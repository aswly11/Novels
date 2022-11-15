using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mynovel.Models
{
    public class Novel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<AuthorNovel> AuthorNovels { get; set; }
        public string Description { get; set; }
        public List<Chapter> Chapters { get; set; }
        public List<FeedBack> FeedBacks { get; set; }
        public float Rate { get; set; }
        public string profile { get; set; }
        public DateTime Publish_Year { get; set; }

    }
}
