
namespace DEMOclicker
{
    partial class activation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(activation));
            this.label1 = new System.Windows.Forms.Label();
            this.key1 = new System.Windows.Forms.TextBox();
            this.actBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ключ активации:";
            // 
            // key1
            // 
            this.key1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.key1.Location = new System.Drawing.Point(15, 27);
            this.key1.MaxLength = 14;
            this.key1.Name = "key1";
            this.key1.Size = new System.Drawing.Size(196, 20);
            this.key1.TabIndex = 1;
            this.key1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.key1.TextChanged += new System.EventHandler(this.key1_TextChanged);
            this.key1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.key1_KeyDown);
            // 
            // actBtn
            // 
            this.actBtn.Location = new System.Drawing.Point(15, 53);
            this.actBtn.Name = "actBtn";
            this.actBtn.Size = new System.Drawing.Size(196, 23);
            this.actBtn.TabIndex = 7;
            this.actBtn.Text = "Активировать";
            this.actBtn.UseVisualStyleBackColor = true;
            this.actBtn.Click += new System.EventHandler(this.actBtn_Click);
            // 
            // activation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 89);
            this.Controls.Add(this.actBtn);
            this.Controls.Add(this.key1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "activation";
            this.Text = "Активация";
            this.Load += new System.EventHandler(this.activation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox key1;
        private System.Windows.Forms.Button actBtn;
    }
}