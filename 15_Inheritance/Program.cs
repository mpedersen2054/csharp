using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // When one class inherits from another it gains all the properties and 
            // methods of the parent class. In C# each class can only inherit from one other class,
            // although any number of classes can inherit from any given class.
            // This sequence of passing information down through multiple levels 
            // of classes is called the inheritance chain.

            // The base keyword following the new class constructor is done to pass the 
            // needed variables to the parent class' constructor methods. The parent class's 
            // constructor will be run, and then the child class's constructor will execute. Because of this,
            // we can keep all the properties and functionality of the parent class while still 
            // having the ability to add to or overwrite them.

            // to override a method we want to use
            // public new void GetInfo() {...} -- hence NEW

            // public methods are inherited as expected; however, private methods are not.
            // If we want to have a method have the visibility of a private method, but still be inherited,
            // we have to use the access modifier of protected in place of public.

            // Polymorphism is the idea that objects can be treated as if they belonged to any 
            // of the classes above them in the inheritance chain. We can instantiate an 
            // instance of a child class and store it in a variable of its parent type.
        }
    }
}
