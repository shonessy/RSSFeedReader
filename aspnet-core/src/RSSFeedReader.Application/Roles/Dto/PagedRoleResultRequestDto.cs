using Abp.Application.Services.Dto;

namespace RssFeedReader.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

