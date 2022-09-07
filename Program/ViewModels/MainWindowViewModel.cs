
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using ReactiveUI;
using Avalonia;

namespace Program.ViewModels

#nullable enable

{
    internal class MainWindowViewModel : ViewModelBase
    {
        
       private ViewModelBase content;

        public MainWindowViewModel()
        {

            content = new SecondView();
       
        }

            private int count;
            public int Count
            {
                get => count;
                set => this.RaiseAndSetIfChanged(ref count, value);
            }

            public ViewModelBase Content
            {
                get => content;
                private set => this.RaiseAndSetIfChanged(ref content, value);
            }

            public void secondView()
            {
                Content = new SecondView();
            }

            public void addItemView()
            {
                Content = new AddItemViewModel();
            }

            public void clockFaceView()
            {
                Content = new ClockFaceViewModel();
            }

        // test inject control command in VM MVVM
        public void IncCount(object sender, object parameter) 
        {
            var a = (AvaloniaPropertyChangedEventArgs)parameter;
            var b = a.NewValue;

            if (b.GetType() == typeof(ClockFaceViewModel))
            {
                Count++;
            }

        }

        // вывод данных из модели во вьюшку
        internal IRandNum randFunc;
        private int rand_num;
        // public int Rand_Num
        // {
        //     private set 
        //     { 
        //         rand_num = value;
        //         OnPropertyChanged();
        //     }
        //     get
        //     {
        //         return rand_num;
        //     }
        // }
     

        // private void OnPropertyRandFunc(object sender, PropertyChangedEventArgs e)
        // {
        //     if(e.PropertyName == "Show_Rand")
        //     {
        //         Rand_Num = randFunc.Show_Rand;
        //     }
        // }

        // public event PropertyChangedEventHandler? PropertyChanged;
        // protected virtual void OnPropertyChanged([CallerMemberName] string? arg = null)
        // {
        //     PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(arg));
        // }

        //public string Greeting => "Welcome to Avalonia!";
    }
}
