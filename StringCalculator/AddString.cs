using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class AddString
    {
        /* public static int Add(string debut)
         {
             var parties = debut.Split(',');
             var first = int.Parse(parties.First());
             var second = int.Parse(parties.Last());
             return first + second;
         } */

        public static int Add(string debut)
        {
            var délimitateur = ",";
            var spécifieDélimitateurc = debut.StartsWith("//");

           

            var parties = debut
                .Split(délimitateur)
                .Select(int.Parse)
                .Where(nombres => nombres <= 1000)
                .ToList();

            var nombreNégatif = parties.FirstOrDefault(nombre => nombre < 0);

            if (nombreNégatif == default) return parties.Sum();

            var positionNombreNégatif = parties.IndexOf(nombreNégatif) + 1;
            throw new NombreNegatifs(nombreNégatif, positionNombreNégatif);


            //var parties = debut.Split(',');

            //return parties.Select(int.Parse.Sum();
        }
    }
}