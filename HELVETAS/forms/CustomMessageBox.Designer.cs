namespace HELVETAS.forms
{
    partial class CustomMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.bunifuAppBar1 = new Bunifu.Utils.BunifuAppBar();
            this.label_txt_info = new System.Windows.Forms.Label();
            this.img_info = new System.Windows.Forms.PictureBox();
            this.ok_but = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            ((System.ComponentModel.ISupportInitialize)(this.img_info)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuAppBar1
            // 
            this.bunifuAppBar1.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuAppBar1.ControlBoxColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuAppBar1.ControlBoxColorActive = System.Drawing.Color.White;
            this.bunifuAppBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuAppBar1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuAppBar1.ForeColor = System.Drawing.Color.White;
            this.bunifuAppBar1.Icon = null;
            this.bunifuAppBar1.Location = new System.Drawing.Point(0, 0);
            this.bunifuAppBar1.Name = "bunifuAppBar1";
            this.bunifuAppBar1.Size = new System.Drawing.Size(300, 25);
            this.bunifuAppBar1.TabIndex = 0;
            this.bunifuAppBar1.Title = "";
            this.bunifuAppBar1.TitleMargin = new System.Windows.Forms.Padding(47, 12, 0, 0);
            // 
            // label_txt_info
            // 
            this.label_txt_info.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_txt_info.Location = new System.Drawing.Point(67, 31);
            this.label_txt_info.Name = "label_txt_info";
            this.label_txt_info.Size = new System.Drawing.Size(200, 89);
            this.label_txt_info.TabIndex = 3;
            this.label_txt_info.Text = "txt";
            this.label_txt_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // img_info
            // 
            this.img_info.Image = global::HELVETAS.Properties.Resources.info;
            this.img_info.Location = new System.Drawing.Point(12, 56);
            this.img_info.Name = "img_info";
            this.img_info.Size = new System.Drawing.Size(49, 42);
            this.img_info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_info.TabIndex = 2;
            this.img_info.TabStop = false;
            // 
            // ok_but
            // 
            this.ok_but.AllowAnimations = true;
            this.ok_but.AllowMouseEffects = true;
            this.ok_but.AllowToggling = false;
            this.ok_but.AnimationSpeed = 200;
            this.ok_but.AutoGenerateColors = false;
            this.ok_but.AutoRoundBorders = false;
            this.ok_but.AutoSizeLeftIcon = true;
            this.ok_but.AutoSizeRightIcon = true;
            this.ok_but.BackColor = System.Drawing.Color.Transparent;
            this.ok_but.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.ok_but.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ok_but.BackgroundImage")));
            this.ok_but.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.ok_but.ButtonText = "OK";
            this.ok_but.ButtonTextMarginLeft = 0;
            this.ok_but.ColorContrastOnClick = 45;
            this.ok_but.ColorContrastOnHover = 45;
            this.ok_but.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.ok_but.CustomizableEdges = borderEdges2;
            this.ok_but.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ok_but.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ok_but.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ok_but.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ok_but.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.ok_but.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_but.ForeColor = System.Drawing.Color.White;
            this.ok_but.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ok_but.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.ok_but.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ok_but.IconMarginLeft = 11;
            this.ok_but.IconPadding = 10;
            this.ok_but.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ok_but.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.ok_but.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ok_but.IconSize = 25;
            this.ok_but.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.ok_but.IdleBorderRadius = 15;
            this.ok_but.IdleBorderThickness = 1;
            this.ok_but.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.ok_but.IdleIconLeftImage = null;
            this.ok_but.IdleIconRightImage = null;
            this.ok_but.IndicateFocus = false;
            this.ok_but.Location = new System.Drawing.Point(22, 128);
            this.ok_but.Name = "ok_but";
            this.ok_but.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ok_but.OnDisabledState.BorderRadius = 15;
            this.ok_but.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.ok_but.OnDisabledState.BorderThickness = 1;
            this.ok_but.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ok_but.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ok_but.OnDisabledState.IconLeftImage = null;
            this.ok_but.OnDisabledState.IconRightImage = null;
            this.ok_but.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ok_but.onHoverState.BorderRadius = 15;
            this.ok_but.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.ok_but.onHoverState.BorderThickness = 1;
            this.ok_but.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ok_but.onHoverState.ForeColor = System.Drawing.Color.White;
            this.ok_but.onHoverState.IconLeftImage = null;
            this.ok_but.onHoverState.IconRightImage = null;
            this.ok_but.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ok_but.OnIdleState.BorderRadius = 15;
            this.ok_but.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.ok_but.OnIdleState.BorderThickness = 1;
            this.ok_but.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.ok_but.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.ok_but.OnIdleState.IconLeftImage = null;
            this.ok_but.OnIdleState.IconRightImage = null;
            this.ok_but.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ok_but.OnPressedState.BorderRadius = 15;
            this.ok_but.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.ok_but.OnPressedState.BorderThickness = 1;
            this.ok_but.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ok_but.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.ok_but.OnPressedState.IconLeftImage = null;
            this.ok_but.OnPressedState.IconRightImage = null;
            this.ok_but.Size = new System.Drawing.Size(255, 40);
            this.ok_but.TabIndex = 1;
            this.ok_but.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ok_but.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ok_but.TextMarginLeft = 0;
            this.ok_but.TextPadding = new System.Windows.Forms.Padding(0);
            this.ok_but.UseDefaultRadiusAndThickness = true;
            this.ok_but.Click += new System.EventHandler(this.ok_but_Click);
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = true;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = true;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 180);
            this.Controls.Add(this.label_txt_info);
            this.Controls.Add(this.img_info);
            this.Controls.Add(this.ok_but);
            this.Controls.Add(this.bunifuAppBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 180);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 180);
            this.Name = "CustomMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "msg";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomMessageBox_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.img_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 ok_but;
        private Bunifu.Utils.BunifuAppBar bunifuAppBar1;
        private System.Windows.Forms.Label label_txt_info;
        private System.Windows.Forms.PictureBox img_info;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
    }
}