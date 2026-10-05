namespace FundementalsOfCSharp;

public class UserInput
{
    // to get user input you will use Console.ReadLine()
    //basic example of how to get user input with both using Strings and Ints

    public static void mainUser()
    {
        Console.WriteLine("Please enter your username: ");
        
        string username = Console.ReadLine();
        
        Console.WriteLine("Username is : " + username);
        
        Console.WriteLine("So then what is your age: ");
        
        //Convert to is how you type cast into different data types
        //int32 is a short int which uses less memory which is 16 bits
        //the number range is -32768 to 32767
        //int64 which is the long int has about 32bits or higher
        //the number range for a long int is -2,147,483,648 to 2,147,483,647
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Age is : " + age);
       
    }
}