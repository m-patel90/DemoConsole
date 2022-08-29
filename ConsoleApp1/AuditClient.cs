//using Bct.Common.Auditing.Client;
//using Bct.Common.Auditing.Contract;
//using Bct.Common.Auditing.Contract.Entities;
//using Bct.Common.MessageBus;
//using Bct.Common.NServiceBus;
//using Microsoft.Extensions.Logging;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    public class AuditClient
//    {
//        public void AuditingClient()
//        {
//            Task.Run(async () => await InitializeAuditClient()).Wait();
//        }
//        private async Task InitializeAuditClient()
//        {
//            var hostingConfig = new HostingConfiguration
//            {
//                RabbitMqConnectionString = "host=localhost;username=guest;password=guest;virtualhost=/",
//                EndpointName = Constants.RouteName,
//                LimitMessageProcessingConcurrencyNumProcessors = null,
//                PersistenceType = "MSSQL",
//                ConnectionString = "connectionString",
//                EnablePersistence = false,
//                EnableOutbox = false,
//                EnableMetrics = false,
//                SubscriptionPersisterCachingTimePeriodMinutes = 1,
//                SendOnly = false,
//                EndpointRoutes =
//                              {
//                                  { typeof(Constants).Assembly, Constants.RouteName }
//                              }
//            };

//            var loggerFactory = LoggerFactory.Create(builder => { });
//            var logger = loggerFactory.CreateLogger("TestCategory");

//            var manager = new MessageBusManager(logger);
//            var busControl = await manager.CreateBusAsync(Constants.RouteName, hostingConfig);
//            var client = new AuditingClient(busControl, logger);

//            var auditEntryDataChanged = new List<AuditEntryDataChanged>
//            {
//                new AuditEntryDataChanged
//                {
//                    EntryType = "Example",
//                    OriginId = "Example",
//                    OriginName = "Example",
//                    TenantId = "Example",
//                    ActionTimestampUtc = DateTime.Now,
//                    ByUserId = "Example",
//                }
//            };
//            var resultClientDataChanged = await client.SendAsync(auditEntryDataChanged);
//        }
//    }
//}
