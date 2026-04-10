using cybersecurity_awareness_chatbot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace cybersecurity_chatbot
{//start of namespace
    public class Program
    {//start of class
        static void Main(string[] args)
        {//start of main method

            //Creating an instance of Audio_greeting class with a constructor
            new Audio_greeting();
            //Creating an instance of Ascii_Logo class with constructor
            new Ascii_Logo();

            //creating an instance of Welcoming_User class with object name welcome_and_collect
            Welcoming_User welcome_and_collect = new Welcoming_User();

            //calling the welcome() method
            welcome_and_collect.welcome();

            //Calling the ask_username method
            welcome_and_collect.ask_username();

            // Get the username from the welcome class
            string userName = welcome_and_collect.get_username();

            //creating an instance of response_system class with object name respond
            response_system respond = new response_system(userName);

        }//end of main method

    }//end of class

}//end of namespace
