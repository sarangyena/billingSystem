namespace prjBilling
{
    partial class frmAddRecord
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
            this.radMenuItem1 = new Telerik.WinControls.UI.RadDropDownMenu();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radDock1 = new Telerik.WinControls.UI.Docking.RadDock();
            this.documentWindow1 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.editDate = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnClose = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.txtStyle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTerms = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTIN = new System.Windows.Forms.TextBox();
            this.txtBilledTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBillRef = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radMenuItem1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).BeginInit();
            this.radDock1.SuspendLayout();
            this.documentWindow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).BeginInit();
            this.documentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).BeginInit();
            this.documentTabStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AnimationEnabled = true;
            this.radMenuItem1.AnimationFrames = 1;
            this.radMenuItem1.AnimationType = Telerik.WinControls.UI.PopupAnimationTypes.Fade;
            this.radMenuItem1.AutoSize = true;
            this.radMenuItem1.DropDownAnimationDirection = Telerik.WinControls.UI.RadDirection.Down;
            this.radMenuItem1.DropShadow = true;
            this.radMenuItem1.EasingType = Telerik.WinControls.RadEasingType.InQuad;
            this.radMenuItem1.EnableAeroEffects = false;
            this.radMenuItem1.FadeAnimationFrames = 10;
            this.radMenuItem1.FadeAnimationSpeed = 10;
            this.radMenuItem1.FadeAnimationType = Telerik.WinControls.UI.FadeAnimationType.FadeIn;
            this.radMenuItem1.FitToScreenMode = ((Telerik.WinControls.UI.FitToScreenModes)((Telerik.WinControls.UI.FitToScreenModes.FitWidth | Telerik.WinControls.UI.FitToScreenModes.FitHeight)));
            this.radMenuItem1.HorizontalAlignmentCorrectionMode = Telerik.WinControls.UI.AlignmentCorrectionMode.SnapToOuterEdges;
            this.radMenuItem1.Location = new System.Drawing.Point(0, 0);
            this.radMenuItem1.Maximum = new System.Drawing.Size(0, 0);
            this.radMenuItem1.Minimum = new System.Drawing.Size(0, 0);
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Opacity = 1F;
            this.radMenuItem1.ProcessKeyboard = false;
            this.radMenuItem1.RollOverItemSelection = true;
            this.radMenuItem1.Size = new System.Drawing.Size(0, 0);
            this.radMenuItem1.TabIndex = 0;
            this.radMenuItem1.VerticalAlignmentCorrectionMode = Telerik.WinControls.UI.AlignmentCorrectionMode.SnapToOuterEdges;
            this.radMenuItem1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(733, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // radDock1
            // 
            this.radDock1.ActiveWindow = this.documentWindow1;
            this.radDock1.CausesValidation = false;
            this.radDock1.Controls.Add(this.documentContainer1);
            this.radDock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDock1.IsCleanUpTarget = true;
            this.radDock1.Location = new System.Drawing.Point(0, 24);
            this.radDock1.MainDocumentContainer = this.documentContainer1;
            this.radDock1.Name = "radDock1";
            // 
            // 
            // 
            this.radDock1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.radDock1.Size = new System.Drawing.Size(733, 250);
            this.radDock1.TabIndex = 1;
            this.radDock1.TabStop = false;
            this.radDock1.Text = "radDock1";
            // 
            // documentWindow1
            // 
            this.documentWindow1.Controls.Add(this.panel1);
            this.documentWindow1.Controls.Add(this.btnClose);
            this.documentWindow1.Controls.Add(this.btnSave);
            this.documentWindow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.documentWindow1.Location = new System.Drawing.Point(6, 29);
            this.documentWindow1.Name = "documentWindow1";
            this.documentWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            this.documentWindow1.Size = new System.Drawing.Size(711, 205);
            this.documentWindow1.Text = "Header";
            // 
            // editDate
            // 
            this.editDate.Location = new System.Drawing.Point(473, 43);
            this.editDate.Name = "editDate";
            this.editDate.Size = new System.Drawing.Size(219, 20);
            this.editDate.TabIndex = 33;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(92, 121);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(219, 20);
            this.txtAddress.TabIndex = 31;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(594, 172);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 24);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(478, 172);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 24);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtStyle
            // 
            this.txtStyle.Location = new System.Drawing.Point(473, 95);
            this.txtStyle.Name = "txtStyle";
            this.txtStyle.Size = new System.Drawing.Size(219, 20);
            this.txtStyle.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(371, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Bus. Style:";
            // 
            // txtTerms
            // 
            this.txtTerms.Location = new System.Drawing.Point(473, 69);
            this.txtTerms.Name = "txtTerms";
            this.txtTerms.Size = new System.Drawing.Size(219, 20);
            this.txtTerms.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Terms:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Date:";
            // 
            // txtTIN
            // 
            this.txtTIN.Location = new System.Drawing.Point(92, 95);
            this.txtTIN.Name = "txtTIN";
            this.txtTIN.Size = new System.Drawing.Size(219, 20);
            this.txtTIN.TabIndex = 22;
            // 
            // txtBilledTo
            // 
            this.txtBilledTo.Location = new System.Drawing.Point(92, 69);
            this.txtBilledTo.Name = "txtBilledTo";
            this.txtBilledTo.Size = new System.Drawing.Size(219, 20);
            this.txtBilledTo.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "TIN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Billed To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Address:";
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(92, 42);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(219, 21);
            this.comboBoxCustomer.TabIndex = 16;
            this.comboBoxCustomer.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCustomer_SelectionChangeCommitted_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Customer Name:";
            // 
            // documentContainer1
            // 
            this.documentContainer1.CausesValidation = false;
            this.documentContainer1.Controls.Add(this.documentTabStrip1);
            this.documentContainer1.Name = "documentContainer1";
            // 
            // 
            // 
            this.documentContainer1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            // 
            // documentTabStrip1
            // 
            this.documentTabStrip1.CanUpdateChildIndex = true;
            this.documentTabStrip1.CausesValidation = false;
            this.documentTabStrip1.Controls.Add(this.documentWindow1);
            this.documentTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.documentTabStrip1.Name = "documentTabStrip1";
            // 
            // 
            // 
            this.documentTabStrip1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.documentTabStrip1.SelectedIndex = 0;
            this.documentTabStrip1.Size = new System.Drawing.Size(723, 240);
            this.documentTabStrip1.TabIndex = 0;
            this.documentTabStrip1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.txtBillRef);
            this.panel1.Controls.Add(this.editDate);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtStyle);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtBillNo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTerms);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.comboBoxCustomer);
            this.panel1.Controls.Add(this.txtBilledTo);
            this.panel1.Controls.Add(this.txtTIN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 163);
            this.panel1.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bill No.:";
            // 
            // txtBillNo
            // 
            this.txtBillNo.Location = new System.Drawing.Point(92, 16);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.ReadOnly = true;
            this.txtBillNo.Size = new System.Drawing.Size(219, 20);
            this.txtBillNo.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(371, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Bill Reference No.:";
            // 
            // txtBillRef
            // 
            this.txtBillRef.Location = new System.Drawing.Point(473, 16);
            this.txtBillRef.Name = "txtBillRef";
            this.txtBillRef.Size = new System.Drawing.Size(219, 20);
            this.txtBillRef.TabIndex = 37;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(374, 127);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(41, 13);
            this.lblID.TabIndex = 38;
            this.lblID.Text = "label10";
            // 
            // frmAddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 274);
            this.Controls.Add(this.radDock1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAddRecord";
            this.Text = "Add Record";
            this.Load += new System.EventHandler(this.frmAddRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radMenuItem1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).EndInit();
            this.radDock1.ResumeLayout(false);
            this.documentWindow1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).EndInit();
            this.documentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).EndInit();
            this.documentTabStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadDropDownMenu radMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow1;
        private System.Windows.Forms.TextBox txtStyle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTerms;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTIN;
        private System.Windows.Forms.TextBox txtBilledTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadButton btnClose;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker editDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBillRef;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label @try;
        private System.Windows.Forms.Label lblID;
    }
}