namespace Poznamky
{
    partial class Form_Update
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.NoteUpdate_Button = new System.Windows.Forms.Button();
            this.Back_Form1_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(204, 26);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(217, 20);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Location = new System.Drawing.Point(164, 92);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(302, 155);
            this.NoteTextBox.TabIndex = 1;
            this.NoteTextBox.TextChanged += new System.EventHandler(this.NoteTextBox_TextChanged);
            // 
            // NoteUpdate_Button
            // 
            this.NoteUpdate_Button.Location = new System.Drawing.Point(259, 280);
            this.NoteUpdate_Button.Name = "NoteUpdate_Button";
            this.NoteUpdate_Button.Size = new System.Drawing.Size(124, 58);
            this.NoteUpdate_Button.TabIndex = 2;
            this.NoteUpdate_Button.Text = "Aktualizovat";
            this.NoteUpdate_Button.UseVisualStyleBackColor = true;
            this.NoteUpdate_Button.Click += new System.EventHandler(this.NoteUpdate_Button_Click);
            // 
            // Back_Form1_Button
            // 
            this.Back_Form1_Button.Location = new System.Drawing.Point(63, 381);
            this.Back_Form1_Button.Name = "Back_Form1_Button";
            this.Back_Form1_Button.Size = new System.Drawing.Size(124, 58);
            this.Back_Form1_Button.TabIndex = 3;
            this.Back_Form1_Button.Text = "Zpět";
            this.Back_Form1_Button.UseVisualStyleBackColor = true;
            this.Back_Form1_Button.Click += new System.EventHandler(this.Back_Form1_Button_Click);
            // 
            // Form_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 487);
            this.Controls.Add(this.Back_Form1_Button);
            this.Controls.Add(this.NoteUpdate_Button);
            this.Controls.Add(this.NoteTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "Form_Update";
            this.Text = "Form_Update";
            this.Load += new System.EventHandler(this.Form_Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.Button NoteUpdate_Button;
        private System.Windows.Forms.Button Back_Form1_Button;
    }
}