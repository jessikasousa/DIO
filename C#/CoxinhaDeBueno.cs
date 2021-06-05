using System;
class Coxinha 
{
    static void Main(string[] args) 
    {
        string[] line = Console.ReadLine().Split(" ");
        
      float A = Int32.Parse(line[0]);
      float B = Int32.Parse(line[1]);
        
      float total = (A / B);
        
      if (A % B != 0)
        Console.WriteLine(Math.Round(total, 2).ToString("0.00"));
      else
        Console.WriteLine(total.ToString("0.00"));
    }
}
