using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Reservation_System.Models
{
   public class Reservation
    {

        public RoomID RoomID { get; }

        public String UserName { get; }

        public DateTime StartTime { get; }
        public DateTime EndTime { get; }

        public TimeSpan Lenght => EndTime.Subtract(StartTime);


        public Reservation(RoomID roomID , DateTime startTime,DateTime endTime , String userName) {
            

        
        
          RoomID = roomID;
          StartTime = startTime;
          EndTime = endTime;
            UserName = userName;

        }


        public bool Conflicts(Reservation reservation)
        {
            if(reservation.RoomID.Equals (RoomID))
            {

                return false;
            }
        
        
        return reservation.StartTime < EndTime && reservation.EndTime < StartTime;
        
        }






    }
}
