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
            this.SendNote_Button = new System.Windows.Forms.Button();
            this.DeleteNote_Button = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.ShowNote_ListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SendNote_Button
            // 
            this.SendNote_Button.Location = new System.Drawing.Point(238, 216);
            this.SendNote_Button.Name = "SendNote_Button";
            this.SendNote_Button.Size = new System.Drawing.Size(138, 62);
            this.SendNote_Button.TabIndex = 0;
            this.SendNote_Button.Text = "Odeslat";
            this.SendNote_Button.UseVisualStyleBackColor = true;
            this.SendNote_Button.Click += new System.EventHandler(this.SendNote_Button_Click);
            // 
            // DeleteNote_Button
            // 
            this.DeleteNote_Button.Location = new System.Drawing.Point(238, 284);
            this.DeleteNote_Button.Name = "DeleteNote_Button";
            this.DeleteNote_Button.Size = new System.Drawing.Size(138, 62);
            this.DeleteNote_Button.TabIndex = 1;
            this.DeleteNote_Button.Text = "Smazat";
            this.DeleteNote_Button.UseVisualStyleBackColor = true;
            this.DeleteNote_Button.Click += new System.EventHandler(this.DeleteNote_Button_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(12, 22);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(214, 20);
            this.NameTextBox.TabIndex = 3;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Location = new System.Drawing.Point(12, 48);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(259, 159);
            this.NoteTextBox.TabIndex = 4;
            this.NoteTextBox.TextChanged += new System.EventHandler(this.NoteTextBox_TextChanged);
            // 
            // ShowNote_ListBox
            // 
            this.ShowNote_ListBox.FormattingEnabled = true;
            this.ShowNote_ListBox.Location = new System.Drawing.Point(291, 48);
            this.ShowNote_ListBox.Name = "ShowNote_ListBox";
            this.ShowNote_ListBox.Size = new System.Drawing.Size(320, 160);
            this.ShowNote_ListBox.TabIndex = 5;
            this.ShowNote_ListBox.SelectedIndexChanged += new System.EventHandler(this.ShowNote_ListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowNote_ListBox);
            this.Controls.Add(this.NoteTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.DeleteNote_Button);
            this.Controls.Add(this.SendNote_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
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
    }
}

