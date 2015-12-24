using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class FlashDisk : IMobileStorage
    {
        public string Read()
        {
            return "正在读取U盘";
        }

        public string Write()
        {
            return "正在写入U盘";
        }
    }
}
