namespace TouristAgency
{
    partial class formHotTour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHotTour));
            this.dgvHotTour = new System.Windows.Forms.DataGridView();
            this.id_tour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_tour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city_dep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_dep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.way = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excursions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbTypeTour = new System.Windows.Forms.ComboBox();
            this.lblTypeTour = new System.Windows.Forms.Label();
            this.lblPersons = new System.Windows.Forms.Label();
            this.nudPerson = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.lblFoundNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotTour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHotTour
            // 
            this.dgvHotTour.AllowUserToAddRows = false;
            this.dgvHotTour.AllowUserToDeleteRows = false;
            this.dgvHotTour.BackgroundColor = System.Drawing.Color.White;
            this.dgvHotTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHotTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_tour,
            this.type_tour,
            this.name,
            this.city_dep,
            this.date_dep,
            this.days,
            this.way,
            this.excursions,
            this.country,
            this.city,
            this.price});
            this.dgvHotTour.GridColor = System.Drawing.Color.White;
            this.dgvHotTour.Location = new System.Drawing.Point(14, 112);
            this.dgvHotTour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvHotTour.Name = "dgvHotTour";
            this.dgvHotTour.ReadOnly = true;
            this.dgvHotTour.Size = new System.Drawing.Size(1108, 534);
            this.dgvHotTour.TabIndex = 0;
            this.dgvHotTour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHotTour_CellContentClick);
            // 
            // id_tour
            // 
            this.id_tour.HeaderText = "id_tour";
            this.id_tour.Name = "id_tour";
            this.id_tour.ReadOnly = true;
            this.id_tour.Visible = false;
            // 
            // type_tour
            // 
            this.type_tour.HeaderText = "Тип тура";
            this.type_tour.Name = "type_tour";
            this.type_tour.ReadOnly = true;
            this.type_tour.Width = 120;
            // 
            // name
            // 
            this.name.HeaderText = "Название тура";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 130;
            // 
            // city_dep
            // 
            this.city_dep.HeaderText = "Город отправления";
            this.city_dep.Name = "city_dep";
            this.city_dep.ReadOnly = true;
            this.city_dep.Width = 120;
            // 
            // date_dep
            // 
            this.date_dep.HeaderText = "Дата начала";
            this.date_dep.Name = "date_dep";
            this.date_dep.ReadOnly = true;
            this.date_dep.Width = 77;
            // 
            // days
            // 
            this.days.HeaderText = "Количество дней";
            this.days.Name = "days";
            this.days.ReadOnly = true;
            // 
            // way
            // 
            this.way.HeaderText = "Путь";
            this.way.Name = "way";
            this.way.ReadOnly = true;
            this.way.Width = 120;
            // 
            // excursions
            // 
            this.excursions.HeaderText = "Экскурсии";
            this.excursions.Name = "excursions";
            this.excursions.ReadOnly = true;
            // 
            // country
            // 
            this.country.HeaderText = "Страна";
            this.country.Name = "country";
            this.country.ReadOnly = true;
            // 
            // city
            // 
            this.city.HeaderText = "Город";
            this.city.Name = "city";
            this.city.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Цена ($)";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 97;
            // 
            // cbTypeTour
            // 
            this.cbTypeTour.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbTypeTour.FormattingEnabled = true;
            this.cbTypeTour.Items.AddRange(new object[] {
            ""});
            this.cbTypeTour.Location = new System.Drawing.Point(220, 14);
            this.cbTypeTour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTypeTour.Name = "cbTypeTour";
            this.cbTypeTour.Size = new System.Drawing.Size(221, 24);
            this.cbTypeTour.TabIndex = 27;
            this.cbTypeTour.SelectedIndexChanged += new System.EventHandler(this.cbTypeTour_SelectedIndexChanged);
            this.cbTypeTour.TextChanged += new System.EventHandler(this.cbTypeTour_TextChanged);
            // 
            // lblTypeTour
            // 
            this.lblTypeTour.AutoSize = true;
            this.lblTypeTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTypeTour.Location = new System.Drawing.Point(14, 12);
            this.lblTypeTour.Name = "lblTypeTour";
            this.lblTypeTour.Size = new System.Drawing.Size(74, 20);
            this.lblTypeTour.TabIndex = 26;
            this.lblTypeTour.Text = "Тип тура";
            // 
            // lblPersons
            // 
            this.lblPersons.AutoSize = true;
            this.lblPersons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPersons.Location = new System.Drawing.Point(14, 62);
            this.lblPersons.Name = "lblPersons";
            this.lblPersons.Size = new System.Drawing.Size(155, 20);
            this.lblPersons.TabIndex = 30;
            this.lblPersons.Text = "Количество людей";
            this.lblPersons.Click += new System.EventHandler(this.lblPersons_Click);
            // 
            // nudPerson
            // 
            this.nudPerson.Location = new System.Drawing.Point(220, 62);
            this.nudPerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudPerson.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPerson.Name = "nudPerson";
            this.nudPerson.Size = new System.Drawing.Size(222, 22);
            this.nudPerson.TabIndex = 31;
            this.nudPerson.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPerson.ValueChanged += new System.EventHandler(this.nudPerson_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(269, 678);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(171, 47);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.White;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApply.Location = new System.Drawing.Point(14, 678);
            this.btnApply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(171, 47);
            this.btnApply.TabIndex = 33;
            this.btnApply.Text = "Применить";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.Color.White;
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSale.Location = new System.Drawing.Point(696, 678);
            this.btnSale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(426, 47);
            this.btnSale.TabIndex = 32;
            this.btnSale.Text = "Оформить заказ";
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // lblFoundNumber
            // 
            this.lblFoundNumber.AutoSize = true;
            this.lblFoundNumber.Location = new System.Drawing.Point(15, 656);
            this.lblFoundNumber.Name = "lblFoundNumber";
            this.lblFoundNumber.Size = new System.Drawing.Size(15, 16);
            this.lblFoundNumber.TabIndex = 35;
            this.lblFoundNumber.Text = "1";
            // 
            // formHotTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1136, 740);
            this.Controls.Add(this.lblFoundNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.nudPerson);
            this.Controls.Add(this.lblPersons);
            this.Controls.Add(this.cbTypeTour);
            this.Controls.Add(this.lblTypeTour);
            this.Controls.Add(this.dgvHotTour);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "formHotTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Горящие туры";
            this.Load += new System.EventHandler(this.formHotTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHotTour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHotTour;
        public System.Windows.Forms.ComboBox cbTypeTour;
        private System.Windows.Forms.Label lblTypeTour;
        private System.Windows.Forms.Label lblPersons;
        private System.Windows.Forms.NumericUpDown nudPerson;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Label lblFoundNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tour;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_tour;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn city_dep;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_dep;
        private System.Windows.Forms.DataGridViewTextBoxColumn days;
        private System.Windows.Forms.DataGridViewTextBoxColumn way;
        private System.Windows.Forms.DataGridViewTextBoxColumn excursions;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}