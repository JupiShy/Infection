using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infection
{
    public class ButtonCell : Button //дочірній клас кнопок з "обгорткою"
    {
        public ButtonCell() 
        {
            State = 0; 
            TimeImmune = 0; 
            TimeInfected = 0; 
        }

        public int State { get; set; } //стан клітини (0 - здорова, 1 - хвора, 2 - імунитет)
        public int TimeInfected { get; set; } //скільки часу клітина інфікована
        public int TimeImmune { get; set; } //скільки часу клітина має імунітет
    }
}
