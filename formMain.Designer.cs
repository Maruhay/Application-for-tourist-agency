namespace TouristAgency
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.btnFindTour = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnManageData = new System.Windows.Forms.Button();
            this.btnConstructor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFindTour
            // 
            this.btnFindTour.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFindTour.BackgroundImage = global::TouristAgency.Properties.Resources.SearchSearchSearch1;
            this.btnFindTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindTour.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFindTour.ForeColor = System.Drawing.Color.Black;
            this.btnFindTour.Location = new System.Drawing.Point(12, 308);
            this.btnFindTour.Name = "btnFindTour";
            this.btnFindTour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFindTour.Size = new System.Drawing.Size(300, 58);
            this.btnFindTour.TabIndex = 0;
            this.btnFindTour.UseVisualStyleBackColor = false;
            this.btnFindTour.Click += new System.EventHandler(this.btnFindTour_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackgroundImage = global::TouristAgency.Properties.Resources.SaleSaleSale2;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOrders.ForeColor = System.Drawing.Color.Black;
            this.btnOrders.Location = new System.Drawing.Point(384, 308);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(300, 58);
            this.btnOrders.TabIndex = 1;
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnManageData
            // 
            this.btnManageData.BackgroundImage = global::TouristAgency.Properties.Resources.MDMDMD1;
            this.btnManageData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageData.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnManageData.ForeColor = System.Drawing.Color.Black;
            this.btnManageData.Location = new System.Drawing.Point(384, 372);
            this.btnManageData.Name = "btnManageData";
            this.btnManageData.Size = new System.Drawing.Size(300, 58);
            this.btnManageData.TabIndex = 2;
            this.btnManageData.UseVisualStyleBackColor = true;
            this.btnManageData.Click += new System.EventHandler(this.btnManageData_Click);
            // 
            // btnConstructor
            // 
            this.btnConstructor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConstructor.BackgroundImage = global::TouristAgency.Properties.Resources.ConstructorConstructorConstructor1;
            this.btnConstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConstructor.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConstructor.ForeColor = System.Drawing.Color.Black;
            this.btnConstructor.Location = new System.Drawing.Point(12, 372);
            this.btnConstructor.Name = "btnConstructor";
            this.btnConstructor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConstructor.Size = new System.Drawing.Size(300, 58);
            this.btnConstructor.TabIndex = 3;
            this.btnConstructor.UseVisualStyleBackColor = false;
            this.btnConstructor.Click += new System.EventHandler(this.btnConstructor_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TouristAgency.Properties.Resources.Fonfonfon;
            this.ClientSize = new System.Drawing.Size(705, 442);
            this.Controls.Add(this.btnConstructor);
            this.Controls.Add(this.btnManageData);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnFindTour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Туристическое агенство";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.Enter += new System.EventHandler(this.formMain_Enter);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFindTour;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnManageData;
        private System.Windows.Forms.Button btnConstructor;
    }
}

