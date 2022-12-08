// Задаёт массив из 8 элементов и выводит их на экран
using System;  
public class Exercise1  
{  
    public static void Main()  
{  
    int[] arr = new int[10]; 
    int i;  

    Console.Write("Input 10 elements in the array :");  
    for(i=0; i<8; i++)  
    {  
	    Console.WriteLine();
	    arr[i] = Convert.ToInt32(Console.ReadLine());  		
    }  
  
    Console.Write("\nElements in array are: ");  
    for(i=0; i<8; i++)  
    {  
        Console.WriteLine("[{0}]", string.Join(", ", arr[i])); 
    } 	
  }
}




