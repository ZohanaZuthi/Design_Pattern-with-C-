using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid_principles.SRP
{
    public class UserRepository
    {
        public void Save(User user)
        {
            Console.WriteLine("User saved to database");
        }
    }
}