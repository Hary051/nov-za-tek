internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = new int[] { 1,5,9 };
        double a=Avg(numbers);
        Console.WriteLine(a);
       
    }
    private static double Avg(int[] numbers)
    {
        int result = 0;
        int avg;
        for (int i = 0;i < numbers.Length; i++)
        {
            result += numbers[i];
        }
        double avg1= result / numbers.Length;
        return avg1;
    }
    void Plus()
    {
        Console.WriteLine(1);
    }
}