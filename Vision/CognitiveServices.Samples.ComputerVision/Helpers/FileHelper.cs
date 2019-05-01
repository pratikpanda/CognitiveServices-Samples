using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CognitiveServices.Samples.ComputerVision.Helpers
{
    public static class FileHelper
    {
        public static byte[] GetContentAsByteArray(string contentFilePath)
        {
            FileStream fileStream = new FileStream(contentFilePath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            return binaryReader.ReadBytes((int)fileStream.Length);
        }

        public static void WriteByteArrayDataToFile(byte[] data, string filePath)
        {
            using (BinaryWriter binaryWriter = new BinaryWriter(new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write)))
            {
                binaryWriter.Write(data);
            }
        }
    }
}
