using System;


namespace FundementalsOfCSharp;

public class Variables
{
     
    
    static void Main2()
    {
        //String Variable
        String Name = "Lucas"; 
        
        //Int variable
        int Age = 18;
        
        //double variable
        double doublechip = 4.9;
        
        //char variable
        
        char myLetter = 'A';
        
        // Boolean variable
        bool myBool = true;
        Console.WriteLine(Name);
        
        //Float variable
        float myFloat = 3.14f;
        
        //Constant variables are variables that cannot be changed from code
        
        //Types casting 
        //Implicity Casting is when the casting is done automatically when passing a smaller size type to a larger size type

        int myInt = 9;
        double myDouble = myInt;

        Console.WriteLine(myInt);
        Console.WriteLine(myDouble);
        
        //Explicit Casting
        //this must be done manually by placing the type in () in front of the value

        double NewDouble = 9.78;
        int myInterger = (int) NewDouble;
        
        Console.WriteLine(NewDouble);
        Console.WriteLine(myInterger);
        
        //Type Conversion 
        //this is also possible to convert data types by specifically using built in methods such as Convert.ToBoolean, etc

        int OtherInt = 10;
        double Double = 5.25;
        bool myBoolean = true;
        
        
        Console.WriteLine(Convert.ToString(OtherInt));    // convert int to string
        Console.WriteLine(Convert.ToDouble(OtherInt));    // convert int to double
        Console.WriteLine(Convert.ToInt32(Double));  // convert double to int
        Console.WriteLine(Convert.ToString(myBoolean));   // convert bool to string
    }
}