namespace HELVETAS.dialogs
{
    partial class LoginUsersListDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUsersListDialog));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.close_ = new System.Windows.Forms.Button();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.all_list_btn = new System.Windows.Forms.Button();
            this.useCalendar = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.datePicker = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.dataGridViewUsers = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearchName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.heder_text = new System.Windows.Forms.Label();
            this.bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // close_
            // 
            this.close_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_.BackColor = System.Drawing.Color.Red;
            this.close_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_.ForeColor = System.Drawing.Color.White;
            this.close_.Location = new System.Drawing.Point(888, 12);
            this.close_.Name = "close_";
            this.close_.Size = new System.Drawing.Size(40, 30);
            this.close_.TabIndex = 29;
            this.close_.Text = "X";
            this.close_.UseVisualStyleBackColor = false;
            this.close_.Click += new System.EventHandler(this.close__Click);
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.bunifuShadowPanel1.BorderRadius = 0;
            this.bunifuShadowPanel1.BorderThickness = 2;
            this.bunifuShadowPanel1.Controls.Add(this.all_list_btn);
            this.bunifuShadowPanel1.Controls.Add(this.useCalendar);
            this.bunifuShadowPanel1.Controls.Add(this.datePicker);
            this.bunifuShadowPanel1.Controls.Add(this.close_);
            this.bunifuShadowPanel1.Controls.Add(this.dataGridViewUsers);
            this.bunifuShadowPanel1.Controls.Add(this.label2);
            this.bunifuShadowPanel1.Controls.Add(this.label1);
            this.bunifuShadowPanel1.Controls.Add(this.textBoxSearchName);
            this.bunifuShadowPanel1.Controls.Add(this.heder_text);
            this.bunifuShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.Red;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 0;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.ForwardDiagonal;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(940, 555);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel1.TabIndex = 19;
            // 
            // all_list_btn
            // 
            this.all_list_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.all_list_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.all_list_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_list_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.all_list_btn.Location = new System.Drawing.Point(593, 59);
            this.all_list_btn.Name = "all_list_btn";
            this.all_list_btn.Size = new System.Drawing.Size(147, 32);
            this.all_list_btn.TabIndex = 33;
            this.all_list_btn.Text = "Хамаи руйхат";
            this.all_list_btn.UseVisualStyleBackColor = true;
            this.all_list_btn.Click += new System.EventHandler(this.all_list_btn_Click_1);
            // 
            // useCalendar
            // 
            this.useCalendar.AllowBindingControlAnimation = true;
            this.useCalendar.AllowBindingControlColorChanges = false;
            this.useCalendar.AllowBindingControlLocation = true;
            this.useCalendar.AllowCheckBoxAnimation = false;
            this.useCalendar.AllowCheckmarkAnimation = true;
            this.useCalendar.AllowOnHoverStates = true;
            this.useCalendar.AutoCheck = true;
            this.useCalendar.BackColor = System.Drawing.Color.Transparent;
            this.useCalendar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("useCalendar.BackgroundImage")));
            this.useCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.useCalendar.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.useCalendar.BorderRadius = 12;
            this.useCalendar.Checked = false;
            this.useCalendar.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.useCalendar.Cursor = System.Windows.Forms.Cursors.Default;
            this.useCalendar.CustomCheckmarkImage = null;
            this.useCalendar.Location = new System.Drawing.Point(543, 66);
            this.useCalendar.MinimumSize = new System.Drawing.Size(17, 17);
            this.useCalendar.Name = "useCalendar";
            this.useCalendar.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.useCalendar.OnCheck.BorderRadius = 12;
            this.useCalendar.OnCheck.BorderThickness = 2;
            this.useCalendar.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.useCalendar.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.useCalendar.OnCheck.CheckmarkThickness = 2;
            this.useCalendar.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.useCalendar.OnDisable.BorderRadius = 12;
            this.useCalendar.OnDisable.BorderThickness = 2;
            this.useCalendar.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.useCalendar.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.useCalendar.OnDisable.CheckmarkThickness = 2;
            this.useCalendar.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.useCalendar.OnHoverChecked.BorderRadius = 12;
            this.useCalendar.OnHoverChecked.BorderThickness = 2;
            this.useCalendar.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.useCalendar.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.useCalendar.OnHoverChecked.CheckmarkThickness = 2;
            this.useCalendar.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.useCalendar.OnHoverUnchecked.BorderRadius = 12;
            this.useCalendar.OnHoverUnchecked.BorderThickness = 1;
            this.useCalendar.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.useCalendar.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.useCalendar.OnUncheck.BorderRadius = 12;
            this.useCalendar.OnUncheck.BorderThickness = 1;
            this.useCalendar.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.useCalendar.Size = new System.Drawing.Size(21, 21);
            this.useCalendar.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.useCalendar.TabIndex = 32;
            this.useCalendar.Tag = "";
            this.useCalendar.ThreeState = false;
            this.useCalendar.ToolTipText = "Истифодаи календар";
            this.useCalendar.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.useCalendar_CheckedChanged);
            // 
            // datePicker
            // 
            this.datePicker.BackColor = System.Drawing.Color.Transparent;
            this.datePicker.BorderColor = System.Drawing.Color.Silver;
            this.datePicker.BorderRadius = 1;
            this.datePicker.Color = System.Drawing.Color.Silver;
            this.datePicker.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.datePicker.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.datePicker.DisabledColor = System.Drawing.Color.Gray;
            this.datePicker.DisplayWeekNumbers = false;
            this.datePicker.DPHeight = 0;
            this.datePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.datePicker.FillDatePicker = false;
            this.datePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datePicker.ForeColor = System.Drawing.Color.Black;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Icon = ((System.Drawing.Image)(resources.GetObject("datePicker.Icon")));
            this.datePicker.IconColor = System.Drawing.Color.Gray;
            this.datePicker.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.datePicker.LeftTextMargin = 5;
            this.datePicker.Location = new System.Drawing.Point(436, 58);
            this.datePicker.MinimumSize = new System.Drawing.Size(4, 32);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(101, 32);
            this.datePicker.TabIndex = 30;
            this.datePicker.Value = new System.DateTime(2022, 7, 8, 11, 16, 38, 0);
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowCustomTheming = false;
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AllowUserToResizeColumns = false;
            this.dataGridViewUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUsers.ColumnHeadersHeight = 40;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.date,
            this.time});
            this.dataGridViewUsers.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridViewUsers.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewUsers.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewUsers.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewUsers.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewUsers.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridViewUsers.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewUsers.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewUsers.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewUsers.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewUsers.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataGridViewUsers.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewUsers.CurrentTheme.Name = null;
            this.dataGridViewUsers.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewUsers.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewUsers.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewUsers.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewUsers.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewUsers.EnableHeadersVisualStyles = false;
            this.dataGridViewUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewUsers.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewUsers.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridViewUsers.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewUsers.Location = new System.Drawing.Point(12, 101);
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.RowHeadersWidth = 40;
            this.dataGridViewUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewUsers.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.dataGridViewUsers.RowTemplate.Height = 40;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(916, 442);
            this.dataGridViewUsers.TabIndex = 28;
            this.dataGridViewUsers.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "id";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.FillWeight = 50F;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "name_user";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.FillWeight = 58.73079F;
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Ном";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "surname_user";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column3.FillWeight = 58.73079F;
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Насаб";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.DataPropertyName = "type_user";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column4.HeaderText = "Намуд";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "action";
            this.Column5.HeaderText = "Амал";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.date.DataPropertyName = "date";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.DefaultCellStyle = dataGridViewCellStyle7;
            this.date.HeaderText = "Таърихи руз";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 120;
            // 
            // time
            // 
            this.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.time.DataPropertyName = "time";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.DefaultCellStyle = dataGridViewCellStyle8;
            this.time.HeaderText = "Соат";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Чустучу";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Тахрихи руз:";
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.AcceptsReturn = false;
            this.textBoxSearchName.AcceptsTab = false;
            this.textBoxSearchName.AnimationSpeed = 200;
            this.textBoxSearchName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxSearchName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxSearchName.AutoSizeHeight = true;
            this.textBoxSearchName.BackColor = System.Drawing.Color.Transparent;
            this.textBoxSearchName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxSearchName.BackgroundImage")));
            this.textBoxSearchName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.textBoxSearchName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textBoxSearchName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.textBoxSearchName.BorderColorIdle = System.Drawing.Color.Silver;
            this.textBoxSearchName.BorderRadius = 1;
            this.textBoxSearchName.BorderThickness = 1;
            this.textBoxSearchName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxSearchName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSearchName.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.textBoxSearchName.DefaultText = "";
            this.textBoxSearchName.FillColor = System.Drawing.Color.White;
            this.textBoxSearchName.HideSelection = true;
            this.textBoxSearchName.IconLeft = null;
            this.textBoxSearchName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSearchName.IconPadding = 10;
            this.textBoxSearchName.IconRight = null;
            this.textBoxSearchName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSearchName.Lines = new string[0];
            this.textBoxSearchName.Location = new System.Drawing.Point(12, 59);
            this.textBoxSearchName.MaxLength = 32767;
            this.textBoxSearchName.MinimumSize = new System.Drawing.Size(1, 1);
            this.textBoxSearchName.Modified = false;
            this.textBoxSearchName.Multiline = false;
            this.textBoxSearchName.Name = "textBoxSearchName";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxSearchName.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.textBoxSearchName.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxSearchName.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxSearchName.OnIdleState = stateProperties4;
            this.textBoxSearchName.Padding = new System.Windows.Forms.Padding(3);
            this.textBoxSearchName.PasswordChar = '\0';
            this.textBoxSearchName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.textBoxSearchName.PlaceholderText = "Ном";
            this.textBoxSearchName.ReadOnly = false;
            this.textBoxSearchName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxSearchName.SelectedText = "";
            this.textBoxSearchName.SelectionLength = 0;
            this.textBoxSearchName.SelectionStart = 0;
            this.textBoxSearchName.ShortcutsEnabled = true;
            this.textBoxSearchName.Size = new System.Drawing.Size(342, 33);
            this.textBoxSearchName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.textBoxSearchName.TabIndex = 14;
            this.textBoxSearchName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxSearchName.TextMarginBottom = 0;
            this.textBoxSearchName.TextMarginLeft = 3;
            this.textBoxSearchName.TextMarginTop = 1;
            this.textBoxSearchName.TextPlaceholder = "Ном";
            this.textBoxSearchName.UseSystemPasswordChar = false;
            this.textBoxSearchName.WordWrap = true;
            this.textBoxSearchName.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // heder_text
            // 
            this.heder_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.heder_text.AutoSize = true;
            this.heder_text.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heder_text.Location = new System.Drawing.Point(386, 9);
            this.heder_text.Name = "heder_text";
            this.heder_text.Size = new System.Drawing.Size(151, 20);
            this.heder_text.TabIndex = 13;
            this.heder_text.Text = "Руйхати воридшави";
            // 
            // LoginUsersListDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(940, 555);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginUsersListDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoginUsersListDialogcs";
            this.Load += new System.EventHandler(this.LoginUsersListDialog_Load);
            this.Shown += new System.EventHandler(this.LoginUsersListDialog_Shown);
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button close_;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.UI.WinForms.BunifuCheckBox useCalendar;
        private Bunifu.UI.WinForms.BunifuDatePicker datePicker;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextBox textBoxSearchName;
        private System.Windows.Forms.Label heder_text;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.Button all_list_btn;
    }
}