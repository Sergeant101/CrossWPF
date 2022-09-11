using Program.ViewModels;
using System.Threading;
using Program.Model;

namespace RandNumViewModel.test;


public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //arrange        
        RandFunc randFunc = new RandFunc();
        // просто RandNumViewModel выдавало ошибку что это пространство имён, бывает
        Program.ViewModels.RandNumViewModel randNumViewModel = new Program.ViewModels.RandNumViewModel(randFunc);
    
        int expected = randNumViewModel.RandomNumber;

        //Act
        Thread.Sleep(2500);
        int actual = randNumViewModel.RandomNumber;

        Assert.NotEqual(expected, actual);
    }

    [Fact]
    public void TestWata2sec2sec()
    {
                //arrange        
        RandFunc randFunc = new RandFunc();
        // просто RandNumViewModel выдавало ошибку что это пространство имён, бывает
        Program.ViewModels.RandNumViewModel randNumViewModel = new Program.ViewModels.RandNumViewModel(randFunc);
    
        Thread.Sleep(2500);
        int expected = randNumViewModel.RandomNumber;

        //Act
        Thread.Sleep(2500);
        int actual = randNumViewModel.RandomNumber;

        Assert.NotEqual(expected, actual);
    }
}