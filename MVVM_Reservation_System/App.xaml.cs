using MVVM_Reservation_System.Exceptions;
using MVVM_Reservation_System.Models;
using System.Configuration;
using System.Data;
using System.Linq.Expressions;
using System.Windows;

namespace MVVM_Reservation_System
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("fiveStars");

            try
            {
                Hotel hotel1 = new Hotel("Five Stars");
                hotel.MakeReservation(new Reservation(
                    new RoomID(1, 3),
                    new DateTime(2024, 1, 4),
                    new DateTime(2024, 1, 7),
                    "fiveStars"
                ));
            }
            catch (ReservationConflictsException)
            {
                // Handle exception
            }


            IEnumerable<Reservation> reservations = (IEnumerable<Reservation>)hotel.GetReservationsForUser("fiveStars");

                base.OnStartup(e);
          
        }

    }

}
