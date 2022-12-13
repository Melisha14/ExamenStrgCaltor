namespace StringCalculator.test
{
    public class UnitTest1
    {
        [Theory(DisplayName = "ETANT DONNE une chaine \"x,y\" " +
                              "QUAND on appelle Add " +
                              "ALORS on obtient x + y")]
        [InlineData(1,2)]
        public void TestAjouter(int x, int y)
        {
            // ETANT donné une chaîne "1, 2"
            var debut = $"{x}, {y}";
            // QUAND on appelle add
            var result = AddString.Add(debut);
            // ALORS on a x+y
            Assert.Equal(x+y, result);
        }
    }
}