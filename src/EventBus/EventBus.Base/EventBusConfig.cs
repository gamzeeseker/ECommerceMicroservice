﻿using EventBus.Base.Enums;

namespace EventBus.Base
{
    public class EventBusConfig
    {
        public int ConnectionRetryCount { get; set; } = 5;

        public string DefaultTopicName { get; set; } = "ECommerceMicroserviceEventBus";

        public string EventBusConnectionString { get; set; } = String.Empty;

        public string SubscriberClientAppName { get; set; } = String.Empty;

        public string EventNamePrefix { get; set; } = String.Empty;

        public string EventNameSuffix { get; set; } = "IntegrationEvent";

        public EventBusType EventBusType { get; set; } = EventBusType.RabbitMQ;

        public object Connection { get; set; }

        public bool DeleteEventPrefix => !String.IsNullOrEmpty(EventNamePrefix);

        public bool DeleteEventSuffix => !String.IsNullOrEmpty(EventNameSuffix);
    }
}
