

public class StartIsGreaterThanEndExecption : Exception
{
    public StartIsGreaterThanEndExecption() : base("End should be Greater than Start")
    {
    }
}
//When the setted range are out of the range 1 - 100
public class InputOutofRangeExecption : Exception
{ 
public  InputOutofRangeExecption() : base("Range should not be less than or equal to 1 or greater than or equal to 100")
    {
    }
}
class Program
{
    static void Main(string[] args)
    {
        try
        {
           
                int start, end;
                Console.WriteLine("Enter Starting Number: ");
                string inputStart = Console.ReadLine();
                start = int.Parse(inputStart);
                Console.WriteLine("Enter End Number: ");
                string inputEnd = Console.ReadLine();
                end = int.Parse(inputEnd);
            
                
            if (start <=1 || start>=100 || end <= 1 || end >= 100)
                 {
                    throw new InputOutofRangeExecption();
                 }    
            else if  (end <= start)
                {
                    throw new StartIsGreaterThanEndExecption();
                }
           
            ReadNumbers(start, end);
            
            }
        
        catch (InputOutofRangeExecption ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (StartIsGreaterThanEndExecption ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(FormatException e) { 
            Console.WriteLine(e.ToString());
        }
        finally
        {
           Console.WriteLine("Program Exited!"); 
        }
    }

    private static void ReadNumbers(int start, int end)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter a Number:");
            string inputNumbers = Console.ReadLine();
            int numbers = int.Parse(inputNumbers);
            if (numbers <= start || numbers >= end)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Please Input numbers only greater than: {start} and less than:{end}");
                Console.ResetColor();
                i--;
            }
        }
    }
}