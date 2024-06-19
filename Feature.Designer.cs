namespace WindowsFormsApp2
{
    partial class Feature
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.EditBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SaveBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label10 = new System.Windows.Forms.Label();
            this.AbsTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PresenceTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ExcusedTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AttDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpIdCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AttendanceDVG = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceDVG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Feature";
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
            this.DeleteBtn.Location = new System.Drawing.Point(944, 277);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(201, 46);
            this.DeleteBtn.TabIndex = 86;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
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
            this.EditBtn.Location = new System.Drawing.Point(559, 277);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(201, 46);
            this.EditBtn.TabIndex = 85;
            this.EditBtn.Text = "Update";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
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
            this.SaveBtn.Location = new System.Drawing.Point(169, 277);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(201, 46);
            this.SaveBtn.TabIndex = 84;
            this.SaveBtn.Text = "Add";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(883, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 23);
            this.label10.TabIndex = 82;
            this.label10.Text = "Absent";
            // 
            // AbsTb
            // 
            this.AbsTb.BorderRadius = 5;
            this.AbsTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AbsTb.DefaultText = "";
            this.AbsTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AbsTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AbsTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AbsTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AbsTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AbsTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AbsTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AbsTb.Location = new System.Drawing.Point(887, 99);
            this.AbsTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AbsTb.Name = "AbsTb";
            this.AbsTb.PasswordChar = '\0';
            this.AbsTb.PlaceholderText = "";
            this.AbsTb.SelectedText = "";
            this.AbsTb.Size = new System.Drawing.Size(242, 37);
            this.AbsTb.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(584, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 23);
            this.label6.TabIndex = 80;
            this.label6.Text = "Present";
            // 
            // PresenceTb
            // 
            this.PresenceTb.BorderRadius = 5;
            this.PresenceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PresenceTb.DefaultText = "";
            this.PresenceTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PresenceTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PresenceTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PresenceTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PresenceTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PresenceTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PresenceTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PresenceTb.Location = new System.Drawing.Point(588, 99);
            this.PresenceTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PresenceTb.Name = "PresenceTb";
            this.PresenceTb.PasswordChar = '\0';
            this.PresenceTb.PlaceholderText = "";
            this.PresenceTb.SelectedText = "";
            this.PresenceTb.Size = new System.Drawing.Size(242, 37);
            this.PresenceTb.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(288, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 78;
            this.label5.Text = "Excued";
            // 
            // ExcusedTb
            // 
            this.ExcusedTb.BorderRadius = 5;
            this.ExcusedTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ExcusedTb.DefaultText = "";
            this.ExcusedTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ExcusedTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ExcusedTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ExcusedTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ExcusedTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ExcusedTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExcusedTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ExcusedTb.Location = new System.Drawing.Point(292, 184);
            this.ExcusedTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExcusedTb.Name = "ExcusedTb";
            this.ExcusedTb.PasswordChar = '\0';
            this.ExcusedTb.PlaceholderText = "";
            this.ExcusedTb.SelectedText = "";
            this.ExcusedTb.Size = new System.Drawing.Size(242, 37);
            this.ExcusedTb.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(584, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 76;
            this.label4.Text = "Period";
            // 
            // AttDate
            // 
            this.AttDate.BorderRadius = 5;
            this.AttDate.Checked = true;
            this.AttDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AttDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.AttDate.Location = new System.Drawing.Point(588, 183);
            this.AttDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.AttDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.AttDate.Name = "AttDate";
            this.AttDate.Size = new System.Drawing.Size(242, 41);
            this.AttDate.TabIndex = 75;
            this.AttDate.Value = new System.DateTime(2024, 5, 24, 10, 29, 30, 999);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 74;
            this.label3.Text = "Employee Id";
            // 
            // EmpIdCb
            // 
            this.EmpIdCb.BackColor = System.Drawing.Color.Transparent;
            this.EmpIdCb.BorderRadius = 5;
            this.EmpIdCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.EmpIdCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmpIdCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpIdCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpIdCb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EmpIdCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.EmpIdCb.ItemHeight = 30;
            this.EmpIdCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.EmpIdCb.Location = new System.Drawing.Point(98, 100);
            this.EmpIdCb.Name = "EmpIdCb";
            this.EmpIdCb.Size = new System.Drawing.Size(142, 36);
            this.EmpIdCb.TabIndex = 73;
            this.EmpIdCb.SelectionChangeCommitted += new System.EventHandler(this.EmpIdCb_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 72;
            this.label2.Text = "Name";
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
            this.EmpNameTb.Enabled = false;
            this.EmpNameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpNameTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmpNameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpNameTb.Location = new System.Drawing.Point(292, 99);
            this.EmpNameTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmpNameTb.Name = "EmpNameTb";
            this.EmpNameTb.PasswordChar = '\0';
            this.EmpNameTb.PlaceholderText = "";
            this.EmpNameTb.SelectedText = "";
            this.EmpNameTb.Size = new System.Drawing.Size(242, 37);
            this.EmpNameTb.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Imprint MT Shadow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 40);
            this.label7.TabIndex = 70;
            this.label7.Text = "Attendance";
            // 
            // AttendanceDVG
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.AttendanceDVG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AttendanceDVG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.AttendanceDVG.ColumnHeadersHeight = 27;
            this.AttendanceDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AttendanceDVG.DefaultCellStyle = dataGridViewCellStyle6;
            this.AttendanceDVG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AttendanceDVG.Location = new System.Drawing.Point(49, 373);
            this.AttendanceDVG.Name = "AttendanceDVG";
            this.AttendanceDVG.RowHeadersVisible = false;
            this.AttendanceDVG.RowHeadersWidth = 51;
            this.AttendanceDVG.RowTemplate.Height = 24;
            this.AttendanceDVG.Size = new System.Drawing.Size(1175, 330);
            this.AttendanceDVG.TabIndex = 87;
            this.AttendanceDVG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AttendanceDVG.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AttendanceDVG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AttendanceDVG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AttendanceDVG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AttendanceDVG.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AttendanceDVG.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AttendanceDVG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AttendanceDVG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AttendanceDVG.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceDVG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AttendanceDVG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AttendanceDVG.ThemeStyle.HeaderStyle.Height = 27;
            this.AttendanceDVG.ThemeStyle.ReadOnly = false;
            this.AttendanceDVG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AttendanceDVG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AttendanceDVG.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendanceDVG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AttendanceDVG.ThemeStyle.RowsStyle.Height = 24;
            this.AttendanceDVG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AttendanceDVG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AttendanceDVG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttendanceDVG_CellContentClick);
            // 
            // Feature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AttendanceDVG);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AbsTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PresenceTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ExcusedTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AttDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmpIdCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmpNameTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "Feature";
            this.Size = new System.Drawing.Size(1281, 750);
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceDVG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton DeleteBtn;
        private Guna.UI2.WinForms.Guna2GradientButton EditBtn;
        private Guna.UI2.WinForms.Guna2GradientButton SaveBtn;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox AbsTb;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox PresenceTb;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox ExcusedTb;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker AttDate;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox EmpIdCb;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox EmpNameTb;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView AttendanceDVG;
    }
}
