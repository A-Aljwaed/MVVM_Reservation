using MVVM_Reservation_System.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVVM_Reservation_System.Models
{
    public class ReservationBook
    {
        private readonly List<Reservation> _roomReservations;

        public ReservationBook()
        {
            _roomReservations = new List<Reservation>();
        }

        public IEnumerable<Reservation> GetReservationForUser(string userName)
        {
            return _roomReservations.Where(r => r.UserName == userName);
        }

        public void AddReservation(Reservation reservation)
        {
            foreach (Reservation existingReservation in _roomReservations)
            {
                if (existingReservation.Conflicts(reservation))
                {
                    throw new ReservationConflictsException(existingReservation, reservation);
                }
            }

            _roomReservations.Add(reservation);
        }
    }
}
