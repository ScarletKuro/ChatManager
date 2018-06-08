namespace ChatManager
{
    partial class ChatManagerUI
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
            this.ParseWorker = new System.ComponentModel.BackgroundWorker();
            this.TabcControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new Khendys.Controls.ExRichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new Khendys.Controls.ExRichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox3 = new Khendys.Controls.ExRichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.richTextBox4 = new Khendys.Controls.ExRichTextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.richTextBox5 = new Khendys.Controls.ExRichTextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.richTextBox6 = new Khendys.Controls.ExRichTextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.richTextBox7 = new Khendys.Controls.ExRichTextBox();
            this.AnnouncementTab = new System.Windows.Forms.TabPage();
            this.richTextBox8 = new Khendys.Controls.ExRichTextBox();
            this.GMTab = new System.Windows.Forms.TabPage();
            this.richTextBox9 = new Khendys.Controls.ExRichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TabcControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.AnnouncementTab.SuspendLayout();
            this.GMTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParseWorker
            // 
            this.ParseWorker.WorkerReportsProgress = true;
            this.ParseWorker.WorkerSupportsCancellation = true;
            this.ParseWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ParseWorker_DoWork);
            // 
            // TabcControl
            // 
            this.TabcControl.Controls.Add(this.tabPage1);
            this.TabcControl.Controls.Add(this.tabPage2);
            this.TabcControl.Controls.Add(this.tabPage3);
            this.TabcControl.Controls.Add(this.tabPage4);
            this.TabcControl.Controls.Add(this.tabPage5);
            this.TabcControl.Controls.Add(this.tabPage6);
            this.TabcControl.Controls.Add(this.tabPage7);
            this.TabcControl.Controls.Add(this.AnnouncementTab);
            this.TabcControl.Controls.Add(this.GMTab);
            this.TabcControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabcControl.Location = new System.Drawing.Point(0, 0);
            this.TabcControl.Name = "TabcControl";
            this.TabcControl.SelectedIndex = 0;
            this.TabcControl.Size = new System.Drawing.Size(772, 519);
            this.TabcControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(764, 493);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.HiglightColor = Khendys.Controls.RtfColor.White;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(758, 487);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextColor = Khendys.Controls.RtfColor.Black;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(764, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Whisper";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.White;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.ForeColor = System.Drawing.Color.Purple;
            this.richTextBox2.HiglightColor = Khendys.Controls.RtfColor.White;
            this.richTextBox2.Location = new System.Drawing.Point(3, 3);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox2.Size = new System.Drawing.Size(758, 487);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextColor = Khendys.Controls.RtfColor.Black;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTextBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(764, 493);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Party";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.White;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.richTextBox3.HiglightColor = Khendys.Controls.RtfColor.White;
            this.richTextBox3.Location = new System.Drawing.Point(3, 3);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox3.Size = new System.Drawing.Size(758, 487);
            this.richTextBox3.TabIndex = 1;
            this.richTextBox3.Text = "";
            this.richTextBox3.TextColor = Khendys.Controls.RtfColor.Black;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.richTextBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(764, 493);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Guild";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.Color.White;
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox4.ForeColor = System.Drawing.Color.Green;
            this.richTextBox4.HiglightColor = Khendys.Controls.RtfColor.White;
            this.richTextBox4.Location = new System.Drawing.Point(3, 3);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox4.Size = new System.Drawing.Size(758, 487);
            this.richTextBox4.TabIndex = 1;
            this.richTextBox4.Text = "";
            this.richTextBox4.TextColor = Khendys.Controls.RtfColor.Black;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.richTextBox5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(764, 493);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Region";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.Color.White;
            this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox5.ForeColor = System.Drawing.Color.Navy;
            this.richTextBox5.HiglightColor = Khendys.Controls.RtfColor.White;
            this.richTextBox5.Location = new System.Drawing.Point(3, 3);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ReadOnly = true;
            this.richTextBox5.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox5.Size = new System.Drawing.Size(758, 487);
            this.richTextBox5.TabIndex = 1;
            this.richTextBox5.Text = "";
            this.richTextBox5.TextColor = Khendys.Controls.RtfColor.Black;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.richTextBox6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(764, 493);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "World";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // richTextBox6
            // 
            this.richTextBox6.BackColor = System.Drawing.Color.White;
            this.richTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.richTextBox6.HiglightColor = Khendys.Controls.RtfColor.White;
            this.richTextBox6.Location = new System.Drawing.Point(3, 3);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.ReadOnly = true;
            this.richTextBox6.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox6.Size = new System.Drawing.Size(758, 487);
            this.richTextBox6.TabIndex = 1;
            this.richTextBox6.Text = "";
            this.richTextBox6.TextColor = Khendys.Controls.RtfColor.Black;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.richTextBox7);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(764, 493);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Trade";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // richTextBox7
            // 
            this.richTextBox7.BackColor = System.Drawing.Color.White;
            this.richTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox7.ForeColor = System.Drawing.Color.Maroon;
            this.richTextBox7.HiglightColor = Khendys.Controls.RtfColor.White;
            this.richTextBox7.Location = new System.Drawing.Point(3, 3);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.ReadOnly = true;
            this.richTextBox7.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox7.Size = new System.Drawing.Size(758, 487);
            this.richTextBox7.TabIndex = 1;
            this.richTextBox7.Text = "";
            this.richTextBox7.TextColor = Khendys.Controls.RtfColor.Black;
            // 
            // AnnouncementTab
            // 
            this.AnnouncementTab.Controls.Add(this.richTextBox8);
            this.AnnouncementTab.Location = new System.Drawing.Point(4, 22);
            this.AnnouncementTab.Name = "AnnouncementTab";
            this.AnnouncementTab.Padding = new System.Windows.Forms.Padding(3);
            this.AnnouncementTab.Size = new System.Drawing.Size(764, 493);
            this.AnnouncementTab.TabIndex = 7;
            this.AnnouncementTab.Text = "Announcement";
            this.AnnouncementTab.UseVisualStyleBackColor = true;
            // 
            // richTextBox8
            // 
            this.richTextBox8.BackColor = System.Drawing.Color.White;
            this.richTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.richTextBox8.HiglightColor = Khendys.Controls.RtfColor.White;
            this.richTextBox8.Location = new System.Drawing.Point(3, 3);
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.ReadOnly = true;
            this.richTextBox8.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox8.Size = new System.Drawing.Size(758, 487);
            this.richTextBox8.TabIndex = 1;
            this.richTextBox8.Text = "";
            this.richTextBox8.TextColor = Khendys.Controls.RtfColor.Black;
            // 
            // GMTab
            // 
            this.GMTab.Controls.Add(this.richTextBox9);
            this.GMTab.Location = new System.Drawing.Point(4, 22);
            this.GMTab.Name = "GMTab";
            this.GMTab.Padding = new System.Windows.Forms.Padding(3);
            this.GMTab.Size = new System.Drawing.Size(764, 493);
            this.GMTab.TabIndex = 8;
            this.GMTab.Text = "GM";
            this.GMTab.UseVisualStyleBackColor = true;
            // 
            // richTextBox9
            // 
            this.richTextBox9.BackColor = System.Drawing.Color.White;
            this.richTextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.richTextBox9.HiglightColor = Khendys.Controls.RtfColor.White;
            this.richTextBox9.Location = new System.Drawing.Point(3, 3);
            this.richTextBox9.Name = "richTextBox9";
            this.richTextBox9.ReadOnly = true;
            this.richTextBox9.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox9.Size = new System.Drawing.Size(758, 487);
            this.richTextBox9.TabIndex = 1;
            this.richTextBox9.Text = "";
            this.richTextBox9.TextColor = Khendys.Controls.RtfColor.Black;
            // 
            // ChatManagerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 519);
            this.Controls.Add(this.TabcControl);
            this.Name = "ChatManagerUI";
            this.Text = "Chat Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatManagerUI_FormClosing);
            this.Load += new System.EventHandler(this.ChatManagerUI_Load);
            this.VisibleChanged += new System.EventHandler(this.ChatManagerUI_VisibleChanged);
            this.TabcControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.AnnouncementTab.ResumeLayout(false);
            this.GMTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.ComponentModel.BackgroundWorker ParseWorker;
        private System.Windows.Forms.TabControl TabcControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage AnnouncementTab;
        private System.Windows.Forms.TabPage GMTab;
        private Khendys.Controls.ExRichTextBox richTextBox1;
        private Khendys.Controls.ExRichTextBox richTextBox2;
        private Khendys.Controls.ExRichTextBox richTextBox3;
        private Khendys.Controls.ExRichTextBox richTextBox4;
        private Khendys.Controls.ExRichTextBox richTextBox5;
        private Khendys.Controls.ExRichTextBox richTextBox6;
        private Khendys.Controls.ExRichTextBox richTextBox7;
        private Khendys.Controls.ExRichTextBox richTextBox8;
        private Khendys.Controls.ExRichTextBox richTextBox9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;

    }
}