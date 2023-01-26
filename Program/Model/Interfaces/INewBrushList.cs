using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;


    public interface INewBrushList
    {
        ObservableCollection<string> BrushList{get; }
        void AddSquare();
        void DeleteSquare();
        void ChangeColorSquare(int SelectElement);
    }
