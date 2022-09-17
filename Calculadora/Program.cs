using System.ComponentModel.DataAnnotations;
using System.Runtime.ExceptionServices;

namespace Calculadora
{
    internal class Program
    {
        private static int getInputDataFromUser(string message)
        {
            string userInput;
            int valueInput = 0;
            bool dataValid = false;

            while (!dataValid)
            {
                Console.WriteLine(message);
                userInput = Console.ReadLine();

                if (!int.TryParse(userInput, out valueInput))
                {
                    Console.WriteLine("The value you entered is not valid, try again.");
                }
                else
                {
                    dataValid = true;
                }
            }
            return valueInput;
        }
        private static string getInputToReturnMainMenu()
        {
            string strValue = null;
            string valueUppValid = "Y";
            string valueLowValid = "y";
            string valueUppInvalid = "N";
            string valueLowInvalid = "n";
            bool dataValid = false;
            while (!dataValid)
            {
                Console.WriteLine("if you want to go to the main menu: \n Press (Y)\n");
                Console.WriteLine("if you want to continue doing operations of this type: \n Press (N)\n");
                strValue = Console.ReadLine();
                
                if (!strValue.Contains(valueUppValid) ^ strValue.Contains(valueLowValid) 
                    ^ strValue.Contains(valueUppInvalid) ^ strValue.Contains(valueLowInvalid))
                {
                    Console.WriteLine("The value you entered is not valid, try again.");
                }
                else
                {
                    dataValid = true;
                }
            }
            return strValue;
        }

        private static double convertToDouble()
        {
            double number;
            number = Convert.ToDouble(Console.ReadLine());
            return number;
        }
        private static void add()
        {
            double firstNumberAdd;
            double secondNumberAdd;
            double resutl;
            Console.WriteLine("..Addition..\n");
            
            Console.WriteLine("Enter the first number.\n");
            firstNumberAdd = convertToDouble();

            Console.WriteLine("Enter the second number.\n");
            secondNumberAdd = convertToDouble();

            resutl = firstNumberAdd + secondNumberAdd;
            Console.Clear();
            Console.WriteLine($"Values entered: {firstNumberAdd}, {secondNumberAdd}\n");
            Console.WriteLine($"Output: {resutl}");
        }
        private static void sub()
        {
            double firstNumberAdd;
            double secondNumberAdd;
            double resutl;
            Console.WriteLine("..Subtraction..\n");

            Console.WriteLine("Enter the first number.\n");
            firstNumberAdd = convertToDouble();

            Console.WriteLine("Enter the second number.\n");
            secondNumberAdd = convertToDouble();

            resutl = firstNumberAdd - secondNumberAdd;
            Console.Clear();
            Console.WriteLine($"Values entered: {firstNumberAdd}, {secondNumberAdd}\n");
            Console.WriteLine($"Output: {resutl}");
        }
        private static void mul()
        {
            double firstNumberAdd;
            double secondNumberAdd;
            double resutl;
            Console.WriteLine("..Multiplication..\n");

            Console.WriteLine("Enter the first number.\n");
            firstNumberAdd = convertToDouble();

            Console.WriteLine("Enter the second number.\n");
            secondNumberAdd = convertToDouble();

            resutl = firstNumberAdd * secondNumberAdd;
            Console.Clear();
            Console.WriteLine($"Values entered: {firstNumberAdd}, {secondNumberAdd}\n");
            Console.WriteLine($"Output: {resutl}");
        }
        private static void div()
        {
            double firstNumberAdd;
            double secondNumberAdd;
            double resutl;
            Console.WriteLine("..Division..\n");

            Console.WriteLine("Enter the first number.\n");
            firstNumberAdd = convertToDouble();

            Console.WriteLine("Enter the second number.\n");
            secondNumberAdd = convertToDouble();

            resutl = firstNumberAdd / secondNumberAdd;
            Console.Clear();
            Console.WriteLine($"Values entered: {firstNumberAdd}, {secondNumberAdd}\n");
            Console.WriteLine($"Output: {resutl}");
        }

        static void Main(string[] args)
        {
            //variables for the menu
            int option;
            int menu;


            //option for the menu

            Console.WriteLine("...Calculator...");
            Console.WriteLine("1. Addition.");
            Console.WriteLine("2. Subtraction.");
            Console.WriteLine("3. Multiplication.");
            Console.WriteLine("4. Division.");

            option = getInputDataFromUser("\nSelect the operator do you want to do.");
            Console.Clear();

            //Main Menu
            switch (option)
            {
                case 0:
                    
                    Console.WriteLine("...Calculator...");
                    Console.WriteLine("1. Addition.");
                    Console.WriteLine("2. Subtraction.");
                    Console.WriteLine("3. Multiplication.");
                    Console.WriteLine("4. Division.");

                    option = getInputDataFromUser("\nSelect the operator do you want to do.");
                    Console.Clear();
                    break;

                case 1:
                    add();
                    string addmainMenu;
                    addmainMenu = getInputToReturnMainMenu();
                    if (addmainMenu == "y" ^ addmainMenu == "Y")
                    {
                        goto case 0;
                    }
                    else
                    {
                        if (addmainMenu == "n" ^ addmainMenu == "N")
                        {
                            goto case 1;
                        }
                    }
                    break;
                case 2:
                    sub();
                    string submainMenu;
                    submainMenu = getInputToReturnMainMenu();
                    if (submainMenu == "y" ^ submainMenu == "Y")
                    {
                        goto case 0;
                    }
                    else
                    {
                        if (submainMenu == "n" ^ submainMenu == "N")
                        {
                            goto case 2;
                        }

                    }
                    break ;

                case 3:
                    mul();
                    string mulmainMenu;
                    mulmainMenu = getInputToReturnMainMenu();
                    if (mulmainMenu == "y" ^ mulmainMenu == "Y")
                    {
                        goto case 0;
                    }
                    else
                    {
                        if (mulmainMenu == "n" ^ mulmainMenu == "N")
                        {
                            goto case 3;
                        }
                    }
                    break;

                case 4:
                    div();
                    string divmainMenu;
                    divmainMenu = getInputToReturnMainMenu();
                    if (divmainMenu == "y" ^ divmainMenu == "Y")
                    {
                        goto case 0;
                    }
                    else
                    {
                        if (divmainMenu == "n" ^ divmainMenu == "N")
                        {
                            goto case 4;
                        }
                    }
                    break;

                default:
                    Console.WriteLine("The value you entered is not valid, try again.");
                    break;
            }

            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }
    }
}