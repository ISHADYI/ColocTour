namespace ColocTour
{
    partial class MainForm
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
            this.listBoxTours = new System.Windows.Forms.ListBox();
            this.buttonAddTour = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelMinDays = new System.Windows.Forms.Label();
            this.labelMaxDays = new System.Windows.Forms.Label();
            this.textBoxMinDays = new System.Windows.Forms.TextBox();
            this.textBoxMaxDays = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxTours
            // 
            this.listBoxTours.FormattingEnabled = true;
            this.listBoxTours.Location = new System.Drawing.Point(12, 12);
            this.listBoxTours.Name = "listBoxTours";
            this.listBoxTours.Size = new System.Drawing.Size(223, 147);
            this.listBoxTours.TabIndex = 0;
            // 
            // buttonAddTour
            // 
            this.buttonAddTour.Location = new System.Drawing.Point(12, 165);
            this.buttonAddTour.Name = "buttonAddTour";
            this.buttonAddTour.Size = new System.Drawing.Size(148, 23);
            this.buttonAddTour.TabIndex = 1;
            this.buttonAddTour.Text = "Добавить тур";
            this.buttonAddTour.UseVisualStyleBackColor = true;
            this.buttonAddTour.Click += new System.EventHandler(this.buttonAddTour_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(241, 86);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(138, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelMinDays
            // 
            this.labelMinDays.AutoSize = true;
            this.labelMinDays.Location = new System.Drawing.Point(452, 15);
            this.labelMinDays.Name = "labelMinDays";
            this.labelMinDays.Size = new System.Drawing.Size(172, 13);
            this.labelMinDays.TabIndex = 3;
            this.labelMinDays.Text = "Максимальное количество дней";
            // 
            // labelMaxDays
            // 
            this.labelMaxDays.AutoSize = true;
            this.labelMaxDays.Location = new System.Drawing.Point(238, 15);
            this.labelMaxDays.Name = "labelMaxDays";
            this.labelMaxDays.Size = new System.Drawing.Size(166, 13);
            this.labelMaxDays.TabIndex = 4;
            this.labelMaxDays.Text = "Минимальное количество дней";
            // 
            // textBoxMinDays
            // 
            this.textBoxMinDays.Location = new System.Drawing.Point(241, 47);
            this.textBoxMinDays.Name = "textBoxMinDays";
            this.textBoxMinDays.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinDays.TabIndex = 5;
            // 
            // textBoxMaxDays
            // 
            this.textBoxMaxDays.Location = new System.Drawing.Point(455, 47);
            this.textBoxMaxDays.Name = "textBoxMaxDays";
            this.textBoxMaxDays.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxDays.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 450);
            this.Controls.Add(this.textBoxMaxDays);
            this.Controls.Add(this.textBoxMinDays);
            this.Controls.Add(this.labelMaxDays);
            this.Controls.Add(this.labelMinDays);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonAddTour);
            this.Controls.Add(this.listBoxTours);
            this.Name = "MainForm";
            this.Text = "v";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTours;
        private System.Windows.Forms.Button buttonAddTour;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelMinDays;
        private System.Windows.Forms.Label labelMaxDays;
        private System.Windows.Forms.TextBox textBoxMinDays;
        private System.Windows.Forms.TextBox textBoxMaxDays;
    }
}

