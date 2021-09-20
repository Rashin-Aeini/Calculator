using System;
using Calculator.App;
using Xunit;

namespace Calculator.Test
{
    public class CalcTest
    {
        [Theory]
        [InlineData(3, 5, 8)]
        public void AdditionOne(int first, int second, int expected)
        {
            Calc calc = new Calc();
            
            Assert.Equal(expected, calc.Addition(first, second));
        }
        
        [Theory]
        [InlineData(new[] {1.1f, -3.3f, 5, 7, 8.8f}, 18.6f)]
        public void AdditionTwo(float[] entry, float expected)
        {
            Calc calc = new Calc();
            
            Assert.Equal(expected, calc.Addition(entry));
        }
        
        [Theory]
        [InlineData(3, 5, -2)]
        public void SubtractionOne(int first, int second, int expected)
        {
            Calc calc = new Calc();
                
            Assert.Equal(expected, calc.Subtraction(first, second));
        }
        
        [Theory]
        [InlineData(31, 0)]
        public void DivisionOne(int first, int second)
        {
            Calc calc = new Calc();
                
            Assert.Throws<DivideByZeroException>(() => calc.Division(first, second));
        }
        
        [Theory]
        [InlineData(25, 5, 5)]
        public void DivisionTwo(int first, int second, int expected)
        {
            Calc calc = new Calc();
                
            Assert.Equal(expected, calc.Division(first, second));
        }
        
        [Theory]
        [InlineData(31, 0, 0)]
        public void MultiplicationOne(int first, int second, int expected)
        {
            Calc calc = new Calc();
                
            Assert.Equal(expected, calc.Multiplication(first, second));
        }
        
        [Theory]
        [InlineData(20, 5, 100)]
        public void MultiplicationTwo(int first, int second, int expected)
        {
            Calc calc = new Calc();
                
            Assert.Equal(expected, calc.Multiplication(first, second));
        }
    }
}
