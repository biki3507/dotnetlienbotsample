using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LineBotApp.Models
{
    public class SendingMessagesImage
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
public string originalContentUrl { get; set; }
public string previewImageUrl { get; set; }
}

    }
}