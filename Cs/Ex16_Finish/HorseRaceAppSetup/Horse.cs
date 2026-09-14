using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRaceAppSetup
{
    internal class Horse
    {
        string name;
        int number;

        public Horse()
        {
            name = "default";
            number = 0;
        }

        public Horse(string name, int number)
        {
            this.name = name;
            this.number = number;
        }

        public string getName() { return name; }
        public int getNumber() { return number; }
        public string getHorseInfo() {  return name + " #"+number; }
        public void setName(string name) { this.name = name; }
        public void setNumber(int number) { this.number = number; }
    }
}
