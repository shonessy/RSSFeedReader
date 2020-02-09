using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using RssFeedReader.RssServerFeedTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace RssFeedReader.RssServerFeeds.DTOs
{
    [AutoMapFrom(typeof(RssServerFeed))]
    public class RssServerFeedDto : EntityDto, IHasCreationTime, IHasModificationTime
    {
        public string Title { get; set; }

        public DateTime PubDate { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime? LastModificationTime { get; set; }
    }
}
