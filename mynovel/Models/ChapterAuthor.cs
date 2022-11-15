using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mynovel.Models
{
    public class ChapterAuthor
    {

        public int chapterId { get; set; }
        public Chapter chapter { get; set; }

        public int authorId { get; set; }
        public Author author { get; set; }
    }
}
