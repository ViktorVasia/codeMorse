namespace Morse
{
    partial class begin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(begin));
            this.ComeBeck_btn = new System.Windows.Forms.Button();
            this.Task_label = new System.Windows.Forms.Label();
            this.audio_timer = new System.Windows.Forms.Timer(this.components);
            this.key_timer = new System.Windows.Forms.Timer(this.components);
            this.Test_label = new System.Windows.Forms.Label();
            this.endwrite = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ComeBeck_btn
            // 
            this.ComeBeck_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComeBeck_btn.Location = new System.Drawing.Point(154, 314);
            this.ComeBeck_btn.Name = "ComeBeck_btn";
            this.ComeBeck_btn.Size = new System.Drawing.Size(88, 27);
            this.ComeBeck_btn.TabIndex = 0;
            this.ComeBeck_btn.Text = "Стоп";
            this.ComeBeck_btn.UseVisualStyleBackColor = true;
            this.ComeBeck_btn.Click += new System.EventHandler(this.ComeBeck_btn_Click);
            // 
            // Task_label
            // 
            this.Task_label.AutoSize = true;
            this.Task_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Task_label.Location = new System.Drawing.Point(88, 66);
            this.Task_label.Name = "Task_label";
            this.Task_label.Size = new System.Drawing.Size(115, 25);
            this.Task_label.TabIndex = 2;
            this.Task_label.Text = "Text_task";
            // 
            // audio_timer
            // 
            this.audio_timer.Tick += new System.EventHandler(this.audio_timer_Tick);
            // 
            // key_timer
            // 
            this.key_timer.Tick += new System.EventHandler(this.key_timer_Tick);
            // 
            // Test_label
            // 
            this.Test_label.AutoSize = true;
            this.Test_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Test_label.Location = new System.Drawing.Point(33, 258);
            this.Test_label.Name = "Test_label";
            this.Test_label.Size = new System.Drawing.Size(128, 20);
            this.Test_label.TabIndex = 3;
            this.Test_label.Text = "Введенный код";
            // 
            // endwrite
            // 
            this.endwrite.Tick += new System.EventHandler(this.endwrite_Tick);
            // 
            // begin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 353);
            this.Controls.Add(this.Test_label);
            this.Controls.Add(this.Task_label);
            this.Controls.Add(this.ComeBeck_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "begin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.begin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ComeBeck_btn;
        private System.Windows.Forms.Label Task_label;
        private System.Windows.Forms.Timer audio_timer;
        private System.Windows.Forms.Timer key_timer;
        private System.Windows.Forms.Label Test_label;
        private System.Windows.Forms.Timer endwrite;
    }
}