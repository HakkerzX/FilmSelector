namespace FilmSelector.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
    }

    public FilmSelectorViewModel FilmSelector { get; } = new FilmSelectorViewModel();
}