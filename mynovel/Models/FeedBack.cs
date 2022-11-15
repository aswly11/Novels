
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mynovel.Models
{
    public class FeedBack
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string content { get; set; }
        public Reader user { get; set; }
        public Author author { get; set; }
        public DateTime Created_date { get; set; }
    }
}