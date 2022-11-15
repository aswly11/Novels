using mynovel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mynovel.Infrastructure
{
    public interface IUser
    {
        List<Reader> GetAll();
        Reader GetById(int Id);
        void Insert(Reader user);
        void Update(Reader user);
        void Delete(Reader user);
        void Save();

        Reader IsAuthorized(string username, string password);
    }
}
