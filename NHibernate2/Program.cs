using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate2.Entity;
using NHibernate2.Repository;

namespace NHibernate2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "NHibernate teste";
            var user = new User() {Id = 1,Login = "gustavoTest", Senha = "senha" };

            var ur = new UserRepository();
            try
            {
                Console.WriteLine("tentando cadastrar...");
                ur.Add(user);
                Console.WriteLine("Cadastrou");
                Console.ReadKey();
            }
            catch (Exception erro)
            {
                Console.Clear();
                Console.WriteLine("\n\nErro: " + erro.Message+"\n\n"+ erro);
                Console.ReadKey();
            }

        }
    }
}
