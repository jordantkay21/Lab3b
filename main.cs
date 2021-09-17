using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter salesperson name");
    string name=Console.ReadLine();

    Console.WriteLine("Enter sales amount");
    int sales=Convert.ToInt32(Console.ReadLine());


    double commission=200+(0.09*sales);
    
    Console.WriteLine("Sales commission for " + name + " is " + commission);

    if (sales <2999)
    { 
      Console.WriteLine("Performance is poor");
    }
    else if (sales >=3000 && sales <4999)
    {
      Console.WriteLine("Performance is Average");
    }
     else if (sales >=5000 && sales <9999)
    {
      Console.WriteLine("Performance is Good");
    }
    else if (sales >=10000 && sales <14999)
    {
      Console.WriteLine("Performance is Excellent");
    }
    else if (sales >=15000)
    {
      Console.WriteLine("Performance is Outstanding");
    }
    }
}
  
