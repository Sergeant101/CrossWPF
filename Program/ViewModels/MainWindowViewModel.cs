
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using ReactiveUI;
//using AvaloniaAppTemplate.Namespace;

namespace Program.ViewModels

#nullable enable

{
    internal class MainWindowViewModel : ViewModelBase, INotifyPropertyChanged
    {
        
       private ViewModelBase content;

        public MainWindowViewModel()
        {
            // this.randFunc = _randFunc;

            // SwitchingViews = new ObservableCollection<ViewModelBase>()
            // {
            //     new ViewModel1(),
            //     new ViewModel2()
            // };
            content = new SecondView();
       
        }

            public ViewModelBase Content
            {
                get => content;
                private set => this.RaiseAndSetIfChanged(ref content, value);
            }

        // вывод данных из модели во вьюшку
        internal IRandNum randFunc;
        private int rand_num;
        public int Rand_Num
        {
            private set 
            { 
                rand_num = value;
                OnPropertyChanged();
            }
            get
            {
                return rand_num;
            }
        }





      private ObservableCollection<object> _ViewModelsView;
      

        private void OnPropertyRandFunc(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Show_Rand")
            {
                Rand_Num = randFunc.Show_Rand;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string? arg = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(arg));
        }

        //public string Greeting => "Welcome to Avalonia!";
    }
}
