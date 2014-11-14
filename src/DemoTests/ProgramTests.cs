using NUnit.Framework;
using Demo;

namespace DemoTests
{
  [TestFixture]
  public class ProgramTests
  {
    [Test]
    public void Add()
    {
      Assert.AreEqual(42, Program.Add(40, 2));
    }

    [Test]
    public void Subtract()
    {
        Assert.AreEqual(1066, Program.Subtract(1100, 34));
    }

    [Test]
    public void AddMultiply()
    {
        var a = 2;
        var b = 4;
        var c = 2;
        Assert.AreEqual(16,Program.Multiply(b, Program.Add(a, c)));
    }

    [Test]
    public void Multiply()
    {
        Assert.AreEqual(100, Program.Multiply(10, 10));
    }

    [Test]
    public void Divide()
    {
        Assert.AreEqual(10, Program.Divide(100, 10));
    }
  }
}