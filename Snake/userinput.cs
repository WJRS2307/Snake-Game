using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class userinput : Form
    {
        private String result;
       
        public userinput()
        {
            InitializeComponent();
        }

        public userinput(String result)
        {
            this.result = result;
        }
        public String getname()
        {
            return this.result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            result = input.Text;

            this.Close();
        }

        private void userinput_Load(object sender, EventArgs e)
        {

        }
    }
}
