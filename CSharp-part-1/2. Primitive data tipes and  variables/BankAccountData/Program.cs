//Problem 11. Bank Account Data

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
//bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types 
//and descriptive names.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountData
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            string firstName = "Georgi";
            string middleName = "Todorov";
            string lastName = "Georgiev";
            object holderName = firstName + " " + middleName + " " + lastName;
            decimal availableAmount = 5888.69M;
            string bankName = "Raiffeisen";
            string IBAN = "BG80 BNBG 9661 1020 3456 78";
            ulong firstCreditCardNumber = 4716074813868207u;
            ulong secondCreditCardNumber = 4716564813868207u;
            ulong thirdCreditCardNumber = 4716074813862307u;
            Console.WriteLine("Account holder: " + holderName
            + "\nBalance: " + availableAmount
            + " BGN\nBank: " + bankName
            + "\nIBAN: " + IBAN
            + "\nCredit Card 1: " + firstCreditCardNumber
            + "\nCredit Card 2: " + secondCreditCardNumber
            + "\nCredit Card 3: " + thirdCreditCardNumber);
            
        }
    }
}
