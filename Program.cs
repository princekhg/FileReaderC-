using System;
using System.IO;
public class FileCreateRead
{
    string[] arr;
    public void read()
    {
        int len;
        Console.WriteLine("Enter length of String");
        len =Convert.ToInt32(Console.ReadLine());
        arr = new string[len];
        Console.WriteLine("Enter string here");
        for (int i = 0; i < len; i++)
            arr[i] = Console.ReadLine();

    }
    public static void Main()
    {
       FileCreateRead fileCreateRead = new FileCreateRead();
        fileCreateRead.read();
        File.WriteAllLines("new.txt", fileCreateRead.arr);
        using (StreamReader s = new StreamReader("new.txt"))
        {
            string line;
            Console.WriteLine("************************************");
            Console.WriteLine("The file Content Will be Displayed");
            Console.WriteLine("**************************************");
            while ((line = s.ReadLine())!=null)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();
            
        }
    }
}