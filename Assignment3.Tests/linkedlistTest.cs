using Assignment3;
using NUnit.Framework; 

[TestFixture]
public class LinkedListTest
{
    private SLL list;

    [SetUp]
    public void Setup()
    {
        list = new SLL();
    }

    [Test]
    public void TestIsEmpty()
    {
        Assert.That(list.IsEmpty(), Is.True);
    }

    [Test]
    public void TestAddLast()
    {
        User user = new User(1, "Test User", "test@example.com", "password123");
        list.AddLast(user);
        Assert.That(list.IsEmpty(), Is.False);
        Assert.That(list.Count(), Is.EqualTo(1));
        Assert.That(list.GetValue(0), Is.EqualTo(user));
    }

    [Test]
    public void TestAddFirst()
    {
        User user = new User(1, "Test User", "test@example.com", "password123");
        list.AddFirst(user);
        Assert.That(list.IsEmpty(), Is.False);
        Assert.That(list.Count(), Is.EqualTo(1));
        Assert.That(list.GetValue(0), Is.EqualTo(user));
    }

    [Test]
    public void TestRemoveFirst()
    {
        User user1 = new User(1, "User1", "user1@example.com", "password1");
        User user2 = new User(2, "User2", "user2@example.com", "password2");
        list.AddLast(user1);
        list.AddLast(user2);
        list.RemoveFirst();
        Assert.That(list.Count(), Is.EqualTo(1));
        Assert.That(list.GetValue(0), Is.EqualTo(user2));
    }

    [Test]
    public void TestRemoveLast()
    {
        User user1 = new User(1, "User1", "user1@example.com", "password1");
        User user2 = new User(2, "User2", "user2@example.com", "password2");
        list.AddLast(user1);
        list.AddLast(user2);
        list.RemoveLast();
        Assert.That(list.Count(), Is.EqualTo(1));
        Assert.That(list.GetValue(0), Is.EqualTo(user1));
    }

    [Test]
    public void TestAdd()
    {
        User user1 = new User(1, "User1", "user1@example.com", "password1");
        User user2 = new User(2, "User2", "user2@example.com", "password2");
        list.AddLast(user1);
        list.Add(user2, 1);
        Assert.That(list.GetValue(1), Is.EqualTo(user2));
    }

    [Test]
    public void TestReplace()
    {
        User user1 = new User(1, "User1", "user1@example.com", "password1");
        User user2 = new User(2, "User2", "user2@example.com", "password2");
        list.AddLast(user1);
        list.Replace(user2, 0);
        Assert.That(list.GetValue(0), Is.EqualTo(user2));
    }

    [Test]
    public void TestRemove()
    {
        User user1 = new User(1, "User1", "user1@example.com", "password1");
        User user2 = new User(2, "User2", "user2@example.com", "password2");
        list.AddLast(user1);
        list.AddLast(user2);
        list.Remove(0);
        Assert.That(list.GetValue(0), Is.EqualTo(user2));
    }

    [Test]
    public void TestContains()
    {
        User user1 = new User(1, "User1", "user1@example.com", "password1");
        list.AddLast(user1);
        Assert.That(list.Contains(user1), Is.True);
    }

    [Test]
    public void TestCount()
    {
        Assert.That(list.Count(), Is.EqualTo(0));
        User user = new User(1, "Test User", "test@example.com", "password123");
        list.AddLast(user);
        Assert.That(list.Count(), Is.EqualTo(1));
    }
}
