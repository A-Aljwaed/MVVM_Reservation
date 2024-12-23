using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Reservation_System.Models
{
    public class Hotel
    {
        private readonly ReservationBook _reservationBook;

public String Name { get; }


        public Hotel(String name)
        {
            Name = name;

            _reservationBook = new ReservationBook();


        }

        public IEnumerable<ReservationBook> GetReservationsForUser (string username)
        {

            return (IEnumerable<ReservationBook>)_reservationBook.GetReservationForUser(username);
        }


        public void MakeReservation (Reservation reservation)
        {
            _reservationBook.AddReservation(reservation);
        }
    }
}
