namespace ProxySwitcher
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelcontainer = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabelhint = new System.Windows.Forms.LinkLabel();
            this.checkBox_Silence = new System.Windows.Forms.CheckBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblCPS = new System.Windows.Forms.Label();
            this.NmPort = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbxIp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.rb_Custom = new System.Windows.Forms.RadioButton();
            this.RbNone = new System.Windows.Forms.RadioButton();
            this.panelcontainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmPort)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Im here";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // panelcontainer
            // 
            this.panelcontainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelcontainer.BackColor = System.Drawing.Color.Black;
            this.panelcontainer.Controls.Add(this.linkLabel1);
            this.panelcontainer.Controls.Add(this.linkLabelhint);
            this.panelcontainer.Controls.Add(this.checkBox_Silence);
            this.panelcontainer.Controls.Add(this.lblChange);
            this.panelcontainer.Controls.Add(this.lblCPS);
            this.panelcontainer.Controls.Add(this.NmPort);
            this.panelcontainer.Controls.Add(this.label2);
            this.panelcontainer.Controls.Add(this.label1);
            this.panelcontainer.Controls.Add(this.txbxIp);
            this.panelcontainer.Controls.Add(this.button1);
            this.panelcontainer.Controls.Add(this.btnOk);
            this.panelcontainer.Controls.Add(this.rb_Custom);
            this.panelcontainer.Controls.Add(this.RbNone);
            this.panelcontainer.Location = new System.Drawing.Point(12, 12);
            this.panelcontainer.Name = "panelcontainer";
            this.panelcontainer.Size = new System.Drawing.Size(354, 215);
            this.panelcontainer.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Lime;
            this.linkLabel1.Location = new System.Drawing.Point(285, 187);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(35, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Coder";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabelhint
            // 
            this.linkLabelhint.AutoSize = true;
            this.linkLabelhint.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabelhint.Location = new System.Drawing.Point(327, 3);
            this.linkLabelhint.Name = "linkLabelhint";
            this.linkLabelhint.Size = new System.Drawing.Size(13, 13);
            this.linkLabelhint.TabIndex = 9;
            this.linkLabelhint.TabStop = true;
            this.linkLabelhint.Text = "?";
            this.linkLabelhint.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelhint_LinkClicked);
            // 
            // checkBox_Silence
            // 
            this.checkBox_Silence.AutoSize = true;
            this.checkBox_Silence.ForeColor = System.Drawing.Color.White;
            this.checkBox_Silence.Location = new System.Drawing.Point(268, 3);
            this.checkBox_Silence.Name = "checkBox_Silence";
            this.checkBox_Silence.Size = new System.Drawing.Size(52, 17);
            this.checkBox_Silence.TabIndex = 8;
            this.checkBox_Silence.Text = "Silent";
            this.checkBox_Silence.UseVisualStyleBackColor = true;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(135, 130);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(13, 13);
            this.lblChange.TabIndex = 7;
            this.lblChange.Text = "..";
            this.lblChange.TextChanged += new System.EventHandler(this.lblChange_TextChanged);
            // 
            // lblCPS
            // 
            this.lblCPS.AutoSize = true;
            this.lblCPS.ForeColor = System.Drawing.Color.White;
            this.lblCPS.Location = new System.Drawing.Point(3, 187);
            this.lblCPS.Name = "lblCPS";
            this.lblCPS.Size = new System.Drawing.Size(16, 13);
            this.lblCPS.TabIndex = 6;
            this.lblCPS.Text = "...";
            // 
            // NmPort
            // 
            this.NmPort.Enabled = false;
            this.NmPort.Location = new System.Drawing.Point(135, 79);
            this.NmPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NmPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NmPort.Name = "NmPort";
            this.NmPort.Size = new System.Drawing.Size(100, 20);
            this.NmPort.TabIndex = 5;
            this.NmPort.Value = new decimal(new int[] {
            8080,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Proxy";
            // 
            // txbxIp
            // 
            this.txbxIp.Enabled = false;
            this.txbxIp.Location = new System.Drawing.Point(135, 43);
            this.txbxIp.Name = "txbxIp";
            this.txbxIp.Size = new System.Drawing.Size(100, 20);
            this.txbxIp.TabIndex = 3;
            this.txbxIp.Text = "127.0.0.1";
            this.txbxIp.TextChanged += new System.EventHandler(this.txbxIp_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(154, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Set and minimize";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.SetAndMinimize);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Gray;
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(22, 149);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(126, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Set";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // rb_Custom
            // 
            this.rb_Custom.AutoSize = true;
            this.rb_Custom.ForeColor = System.Drawing.Color.White;
            this.rb_Custom.Location = new System.Drawing.Point(22, 14);
            this.rb_Custom.Name = "rb_Custom";
            this.rb_Custom.Size = new System.Drawing.Size(89, 17);
            this.rb_Custom.TabIndex = 1;
            this.rb_Custom.Text = "Manual Proxy";
            this.rb_Custom.UseVisualStyleBackColor = true;
            this.rb_Custom.CheckedChanged += new System.EventHandler(this.rb_Custom_CheckedChanged);
            // 
            // RbNone
            // 
            this.RbNone.AutoSize = true;
            this.RbNone.Checked = true;
            this.RbNone.ForeColor = System.Drawing.Color.White;
            this.RbNone.Location = new System.Drawing.Point(22, 126);
            this.RbNone.Name = "RbNone";
            this.RbNone.Size = new System.Drawing.Size(68, 17);
            this.RbNone.TabIndex = 0;
            this.RbNone.TabStop = true;
            this.RbNone.Text = "No Proxy";
            this.RbNone.UseVisualStyleBackColor = true;
            this.RbNone.CheckedChanged += new System.EventHandler(this.RbNone_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(378, 239);
            this.Controls.Add(this.panelcontainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.96D;
            this.Text = "System Proxy Switcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelcontainer.ResumeLayout(false);
            this.panelcontainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelcontainer;
        private System.Windows.Forms.RadioButton RbNone;
        private System.Windows.Forms.TextBox txbxIp;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.RadioButton rb_Custom;
        private System.Windows.Forms.NumericUpDown NmPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCPS;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox checkBox_Silence;
        private System.Windows.Forms.LinkLabel linkLabelhint;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
    }
}

