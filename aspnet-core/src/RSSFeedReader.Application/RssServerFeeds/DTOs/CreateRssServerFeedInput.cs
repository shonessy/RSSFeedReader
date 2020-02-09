using System;
using System.Collections.Generic;
using System.Text;

namespace RssFeedReader.RssServerFeeds.DTOs
{
    public class CreateRssServerFeedInput
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }
    }
}
