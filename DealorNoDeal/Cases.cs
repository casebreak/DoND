using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealorNoDeal
{
    class Cases //: IComparable
    {
        public double Value { get; set; }
        public PictureBox Identifier { get; set; }
        public double WorkingValue { get; set; }

        public Cases(double value, PictureBox name)
        {
            Value = value;
            Identifier = name;
            WorkingValue = value;
        }
    }
}
