namespace TouristAgency
{
    partial class formExursionsTour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formExursionsTour));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
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
            this.dgvExcursTour = new System.Windows.Forms.DataGridView();
            this.id_tour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_tour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city_dep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.way_tour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excursions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operator_tour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSale = new System.Windows.Forms.Button();
            this.chkbDate = new System.Windows.Forms.CheckBox();
            this.chkbAdult = new System.Windows.Forms.CheckBox();
            this.chkbDays = new System.Windows.Forms.CheckBox();
            this.lblFindNumber = new System.Windows.Forms.Label();
            this.btnMode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcursTour)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(574, 679);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(187, 47);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.White;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApply.Location = new System.Drawing.Point(382, 679);
            this.btnApply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(186, 47);
            this.btnApply.TabIndex = 32;
            this.btnApply.Text = "Применить";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Максимальная цена";
            // 
            // tbMaxPrice
            // 
            this.tbMaxPrice.Location = new System.Drawing.Point(234, 140);
            this.tbMaxPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaxPrice.Name = "tbMaxPrice";
            this.tbMaxPrice.Size = new System.Drawing.Size(214, 22);
            this.tbMaxPrice.TabIndex = 30;
            this.tbMaxPrice.TextChanged += new System.EventHandler(this.tbMaxPrice_TextChanged);
            // 
            // nudAdult
            // 
            this.nudAdult.Location = new System.Drawing.Point(907, 140);
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
            this.nudAdult.TabIndex = 27;
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
            this.label1.Location = new System.Drawing.Point(696, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Количество взрослых";
            // 
            // nudNumberDays
            // 
            this.nudNumberDays.Location = new System.Drawing.Point(907, 85);
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
            this.nudNumberDays.TabIndex = 25;
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
            this.lbNumberDays.Location = new System.Drawing.Point(696, 85);
            this.lbNumberDays.Name = "lbNumberDays";
            this.lbNumberDays.Size = new System.Drawing.Size(142, 20);
            this.lbNumberDays.TabIndex = 24;
            this.lbNumberDays.Text = "Количество дней";
            // 
            // lbDateDep
            // 
            this.lbDateDep.AutoSize = true;
            this.lbDateDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDateDep.Location = new System.Drawing.Point(696, 31);
            this.lbDateDep.Name = "lbDateDep";
            this.lbDateDep.Size = new System.Drawing.Size(152, 20);
            this.lbDateDep.TabIndex = 23;
            this.lbDateDep.Text = "Дата отправления";
            // 
            // dtpDateDep
            // 
            this.dtpDateDep.Location = new System.Drawing.Point(907, 31);
            this.dtpDateDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDateDep.Name = "dtpDateDep";
            this.dtpDateDep.Size = new System.Drawing.Size(214, 22);
            this.dtpDateDep.TabIndex = 22;
            this.dtpDateDep.Value = new System.DateTime(2017, 2, 28, 0, 0, 0, 0);
            // 
            // lbVisitCity
            // 
            this.lbVisitCity.AutoSize = true;
            this.lbVisitCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbVisitCity.Location = new System.Drawing.Point(21, 85);
            this.lbVisitCity.Name = "lbVisitCity";
            this.lbVisitCity.Size = new System.Drawing.Size(159, 20);
            this.lbVisitCity.TabIndex = 21;
            this.lbVisitCity.Text = "Посещаемые места";
            this.lbVisitCity.Click += new System.EventHandler(this.lbVisitCity_Click);
            // 
            // lbCityDep
            // 
            this.lbCityDep.AutoSize = true;
            this.lbCityDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCityDep.Location = new System.Drawing.Point(21, 31);
            this.lbCityDep.Name = "lbCityDep";
            this.lbCityDep.Size = new System.Drawing.Size(160, 20);
            this.lbCityDep.TabIndex = 20;
            this.lbCityDep.Text = "Город отправления";
            this.lbCityDep.Click += new System.EventHandler(this.lbCityDep_Click);
            // 
            // cbVisitCity
            // 
            this.cbVisitCity.FormattingEnabled = true;
            this.cbVisitCity.Items.AddRange(new object[] {
            ""});
            this.cbVisitCity.Location = new System.Drawing.Point(234, 85);
            this.cbVisitCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbVisitCity.Name = "cbVisitCity";
            this.cbVisitCity.Size = new System.Drawing.Size(214, 24);
            this.cbVisitCity.TabIndex = 19;
            this.cbVisitCity.SelectedIndexChanged += new System.EventHandler(this.cbVisitCity_SelectedIndexChanged);
            // 
            // cbCityDep
            // 
            this.cbCityDep.DisplayMember = "ывыа";
            this.cbCityDep.FormattingEnabled = true;
            this.cbCityDep.Items.AddRange(new object[] {
            ""});
            this.cbCityDep.Location = new System.Drawing.Point(234, 31);
            this.cbCityDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCityDep.Name = "cbCityDep";
            this.cbCityDep.Size = new System.Drawing.Size(214, 24);
            this.cbCityDep.Sorted = true;
            this.cbCityDep.TabIndex = 18;
            this.cbCityDep.SelectedIndexChanged += new System.EventHandler(this.cbCityDep_SelectedIndexChanged);
            // 
            // dgvExcursTour
            // 
            this.dgvExcursTour.AllowUserToAddRows = false;
            this.dgvExcursTour.AllowUserToDeleteRows = false;
            this.dgvExcursTour.BackgroundColor = System.Drawing.Color.White;
            this.dgvExcursTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcursTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_tour,
            this.name_tour,
            this.city_dep,
            this.date_start,
            this.number_days,
            this.way_tour,
            this.excursions,
            this.operator_tour,
            this.price});
            this.dgvExcursTour.Location = new System.Drawing.Point(19, 254);
            this.dgvExcursTour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvExcursTour.Name = "dgvExcursTour";
            this.dgvExcursTour.ReadOnly = true;
            this.dgvExcursTour.Size = new System.Drawing.Size(1103, 396);
            this.dgvExcursTour.TabIndex = 34;
            // 
            // id_tour
            // 
            this.id_tour.HeaderText = "id_tour";
            this.id_tour.Name = "id_tour";
            this.id_tour.ReadOnly = true;
            this.id_tour.Visible = false;
            // 
            // name_tour
            // 
            this.name_tour.HeaderText = "Название тура";
            this.name_tour.Name = "name_tour";
            this.name_tour.ReadOnly = true;
            this.name_tour.Width = 150;
            // 
            // city_dep
            // 
            this.city_dep.HeaderText = "Город отправления";
            this.city_dep.Name = "city_dep";
            this.city_dep.ReadOnly = true;
            this.city_dep.Width = 150;
            // 
            // date_start
            // 
            this.date_start.HeaderText = "Дата начала";
            this.date_start.Name = "date_start";
            this.date_start.ReadOnly = true;
            this.date_start.Width = 77;
            // 
            // number_days
            // 
            this.number_days.HeaderText = "Количество дней";
            this.number_days.Name = "number_days";
            this.number_days.ReadOnly = true;
            // 
            // way_tour
            // 
            this.way_tour.HeaderText = "Путь";
            this.way_tour.Name = "way_tour";
            this.way_tour.ReadOnly = true;
            this.way_tour.Width = 150;
            // 
            // excursions
            // 
            this.excursions.HeaderText = "Экскурсии";
            this.excursions.Name = "excursions";
            this.excursions.ReadOnly = true;
            this.excursions.Width = 170;
            // 
            // operator_tour
            // 
            this.operator_tour.HeaderText = "Тур. оператор";
            this.operator_tour.Name = "operator_tour";
            this.operator_tour.ReadOnly = true;
            this.operator_tour.Width = 140;
            // 
            // price
            // 
            this.price.HeaderText = "Цена ($)";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 122;
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.Color.White;
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSale.Location = new System.Drawing.Point(767, 679);
            this.btnSale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(355, 47);
            this.btnSale.TabIndex = 35;
            this.btnSale.Text = "Оформить заказ";
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // chkbDate
            // 
            this.chkbDate.AutoSize = true;
            this.chkbDate.Location = new System.Drawing.Point(672, 34);
            this.chkbDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkbDate.Name = "chkbDate";
            this.chkbDate.Size = new System.Drawing.Size(15, 14);
            this.chkbDate.TabIndex = 36;
            this.chkbDate.UseVisualStyleBackColor = true;
            // 
            // chkbAdult
            // 
            this.chkbAdult.AutoSize = true;
            this.chkbAdult.Location = new System.Drawing.Point(672, 145);
            this.chkbAdult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkbAdult.Name = "chkbAdult";
            this.chkbAdult.Size = new System.Drawing.Size(15, 14);
            this.chkbAdult.TabIndex = 37;
            this.chkbAdult.UseVisualStyleBackColor = true;
            // 
            // chkbDays
            // 
            this.chkbDays.AutoSize = true;
            this.chkbDays.Location = new System.Drawing.Point(672, 89);
            this.chkbDays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkbDays.Name = "chkbDays";
            this.chkbDays.Size = new System.Drawing.Size(15, 14);
            this.chkbDays.TabIndex = 39;
            this.chkbDays.UseVisualStyleBackColor = true;
            // 
            // lblFindNumber
            // 
            this.lblFindNumber.AutoSize = true;
            this.lblFindNumber.Location = new System.Drawing.Point(19, 657);
            this.lblFindNumber.Name = "lblFindNumber";
            this.lblFindNumber.Size = new System.Drawing.Size(15, 16);
            this.lblFindNumber.TabIndex = 40;
            this.lblFindNumber.Text = "1";
            // 
            // btnMode
            // 
            this.btnMode.BackColor = System.Drawing.Color.White;
            this.btnMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMode.Location = new System.Drawing.Point(21, 679);
            this.btnMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(355, 47);
            this.btnMode.TabIndex = 41;
            this.btnMode.Text = "Интерактивный режим";
            this.btnMode.UseVisualStyleBackColor = false;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // formExursionsTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1136, 741);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.lblFindNumber);
            this.Controls.Add(this.chkbDays);
            this.Controls.Add(this.chkbAdult);
            this.Controls.Add(this.chkbDate);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.dgvExcursTour);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
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
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "formExursionsTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Экскурсионные туры";
            this.Load += new System.EventHandler(this.formExursionsTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAdult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcursTour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
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
        private System.Windows.Forms.DataGridView dgvExcursTour;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.CheckBox chkbDate;
        private System.Windows.Forms.CheckBox chkbAdult;
        private System.Windows.Forms.CheckBox chkbDays;
        private System.Windows.Forms.Label lblFindNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tour;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_tour;
        private System.Windows.Forms.DataGridViewTextBoxColumn city_dep;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_days;
        private System.Windows.Forms.DataGridViewTextBoxColumn way_tour;
        private System.Windows.Forms.DataGridViewTextBoxColumn excursions;
        private System.Windows.Forms.DataGridViewTextBoxColumn operator_tour;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button btnMode;
    }
}