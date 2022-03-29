namespace Postava
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAttack1 = new System.Windows.Forms.Button();
            this.btnHeal1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnHeal2 = new System.Windows.Forms.Button();
            this.btnAttack2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 161);
            this.textBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnAttack1
            // 
            this.btnAttack1.Location = new System.Drawing.Point(22, 191);
            this.btnAttack1.Name = "btnAttack1";
            this.btnAttack1.Size = new System.Drawing.Size(132, 37);
            this.btnAttack1.TabIndex = 2;
            this.btnAttack1.Text = "Attack";
            this.btnAttack1.UseVisualStyleBackColor = true;
            this.btnAttack1.Click += new System.EventHandler(this.btnAttack1_Click);
            // 
            // btnHeal1
            // 
            this.btnHeal1.Location = new System.Drawing.Point(22, 234);
            this.btnHeal1.Name = "btnHeal1";
            this.btnHeal1.Size = new System.Drawing.Size(132, 37);
            this.btnHeal1.TabIndex = 3;
            this.btnHeal1.Text = "Heal";
            this.btnHeal1.UseVisualStyleBackColor = true;
            this.btnHeal1.Click += new System.EventHandler(this.btnHeal1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(283, 24);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 161);
            this.textBox2.TabIndex = 4;
            // 
            // btnHeal2
            // 
            this.btnHeal2.Location = new System.Drawing.Point(283, 234);
            this.btnHeal2.Name = "btnHeal2";
            this.btnHeal2.Size = new System.Drawing.Size(132, 37);
            this.btnHeal2.TabIndex = 6;
            this.btnHeal2.Text = "Heal";
            this.btnHeal2.UseVisualStyleBackColor = true;
            this.btnHeal2.Click += new System.EventHandler(this.btnHeal2_Click);
            // 
            // btnAttack2
            // 
            this.btnAttack2.Location = new System.Drawing.Point(283, 191);
            this.btnAttack2.Name = "btnAttack2";
            this.btnAttack2.Size = new System.Drawing.Size(132, 37);
            this.btnAttack2.TabIndex = 5;
            this.btnAttack2.Text = "Attack";
            this.btnAttack2.UseVisualStyleBackColor = true;
            this.btnAttack2.Click += new System.EventHandler(this.btnAttack2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 294);
            this.Controls.Add(this.btnHeal2);
            this.Controls.Add(this.btnAttack2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnHeal1);
            this.Controls.Add(this.btnAttack1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnAttack1;
        private System.Windows.Forms.Button btnHeal1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnHeal2;
        private System.Windows.Forms.Button btnAttack2;
    }
}

