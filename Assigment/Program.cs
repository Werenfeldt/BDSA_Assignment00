using System;
using System.IO;

namespace Assigment
{
    public class Program
    { 

        public int year;
        public bool leapYear;
        public string answer;

        public static void Main(string[] args){

            //makes sure the terminal doesnt echo the input. 
            string input = null;
                while (true)
                {
                    var key = System.Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter)
                        break;
                    input += key.KeyChar;
                }
            

            new Program(Convert.ToInt32(input));
        }

        public Program(int year){
            this.leapYear = IsLeapYear(year); 
            
            this.answer = response(leapYear);

            Console.WriteLine(answer);
        }

        public bool IsLeapYear(int year){

            if(year % 4 != 0){
                return false; 
            } else {
                if(year % 100 == 0) {
                    if(year % 400 == 0){
                        return true;
                    } else {
                        return false; 
                    }
                } else {
                    return true;
                }
            }
        }

        public string response(bool IsLeapYear){
            if(IsLeapYear){
                return "yay";
            } else {
                return "nay";
            }
        }
    }
}
