using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackOpening
{
    public enum Nation
    {
        SPAIN, ENGLAND, BRASIL
    }
    public class Player
    {
      

        private Nation nationality;
        private string name;
        public Player(string n, Nation nat)
        {
            this.name = n;
            this.nationality = nat;
        }

        public string Name() { return name; }
        public Nation Nat() {  return nationality; }
    }
}
