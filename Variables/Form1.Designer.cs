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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rebuildRebroPodObmotki = new System.Windows.Forms.Button();
            this.rebuildKosinka = new System.Windows.Forms.Button();
            this.rebuildUpor = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rebuildShveller
            // 
            this.rebuildShveller.Location = new System.Drawing.Point(9, 29);
            this.rebuildShveller.Name = "rebuildShveller";
            this.rebuildShveller.Size = new System.Drawing.Size(101, 23);
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(714, 454);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rebuildUpor);
            this.tabPage1.Controls.Add(this.rebuildKosinka);
            this.tabPage1.Controls.Add(this.rebuildRebroPodObmotki);
            this.tabPage1.Controls.Add(this.rebuildShveller);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(706, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Балка ярмовая нижняя";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(706, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rebuildRebroPodObmotki
            // 
            this.rebuildRebroPodObmotki.Location = new System.Drawing.Point(9, 75);
            this.rebuildRebroPodObmotki.Name = "rebuildRebroPodObmotki";
            this.rebuildRebroPodObmotki.Size = new System.Drawing.Size(101, 43);
            this.rebuildRebroPodObmotki.TabIndex = 1;
            this.rebuildRebroPodObmotki.Text = "ребро под обмотки";
            this.rebuildRebroPodObmotki.UseVisualStyleBackColor = true;
            this.rebuildRebroPodObmotki.Click += new System.EventHandler(this.rebuildRebroPodObmotki_Click);
            // 
            // rebuildKosinka
            // 
            this.rebuildKosinka.Location = new System.Drawing.Point(9, 138);
            this.rebuildKosinka.Name = "rebuildKosinka";
            this.rebuildKosinka.Size = new System.Drawing.Size(101, 43);
            this.rebuildKosinka.TabIndex = 2;
            this.rebuildKosinka.Text = "Косынка";
            this.rebuildKosinka.UseVisualStyleBackColor = true;
            this.rebuildKosinka.Click += new System.EventHandler(this.rebuildKosinka_Click);
            // 
            // rebuildUpor
            // 
            this.rebuildUpor.Location = new System.Drawing.Point(9, 200);
            this.rebuildUpor.Name = "rebuildUpor";
            this.rebuildUpor.Size = new System.Drawing.Size(101, 43);
            this.rebuildUpor.TabIndex = 3;
            this.rebuildUpor.Text = "Упор";
            this.rebuildUpor.UseVisualStyleBackColor = true;
            this.rebuildUpor.Click += new System.EventHandler(this.rebuildUpor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
    }
}

