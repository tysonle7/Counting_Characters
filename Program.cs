using System;  
public class Program {  
    public static void Main() {  
        string strFirst;  
        char charCout;  
        int Count = 0;  
        Console.Write("Enter Your String:");  
        strFirst = Console.ReadLine();  
        Console.Write("Enter Count Character:");  
        charCout = Convert.ToChar(Console.ReadLine());  
        Console.Write("Your Character Count:");  
        foreach(char chr in strFirst) {  
            if (chr == charCout) {  
                Count++;  
            }  
        }  
        Console.Write(Count);  
    }  
}  