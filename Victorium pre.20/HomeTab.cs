using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using FastColoredTextBoxNS;
using WeAreDevs_API;

namespace Victorium_pre_2._0
{
    public partial class HomeTab : UserControl
    {
        readonly ExploitAPI api = new ExploitAPI();
        private ExploitAPI m = new ExploitAPI();
        private Point lastPoint;
        public HomeTab()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e) => this.m.LaunchExploit();

        private void button2_Click(object sender, EventArgs e) => this.m.SendLuaScript(this.fastColoredTextBox1.Text);

        private void button6_Click(object sender, EventArgs e) => this.fastColoredTextBox1.Clear();

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Lua File (*.lua)|*.lua|Text File (*.txt)|*.txt";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                this.fastColoredTextBox1.Text = "";
                Stream stream;
                if ((stream = openFileDialog.OpenFile()) == null)
                    return;
                using (stream)
                    this.fastColoredTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("An unexpected error has occured", "OOF!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void HomeTab_Load(object sender, EventArgs e)
        {

        }
    }
}
