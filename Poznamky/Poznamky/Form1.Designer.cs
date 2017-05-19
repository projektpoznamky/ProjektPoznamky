namespace Poznamky
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SendNote_Button = new System.Windows.Forms.Button();
            this.DeleteNote_Button = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.ShowNote_ListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateNote_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Close_Button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendNote_Button
            // 
            this.SendNote_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SendNote_Button.Location = new System.Drawing.Point(683, 150);
            this.SendNote_Button.Name = "SendNote_Button";
            this.SendNote_Button.Size = new System.Drawing.Size(138, 62);
            this.SendNote_Button.TabIndex = 0;
            this.SendNote_Button.Text = "Odeslat";
            this.SendNote_Button.UseVisualStyleBackColor = true;
            this.SendNote_Button.Click += new System.EventHandler(this.SendNote_Button_Click);
            // 
            // DeleteNote_Button
            // 
            this.DeleteNote_Button.Location = new System.Drawing.Point(696, 319);
            this.DeleteNote_Button.Name = "DeleteNote_Button";
            this.DeleteNote_Button.Size = new System.Drawing.Size(138, 62);
            this.DeleteNote_Button.TabIndex = 1;
            this.DeleteNote_Button.Text = "Smazat";
            this.DeleteNote_Button.UseVisualStyleBackColor = true;
            this.DeleteNote_Button.Click += new System.EventHandler(this.DeleteNote_Button_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(290, 301);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(214, 20);
            this.NameTextBox.TabIndex = 3;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Location = new System.Drawing.Point(290, 327);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(259, 159);
            this.NoteTextBox.TabIndex = 4;
            this.NoteTextBox.TextChanged += new System.EventHandler(this.NoteTextBox_TextChanged);
            // 
            // ShowNote_ListBox
            // 
            this.ShowNote_ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShowNote_ListBox.FormattingEnabled = true;
            this.ShowNote_ListBox.ItemHeight = 15;
            this.ShowNote_ListBox.Location = new System.Drawing.Point(290, 73);
            this.ShowNote_ListBox.Name = "ShowNote_ListBox";
            this.ShowNote_ListBox.Size = new System.Drawing.Size(306, 154);
            this.ShowNote_ListBox.TabIndex = 5;
            this.ShowNote_ListBox.SelectedIndexChanged += new System.EventHandler(this.ShowNote_ListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(885, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // UpdateNote_Button
            // 
            this.UpdateNote_Button.Location = new System.Drawing.Point(696, 250);
            this.UpdateNote_Button.Name = "UpdateNote_Button";
            this.UpdateNote_Button.Size = new System.Drawing.Size(138, 62);
            this.UpdateNote_Button.TabIndex = 7;
            this.UpdateNote_Button.Text = "Aktualizovat";
            this.UpdateNote_Button.UseVisualStyleBackColor = true;
            this.UpdateNote_Button.Click += new System.EventHandler(this.UpdateNote_Button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 724);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(0, 189);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 297);
            this.panel3.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(3, 148);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 44);
            this.button4.TabIndex = 13;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(3, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 44);
            this.button3.TabIndex = 12;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(3, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 44);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 27);
            this.panel5.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(63, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(26, 23);
            this.panel4.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.SeaShell;
            this.label2.Location = new System.Drawing.Point(89, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "USER";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.Close_Button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 27);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Close_Button
            // 
            this.Close_Button.BackColor = System.Drawing.SystemColors.Highlight;
            this.Close_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Close_Button.BackgroundImage")));
            this.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Close_Button.Location = new System.Drawing.Point(674, -1);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(26, 26);
            this.Close_Button.TabIndex = 0;
            this.Close_Button.UseVisualStyleBackColor = false;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            this.Close_Button.MouseLeave += new System.EventHandler(this.Close_Button_MouseLeave);
            this.Close_Button.MouseHover += new System.EventHandler(this.Close_Button_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1125, 724);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SendNote_Button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UpdateNote_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowNote_ListBox);
            this.Controls.Add(this.NoteTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.DeleteNote_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendNote_Button;
        private System.Windows.Forms.Button DeleteNote_Button;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.ListBox ShowNote_ListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateNote_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
    }
}

