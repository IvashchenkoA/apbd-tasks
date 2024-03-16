Console.WriteLine("Hello, World!");

Console.WriteLine("This is modification 1");

Console.WriteLine("This is modification 2");

Console.WriteLine("This is modification 3:))");

 double CalculateAverage(int[] a)
 {
     int s = 0;
     foreach(int n in a)
     {
         s += n;
     }
     return (double)s/a.Length;
 }
 
 int[] arr = {1,2,3,4,5,6};
 Console.WriteLine("average is: " + CalculateAverage(arr));