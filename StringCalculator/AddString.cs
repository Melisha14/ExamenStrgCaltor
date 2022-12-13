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
            var first = int.Parse(parties.First());
            var second = int.Parse(parties.Last());
            return first + second;
        }
    }
}
