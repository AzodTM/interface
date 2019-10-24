namespace Interface
{
    partial class View
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
            this.buttonChooseBird = new System.Windows.Forms.Button();
            this.buttonChooseFish = new System.Windows.Forms.Button();
            this.buttonChooseReptilia = new System.Windows.Forms.Button();
            this.textBoxCountAnimals = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonChooseBird
            // 
            this.buttonChooseBird.Location = new System.Drawing.Point(53, 156);
            this.buttonChooseBird.Name = "buttonChooseBird";
            this.buttonChooseBird.Size = new System.Drawing.Size(185, 118);
            this.buttonChooseBird.TabIndex = 0;
            this.buttonChooseBird.Text = "Bird";
            this.buttonChooseBird.UseVisualStyleBackColor = true;
            this.buttonChooseBird.Click += new System.EventHandler(this.buttonChooseBird_Click);
            // 
            // buttonChooseFish
            // 
            this.buttonChooseFish.Location = new System.Drawing.Point(306, 156);
            this.buttonChooseFish.Name = "buttonChooseFish";
            this.buttonChooseFish.Size = new System.Drawing.Size(185, 118);
            this.buttonChooseFish.TabIndex = 1;
            this.buttonChooseFish.Text = "Fish";
            this.buttonChooseFish.UseVisualStyleBackColor = true;
            this.buttonChooseFish.Click += new System.EventHandler(this.buttonChooseFish_Click);
            // 
            // buttonChooseReptilia
            // 
            this.buttonChooseReptilia.Location = new System.Drawing.Point(565, 156);
            this.buttonChooseReptilia.Name = "buttonChooseReptilia";
            this.buttonChooseReptilia.Size = new System.Drawing.Size(185, 118);
            this.buttonChooseReptilia.TabIndex = 2;
            this.buttonChooseReptilia.Text = "Reptilia";
            this.buttonChooseReptilia.UseVisualStyleBackColor = true;
            this.buttonChooseReptilia.Click += new System.EventHandler(this.buttonChooseReptilia_Click);
            // 
            // textBoxCountAnimals
            // 
            this.textBoxCountAnimals.Location = new System.Drawing.Point(329, 30);
            this.textBoxCountAnimals.Name = "textBoxCountAnimals";
            this.textBoxCountAnimals.ReadOnly = true;
            this.textBoxCountAnimals.Size = new System.Drawing.Size(121, 20);
            this.textBoxCountAnimals.TabIndex = 3;
            this.textBoxCountAnimals.Text = "Animals in Zoo:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCountAnimals);
            this.Controls.Add(this.buttonChooseReptilia);
            this.Controls.Add(this.buttonChooseFish);
            this.Controls.Add(this.buttonChooseBird);
            this.Name = "MainForm";
            this.Text = "Animals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChooseBird;
        private System.Windows.Forms.Button buttonChooseFish;
        private System.Windows.Forms.Button buttonChooseReptilia;
        private System.Windows.Forms.TextBox textBoxCountAnimals;
    }
}

