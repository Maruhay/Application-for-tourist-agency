namespace TouristAgency
{
    partial class formSeaTour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSeaTour));
            this.cbCityDep = new System.Windows.Forms.ComboBox();
            this.lblCityDep = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.lblHotel = new System.Windows.Forms.Label();
            this.gbStar = new System.Windows.Forms.GroupBox();
            this.rbTwoStars = new System.Windows.Forms.CheckBox();
            this.rbThreeStars = new System.Windows.Forms.CheckBox();
            this.rbFourStars = new System.Windows.Forms.CheckBox();
            this.rbFiveStars = new System.Windows.Forms.CheckBox();
            this.gbFood = new System.Windows.Forms.GroupBox();
            this.rbRO = new System.Windows.Forms.CheckBox();
            this.rbBB = new System.Windows.Forms.CheckBox();
            this.rbHB = new System.Windows.Forms.CheckBox();
            this.rbFB = new System.Windows.Forms.CheckBox();
            this.rbAI = new System.Windows.Forms.CheckBox();
            this.rbUAI = new System.Windows.Forms.CheckBox();
            this.nudNumberDays = new System.Windows.Forms.NumericUpDown();
            this.lbNumberDays = new System.Windows.Forms.Label();
            this.lbDateDep = new System.Windows.Forms.Label();
            this.dtpDateDep = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblMaxPrice = new System.Windows.Forms.Label();
            this.tbMaxPrice = new System.Windows.Forms.TextBox();
            this.nudAdult = new System.Windows.Forms.NumericUpDown();
            this.lblNumberAdult = new System.Windows.Forms.Label();
            this.dgvSeaTour = new System.Windows.Forms.DataGridView();
            this.id_sea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_sea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city_dep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_says = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.way_tour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city_tour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operator_tour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSale = new System.Windows.Forms.Button();
            this.chkbDate = new System.Windows.Forms.CheckBox();
            this.chkbFood = new System.Windows.Forms.CheckBox();
            this.chkbStar = new System.Windows.Forms.CheckBox();
            this.chkbDays = new System.Windows.Forms.CheckBox();
            this.chkbAdult = new System.Windows.Forms.CheckBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.lblFindNumber = new System.Windows.Forms.Label();
            this.btnMode = new System.Windows.Forms.Button();
            this.gbStar.SuspendLayout();
            this.gbFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeaTour)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCityDep
            // 
            this.cbCityDep.DisplayMember = "ывыа";
            this.cbCityDep.FormattingEnabled = true;
            this.cbCityDep.Items.AddRange(new object[] {
            ""});
            this.cbCityDep.Location = new System.Drawing.Point(225, 10);
            this.cbCityDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCityDep.Name = "cbCityDep";
            this.cbCityDep.Size = new System.Drawing.Size(214, 24);
            this.cbCityDep.Sorted = true;
            this.cbCityDep.TabIndex = 2;
            this.cbCityDep.SelectedIndexChanged += new System.EventHandler(this.cbCityDep_SelectedIndexChanged);
            // 
            // lblCityDep
            // 
            this.lblCityDep.AutoSize = true;
            this.lblCityDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCityDep.Location = new System.Drawing.Point(14, 11);
            this.lblCityDep.Name = "lblCityDep";
            this.lblCityDep.Size = new System.Drawing.Size(160, 20);
            this.lblCityDep.TabIndex = 3;
            this.lblCityDep.Text = "Город отправления";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Страна";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbCountry
            // 
            this.cbCountry.DisplayMember = "ывыа";
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Items.AddRange(new object[] {
            ""});
            this.cbCountry.Location = new System.Drawing.Point(225, 63);
            this.cbCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(214, 24);
            this.cbCountry.Sorted = true;
            this.cbCountry.TabIndex = 4;
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHotel.Location = new System.Drawing.Point(14, 198);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(58, 20);
            this.lblHotel.TabIndex = 6;
            this.lblHotel.Text = "Отель";
            this.lblHotel.Click += new System.EventHandler(this.lblHotel_Click);
            // 
            // gbStar
            // 
            this.gbStar.Controls.Add(this.rbTwoStars);
            this.gbStar.Controls.Add(this.rbThreeStars);
            this.gbStar.Controls.Add(this.rbFourStars);
            this.gbStar.Controls.Add(this.rbFiveStars);
            this.gbStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbStar.Location = new System.Drawing.Point(127, 171);
            this.gbStar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbStar.Name = "gbStar";
            this.gbStar.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbStar.Size = new System.Drawing.Size(166, 73);
            this.gbStar.TabIndex = 7;
            this.gbStar.TabStop = false;
            this.gbStar.Text = "Звёздность";
            // 
            // rbTwoStars
            // 
            this.rbTwoStars.AutoSize = true;
            this.rbTwoStars.Checked = true;
            this.rbTwoStars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rbTwoStars.Location = new System.Drawing.Point(104, 41);
            this.rbTwoStars.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbTwoStars.Name = "rbTwoStars";
            this.rbTwoStars.Size = new System.Drawing.Size(39, 20);
            this.rbTwoStars.TabIndex = 3;
            this.rbTwoStars.Text = "2*";
            this.rbTwoStars.UseVisualStyleBackColor = true;
            // 
            // rbThreeStars
            // 
            this.rbThreeStars.AutoSize = true;
            this.rbThreeStars.Checked = true;
            this.rbThreeStars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rbThreeStars.Location = new System.Drawing.Point(7, 41);
            this.rbThreeStars.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbThreeStars.Name = "rbThreeStars";
            this.rbThreeStars.Size = new System.Drawing.Size(39, 20);
            this.rbThreeStars.TabIndex = 2;
            this.rbThreeStars.Text = "3*";
            this.rbThreeStars.UseVisualStyleBackColor = true;
            // 
            // rbFourStars
            // 
            this.rbFourStars.AutoSize = true;
            this.rbFourStars.Checked = true;
            this.rbFourStars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rbFourStars.Location = new System.Drawing.Point(104, 18);
            this.rbFourStars.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbFourStars.Name = "rbFourStars";
            this.rbFourStars.Size = new System.Drawing.Size(39, 20);
            this.rbFourStars.TabIndex = 1;
            this.rbFourStars.Text = "4*";
            this.rbFourStars.UseVisualStyleBackColor = true;
            // 
            // rbFiveStars
            // 
            this.rbFiveStars.AutoSize = true;
            this.rbFiveStars.Checked = true;
            this.rbFiveStars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rbFiveStars.Location = new System.Drawing.Point(7, 18);
            this.rbFiveStars.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbFiveStars.Name = "rbFiveStars";
            this.rbFiveStars.Size = new System.Drawing.Size(39, 20);
            this.rbFiveStars.TabIndex = 0;
            this.rbFiveStars.Text = "5*";
            this.rbFiveStars.UseVisualStyleBackColor = true;
            // 
            // gbFood
            // 
            this.gbFood.Controls.Add(this.rbRO);
            this.gbFood.Controls.Add(this.rbBB);
            this.gbFood.Controls.Add(this.rbHB);
            this.gbFood.Controls.Add(this.rbFB);
            this.gbFood.Controls.Add(this.rbAI);
            this.gbFood.Controls.Add(this.rbUAI);
            this.gbFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbFood.Location = new System.Drawing.Point(339, 171);
            this.gbFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFood.Name = "gbFood";
            this.gbFood.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFood.Size = new System.Drawing.Size(247, 73);
            this.gbFood.TabIndex = 8;
            this.gbFood.TabStop = false;
            this.gbFood.Text = "Питание";
            // 
            // rbRO
            // 
            this.rbRO.AutoSize = true;
            this.rbRO.Checked = true;
            this.rbRO.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rbRO.Location = new System.Drawing.Point(181, 41);
            this.rbRO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbRO.Name = "rbRO";
            this.rbRO.Size = new System.Drawing.Size(47, 20);
            this.rbRO.TabIndex = 9;
            this.rbRO.Text = "RO";
            this.rbRO.UseVisualStyleBackColor = true;
            // 
            // rbBB
            // 
            this.rbBB.AutoSize = true;
            this.rbBB.Checked = true;
            this.rbBB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rbBB.Location = new System.Drawing.Point(104, 41);
            this.rbBB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbBB.Name = "rbBB";
            this.rbBB.Size = new System.Drawing.Size(45, 20);
            this.rbBB.TabIndex = 8;
            this.rbBB.Text = "BB";
            this.rbBB.UseVisualStyleBackColor = true;
            // 
            // rbHB
            // 
            this.rbHB.AutoSize = true;
            this.rbHB.Checked = true;
            this.rbHB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rbHB.Location = new System.Drawing.Point(7, 41);
            this.rbHB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbHB.Name = "rbHB";
            this.rbHB.Size = new System.Drawing.Size(46, 20);
            this.rbHB.TabIndex = 7;
            this.rbHB.Text = "HB";
            this.rbHB.UseVisualStyleBackColor = true;
            // 
            // rbFB
            // 
            this.rbFB.AutoSize = true;
            this.rbFB.Checked = true;
            this.rbFB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rbFB.Location = new System.Drawing.Point(181, 18);
            this.rbFB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbFB.Name = "rbFB";
            this.rbFB.Size = new System.Drawing.Size(44, 20);
            this.rbFB.TabIndex = 6;
            this.rbFB.Text = "FB";
            this.rbFB.UseVisualStyleBackColor = true;
            // 
            // rbAI
            // 
            this.rbAI.AutoSize = true;
            this.rbAI.Checked = true;
            this.rbAI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rbAI.Location = new System.Drawing.Point(104, 18);
            this.rbAI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbAI.Name = "rbAI";
            this.rbAI.Size = new System.Drawing.Size(39, 20);
            this.rbAI.TabIndex = 5;
            this.rbAI.Text = "AI";
            this.rbAI.UseVisualStyleBackColor = true;
            // 
            // rbUAI
            // 
            this.rbUAI.AutoSize = true;
            this.rbUAI.Checked = true;
            this.rbUAI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rbUAI.Location = new System.Drawing.Point(7, 18);
            this.rbUAI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbUAI.Name = "rbUAI";
            this.rbUAI.Size = new System.Drawing.Size(49, 20);
            this.rbUAI.TabIndex = 4;
            this.rbUAI.Text = "UAI";
            this.rbUAI.UseVisualStyleBackColor = true;
            // 
            // nudNumberDays
            // 
            this.nudNumberDays.Location = new System.Drawing.Point(904, 64);
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
            this.nudNumberDays.TabIndex = 12;
            this.nudNumberDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberDays.ValueChanged += new System.EventHandler(this.nudNumberDays_ValueChanged);
            // 
            // lbNumberDays
            // 
            this.lbNumberDays.AutoSize = true;
            this.lbNumberDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNumberDays.Location = new System.Drawing.Point(692, 64);
            this.lbNumberDays.Name = "lbNumberDays";
            this.lbNumberDays.Size = new System.Drawing.Size(142, 20);
            this.lbNumberDays.TabIndex = 11;
            this.lbNumberDays.Text = "Количество дней";
            this.lbNumberDays.Click += new System.EventHandler(this.lbNumberDays_Click);
            // 
            // lbDateDep
            // 
            this.lbDateDep.AutoSize = true;
            this.lbDateDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDateDep.Location = new System.Drawing.Point(692, 14);
            this.lbDateDep.Name = "lbDateDep";
            this.lbDateDep.Size = new System.Drawing.Size(152, 20);
            this.lbDateDep.TabIndex = 10;
            this.lbDateDep.Text = "Дата отправления";
            this.lbDateDep.Click += new System.EventHandler(this.lbDateDep_Click);
            // 
            // dtpDateDep
            // 
            this.dtpDateDep.Location = new System.Drawing.Point(905, 19);
            this.dtpDateDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDateDep.Name = "dtpDateDep";
            this.dtpDateDep.Size = new System.Drawing.Size(214, 22);
            this.dtpDateDep.TabIndex = 9;
            this.dtpDateDep.Value = new System.DateTime(2017, 2, 27, 0, 0, 0, 0);
            this.dtpDateDep.ValueChanged += new System.EventHandler(this.dtpDateDep_ValueChanged);
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
            this.btnCancel.TabIndex = 25;
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
            this.btnApply.TabIndex = 24;
            this.btnApply.Text = "Применить";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lblMaxPrice
            // 
            this.lblMaxPrice.AutoSize = true;
            this.lblMaxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMaxPrice.Location = new System.Drawing.Point(694, 166);
            this.lblMaxPrice.Name = "lblMaxPrice";
            this.lblMaxPrice.Size = new System.Drawing.Size(162, 20);
            this.lblMaxPrice.TabIndex = 23;
            this.lblMaxPrice.Text = "Максимальная цена";
            // 
            // tbMaxPrice
            // 
            this.tbMaxPrice.Location = new System.Drawing.Point(905, 166);
            this.tbMaxPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaxPrice.Name = "tbMaxPrice";
            this.tbMaxPrice.Size = new System.Drawing.Size(214, 22);
            this.tbMaxPrice.TabIndex = 22;
            // 
            // nudAdult
            // 
            this.nudAdult.Location = new System.Drawing.Point(906, 112);
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
            this.nudAdult.TabIndex = 19;
            this.nudAdult.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNumberAdult
            // 
            this.lblNumberAdult.AutoSize = true;
            this.lblNumberAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumberAdult.Location = new System.Drawing.Point(694, 112);
            this.lblNumberAdult.Name = "lblNumberAdult";
            this.lblNumberAdult.Size = new System.Drawing.Size(175, 20);
            this.lblNumberAdult.TabIndex = 18;
            this.lblNumberAdult.Text = "Количество взрослых";
            // 
            // dgvSeaTour
            // 
            this.dgvSeaTour.AllowUserToAddRows = false;
            this.dgvSeaTour.AllowUserToDeleteRows = false;
            this.dgvSeaTour.BackgroundColor = System.Drawing.Color.White;
            this.dgvSeaTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeaTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_sea,
            this.name_sea,
            this.city_dep,
            this.date_start,
            this.number_says,
            this.way_tour,
            this.city_tour,
            this.operator_tour,
            this.price});
            this.dgvSeaTour.GridColor = System.Drawing.Color.White;
            this.dgvSeaTour.Location = new System.Drawing.Point(19, 286);
            this.dgvSeaTour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSeaTour.Name = "dgvSeaTour";
            this.dgvSeaTour.ReadOnly = true;
            this.dgvSeaTour.Size = new System.Drawing.Size(1100, 369);
            this.dgvSeaTour.TabIndex = 26;
            // 
            // id_sea
            // 
            this.id_sea.HeaderText = "id_sale";
            this.id_sea.Name = "id_sea";
            this.id_sea.ReadOnly = true;
            this.id_sea.Visible = false;
            // 
            // name_sea
            // 
            this.name_sea.HeaderText = "Название тура";
            this.name_sea.Name = "name_sea";
            this.name_sea.ReadOnly = true;
            this.name_sea.Width = 200;
            // 
            // city_dep
            // 
            this.city_dep.HeaderText = "Город отправления";
            this.city_dep.Name = "city_dep";
            this.city_dep.ReadOnly = true;
            this.city_dep.Width = 160;
            // 
            // date_start
            // 
            this.date_start.HeaderText = "Дата начала";
            this.date_start.Name = "date_start";
            this.date_start.ReadOnly = true;
            this.date_start.Width = 77;
            // 
            // number_says
            // 
            this.number_says.HeaderText = "Количество дней";
            this.number_says.Name = "number_says";
            this.number_says.ReadOnly = true;
            this.number_says.Width = 130;
            // 
            // way_tour
            // 
            this.way_tour.HeaderText = "Страна";
            this.way_tour.Name = "way_tour";
            this.way_tour.ReadOnly = true;
            this.way_tour.Width = 130;
            // 
            // city_tour
            // 
            this.city_tour.HeaderText = "Регион";
            this.city_tour.Name = "city_tour";
            this.city_tour.ReadOnly = true;
            this.city_tour.Width = 130;
            // 
            // operator_tour
            // 
            this.operator_tour.HeaderText = "Тур. оператор";
            this.operator_tour.Name = "operator_tour";
            this.operator_tour.ReadOnly = true;
            this.operator_tour.Width = 130;
            // 
            // price
            // 
            this.price.HeaderText = "Цена ($)";
            this.price.Name = "price";
            this.price.ReadOnly = true;
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
            this.btnSale.TabIndex = 27;
            this.btnSale.Text = "Оформить заказ";
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // chkbDate
            // 
            this.chkbDate.AutoSize = true;
            this.chkbDate.Location = new System.Drawing.Point(669, 20);
            this.chkbDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkbDate.Name = "chkbDate";
            this.chkbDate.Size = new System.Drawing.Size(15, 14);
            this.chkbDate.TabIndex = 28;
            this.chkbDate.UseVisualStyleBackColor = true;
            // 
            // chkbFood
            // 
            this.chkbFood.AutoSize = true;
            this.chkbFood.Location = new System.Drawing.Point(315, 204);
            this.chkbFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkbFood.Name = "chkbFood";
            this.chkbFood.Size = new System.Drawing.Size(15, 14);
            this.chkbFood.TabIndex = 30;
            this.chkbFood.UseVisualStyleBackColor = true;
            // 
            // chkbStar
            // 
            this.chkbStar.AutoSize = true;
            this.chkbStar.Location = new System.Drawing.Point(103, 204);
            this.chkbStar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkbStar.Name = "chkbStar";
            this.chkbStar.Size = new System.Drawing.Size(15, 14);
            this.chkbStar.TabIndex = 31;
            this.chkbStar.UseVisualStyleBackColor = true;
            // 
            // chkbDays
            // 
            this.chkbDays.AutoSize = true;
            this.chkbDays.Location = new System.Drawing.Point(668, 69);
            this.chkbDays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkbDays.Name = "chkbDays";
            this.chkbDays.Size = new System.Drawing.Size(15, 14);
            this.chkbDays.TabIndex = 32;
            this.chkbDays.UseVisualStyleBackColor = true;
            // 
            // chkbAdult
            // 
            this.chkbAdult.AutoSize = true;
            this.chkbAdult.Location = new System.Drawing.Point(670, 117);
            this.chkbAdult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkbAdult.Name = "chkbAdult";
            this.chkbAdult.Size = new System.Drawing.Size(15, 14);
            this.chkbAdult.TabIndex = 33;
            this.chkbAdult.UseVisualStyleBackColor = true;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCity.Location = new System.Drawing.Point(14, 111);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(62, 20);
            this.lblCity.TabIndex = 35;
            this.lblCity.Text = "Регион";
            // 
            // cbCity
            // 
            this.cbCity.DisplayMember = "ывыа";
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Items.AddRange(new object[] {
            ""});
            this.cbCity.Location = new System.Drawing.Point(225, 112);
            this.cbCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(214, 24);
            this.cbCity.Sorted = true;
            this.cbCity.TabIndex = 34;
            this.cbCity.SelectedIndexChanged += new System.EventHandler(this.cbCity_SelectedIndexChanged);
            // 
            // lblFindNumber
            // 
            this.lblFindNumber.AutoSize = true;
            this.lblFindNumber.Location = new System.Drawing.Point(19, 658);
            this.lblFindNumber.Name = "lblFindNumber";
            this.lblFindNumber.Size = new System.Drawing.Size(15, 16);
            this.lblFindNumber.TabIndex = 36;
            this.lblFindNumber.Text = "1";
            // 
            // btnMode
            // 
            this.btnMode.BackColor = System.Drawing.Color.White;
            this.btnMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMode.Location = new System.Drawing.Point(18, 678);
            this.btnMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(355, 47);
            this.btnMode.TabIndex = 37;
            this.btnMode.Text = "Интерактивный режим";
            this.btnMode.UseVisualStyleBackColor = false;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // formSeaTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1136, 741);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.lblFindNumber);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.chkbAdult);
            this.Controls.Add(this.chkbDays);
            this.Controls.Add(this.chkbStar);
            this.Controls.Add(this.chkbFood);
            this.Controls.Add(this.chkbDate);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.dgvSeaTour);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblMaxPrice);
            this.Controls.Add(this.tbMaxPrice);
            this.Controls.Add(this.nudAdult);
            this.Controls.Add(this.lblNumberAdult);
            this.Controls.Add(this.nudNumberDays);
            this.Controls.Add(this.lbNumberDays);
            this.Controls.Add(this.lbDateDep);
            this.Controls.Add(this.dtpDateDep);
            this.Controls.Add(this.gbFood);
            this.Controls.Add(this.gbStar);
            this.Controls.Add(this.lblHotel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.lblCityDep);
            this.Controls.Add(this.cbCityDep);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "formSeaTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отдых на море";
            this.Load += new System.EventHandler(this.formSeaTour_Load);
            this.gbStar.ResumeLayout(false);
            this.gbStar.PerformLayout();
            this.gbFood.ResumeLayout(false);
            this.gbFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeaTour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cbCityDep;
        private System.Windows.Forms.Label lblCityDep;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.GroupBox gbStar;
        private System.Windows.Forms.CheckBox rbTwoStars;
        private System.Windows.Forms.CheckBox rbThreeStars;
        private System.Windows.Forms.CheckBox rbFourStars;
        private System.Windows.Forms.CheckBox rbFiveStars;
        private System.Windows.Forms.GroupBox gbFood;
        private System.Windows.Forms.CheckBox rbRO;
        private System.Windows.Forms.CheckBox rbBB;
        private System.Windows.Forms.CheckBox rbHB;
        private System.Windows.Forms.CheckBox rbFB;
        private System.Windows.Forms.CheckBox rbAI;
        private System.Windows.Forms.CheckBox rbUAI;
        private System.Windows.Forms.NumericUpDown nudNumberDays;
        private System.Windows.Forms.Label lbNumberDays;
        private System.Windows.Forms.Label lbDateDep;
        private System.Windows.Forms.DateTimePicker dtpDateDep;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblMaxPrice;
        private System.Windows.Forms.TextBox tbMaxPrice;
        private System.Windows.Forms.NumericUpDown nudAdult;
        private System.Windows.Forms.Label lblNumberAdult;
        private System.Windows.Forms.DataGridView dgvSeaTour;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.CheckBox chkbDate;
        private System.Windows.Forms.CheckBox chkbFood;
        private System.Windows.Forms.CheckBox chkbStar;
        private System.Windows.Forms.CheckBox chkbDays;
        private System.Windows.Forms.CheckBox chkbAdult;
        private System.Windows.Forms.Label lblCity;
        public System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.Label lblFindNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_sea;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_sea;
        private System.Windows.Forms.DataGridViewTextBoxColumn city_dep;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_says;
        private System.Windows.Forms.DataGridViewTextBoxColumn way_tour;
        private System.Windows.Forms.DataGridViewTextBoxColumn city_tour;
        private System.Windows.Forms.DataGridViewTextBoxColumn operator_tour;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button btnMode;
    }
}