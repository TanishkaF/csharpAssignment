using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDLOG
{
    internal class logger
    {
        public static void addData(Exception inputData)
        {
            string fileName = @"C:\Users\tanishkaf\Desktop\dotnetprac\A2\logFile.txt";

            string logMessage = $"Time: {DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")}{Environment.NewLine}" +
                                "-----------------------------------------------------------" +
                                $"{Environment.NewLine}Exception Details:{Environment.NewLine}" +
                                $"Message: {inputData.Message}{Environment.NewLine}" +
                                $"StackTrace: {inputData.StackTrace}{Environment.NewLine}" +
                                $"Source: {inputData.Source}{Environment.NewLine}" +
                                $"TargetSite: {inputData.TargetSite?.ToString()}{Environment.NewLine}" +
                                "-----------------------------------------------------------" +
                                $"{Environment.NewLine}";

            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine(logMessage);
            }
        }
    }

}