//Problem 10. Employee Data

//A marketing company wants to keep record of its employees. Each record would have the following characteristics:

//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
//Use descriptive names. Print the data at the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "Georgi";
            string lastName ="Georgiev";
            byte age = 20;
            char gender = 'm';
            long personalNumber = 7563560061;
            int employeeNumber = 27560000;
            Console.WriteLine("Name: " + firstName + " " + lastName + "\nAge: " + age + "\nGender: " + gender + "\nID Number: " +
                               personalNumber + "\nUnique employee number: " + employeeNumber);

        }
    }
}
