using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mynovel.Models
{
    public class Chapter
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Number { get; set; }

        public string Title { get; set; }
        public List<ChapterAuthor> ChapterAuthors { get; set; }

        public string Content { get; set; }
        public List<FeedBack> FeedBacks { get; set; }
        public int NovelId { get; set; }
        [ForeignKey("NovelId")]
        public Novel Novel { get; set; }

        public DateTime Publish_date{ get; set; }
        public int Views { get; set; }

    }
}