using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RssFeedReader.RssServerFeeds.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RssFeedReader.RssServerFeeds
{
    public interface IRssServerFeedService : IApplicationService
    {
        Task<ListResultDto<RssServerFeedDto>> GetAll(GetAllRssServerFeedInput input);

        Task<RssServerFeedDto> GetById(int Id);

        Task Create(CreateRssServerFeedInput input);

        Task Delete(int Id);
    }
}
