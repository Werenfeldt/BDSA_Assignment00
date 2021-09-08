using System;
using Xunit;
using System.IO;

namespace Assigment.Tests
{
    public class ProgramTests
    {

        [Fact]
        public void IsLeapYear_devisible_by_four()
        {
            
            bool x = new Program(40).IsLeapYear(40);
            
            Assert.True(x);
        }

        [Fact]
        public void IsLeapYear_not_devisible_by_four()
        {
            
            bool x = new Program(77).IsLeapYear(77);
            
            Assert.False(x);
        }

        [Fact]
        public void IsLeapYear_devisible_by_four_not_100()
        {
            bool x = new Program(80).IsLeapYear(80);
            
            Assert.True(x);
        }

        [Fact]
        public void IsLeapYear_is_devisible_by_four_100()
        {
            bool x = new Program(200).IsLeapYear(200);
            
            Assert.False(x);
        }

        [Fact]
        public void IsLeapYear_is_devilisble_by_four_100_400()
        {
            bool x = new Program(800).IsLeapYear(800);
            
            Assert.True(x);
        }


        [Fact]
        public void IsLeapYear_input(){
            var writer = new StringWriter();
            Console.SetOut(writer);

            
            new Program(140);
            
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("yay", output);

        } 
        
        [Fact]
        public void IsNOTLeapYear_input(){
            var writer = new StringWriter();
            Console.SetOut(writer);

            
            new Program(600);
            
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("nay", output);

        } 
    }
}
