using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Move_to_start();
            
        }

        private void finish_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You go to the second level");
            Form Form2=new Form2();
            Form2.ShowDialog();
            Close();
        }
        public void Move_to_start()
        {
            Point start_point = panel1.Location;
            start_point.Offset(35, 35);
            Cursor.Position=PointToScreen(start_point);
        }

        private void label24_MouseEnter(object sender, EventArgs e)
        {
            Move_to_start();
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Clip = this.Bounds;
            Move_to_start();
        }
    }
}
