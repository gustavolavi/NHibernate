using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate2.Config;
using NHibernate2.Entity;
using NHibernate2.Interface;

namespace NHibernate2.Repository
{
    class UserRepository : IUserRepository
    {
        public void Add(User user)
        {
            using (var sessao = new SessionConfig().OpenSession())
            {
                using (var transaction =sessao.Transaction)
                {
                    sessao.Save(user);
                    transaction.Commit();
                }
            }
        }

        public void Update(User user)
        {
            using (var sessao = new SessionConfig().OpenSession())
            {
                using (var transaction = sessao.Transaction)
                {
                    sessao.Update(user);
                    transaction.Commit();
                }
            }
        }

        public void Delete(User user)
        {
            using (var sessao = new SessionConfig().OpenSession())
            {
                using (var transaction = sessao.Transaction)
                {
                    sessao.Delete(user);
                    transaction.Commit();
                }
            }
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
