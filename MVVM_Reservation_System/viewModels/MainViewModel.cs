namespace MVVM_Reservation_System.viewModels;

public class MainViewModel : ViweModeBase
{

    public ViweModeBase CurrentMode { get; }

    public MainViewModel()
    {

        CurrentMode = new MakeResrvationViewModel();
    }


}