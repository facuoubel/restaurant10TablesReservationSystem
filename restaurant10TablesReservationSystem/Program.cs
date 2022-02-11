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
            string[] userNames = new string[10] { "Facu", "", "", "", "", "", "", "", "", "" };
            int arrayCurrentIndex = 1;
            bool userType;
            Console.WriteLine("Welcome to the Facu restaurant!");
         

                while(true)
            {
                Console.WriteLine("Are you a registered user? Write true, or false to register");
                userType = Convert.ToBoolean(Console.ReadLine());
                if (userType == true)
                {
                    Console.WriteLine("Hello, please enter your user name:");
                        string userToSearch = Console.ReadLine();
                    Console.WriteLine("The user you searched is {0}", userToSearch);
                }
            }

        }
    }
}
