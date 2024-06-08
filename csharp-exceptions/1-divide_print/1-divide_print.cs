using System;
class int
{
    public static void divide(int a, int b)
    {
        int result = 0;
        try
        {
            result = a / b;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Can't divide by Zero");
        }
        finally
        {
            result = a / b;
            Console.WriteLine($"{result}");
        }
    }
}