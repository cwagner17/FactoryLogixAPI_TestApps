using FactoryLogix.xTend.Core;
using FactoryLogix.xTend.DataObjects;
using FactoryLogix.xTend.Services;
using System;
using System.Configuration;


namespace FlxIssue
{
    internal static class Program
    {
        private static IReportingServices _reportingService = new FactoryLogix.xTend.Analytics.ReportingServices();
        private static Guid _sessionId;

        private static void Main()
        {
            //
            var serverAddress = ConfigurationManager.AppSettings["FlxApplicationServerName"];
            var username = ConfigurationManager.AppSettings["FlxServiceAccountName"];
            var password = ConfigurationManager.AppSettings["FlxServiceAccountPassword"];

            var testPartNumber = ConfigurationManager.AppSettings["TestPartNumber"];
            var testSerialNumber = ConfigurationManager.AppSettings["TestSerialNumber"];

            var conn = new ConnectionServices();
            var dbConnName = "FactoryLogix2019";

            _sessionId = conn.Connect(serverAddress, username, password, dbConnName);

            
            var assemblyParameter = new ParameterValue
            {
                DataSourceId = "WIP 1",
                ParameterId = "Assembly"
            };
            assemblyParameter.Values.Add(testPartNumber);

            var serialNumberParameter = new ParameterValue
            {
                DataSourceId = "WIP 1",
                ParameterId = "Serial Number"
            };
            serialNumberParameter.Values.Add(testSerialNumber);

            

            //System.ServiceModel.QuotaExceededException is thrown using GetDataTemplate
            var template = _reportingService.GetDataTemplate(_sessionId, "whippy");

            var result = _reportingService.RunDataTemplate(_sessionId, template.Id, new [] { assemblyParameter, serialNumberParameter });

            Console.ReadKey();
        }
    }
}
