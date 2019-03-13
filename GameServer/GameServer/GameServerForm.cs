using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GameServer
{
    public partial class GameServerForm : Form
    {
        public GameServerForm()
        {
            InitializeComponent();
        }
        

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void GameServerForm_Load(object sender, EventArgs e)
        {
            AllocConsole();
            
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            General.InitializeServer();
        }
    }
}
