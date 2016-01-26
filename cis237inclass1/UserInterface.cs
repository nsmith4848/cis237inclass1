using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class UserInterface
    {
        //Private Variables - No need for local variables, so there are no private variable declarations for this class.

        //Since there are no local variables, there is no need for public properties, so I don't need that section either.

        //Public methods - we will have some of these!
        
        //This will print the menu to the screen, and await a valid input from the user.  Once the input is valid, it will return the number that they selected.
        public int GetUserInput()
        {
            //Print the menu
            this.printMenu();

            //Get user input
            String input = Console.ReadLine();

            while(input != "1" && input != "2")
            {
                //Give them a prompt to rethink their last choice
                Console.WriteLine("That is not a valid entry");
                Console.WriteLine("Please make a valid choice");
                Console.WriteLine();
                //Reprint the menu for the user
                this.printMenu();
                //Accept their next input
                input = Console.ReadLine();
            }
            //Returns input as the number they typed in, no try catch necessary due to previous "while" loop
            return Int32.Parse(input);
        }

        //Take in a string that we would like output to the screen
        //Unlike Console.WriteLine, we could adapt this class to a more involved web based program without changing the other classes
        public void PrintAllOutput(string allOutput)
        {
            Console.WriteLine(allOutput);
        }

        //This is just a private method to print the Menu.  It will probably happen quite a bit, so it makes sense that it is in a method.
        private void printMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1.  Print List");
            Console.WriteLine("2. Exit");
        }

        //Constructors - No need for any constructors either.  We will just use the default one provided to us.We can't see it, but it's available
    }
}
