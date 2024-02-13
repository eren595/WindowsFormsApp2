using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngilis_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Merhaba " +txtAdSoyad.Text);
        }

        private void btngilis_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGiris.Text = "Tıkla";
            btnGiris.Location =new Point(100,60);
            btnGiris.Size=new Size(100,30);
            btnGiris.ForeColor=Color.White;
            btnGiris.BackColor = Color.Black;
            btnGiris.TabIndex = 2;

            txtAdSoyad.Location = new Point(75,10);
            txtAdSoyad.Size = new Size(100,30);
            txtAdSoyad.TabIndex = 1;

            this.Controls.Add(lblAdSoyad);
            this.Controls.Add(txtAdSoyad);
            this.Controls.Add(btnGiris);
        }
    }
}
