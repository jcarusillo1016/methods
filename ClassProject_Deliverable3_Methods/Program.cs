///Name: Joseph Carusillo
///Date: 9/19/2019
///Project: Deliverable3_Methods
///Description:  ask user form name then write a mthod with there name in it

using System;


namespace ClassProject_Deliverable3_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /// prompts the user to enter ther name for the program to run properly
            Console.WriteLine("Please enter your name into the space below");                       

            /// try/catch to handle possible errors
            try
            {
                //will get user input for program
                string input = Console.ReadLine();

                name();                         
                void name ()
                {
                    //users name and the requestd message
                    Console.WriteLine("Hello " + input + "!");
                }
                
                                                                                   
            }
            catch
            {
                ///error message for the user 
                Console.WriteLine("There was an error, please enter your name in the space below");
                Console.WriteLine("please press any key to close the window");
                               
            }
            // used to keep the window open
            Console.ReadKey();                       
        }
    }
}
