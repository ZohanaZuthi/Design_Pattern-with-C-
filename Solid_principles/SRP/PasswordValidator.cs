using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid_principles.SRP
{
    public class PasswordValidator
    {
        public bool IsValid(string password)
        {
            return password.Length >= 6;
        }
    }
}