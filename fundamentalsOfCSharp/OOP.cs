namespace FundementalsOfCSharp;

public class OOP
{
    //OOP works very similar to both python and java in terms of general layout as well as def

    //Here is a example of creating both a class and object in OOP
    //It is also really easy to have multiple objects in the same class

    //Constructors are a special method to initialize multiple objects. Which when a object of the class is created the 
    //constructor can be used to set initial values for the fields
    class Car
    {
        public string model;

        public Car(string modelname)
        {
            model = modelname;
        }
        
    }
    
    public static void main_OOP()
    {
        Car volk = new Car("Alero");
        Console.WriteLine(volk.model);
    }
}

