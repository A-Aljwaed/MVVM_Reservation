

using MVVM_Reservation_System.Models;
using System.Runtime.Serialization;

namespace MVVM_Reservation_System.Exceptions
{
    public class ReservationConflictsException : Exception
    {
        private Reservation reservation;

        public Reservation ExistingReservation { get; }

        public Reservation IncomingReservation { get; }

  

        public ReservationConflictsException(String message,Reservation existingReservation , Reservation incomingReservation)
        {
            ExistingReservation = existingReservation;
            IncomingReservation = incomingReservation;
        }

        protected ReservationConflictsException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        public ReservationConflictsException(string? message) : base(message) { }

        public ReservationConflictsException(string? message, Exception? innerException) : base(message, innerException) { }

        public ReservationConflictsException(Reservation existingReservation, Reservation reservation)
        {
            ExistingReservation = existingReservation;
            this.reservation = reservation;
        }
    }
}
