using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace RS232_시리얼통신_1
{
    public partial class Form1 : Form
    {
        /*------------------------------------------------------------------------
        * 시리얼 통신 변수
        *-----------------------------------------------------------------------*/

        SerialPort my_serial = new SerialPort(); // 시리얼 포트 변수 생성 my_serial
        delegate void SetTextCallBack(string opt); // callback 함수
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_comdev_MouseClick(object sender, MouseEventArgs e) // 마우스를 클릭하였을 때 동작되는 함수
        {
            comboBox_comdev.Items.Clear(); //comboBox_comdev 콤보박스 변수
            foreach (string comport in SerialPort.GetPortNames())
            {
                comboBox_comdev.Items.Add(comport);
            }
        }

        private void comboBox_comdev_SelectedIndexChanged(object sender, EventArgs e) // 콤보박스 선택 아이템 선택했을 때 동작되는 함수
        {

        }

        private void button_cmd_Click(object sender, EventArgs e) //버튼 클릭하였을 때 동작되는 함수
        {

        }
    }
}
