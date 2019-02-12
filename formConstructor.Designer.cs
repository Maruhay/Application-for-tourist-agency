namespace TouristAgency
{
    partial class formConstructor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formConstructor));
            this.tbCityDep = new System.Windows.Forms.TextBox();
            this.tbDays = new System.Windows.Forms.TextBox();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.tbNameTour = new System.Windows.Forms.TextBox();
            this.cbTypeTour = new System.Windows.Forms.ComboBox();
            this.lblDateDep = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblCityDep = new System.Windows.Forms.Label();
            this.lblNameTour = new System.Windows.Forms.Label();
            this.lblTypeTour = new System.Windows.Forms.Label();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAddCountry = new System.Windows.Forms.Button();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.tbWay = new System.Windows.Forms.TextBox();
            this.lblWay = new System.Windows.Forms.Label();
            this.lblExcursions = new System.Windows.Forms.Label();
            this.tbExcursions = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbPerson = new System.Windows.Forms.TextBox();
            this.lblPerson = new System.Windows.Forms.Label();
            this.btnMode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCityDep
            // 
            this.tbCityDep.Location = new System.Drawing.Point(273, 224);
            this.tbCityDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCityDep.Name = "tbCityDep";
            this.tbCityDep.Size = new System.Drawing.Size(221, 22);
            this.tbCityDep.TabIndex = 29;
            // 
            // tbDays
            // 
            this.tbDays.Location = new System.Drawing.Point(273, 140);
            this.tbDays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDays.Name = "tbDays";
            this.tbDays.Size = new System.Drawing.Size(221, 22);
            this.tbDays.TabIndex = 28;
            this.tbDays.Leave += new System.EventHandler(this.tbDays_Leave);
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.Location = new System.Drawing.Point(273, 100);
            this.dtpDateStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(221, 22);
            this.dtpDateStart.TabIndex = 27;
            // 
            // tbNameTour
            // 
            this.tbNameTour.Location = new System.Drawing.Point(273, 59);
            this.tbNameTour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNameTour.Name = "tbNameTour";
            this.tbNameTour.Size = new System.Drawing.Size(221, 22);
            this.tbNameTour.TabIndex = 26;
            // 
            // cbTypeTour
            // 
            this.cbTypeTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeTour.FormattingEnabled = true;
            this.cbTypeTour.Location = new System.Drawing.Point(273, 15);
            this.cbTypeTour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTypeTour.Name = "cbTypeTour";
            this.cbTypeTour.Size = new System.Drawing.Size(221, 24);
            this.cbTypeTour.TabIndex = 25;
            this.cbTypeTour.SelectedIndexChanged += new System.EventHandler(this.cbTypeTour_SelectedIndexChanged);
            // 
            // lblDateDep
            // 
            this.lblDateDep.AutoSize = true;
            this.lblDateDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateDep.Location = new System.Drawing.Point(13, 100);
            this.lblDateDep.Name = "lblDateDep";
            this.lblDateDep.Size = new System.Drawing.Size(107, 20);
            this.lblDateDep.TabIndex = 24;
            this.lblDateDep.Text = "Дата начала";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDays.Location = new System.Drawing.Point(13, 140);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(142, 20);
            this.lblDays.TabIndex = 23;
            this.lblDays.Text = "Количество дней";
            // 
            // lblCityDep
            // 
            this.lblCityDep.AutoSize = true;
            this.lblCityDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCityDep.Location = new System.Drawing.Point(13, 224);
            this.lblCityDep.Name = "lblCityDep";
            this.lblCityDep.Size = new System.Drawing.Size(160, 20);
            this.lblCityDep.TabIndex = 22;
            this.lblCityDep.Text = "Город отправления";
            // 
            // lblNameTour
            // 
            this.lblNameTour.AutoSize = true;
            this.lblNameTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameTour.Location = new System.Drawing.Point(13, 57);
            this.lblNameTour.Name = "lblNameTour";
            this.lblNameTour.Size = new System.Drawing.Size(121, 20);
            this.lblNameTour.TabIndex = 21;
            this.lblNameTour.Text = "Название тура";
            // 
            // lblTypeTour
            // 
            this.lblTypeTour.AutoSize = true;
            this.lblTypeTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTypeTour.Location = new System.Drawing.Point(13, 16);
            this.lblTypeTour.Name = "lblTypeTour";
            this.lblTypeTour.Size = new System.Drawing.Size(74, 20);
            this.lblTypeTour.TabIndex = 20;
            this.lblTypeTour.Text = "Тип тура";
            // 
            // cbCity
            // 
            this.cbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(273, 305);
            this.cbCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(221, 24);
            this.cbCity.Sorted = true;
            this.cbCity.TabIndex = 33;
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(273, 265);
            this.cbCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(221, 24);
            this.cbCountry.Sorted = true;
            this.cbCountry.TabIndex = 32;
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCity.Location = new System.Drawing.Point(13, 306);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(56, 20);
            this.lblCity.TabIndex = 31;
            this.lblCity.Text = "Город";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountry.Location = new System.Drawing.Point(13, 266);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(65, 20);
            this.lblCountry.TabIndex = 30;
            this.lblCountry.Text = "Страна";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.White;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOK.Location = new System.Drawing.Point(273, 491);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(222, 46);
            this.btnOK.TabIndex = 34;
            this.btnOK.Text = "Сформировать";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAddCountry
            // 
            this.btnAddCountry.BackColor = System.Drawing.Color.White;
            this.btnAddCountry.BackgroundImage = global::TouristAgency.Properties.Resources.btnAdd;
            this.btnAddCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddCountry.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddCountry.Location = new System.Drawing.Point(493, 266);
            this.btnAddCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddCountry.Name = "btnAddCountry";
            this.btnAddCountry.Size = new System.Drawing.Size(22, 21);
            this.btnAddCountry.TabIndex = 35;
            this.btnAddCountry.UseVisualStyleBackColor = false;
            this.btnAddCountry.Click += new System.EventHandler(this.btnAddCountry_Click);
            // 
            // btnAddCity
            // 
            this.btnAddCity.BackColor = System.Drawing.Color.White;
            this.btnAddCity.BackgroundImage = global::TouristAgency.Properties.Resources.btnAdd;
            this.btnAddCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddCity.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddCity.Location = new System.Drawing.Point(493, 305);
            this.btnAddCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(22, 21);
            this.btnAddCity.TabIndex = 36;
            this.btnAddCity.UseVisualStyleBackColor = false;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // tbWay
            // 
            this.tbWay.Location = new System.Drawing.Point(273, 410);
            this.tbWay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbWay.Name = "tbWay";
            this.tbWay.Size = new System.Drawing.Size(221, 22);
            this.tbWay.TabIndex = 37;
            // 
            // lblWay
            // 
            this.lblWay.AutoSize = true;
            this.lblWay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWay.Location = new System.Drawing.Point(13, 410);
            this.lblWay.Name = "lblWay";
            this.lblWay.Size = new System.Drawing.Size(46, 20);
            this.lblWay.TabIndex = 38;
            this.lblWay.Text = "Путь";
            // 
            // lblExcursions
            // 
            this.lblExcursions.AutoSize = true;
            this.lblExcursions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExcursions.Location = new System.Drawing.Point(13, 450);
            this.lblExcursions.Name = "lblExcursions";
            this.lblExcursions.Size = new System.Drawing.Size(87, 20);
            this.lblExcursions.TabIndex = 40;
            this.lblExcursions.Text = "Экскурсии";
            // 
            // tbExcursions
            // 
            this.tbExcursions.Location = new System.Drawing.Point(273, 450);
            this.tbExcursions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbExcursions.Name = "tbExcursions";
            this.tbExcursions.Size = new System.Drawing.Size(221, 22);
            this.tbExcursions.TabIndex = 39;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(273, 346);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(222, 46);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Добавить в путь";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbPerson
            // 
            this.tbPerson.Location = new System.Drawing.Point(273, 181);
            this.tbPerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPerson.Name = "tbPerson";
            this.tbPerson.Size = new System.Drawing.Size(221, 22);
            this.tbPerson.TabIndex = 44;
            this.tbPerson.TextChanged += new System.EventHandler(this.tbPerson_TextChanged);
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPerson.Location = new System.Drawing.Point(13, 181);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(155, 20);
            this.lblPerson.TabIndex = 43;
            this.lblPerson.Text = "Количество людей";
            // 
            // btnMode
            // 
            this.btnMode.BackColor = System.Drawing.Color.White;
            this.btnMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMode.Location = new System.Drawing.Point(17, 491);
            this.btnMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(222, 46);
            this.btnMode.TabIndex = 45;
            this.btnMode.Text = "Интерактивный режим";
            this.btnMode.UseVisualStyleBackColor = false;
            this.btnMode.Visible = false;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // formConstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(527, 553);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.tbPerson);
            this.Controls.Add(this.lblPerson);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblExcursions);
            this.Controls.Add(this.tbExcursions);
            this.Controls.Add(this.lblWay);
            this.Controls.Add(this.tbWay);
            this.Controls.Add(this.btnAddCity);
            this.Controls.Add(this.btnAddCountry);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.tbCityDep);
            this.Controls.Add(this.tbDays);
            this.Controls.Add(this.dtpDateStart);
            this.Controls.Add(this.tbNameTour);
            this.Controls.Add(this.cbTypeTour);
            this.Controls.Add(this.lblDateDep);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.lblCityDep);
            this.Controls.Add(this.lblNameTour);
            this.Controls.Add(this.lblTypeTour);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "formConstructor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Формирование индивидуального тура";
            this.Load += new System.EventHandler(this.formConstructor_Load);
            this.Enter += new System.EventHandler(this.formConstructor_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbCityDep;
        public System.Windows.Forms.TextBox tbDays;
        public System.Windows.Forms.DateTimePicker dtpDateStart;
        public System.Windows.Forms.TextBox tbNameTour;
        public System.Windows.Forms.ComboBox cbTypeTour;
        private System.Windows.Forms.Label lblDateDep;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblCityDep;
        private System.Windows.Forms.Label lblNameTour;
        private System.Windows.Forms.Label lblTypeTour;
        public System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAddCountry;
        private System.Windows.Forms.Button btnAddCity;
        public System.Windows.Forms.TextBox tbWay;
        private System.Windows.Forms.Label lblWay;
        private System.Windows.Forms.Label lblExcursions;
        public System.Windows.Forms.TextBox tbExcursions;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.TextBox tbPerson;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.Button btnMode;
        public System.Windows.Forms.ComboBox cbCity;
    }
}