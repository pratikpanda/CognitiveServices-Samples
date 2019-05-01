using CognitiveServices.Samples.ComputerVision.Helpers;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CognitiveServices.Samples.ComputerVision.Services
{
    public class ThumbnailGeneratorService
    {
        private HttpClient httpClient;

        public ThumbnailGeneratorService()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", ServiceHelper.SubscriptionKey);
        }

        public async Task<byte[]> GenerateThumbnailAsync(byte[] imageData, int width, int height, bool smartCropping)
        {
            var queryStringParameters = $"width={width.ToString()}&height={height.ToString()}&smartCropping={smartCropping.ToString().ToLower()}";
            var requestUri = ServiceHelper.Endpoint + "generateThumbnail" + queryStringParameters;
            HttpResponseMessage httpResponseMessage = null;
            using (ByteArrayContent content = new ByteArrayContent(imageData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                httpResponseMessage = await httpClient.PostAsync(requestUri, content);
                return await httpResponseMessage.Content.ReadAsByteArrayAsync();
            }
        }
    }
}
