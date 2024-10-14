using System;

class Program {
    static void Main() {
        Console.WriteLine("Starting the multi-file C# project!");
        
        // Gọi phương thức từ Helper.cs
        Helper.PrintMessage("Hello from Helper class!");

        // Gọi phương thức từ Utility.cs
        Utility.ShowDateTime();
    }
}
