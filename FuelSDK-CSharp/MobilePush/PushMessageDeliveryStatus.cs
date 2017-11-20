using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace FuelSDK.MobilePush
{
    public class PushMessageDeliveryStatus
    {
        public HttpStatusCode Code { get; set; }
        public string MessageId { get; set; }
        public int Count { get; set; }
        public string CreateDate { get; set; }
        public string CompleteDate { get; set; }
        public string ScheduledDate { get; set; }
        public string Status { get; set; }
        public string TriggeredSendStatus { get; set; }
    }
}
