using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LineBotApp.Models
{
    public class SendingMessagesText
    {

        public class Rootobject
        {
            public string[] to { get; set; }
            public int toChannel { get; set; }
            public string eventType { get; set; }
            public Content content { get; set; }
        }

        public class Content
        {
            public int contentType { get; set; }
            public int toType { get; set; }
            public string text { get; set; }
        }

    }
}