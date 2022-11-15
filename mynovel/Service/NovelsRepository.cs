using Microsoft.EntityFrameworkCore;
using mynovel.Data;
using mynovel.Infrastructure;
using mynovel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mynovel.Service
{
    public class NovelsRepository : INovel
    {
        private DBContext _context;

        public NovelsRepository(DBContext context)
        {
            _context = context;
        }

        public void Delete(Novel novel)
        {
            _context.Novels.Remove(novel);
        }
         
        public List<Novel> GetAll()
        {
             return _context.Novels.ToList();
        }

        public Novel GetById(int Id)
        {
            return _context.Novels.Where(x=>x.Id==Id).FirstOrDefault();

        }

        public void Insert(Novel novel)
        {
            _context.Novels.Add(novel);

        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Novel novel)
        {
            _context.Novels.Update(novel);
        }
    }
}
