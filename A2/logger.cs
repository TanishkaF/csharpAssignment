using System;
using System.Configuration;
using System.IO;

namespace CRUDLOG
{
    internal class Logger
    {
        public static void AddData(Exception inputData)
        {
            //string fileName = @"C:\Users\tanishkaf\Desktop\dotnetprac\A2\logFile.txt";
            string logFilePath = ConfigurationManager.AppSettings["LogFilePath"];


            string logMessage = $"Time: {DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")}{Environment.NewLine}" +
                                "-----------------------------------------------------------" +
                                $"{Environment.NewLine}Exception Details:{Environment.NewLine}" +
                                $"Message: {inputData.Message}{Environment.NewLine}" +
                                $"StackTrace: {inputData.StackTrace}{Environment.NewLine}" +
                                $"Source: {inputData.Source}{Environment.NewLine}" +
                                $"TargetSite: {inputData.TargetSite?.ToString()}{Environment.NewLine}" +
                                "-----------------------------------------------------------" +
                                $"{Environment.NewLine}";

            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine(logMessage);
            }
        }
    }

}