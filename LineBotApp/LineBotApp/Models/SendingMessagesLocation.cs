using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LineBotApp.Models
{
    public class SendingMessagesLocation
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
            public Location location { get; set; }
        }

        public class Location
        {
            public string title { get; set; }
            public float latitude { get; set; }
            public float longitude { get; set; }
        }

    }
}