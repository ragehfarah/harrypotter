using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    internal class Slytherin : House
    {
        protected override bool HasCorrectPasswordFormat(string newPassword)
        {

            char[] constant = new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k','l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
            char[] vowel = new char[] { 'a', 'e', 'i', 'o', 'u' };
            if (newPassword.Length < 8) return false;
            if (!newPassword.StartsWith("constant")) return true;
            if (!newPassword.EndsWith("constant")) return true;
            return false;
        }
      
    }
}
