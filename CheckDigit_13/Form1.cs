using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckDigit_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
         
        private void Tx1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Tx1_KeyPress(object sender, KeyPressEventArgs e ) 
        {
            
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))) //|| (char)('.') == (e.KeyChar)))
            {
                e.Handled = true;
                label1.Text = "**กรุณากรอกเฉพาะตัวเลข 0-9**";
            }
            else
            {
                label1.Text = "";
            }
        }
        private void tx2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))) //|| (char)('.') == (e.KeyChar)))
            {
                e.Handled = true;
                label1.Text = "**กรุณากรอกเฉพาะตัวเลข 0-9**";
            }
            else
            {
                label1.Text = "";
            }
        }
        private void tx3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))) //|| (char)('.') == (e.KeyChar)))
            {
                e.Handled = true;
                label1.Text = "**กรุณากรอกเฉพาะตัวเลข 0-9**";
            }
            else
            {
                label1.Text = "";
            }
        }
        private void tx4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))) //|| (char)('.') == (e.KeyChar)))
            {
                e.Handled = true;
                label1.Text = "**กรุณากรอกเฉพาะตัวเลข 0-9**";
            }
            else
            {
                label1.Text = "";
            }
        }
        private void tx5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))) //|| (char)('.') == (e.KeyChar)))
            {
                e.Handled = true;
                label1.Text = "**กรุณากรอกเฉพาะตัวเลข 0-9**";
            }
            else
            {
                label1.Text = "";
            }
        }
        private void tx6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))) //|| (char)('.') == (e.KeyChar)))
            {
                e.Handled = true;
                label1.Text = "**กรุณากรอกเฉพาะตัวเลข 0-9**";
            }
            else
            {
                label1.Text = "";
            }
        }
        private void tx7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))) //|| (char)('.') == (e.KeyChar)))
            {
                e.Handled = true;
                label1.Text = "**กรุณากรอกเฉพาะตัวเลข 0-9**";
            }
            else
            {
                label1.Text = "";
            }
        }
        private void tx8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))) //|| (char)('.') == (e.KeyChar)))
            {
                e.Handled = true;
                label1.Text = "**กรุณากรอกเฉพาะตัวเลข 0-9**";
            }
            else
            {
                label1.Text = "";
            }
        }
        private void tx9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))) //|| (char)('.') == (e.KeyChar)))
            {
                e.Handled = true;
                label1.Text = "**กรุณากรอกเฉพาะตัวเลข 0-9**";
            }
            else
            {
                label1.Text = "";
            }
        }
        private void tx10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))) //|| (char)('.') == (e.KeyChar)))
            {
                e.Handled = true;
                label1.Text = "**กรุณากรอกเฉพาะตัวเลข 0-9**";
            }
            else
            {
                label1.Text = "";
            }
        }
        private void tx11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))) //|| (char)('.') == (e.KeyChar)))
            {
                e.Handled = true;
                label1.Text = "**กรุณากรอกเฉพาะตัวเลข 0-9**";
            }
            else
            {
                label1.Text = "";
            }
        }
        private void Tx12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))) //|| (char)('.') == (e.KeyChar)))
            {
                e.Handled = true;
                label1.Text = "**กรุณากรอกเฉพาะตัวเลข 0-9**";
            }
            else
            {
                label1.Text = "";
            }
        }
        private void Tx13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))) //|| (char)('.') == (e.KeyChar)))
            {
                e.Handled = true;
                label1.Text = "**กรุณากรอกเฉพาะตัวเลข 0-9**";
            }
            else
            {
                label1.Text = "";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int sum,smod,total, t1, t2,t3,t4,t5,t6,t7,t8,t9,t10,t11,t12,t13;
            t1 = int.Parse(tx1.Text);
            t2 = int.Parse(tx2.Text);
            t3 = int.Parse(tx3.Text);
            t4 = int.Parse(tx4.Text);
            t5 = int.Parse(tx5.Text);
            t6 = int.Parse(tx6.Text);
            t7 = int.Parse(tx7.Text);
            t8 = int.Parse(tx8.Text);
            t9 = int.Parse(tx9.Text);
            t10 = int.Parse(tx10.Text);
            t11 = int.Parse(tx11.Text);
            t12 = int.Parse(tx12.Text);
            t13 = int.Parse(tx13.Text);
            sum = (t1*13) + (t2*12) + (t3*11) + (t4*10) + (t5*9) + (t6*8) + (t7*7) + (t8*6) + (t9*5) + (t10*4) + (t11*3) + (t12*2) ;
            label6.Text = sum.ToString();
            smod = sum % 11;
            label7.Text = smod.ToString();
            total = 11 - smod;
            label8.Text = total.ToString();
            if(total == t13)
            {
                label3.Text = "เลขบัตรถูกต้อง";
            }
            else
            {
                label3.Text = "เลขบัตรไม่ถูกต้อง";
            }
            maskedTextBox1.Text = t1.ToString() + t2.ToString() + t3.ToString() + t4.ToString() + t5.ToString() + t6.ToString() + t7.ToString() + t8.ToString() + t9.ToString() + t10.ToString() + t11.ToString() + t12.ToString()+total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tx1.Text = "";
            tx2.Text = "";
            tx3.Text = "";
            tx4.Text = "";
            tx5.Text = "";
            tx6.Text = "";
            tx7.Text = "";
            tx8.Text = "";
            tx9.Text = "";
            tx10.Text = "";
            tx11.Text = "";
            tx12.Text = "";
            tx13.Text = "";
            maskedTextBox1.Text = "";
            label1.Text = "";
            label3.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
        }
    }
}
