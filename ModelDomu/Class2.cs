using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDomu
{
   public partial class Form : Form1
    {
        Location currentLocation;

        RoomWithDoor livingRoom;
        Room diningRoom;
        RoomWithDoor kitchen;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        Outside garden;

        public Form(Location currentLocation, RoomWithDoor livingRoom, Room diningRoom, RoomWithDoor kitchen, OutsideWithDoor frontYard, OutsideWithDoor backYard, Outside garden)
        {
            this.currentLocation = currentLocation;
            this.livingRoom = livingRoom;
            this.diningRoom = diningRoom;
            this.kitchen = kitchen;
            this.frontYard = frontYard;
            this.backYard = backYard;
            this.garden = garden;
        }
    }
}
