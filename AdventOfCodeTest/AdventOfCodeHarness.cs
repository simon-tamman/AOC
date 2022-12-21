using System;
using AdventOfCode;
using AdventOfCode._2;
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
        var result = FirstAnswers.FindMostCalories();
        Console.WriteLine($"Answer is: {result}");
    }
    
    [Test]
    public void Test1Part2()
    {
        var result = FirstAnswers.FindSumOfTopThreeCalories();
        Console.WriteLine($"Answer is: {result}");
    }
    
    [Test]
    public void Test2()
    {
        var result = CalculateRpsScores.Calculate();
        Console.WriteLine($"Answer is: {result}");
    }
    
    [Test]
    public void Test2Part2()
    {
        var result = CalculateRpsScores.Calculate(Strategy.Part2);
        Console.WriteLine($"Answer is: {result}");
    }
}