using System;
using System.Net.Security;
using static StringCalculator.AddString;

namespace StringCalculator.test
{
    public class UnitTest1
    {
        [Theory(DisplayName = "ETANT DONNE une chaine \"x,y\" " +
                              "QUAND on appelle Add " +
                              "ALORS on a x + y")]
        [InlineData(1, 2)]
        public void TestAjouter(int x, int y)
        {
            // ETANT une chaîne "1, 2"
            var debut = $"{x}, {y}";
            // QUAND on appelle add
            var result = Add(debut);
            // ALORS on a x+y
            Assert.Equal(x + y, result);
        }

        [Theory(DisplayName = "ETANT DONNE une chaine \"x,y,z\" " +
                                      "QUAND on appelle Add " +
                                      "ALORS on a somme de plusieurs nombres")]

        [InlineData(1, 2, 3)]
        public void TestPlusDeDeuxNombres(int x, int y, int z) 
        {
            // ETANT n nombres "1, 2, 3"
            var debut = $"{x}, {y}, {z}";
            // QUAND on appelle add
            var result = AddString.Add(debut);
            // ALORS on a somme de plusieurs nombres
            Assert.Equal(x + y + z, result);
        }


        [Fact]
        public void TestSaut_de_Lignes()
        {

            // ETANT DONNE une liste de nombres de la forme "1,2,..."comportant un saut de ligne
            var debut = string.Join(',', new int[] { 1, 2, 3 });
            var entréeAvecSautDeLigne = Add(debut);

            // QUAND on appelle Add
            var resultAvecSautDeLigne = Add(debut);

            // ALORS le résultat est le même que pour un debut n'en ayant pas

            var resultSansSautDeLigne = Add(debut);

            Assert.Equal(resultSansSautDeLigne, resultAvecSautDeLigne);
        }

        [Fact]

        public void TestNombreNegatifs()
        {
            // ETANT DONNE une liste de nombres de la forme "1,2,..."comportant un nombre négatif
            var debut = string.Join(',', new int[] { -1, 2, 3 });

            // QUAND on appelle Add
            void Act() => AddString.Add(debut);

            // ALORS une exception est lancée, contenant le nombre et sa position
            var exception = Assert.Throws<NombreNegatifs>(Act);

            Assert.Equal(-1, exception.nombreFautif);
            Assert.Equal(-1, exception.position);
        }

        [Fact]
        public void NombresSuperieurs()
        {
            // ETANT DONNE une liste de nombres de la forme "1,2,..."comportant un nombre supérieur à 1000

            var nombres = new int[] { 1001, 2, 3 };
            var debut = string.Join(',', nombres);

            // QUAND on appelle Add

            var resultAvecNombresSuperieurs = AddString.Add(debut);

            // ALORS le résultat est le même que pour une entrée n'en ayant pas

            var nombresSanNombresSuperieur = nombres.Where(nombres => nombres <= 1000);
            var entréeSansGrandNombres = string.Join(',', nombresSanNombresSuperieur);
            var résultatSansNombresSuperieurs = AddString.Add(entréeSansGrandNombres);

            Assert.Equal(résultatSansNombresSuperieurs, resultAvecNombresSuperieurs);

        }
    }
}
