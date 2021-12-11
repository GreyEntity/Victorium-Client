using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using WeAreDevs_API;

namespace Victorium_pre_2._0
{
    public partial class Form1 : Form
    {
        readonly ExploitAPI api = new ExploitAPI();
        private ExploitAPI m = new ExploitAPI();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckInjected();
        }

        private void MoveSidePanel(Control TabSelect)
        {
            SelectedPanel.Height = TabSelect.Height;
            SelectedPanel.Top = TabSelect.Top;
        }

        private void ChangeColourButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(ChangeColourButton);
            if (ColourDialog.ShowDialog() == DialogResult.OK)
            {
                SelectedPanel.BackColor = ColourDialog.Color;
                TopColourPanel.BackColor = ColourDialog.Color;
                SideColourPanel.BackColor = ColourDialog.Color;
            }
        }

        private void CheckInjected()
        {
            if (api.isAPIAttached())
            {
                //The exploit is injected and now ready to execute scripts/commands
                AttachingLabel.Text = "Attached";
            }
            else
            {
                //The exploit is not injected... The client must inject
                AttachingLabel.Text = "Not Attached";
            }
        }

        private void KillRobloxButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(KillRobloxButton);
            if (Process.GetProcessesByName("RobloxPlayerBeta").Length == 0)//If Process not found run the code in the block body
            {
                MessageBox.Show("Roblox is already Closed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);//Show Message Box to tell that Roblox Process is not running
                return;
            }
            else//Process is found so run the code in the block body
            {
                try
                {
                    Process[] proc = Process.GetProcessesByName("RobloxPlayerBeta");//Store Process in a variable for easy use
                    proc[0].Kill();//Kill Process
                    MessageBox.Show("Killed Roblox!", "Yay!", MessageBoxButtons.OK, MessageBoxIcon.Warning);//Show Message box to tell that Roblox Process got terminated
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());//Show Message Box with the Exception
                }
            }
        }

        private void HomeTabButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(HomeTabButton);
        }

        private void siticoneToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneToggleSwitch1.Checked == true)
                this.TopMost = true;
            if (siticoneToggleSwitch1.Checked == false)
                this.TopMost = false;
        }

        private void ExecutorTabButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(ExecutorTabButton);

        }

        private void ButtonsTabButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(ButtonsTabButton);
        }

        private void OptionsTabButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(OptionsTabButton);
        }

        private void AttachingLabel_Click(object sender, EventArgs e)
        {

        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CheckInjected();
        }

        private void CommandLineTabButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(CommandLineTabButton);
        }
    }
}