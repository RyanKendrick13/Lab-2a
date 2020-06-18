using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter Temperature in Celsius");
    var input = Console.ReadLine();
    double C = Convert.ToDouble(input);
    double F = (C*9/5)+32;
Console.WriteLine("Fahrenheit equilvalence for"+" "+" " + C +" "+ "degree celsius is "+ F);
    
    if(F < 32){
      Console.WriteLine("This temperature is below freezing temperature of 32 degrees farenheit");
      }
     if(F >212){
        Console.WriteLine("This temperature is above boiling temperature of 212 degrees farenheit");

      }
    
 
    

  }
}