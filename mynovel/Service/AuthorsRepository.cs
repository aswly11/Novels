using mynovel.Data;
using mynovel.Infrastructure;
using mynovel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mynovel.Service
{
    public class AuthorsRepository : IAuthor
    {
        private DBContext _context;

        public AuthorsRepository(DBContext context)
        {
            _context = context;
        }

        public void Delete(Author author)
        {
            _context.Authors.Remove(author);
        }

        public List<Author> GetAll()
        {
            return _context.Authors.ToList();
        }

        public Author GetById(int Id)
        {
            throw new NotImplementedException();
        }

        //public Author GetById(int Id)
        //{
        //    return _context.Authors.Where(x => x.Id == Id).FirstOrDefault();
        //}

        public void Insert(Author author)
        {
            _context.Authors.Add(author);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Author author)
        {
            _context.Authors.Update(author);
        }
    }
}
