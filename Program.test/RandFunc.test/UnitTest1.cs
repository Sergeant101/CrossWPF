using System;
using Cross_WPF_Test.Model;
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
}