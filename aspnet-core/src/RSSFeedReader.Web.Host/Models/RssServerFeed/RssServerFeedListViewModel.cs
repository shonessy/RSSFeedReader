using Abp.Application.Services.Dto;
using RssFeedReader.RssServerFeeds.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RssFeedReader.Web.Host.Models.RssServerFeed
{
    public class RssServerFeedListViewModel
    {
        public ListResultDto<RssServerFeedDto> RssServerFeeds { get; }
        public RssServerFeedListViewModel(ListResultDto<RssServerFeedDto> rssServerFeeds)
        {
            RssServerFeeds = rssServerFeeds;
        }

    }
}
