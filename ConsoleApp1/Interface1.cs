using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IClown
    {
        string FunnyThingIHave { get; }
        void Honk();
    }
    interface IScaryClown : IClown
    {
        string scarryThingsIHave { get; }
        void ScareLittleChildren();
    }
}
