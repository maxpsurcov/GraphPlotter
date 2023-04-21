namespace GraphPlotter
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(583, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 419);
            this.panel1.TabIndex = 0;
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(712, 63);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(135, 29);
            this.txtR.TabIndex = 1;
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(539, 63);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(135, 29);
            this.txtH.TabIndex = 2;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(267, 125);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(161, 56);
            this.btnDraw.TabIndex = 3;
            this.btnDraw.Text = "button1";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 790);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Button btnDraw;
    }
}

