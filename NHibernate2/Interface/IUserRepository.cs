using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate2.Entity;

namespace NHibernate2.Interface
{
    public interface IUserRepository
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);
        User GetById(int id);
        IEnumerable<User> GetAll();


    }
}
