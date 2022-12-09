namespace Variables
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
            this.rebuildShveller = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OtverstiyaPodLapi = new System.Windows.Forms.CheckBox();
            this.OtverstiyaPodMost = new System.Windows.Forms.CheckBox();
            this.SmotovieOtverstiya = new System.Windows.Forms.CheckBox();
            this.OtverstiyaPodPolubandazh = new System.Windows.Forms.CheckBox();
            this.sborka = new System.Windows.Forms.Button();
            this.rebuildUpor = new System.Windows.Forms.Button();
            this.rebuildKosinka = new System.Windows.Forms.Button();
            this.rebuildRebroPodObmotki = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // rebuildShveller
            // 
            this.rebuildShveller.Location = new System.Drawing.Point(9, 16);
            this.rebuildShveller.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rebuildShveller.Name = "rebuildShveller";
            this.rebuildShveller.Size = new System.Drawing.Size(101, 37);
            this.rebuildShveller.TabIndex = 0;
            this.rebuildShveller.Text = "Швеллер";
            this.rebuildShveller.UseVisualStyleBackColor = true;
            this.rebuildShveller.Click += new System.EventHandler(this.rebuildShveller_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, -2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(715, 454);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.OtverstiyaPodLapi);
            this.tabPage1.Controls.Add(this.OtverstiyaPodMost);
            this.tabPage1.Controls.Add(this.SmotovieOtverstiya);
            this.tabPage1.Controls.Add(this.OtverstiyaPodPolubandazh);
            this.tabPage1.Controls.Add(this.sborka);
            this.tabPage1.Controls.Add(this.rebuildUpor);
            this.tabPage1.Controls.Add(this.rebuildKosinka);
            this.tabPage1.Controls.Add(this.rebuildRebroPodObmotki);
            this.tabPage1.Controls.Add(this.rebuildShveller);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(707, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Балка ярмовая нижняя";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(45, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.WordWrap = false;
            // 
            // OtverstiyaPodLapi
            // 
            this.OtverstiyaPodLapi.AutoSize = true;
            this.OtverstiyaPodLapi.Location = new System.Drawing.Point(154, 180);
            this.OtverstiyaPodLapi.Name = "OtverstiyaPodLapi";
            this.OtverstiyaPodLapi.Size = new System.Drawing.Size(159, 20);
            this.OtverstiyaPodLapi.TabIndex = 8;
            this.OtverstiyaPodLapi.Text = "Отверстия под лапы";
            this.OtverstiyaPodLapi.UseVisualStyleBackColor = true;
            this.OtverstiyaPodLapi.CheckedChanged += new System.EventHandler(this.OtverstiyaPodLapi_CheckedChanged);
            // 
            // OtverstiyaPodMost
            // 
            this.OtverstiyaPodMost.AutoSize = true;
            this.OtverstiyaPodMost.Location = new System.Drawing.Point(154, 154);
            this.OtverstiyaPodMost.Name = "OtverstiyaPodMost";
            this.OtverstiyaPodMost.Size = new System.Drawing.Size(157, 20);
            this.OtverstiyaPodMost.TabIndex = 7;
            this.OtverstiyaPodMost.Text = "Отверстия под мост";
            this.OtverstiyaPodMost.UseVisualStyleBackColor = true;
            this.OtverstiyaPodMost.CheckedChanged += new System.EventHandler(this.OtverstiyaPodMost_CheckedChanged);
            // 
            // SmotovieOtverstiya
            // 
            this.SmotovieOtverstiya.AutoSize = true;
            this.SmotovieOtverstiya.Location = new System.Drawing.Point(154, 128);
            this.SmotovieOtverstiya.Name = "SmotovieOtverstiya";
            this.SmotovieOtverstiya.Size = new System.Drawing.Size(171, 20);
            this.SmotovieOtverstiya.TabIndex = 6;
            this.SmotovieOtverstiya.Text = "Смотровые отверстия";
            this.SmotovieOtverstiya.UseVisualStyleBackColor = true;
            this.SmotovieOtverstiya.CheckedChanged += new System.EventHandler(this.SmotrovieOtverstiya_CheckedChanged);
            // 
            // OtverstiyaPodPolubandazh
            // 
            this.OtverstiyaPodPolubandazh.AutoSize = true;
            this.OtverstiyaPodPolubandazh.Location = new System.Drawing.Point(154, 16);
            this.OtverstiyaPodPolubandazh.Name = "OtverstiyaPodPolubandazh";
            this.OtverstiyaPodPolubandazh.Size = new System.Drawing.Size(207, 20);
            this.OtverstiyaPodPolubandazh.TabIndex = 5;
            this.OtverstiyaPodPolubandazh.Text = "Отверстия под полубандаж";
            this.OtverstiyaPodPolubandazh.UseVisualStyleBackColor = true;
            this.OtverstiyaPodPolubandazh.CheckedChanged += new System.EventHandler(this.OtverstiyaPodPolubandazh_CheckedChanged);
            // 
            // sborka
            // 
            this.sborka.Location = new System.Drawing.Point(9, 338);
            this.sborka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sborka.Name = "sborka";
            this.sborka.Size = new System.Drawing.Size(101, 43);
            this.sborka.TabIndex = 4;
            this.sborka.Text = "Сборка";
            this.sborka.UseVisualStyleBackColor = true;
            this.sborka.Click += new System.EventHandler(this.RebuildBalkaYarmNizh_Click);
            // 
            // rebuildUpor
            // 
            this.rebuildUpor.Location = new System.Drawing.Point(9, 283);
            this.rebuildUpor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rebuildUpor.Name = "rebuildUpor";
            this.rebuildUpor.Size = new System.Drawing.Size(101, 43);
            this.rebuildUpor.TabIndex = 3;
            this.rebuildUpor.Text = "Упор";
            this.rebuildUpor.UseVisualStyleBackColor = true;
            this.rebuildUpor.Click += new System.EventHandler(this.rebuildUpor_Click);
            // 
            // rebuildKosinka
            // 
            this.rebuildKosinka.Location = new System.Drawing.Point(9, 220);
            this.rebuildKosinka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rebuildKosinka.Name = "rebuildKosinka";
            this.rebuildKosinka.Size = new System.Drawing.Size(101, 43);
            this.rebuildKosinka.TabIndex = 2;
            this.rebuildKosinka.Text = "Косынка";
            this.rebuildKosinka.UseVisualStyleBackColor = true;
            this.rebuildKosinka.Click += new System.EventHandler(this.rebuildKosinka_Click);
            // 
            // rebuildRebroPodObmotki
            // 
            this.rebuildRebroPodObmotki.Location = new System.Drawing.Point(9, 158);
            this.rebuildRebroPodObmotki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rebuildRebroPodObmotki.Name = "rebuildRebroPodObmotki";
            this.rebuildRebroPodObmotki.Size = new System.Drawing.Size(101, 43);
            this.rebuildRebroPodObmotki.TabIndex = 1;
            this.rebuildRebroPodObmotki.Text = "ребро под обмотки";
            this.rebuildRebroPodObmotki.UseVisualStyleBackColor = true;
            this.rebuildRebroPodObmotki.Click += new System.EventHandler(this.rebuildRebroPodObmotki_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(707, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(154, 231);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 692);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rebuildShveller;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button rebuildRebroPodObmotki;
        private System.Windows.Forms.Button rebuildKosinka;
        private System.Windows.Forms.Button rebuildUpor;
        private System.Windows.Forms.Button sborka;
        private System.Windows.Forms.CheckBox OtverstiyaPodPolubandazh;
        private System.Windows.Forms.CheckBox SmotovieOtverstiya;
        private System.Windows.Forms.CheckBox OtverstiyaPodMost;
        private System.Windows.Forms.CheckBox OtverstiyaPodLapi;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

