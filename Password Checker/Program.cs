using System;

namespace Password_Checker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "!@#$%^&*-+?.";

            Console.WriteLine("Welcome to the Greedy Goblin Company! To protect your funds, please create a strong password.\n The rules are as follows:\n 1: No empty spaces!\n 2:At least 8 characters in length.\n 3: At least one lower case letter.\n 4: At least one upper case letter.\n 5: At least one special character.\n Enter your password:");
            string password =
            Console.ReadLine();

            int score = 0;
            if (password.Length >= minLength)
            {
                score++;
            }
            if (Tools.Contains(password, uppercase))
            {
                score++;
            }
            if (Tools.Contains(password, lowercase))
            {
                score++;
            }
            if (Tools.Contains(password, digits))
            {
                score++;
            }
            if (Tools.Contains(password, specialChars))
            {
                score++;
            }
            if (password.Contains(" "))
                Console.WriteLine("No spaces allowed!");
            switch (score)
            {
                case 5:
                case 4:
                    Console.WriteLine("You've got an impressive password here. Nice and strong!");
                    break;
                case 3:
                    Console.WriteLine("You've got a decent password here, but it could be stronger. Maybe consider strengthening it?");
                    break;
                case 2:
                    Console.WriteLine("This password is okay, but you could definitely make a stronger one.");
                    break;
                case 1:
                    Console.WriteLine("This password will technically pass, but you really should consider making a stronger one. It's pretty weak.");
                    break;
                default:
                    Console.WriteLine("Sorry, but this password doesn't meet any of the requirements. Follow the rules and make a better one!");
                    break;

            }
        }
    }
}