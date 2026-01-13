using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticillaParaLaRecuperacioncillaEX
{
    public class MetodillosSueltacillos
    {
        public static int random(int min, int max)
        {
            Random rnd = new Random();
            int random = rnd.Next(min, max + 1);
            return random;
        }

    }
}
