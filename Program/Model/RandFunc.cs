using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System;
using System.Diagnostics;

[assembly: InternalsVisibleTo("RandFunc.test")]
[assembly: InternalsVisibleTo("RandNumViewModel.test")]
#nullable disable

namespace Program.Model;

internal class RandFunc: IRandNum
    {

        internal RandFunc()
        {
            timerCallback = new TimerCallback(GetRandNum);
            rand = new Random();

            timer = new Timer(timerCallback, 0, 0, periodTimer);
        }

        private Random rand;

        private readonly TimerCallback timerCallback;
        private Timer timer;
        
        private int show_Rand;
        public int Show_Rand 
        { 
            get => show_Rand;
            private set
            {
                show_Rand = value;
                OnPropertyChanged();
                Debug.WriteLine($"{Show_Rand}");
            }
        }

        private int periodTimer = 2000;
    
        #region
        private void GetRandNum(Object sender)
        {
            Show_Rand = rand.Next();
        }

        public bool TimerCountUp()
        {
            if (periodTimer >= 10000)
            {
                timer.Change(0, 1000);
                return false;
            }

            periodTimer += 1000;
            return timer.Change(0, periodTimer);

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