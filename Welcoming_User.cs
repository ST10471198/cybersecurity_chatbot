using System;

namespace cybersecurity_chatbot
{//start of namespace
    public class Welcoming_User
    {//start of class

        //creating a global variable to store username
        private string username = string.Empty;

        //void method to welcome the user 
        public void welcome()
        {//start of method


            //message to welcome the user
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" -------------------------------------------");
            Console.WriteLine("(          Welcome to Ruby Chatbot          )");
            Console.WriteLine(" -------------------------------------------");

            //reseting the color
            Console.ResetColor();

        }//end of method

        //method to ask for username 
        public void ask_username()
        {//start of method

            //asking the user for their name
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("RUBY: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Enter your name..");

            //reset color
            Console.ResetColor();

            //do-while loop to re-prompt the user until they enter a valid name
            do
            {//start of do-while loop

                //prompt and test color
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("User: ");

                Console.ForegroundColor = ConsoleColor.Yellow;
                username = Console.ReadLine();

            } while (!empty());//end of do while

        }//end of method

        //boolean method to check if the username is not empty
        public Boolean empty()
        {// start of empty() method

            //checking if username is not empty using if statement
            if (username != "")
            {//start of if statement

                //susccess message
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("RUBY: ");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hey, " + username);

                //reset color
                Console.ResetColor();

                //return true
                return true;

            }//end of if statement
            else
            {//start of else statement

                //error message
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("RUBY: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter name...");

                //return false
                return false;

            }//end of else statement

        }//end of empty() method

        public string get_username()
        {//start of method

            return username;

        }//end of method

    }//end of class

}//end of namespace