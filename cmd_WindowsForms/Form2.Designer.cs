namespace cmd_WindowsForms
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.передачаЗначенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPassByFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPassByNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPassByFild = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 282);
            this.textBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.передачаЗначенийToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(340, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // передачаЗначенийToolStripMenuItem
            // 
            this.передачаЗначенийToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPassByFile,
            this.menuPassByNew,
            this.menuPassByFild});
            this.передачаЗначенийToolStripMenuItem.Name = "передачаЗначенийToolStripMenuItem";
            this.передачаЗначенийToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.передачаЗначенийToolStripMenuItem.Text = "Передача значений";
            // 
            // menuPassByFile
            // 
            this.menuPassByFile.Name = "menuPassByFile";
            this.menuPassByFile.Size = new System.Drawing.Size(198, 22);
            this.menuPassByFile.Text = "Через файл";
            this.menuPassByFile.Click += new System.EventHandler(this.menuPassByFile_Click);
            // 
            // menuPassByNew
            // 
            this.menuPassByNew.Name = "menuPassByNew";
            this.menuPassByNew.Size = new System.Drawing.Size(198, 22);
            this.menuPassByNew.Text = "Через конструктор";
            this.menuPassByNew.Click += new System.EventHandler(this.menuPassByNew_Click);
            // 
            // menuPassByFild
            // 
            this.menuPassByFild.Name = "menuPassByFild";
            this.menuPassByFild.Size = new System.Drawing.Size(198, 22);
            this.menuPassByFild.Text = "Через свойства класса";
            this.menuPassByFild.Click += new System.EventHandler(this.menuPassByFild_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 306);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem передачаЗначенийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPassByFile;
        private System.Windows.Forms.ToolStripMenuItem menuPassByNew;
        private System.Windows.Forms.ToolStripMenuItem menuPassByFild;
    }
}