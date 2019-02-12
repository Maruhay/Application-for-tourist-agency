namespace TouristAgency
{
    partial class formFormSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFormSale));
            this.tbTypeTour = new System.Windows.Forms.TextBox();
            this.lblTypeTour = new System.Windows.Forms.Label();
            this.lblNameTour = new System.Windows.Forms.Label();
            this.lblDateDep = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblPerson = new System.Windows.Forms.Label();
            this.lblCityDep = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.gbTour = new System.Windows.Forms.GroupBox();
            this.lblChildren = new System.Windows.Forms.Label();
            this.tbChildren = new System.Windows.Forms.TextBox();
            this.lblFood = new System.Windows.Forms.Label();
            this.lblHotel = new System.Windows.Forms.Label();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbHotel = new System.Windows.Forms.ComboBox();
            this.tbExcursions = new System.Windows.Forms.TextBox();
            this.lblExcursions = new System.Windows.Forms.Label();
            this.tbWay = new System.Windows.Forms.TextBox();
            this.lblWay = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbNameTour = new System.Windows.Forms.TextBox();
            this.tbDateStart = new System.Windows.Forms.TextBox();
            this.tbDays = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbAdult = new System.Windows.Forms.TextBox();
            this.tbCityDep = new System.Windows.Forms.TextBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.gbSide = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblItogo = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnGetPrice = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnAddEmpl = new System.Windows.Forms.Button();
            this.btnImg = new System.Windows.Forms.Button();
            this.gbTour.SuspendLayout();
            this.gbSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTypeTour
            // 
            this.tbTypeTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTypeTour.Location = new System.Drawing.Point(295, 34);
            this.tbTypeTour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTypeTour.Name = "tbTypeTour";
            this.tbTypeTour.ReadOnly = true;
            this.tbTypeTour.Size = new System.Drawing.Size(196, 20);
            this.tbTypeTour.TabIndex = 28;
            // 
            // lblTypeTour
            // 
            this.lblTypeTour.AutoSize = true;
            this.lblTypeTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTypeTour.Location = new System.Drawing.Point(7, 34);
            this.lblTypeTour.Name = "lblTypeTour";
            this.lblTypeTour.Size = new System.Drawing.Size(74, 20);
            this.lblTypeTour.TabIndex = 27;
            this.lblTypeTour.Text = "Тип тура";
            // 
            // lblNameTour
            // 
            this.lblNameTour.AutoSize = true;
            this.lblNameTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameTour.Location = new System.Drawing.Point(7, 73);
            this.lblNameTour.Name = "lblNameTour";
            this.lblNameTour.Size = new System.Drawing.Size(121, 20);
            this.lblNameTour.TabIndex = 29;
            this.lblNameTour.Text = "Название тура";
            // 
            // lblDateDep
            // 
            this.lblDateDep.AutoSize = true;
            this.lblDateDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateDep.Location = new System.Drawing.Point(7, 116);
            this.lblDateDep.Name = "lblDateDep";
            this.lblDateDep.Size = new System.Drawing.Size(107, 20);
            this.lblDateDep.TabIndex = 31;
            this.lblDateDep.Text = "Дата начала";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDays.Location = new System.Drawing.Point(7, 156);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(142, 20);
            this.lblDays.TabIndex = 33;
            this.lblDays.Text = "Количество дней";
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPerson.Location = new System.Drawing.Point(7, 197);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(175, 20);
            this.lblPerson.TabIndex = 35;
            this.lblPerson.Text = "Количество взрослых";
            this.lblPerson.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCityDep
            // 
            this.lblCityDep.AutoSize = true;
            this.lblCityDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCityDep.Location = new System.Drawing.Point(7, 278);
            this.lblCityDep.Name = "lblCityDep";
            this.lblCityDep.Size = new System.Drawing.Size(160, 20);
            this.lblCityDep.TabIndex = 37;
            this.lblCityDep.Text = "Город отправления";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCity.Location = new System.Drawing.Point(7, 359);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(56, 20);
            this.lblCity.TabIndex = 39;
            this.lblCity.Text = "Город";
            this.lblCity.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountry.Location = new System.Drawing.Point(7, 319);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(65, 20);
            this.lblCountry.TabIndex = 41;
            this.lblCountry.Text = "Страна";
            // 
            // gbTour
            // 
            this.gbTour.Controls.Add(this.btnImg);
            this.gbTour.Controls.Add(this.lblChildren);
            this.gbTour.Controls.Add(this.tbChildren);
            this.gbTour.Controls.Add(this.lblFood);
            this.gbTour.Controls.Add(this.lblHotel);
            this.gbTour.Controls.Add(this.cbFood);
            this.gbTour.Controls.Add(this.cbHotel);
            this.gbTour.Controls.Add(this.tbExcursions);
            this.gbTour.Controls.Add(this.lblExcursions);
            this.gbTour.Controls.Add(this.tbWay);
            this.gbTour.Controls.Add(this.lblWay);
            this.gbTour.Controls.Add(this.tbCity);
            this.gbTour.Controls.Add(this.tbNameTour);
            this.gbTour.Controls.Add(this.tbDateStart);
            this.gbTour.Controls.Add(this.tbDays);
            this.gbTour.Controls.Add(this.tbCountry);
            this.gbTour.Controls.Add(this.tbAdult);
            this.gbTour.Controls.Add(this.tbCityDep);
            this.gbTour.Controls.Add(this.lblNameTour);
            this.gbTour.Controls.Add(this.lblCity);
            this.gbTour.Controls.Add(this.lblCountry);
            this.gbTour.Controls.Add(this.lblTypeTour);
            this.gbTour.Controls.Add(this.tbTypeTour);
            this.gbTour.Controls.Add(this.lblDateDep);
            this.gbTour.Controls.Add(this.lblCityDep);
            this.gbTour.Controls.Add(this.lblDays);
            this.gbTour.Controls.Add(this.lblPerson);
            this.gbTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbTour.Location = new System.Drawing.Point(14, 1);
            this.gbTour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTour.Name = "gbTour";
            this.gbTour.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTour.Size = new System.Drawing.Size(499, 492);
            this.gbTour.TabIndex = 43;
            this.gbTour.TabStop = false;
            this.gbTour.Text = "Информация о туре";
            this.gbTour.Enter += new System.EventHandler(this.gbTour_Enter);
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChildren.Location = new System.Drawing.Point(7, 238);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(151, 20);
            this.lblChildren.TabIndex = 58;
            this.lblChildren.Text = "Количество детей";
            // 
            // tbChildren
            // 
            this.tbChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbChildren.Location = new System.Drawing.Point(295, 238);
            this.tbChildren.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbChildren.Name = "tbChildren";
            this.tbChildren.Size = new System.Drawing.Size(196, 20);
            this.tbChildren.TabIndex = 57;
            this.tbChildren.Leave += new System.EventHandler(this.tbChildren_Leave);
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFood.Location = new System.Drawing.Point(7, 441);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(75, 20);
            this.lblFood.TabIndex = 56;
            this.lblFood.Text = "Питание";
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHotel.Location = new System.Drawing.Point(7, 401);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(58, 20);
            this.lblHotel.TabIndex = 55;
            this.lblHotel.Text = "Отель";
            // 
            // cbFood
            // 
            this.cbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(295, 441);
            this.cbFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(196, 21);
            this.cbFood.TabIndex = 54;
            // 
            // cbHotel
            // 
            this.cbHotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbHotel.FormattingEnabled = true;
            this.cbHotel.Location = new System.Drawing.Point(295, 400);
            this.cbHotel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbHotel.Name = "cbHotel";
            this.cbHotel.Size = new System.Drawing.Size(196, 21);
            this.cbHotel.TabIndex = 53;
            this.cbHotel.SelectedIndexChanged += new System.EventHandler(this.cbHotel_SelectedIndexChanged);
            // 
            // tbExcursions
            // 
            this.tbExcursions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbExcursions.Location = new System.Drawing.Point(295, 359);
            this.tbExcursions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbExcursions.Name = "tbExcursions";
            this.tbExcursions.ReadOnly = true;
            this.tbExcursions.Size = new System.Drawing.Size(196, 20);
            this.tbExcursions.TabIndex = 52;
            // 
            // lblExcursions
            // 
            this.lblExcursions.AutoSize = true;
            this.lblExcursions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExcursions.Location = new System.Drawing.Point(7, 359);
            this.lblExcursions.Name = "lblExcursions";
            this.lblExcursions.Size = new System.Drawing.Size(87, 20);
            this.lblExcursions.TabIndex = 51;
            this.lblExcursions.Text = "Экскурсии";
            // 
            // tbWay
            // 
            this.tbWay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWay.Location = new System.Drawing.Point(295, 319);
            this.tbWay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbWay.Name = "tbWay";
            this.tbWay.ReadOnly = true;
            this.tbWay.Size = new System.Drawing.Size(196, 20);
            this.tbWay.TabIndex = 50;
            // 
            // lblWay
            // 
            this.lblWay.AutoSize = true;
            this.lblWay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWay.Location = new System.Drawing.Point(7, 319);
            this.lblWay.Name = "lblWay";
            this.lblWay.Size = new System.Drawing.Size(46, 20);
            this.lblWay.TabIndex = 49;
            this.lblWay.Text = "Путь";
            // 
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCity.Location = new System.Drawing.Point(295, 359);
            this.tbCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCity.Name = "tbCity";
            this.tbCity.ReadOnly = true;
            this.tbCity.Size = new System.Drawing.Size(196, 20);
            this.tbCity.TabIndex = 48;
            // 
            // tbNameTour
            // 
            this.tbNameTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNameTour.Location = new System.Drawing.Point(295, 75);
            this.tbNameTour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNameTour.Name = "tbNameTour";
            this.tbNameTour.ReadOnly = true;
            this.tbNameTour.Size = new System.Drawing.Size(196, 20);
            this.tbNameTour.TabIndex = 47;
            // 
            // tbDateStart
            // 
            this.tbDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDateStart.Location = new System.Drawing.Point(295, 116);
            this.tbDateStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDateStart.Name = "tbDateStart";
            this.tbDateStart.ReadOnly = true;
            this.tbDateStart.Size = new System.Drawing.Size(196, 20);
            this.tbDateStart.TabIndex = 46;
            // 
            // tbDays
            // 
            this.tbDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDays.Location = new System.Drawing.Point(295, 156);
            this.tbDays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDays.Name = "tbDays";
            this.tbDays.ReadOnly = true;
            this.tbDays.Size = new System.Drawing.Size(196, 20);
            this.tbDays.TabIndex = 45;
            // 
            // tbCountry
            // 
            this.tbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCountry.Location = new System.Drawing.Point(295, 319);
            this.tbCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.ReadOnly = true;
            this.tbCountry.Size = new System.Drawing.Size(196, 20);
            this.tbCountry.TabIndex = 44;
            // 
            // tbAdult
            // 
            this.tbAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAdult.Location = new System.Drawing.Point(295, 197);
            this.tbAdult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAdult.Name = "tbAdult";
            this.tbAdult.Size = new System.Drawing.Size(196, 20);
            this.tbAdult.TabIndex = 43;
            this.tbAdult.Leave += new System.EventHandler(this.tbAdult_Leave);
            // 
            // tbCityDep
            // 
            this.tbCityDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCityDep.Location = new System.Drawing.Point(295, 278);
            this.tbCityDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCityDep.Name = "tbCityDep";
            this.tbCityDep.ReadOnly = true;
            this.tbCityDep.Size = new System.Drawing.Size(196, 20);
            this.tbCityDep.TabIndex = 42;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmployee.Location = new System.Drawing.Point(7, 34);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(91, 20);
            this.lblEmployee.TabIndex = 53;
            this.lblEmployee.Text = "Сотрудник";
            // 
            // cbEmployee
            // 
            this.cbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(295, 33);
            this.cbEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(196, 21);
            this.cbEmployee.TabIndex = 54;
            // 
            // cbClient
            // 
            this.cbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(295, 74);
            this.cbClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(196, 21);
            this.cbClient.TabIndex = 56;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClient.Location = new System.Drawing.Point(7, 75);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(65, 20);
            this.lblClient.TabIndex = 55;
            this.lblClient.Text = "Клиент";
            // 
            // gbSide
            // 
            this.gbSide.Controls.Add(this.btnAddClient);
            this.gbSide.Controls.Add(this.btnAddEmpl);
            this.gbSide.Controls.Add(this.cbClient);
            this.gbSide.Controls.Add(this.lblClient);
            this.gbSide.Controls.Add(this.lblEmployee);
            this.gbSide.Controls.Add(this.cbEmployee);
            this.gbSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbSide.Location = new System.Drawing.Point(14, 501);
            this.gbSide.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSide.Name = "gbSide";
            this.gbSide.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbSide.Size = new System.Drawing.Size(499, 122);
            this.gbSide.TabIndex = 44;
            this.gbSide.TabStop = false;
            this.gbSide.Text = "Стороны договора";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(316, 689);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(197, 46);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "Оформить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblItogo
            // 
            this.lblItogo.AutoSize = true;
            this.lblItogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblItogo.Location = new System.Drawing.Point(21, 644);
            this.lblItogo.Name = "lblItogo";
            this.lblItogo.Size = new System.Drawing.Size(125, 20);
            this.lblItogo.TabIndex = 57;
            this.lblItogo.Text = "Итоговая цена:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(304, 644);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 20);
            this.lblPrice.TabIndex = 58;
            // 
            // btnGetPrice
            // 
            this.btnGetPrice.BackColor = System.Drawing.Color.White;
            this.btnGetPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetPrice.Location = new System.Drawing.Point(14, 689);
            this.btnGetPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetPrice.Name = "btnGetPrice";
            this.btnGetPrice.Size = new System.Drawing.Size(197, 46);
            this.btnGetPrice.TabIndex = 59;
            this.btnGetPrice.Text = "Рассчитать цену";
            this.btnGetPrice.UseVisualStyleBackColor = false;
            this.btnGetPrice.Click += new System.EventHandler(this.btnGetPrice_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.White;
            this.btnAddClient.BackgroundImage = global::TouristAgency.Properties.Resources.btnAdd;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddClient.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddClient.Location = new System.Drawing.Point(274, 73);
            this.btnAddClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(23, 23);
            this.btnAddClient.TabIndex = 58;
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnAddEmpl
            // 
            this.btnAddEmpl.BackColor = System.Drawing.Color.White;
            this.btnAddEmpl.BackgroundImage = global::TouristAgency.Properties.Resources.btnAdd;
            this.btnAddEmpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmpl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddEmpl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddEmpl.Location = new System.Drawing.Point(274, 34);
            this.btnAddEmpl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddEmpl.Name = "btnAddEmpl";
            this.btnAddEmpl.Size = new System.Drawing.Size(23, 23);
            this.btnAddEmpl.TabIndex = 57;
            this.btnAddEmpl.UseVisualStyleBackColor = false;
            this.btnAddEmpl.Click += new System.EventHandler(this.btnAddCountry_Click);
            // 
            // btnImg
            // 
            this.btnImg.BackColor = System.Drawing.Color.White;
            this.btnImg.BackgroundImage = global::TouristAgency.Properties.Resources.btnPhoto;
            this.btnImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnImg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImg.Location = new System.Drawing.Point(274, 400);
            this.btnImg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(23, 23);
            this.btnImg.TabIndex = 59;
            this.btnImg.UseVisualStyleBackColor = false;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // formFormSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(527, 750);
            this.Controls.Add(this.btnGetPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblItogo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbSide);
            this.Controls.Add(this.gbTour);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "formFormSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление заказа";
            this.Load += new System.EventHandler(this.formFormSale_Load);
            this.gbTour.ResumeLayout(false);
            this.gbTour.PerformLayout();
            this.gbSide.ResumeLayout(false);
            this.gbSide.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbTypeTour;
        private System.Windows.Forms.Label lblTypeTour;
        private System.Windows.Forms.Label lblNameTour;
        private System.Windows.Forms.Label lblDateDep;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.Label lblCityDep;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.GroupBox gbTour;
        public System.Windows.Forms.TextBox tbCity;
        public System.Windows.Forms.TextBox tbNameTour;
        public System.Windows.Forms.TextBox tbDateStart;
        public System.Windows.Forms.TextBox tbDays;
        public System.Windows.Forms.TextBox tbCountry;
        public System.Windows.Forms.TextBox tbAdult;
        public System.Windows.Forms.TextBox tbCityDep;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Label lblEmployee;
        public System.Windows.Forms.TextBox tbExcursions;
        private System.Windows.Forms.Label lblExcursions;
        public System.Windows.Forms.TextBox tbWay;
        private System.Windows.Forms.Label lblWay;
        private System.Windows.Forms.GroupBox gbSide;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbHotel;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblItogo;
        private System.Windows.Forms.Label lblChildren;
        public System.Windows.Forms.TextBox tbChildren;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnAddEmpl;
        private System.Windows.Forms.Button btnGetPrice;
        private System.Windows.Forms.Button btnImg;
    }
}