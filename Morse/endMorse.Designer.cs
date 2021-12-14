namespace Morse
{
    partial class endMorse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(endMorse));
            this.ErrorText_label = new System.Windows.Forms.Label();
            this.Err_label = new System.Windows.Forms.Label();
            this.repeat_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ErrorText_label
            // 
            this.ErrorText_label.AutoSize = true;
            this.ErrorText_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorText_label.Location = new System.Drawing.Point(149, 30);
            this.ErrorText_label.Name = "ErrorText_label";
            this.ErrorText_label.Size = new System.Drawing.Size(161, 16);
            this.ErrorText_label.TabIndex = 0;
            this.ErrorText_label.Text = "Колическтво ошибок";
            // 
            // Err_label
            // 
            this.Err_label.AutoSize = true;
            this.Err_label.Location = new System.Drawing.Point(326, 33);
            this.Err_label.Name = "Err_label";
            this.Err_label.Size = new System.Drawing.Size(82, 13);
            this.Err_label.TabIndex = 1;
            this.Err_label.Text = "Кол-во ошибок";
            // 
            // repeat_btn
            // 
            this.repeat_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repeat_btn.Location = new System.Drawing.Point(307, 143);
            this.repeat_btn.Name = "repeat_btn";
            this.repeat_btn.Size = new System.Drawing.Size(101, 32);
            this.repeat_btn.TabIndex = 2;
            this.repeat_btn.Text = "Повторить";
            this.repeat_btn.UseVisualStyleBackColor = true;
            this.repeat_btn.Click += new System.EventHandler(this.repeat_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_btn.Location = new System.Drawing.Point(152, 143);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(83, 32);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "Выход";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // endMorse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 213);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.repeat_btn);
            this.Controls.Add(this.Err_label);
            this.Controls.Add(this.ErrorText_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "endMorse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.endMorse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ErrorText_label;
        private System.Windows.Forms.Label Err_label;
        private System.Windows.Forms.Button repeat_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}