
namespace DEMOclicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clik = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.actBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clik
            // 
            this.clik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clik.Location = new System.Drawing.Point(119, 41);
            this.clik.Name = "clik";
            this.clik.Size = new System.Drawing.Size(112, 45);
            this.clik.TabIndex = 0;
            this.clik.Text = "КЛИК";
            this.clik.UseMnemonic = false;
            this.clik.UseVisualStyleBackColor = true;
            this.clik.Click += new System.EventHandler(this.Clik_Click);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score.Location = new System.Drawing.Point(12, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(20, 24);
            this.score.TabIndex = 1;
            this.score.Text = "0";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 20);
            this.textBox1.TabIndex = 3;
            // 
            // actBtn
            // 
            this.actBtn.Location = new System.Drawing.Point(167, 9);
            this.actBtn.Name = "actBtn";
            this.actBtn.Size = new System.Drawing.Size(172, 23);
            this.actBtn.TabIndex = 4;
            this.actBtn.Text = "Активировать полную версию";
            this.actBtn.UseVisualStyleBackColor = true;
            this.actBtn.Click += new System.EventHandler(this.actBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 110);
            this.Controls.Add(this.actBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.score);
            this.Controls.Add(this.clik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Кликер";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button clik;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button actBtn;
    }
}

