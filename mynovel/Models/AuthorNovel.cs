using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mynovel.Models
{
    public class AuthorNovel
    {

        public int novelId { get; set; }
        public Novel novel { get; set; }

        public int AuthorId { get; set; }
        public Author author { get; set; }
    }
}
