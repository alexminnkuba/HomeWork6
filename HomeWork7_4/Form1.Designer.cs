namespace HomeWork7_4
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
            this.button1_selectsources = new System.Windows.Forms.Button();
            this.button_selectdestination = new System.Windows.Forms.Button();
            this.textBox_sources = new System.Windows.Forms.TextBox();
            this.textBox_destinationt = new System.Windows.Forms.TextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1_selectsources
            // 
            this.button1_selectsources.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_selectsources.Location = new System.Drawing.Point(49, 32);
            this.button1_selectsources.Name = "button1_selectsources";
            this.button1_selectsources.Size = new System.Drawing.Size(169, 61);
            this.button1_selectsources.TabIndex = 0;
            this.button1_selectsources.Text = "Выбрать исходную директорию";
            this.button1_selectsources.UseVisualStyleBackColor = true;
            this.button1_selectsources.Click += new System.EventHandler(this.button1_selectsources_Click);
            // 
            // button_selectdestination
            // 
            this.button_selectdestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_selectdestination.Location = new System.Drawing.Point(49, 113);
            this.button_selectdestination.Name = "button_selectdestination";
            this.button_selectdestination.Size = new System.Drawing.Size(169, 64);
            this.button_selectdestination.TabIndex = 1;
            this.button_selectdestination.Text = "Выбрать директорию назначения";
            this.button_selectdestination.UseVisualStyleBackColor = true;
            this.button_selectdestination.Click += new System.EventHandler(this.button_selectdestination_Click);
            // 
            // textBox_sources
            // 
            this.textBox_sources.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_sources.Location = new System.Drawing.Point(324, 60);
            this.textBox_sources.Name = "textBox_sources";
            this.textBox_sources.Size = new System.Drawing.Size(427, 26);
            this.textBox_sources.TabIndex = 2;
            // 
            // textBox_destinationt
            // 
            this.textBox_destinationt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_destinationt.Location = new System.Drawing.Point(324, 128);
            this.textBox_destinationt.Name = "textBox_destinationt";
            this.textBox_destinationt.Size = new System.Drawing.Size(427, 24);
            this.textBox_destinationt.TabIndex = 3;
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start.Location = new System.Drawing.Point(49, 197);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(169, 49);
            this.button_start.TabIndex = 4;
            this.button_start.Text = "Запуск проверки";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(324, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Статус проверки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.textBox_destinationt);
            this.Controls.Add(this.textBox_sources);
            this.Controls.Add(this.button_selectdestination);
            this.Controls.Add(this.button1_selectsources);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_selectsources;
        private System.Windows.Forms.Button button_selectdestination;
        private System.Windows.Forms.TextBox textBox_sources;
        private System.Windows.Forms.TextBox textBox_destinationt;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label1;
    }
}

