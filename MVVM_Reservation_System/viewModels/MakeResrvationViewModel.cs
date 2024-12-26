using System.Security.Cryptography;
using System.Windows.Input;

namespace MVVM_Reservation_System.viewModels;

public class MakeResrvationViewModel : ViweModeBase
{


    private string _userName;

    public string UserName
    {
        
        get { return _userName; }
        set
        {
            _userName = value; 
            OnPropertyChanged(nameof(UserName));
        }
        
    }

    private int _roomNr;

    public int RoomNr
    {
        get { return _roomNr; }

        set
        {
            _roomNr = value;
            OnPropertyChanged(nameof(RoomNr));
        }
    }

    private int _floorNr;

    public int FloorNr
    {
        get { return _floorNr; }
        set
        {
            _floorNr = value;
            OnPropertyChanged(nameof(FloorNr));
        }
    }

    
    private DateTime _startdate;

    public DateTime StartDate
    {
        get { return _startdate; }
        set
        {
            _startdate = value;
            OnPropertyChanged(nameof(StartDate));
        }
    }
    
    
    private DateTime _enddate;

    public DateTime EndDate
    {
        get { return _enddate; }
        set
        {
            _enddate = value;
        }
    }

    
    // Button
    
    public ICommand SubmitCommand { get; }
    public ICommand CancelCommand { get; }
    
    
    
    
    
    // Constructure

    public MakeResrvationViewModel()
    {
        
    }
    
}