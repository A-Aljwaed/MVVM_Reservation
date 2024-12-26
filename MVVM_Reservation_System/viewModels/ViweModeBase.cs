using System.ComponentModel;

namespace MVVM_Reservation_System.viewModels;

public class ViweModeBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;


    protected void OnPropertyChanged(string propertyName)
    {
        
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        
    }
}