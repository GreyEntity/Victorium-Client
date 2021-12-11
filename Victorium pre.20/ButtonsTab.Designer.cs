
namespace Victorium_pre_2._0
{
    partial class ButtonsTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flatToggle1 = new FlatUI.FlatToggle();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneVScrollBar1 = new Siticone.Desktop.UI.WinForms.SiticoneVScrollBar();
            this.SuspendLayout();
            // 
            // flatToggle1
            // 
            this.flatToggle1.BackColor = System.Drawing.Color.Transparent;
            this.flatToggle1.Checked = false;
            this.flatToggle1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatToggle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatToggle1.Location = new System.Drawing.Point(262, 184);
            this.flatToggle1.Name = "flatToggle1";
            this.flatToggle1.Options = FlatUI.FlatToggle._Options.Style1;
            this.flatToggle1.Size = new System.Drawing.Size(76, 33);
            this.flatToggle1.TabIndex = 1;
            this.flatToggle1.Text = "flatToggle1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(197)))), ((int)(((byte)(201)))));
            this.label1.Location = new System.Drawing.Point(185, -9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // siticoneVScrollBar1
            // 
            this.siticoneVScrollBar1.HoverState.Parent = null;
            this.siticoneVScrollBar1.InUpdate = false;
            this.siticoneVScrollBar1.LargeChange = 10;
            this.siticoneVScrollBar1.Location = new System.Drawing.Point(0, 0);
            this.siticoneVScrollBar1.Name = "siticoneVScrollBar1";
            this.siticoneVScrollBar1.PressedState.Parent = this.siticoneVScrollBar1;
            this.siticoneVScrollBar1.ScrollbarSize = 18;
            this.siticoneVScrollBar1.Size = new System.Drawing.Size(18, 321);
            this.siticoneVScrollBar1.TabIndex = 3;
            this.siticoneVScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.siticoneVScrollBar1_Scroll);
            // 
            // ButtonsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.siticoneVScrollBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flatToggle1);
            this.Name = "ButtonsTab";
            this.Size = new System.Drawing.Size(558, 321);
            this.Load += new System.EventHandler(this.ButtonsTab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlatUI.FlatToggle flatToggle1;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneVScrollBar siticoneVScrollBar1;
    }
}
