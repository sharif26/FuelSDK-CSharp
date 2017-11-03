﻿using FuelSDK.SMS;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuelSDK.Test
{
    [TestFixture()]
    public class SMSSendMessageTest
    {
        ETClient client;


        [OneTimeSetUp]
        public void Setup()
        {
            client = new ETClient();
        }

        [SetUp]
        public void SMSSendMessageSetup()
        {
        }

        [Test()]
        public void SendMessageToMobileNumbers()
        {
            SMSMessageContact msgContact = new SMSMessageContact
            {
                MessageId = "MjE6Nzg6MA",
                AuthStub = client,
                MobileNumbers = new[] { "12055550100", "12515550100" },
                Subscribe = true,
                Resubscribe = true,
                Keyword = "DBE05D",
                Override = true,
                MessageText = "Send Message To Mobile Numbers",
                SendTime = DateTime.Now
            };
            var response = msgContact.SendMessage();
            Assert.IsNotNull(response);
        }

        [Test()]
        public void SendMessageToSubscribers()
        {
            SMSSubscriber subs1 = new SMSSubscriber
            {
                MobileNumber = "12055550100",
                SubscriberKey = "12055550100"
            };
            SMSSubscriber subs2 = new SMSSubscriber
            {
                MobileNumber = "12515550100",
                SubscriberKey = "12515550100"
            };

            SMSMessageContact msgContact = new SMSMessageContact
            {
                MessageId = "MjE6Nzg6MA",
                AuthStub = client,
                Subscribers = new SMSSubscriber[] { subs1, subs2 },
                Subscribe = true,
                Resubscribe = true,
                Keyword = "DBE05D",
                Override = true,
                MessageText = "Send Message To Mobile Numbers",
                SendTime = DateTime.Now
            };
            var response = msgContact.SendMessage();
            Assert.IsNotNull(response);
        }

        [Test()]
        public void SendMessageToList()
        {
            SMSMessageList msgList = new SMSMessageList
            {
                MessageId = "MjE6Nzg6MA",
                AuthStub = client,
                TargetListIds = new[] { "9cc85cc3-90b9-e711-80d3-1402ec6b9528" },
                OverrideTemplateTargetLists = true,
                OverrideTemplateExclusionLists = false,
                IgnoreExclusionLists = true,
                OverrideMessageText = true,
                AllowDuplication = false,
                MessageText = "Send Message To Mobile Numbers",
                SendTime = DateTime.Now
            };
            var response = msgList.SendMessageToList();
            Assert.IsNotNull(response);
        }

    }
}
