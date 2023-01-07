using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using ReactiveUI;

namespace Program.ViewModels
{
    internal class rTestViewModel : ViewModelBase
    {

        public rTestViewModel()
        {
            colorBrushList = new ObservableCollection<string>(MockSrtingColorBrush());
        }

        private ObservableCollection<string> colorBrushList = null!;

        public ObservableCollection<string> ColorBrushList
        {
            get => colorBrushList;
            set => this.RaiseAndSetIfChanged(ref colorBrushList, value);
        }

        private int selectedIndex;
        public int SelectedIndex
        {
            get => selectedIndex;
            set => this.RaiseAndSetIfChanged(ref selectedIndex, value);
        }

        private IEnumerable<string> MockSrtingColorBrush()
        {
            var defaultBrush = new List<string>()
            {
                new string("#F00000"),
                new string("#FA0000"),
                new string("#FB0000"),
                new string("#FC0000"),
                new string("#FD0000"),
                new string("#FF0000"),
                new string("#FFA000"),
                new string("#FFB000"),
                new string("#FFC000"),
                new string("#FFF000"),
                new string("#FFFA00"),
                new string("#FFFB00"),
                new string("#FFFC00"),
                new string("#FFFF00"),
                new string("#FFFFA0"),
                new string("#FFFFB0"),
                new string("#FFFFC0"),
                new string("#FFFFF0"),
                new string("#FFFFFA"),
                new string("#FFFFFB"),
                new string("#FFFFFC"),
                new string("#FFFFFF")
            };

            return defaultBrush;
        }
        
    }
}