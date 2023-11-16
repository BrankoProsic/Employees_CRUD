namespace Employees_CRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEmployees = new System.Windows.Forms.Label();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblEmpCity = new System.Windows.Forms.Label();
            this.lblEmpAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblJoinDate = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.radioBtnMale = new System.Windows.Forms.RadioButton();
            this.radioBtnFemale = new System.Windows.Forms.RadioButton();
            this.dateTimePickerJoin = new System.Windows.Forms.DateTimePicker();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmployees.Location = new System.Drawing.Point(387, 9);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(162, 41);
            this.lblEmployees.TabIndex = 0;
            this.lblEmployees.Text = "Employees";
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmpID.Location = new System.Drawing.Point(24, 82);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(122, 28);
            this.lblEmpID.TabIndex = 1;
            this.lblEmpID.Text = "Employee ID";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmpName.Location = new System.Drawing.Point(24, 120);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(155, 28);
            this.lblEmpName.TabIndex = 2;
            this.lblEmpName.Text = "Employee Name";
            // 
            // lblEmpCity
            // 
            this.lblEmpCity.AutoSize = true;
            this.lblEmpCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmpCity.Location = new System.Drawing.Point(24, 162);
            this.lblEmpCity.Name = "lblEmpCity";
            this.lblEmpCity.Size = new System.Drawing.Size(137, 28);
            this.lblEmpCity.TabIndex = 3;
            this.lblEmpCity.Text = "Employee City";
            // 
            // lblEmpAge
            // 
            this.lblEmpAge.AutoSize = true;
            this.lblEmpAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmpAge.Location = new System.Drawing.Point(24, 203);
            this.lblEmpAge.Name = "lblEmpAge";
            this.lblEmpAge.Size = new System.Drawing.Size(138, 28);
            this.lblEmpAge.TabIndex = 4;
            this.lblEmpAge.Text = "Employee Age";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGender.Location = new System.Drawing.Point(473, 85);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(76, 28);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Gender";
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.AutoSize = true;
            this.lblJoinDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJoinDate.Location = new System.Drawing.Point(473, 126);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(93, 28);
            this.lblJoinDate.TabIndex = 6;
            this.lblJoinDate.Text = "Join Date";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContact.Location = new System.Drawing.Point(473, 166);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(80, 28);
            this.lblContact.TabIndex = 7;
            this.lblContact.Text = "Contact";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxID.Location = new System.Drawing.Point(204, 83);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(256, 30);
            this.textBoxID.TabIndex = 8;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(204, 124);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(256, 30);
            this.textBoxName.TabIndex = 9;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAge.Location = new System.Drawing.Point(204, 207);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(256, 30);
            this.textBoxAge.TabIndex = 10;
            // 
            // textBoxContact
            // 
            this.textBoxContact.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxContact.Location = new System.Drawing.Point(653, 166);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(256, 30);
            this.textBoxContact.TabIndex = 11;
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Items.AddRange(new object[] {
            "Belgrade, SERBIA",
            "Austin, TEXAS",
            "Dublin, IRELAND",
            "Banska Bystrica, SLOVAKIA"});
            this.comboBoxCity.Location = new System.Drawing.Point(204, 166);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(256, 31);
            this.comboBoxCity.TabIndex = 12;
            // 
            // radioBtnMale
            // 
            this.radioBtnMale.AutoSize = true;
            this.radioBtnMale.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnMale.Location = new System.Drawing.Point(653, 90);
            this.radioBtnMale.Name = "radioBtnMale";
            this.radioBtnMale.Size = new System.Drawing.Size(68, 27);
            this.radioBtnMale.TabIndex = 13;
            this.radioBtnMale.TabStop = true;
            this.radioBtnMale.Text = "Male";
            this.radioBtnMale.UseVisualStyleBackColor = true;
            // 
            // radioBtnFemale
            // 
            this.radioBtnFemale.AutoSize = true;
            this.radioBtnFemale.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBtnFemale.Location = new System.Drawing.Point(792, 90);
            this.radioBtnFemale.Name = "radioBtnFemale";
            this.radioBtnFemale.Size = new System.Drawing.Size(85, 27);
            this.radioBtnFemale.TabIndex = 14;
            this.radioBtnFemale.TabStop = true;
            this.radioBtnFemale.Text = "Female";
            this.radioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerJoin
            // 
            this.dateTimePickerJoin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerJoin.Location = new System.Drawing.Point(653, 127);
            this.dateTimePickerJoin.Name = "dateTimePickerJoin";
            this.dateTimePickerJoin.Size = new System.Drawing.Size(256, 27);
            this.dateTimePickerJoin.TabIndex = 15;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInsert.Location = new System.Drawing.Point(473, 207);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(99, 34);
            this.btnInsert.TabIndex = 16;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(24, 313);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(912, 260);
            this.dataGridView.TabIndex = 17;
            this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(578, 207);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 34);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearch.Location = new System.Drawing.Point(24, 271);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(70, 28);
            this.lblSearch.TabIndex = 19;
            this.lblSearch.Text = "Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearch.Location = new System.Drawing.Point(124, 273);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(336, 30);
            this.textBoxSearch.TabIndex = 20;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(786, 265);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 34);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete Contact";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(948, 585);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dateTimePickerJoin);
            this.Controls.Add(this.radioBtnFemale);
            this.Controls.Add(this.radioBtnMale);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblJoinDate);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblEmpAge);
            this.Controls.Add(this.lblEmpCity);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.lblEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "EMPOYEES";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEmployees;
        private Label lblEmpID;
        private Label lblEmpName;
        private Label lblEmpCity;
        private Label lblEmpAge;
        private Label lblGender;
        private Label lblJoinDate;
        private Label lblContact;
        private TextBox textBoxID;
        private TextBox textBoxName;
        private TextBox textBoxAge;
        private TextBox textBoxContact;
        private ComboBox comboBoxCity;
        private RadioButton radioBtnMale;
        private RadioButton radioBtnFemale;
        private DateTimePicker dateTimePickerJoin;
        private Button btnInsert;
        private DataGridView dataGridView;
        private Button btnUpdate;
        private Label lblSearch;
        private TextBox textBoxSearch;
        private Button btnDelete;
    }
}