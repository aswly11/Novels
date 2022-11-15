using mynovel.Data;
using mynovel.Infrastructure;
using mynovel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mynovel.Service
{
    public class UsersRepository : IUser
    {
        private DBContext _context;

        public UsersRepository(DBContext context)
        {
            _context = context;
        }

        public void Delete(Reader user)
        {
            _context.Users.Remove(user);
        }

        public List<Reader> GetAll()
        {
            return _context.Users.ToList();
        }

        public Reader GetById(int Id)
        {
            throw new NotImplementedException();
        }

        //public Reader GetById(int Id)
        //{
        //    return _context.Users.Where(x => x.Id == Id).FirstOrDefault();
        //}

        public void Insert(Reader user)
        {
            _context.Users.Add(user);
        }

        public Reader IsAuthorized(string username, string password)
        {
            return _context.Users.Where(x => x.UserName == username && x.Password == password).FirstOrDefault();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Reader user)
        {
            _context.Users.Update(user);
        }
    }
}
