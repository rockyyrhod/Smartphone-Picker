using System;

namespace GymProgram
{
    class Program
    {
        static void Main()
        {
            string gymPass = "3-12";

            Console.WriteLine("Welcome to GymProg...");

            Console.Write("Enter the GymPass: ");
            string userInput = Console.ReadLine();

            while (userInput != "0")
            {
                string result = userInput == gymPass ? "correct" : "error";

                if (result == "correct")
                {
                    while (true)
                    {
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("Here are the following programs: ");
                        Console.WriteLine("Enter G (Push)");
                        Console.WriteLine("Enter Y (Pull)");
                        Console.WriteLine("Enter M (Leg)");
                        Console.WriteLine("Enter 0 to exit...");


                        Console.WriteLine("Choose your option:");
                        userInput = Console.ReadLine();

                        switch (userInput)
                        {
                            case "G":
                                Console.WriteLine("Push Day: ");
                                Console.WriteLine("1. Flat Dumbbell Bench Press");
                                Console.WriteLine("2. Incline Bench Press");
                                Console.WriteLine("3. Dips");
                                Console.WriteLine("4. Side Lateral Raises");
                                Console.WriteLine("5. Triceps Pushdown");
                                Console.WriteLine("6. Seated Triceps Extension");
                                Console.WriteLine("7. Skullcrushers");
                                Console.WriteLine("8. Dumbbell Shoulder Press");
                                break;

                            case "Y":
                                Console.WriteLine("Pull Day: ");
                                Console.WriteLine("1. Pull Ups");
                                Console.WriteLine("2. Deadlifts");
                                Console.WriteLine("3. Lat Pulldowns");
                                Console.WriteLine("4. Barbell Rows");
                                Console.WriteLine("5. Dumbbell Rows");
                                Console.WriteLine("6. Pullovers");
                                Console.WriteLine("7. Dumbbell Shrugs");
                                Console.WriteLine("8. Dumbbell Preacher Curls");
                                Console.WriteLine("");
                                break;

                            case "M":
                                Console.WriteLine("Leg Day: ");
                                Console.WriteLine("1. Leg Press");
                                Console.WriteLine("2. Hack Squats");
                                Console.WriteLine("3. Leg Extension");
                                Console.WriteLine("4. Leg Curl");
                                Console.WriteLine("5. Lunges");
                                Console.WriteLine("6. Standing Calf Raises");
                                Console.WriteLine("7. Squats");
                                Console.WriteLine("8. Deadlifts ");
                                Console.WriteLine("");
                                break;

                            case "0":
                                Console.WriteLine("Exiting program...");
                                break;
                            default:
                                Console.WriteLine("Invalid input!");
                                break;
                        }

                        if (userInput == "0") 
                        {
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Invalid GymPass, Please try again!");
                    userInput = Console.ReadLine();
                } 
            }

            Console.WriteLine("");
            Console.WriteLine("Thanks for using GymProg...");
            Console.WriteLine("Hope we helped you in your workout program.");
        }
    }
}