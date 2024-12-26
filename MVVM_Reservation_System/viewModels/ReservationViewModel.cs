using MVVM_Reservation_System.Models;

namespace MVVM_Reservation_System.viewModels;

public class ReservationViewModel : ViweModeBase
{
    private readonly Reservation _reservation;


    public String RoomID => _reservation.RoomID?.ToString();

    public String UserName => _reservation.UserName;

    public DateTime StartTime => _reservation.StartTime;
    public DateTime EndTime => _reservation.EndTime;



    public ReservationViewModel(Reservation reservation)
    {
        _reservation = reservation;
        
        
    }
    
}