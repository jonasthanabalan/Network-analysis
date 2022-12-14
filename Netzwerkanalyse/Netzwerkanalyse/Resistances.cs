using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netzwerkanalyse
{
    internal class Resistances
    {
        public void write(double[] resistances)
        {
            using (var sr = new StreamWriter("resistances.dat"))
            {
                foreach (int value in resistances)
                {
                    sr.Write(value + ", ");
                }
            }
        }
    }
}
