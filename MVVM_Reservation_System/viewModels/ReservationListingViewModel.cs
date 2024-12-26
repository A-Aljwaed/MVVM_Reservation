using System.Collections.ObjectModel;
using System.Windows.Input;
using MVVM_Reservation_System.Models;

namespace MVVM_Reservation_System.viewModels;

public class ReservationListingViewModel : ViweModeBase
{

    private readonly ObservableCollection<ReservationViewModel> _reservations;
    
    
    public IEnumerable<ReservationViewModel> Reservations => _reservations;

    public ICommand MakeResrvationCommand { get; }

    public ReservationListingViewModel()
    {

        _reservations = new ObservableCollection<ReservationViewModel>();


    }






}