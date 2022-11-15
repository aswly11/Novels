using mynovel.Data;
using mynovel.Infrastructure;
using mynovel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mynovel.Service
{
    public class ChaptersRepository : IChapter
    {
        private DBContext _context;

        public ChaptersRepository(DBContext context)
        {
            _context = context;
        }

        public void Delete(Chapter chapter)
        {
            _context.Chapters.Remove(chapter);

        }

        public List<Chapter> GetAll()
        {
            return _context.Chapters.ToList();

        }

        public Chapter GetById(int Id)
        {
            return _context.Chapters.Where(x => x.Id == Id).FirstOrDefault();
        }

        public void Insert(Chapter chapter)
        {
            _context.Chapters.Add(chapter);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Chapter chapter)
        {
            _context.Chapters.Update(chapter);
        }
    }
}
