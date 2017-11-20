using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuelSDK.SMS
{
    /// <summary>
    /// Class represent SMS history information.
    /// </summary>
    public class SMSHistory
    {
        /// <summary>
        /// The type of the SMS: MT(Mobile Terminating) or MO(Mobile Originating).
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Actual message that is sent/received to/from the subscriber via SMS.
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// The date/time when the SMS is sent/received.
        /// </summary>
        public string Date { get; set; }
    }
}
