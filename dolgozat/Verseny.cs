using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat
{
    internal class Verseny
    {

        public string Name { get; set; }
        public int Birthdate { get; set; }
        public int Startnumber { get; set; }
        public string Sex { get; set; }
        public string Category { get; set; }
        public TimeSpan Swimtime { get; set; }
        public TimeSpan Depotime1 { get; set; }
        public TimeSpan Cycling { get; set; }
        public TimeSpan Depotime2 { get; set; }
        public TimeSpan Running { get; set; }

        public Verseny(string sor)
        {
            string[] sordb = sor.Split(';');
            Name = sordb[0];
            Birthdate = int.Parse(sordb[1]);
            Startnumber = int.Parse(sordb[2]);
            Sex = sordb[3];
            Category = sordb[4];
            Swimtime = TimeSpan.Parse(sordb[5]);
            Depotime1 = TimeSpan.Parse(sordb[6]);
            Cycling = TimeSpan.Parse(sordb[7]);
            Depotime2 = TimeSpan.Parse(sordb[8]);
            Running = TimeSpan.Parse(sordb[9]);
        }

        public override string ToString() =>
            $"{Name} Születési év: {Birthdate} Rajtszám: {Startnumber} Nem: {Sex} Úszásidő {Swimtime} Első depó idő {Depotime1} bicikli idő {Cycling} Második depó {Depotime2} futás ideje {Running} ";
}
}

