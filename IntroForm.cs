using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Game
{
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
        }

        private void Play_Btn_Click(object sender, EventArgs e)
        {
            GameForm gf = new GameForm(this, User.Host);
            this.Hide();
            gf.Show();
        }
    }
}
