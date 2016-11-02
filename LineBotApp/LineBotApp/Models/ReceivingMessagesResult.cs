using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LineBotApp.Models
{
    public class ReceivingMessagesResult
    {

        public class Rootobject
        {
            public Result[] result { get; set; }
        }

        public class Result
        {
            public string from { get; set; }
            public int fromChannel { get; set; }
            public string[] to { get; set; }
            public int toChannel { get; set; }
            public string eventType { get; set; }
            public string id { get; set; }
            public Content content { get; set; }
        }

        public class Content
        {
            public object location { get; set; }
            public string id { get; set; }
            public int contentType { get; set; }
            public string from { get; set; }
            public long createdTime { get; set; }
            public string[] to { get; set; }
            public int toType { get; set; }
            public object contentMetadata { get; set; }
            public string text { get; set; }
        }



    }
}