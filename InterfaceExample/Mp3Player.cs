using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class Mp3Player : IMobileStorage
    {
        public string Read()
        {
            return "正在读取MP3";
        }

        public string Write()
        {
            return "正在写入MP3";
        }
    }
}
