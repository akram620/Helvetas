namespace HELVETAS.ChildScreens
{
    partial class UserListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserListForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.dataGridViewUsers = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.create_user_btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit_btn = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete_btn = new System.Windows.Forms.DataGridViewImageColumn();
            this.change_admin_btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
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
            this.edit_btn,
            this.delete_btn});
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewUsers.EnableHeadersVisualStyles = false;
            this.dataGridViewUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewUsers.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewUsers.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridViewUsers.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewUsers.Location = new System.Drawing.Point(12, 58);
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.RowHeadersWidth = 40;
            this.dataGridViewUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewUsers.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.dataGridViewUsers.RowTemplate.Height = 40;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(816, 485);
            this.dataGridViewUsers.TabIndex = 21;
            this.dataGridViewUsers.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellContentClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 66.84867F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::HELVETAS.Properties.Resources.delete_icon;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 40;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 197;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 32.50118F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::HELVETAS.Properties.Resources.delete_icon;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.MinimumWidth = 40;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.Width = 81;
            // 
            // create_user_btn
            // 
            this.create_user_btn.AllowAnimations = true;
            this.create_user_btn.AllowMouseEffects = true;
            this.create_user_btn.AllowToggling = false;
            this.create_user_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.create_user_btn.AnimationSpeed = 200;
            this.create_user_btn.AutoGenerateColors = false;
            this.create_user_btn.AutoRoundBorders = false;
            this.create_user_btn.AutoSizeLeftIcon = true;
            this.create_user_btn.AutoSizeRightIcon = true;
            this.create_user_btn.BackColor = System.Drawing.Color.Transparent;
            this.create_user_btn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(173)))), ((int)(((byte)(87)))));
            this.create_user_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("create_user_btn.BackgroundImage")));
            this.create_user_btn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.create_user_btn.ButtonText = "Илова кардани коргар";
            this.create_user_btn.ButtonTextMarginLeft = 0;
            this.create_user_btn.ColorContrastOnClick = 45;
            this.create_user_btn.ColorContrastOnHover = 45;
            this.create_user_btn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.create_user_btn.CustomizableEdges = borderEdges1;
            this.create_user_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.create_user_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.create_user_btn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.create_user_btn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.create_user_btn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.create_user_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_user_btn.ForeColor = System.Drawing.Color.White;
            this.create_user_btn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.create_user_btn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.create_user_btn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.create_user_btn.IconMarginLeft = 11;
            this.create_user_btn.IconPadding = 10;
            this.create_user_btn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.create_user_btn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.create_user_btn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.create_user_btn.IconSize = 25;
            this.create_user_btn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(173)))), ((int)(((byte)(87)))));
            this.create_user_btn.IdleBorderRadius = 15;
            this.create_user_btn.IdleBorderThickness = 1;
            this.create_user_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(173)))), ((int)(((byte)(87)))));
            this.create_user_btn.IdleIconLeftImage = null;
            this.create_user_btn.IdleIconRightImage = null;
            this.create_user_btn.IndicateFocus = false;
            this.create_user_btn.Location = new System.Drawing.Point(638, 10);
            this.create_user_btn.Name = "create_user_btn";
            this.create_user_btn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.create_user_btn.OnDisabledState.BorderRadius = 15;
            this.create_user_btn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.create_user_btn.OnDisabledState.BorderThickness = 1;
            this.create_user_btn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.create_user_btn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.create_user_btn.OnDisabledState.IconLeftImage = null;
            this.create_user_btn.OnDisabledState.IconRightImage = null;
            this.create_user_btn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(186)))), ((int)(((byte)(93)))));
            this.create_user_btn.onHoverState.BorderRadius = 15;
            this.create_user_btn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.create_user_btn.onHoverState.BorderThickness = 1;
            this.create_user_btn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(186)))), ((int)(((byte)(93)))));
            this.create_user_btn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.create_user_btn.onHoverState.IconLeftImage = null;
            this.create_user_btn.onHoverState.IconRightImage = null;
            this.create_user_btn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(173)))), ((int)(((byte)(87)))));
            this.create_user_btn.OnIdleState.BorderRadius = 15;
            this.create_user_btn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.create_user_btn.OnIdleState.BorderThickness = 1;
            this.create_user_btn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(173)))), ((int)(((byte)(87)))));
            this.create_user_btn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.create_user_btn.OnIdleState.IconLeftImage = null;
            this.create_user_btn.OnIdleState.IconRightImage = null;
            this.create_user_btn.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.create_user_btn.OnPressedState.BorderRadius = 15;
            this.create_user_btn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.create_user_btn.OnPressedState.BorderThickness = 1;
            this.create_user_btn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(173)))), ((int)(((byte)(87)))));
            this.create_user_btn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.create_user_btn.OnPressedState.IconLeftImage = null;
            this.create_user_btn.OnPressedState.IconRightImage = null;
            this.create_user_btn.Size = new System.Drawing.Size(190, 42);
            this.create_user_btn.TabIndex = 20;
            this.create_user_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.create_user_btn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.create_user_btn.TextMarginLeft = 0;
            this.create_user_btn.TextPadding = new System.Windows.Forms.Padding(0);
            this.create_user_btn.UseDefaultRadiusAndThickness = true;
            this.create_user_btn.Click += new System.EventHandler(this.create_user_btn_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.FillWeight = 10.94666F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "name_user";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.FillWeight = 72.97773F;
            this.Column2.HeaderText = "Ном";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "surname_user";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Column3.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column3.FillWeight = 72.97773F;
            this.Column3.HeaderText = "Насаб";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "type_user";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Column4.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column4.FillWeight = 72.97773F;
            this.Column4.HeaderText = "Намуд";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // edit_btn
            // 
            this.edit_btn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.edit_btn.FillWeight = 60F;
            this.edit_btn.HeaderText = "";
            this.edit_btn.Image = global::HELVETAS.Properties.Resources.edit_icon;
            this.edit_btn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.edit_btn.MinimumWidth = 60;
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.ReadOnly = true;
            this.edit_btn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.edit_btn.ToolTipText = "Иваз кардан";
            this.edit_btn.Width = 60;
            // 
            // delete_btn
            // 
            this.delete_btn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.delete_btn.FillWeight = 60F;
            this.delete_btn.HeaderText = "";
            this.delete_btn.Image = global::HELVETAS.Properties.Resources.delete_icon;
            this.delete_btn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete_btn.MinimumWidth = 60;
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.ReadOnly = true;
            this.delete_btn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.delete_btn.ToolTipText = "Нест кардан";
            this.delete_btn.Width = 60;
            // 
            // change_admin_btn
            // 
            this.change_admin_btn.AllowAnimations = true;
            this.change_admin_btn.AllowMouseEffects = true;
            this.change_admin_btn.AllowToggling = false;
            this.change_admin_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.change_admin_btn.AnimationSpeed = 200;
            this.change_admin_btn.AutoGenerateColors = false;
            this.change_admin_btn.AutoRoundBorders = false;
            this.change_admin_btn.AutoSizeLeftIcon = true;
            this.change_admin_btn.AutoSizeRightIcon = true;
            this.change_admin_btn.BackColor = System.Drawing.Color.Transparent;
            this.change_admin_btn.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.change_admin_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("change_admin_btn.BackgroundImage")));
            this.change_admin_btn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.change_admin_btn.ButtonText = "Иваз кардани админ";
            this.change_admin_btn.ButtonTextMarginLeft = 0;
            this.change_admin_btn.ColorContrastOnClick = 45;
            this.change_admin_btn.ColorContrastOnHover = 45;
            this.change_admin_btn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.change_admin_btn.CustomizableEdges = borderEdges2;
            this.change_admin_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.change_admin_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.change_admin_btn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.change_admin_btn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.change_admin_btn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.change_admin_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.change_admin_btn.ForeColor = System.Drawing.Color.White;
            this.change_admin_btn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.change_admin_btn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.change_admin_btn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.change_admin_btn.IconMarginLeft = 11;
            this.change_admin_btn.IconPadding = 10;
            this.change_admin_btn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.change_admin_btn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.change_admin_btn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.change_admin_btn.IconSize = 25;
            this.change_admin_btn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.change_admin_btn.IdleBorderRadius = 15;
            this.change_admin_btn.IdleBorderThickness = 1;
            this.change_admin_btn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.change_admin_btn.IdleIconLeftImage = null;
            this.change_admin_btn.IdleIconRightImage = null;
            this.change_admin_btn.IndicateFocus = false;
            this.change_admin_btn.Location = new System.Drawing.Point(442, 10);
            this.change_admin_btn.Name = "change_admin_btn";
            this.change_admin_btn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.change_admin_btn.OnDisabledState.BorderRadius = 15;
            this.change_admin_btn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.change_admin_btn.OnDisabledState.BorderThickness = 1;
            this.change_admin_btn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.change_admin_btn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.change_admin_btn.OnDisabledState.IconLeftImage = null;
            this.change_admin_btn.OnDisabledState.IconRightImage = null;
            this.change_admin_btn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.change_admin_btn.onHoverState.BorderRadius = 15;
            this.change_admin_btn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.change_admin_btn.onHoverState.BorderThickness = 1;
            this.change_admin_btn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.change_admin_btn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.change_admin_btn.onHoverState.IconLeftImage = null;
            this.change_admin_btn.onHoverState.IconRightImage = null;
            this.change_admin_btn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.change_admin_btn.OnIdleState.BorderRadius = 15;
            this.change_admin_btn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.change_admin_btn.OnIdleState.BorderThickness = 1;
            this.change_admin_btn.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.change_admin_btn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.change_admin_btn.OnIdleState.IconLeftImage = null;
            this.change_admin_btn.OnIdleState.IconRightImage = null;
            this.change_admin_btn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.change_admin_btn.OnPressedState.BorderRadius = 15;
            this.change_admin_btn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.change_admin_btn.OnPressedState.BorderThickness = 1;
            this.change_admin_btn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.change_admin_btn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.change_admin_btn.OnPressedState.IconLeftImage = null;
            this.change_admin_btn.OnPressedState.IconRightImage = null;
            this.change_admin_btn.Size = new System.Drawing.Size(190, 42);
            this.change_admin_btn.TabIndex = 22;
            this.change_admin_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.change_admin_btn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.change_admin_btn.TextMarginLeft = 0;
            this.change_admin_btn.TextPadding = new System.Windows.Forms.Padding(0);
            this.change_admin_btn.UseDefaultRadiusAndThickness = true;
            this.change_admin_btn.Click += new System.EventHandler(this.change_admin_btn_Click);
            // 
            // UserListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 555);
            this.Controls.Add(this.change_admin_btn);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.create_user_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserListForm";
            this.Text = "UserList";
            this.Load += new System.EventHandler(this.UserListForm_Load);
            this.Shown += new System.EventHandler(this.UserListForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 create_user_btn;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewUsers;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn edit_btn;
        private System.Windows.Forms.DataGridViewImageColumn delete_btn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 change_admin_btn;
    }
}