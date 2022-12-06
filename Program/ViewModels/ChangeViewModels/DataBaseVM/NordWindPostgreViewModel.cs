namespace Program.ViewModels;
using ReactiveUI;

internal class NordWindPostgreViewModel: ViewModelBase
{
    public NordWindPostgreViewModel()
    {
        contentNordwind = new CategoriesViewModel();
    }

    private ViewModelBase contentNordwind;

    public ViewModelBase ContentNordwind
    {
        get => contentNordwind;
        private set => this.RaiseAndSetIfChanged(ref contentNordwind, value);
    }


    public void Product()
    {
        ContentNordwind = new ProductViewModel();
    }

     public void Categories()
    {
        ContentNordwind = new CategoriesViewModel();
    }

}