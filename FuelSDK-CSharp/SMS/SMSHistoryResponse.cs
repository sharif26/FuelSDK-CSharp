using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuelSDK.SMS
{
    /// <summary>
    /// Class represent SMS tracking history information.
    /// </summary>
    public class SMSHistoryResponse
    {
        /// <summary>
        /// Number of the SMS messages sent to the subscriber.
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// The date time when the Queued MO is created.
        /// </summary>
        public string CreateDate { get; set; }
        /// <summary>
        /// Status of the SMS message sent to the subscriber.
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// An array of history information.
        /// </summary>
        public SMSHistory[] History { get; set; }
    }
}
