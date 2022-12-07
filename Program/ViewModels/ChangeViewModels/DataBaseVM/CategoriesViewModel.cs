using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Program.Model.NordWindDB;

namespace Program.ViewModels;

internal class CategoriesViewModel : ViewModelBase
{
    public CategoriesViewModel()
    {
        CategoriesList = new ObservableCollection<Category>(DataWorker.GetCategories());
    }

    private ObservableCollection<Category>? categoriesList;

    public ObservableCollection<Category>? CategoriesList
    {
        get;
        private set;
    }

    // //test delete
    // public ObservableCollection<Person> People { get; }

    // private IEnumerable<Person> GenerateMockPeopleTable()
    //     {
    //         var defaultPeople = new List<Person>()
    //         {
    //             new Person()
    //             {
    //                 FirstName = "Pat", 
    //                 LastName = "Patterson", 
    //                 EmployeeNumber = 1010,
    //                 DepartmentNumber = 100, 
    //                 DeskLocation = "B3F3R5T7"
    //             },
    //             new Person()
    //             {
    //                 FirstName = "Jean", 
    //                 LastName = "Jones", 
    //                 EmployeeNumber = 973,
    //                 DepartmentNumber = 200, 
    //                 DeskLocation = "B1F1R2T3"
    //             },
    //             new Person()
    //             {
    //                 FirstName = "Terry", 
    //                 LastName = "Tompson", 
    //                 EmployeeNumber = 300,
    //                 DepartmentNumber = 100, 
    //                 DeskLocation = "B3F2R10T1"
    //             }
    //         };

    //         return defaultPeople;
    //     }

}