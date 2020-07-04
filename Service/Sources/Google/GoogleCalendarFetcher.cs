using Domain.Schedule;
using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using Application.Interfaces.Service;
using Application.Schedule.Dtos;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;

namespace Service.Sources
{
    public class GoogleCalendarFetcher : IScheduleFetcher
    {
        public GoogleCalendarFetcher() => InitializeAsync();

        public List<EntryDto> GetEntriesFromSource()
        {
            return new List<EntryDto>();
        }

        private async void InitializeAsync()
        {
            UserCredential credential;
            var scopes = new string[] { CalendarService.Scope.CalendarEvents };

            var credentials = await GetCredentials();
            var credentialsBytes = Encoding.ASCII.GetBytes(credentials);
            var credentialsStream = new MemoryStream(credentialsBytes);

            // The file token.json stores the user's access and refresh tokens, and is created
            // automatically when the authorization flow completes for the first time.
            var roamingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var credPath = Path.Combine(roamingDirectory, "MyPersonalAssistant\\token.json");
            credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                GoogleClientSecrets.Load(credentialsStream).Secrets,
                scopes,
                "user",
                CancellationToken.None,
                new FileDataStore(credPath, true));
            Console.WriteLine("Credential file saved to: " + credPath);

            // Create Google Calendar API service.
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                // TODO: Make into an global variable
                ApplicationName = "9NZ6CGKNS6XW",
            });

            // Define parameters of request.
            EventsResource.ListRequest request = service.Events.List("primary");
            request.TimeMin = DateTime.Now;
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 10;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            // List events.
            Events events = request.Execute();
            Console.WriteLine("Upcoming events:");
            if (events.Items != null && events.Items.Count > 0)
            {
                foreach (var eventItem in events.Items)
                {
                    string when = eventItem.Start.DateTime.ToString();
                    if (String.IsNullOrEmpty(when))
                    {
                        when = eventItem.Start.Date;
                    }
                    Console.WriteLine("{0} ({1})", eventItem.Summary, when);
                }
            }
            else
            {
                Console.WriteLine("No upcoming events found.");
            }
            Console.Read();
        }

        private async Task<string> GetCredentials()
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var credentialsUrl = "https://content.jeremykabogo.com/assistant/credentials.json";
                    var httpResponse = await httpClient.GetAsync(credentialsUrl);
                    httpResponse.EnsureSuccessStatusCode();
                    return await httpResponse.Content.ReadAsStringAsync();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
