using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Class_vs_Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // CLass Example (Reference Type)
            MyClass num1 = new MyClass(10);
            MyClass num2 = num1;              // This line creates reference to the same object i.e object reference of the My Class num2 but assigns the same content which num1 is pointing to

            Console.WriteLine("Example for CLass:");
            Console.WriteLine($"Value of num1 before updating is: {num1.Value}");  
            Console.WriteLine($"Value of num2 before updating is: {num2.Value}");
            num2.Value = 20;                  // num1 and num2 point to the same object in memory. Changing num2.Value also affects num1.Value because both variables reference the same object.
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Value of num1 after updating is: {num1.Value}");  // Value changes to 20 (reference type)
            Console.WriteLine($"Value of num2 after updating is: {num2.Value}");  // Value is 20

            // Struct Example (Value Type)
            MyStruct myid1 = new MyStruct(10);
            MyStruct myid2 = myid1; // Creates a copy i.e when you assign one struct to another, a copy is made. Each struct variable holds its own data, so changes to one do not affect the other. (value type)

            Console.WriteLine("===========================================");

            Console.WriteLine("Example for Struct:");

            Console.WriteLine($"Value of num1 before updating is: {myid1.Value}");
            Console.WriteLine($"Value of num2 before updating is: {myid2.Value}");

            myid2.Value = 20;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Value of num1 after updating is: {myid1.Value}");   // Value remains 10 because it is value type.
            Console.WriteLine($"Value of num2 after updating is: {myid2.Value}");   // Value changes to 20
        }
        
        
       //Main Differences between Class and Struct:
       //     Memory Allocation:  Class: Allocated on the heap.It behaves as a reference type.
       //                         Struct: Allocated on the stack (or inline in arrays) and behaves as a value type.
       //     Assignment :        Class: When you assign an object of a class to another variable, both variables point to the same instance.Changes to one affect the other.
       //                         Struct: When you assign a struct to another variable, a copy is made.Changes to one do not affect the other.
       //     Default Values:     Class: If no constructor is defined, reference types have a default value of null.
       //                         Struct: Value types are automatically initialized to their default values (e.g., 0 for int, false for bool).
       //     Inheritance:        Class: Supports inheritance(can be derived from other classes).
       //                         Struct: Does not support inheritance from other structs or classes(but can implement interfaces).
        }
}
