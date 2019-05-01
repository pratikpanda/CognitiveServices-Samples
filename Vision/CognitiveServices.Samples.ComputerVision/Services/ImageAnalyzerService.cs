using CognitiveServices.Samples.ComputerVision.Helpers;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using CognitiveServices.Samples.Common;
using System.IO;

namespace CognitiveServices.Samples.ComputerVision.Services
{
    public class ImageAnalyzerService
    {
        private HttpClient httpClient;

        public ImageAnalyzerService()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", ServiceHelper.SubscriptionKey);
        }

        public async Task<string> AnalyzeImageAsync(byte[] imageData)
        {
            var queryStringParameters = "visualFeatures=Categories,Description,Color&language=en";
            var requestUri = ServiceHelper.Endpoint + "analyze" + "?" + queryStringParameters;
            HttpResponseMessage httpResponseMessage = null;
            using (ByteArrayContent content = new ByteArrayContent(imageData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                httpResponseMessage = await httpClient.PostAsync(requestUri, content);
                return await httpResponseMessage.Content.ReadAsStringAsync();
            }
        }

        public void WriteAnalysis(string analysis)
        {
            Console.WriteLine(analysis.Prettify());
        }
    }
}
