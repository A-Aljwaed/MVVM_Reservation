using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Reservation_System.Models
{
    public class RoomID
    {
        private int v1;
        private int v2;

        public RoomID(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public int FloorNumber { get; }
        public int RoomNr { get; }





        // comparesion of the Rooms in the Reservation Book
        public override bool Equals(object? obj)
        {
            return obj is RoomID roomID && FloorNumber == roomID.FloorNumber
                && RoomNr == roomID.RoomNr;
        }


        // geting Uniqe Hash
        public override int GetHashCode()
        {
            return HashCode.Combine(FloorNumber, RoomNr);
        }

        public static bool operator ==(RoomID left, RoomID right) { if(left is null && right is null){ return true;  }
        
            return !(left is null && right is null);
        }


        public static bool operator !=(RoomID left, RoomID right)
        {
            return !(left == right);
        }

    }
}
