using CognitiveServices.Samples.ComputerVision.Helpers;
using CognitiveServices.Samples.ComputerVision.Services;
using System;
using System.IO;

namespace CognitiveServices.Samples.ComputerVision
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string imageFilePath = @".\Assets\dirtCar.jpg";
            var imageData = FileHelper.GetContentAsByteArray(imageFilePath);

            //Analyze Image
            //var service = new ImageAnalyzerService();
            //var analysis = service.AnalyzeImageAsync(imageData).Result;
            //service.WriteAnalysis(analysis);

            //Generate Thumbnail
            //var service = new ThumbnailGeneratorService();
            //var thumbnailData = service.GenerateThumbnailAsync(imageData, 80, 50, true).Result;
            //var thumbnailFilePath = string.Format("{0}\\thumbnail_{1:yyyy-MMM-dd_hh-mm-ss}.jpg",
            //    Path.GetDirectoryName(imageFilePath), DateTime.Now);
            //FileHelper.WriteByteArrayDataToFile(thumbnailData, thumbnailFilePath);
            Console.ReadKey();
        }
    }
}
