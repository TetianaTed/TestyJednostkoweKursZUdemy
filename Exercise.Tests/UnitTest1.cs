namespace Exercise.Tests
{
    public class UnitTest1
    {
        //NazwaMetody_Scenariusz_Rezultat
        //Append_ForTwoStrings_ReturnsConccatenatString()

        [Fact] 
        public void ReverseWords_ForStrings_ReturnsReversedWords()
        {
            //arrange

            string givenUserString = "ala ma kota";

            //act

            string result = Exercise.StringHelper.ReverseWords(givenUserString);

            //assert

            Assert.Equal("kota ma ala", result);
        }

        [Theory]
        [InlineData("ala ma kota", "kota ma ala")]
        [InlineData("to jest test", "test jest to")]
        public void ReverseWords_ForStrings_ReturnsReversedWords_Parametrizied(string givenUserWords,                                          
                                                                               string expectedRevercedWords)
        {
            //act

            string result = Exercise.StringHelper.ReverseWords(givenUserWords);

            //assert

            Assert.Equal(result, expectedRevercedWords);
        }

        [Fact]
        public void IsPalindrome_ForString_ReturnsReversedPalindromeString()
        {
            //arrange

            string givenUserString = "ala";

            //act

            bool result = Exercise.StringHelper.IsPalindrome(givenUserString);

            //assert

            Assert.True(result);
        }

        [Theory]
        [InlineData("ola", false)]
        [InlineData("ala", true)]
        [InlineData("Ala", false)]
        [InlineData("kajak", true)]
        public void IsPalindrome_ForString_ReturnsReversedPalindromeString_Parametrizied(string givenUserWord,
                                                                       bool expectedBoolianValue)
        {
            //act

            bool result = Exercise.StringHelper.IsPalindrome(givenUserWord);

            //assert

            Assert.Equal(result, expectedBoolianValue);    
        }
    }
}