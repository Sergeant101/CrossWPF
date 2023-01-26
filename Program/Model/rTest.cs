using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using ReactiveUI;

namespace Program.Model
{
    internal class rTest: INewBrushList
    {

        public rTest()
        {
            BrushList = new ObservableCollection<string>(GetStartBrushList());
        }

        private ObservableCollection<string> brushList = null!;
        public ObservableCollection<string> BrushList 
            { get => brushList; 
            private set => brushList = value; }

        public void AddSquare()
        {

        }
        public void DeleteSquare()
        {

        }
        public void ChangeColorSquare(int SelectElement)
        {
            // condition against crash (SelectElement == -1)
            if(SelectElement >= 0)
            {
                BrushList[SelectElement] = GetRandBrush();
            }
        }

        private List<string> GetStartBrushList()
        {

            var NewBrushList = new List<string>();
            var random = new Random();
            var count = random.Next(50, 70);

            for(int i = 0; i < count; i++)
            {
                NewBrushList.Add(GetRandBrush());
            }

            return NewBrushList;
        }

        private string GetRandBrush()
        {
            var color = "#";

            for( int i = 0; i < 6; i++ )
            {
                color += quadrant();
            }

            return color;

            string quadrant()
            {
                var random = new Random();
                var select = random.Next(0, 15);
                string ret;

                if (select < 10)
                {
                    return select.ToString();
                }

                switch(select)
                {
                    case 10:
                    ret = "A";
                    break;

                    case 11:
                    ret = "B";
                    break;

                    case 12:
                    ret = "C";
                    break;

                    case 13:
                    ret = "D";
                    break;

                    case 14:
                    ret = "E";
                    break;

                    default:
                    ret = "F";
                    break;
                }

                return ret;
            } 
        }
    }
}