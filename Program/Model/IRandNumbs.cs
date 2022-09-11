using System.ComponentModel;

public interface IRandNum: INotifyPropertyChanged
{
    int Show_Rand{get;}
    bool TimerCountUp();
}