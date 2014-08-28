using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MemoryLeak
{
    public partial class Form1 : Form
    {
        public event Action SomeStaticEvent;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 frm = new Form2();
            Form2 frm = new Form2(this);
            frm.ShowDialog();
        }
    }

    public static class StaticStuff
    {
        public static event Action SomeStaticEvent;
    }

}
