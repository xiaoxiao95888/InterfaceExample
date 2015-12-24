using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class Computer
    {
        public IMobileStorage UsbDrive { get; set; }        
        public string ReadData()
        {
            return UsbDrive.Read();
        }
        public string WriteData()
        {
            return UsbDrive.Write();
        }
    }
}
