using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Computer computer = new Computer();
        private void button1_Click(object sender, EventArgs e)
        {
            computer.UsbDrive = new FlashDisk();
            textBox1.AppendText(computer.ReadData() + "\n");
            textBox1.AppendText(computer.WriteData() + "\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            computer.UsbDrive = new Mp3Player();
            textBox1.AppendText(computer.ReadData() + "\n");
            textBox1.AppendText(computer.WriteData() + "\n");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //隔壁二狗子给我的IPHONE，他压根就不知道有IMobileStorage接口，我们需要一个适配器来转换一下rd wt方法 
            var adapter = new PhoneAdapter();
            var phone = new Phone();
            adapter.phone = phone;
            computer.UsbDrive = adapter;
            textBox1.AppendText(computer.ReadData() + "\n");
            textBox1.AppendText(computer.WriteData() + "\n");
        }
    }
}
