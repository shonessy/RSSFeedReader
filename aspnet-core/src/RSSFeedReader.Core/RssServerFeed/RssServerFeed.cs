using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RssFeedReader.RssServerFeedTable
{
    [Table("RssServerFeed")]
    public class RssServerFeed : Entity, IHasCreationTime, IHasModificationTime
    {
        public const int DefaultStringSize = 200;

        [Required]
        [StringLength(DefaultStringSize)]
        public string Title { get; set; }

        [Required]
        public DateTime PubDate { get; set; }

        [Required]
        [StringLength(DefaultStringSize)]
        public string Author { get; set; }

        [Required]
        [StringLength(DefaultStringSize)]
        public string Description { get; set; }

        [Required]
        [MaxLength]
        public string Content { get; set; }

        [Required]
        public DateTime CreationTime { get; set; }

        public DateTime? LastModificationTime { get; set; }

        public RssServerFeed()
        {
            var time = Clock.Now;
            PubDate = time;
            CreationTime = time;
            LastModificationTime = time;
        }

        public RssServerFeed(string title, string author, string description, string content) : this()
        {
            Title = title;
            Author = author;
            Description = description;
            Content = content;
        }
    }
}
