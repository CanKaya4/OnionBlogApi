using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Domain.Entities
{
    public class Article
    {
        public int ArticleId { get; set; }
        public int Title { get; set; }
        public string Content { get; set; }
        public int CoverImageUrl { get; set; }
        public decimal Rating { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public DateTime RelaseDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string CreatedYear { get; set; }
        public bool Status { get; set; }
    }
}
