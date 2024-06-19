namespace WindowsFormsApp2
{
    partial class UC_Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpGenCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpDOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EmpPhoneTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EmpAddTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EmpPosCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.JDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.EmpQualCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.EmpSalTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmployeeDVG = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SaveBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.EditBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDVG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard";
            // 
            // EmpNameTb
            // 
            this.EmpNameTb.BorderRadius = 5;
            this.EmpNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpNameTb.DefaultText = "";
            this.EmpNameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmpNameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmpNameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpNameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpNameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpNameTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmpNameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpNameTb.Location = new System.Drawing.Point(79, 108);
            this.EmpNameTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmpNameTb.Name = "EmpNameTb";
            this.EmpNameTb.PasswordChar = '\0';
            this.EmpNameTb.PlaceholderText = "";
            this.EmpNameTb.SelectedText = "";
            this.EmpNameTb.Size = new System.Drawing.Size(242, 37);
            this.EmpNameTb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // EmpGenCb
            // 
            this.EmpGenCb.BackColor = System.Drawing.Color.Transparent;
            this.EmpGenCb.BorderRadius = 5;
            this.EmpGenCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.EmpGenCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmpGenCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpGenCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpGenCb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EmpGenCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.EmpGenCb.ItemHeight = 30;
            this.EmpGenCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.EmpGenCb.Location = new System.Drawing.Point(79, 195);
            this.EmpGenCb.Name = "EmpGenCb";
            this.EmpGenCb.Size = new System.Drawing.Size(242, 36);
            this.EmpGenCb.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Gender";
            // 
            // EmpDOB
            // 
            this.EmpDOB.BorderRadius = 5;
            this.EmpDOB.Checked = true;
            this.EmpDOB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.EmpDOB.Location = new System.Drawing.Point(79, 276);
            this.EmpDOB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.EmpDOB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.EmpDOB.Name = "EmpDOB";
            this.EmpDOB.Size = new System.Drawing.Size(242, 41);
            this.EmpDOB.TabIndex = 11;
            this.EmpDOB.Value = new System.DateTime(2024, 5, 24, 10, 29, 30, 999);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "DOB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(371, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phone";
            // 
            // EmpPhoneTb
            // 
            this.EmpPhoneTb.BorderRadius = 5;
            this.EmpPhoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpPhoneTb.DefaultText = "";
            this.EmpPhoneTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmpPhoneTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmpPhoneTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpPhoneTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpPhoneTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpPhoneTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmpPhoneTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpPhoneTb.Location = new System.Drawing.Point(375, 273);
            this.EmpPhoneTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmpPhoneTb.Name = "EmpPhoneTb";
            this.EmpPhoneTb.PasswordChar = '\0';
            this.EmpPhoneTb.PlaceholderText = "";
            this.EmpPhoneTb.SelectedText = "";
            this.EmpPhoneTb.Size = new System.Drawing.Size(242, 37);
            this.EmpPhoneTb.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(371, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Address";
            // 
            // EmpAddTb
            // 
            this.EmpAddTb.BorderRadius = 5;
            this.EmpAddTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpAddTb.DefaultText = "";
            this.EmpAddTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmpAddTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmpAddTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpAddTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpAddTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpAddTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmpAddTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpAddTb.Location = new System.Drawing.Point(375, 108);
            this.EmpAddTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmpAddTb.Name = "EmpAddTb";
            this.EmpAddTb.PasswordChar = '\0';
            this.EmpAddTb.PlaceholderText = "";
            this.EmpAddTb.SelectedText = "";
            this.EmpAddTb.Size = new System.Drawing.Size(242, 37);
            this.EmpAddTb.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(371, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Position";
            // 
            // EmpPosCb
            // 
            this.EmpPosCb.BackColor = System.Drawing.Color.Transparent;
            this.EmpPosCb.BorderRadius = 5;
            this.EmpPosCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.EmpPosCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmpPosCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpPosCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpPosCb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EmpPosCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.EmpPosCb.ItemHeight = 30;
            this.EmpPosCb.Items.AddRange(new object[] {
            "Manager",
            "Senior",
            "Junior"});
            this.EmpPosCb.Location = new System.Drawing.Point(375, 195);
            this.EmpPosCb.Name = "EmpPosCb";
            this.EmpPosCb.Size = new System.Drawing.Size(242, 36);
            this.EmpPosCb.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(658, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Join Date";
            // 
            // JDate
            // 
            this.JDate.BorderRadius = 5;
            this.JDate.Checked = true;
            this.JDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.JDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.JDate.Location = new System.Drawing.Point(662, 104);
            this.JDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.JDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.JDate.Name = "JDate";
            this.JDate.Size = new System.Drawing.Size(242, 41);
            this.JDate.TabIndex = 19;
            this.JDate.Value = new System.DateTime(2024, 5, 24, 10, 29, 30, 999);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(658, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "Qualification";
            // 
            // EmpQualCb
            // 
            this.EmpQualCb.BackColor = System.Drawing.Color.Transparent;
            this.EmpQualCb.BorderRadius = 5;
            this.EmpQualCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.EmpQualCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmpQualCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpQualCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpQualCb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EmpQualCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.EmpQualCb.ItemHeight = 30;
            this.EmpQualCb.Items.AddRange(new object[] {
            "BCA",
            "MCA",
            "MBA",
            "BCOM",
            "BTech",
            "BBA",
            "Other..."});
            this.EmpQualCb.Location = new System.Drawing.Point(662, 195);
            this.EmpQualCb.Name = "EmpQualCb";
            this.EmpQualCb.Size = new System.Drawing.Size(242, 36);
            this.EmpQualCb.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(945, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "Base Salary";
            // 
            // EmpSalTb
            // 
            this.EmpSalTb.BorderRadius = 5;
            this.EmpSalTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpSalTb.DefaultText = "";
            this.EmpSalTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmpSalTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmpSalTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpSalTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpSalTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpSalTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmpSalTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpSalTb.Location = new System.Drawing.Point(949, 108);
            this.EmpSalTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmpSalTb.Name = "EmpSalTb";
            this.EmpSalTb.PasswordChar = '\0';
            this.EmpSalTb.PlaceholderText = "";
            this.EmpSalTb.SelectedText = "";
            this.EmpSalTb.Size = new System.Drawing.Size(242, 37);
            this.EmpSalTb.TabIndex = 23;
            // 
            // EmployeeDVG
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.EmployeeDVG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeDVG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeDVG.ColumnHeadersHeight = 27;
            this.EmployeeDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeDVG.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeeDVG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeDVG.Location = new System.Drawing.Point(57, 386);
            this.EmployeeDVG.Name = "EmployeeDVG";
            this.EmployeeDVG.RowHeadersVisible = false;
            this.EmployeeDVG.RowHeadersWidth = 51;
            this.EmployeeDVG.RowTemplate.Height = 24;
            this.EmployeeDVG.Size = new System.Drawing.Size(1175, 330);
            this.EmployeeDVG.TabIndex = 25;
            this.EmployeeDVG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDVG.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmployeeDVG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmployeeDVG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmployeeDVG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmployeeDVG.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDVG.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeDVG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EmployeeDVG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmployeeDVG.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeDVG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmployeeDVG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmployeeDVG.ThemeStyle.HeaderStyle.Height = 27;
            this.EmployeeDVG.ThemeStyle.ReadOnly = false;
            this.EmployeeDVG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDVG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeeDVG.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeDVG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmployeeDVG.ThemeStyle.RowsStyle.Height = 24;
            this.EmployeeDVG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeDVG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmployeeDVG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeDVG_CellContentClick);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BorderRadius = 10;
            this.SaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveBtn.FillColor = System.Drawing.Color.Aqua;
            this.SaveBtn.FillColor2 = System.Drawing.Color.Red;
            this.SaveBtn.Font = new System.Drawing.Font("Engravers MT", 10.8F, System.Drawing.FontStyle.Bold);
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(1031, 167);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(201, 46);
            this.SaveBtn.TabIndex = 26;
            this.SaveBtn.Text = "Add";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BorderRadius = 10;
            this.EditBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditBtn.FillColor = System.Drawing.Color.Aqua;
            this.EditBtn.FillColor2 = System.Drawing.Color.Red;
            this.EditBtn.Font = new System.Drawing.Font("Engravers MT", 10.8F, System.Drawing.FontStyle.Bold);
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(1031, 219);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(201, 46);
            this.EditBtn.TabIndex = 27;
            this.EditBtn.Text = "Update";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BorderRadius = 10;
            this.DeleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteBtn.FillColor = System.Drawing.Color.Aqua;
            this.DeleteBtn.FillColor2 = System.Drawing.Color.Red;
            this.DeleteBtn.Font = new System.Drawing.Font("Engravers MT", 10.8F, System.Drawing.FontStyle.Bold);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(1031, 273);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(201, 46);
            this.DeleteBtn.TabIndex = 28;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.BorderRadius = 10;
            this.guna2GradientButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton4.FillColor = System.Drawing.Color.Aqua;
            this.guna2GradientButton4.FillColor2 = System.Drawing.Color.Red;
            this.guna2GradientButton4.Font = new System.Drawing.Font("Engravers MT", 10.8F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.Location = new System.Drawing.Point(1031, 325);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.Size = new System.Drawing.Size(201, 46);
            this.guna2GradientButton4.TabIndex = 29;
            this.guna2GradientButton4.Text = "Clear";
            this.guna2GradientButton4.Click += new System.EventHandler(this.guna2GradientButton4_Click);
            // 
            // UC_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GradientButton4);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.EmployeeDVG);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.EmpSalTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EmpQualCb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.JDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EmpPosCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EmpAddTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmpPhoneTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmpDOB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmpGenCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmpNameTb);
            this.Controls.Add(this.label1);
            this.Name = "UC_Dashboard";
            this.Size = new System.Drawing.Size(1281, 750);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDVG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox EmpNameTb;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox EmpGenCb;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker EmpDOB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox EmpPhoneTb;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox EmpAddTb;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox EmpPosCb;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DateTimePicker JDate;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox EmpQualCb;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox EmpSalTb;
        private Guna.UI2.WinForms.Guna2DataGridView EmployeeDVG;
        private Guna.UI2.WinForms.Guna2GradientButton SaveBtn;
        private Guna.UI2.WinForms.Guna2GradientButton EditBtn;
        private Guna.UI2.WinForms.Guna2GradientButton DeleteBtn;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
    }
}
