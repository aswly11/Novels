using mynovel.Data;
using mynovel.Infrastructure;
using mynovel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mynovel.Service
{
    public class FeedBackRepository : IFeedBack
    {
        private DBContext _context;

        public FeedBackRepository(DBContext context)
        {
            _context = context;
        }

        public void Delete(FeedBack feedBack)
        {
            _context.FeedBacks.Remove(feedBack);
        }

        public List<FeedBack> GetAll()
        {
            return _context.FeedBacks.ToList();
        }

        public FeedBack GetById(int Id)
        {
            return _context.FeedBacks.Where(x => x.Id == Id).FirstOrDefault();
        }

        public void Insert(FeedBack feedBack)
        {
            _context.FeedBacks.Add(feedBack);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(FeedBack feedBack)
        {
            _context.FeedBacks.Update(feedBack);
        }
    }
}
