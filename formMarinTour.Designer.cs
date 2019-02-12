namespace TouristAgency
{
    partial class formMarinTour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMarinTour));
            this.lblFindNumber = new System.Windows.Forms.Label();
            this.chchbAdult = new System.Windows.Forms.CheckBox();
            this.chckbDays = new System.Windows.Forms.CheckBox();
            this.chckbDate = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMaxPrice = new System.Windows.Forms.TextBox();
            this.nudAdult = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudNumberDays = new System.Windows.Forms.NumericUpDown();
            this.lbNumberDays = new System.Windows.Forms.Label();
            this.lbDateDep = new System.Windows.Forms.Label();
            this.dtpDateDep = new System.Windows.Forms.DateTimePicker();
            this.lbVisitCity = new System.Windows.Forms.Label();
            this.lbCityDep = new System.Windows.Forms.Label();
            this.cbVisitCity = new System.Windows.Forms.ComboBox();
            this.cbCityDep = new System.Windows.Forms.ComboBox();
            this.dgvMarinTour = new System.Windows.Forms.DataGridView();
            this.id_tour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_tour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city_departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.days_tour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.way = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operator_tour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarinTour)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFindNumber
            // 
            this.lblFindNumber.AutoSize = true;
            this.lblFindNumber.Location = new System.Drawing.Point(16, 656);
            this.lblFindNumber.Name = "lblFindNumber";
            this.lblFindNumber.Size = new System.Drawing.Size(15, 16);
            this.lblFindNumber.TabIndex = 43;
            this.lblFindNumber.Text = "1";
            // 
            // chchbAdult
            // 
            this.chchbAdult.AutoSize = true;
            this.chchbAdult.Location = new System.Drawing.Point(670, 139);
            this.chchbAdult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chchbAdult.Name = "chchbAdult";
            this.chchbAdult.Size = new System.Drawing.Size(15, 14);
            this.chchbAdult.TabIndex = 42;
            this.chchbAdult.UseVisualStyleBackColor = true;
            // 
            // chckbDays
            // 
            this.chckbDays.AutoSize = true;
            this.chckbDays.Location = new System.Drawing.Point(670, 84);
            this.chckbDays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chckbDays.Name = "chckbDays";
            this.chckbDays.Size = new System.Drawing.Size(15, 14);
            this.chckbDays.TabIndex = 41;
            this.chckbDays.UseVisualStyleBackColor = true;
            // 
            // chckbDate
            // 
            this.chckbDate.AutoSize = true;
            this.chckbDate.Location = new System.Drawing.Point(670, 30);
            this.chckbDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chckbDate.Name = "chckbDate";
            this.chckbDate.Size = new System.Drawing.Size(15, 14);
            this.chckbDate.TabIndex = 40;
            this.chckbDate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(571, 678);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(187, 47);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.White;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApply.Location = new System.Drawing.Point(379, 678);
            this.btnApply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(186, 47);
            this.btnApply.TabIndex = 38;
            this.btnApply.Text = "Применить";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.Color.White;
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSale.Location = new System.Drawing.Point(764, 678);
            this.btnSale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(355, 47);
            this.btnSale.TabIndex = 37;
            this.btnSale.Text = "Оформить заказ";
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Максимальная цена";
            // 
            // tbMaxPrice
            // 
            this.tbMaxPrice.Location = new System.Drawing.Point(233, 135);
            this.tbMaxPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaxPrice.Name = "tbMaxPrice";
            this.tbMaxPrice.Size = new System.Drawing.Size(214, 22);
            this.tbMaxPrice.TabIndex = 35;
            // 
            // nudAdult
            // 
            this.nudAdult.Location = new System.Drawing.Point(905, 135);
            this.nudAdult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudAdult.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudAdult.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdult.Name = "nudAdult";
            this.nudAdult.Size = new System.Drawing.Size(215, 22);
            this.nudAdult.TabIndex = 32;
            this.nudAdult.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(694, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Количество взрослых";
            // 
            // nudNumberDays
            // 
            this.nudNumberDays.Location = new System.Drawing.Point(905, 80);
            this.nudNumberDays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudNumberDays.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudNumberDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberDays.Name = "nudNumberDays";
            this.nudNumberDays.Size = new System.Drawing.Size(215, 22);
            this.nudNumberDays.TabIndex = 30;
            this.nudNumberDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbNumberDays
            // 
            this.lbNumberDays.AutoSize = true;
            this.lbNumberDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNumberDays.Location = new System.Drawing.Point(694, 80);
            this.lbNumberDays.Name = "lbNumberDays";
            this.lbNumberDays.Size = new System.Drawing.Size(142, 20);
            this.lbNumberDays.TabIndex = 29;
            this.lbNumberDays.Text = "Количество дней";
            // 
            // lbDateDep
            // 
            this.lbDateDep.AutoSize = true;
            this.lbDateDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDateDep.Location = new System.Drawing.Point(694, 25);
            this.lbDateDep.Name = "lbDateDep";
            this.lbDateDep.Size = new System.Drawing.Size(152, 20);
            this.lbDateDep.TabIndex = 28;
            this.lbDateDep.Text = "Дата отправления";
            // 
            // dtpDateDep
            // 
            this.dtpDateDep.Location = new System.Drawing.Point(905, 25);
            this.dtpDateDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDateDep.Name = "dtpDateDep";
            this.dtpDateDep.Size = new System.Drawing.Size(214, 22);
            this.dtpDateDep.TabIndex = 27;
            this.dtpDateDep.Value = new System.DateTime(2017, 2, 28, 0, 0, 0, 0);
            // 
            // lbVisitCity
            // 
            this.lbVisitCity.AutoSize = true;
            this.lbVisitCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbVisitCity.Location = new System.Drawing.Point(19, 80);
            this.lbVisitCity.Name = "lbVisitCity";
            this.lbVisitCity.Size = new System.Drawing.Size(159, 20);
            this.lbVisitCity.TabIndex = 26;
            this.lbVisitCity.Text = "Посещаемые места";
            // 
            // lbCityDep
            // 
            this.lbCityDep.AutoSize = true;
            this.lbCityDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCityDep.Location = new System.Drawing.Point(19, 25);
            this.lbCityDep.Name = "lbCityDep";
            this.lbCityDep.Size = new System.Drawing.Size(160, 20);
            this.lbCityDep.TabIndex = 25;
            this.lbCityDep.Text = "Город отправления";
            // 
            // cbVisitCity
            // 
            this.cbVisitCity.FormattingEnabled = true;
            this.cbVisitCity.Items.AddRange(new object[] {
            ""});
            this.cbVisitCity.Location = new System.Drawing.Point(233, 80);
            this.cbVisitCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbVisitCity.Name = "cbVisitCity";
            this.cbVisitCity.Size = new System.Drawing.Size(214, 24);
            this.cbVisitCity.TabIndex = 24;
            this.cbVisitCity.SelectedIndexChanged += new System.EventHandler(this.cbVisitCity_SelectedIndexChanged);
            // 
            // cbCityDep
            // 
            this.cbCityDep.DisplayMember = "ывыа";
            this.cbCityDep.FormattingEnabled = true;
            this.cbCityDep.Items.AddRange(new object[] {
            ""});
            this.cbCityDep.Location = new System.Drawing.Point(233, 25);
            this.cbCityDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCityDep.Name = "cbCityDep";
            this.cbCityDep.Size = new System.Drawing.Size(214, 24);
            this.cbCityDep.Sorted = true;
            this.cbCityDep.TabIndex = 23;
            this.cbCityDep.SelectedIndexChanged += new System.EventHandler(this.cbCityDep_SelectedIndexChanged);
            // 
            // dgvMarinTour
            // 
            this.dgvMarinTour.AllowUserToAddRows = false;
            this.dgvMarinTour.AllowUserToDeleteRows = false;
            this.dgvMarinTour.BackgroundColor = System.Drawing.Color.White;
            this.dgvMarinTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarinTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_tour,
            this.name_tour,
            this.city_departure,
            this.date_departure,
            this.days_tour,
            this.way,
            this.operator_tour,
            this.price});
            this.dgvMarinTour.Location = new System.Drawing.Point(16, 246);
            this.dgvMarinTour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMarinTour.Name = "dgvMarinTour";
            this.dgvMarinTour.ReadOnly = true;
            this.dgvMarinTour.Size = new System.Drawing.Size(1104, 406);
            this.dgvMarinTour.TabIndex = 22;
            // 
            // id_tour
            // 
            this.id_tour.Frozen = true;
            this.id_tour.HeaderText = "id_tour";
            this.id_tour.Name = "id_tour";
            this.id_tour.ReadOnly = true;
            this.id_tour.Visible = false;
            // 
            // name_tour
            // 
            this.name_tour.Frozen = true;
            this.name_tour.HeaderText = "Название тура";
            this.name_tour.Name = "name_tour";
            this.name_tour.ReadOnly = true;
            this.name_tour.Width = 200;
            // 
            // city_departure
            // 
            this.city_departure.Frozen = true;
            this.city_departure.HeaderText = "Город отправления";
            this.city_departure.Name = "city_departure";
            this.city_departure.ReadOnly = true;
            this.city_departure.Width = 160;
            // 
            // date_departure
            // 
            this.date_departure.Frozen = true;
            this.date_departure.HeaderText = "Дата начала";
            this.date_departure.Name = "date_departure";
            this.date_departure.ReadOnly = true;
            this.date_departure.Width = 77;
            // 
            // days_tour
            // 
            this.days_tour.Frozen = true;
            this.days_tour.HeaderText = "Количество дней";
            this.days_tour.Name = "days_tour";
            this.days_tour.ReadOnly = true;
            // 
            // way
            // 
            this.way.Frozen = true;
            this.way.HeaderText = "Путь";
            this.way.Name = "way";
            this.way.ReadOnly = true;
            this.way.Width = 200;
            // 
            // operator_tour
            // 
            this.operator_tour.Frozen = true;
            this.operator_tour.HeaderText = "Тур. оператор";
            this.operator_tour.Name = "operator_tour";
            this.operator_tour.ReadOnly = true;
            this.operator_tour.Width = 180;
            // 
            // price
            // 
            this.price.Frozen = true;
            this.price.HeaderText = "Цена ($)";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 150;
            // 
            // btnMode
            // 
            this.btnMode.BackColor = System.Drawing.Color.White;
            this.btnMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMode.Location = new System.Drawing.Point(16, 678);
            this.btnMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(355, 47);
            this.btnMode.TabIndex = 44;
            this.btnMode.Text = "Интерактивный режим";
            this.btnMode.UseVisualStyleBackColor = false;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // formMarinTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1136, 741);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.lblFindNumber);
            this.Controls.Add(this.chchbAdult);
            this.Controls.Add(this.chckbDays);
            this.Controls.Add(this.chckbDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMaxPrice);
            this.Controls.Add(this.nudAdult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudNumberDays);
            this.Controls.Add(this.lbNumberDays);
            this.Controls.Add(this.lbDateDep);
            this.Controls.Add(this.dtpDateDep);
            this.Controls.Add(this.lbVisitCity);
            this.Controls.Add(this.lbCityDep);
            this.Controls.Add(this.cbVisitCity);
            this.Controls.Add(this.cbCityDep);
            this.Controls.Add(this.dgvMarinTour);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "formMarinTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Морские круизы";
            this.Load += new System.EventHandler(this.formMarinTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAdult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarinTour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFindNumber;
        private System.Windows.Forms.CheckBox chchbAdult;
        private System.Windows.Forms.CheckBox chckbDays;
        private System.Windows.Forms.CheckBox chckbDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMaxPrice;
        private System.Windows.Forms.NumericUpDown nudAdult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudNumberDays;
        private System.Windows.Forms.Label lbNumberDays;
        private System.Windows.Forms.Label lbDateDep;
        private System.Windows.Forms.DateTimePicker dtpDateDep;
        private System.Windows.Forms.Label lbVisitCity;
        private System.Windows.Forms.Label lbCityDep;
        private System.Windows.Forms.ComboBox cbVisitCity;
        public System.Windows.Forms.ComboBox cbCityDep;
        private System.Windows.Forms.DataGridView dgvMarinTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tour;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_tour;
        private System.Windows.Forms.DataGridViewTextBoxColumn city_departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn days_tour;
        private System.Windows.Forms.DataGridViewTextBoxColumn way;
        private System.Windows.Forms.DataGridViewTextBoxColumn operator_tour;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button btnMode;
    }
}