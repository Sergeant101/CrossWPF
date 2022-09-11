using System;
using System.Threading;
using Program.Model;
using System.Threading.Tasks;
using Xunit;
using System.ComponentModel;

#nullable disable

namespace TestModel.test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //Arrange
        RandFunc randFunc = new RandFunc();
        int expected = randFunc.Show_Rand;

        //Act
        randFunc.PropertyChanged += GetAssert;

        void GetAssert(object sender, PropertyChangedEventArgs e)
        {
            int actual = randFunc.Show_Rand;
            Assert.NotEqual(expected, actual);
        }        
    }
    
    [Fact]
    public void TestWait2sec()
    {
        RandFunc randFunc = new RandFunc();
        Thread.Sleep(2500);
        int expected = randFunc.Show_Rand;
        Thread.Sleep(2500);
        int actual = randFunc.Show_Rand;

        Assert.NotEqual(expected, actual);
    }

    [Fact]
    public void TestUpIntervalTimer1()
    {
        //Arrange
        RandFunc randFunc = new RandFunc();
        randFunc.TimerCountUp();
        Thread.Sleep(3500);
        int expected = randFunc.Show_Rand;

        //Act
        Thread.Sleep(2000);
        int actual = randFunc.Show_Rand;

        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestUpIntervalTimer2()
    {
        //Arrange 
        RandFunc randFunc = new RandFunc();
        randFunc.TimerCountUp();
        Thread.Sleep(3500);
        int expected = randFunc.Show_Rand;

        //Act
        Thread.Sleep(3500);
        int actual = randFunc.Show_Rand;

        //Assert
        Assert.NotEqual(expected, actual);
    }
}