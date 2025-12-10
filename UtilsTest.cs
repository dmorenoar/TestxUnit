using Tools;

namespace TestUtilsxUnit
{
    public class UtilsTest
    {
        [Fact]
        [Trait("Category", "Maths")]
        public void Add_ShouldReturnCorrectSum()
        {
            //Arange
            int num = 0;
            int num2 = 2;

            //Act
            int result = Utils.Add(num, num2);

            //Assert
            Assert.Equal(2, result);
        }

        [Theory]
        [Trait("Category", "Logic")]
        [InlineData(0, true)]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(3, false)]
        public void IsEven_ShouldReturnTrue(int num, bool expected)
        {
            Assert.Equal(expected,Utils.IsEven(num));
        }

        [Fact]
        [Trait("Category", "Logic")]
        public void IsEven_ShouldReturnFalse()
        {
            //Arrange
            int num = 3;

            //Act
            bool result = Utils.IsEven(num);

            //Assert
            Assert.False(result);
        }

        [Fact]
        [Trait("Category","NullCheck")]
        public void Reverse_ShouldReturnNull_WhenInputIsNull()
        {
            //Arrange
            string text = null;
            //Act
            string result = Utils.Reverse(text);
            //Assert
            Assert.Null(result);
        }

        [Theory]
        [Trait("Category", "String")]
        [InlineData("hello", "olleh")]
        [InlineData("world", "dlrow")]
        public void Reverse_ShouldReturnReversedString(string input, string expected)
        {
            //Act
            string result = Utils.Reverse(input);
            //Assert
            Assert.Equal(expected, result);
        }
    }
}
