using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infection
{
    public class ButtonCell : Button
    {
        public ButtonCell()
        {
            State = 0;
            TimeImmune = 0;
            TimeInfected = 0;
        }

        public int State { get; set; }
        public int TimeInfected { get; set; }
        public int TimeImmune { get; set; }
    }
}
