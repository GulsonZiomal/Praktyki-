using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDomu
{
    abstract class Location
    {
        public Location(string name)
        {
            name = name;
        }
        public Location[] Exits;
        public string Name { get; private set; }

        public virtual string Description
        {
            get
            {
                string description = "Stoisz w " + Name + ". Widzisz wyjścia do następujących lokalizacji: ";
                for (int i = 0; i < Exits.Length; i++)
                {
                    description += " " + Exits[i].Name;
                    if (i != Exits.Length - 1)
                        description += ",";
                }
                description += ".";
                return description;
            }
        }
    }
    class Room : Location
    {
        private string decoration;

        public Room(string name, string decoration) : base(name)
        {
            this.decoration = decoration;
        }
        public override string Description
        {
            get
            {
                return base.Description + "widzisz tutaj " + decoration + ".";
            }
        }
    }
    class RoomWithDoor : Room, IHasExteriorDoor
    {

        public RoomWithDoor(string name, string decoration, string doorDescription) : base(name, decoration)
        {
            doorDescription = doorDescription;
        }

        public string DoorDescription { get; private set; }
        
        public Location Doorlocation { get; set; }
        public Location DoorLocation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    class Outside : Location
    {
        private bool hot;
        
        public Outside(string name, bool hot) : base(name)
        {
            this.hot = hot;
        }

        public override string Description
        {
            get
            {
                string NewDescription = base.Description;
                if (hot)
                    NewDescription += "Tutaj jest bardzo gorąco";
                return NewDescription; 
            }
        }
    }

    class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public OutsideWithDoor(string name, bool hot, string doorDescription) : base(name, hot)
        {
            this.DoorDescription = doorDescription;
        }
         public string DoorDescription { get; private set;}

        public Location Doorlocation { get; set; }
        public Location DoorLocation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string Description
        {
            get { return base.Description + " Widzisz teraz " + DoorDescription + "."; }
        }
    }
}
