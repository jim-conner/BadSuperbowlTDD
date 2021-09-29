using System;
using Xunit;

namespace BadSuperbowlTDD.Tests
{
    //test classes must be public
    public class NumberTwoRomanNumeralsTests
    {
        //need to have fact atrribute, and needs to be public
        //Another type of test is Theory so ... [Fact] and [Theory]
        [Fact]
        public void the_num_1_is_translated_into_the_letter_I()
        {
            //Arrange
            var numberToTranslate = 1;
            var expectedResult = "I";
            var translator = new NumberTranslator();

            //Act
            var actualResult = translator.Translate(numberToTranslate);

            //Assert
            if (actualResult != expectedResult)
            {
                throw new Exception($"This is wrong... {actualResult} is not equal to {expectedResult}.");
            }

            //Assert.True(actualResult == expectedResult);
            Assert.Equal(expectedResult, actualResult);

            //Assertion Libraries ...? 

            //throw new Exception("This test is bad a should feel bad about it's choices.");

            //tests pass if no exceptions are thrown while test is running
            //tests fail if any exceptions are thrown while test is running
        }

        [Fact]
        public void the_num_4_should_translate_into_the_letter_IV()
        {
            //Arrange
            var numberToTranslate = 4;
            var expectedResult = "IV";
            var translator = new NumberTranslator();

            //Act
            var actualResult = translator.Translate(numberToTranslate);

            //Assert
            Assert.Equal(expectedResult, actualResult);

        }

        [Fact]
        public void the_num_3_should_translate_into_the_numeral_III()
        {
            var numberToTranslate = 3;
            var expectedResult = "III";
            var translator = new NumberTranslator();

            var actualResult = translator.Translate(numberToTranslate);

            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(8, "VIII")]
        [InlineData(15, "XV")]
        [InlineData(19, "XIX")]
        [InlineData(39, "XXXIX")]
        //29
        //24
        //45
        //we have a lot of InlineDataAttributes!
        // you can pass thru list of strings/cases
        // you can also use a DB to pass cases into theories
        //InlineData as most basic type of case to pass (good for 4-5 things)

        public void given_a_number_it_is_translated_appropriately(int numberToTranslate, string expectedResult)
        {

            //Arrange
            var translator = new NumberTranslator();

            //Act
            var actualResult = translator.Translate(numberToTranslate);

            //Assert
            Assert.Equal(expectedResult, actualResult);

        }
    }
}
