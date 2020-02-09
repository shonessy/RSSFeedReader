using Microsoft.AspNetCore.Mvc;
using RssFeedReader.Controllers;
using RssFeedReader.RssServerFeeds;
using RssFeedReader.RssServerFeeds.DTOs;
using RssFeedReader.Web.Host.Models.RssServerFeed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RssFeedReader.Web.Host.Controllers.RssServerFeed
{
    public class RssServerFeedController : RSSFeedReaderControllerBase
    {
        private readonly IRssServerFeedService _rssServerFeedService;

        public RssServerFeedController(IRssServerFeedService rssServerFeedService)
        {
            _rssServerFeedService = rssServerFeedService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllRssServerFeeds(GetAllRssServerFeedInput input)
        {
            var output = await _rssServerFeedService.GetAll(input);

            var ret = new RssServerFeedListViewModel(output);

            return View(ret);
        }

        [HttpGet]
        public async Task<ActionResult> GetById(int Id)
        {
            var ret = await _rssServerFeedService.GetById(Id);

            return View(ret);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CreateRssServerFeedInput data)
        {
            await _rssServerFeedService.Create(data);
            return View();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int Id)
        {
            await _rssServerFeedService.Delete(Id);
            return View();
        }
    }
}
