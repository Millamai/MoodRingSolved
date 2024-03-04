using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MoodRingSolved
{
    public class MoodRing
    {

        public Moods Mood { get; set; }
        private  Random rnd = new Random();
        public enum Moods
        {
            Default,
            Creative,
            Romantic,
            Uncertain,
            Comfortable
        }


        public MoodRing()
        {
            //Her sættes ringen til at være default
            Mood = Moods.Default;
        }

        //Finder et random humør
        public Moods FindMyMood() {
            Type type = typeof(Moods);
            Array values = type.GetEnumValues();
            return (Moods)values.GetValue(rnd.Next(values.Length));
        }
    }
}
