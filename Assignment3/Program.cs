using System;
using Assignment3;

namespace Assignment3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Create a new linked list
            ILinkedListADT userList = new SLL();

            // Add some users
            userList.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            userList.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));

            // Display users
            Console.WriteLine("Users in the list:");
            for (int i = 0; i < userList.Count(); i++)
            {
                User user = userList.GetValue(i);
                Console.WriteLine($"ID: {user.Id}, Name: {user.Name}, Email: {user.Email}");
            }

            // Wait for user input before closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
