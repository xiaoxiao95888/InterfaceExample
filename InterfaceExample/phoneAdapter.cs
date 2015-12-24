using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class PhoneAdapter : IMobileStorage
    {
        public Phone phone { get; set; }
        public string Read()
        {
            return phone.rd();
        }

        public string Write()
        {
            return phone.wt();
        }
    }
}
