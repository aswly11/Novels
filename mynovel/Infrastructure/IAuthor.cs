using mynovel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mynovel.Infrastructure
{
    public interface IAuthor
    {
        List<Author> GetAll();
        Author GetById(int Id);
        void Insert(Author author);
        void Update(Author author);
        void Delete(Author author);
        void Save();
    }
}
