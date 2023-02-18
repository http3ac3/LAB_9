
namespace LAB_9
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
            this.label1 = new System.Windows.Forms.Label();
            this.OpenTextTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KeyWordTB = new System.Windows.Forms.TextBox();
            this.CipherButton = new System.Windows.Forms.Button();
            this.DecipherButtom = new System.Windows.Forms.Button();
            this.AnswerTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Открытый текст";
            // 
            // OpenTextTB
            // 
            this.OpenTextTB.Location = new System.Drawing.Point(135, 10);
            this.OpenTextTB.Name = "OpenTextTB";
            this.OpenTextTB.Size = new System.Drawing.Size(315, 22);
            this.OpenTextTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ключевое слово";
            // 
            // KeyWordTB
            // 
            this.KeyWordTB.Location = new System.Drawing.Point(135, 38);
            this.KeyWordTB.Name = "KeyWordTB";
            this.KeyWordTB.Size = new System.Drawing.Size(315, 22);
            this.KeyWordTB.TabIndex = 1;
            // 
            // CipherButton
            // 
            this.CipherButton.Location = new System.Drawing.Point(16, 70);
            this.CipherButton.Name = "CipherButton";
            this.CipherButton.Size = new System.Drawing.Size(213, 37);
            this.CipherButton.TabIndex = 2;
            this.CipherButton.Text = "Зашифровать";
            this.CipherButton.UseVisualStyleBackColor = true;
            this.CipherButton.Click += new System.EventHandler(this.CipherButton_Click);
            // 
            // DecipherButtom
            // 
            this.DecipherButtom.Location = new System.Drawing.Point(235, 70);
            this.DecipherButtom.Name = "DecipherButtom";
            this.DecipherButtom.Size = new System.Drawing.Size(215, 37);
            this.DecipherButtom.TabIndex = 2;
            this.DecipherButtom.Text = "Расшифровать";
            this.DecipherButtom.UseVisualStyleBackColor = true;
            this.DecipherButtom.Click += new System.EventHandler(this.DecipherButtom_Click);
            // 
            // AnswerTB
            // 
            this.AnswerTB.Location = new System.Drawing.Point(16, 125);
            this.AnswerTB.Name = "AnswerTB";
            this.AnswerTB.Size = new System.Drawing.Size(432, 220);
            this.AnswerTB.TabIndex = 3;
            this.AnswerTB.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 356);
            this.Controls.Add(this.AnswerTB);
            this.Controls.Add(this.DecipherButtom);
            this.Controls.Add(this.CipherButton);
            this.Controls.Add(this.KeyWordTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OpenTextTB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OpenTextTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KeyWordTB;
        private System.Windows.Forms.Button CipherButton;
        private System.Windows.Forms.Button DecipherButtom;
        private System.Windows.Forms.RichTextBox AnswerTB;
    }
}

