//deposit amount - non negative integer (IllegalArgumentException- "Negative numbers are not allowed")
//costperday - non negative integer (same as per above)
//error and exceptions to be handled
//(NumberFormatException - "Invalid Number Format")


using System.Numerics;
using System.Reflection.Metadata;

/*
    public class ItemExceptions : Exception
    {
        public ItemExceptions() {}
        public ItemExceptions(string message) : base(message)
        {

        }
        public NumberFormatExceptions(string message) : base(message) { }
        public IllegalArgumentExceptions(string message) : base(message) { }
    }
*/
public class Items{
    private string name;
    private double initialAmount;
    private double costPerDay;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double InitialAmount
    {
        get { return initialAmount; }
        set { initialAmount = value; }
    }

    public double CostPerDay
    {
        get { return costPerDay; }
        set { costPerDay = value; }
    }

    private Items()
    {
        //default constructor
    }

    public Items(string name, double initialAmount, double costPerDay):this()
    {
        //param constructor
        this.name = name;
        this.initialAmount = initialAmount;
        this.costPerDay = costPerDay;
    }

    public static String ToString(Items items)
    {
        return $" Final string : " + items.name + " " + items.initialAmount + " " + items.costPerDay;
    }


}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of items : ");
        int n = Convert.ToInt32(Console.ReadLine());


        //non negative integer try catch block
        //int name, initialAmount, costPerDay;
        try
        {
            string name = Console.ReadLine();
            double initialAmount = Convert.ToDouble(Console.ReadLine());
            double costPerDay = Convert.ToDouble(Console.ReadLine());
            if(initialAmount >= 0 || costPerDay >= 0)
            {
                Items i1 = new(name,initialAmount,costPerDay);
                Console.WriteLine(Items.ToString(i1));
            }            
            else
            {
                throw new IllegalArgumentException("Negative Numbers are not allowed");
            }
        }
        catch (IllegalArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }



    }

}

[Serializable]
internal class IllegalArgumentException : Exception
{
    public IllegalArgumentException()
    {
    }

    public IllegalArgumentException(string? message) : base(message)
    {
    }

    public IllegalArgumentException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
/*
[Serializable]
internal class NumberFormatException : Exception
{
   public NumberFormatException()
   {
   }

   public NumberFormatException(string? message) : base(message)
   {
       //Console.WriteLine($"Invalid Number Format");
   }

   public NumberFormatException(string? message, Exception? innerException) : base(message, innerException)
   {
   }
}*/