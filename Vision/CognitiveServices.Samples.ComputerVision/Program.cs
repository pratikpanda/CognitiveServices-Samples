using CognitiveServices.Samples.ComputerVision.Helpers;
using CognitiveServices.Samples.ComputerVision.Services;
using System;

namespace CognitiveServices.Samples.ComputerVision
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string imageFilePath = @".\Assets\dirtCar.jpg";
            // Analyze Image
            var imageData = FileHelper.GetContentAsByteArray(imageFilePath);
            var service = new ImageAnalyzerService();
            var analysis = service.AnalyzeImageAsync(imageData).Result;
            service.WriteAnalysis(analysis);
            Console.ReadKey();
        }
    }
}
