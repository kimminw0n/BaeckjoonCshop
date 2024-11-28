using System;
using System.Text;
class Program
{
    static void Main()
    {
        int t= int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        for(int i=0; i<t; i++)
        {
            string[] inputs = Console.ReadLine().Split();
            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            sb.AppendLine((a + b).ToString());
        }
        Console.Write(sb.ToString());
    }
}