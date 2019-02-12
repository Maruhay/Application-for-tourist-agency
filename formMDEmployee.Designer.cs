namespace TouristAgency
{
    partial class formMDEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMDEmployee));
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.tbSeriesPasp = new System.Windows.Forms.TextBox();
            this.tbNumberPasp = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.lblFIO = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblPasp = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(273, 15);
            this.tbFIO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(221, 22);
            this.tbFIO.TabIndex = 0;
            // 
            // cbPosition
            // 
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(273, 55);
            this.cbPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(221, 24);
            this.cbPosition.TabIndex = 1;
            // 
            // tbSeriesPasp
            // 
            this.tbSeriesPasp.Location = new System.Drawing.Point(273, 96);
            this.tbSeriesPasp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSeriesPasp.MaxLength = 2;
            this.tbSeriesPasp.Name = "tbSeriesPasp";
            this.tbSeriesPasp.Size = new System.Drawing.Size(48, 22);
            this.tbSeriesPasp.TabIndex = 2;
            this.tbSeriesPasp.TextChanged += new System.EventHandler(this.tbSeriesPasp_TextChanged);
            // 
            // tbNumberPasp
            // 
            this.tbNumberPasp.Location = new System.Drawing.Point(329, 96);
            this.tbNumberPasp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNumberPasp.MaxLength = 6;
            this.tbNumberPasp.Name = "tbNumberPasp";
            this.tbNumberPasp.Size = new System.Drawing.Size(165, 22);
            this.tbNumberPasp.TabIndex = 3;
            this.tbNumberPasp.Leave += new System.EventHandler(this.tbNumberPasp_Leave);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(273, 137);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPhone.MaxLength = 12;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(221, 22);
            this.tbPhone.TabIndex = 4;
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(273, 177);
            this.tbAdress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(221, 22);
            this.tbAdress.TabIndex = 5;
            // 
            // lblFIO
            // 
            this.lblFIO.AutoSize = true;
            this.lblFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFIO.Location = new System.Drawing.Point(14, 15);
            this.lblFIO.Name = "lblFIO";
            this.lblFIO.Size = new System.Drawing.Size(149, 20);
            this.lblFIO.TabIndex = 6;
            this.lblFIO.Text = "ФИО сотрудника *";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPosition.Location = new System.Drawing.Point(14, 57);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(105, 20);
            this.lblPosition.TabIndex = 7;
            this.lblPosition.Text = "Должность *";
            // 
            // lblPasp
            // 
            this.lblPasp.AutoSize = true;
            this.lblPasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPasp.Location = new System.Drawing.Point(14, 96);
            this.lblPasp.Name = "lblPasp";
            this.lblPasp.Size = new System.Drawing.Size(205, 20);
            this.lblPasp.TabIndex = 8;
            this.lblPasp.Text = "Серия и номер паспорта *";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhone.Location = new System.Drawing.Point(14, 137);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(142, 20);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Номер телефона";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAdress.Location = new System.Drawing.Point(14, 177);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(57, 20);
            this.lblAdress.TabIndex = 10;
            this.lblAdress.Text = "Адрес";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(273, 218);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(222, 46);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(273, 218);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(222, 46);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // formMDEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(509, 279);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblPasp);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblFIO);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbNumberPasp);
            this.Controls.Add(this.tbSeriesPasp);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.tbFIO);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "formMDEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудник";
            this.Load += new System.EventHandler(this.formMDEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.TextBox tbSeriesPasp;
        private System.Windows.Forms.TextBox tbNumberPasp;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label lblFIO;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblPasp;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
    }
}