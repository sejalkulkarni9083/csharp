using System; 
 
/* Invoke exe using console */ 
 
public class HelloWorld 
{ 
          public static void Main (string [] args) 
          { 
                Console.WriteLine ("parameter count = {0}", args.Length); 
                Console.WriteLine ("Hello {0}", args [0]); 
                Console.ReadLine (); 
 
          } 
} 