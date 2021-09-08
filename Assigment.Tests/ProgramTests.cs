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

            
            new Program(2000);
            
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("yay", output);

        } 
        
        [Fact]
        public void IsNOTLeapYear_input(){
            var writer = new StringWriter();
            Console.SetOut(writer);

            
            new Program(7777);
            
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("nay", output);

        } 

        [Fact]
        public void IsLeapYear_input_valid_year(){
            var writer = new StringWriter();
            Console.SetOut(writer);

            
            new Program(600);
            
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("The year must be at least 1582", output);
        } 

        [Fact]
        public void IsLeapYear_input_Invalid(){
            var writer = new StringWriter();
            Console.SetOut(writer);

            //needs to press enter to run this test. 
            Program.Main(new string[1]{"hej"});
            
            
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("The input must be an integer", output);
        } 
    }
}
