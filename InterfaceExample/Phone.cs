using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    /// <summary>
    /// 隔壁二狗子给我的IPHONE，他压根就不知道有IMobileStorage接口，我们需要一个适配器来转换一下rd wt方法
    /// </summary>
    public class Phone
    {
        public string rd()
        {
            return "读取iphone";
        }
        public string wt()
        {
            return "写入iphone";
        }
    }
}
