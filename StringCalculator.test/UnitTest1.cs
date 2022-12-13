using System.Net.Security;

namespace StringCalculator.test
{
    public class UnitTest1
    {
        [Theory(DisplayName = "ETANT DONNE une chaine \"x,y\" " +
                              "QUAND on appelle Add " +
                              "ALORS on a x + y")]
        [InlineData(1,2)]
        public void TestAjouter(int x, int y)
        {
            // ETANT une chaîne "1, 2"
            var debut = $"{x}, {y}";
            // QUAND on appelle add
            var result = AddString.Add(debut);
            // ALORS on a x+y
            Assert.Equal(x+y, result);
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
        /*
                [Theory(DisplayName = "ETANT DONNE une chaine \"x,y\" " contenant un saut_de_ligne+
                                      "QUAND on appelle Add " +
                                      "ALORS on obtient x + y")]
                [InlineData()]
                public void TestSaut_de_Lignes()
                {

                }*/
    }

}