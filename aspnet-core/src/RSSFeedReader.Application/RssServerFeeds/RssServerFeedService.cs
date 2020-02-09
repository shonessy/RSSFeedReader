using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RssFeedReader.RssServerFeeds.DTOs;
using RssFeedReader.RssServerFeedTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssFeedReader.RssServerFeeds
{
    public class RssServerFeedService : IRssServerFeedService
    {

        private readonly IRepository<RssServerFeed> _rssServerFeedRepository;
        private readonly Mapper _mapper;

        public RssServerFeedService(IRepository<RssServerFeed> rssServerFeedRepository)
        {
            _rssServerFeedRepository = rssServerFeedRepository;
            var config = new MapperConfiguration(cfg => cfg.CreateMap<RssServerFeed, RssServerFeedDto>());
            _mapper = new Mapper(config);
        }

        public async Task<ListResultDto<RssServerFeedDto>> GetAll(GetAllRssServerFeedInput input)
        {
            var feeds = await _rssServerFeedRepository
                .GetAll()
                .OrderByDescending(t => t.CreationTime)
                .ToListAsync();

            return new ListResultDto<RssServerFeedDto>(
                _mapper.Map<List<RssServerFeedDto>>(feeds)
            );
        }

        public async Task<RssServerFeedDto> GetById(int Id)
        {
            var feed = await _rssServerFeedRepository.GetAsync(Id);
            var ret = _mapper.Map<RssServerFeedDto>(feed);
            return ret;
        }

        public async Task Create(CreateRssServerFeedInput input)
        {
            var obj = new RssServerFeed(input.Title, input.Author, input.Description, input.Content);
            _rssServerFeedRepository.Insert(obj);
            await Task.Run(() => true);
        }

        public async Task Delete(int Id)
        {
            _rssServerFeedRepository.Delete(Id);
            await Task.Run(() => true);
        }
    }
}
