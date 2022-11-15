using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mynovel.Models
{
    public class Author:IdentityUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Name { get; set; }
        public AuthorType authorType { get; set; }

        public string Password { get; set; }
        public List<ChapterAuthor> ChapterAuthors { get; set; }
        public List<AuthorNovel> AuthorNovels { get; set; }


    }
}
