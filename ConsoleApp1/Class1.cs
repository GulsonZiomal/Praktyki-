using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TallGuy : IClown
    {
        public string Name;
        public int Height;

        public string FunnyThingIHave
        {
            get { return "Duże buty"; }
        }

        public void Honk()
        {
            Console.WriteLine("Hej dzieciaki! Mam" + FunnyThingIHave);
        }

        public void TalkAboutYourself()
        {
            Console.WriteLine("nazywam się " + Name + " i mam " + Height + "cm wzrostu");
        }
    }

    class FunnyFunny : IClown
    {
        public FunnyFunny(string funnyThingIHave)
        {
            this.funnnyThingIHave = funnyThingIHave;
        }
        private string funnyThingIHave;
        private string funnnyThingIHave;

        public string FunnnyThingIHave
        {
            get { return "Cześć dzieciaki! Mam" + funnyThingIHave; }
        }

        public string FunnyThingIHave => throw new NotImplementedException();

        public void Hank()
        {
            Console.WriteLine(this.FunnnyThingIHave);
        }

        public void Honk()
        {
            
        }
    }
    class ScaryScary : FunnyFunny, IScaryClown
    {
        public ScaryScary(string funnyThingIHave, int numberOfScaryThings) : base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }
        private int numberOfScaryThings;
        public string ScaryThingIHave
        {
            get { return "Mam " + numberOfScaryThings + " pająków"; }
        }

        public void ScareLittleChildren()
        {
            Console.WriteLine("Buu! Mam Cie!");
        }

        public string scarryThingsIHave => throw new NotImplementedException();

    }
}
