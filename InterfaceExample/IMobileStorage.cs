using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    /// <summary>
    /// 移动存储接口,两个方法，read write
    /// </summary>
    public interface IMobileStorage
    {
        string Read();
        string Write();
    }
}
