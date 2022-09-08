using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

using Program.Model;

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

    private void ChangedNumbs(object sender, PropertyChangedEventArgs e)
    {

    }

}