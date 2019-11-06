using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_49
{
    class ProgrammerAttribute : Attribute
    {
        private string programmerValue;
        public ProgrammerAttribute(string programmer)
        {
            programmerValue = programmer;
        }
        public string Programmer
        {
            get
            {
                return programmerValue;
            }
        }
    }
}
