using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Tamagotchi tama=new Tamagotchi();


        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tama.NoHagoNada();
            tama.MostrarEstatus(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tama.Comer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tama.IrAlBaño();
        }
    }
}
