namespace WP_2020_01_HW01_3A713155
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.rtex = new System.Windows.Forms.RichTextBox();
            this.tex = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtex
            // 
            this.rtex.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtex.Location = new System.Drawing.Point(12, 96);
            this.rtex.Name = "rtex";
            this.rtex.Size = new System.Drawing.Size(393, 65);
            this.rtex.TabIndex = 0;
            this.rtex.Text = "";
            // 
            // tex
            // 
            this.tex.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex.Location = new System.Drawing.Point(12, 12);
            this.tex.Multiline = true;
            this.tex.Name = "tex";
            this.tex.Size = new System.Drawing.Size(164, 55);
            this.tex.TabIndex = 1;
            this.tex.Text = "蔡昀劭";
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn.Location = new System.Drawing.Point(240, 12);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(165, 55);
            this.btn.TabIndex = 2;
            this.btn.Text = "確認";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 191);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.tex);
            this.Controls.Add(this.rtex);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtex;
        private System.Windows.Forms.TextBox tex;
        private System.Windows.Forms.Button btn;
    }
}

