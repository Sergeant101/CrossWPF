using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Program.ViewModels

#nullable enable

{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        
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

        MainWindowViewModel(IRandNum _randFunc)
        {
            if(!(_randFunc is IRandNum))
            {
                throw new System.Exception("Неверный формат введённого объекта");
            }

            randFunc = _randFunc;
        }

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
