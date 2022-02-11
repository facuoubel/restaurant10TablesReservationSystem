using System;
/*
 *1. Validar si el usuario existe o si se debe registrar; generar un sistema de registro o login.
 *2. El programa debe ser capaz de darle la bienvenida a un usuario existente
 *3. El programa debe repetirse hasta que se registren los diez comensales. 
*/

namespace restaurant10TablesReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = new string[10] { "", "", "", "", "", "", "", "", "", "" };
            int arrayCurrentIndex = 0;
            bool userType;
            Console.WriteLine("Welcome to the Facu restaurant!");
         

                while(arrayCurrentIndex < 10)
            {
                Console.WriteLine("\n \n Are you a registered user? Write true, or false to register");
                userType = Convert.ToBoolean(Console.ReadLine());
                if (userType == true)
                {
                    Console.WriteLine("Hello, please enter your user name:");
                        string userToSearch = Console.ReadLine();
                    Console.WriteLine("The user you searched is {0}", userToSearch);
                    int index = Array.IndexOf(userNames, userToSearch);
                    if (index == -1)
                    {
                        Console.WriteLine("User not found, try again or register");
                    }
                    else
                    {
                        Console.WriteLine("Welcome {0}, it's a pleasure to give you food.", userNames[index]);
                    }
                }
                else if(userType == false)
                {
                    Console.WriteLine("Please write and remember your user name:");
                    userNames[arrayCurrentIndex] = Console.ReadLine();
                    Console.WriteLine("Your user has been saved succesfully! \n" + "Your user name is > {0}", userNames[arrayCurrentIndex]);
                    arrayCurrentIndex++;
                }
            }
            Console.WriteLine("The restaurant is full, try again later \n These are the guests to the dinner:");
            int auxIndex = 0;
            foreach(string element in userNames)
            {
                Console.WriteLine("User number {0} and user Name:{1}", auxIndex+1, userNames[auxIndex]);
                auxIndex++;
            }
            Environment.Exit(0);

        }
    }
}
