namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.tbFolder = new System.Windows.Forms.TextBox();
            this.btAct = new System.Windows.Forms.Button();
            this.btFolder = new System.Windows.Forms.Button();
            this.cbUse = new System.Windows.Forms.CheckBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tbTimer = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(120, 22);
            this.tsmiExit.Text = "Закрыть";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.vScrollBar1.Location = new System.Drawing.Point(738, 24);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(0, 0);
            this.vScrollBar1.TabIndex = 5;
            // 
            // tbFolder
            // 
            this.tbFolder.Location = new System.Drawing.Point(115, 27);
            this.tbFolder.Name = "tbFolder";
            this.tbFolder.Size = new System.Drawing.Size(356, 20);
            this.tbFolder.TabIndex = 6;
            // 
            // btAct
            // 
            this.btAct.Location = new System.Drawing.Point(513, 69);
            this.btAct.Name = "btAct";
            this.btAct.Size = new System.Drawing.Size(75, 20);
            this.btAct.TabIndex = 7;
            this.btAct.Text = "Обработать";
            this.btAct.UseVisualStyleBackColor = true;
            this.btAct.Click += new System.EventHandler(this.btAct_Click);
            // 
            // btFolder
            // 
            this.btFolder.Location = new System.Drawing.Point(477, 27);
            this.btFolder.Name = "btFolder";
            this.btFolder.Size = new System.Drawing.Size(27, 20);
            this.btFolder.TabIndex = 8;
            this.btFolder.Text = "...";
            this.btFolder.UseVisualStyleBackColor = true;
            this.btFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbUse
            // 
            this.cbUse.AutoSize = true;
            this.cbUse.Location = new System.Drawing.Point(12, 27);
            this.cbUse.Name = "cbUse";
            this.cbUse.Size = new System.Drawing.Size(97, 17);
            this.cbUse.TabIndex = 10;
            this.cbUse.Text = "Активировать";
            this.cbUse.UseVisualStyleBackColor = true;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(127, 69);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(255, 20);
            this.tb1.TabIndex = 13;
            // 
            // tbTimer
            // 
            this.tbTimer.Location = new System.Drawing.Point(598, 28);
            this.tbTimer.Name = "tbTimer";
            this.tbTimer.Size = new System.Drawing.Size(37, 20);
            this.tbTimer.TabIndex = 14;
            this.tbTimer.TextChanged += new System.EventHandler(this.tbTimer_TextChanged_1);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(510, 31);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(82, 13);
            this.lbl1.TabIndex = 15;
            this.lbl1.Text = "Удалить через";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(641, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "минут";
            // 
            // rtb1
            // 
            this.rtb1.Location = new System.Drawing.Point(103, 104);
            this.rtb1.Name = "rtb1";
            this.rtb1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb1.Size = new System.Drawing.Size(178, 207);
            this.rtb1.TabIndex = 17;
            this.rtb1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(752, 356);
            this.Controls.Add(this.rtb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.tbTimer);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.cbUse);
            this.Controls.Add(this.btFolder);
            this.Controls.Add(this.btAct);
            this.Controls.Add(this.tbFolder);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.TextBox tbFolder;
        private System.Windows.Forms.Button btAct;
        private System.Windows.Forms.Button btFolder;
        private System.Windows.Forms.CheckBox cbUse;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tbTimer;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb1;
    }
}

