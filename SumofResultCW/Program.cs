// See https://aka.ms/new-console-template for more information
using System;

//This code adds the digits of a number, if the answer has more than one digit it will add those digits
// EX 29 = 2 + 9 = 11 = 1 + 1 = 2 (not valid for neg
public class Number
{
    
    public static int DigitalRoot(long n)
    {


        //Will repeat as long as n has 2 or more digits
        while (n > 9)
        {

            int sum = 0;
            //turn n into string so index can be used
            string stringn = n.ToString();
            //loop through each number of n
            for (int i = 0; i < stringn.Length; i++)
            {
                //change each char back into a int and add to result
                sum += int.Parse(stringn[i].ToString());

            }
            //change n into the result, repeat if nesecary 
            n = sum;

        }
        //return n as an int
        return (int)n;
    }
}