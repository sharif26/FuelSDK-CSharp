﻿using NUnit.Framework;
using System;
using FuelSDK;
using Newtonsoft.Json.Linq;
using FuelSDK.SMS;
using System.Net;

namespace FuelSDK.Test
{
    [TestFixture()]
    public class QueueMOTest
    {

        ETClient client;
        QueueMO queue;
        QueueMOResponse qResponse;


        [OneTimeSetUp]
        public void Setup()
        {
            client = new ETClient();
        }



        [Test()]
        public void QueueMessageForMobileNumbers()
        {
            queue = new QueueMO
            {
                AuthStub = client,
                MobileNumbers = new[] { "12055550100", "12515550100" },
                MessageText = "MC_SDK_NEW",
                ShortCode = "10766790"
            };
            qResponse = queue.QueueMOForMobileNumbers();
            Assert.AreEqual(qResponse.Code, HttpStatusCode.Accepted);

        }

        [Test()]
        public void QueueMessageForSubscribers()
        {
            queue = new QueueMO
            {
                AuthStub = client,
                Subscribers = new SMSSubscriber[] 
                { 
                    new SMSSubscriber 
                    { 
                        MobileNumber = "12055550100", 
                        SubscriberKey = "12055550100" 
                    }, 
                    new SMSSubscriber 
                    { 
                        MobileNumber = "12515550100", 
                        SubscriberKey = "12515550100" 
                    } 
                },
                MessageText = "MC_SDK",
                ShortCode = "10766790"
            };
            qResponse = queue.QueueMOForSubscribers();
            Assert.AreEqual(qResponse.Code, HttpStatusCode.Accepted);

        }

        [Test()]
        public void GetQueueMODeliveryStatus()
        {
            QueueMessageForMobileNumbers();
            foreach (var resp in qResponse.Results)
            {
                var response = queue.GetDeliveryStatus(resp.Identifier);
                Assert.IsNotNull(response);
            }
        }

        [Test()]
        public void GetQueueMOTrackingHistory()
        {
            QueueMessageForSubscribers();
            foreach (var resp in qResponse.Results)
            {
                var response = queue.GetTrackingHistory(resp.Identifier);
                Assert.IsNotNull(response);
            }
        }

    }


}
