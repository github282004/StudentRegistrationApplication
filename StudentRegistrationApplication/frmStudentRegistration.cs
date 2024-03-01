using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            {
                ComboBox myBox = new ComboBox();
                dayBox.Items.Add(i.ToString());
            }
            for (int i = 1; i <= 12; i++)
            {
                ComboBox myBox = new ComboBox();
                monthBox.Items.Add(i.ToString());
            }
            for (int i = 1990; i <= 2024; i++)
            {
                ComboBox myBox = new ComboBox();
                yearBox.Items.Add(i.ToString());
            }
        }
    }
          
}
