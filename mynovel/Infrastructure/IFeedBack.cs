using mynovel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mynovel.Infrastructure
{
    public interface IFeedBack
    {
        List<FeedBack> GetAll();
        FeedBack GetById(int Id);
        void Insert(FeedBack feedBack);
        void Update(FeedBack feedBack);
        void Delete(FeedBack feedBack);
        void Save();
    }
}
