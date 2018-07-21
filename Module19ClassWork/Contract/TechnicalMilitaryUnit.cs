using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module19ClassWork.Contract
{
    abstract class TechnicalMilitaryUnit: MilitaryUnit
    {
        public string Mark { get; private set; }

        public TechnicalMilitaryUnit(string mark)
        {
            Mark = mark ?? throw new ArgumentNullException(nameof(mark));
        }
    }
}
