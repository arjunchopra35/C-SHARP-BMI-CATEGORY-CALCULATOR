/*
 * Author = Arjun Chopra
 * Date = 4th October 2018
 * Program name = BMI Category Calculator
 * Program Description = This program calculates your BMI and tells you wether you are underweight, overweight
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiCategory
{
    class Program
    {
        
        static void Main(string[] args)
        {

            

            // Variables
            double heightInches;
            double weightPounds;
            double bodyMassIndex;
            bool isNumber;
            string category;

            // Constants
            const double minHeight = 5;
            const double maxHeight = 120;
            const double minWeight = 0.5;
            const double maxWeight = 999;

            


            // Prompt the user to enter height in Inches
            Console.Write("Enter your height in Inches: ");

            // Get the Input Height in Inches and check whether the input is valid
            isNumber = double.TryParse(Console.ReadLine(), out heightInches);

            // Checking whether the number is valid or between the desired range
            if (isNumber == false || heightInches <= minHeight || heightInches >= maxHeight)
            {
                //Prompting the user to enter a valid number between the desired range
                Console.WriteLine("Please enter a height input in Inches between   " + minHeight + " and " + maxHeight);
                
            }
            else
            {
                //Prompting the user to enter weight in pounds
                Console.Write("Enter your weight in Pounds ");

                //Checking whether the input is a valid number
                isNumber = double.TryParse(Console.ReadLine(), out weightPounds);

                //Checking whether the number is valid or between the desired range
                if (isNumber == false || weightPounds <= minWeight || weightPounds >= maxWeight)

                {
                    //prompting the user to enter a valid input between the desired range
                    Console.WriteLine("Please enter weight in pounds between   " + minWeight + " and " + maxWeight);
                    
                }
                //This part of code runs when the input is valid and in range
                 else
                {
                    //Calculate the body mass index of the user and round it to first place of decimal
                    bodyMassIndex = Math.Round((weightPounds / (heightInches * heightInches)) * 703, 1);

                    //Checking if the user is severly underweight
                    if (bodyMassIndex < 16)
                    {
                        //The user falls under severly underweight category
                        category = "severly underweight";
                        //Prompting the user with his/her BMI and the category
                        Console.WriteLine("The BMI for a {0} Inches tall person, who weighs {1} Pounds is : {2} which is considered {3}", heightInches, weightPounds, bodyMassIndex, category);
                    }
                    // Checking whether the user falls under underweight category
                    else if (bodyMassIndex >= 16 && bodyMassIndex < 18.5)
                    {
                        //The user falls under underweight category
                        category = "underweight";
                        //Prompting the user with BMI and their category
                        Console.WriteLine("The BMI for a {0} Inches tall person, who weighs {1} Pounds is : {2} which is considered {3}", heightInches, weightPounds, bodyMassIndex, category);
                    }
                    // Checking whether the user comes under healthy category
                    else if (bodyMassIndex >= 18.5 && bodyMassIndex < 25)
                    {
                        //The user falls under healthy category
                        category = "healthy";
                        //Prompting the user with their BMI and category
                        Console.WriteLine("The BMI for a {0} Inches tall person, who weighs {1} Pounds is : {2} which is considered {3}", heightInches, weightPounds, bodyMassIndex, category);
                    }
                    //Checking if the user falls under over weight category
                    else if (bodyMassIndex >= 25 && bodyMassIndex < 30)
                    {
                        //The user falls under Over weight category
                        category = "Overweight";
                        //Prompting the user with their BMI and category
                        Console.WriteLine("The BMI for a {0} Inches tall person, who weighs {1} Pounds is : {2} which is considered {3}", heightInches, weightPounds, bodyMassIndex, category);
                    }
                    //Checking whether the user is obese
                    else if (bodyMassIndex >= 30)
                    {
                        //The user falls under obese category
                        category = "Obese";
                        //Prompting the user that with their BMI and category
                        Console.WriteLine("The BMI for a {0} Inches tall person, who weighs {1} Pounds is : {2} which is considered {3}", heightInches, weightPounds, bodyMassIndex, category);
                    }

                    

                }
               

            }    

            //Prompt the user to press any key and exit the application
            Console.WriteLine("\n\nPress any key to end this application..");  

            //any Keypress exits application
            Console.ReadKey();
        }
    }
}
