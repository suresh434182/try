using System;
using System.Text.RegularExpressions;

class GFG
{


    static void Main(string[] args)
    {
        string strRegex = @"(^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$;
        string[] str = {"9925612824","8238783138", "02812451830"};
        

        foreach (string s in str)
        {
            Console.WriteLine("{ 0} {1} a valid mobile number.", s,
                        (s) ? "is" : "is not");
        }

       
    

    
       

       
        Regex re = new Regex(strRegex);

       
        if (re.IsMatch(inputMobileNumber))
           Console.
        else
            return (false);
        Console.ReadKey();
    }
}