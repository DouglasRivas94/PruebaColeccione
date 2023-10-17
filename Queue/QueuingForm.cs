using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue
{
    public partial class QueuingForm : Form
    {
        public QueuingForm()
        {
            InitializeComponent();
            lblposition.Text = GetPosition();
        }

        private void btncashier_Click(object sender, EventArgs e)
        {
            
        }

         private static int number = 1;
        Queue<int> position = new Queue<int>();

        public static string GetPosition()
        {
            string na;
            na = number.ToString("D4");
            number++;
            return na;
        }

    }
}
