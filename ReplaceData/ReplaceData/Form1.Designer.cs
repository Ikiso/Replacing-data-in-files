
namespace ReplaceData
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.загрузитьIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьИзменяемыйФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьИзминенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonExecuteTranslate = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьIdToolStripMenuItem,
            this.загрузитьИзменяемыйФайлToolStripMenuItem,
            this.сохранитьИзминенияToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(415, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // загрузитьIdToolStripMenuItem
            // 
            this.загрузитьIdToolStripMenuItem.Name = "загрузитьIdToolStripMenuItem";
            this.загрузитьIdToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.загрузитьIdToolStripMenuItem.Text = "Загрузить id";
            this.загрузитьIdToolStripMenuItem.Click += new System.EventHandler(this.загрузитьIdToolStripMenuItem_Click);
            // 
            // загрузитьИзменяемыйФайлToolStripMenuItem
            // 
            this.загрузитьИзменяемыйФайлToolStripMenuItem.Name = "загрузитьИзменяемыйФайлToolStripMenuItem";
            this.загрузитьИзменяемыйФайлToolStripMenuItem.Size = new System.Drawing.Size(179, 20);
            this.загрузитьИзменяемыйФайлToolStripMenuItem.Text = "Загрузить изменяемый файл";
            this.загрузитьИзменяемыйФайлToolStripMenuItem.Click += new System.EventHandler(this.загрузитьИзменяемыйФайлToolStripMenuItem_Click);
            // 
            // сохранитьИзминенияToolStripMenuItem
            // 
            this.сохранитьИзминенияToolStripMenuItem.Name = "сохранитьИзминенияToolStripMenuItem";
            this.сохранитьИзминенияToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.сохранитьИзминенияToolStripMenuItem.Text = "Сохранить изминения";
            this.сохранитьИзминенияToolStripMenuItem.Click += new System.EventHandler(this.сохранитьИзминенияToolStripMenuItem_Click);
            // 
            // buttonExecuteTranslate
            // 
            this.buttonExecuteTranslate.Location = new System.Drawing.Point(94, 62);
            this.buttonExecuteTranslate.Name = "buttonExecuteTranslate";
            this.buttonExecuteTranslate.Size = new System.Drawing.Size(196, 37);
            this.buttonExecuteTranslate.TabIndex = 1;
            this.buttonExecuteTranslate.Text = "Выполнить";
            this.buttonExecuteTranslate.UseVisualStyleBackColor = true;
            this.buttonExecuteTranslate.Click += new System.EventHandler(this.buttonExecuteTranslate_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 147);
            this.Controls.Add(this.buttonExecuteTranslate);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem загрузитьIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьИзменяемыйФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИзминенияToolStripMenuItem;
        private System.Windows.Forms.Button buttonExecuteTranslate;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

