
namespace LTKK_APB
{
    partial class frm1
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
            this.lbA = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.txtbA = new System.Windows.Forms.TextBox();
            this.txtbB = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbA.Location = new System.Drawing.Point(12, 9);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(87, 16);
            this.lbA.TabIndex = 0;
            this.lbA.Text = "Số nguyên A:";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbB.Location = new System.Drawing.Point(12, 42);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(87, 16);
            this.lbB.TabIndex = 0;
            this.lbB.Text = "Số nguyên B:";
            // 
            // txtbA
            // 
            this.txtbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtbA.Location = new System.Drawing.Point(105, 6);
            this.txtbA.Name = "txtbA";
            this.txtbA.Size = new System.Drawing.Size(276, 22);
            this.txtbA.TabIndex = 1;
            // 
            // txtbB
            // 
            this.txtbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtbB.Location = new System.Drawing.Point(105, 39);
            this.txtbB.Name = "txtbB";
            this.txtbB.Size = new System.Drawing.Size(276, 22);
            this.txtbB.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSubmit.Location = new System.Drawing.Point(263, 67);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(118, 40);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Tính A + B";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 122);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtbB);
            this.Controls.Add(this.txtbA);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbA);
            this.Name = "frm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LTKK A Plus B";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.TextBox txtbA;
        private System.Windows.Forms.TextBox txtbB;
        private System.Windows.Forms.Button btnSubmit;
    }
}

