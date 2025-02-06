namespace HomeWork7_1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox_sentences = new System.Windows.Forms.CheckBox();
            this.checkBoxchar = new System.Windows.Forms.CheckBox();
            this.checkBox_word = new System.Windows.Forms.CheckBox();
            this.checkBox_question = new System.Windows.Forms.CheckBox();
            this.checkBox_exclamation = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(17, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Анализ текста";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(17, 183);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(758, 32);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Отчет";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(285, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Сохранить отчет";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(151, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 43);
            this.button4.TabIndex = 6;
            this.button4.Text = "Остановить анализ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBox_sentences
            // 
            this.checkBox_sentences.AutoSize = true;
            this.checkBox_sentences.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_sentences.Location = new System.Drawing.Point(431, 43);
            this.checkBox_sentences.Name = "checkBox_sentences";
            this.checkBox_sentences.Size = new System.Drawing.Size(218, 20);
            this.checkBox_sentences.TabIndex = 7;
            this.checkBox_sentences.Text = "Количество предложений";
            this.checkBox_sentences.UseVisualStyleBackColor = true;
            // 
            // checkBoxchar
            // 
            this.checkBoxchar.AutoSize = true;
            this.checkBoxchar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxchar.Location = new System.Drawing.Point(431, 69);
            this.checkBoxchar.Name = "checkBoxchar";
            this.checkBoxchar.Size = new System.Drawing.Size(190, 20);
            this.checkBoxchar.TabIndex = 8;
            this.checkBoxchar.Text = "Количество символов";
            this.checkBoxchar.UseVisualStyleBackColor = true;
            // 
            // checkBox_word
            // 
            this.checkBox_word.AutoSize = true;
            this.checkBox_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_word.Location = new System.Drawing.Point(431, 95);
            this.checkBox_word.Name = "checkBox_word";
            this.checkBox_word.Size = new System.Drawing.Size(153, 20);
            this.checkBox_word.TabIndex = 9;
            this.checkBox_word.Text = "Количество слов";
            this.checkBox_word.UseVisualStyleBackColor = true;
            // 
            // checkBox_question
            // 
            this.checkBox_question.AutoSize = true;
            this.checkBox_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_question.Location = new System.Drawing.Point(431, 121);
            this.checkBox_question.Name = "checkBox_question";
            this.checkBox_question.Size = new System.Drawing.Size(344, 20);
            this.checkBox_question.TabIndex = 10;
            this.checkBox_question.Text = "Количество вопросительных предложений";
            this.checkBox_question.UseVisualStyleBackColor = true;
            // 
            // checkBox_exclamation
            // 
            this.checkBox_exclamation.AutoSize = true;
            this.checkBox_exclamation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_exclamation.Location = new System.Drawing.Point(431, 147);
            this.checkBox_exclamation.Name = "checkBox_exclamation";
            this.checkBox_exclamation.Size = new System.Drawing.Size(352, 20);
            this.checkBox_exclamation.TabIndex = 11;
            this.checkBox_exclamation.Text = "Количество восклицательных предложений";
            this.checkBox_exclamation.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(439, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Параметры выбора отчета";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_exclamation);
            this.Controls.Add(this.checkBox_question);
            this.Controls.Add(this.checkBox_word);
            this.Controls.Add(this.checkBoxchar);
            this.Controls.Add(this.checkBox_sentences);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox_sentences;
        private System.Windows.Forms.CheckBox checkBoxchar;
        private System.Windows.Forms.CheckBox checkBox_word;
        private System.Windows.Forms.CheckBox checkBox_question;
        private System.Windows.Forms.CheckBox checkBox_exclamation;
        private System.Windows.Forms.Label label2;
    }
}

