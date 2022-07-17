namespace HELVETAS.dialogs
{
    partial class AddAVPDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAVPDialog));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.name_district_combo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.result_txt = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.create_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.header_text = new System.Windows.Forms.Label();
            this.name_avp_txt = new Bunifu.UI.WinForms.BunifuTextBox();
            this.districr_name_txt = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.bunifuShadowPanel1.BorderRadius = 0;
            this.bunifuShadowPanel1.BorderThickness = 2;
            this.bunifuShadowPanel1.Controls.Add(this.name_district_combo);
            this.bunifuShadowPanel1.Controls.Add(this.name_avp_txt);
            this.bunifuShadowPanel1.Controls.Add(this.result_txt);
            this.bunifuShadowPanel1.Controls.Add(this.cancel_btn);
            this.bunifuShadowPanel1.Controls.Add(this.create_btn);
            this.bunifuShadowPanel1.Controls.Add(this.close_btn);
            this.bunifuShadowPanel1.Controls.Add(this.header_text);
            this.bunifuShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.Empty;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 0;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.ForwardDiagonal;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(400, 251);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel1.TabIndex = 35;
            this.bunifuShadowPanel1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.bunifuShadowPanel1_ControlAdded);
            // 
            // name_district_combo
            // 
            this.name_district_combo.BackColor = System.Drawing.Color.Transparent;
            this.name_district_combo.BorderRadius = 5;
            this.name_district_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.name_district_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.name_district_combo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_district_combo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_district_combo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.name_district_combo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.name_district_combo.ItemHeight = 30;
            this.name_district_combo.Location = new System.Drawing.Point(20, 120);
            this.name_district_combo.Name = "name_district_combo";
            this.name_district_combo.Size = new System.Drawing.Size(364, 36);
            this.name_district_combo.TabIndex = 35;
            this.name_district_combo.SelectedIndexChanged += new System.EventHandler(this.name_district_combo_SelectedIndexChanged);
            // 
            // result_txt
            // 
            this.result_txt.AutoSize = true;
            this.result_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_txt.ForeColor = System.Drawing.Color.Red;
            this.result_txt.Location = new System.Drawing.Point(17, 169);
            this.result_txt.Name = "result_txt";
            this.result_txt.Size = new System.Drawing.Size(0, 17);
            this.result_txt.TabIndex = 33;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.Color.Red;
            this.cancel_btn.Location = new System.Drawing.Point(20, 204);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(175, 35);
            this.cancel_btn.TabIndex = 3;
            this.cancel_btn.Text = "Инкор кардан";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // create_btn
            // 
            this.create_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.create_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.create_btn.FlatAppearance.BorderSize = 0;
            this.create_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.create_btn.Location = new System.Drawing.Point(213, 204);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(175, 35);
            this.create_btn.TabIndex = 2;
            this.create_btn.Text = "Илова кардан";
            this.create_btn.UseVisualStyleBackColor = false;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Red;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(348, 9);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(40, 30);
            this.close_btn.TabIndex = 32;
            this.close_btn.Text = "X";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // header_text
            // 
            this.header_text.AutoSize = true;
            this.header_text.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_text.Location = new System.Drawing.Point(148, 9);
            this.header_text.Name = "header_text";
            this.header_text.Size = new System.Drawing.Size(109, 20);
            this.header_text.TabIndex = 31;
            this.header_text.Text = "Илова кардан";
            // 
            // name_avp_txt
            // 
            this.name_avp_txt.AcceptsReturn = false;
            this.name_avp_txt.AcceptsTab = false;
            this.name_avp_txt.AnimationSpeed = 200;
            this.name_avp_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.name_avp_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.name_avp_txt.AutoSizeHeight = true;
            this.name_avp_txt.BackColor = System.Drawing.Color.Transparent;
            this.name_avp_txt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("name_avp_txt.BackgroundImage")));
            this.name_avp_txt.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.name_avp_txt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.name_avp_txt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.name_avp_txt.BorderColorIdle = System.Drawing.Color.Silver;
            this.name_avp_txt.BorderRadius = 8;
            this.name_avp_txt.BorderThickness = 1;
            this.name_avp_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.name_avp_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_avp_txt.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_avp_txt.DefaultText = "";
            this.name_avp_txt.FillColor = System.Drawing.Color.White;
            this.name_avp_txt.HideSelection = true;
            this.name_avp_txt.IconLeft = null;
            this.name_avp_txt.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.name_avp_txt.IconPadding = 10;
            this.name_avp_txt.IconRight = null;
            this.name_avp_txt.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.name_avp_txt.Lines = new string[0];
            this.name_avp_txt.Location = new System.Drawing.Point(20, 70);
            this.name_avp_txt.MaxLength = 32767;
            this.name_avp_txt.MinimumSize = new System.Drawing.Size(1, 1);
            this.name_avp_txt.Modified = false;
            this.name_avp_txt.Multiline = false;
            this.name_avp_txt.Name = "name_avp_txt";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.name_avp_txt.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.name_avp_txt.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.name_avp_txt.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.name_avp_txt.OnIdleState = stateProperties4;
            this.name_avp_txt.Padding = new System.Windows.Forms.Padding(3);
            this.name_avp_txt.PasswordChar = '\0';
            this.name_avp_txt.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.name_avp_txt.PlaceholderText = "Номи АВП";
            this.name_avp_txt.ReadOnly = false;
            this.name_avp_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.name_avp_txt.SelectedText = "";
            this.name_avp_txt.SelectionLength = 0;
            this.name_avp_txt.SelectionStart = 0;
            this.name_avp_txt.ShortcutsEnabled = true;
            this.name_avp_txt.Size = new System.Drawing.Size(364, 39);
            this.name_avp_txt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.name_avp_txt.TabIndex = 34;
            this.name_avp_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.name_avp_txt.TextMarginBottom = 0;
            this.name_avp_txt.TextMarginLeft = 3;
            this.name_avp_txt.TextMarginTop = 1;
            this.name_avp_txt.TextPlaceholder = "Номи АВП";
            this.name_avp_txt.UseSystemPasswordChar = false;
            this.name_avp_txt.WordWrap = true;
            this.name_avp_txt.TextChanged += new System.EventHandler(this.name_avp_txt_TextChanged);
            // 
            // districr_name_txt
            // 
            this.districr_name_txt.AcceptsReturn = false;
            this.districr_name_txt.AcceptsTab = false;
            this.districr_name_txt.AnimationSpeed = 200;
            this.districr_name_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.districr_name_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.districr_name_txt.AutoSizeHeight = true;
            this.districr_name_txt.BackColor = System.Drawing.Color.Transparent;
            this.districr_name_txt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("districr_name_txt.BackgroundImage")));
            this.districr_name_txt.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.districr_name_txt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.districr_name_txt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.districr_name_txt.BorderColorIdle = System.Drawing.Color.Silver;
            this.districr_name_txt.BorderRadius = 8;
            this.districr_name_txt.BorderThickness = 1;
            this.districr_name_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.districr_name_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.districr_name_txt.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.districr_name_txt.DefaultText = "";
            this.districr_name_txt.FillColor = System.Drawing.Color.White;
            this.districr_name_txt.HideSelection = true;
            this.districr_name_txt.IconLeft = null;
            this.districr_name_txt.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.districr_name_txt.IconPadding = 10;
            this.districr_name_txt.IconRight = null;
            this.districr_name_txt.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.districr_name_txt.Lines = new string[0];
            this.districr_name_txt.Location = new System.Drawing.Point(20, 57);
            this.districr_name_txt.MaxLength = 32767;
            this.districr_name_txt.MinimumSize = new System.Drawing.Size(1, 1);
            this.districr_name_txt.Modified = false;
            this.districr_name_txt.Multiline = false;
            this.districr_name_txt.Name = "districr_name_txt";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.districr_name_txt.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.districr_name_txt.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.districr_name_txt.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.districr_name_txt.OnIdleState = stateProperties8;
            this.districr_name_txt.Padding = new System.Windows.Forms.Padding(3);
            this.districr_name_txt.PasswordChar = '\0';
            this.districr_name_txt.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.districr_name_txt.PlaceholderText = "Номи район";
            this.districr_name_txt.ReadOnly = false;
            this.districr_name_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.districr_name_txt.SelectedText = "";
            this.districr_name_txt.SelectionLength = 0;
            this.districr_name_txt.SelectionStart = 0;
            this.districr_name_txt.ShortcutsEnabled = true;
            this.districr_name_txt.Size = new System.Drawing.Size(368, 39);
            this.districr_name_txt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.districr_name_txt.TabIndex = 34;
            this.districr_name_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.districr_name_txt.TextMarginBottom = 0;
            this.districr_name_txt.TextMarginLeft = 3;
            this.districr_name_txt.TextMarginTop = 1;
            this.districr_name_txt.TextPlaceholder = "Номи район";
            this.districr_name_txt.UseSystemPasswordChar = false;
            this.districr_name_txt.WordWrap = true;
            // 
            // AddAVPDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 251);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.Controls.Add(this.districr_name_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAVPDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddAVPDialog";
            this.Load += new System.EventHandler(this.AddAVPDialog_Load);
            this.Shown += new System.EventHandler(this.AddAVPDialog_Shown);
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private System.Windows.Forms.Label result_txt;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label header_text;
        private Bunifu.UI.WinForms.BunifuTextBox districr_name_txt;
        private Bunifu.UI.WinForms.BunifuTextBox name_avp_txt;
        private Guna.UI2.WinForms.Guna2ComboBox name_district_combo;
    }
}