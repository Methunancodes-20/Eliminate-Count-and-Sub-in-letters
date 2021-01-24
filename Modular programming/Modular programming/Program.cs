using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Modular_programming
{
    class Program
    {
        /*
   PROGRAMME	:	Modular Programming Assignment

   OUTLINE	:	Program has the user select four different options the you input what option you want from the menu
                the first option makes you write a string then you select what letter you want the count for which
                it then displays, the second makes you select a word and what character you want deleted, the third     
                sees what string you inputted finds the most frequent letter that is there and you select what word you    
                want to replace it with, and the fourth exits you ot of the program. The program uses select case, methods
                , and for loops

   PROGRAMMER	:	Methunan Uthayakumar
     
    DATE		:	October 4, 2020
  */
        static void Main(string[] args)
        {
            Options(); // calls option method 
        }
        
       
        
        /* This is a method 
         * 
         * 
         */
        private static void Options( )
        {
                // writes the different options down and asks what option you want to select
                Console.WriteLine("Choose an option if an option that is not presented is typed program will close:");
                Console.WriteLine("1) Count a pattern");
                Console.WriteLine("2) Eliminate a pattern");
                Console.WriteLine("3) Substitute a pattern");
                Console.WriteLine("4) Exit or press enter");
                Console.Write("Select an option by writing the number of the option: ");

                switch (Console.ReadLine())
                { // is a switch statement where when you enter the digit the methods are presented by the numbers to open
                  // so for example if you enter 1 the countPattern() method will open and execute
                    case "1":
                        countPattern();
                        return;
                    case "2":
                        eliminatePattern();
                        return;
                    case "3":
                        substitutePattern();
                        return;
                    case "4":
                        return;
                }
        }


        /* This is a method 
        * 
        * 
        */
        private static string CaptureInput()
        { // This the method used to input the string the user would like to modify
            Console.Write("Enter the string you want to modify: ");
            return Console.ReadLine().ToLower();
        }

        private static void countPattern()
        {
            Console.Clear(); // clears previous text on console and displays Count a Pattern
            Console.WriteLine("Count a Pattern");

            string word = CaptureInput(); // calls the method to have the user input a string
            Console.Write("What letters count or numbers count do you want ");
            char trend = Convert.ToChar(Console.ReadLine()); // takes the letter user inputs and turns it into a character 
            
            char[] wordarray = word.ToCharArray(); // brings the string to the array 
            
            int Length = 0; // length size and counts how long the length is 
             Length = word.Length - 1;
            int count = 0; // counts lets us know what number were at 

            foreach (char character in wordarray ) // basically says for each individual character follow the if statement
            {
                if (character == trend) // so if the character which is word is equal to the letter inputted from the user 
                    count++;     // because thats the trend the count will increase
            }
            Console.WriteLine(trend + " appeared " + count + " times"); // writes the letter and how many times it appeared 
            Console.WriteLine("Press Enter to reset Program to main menu ");
            Console.ReadLine();

            Console.Clear(); // clears any text on the console
            Program.Options(); // goes back to the options method
            
        }


        /* This is a method 
        * 
        * 
        */
        private static void eliminatePattern()
        {
            Console.Clear();
            Console.WriteLine("Eliminate a Pattern"); // writes what method it is

            string word = CaptureInput(); // asks what string you want to write 
            Console.Write("What letter or number do you want to remove "); // asks what letter you want to remove  
           string letter = Console.ReadLine();

           string newword = word.Replace(letter, ""); // removes the letter with a blank 
           
            Console.WriteLine("so your new string is: " + newword); // writes down the new word you made
            Console.WriteLine("Press Enter to reset Program to main menu ");
            Console.ReadLine();

            Console.Clear(); // clears any text on the console
            Program.Options(); // goes back to the options method
        }


        /* This is a method 
        * 
        * 
        */
        private static void substitutePattern()
        {
            Console.Clear();
            Console.WriteLine("Substitute a Pattern"); // clears previous text and displays Substitute a Pattern

            string word = CaptureInput(); // asks to input a string then asks what letter you want to remove and add after 
            Console.Write("What letter or number do you want to remove ");
            char replace = Convert.ToChar(Console.ReadLine()); // converts the character to char array
            Console.Write("What letter or number do you want to add in ");
            char replacement = Convert.ToChar(Console.ReadLine());

            char[] wordArray = word.ToCharArray(); // brings the string to array
       
            for (int i = 0; i < word.Length; i++) // i is 0 and the code executes the for loop sayin if i is less then the words length
            {
                if (wordArray[i] == replace) // if the word from the string matches and the letter you dont want matches the code proceeds 
                {
                    wordArray[i] = replacement; // then it replaces the letter you want removed with the new word 

                }
            }
            Console.WriteLine(" Your new string is: ");
            Console.WriteLine(wordArray); // just prints the letters out
            Console.WriteLine("Press Enter to reset Program to main menu ");
            Console.ReadLine();

            Console.Clear(); // clears any text on the console
            Program.Options(); // goes back to the options method
        }
        
    }


      
}





        
        
    

