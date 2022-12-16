using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.IO;
namespace Game
{
    public partial class GameForm : Form
    {
        private GamePanel gp;
        public Thread t;
        public StreamReader sr;
        public StreamWriter sw;

        public GameForm(IntroForm introform, User user)       
        {
            InitializeComponent();
            this.gp = new GamePanel(user,Mode.Single);
            gp.gf = this;
            gp.introform = introform;
            Controls.Add(gp);
            gp.StartGame();
        }
    }
}
