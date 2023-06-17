using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.Models;

namespace TDDTest
{
    public class SumTest
    {
        [Theory]
        [InlineData("1,5",6)]
        [InlineData("",0)]
        [InlineData("0", 0)]
        [InlineData("50,30,20", 100)]
        [InlineData("50,30,20,", 100)]
        public void Execute_Numbers_Sum_With_StringNumbers(string numbers, int expected)
        {
            //Arrange
            Sum sum = new Sum();
            //Act
            var result = sum.Execute(numbers);
            //Assert
            Assert.Equal(expected, result);
        }
    }
}
