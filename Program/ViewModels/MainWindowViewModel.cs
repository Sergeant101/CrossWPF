﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using Program.Model;
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

            content = new AddItemViewModel();

            randNum = new RandFunc();

            rtest = new rTest();
       
        }

            private readonly RandFunc randNum;

            private readonly rTest rtest;

            // for test inject command
            private int count;
            public int Count
            {
                get => count;
                set => this.RaiseAndSetIfChanged(ref count, value);
            }
             // end for test inject command

            public ViewModelBase Content
            {
                get => content;
                private set => this.RaiseAndSetIfChanged(ref content, value);
            }            

            public void rTestView()
            {
                Content = new rTestViewModel(rtest);
            }

            public void addItemView()
            {
                Content = new AddItemViewModel();
            }

            public void clockFaceView()
            {
                Content = new ClockFaceViewModel();
            }

            public void showRandNumbs()
            {                
                Content = new RandNumViewModel(randNum);
            }

            public void NordWindPostgre()
            {                
                Content = new NordWindPostgreViewModel();
            }
            

        // test inject control command in VM MVVM
        public void IncCount(object sender, object parameter) 
        {
            var a = (AvaloniaPropertyChangedEventArgs)parameter;
            var b = a?.NewValue;
            
            if (b != null)
            {              

                if (b.GetType() == typeof(ClockFaceViewModel))
                {
                    Count++;
                }
            }
            

        }
        
    }
}
