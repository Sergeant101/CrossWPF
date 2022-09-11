using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using ReactiveUI;

[assembly: InternalsVisibleTo("RandNumViewModel.test")]

#nullable disable

namespace Program.ViewModels;

internal class RandNumViewModel: ViewModelBase
{

    public RandNumViewModel(IRandNum _irandnum)
    {
        this.randNum = _irandnum;
        randNum.PropertyChanged += ChangedNumbs;
    }
    
    readonly IRandNum randNum;

    private int randomNumber;
    public int RandomNumber
    {
        get
        {
            return randomNumber;
        }
        private set => this.RaiseAndSetIfChanged(ref randomNumber, value);
    }

    private void ChangedNumbs(object sender, PropertyChangedEventArgs e)
    {
        RandomNumber = randNum.Show_Rand;
    }

    public void TimerIntervalUp(object sender, object parameter) 
    {
        randNum.TimerCountUp();
    }

}