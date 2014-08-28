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
    public partial class Form2 : Form
    {
        private event Action SomeStaticEvent;

        public Form2()
        {
            InitializeComponent();
            SomeStaticEvent += DoSomething;
        }

        Form1 form1;

        public Form2(Form1 frm)
        {
            InitializeComponent();
            form1 = new Form1();
            form1.SomeStaticEvent += DoSomething;
        }

        private void DoSomething()
        {
        }

        protected override void OnClosed(EventArgs e)
        {
            //form1.SomeStaticEvent -= DoSomething;
            base.OnClosed(e);
        }
    }
}
