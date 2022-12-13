using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class AddString 
    { 
        public static int Add(string debut)
        {
            var parties = debut.Split(',');
            var firstInt = int.Parse(parties.First());
            var secondInt = int.Parse(parties.Last());
            return firstInt + secondInt;
        }
    }
}
