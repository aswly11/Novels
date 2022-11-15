using mynovel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mynovel.Infrastructure
{
    public interface IChapter
    {
        List<Chapter> GetAll();
        Chapter GetById(int Id);
        void Insert(Chapter chapter);
        void Update(Chapter chapter);
        void Delete(Chapter chapter);
        void Save();
    }
}
