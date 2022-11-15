using mynovel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mynovel.Infrastructure
{
   public interface INovel
    {
        List<Novel> GetAll();
        Novel GetById(int Id);
        void Insert(Novel novel);
        void Update(Novel novel);
        void Delete(Novel novel);
        void Save();

    }
}
