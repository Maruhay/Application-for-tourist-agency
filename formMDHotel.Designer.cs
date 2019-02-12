namespace TouristAgency
{
    partial class formMDHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMDHotel));
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.cbStar = new System.Windows.Forms.ComboBox();
            this.chckRO = new System.Windows.Forms.CheckBox();
            this.chckFB = new System.Windows.Forms.CheckBox();
            this.chckBB = new System.Windows.Forms.CheckBox();
            this.chckAI = new System.Windows.Forms.CheckBox();
            this.chckHB = new System.Windows.Forms.CheckBox();
            this.chckUAI = new System.Windows.Forms.CheckBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblFood = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(273, 15);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(221, 22);
            this.tbName.TabIndex = 16;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(273, 177);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPhone.MaxLength = 12;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(221, 22);
            this.tbPhone.TabIndex = 17;
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(273, 55);
            this.cbCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(221, 24);
            this.cbCountry.Sorted = true;
            this.cbCountry.TabIndex = 18;
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(273, 96);
            this.cbCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(221, 24);
            this.cbCity.Sorted = true;
            this.cbCity.TabIndex = 19;
            // 
            // cbStar
            // 
            this.cbStar.FormattingEnabled = true;
            this.cbStar.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2"});
            this.cbStar.Location = new System.Drawing.Point(273, 137);
            this.cbStar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbStar.Name = "cbStar";
            this.cbStar.Size = new System.Drawing.Size(221, 24);
            this.cbStar.TabIndex = 20;
            // 
            // chckRO
            // 
            this.chckRO.AutoSize = true;
            this.chckRO.Location = new System.Drawing.Point(449, 246);
            this.chckRO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chckRO.Name = "chckRO";
            this.chckRO.Size = new System.Drawing.Size(46, 20);
            this.chckRO.TabIndex = 21;
            this.chckRO.Text = "RO";
            this.chckRO.UseVisualStyleBackColor = true;
            // 
            // chckFB
            // 
            this.chckFB.AutoSize = true;
            this.chckFB.Location = new System.Drawing.Point(449, 218);
            this.chckFB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chckFB.Name = "chckFB";
            this.chckFB.Size = new System.Drawing.Size(44, 20);
            this.chckFB.TabIndex = 22;
            this.chckFB.Text = "FB";
            this.chckFB.UseVisualStyleBackColor = true;
            // 
            // chckBB
            // 
            this.chckBB.AutoSize = true;
            this.chckBB.Location = new System.Drawing.Point(273, 246);
            this.chckBB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chckBB.Name = "chckBB";
            this.chckBB.Size = new System.Drawing.Size(45, 20);
            this.chckBB.TabIndex = 23;
            this.chckBB.Text = "BB";
            this.chckBB.UseVisualStyleBackColor = true;
            // 
            // chckAI
            // 
            this.chckAI.AutoSize = true;
            this.chckAI.Location = new System.Drawing.Point(363, 218);
            this.chckAI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chckAI.Name = "chckAI";
            this.chckAI.Size = new System.Drawing.Size(39, 20);
            this.chckAI.TabIndex = 24;
            this.chckAI.Text = "AI";
            this.chckAI.UseVisualStyleBackColor = true;
            // 
            // chckHB
            // 
            this.chckHB.AutoSize = true;
            this.chckHB.Location = new System.Drawing.Point(363, 246);
            this.chckHB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chckHB.Name = "chckHB";
            this.chckHB.Size = new System.Drawing.Size(45, 20);
            this.chckHB.TabIndex = 25;
            this.chckHB.Text = "HB";
            this.chckHB.UseVisualStyleBackColor = true;
            // 
            // chckUAI
            // 
            this.chckUAI.AutoSize = true;
            this.chckUAI.Location = new System.Drawing.Point(273, 218);
            this.chckUAI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chckUAI.Name = "chckUAI";
            this.chckUAI.Size = new System.Drawing.Size(48, 20);
            this.chckUAI.TabIndex = 26;
            this.chckUAI.Text = "UAI";
            this.chckUAI.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(14, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(133, 20);
            this.lblName.TabIndex = 27;
            this.lblName.Text = "Название отеля";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountry.Location = new System.Drawing.Point(14, 57);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(65, 20);
            this.lblCountry.TabIndex = 28;
            this.lblCountry.Text = "Страна";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCity.Location = new System.Drawing.Point(14, 97);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(56, 20);
            this.lblCity.TabIndex = 29;
            this.lblCity.Text = "Город";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Звёздность";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhone.Location = new System.Drawing.Point(14, 177);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(142, 20);
            this.lblPhone.TabIndex = 31;
            this.lblPhone.Text = "Номер телефона";
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFood.Location = new System.Drawing.Point(14, 218);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(75, 20);
            this.lblFood.TabIndex = 32;
            this.lblFood.Text = "Питание";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(273, 287);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(222, 46);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(273, 287);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(222, 46);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // formMDHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(509, 347);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.chckUAI);
            this.Controls.Add(this.chckHB);
            this.Controls.Add(this.chckAI);
            this.Controls.Add(this.chckBB);
            this.Controls.Add(this.chckFB);
            this.Controls.Add(this.chckRO);
            this.Controls.Add(this.cbStar);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbName);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "formMDHotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отель";
            this.Load += new System.EventHandler(this.formMDHotel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbName;
        public System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.ComboBox cbStar;
        private System.Windows.Forms.CheckBox chckRO;
        private System.Windows.Forms.CheckBox chckFB;
        private System.Windows.Forms.CheckBox chckBB;
        private System.Windows.Forms.CheckBox chckAI;
        private System.Windows.Forms.CheckBox chckHB;
        private System.Windows.Forms.CheckBox chckUAI;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}