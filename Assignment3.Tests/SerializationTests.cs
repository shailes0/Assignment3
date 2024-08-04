using NUnit.Framework;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Assignment3.Tests
{
    public class SerializationTests
    {
        private ILinkedListADT users;
        private readonly string testFileName = "test_users.json";

        [SetUp]
        public void Setup()
        {
            users = new SLL();

            users.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            users.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            users.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));
            users.AddLast(new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999"));
        }

        [TearDown]
        public void TearDown()
        {
            users.Clear();
            if (File.Exists(testFileName))
            {
                File.Delete(testFileName);
            }
        }

        [Test]
        public void Test_Serialization()
        {
            // Serialize the linked list to a file
            var options = new JsonSerializerOptions { WriteIndented = true, ReferenceHandler = ReferenceHandler.Preserve };
            string jsonString = JsonSerializer.Serialize(users, options);
            File.WriteAllText(testFileName, jsonString);

            // Deserialize the linked list from the file
            jsonString = File.ReadAllText(testFileName);
            ILinkedListADT deserializedUsers = JsonSerializer.Deserialize<SLL>(jsonString, options);

            // Check if the deserialized list has the same values
            Assert.AreEqual(users.Count(), deserializedUsers.Count());

            for (int i = 0; i < users.Count(); i++)
            {
                Assert.AreEqual(users.GetValue(i), deserializedUsers.GetValue(i));
            }
        }
    }
}
