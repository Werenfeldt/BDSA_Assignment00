using System;
using Xunit;

namespace Assigment.Tests
{
    public class ProgramTests
    {
        Program program = new Program();

        [Fact]
        public void IsLeapYear_devisible_by_four()
        {
            
            bool x = program.IsLeapYear(40);
            
            Assert.True(x);
        }

        [Fact]
        public void IsLeapYear_not_devisible_by_four()
        {
            
            bool x = program.IsLeapYear(77);
            
            Assert.False(x);
        }

        [Fact]
        public void IsLeapYear_devisible_by_four_not_100()
        {
            bool x = program.IsLeapYear(80);
            
            Assert.True(x);
        }

        [Fact]
        public void IsLeapYear_is_devisible_by_four_100()
        {
            bool x = program.IsLeapYear(200);
            
            Assert.False(x);
        }

        public void IsLeapYear_is_devilisble_by_four_100_400()
        {
            bool x = program.IsLeapYear(800);
            
            Assert.False(x);
        }
    }
}
