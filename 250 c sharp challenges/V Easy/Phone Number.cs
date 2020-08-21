/*
Clean up user-entered phone numbers so that they can be sent SMS messages.


*/



//#############################################################
//#                        MY SOLUTIONS                       #
//#############################################################



using System;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string[] symbolsToRemove = new string[] {"-", " ", ".", "+", "(", ")"};
        
        foreach (string symbol in symbolsToRemove)
        {
            phoneNumber = phoneNumber.Replace(symbol, String.Empty);
        }

        if (phoneNumber.Length > 11 || phoneNumber.Length == 11 && phoneNumber[0] - '0' != 1)
        {
            throw new ArgumentException();
        }

        else if (phoneNumber.Length == 11 && phoneNumber[0] == '1')
        {
            phoneNumber = phoneNumber.Substring(1);
        }

        foreach (char character in phoneNumber)
        {
            if (char.IsPunctuation(character) || char.IsLetter(character))
            {
                throw new ArgumentException();
            }
        }

        if (phoneNumber[0] - '0' < 2 || phoneNumber[3] - '0' < 2)
        {
            throw new ArgumentException();
        }
        
        return phoneNumber;
    }
}
