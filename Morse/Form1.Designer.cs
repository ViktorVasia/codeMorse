
namespace Morse
{
    partial class main_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_menu));
            this.trening_btn = new System.Windows.Forms.Button();
            this.letter_btn = new System.Windows.Forms.Button();
            this.num_btn = new System.Windows.Forms.Button();
            this.offset_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trening_btn
            // 
            this.trening_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trening_btn.Location = new System.Drawing.Point(142, 45);
            this.trening_btn.Name = "trening_btn";
            this.trening_btn.Size = new System.Drawing.Size(209, 62);
            this.trening_btn.TabIndex = 0;
            this.trening_btn.Text = "Тренировка по заданиям";
            this.trening_btn.UseVisualStyleBackColor = true;
            this.trening_btn.Click += new System.EventHandler(this.trening_btn_Click);
            // 
            // letter_btn
            // 
            this.letter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.letter_btn.Location = new System.Drawing.Point(142, 113);
            this.letter_btn.Name = "letter_btn";
            this.letter_btn.Size = new System.Drawing.Size(209, 62);
            this.letter_btn.TabIndex = 0;
            this.letter_btn.Text = "Тренировка букв";
            this.letter_btn.UseVisualStyleBackColor = true;
            // 
            // num_btn
            // 
            this.num_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num_btn.Location = new System.Drawing.Point(142, 181);
            this.num_btn.Name = "num_btn";
            this.num_btn.Size = new System.Drawing.Size(209, 62);
            this.num_btn.TabIndex = 0;
            this.num_btn.Text = "Тренировка чисел";
            this.num_btn.UseVisualStyleBackColor = true;
            // 
            // offset_btn
            // 
            this.offset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.offset_btn.Location = new System.Drawing.Point(142, 249);
            this.offset_btn.Name = "offset_btn";
            this.offset_btn.Size = new System.Drawing.Size(209, 62);
            this.offset_btn.TabIndex = 0;
            this.offset_btn.Text = "Зачет";
            this.offset_btn.UseVisualStyleBackColor = true;
            // 
            // main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 365);
            this.Controls.Add(this.offset_btn);
            this.Controls.Add(this.num_btn);
            this.Controls.Add(this.letter_btn);
            this.Controls.Add(this.trening_btn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.main_menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button trening_btn;
        private System.Windows.Forms.Button letter_btn;
        private System.Windows.Forms.Button num_btn;
        private System.Windows.Forms.Button offset_btn;
    }
}

