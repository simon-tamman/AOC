using System;
using AdventOfCode;
using NUnit.Framework;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var result = FindElfWithMostCalories.Find();
        Console.WriteLine($"Answer is: {result}");
    }
}