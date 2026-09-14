namespace FundementalsOfCSharp;

public class Operators
{
    static void main()
    {
        //The math operators are the same as in other languages

        int x = 5;
        int y = 4;


        int add = x + y;

        int sub = x - y;
        
        int mul = x * y;
        
        int div = x / y;

        int modulas = x % y; // returns the division remainder

        int increment = x++; // increasees the value by 1
        
        int decrement = x--; // decrease the value by 1
        
        
        //Assignment operators


        x = 5;
        x += 5;
        x -= 3;
        x /= 2;
        x %= 1;

        x &= 1; //bitwise AND operator
        x|=1; //bitwise OR
        x ^= 1; //Bitwise XOR
        x >>= 1;
        x <<= 2;
        
        //Comparison Operators
        
        Console.WriteLine( x == y);
        Console.WriteLine( x != y);
        Console.WriteLine( x > y);
        Console.WriteLine( x < y);
        Console.WriteLine( x >= y);
        Console.WriteLine( x <= y);
        
        Console.WriteLine(x < 5 && x < 10);
        Console.WriteLine( x < 5 || x > 4);
        Console.WriteLine(!(x < 5 && x < 10));
    }
    
    
}