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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            new Form1().Move_to_start();
        }

        private void finish_2_MouseEnter(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Leave?", "You win!", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                Close();
            }
            else if (res == DialogResult.No)
            {
                Form1 Form1 = new Form1();
                Form1.ShowDialog();
                this.Close();
            }
        }

       

        private void label21_MouseEnter(object sender, EventArgs e)
        {
            new Form1().Move_to_start();
        }

       

        private void label28_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Open window two?", "One", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult res = MessageBox.Show("Open window three?", "Two", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show($"You pressed {res}", $"Window three");
            }
            else if (res == DialogResult.No)
            {
                
                this.Close();
            }
            
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Clip = this.Bounds;
            new Form1().Move_to_start();
        }
    }
}
