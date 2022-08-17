using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System;

[assembly: InternalsVisibleTo("RandFunc.test")]
#nullable disable

namespace Cross_WPF_Test.Model;

internal class RandFunc : INotifyPropertyChanged, IRandNum
    {
        private int show_Rand;
        public int Show_Rand 
        { 
            get
            {
                return show_Rand;
            }
            private set
            {
                show_Rand = value;
                OnPropertyChanged();
            }
        }
        private Random rand;

        internal RandFunc()
        {
            TimerCallback timerCallback = new TimerCallback(GetRandNum);

          //  System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
          //  dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
           // dispatcherTimer.Interval = new TimeSpan(0, 0, 2);
           // dispatcherTimer.Start();
           rand = new Random();

           Timer timer = new Timer(timerCallback, 0, 0, 2000);
        }

        #region
        private void GetRandNum(Object sender)
        {
            Show_Rand = rand.Next();
        }

        #endregion

        #region
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string prop = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
    }