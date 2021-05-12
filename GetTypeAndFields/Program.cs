using System;
using System.Reflection;
namespace GetTypeAndFields
{
    class Program
    {
        static void Main(string[] args)
        {
            HasASecret keeper = new HasASecret();

            // Uncommenting this Console.WriteLine statement causes a compiler error: // 'HasASecret.secret' is inaccessible due to its protection level
            // Console.WriteLine(keeper.secret);
            // But we can still use reflection to get the value of the secret field

            FieldInfo[] fields = keeper.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (FieldInfo field in fields) 
            {
                Console.WriteLine(field.GetValue(keeper));
            }
        }
    }
}
