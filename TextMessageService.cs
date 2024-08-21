using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace TextBeltTestApp
{
    public class TextMessageService
    {
        private readonly string _apiUrl;
        private readonly string _apiKey;

        public TextMessageService(string apiUrl, string apiKey)
        {
            _apiUrl = apiUrl ?? throw new ArgumentNullException(nameof(apiUrl));
            _apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
        }

        public void SendMessage(string phoneNumber, string message, string sender)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentException("Phone number cannot be null or empty", nameof(phoneNumber));
            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentException("Message cannot be null or empty", nameof(message));
            if (string.IsNullOrWhiteSpace(sender))
                throw new ArgumentException("Sender cannot be null or empty", nameof(sender));

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var requestParameters = new Dictionary<string, string>
                    {
                        { "phone", phoneNumber },
                        { "message", message },
                        { "key", _apiKey },
                        { "sender", sender }
                    };

                    var content = new FormUrlEncodedContent(requestParameters);
                    HttpResponseMessage response = client.PostAsync(_apiUrl, content).GetAwaiter().GetResult();

                    if (response.IsSuccessStatusCode)
                    {
                        string result = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode}, {response.ReasonPhrase}");
                    }
                }
            }
            catch (HttpRequestException httpEx)
            {
                Console.WriteLine($"An error occurred while sending the message: {httpEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}