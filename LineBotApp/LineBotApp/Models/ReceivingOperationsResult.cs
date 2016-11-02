using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LineBotApp.Models
{
    public class ReceivingOperationsResult
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
            public string[] _params { get; set; }
            public int revision { get; set; }
            public int opType { get; set; }
        }



    }
}