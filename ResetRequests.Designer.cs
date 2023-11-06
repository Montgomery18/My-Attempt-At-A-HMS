namespace Hospital_Management_System
{
    partial class ResetRequests
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
            this.lblJobRolesTitle = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.lbSearchStaff = new System.Windows.Forms.Label();
            this.picButtonLogout = new System.Windows.Forms.PictureBox();
            this.picButtonMainMenu = new System.Windows.Forms.PictureBox();
            this.lblLeavePageTitle = new System.Windows.Forms.Label();
            this.btnSortAlphabeticallyFilter = new System.Windows.Forms.Button();
            this.btnHideData = new System.Windows.Forms.Button();
            this.btnReverseAlphabeticallyFilter = new System.Windows.Forms.Button();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.lblFiltersTitle = new System.Windows.Forms.Label();
            this.panelLeavePage = new System.Windows.Forms.Panel();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.lblSelectedRequest = new System.Windows.Forms.Label();
            this.picButtonApprove = new System.Windows.Forms.PictureBox();
            this.picButtonDeny = new System.Windows.Forms.PictureBox();
            this.numSelectedRequest = new System.Windows.Forms.NumericUpDown();
            this.numAccountToReset = new System.Windows.Forms.NumericUpDown();
            this.lblAccountToReset = new System.Windows.Forms.Label();
            this.panelSearchAndSelect = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonMainMenu)).BeginInit();
            this.panelLeavePage.SuspendLayout();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonApprove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonDeny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSelectedRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAccountToReset)).BeginInit();
            this.panelSearchAndSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJobRolesTitle
            // 
            this.lblJobRolesTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJobRolesTitle.AutoSize = true;
            this.lblJobRolesTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblJobRolesTitle.Location = new System.Drawing.Point(281, 9);
            this.lblJobRolesTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJobRolesTitle.Name = "lblJobRolesTitle";
            this.lblJobRolesTitle.Size = new System.Drawing.Size(338, 37);
            this.lblJobRolesTitle.TabIndex = 101;
            this.lblJobRolesTitle.Text = "Password Reset Requests";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(232, 48);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(437, 249);
            this.dataGridView.TabIndex = 100;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxSearch.Location = new System.Drawing.Point(145, 37);
            this.txtBoxSearch.MaxLength = 42;
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.PlaceholderText = "Enter Username";
            this.txtBoxSearch.Size = new System.Drawing.Size(205, 25);
            this.txtBoxSearch.TabIndex = 211;
            this.txtBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchEnterKey);
            // 
            // lbSearchStaff
            // 
            this.lbSearchStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSearchStaff.BackColor = System.Drawing.Color.Black;
            this.lbSearchStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSearchStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSearchStaff.ForeColor = System.Drawing.Color.White;
            this.lbSearchStaff.Location = new System.Drawing.Point(145, 6);
            this.lbSearchStaff.Name = "lbSearchStaff";
            this.lbSearchStaff.Size = new System.Drawing.Size(205, 31);
            this.lbSearchStaff.TabIndex = 210;
            this.lbSearchStaff.Text = "Search";
            this.lbSearchStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picButtonLogout
            // 
            this.picButtonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picButtonLogout.BackColor = System.Drawing.Color.Transparent;
            this.picButtonLogout.Image = global::Hospital_Management_System.Properties.Resources.LogoutButton;
            this.picButtonLogout.Location = new System.Drawing.Point(9, 134);
            this.picButtonLogout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picButtonLogout.Name = "picButtonLogout";
            this.picButtonLogout.Size = new System.Drawing.Size(181, 41);
            this.picButtonLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picButtonLogout.TabIndex = 214;
            this.picButtonLogout.TabStop = false;
            this.picButtonLogout.Click += new System.EventHandler(this.picButtonLogout_Click);
            // 
            // picButtonMainMenu
            // 
            this.picButtonMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picButtonMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.picButtonMainMenu.Image = global::Hospital_Management_System.Properties.Resources.MainMenuButton;
            this.picButtonMainMenu.Location = new System.Drawing.Point(9, 62);
            this.picButtonMainMenu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picButtonMainMenu.Name = "picButtonMainMenu";
            this.picButtonMainMenu.Size = new System.Drawing.Size(181, 41);
            this.picButtonMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picButtonMainMenu.TabIndex = 213;
            this.picButtonMainMenu.TabStop = false;
            this.picButtonMainMenu.Click += new System.EventHandler(this.picButtonMainMenu_Click);
            // 
            // lblLeavePageTitle
            // 
            this.lblLeavePageTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLeavePageTitle.AutoSize = true;
            this.lblLeavePageTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblLeavePageTitle.Location = new System.Drawing.Point(22, 12);
            this.lblLeavePageTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLeavePageTitle.Name = "lblLeavePageTitle";
            this.lblLeavePageTitle.Size = new System.Drawing.Size(161, 37);
            this.lblLeavePageTitle.TabIndex = 215;
            this.lblLeavePageTitle.Text = "Leave Page";
            // 
            // btnSortAlphabeticallyFilter
            // 
            this.btnSortAlphabeticallyFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortAlphabeticallyFilter.BackColor = System.Drawing.Color.White;
            this.btnSortAlphabeticallyFilter.Location = new System.Drawing.Point(23, 151);
            this.btnSortAlphabeticallyFilter.Name = "btnSortAlphabeticallyFilter";
            this.btnSortAlphabeticallyFilter.Size = new System.Drawing.Size(117, 35);
            this.btnSortAlphabeticallyFilter.TabIndex = 217;
            this.btnSortAlphabeticallyFilter.Text = "Sort Alphabetically";
            this.btnSortAlphabeticallyFilter.UseVisualStyleBackColor = false;
            this.btnSortAlphabeticallyFilter.Click += new System.EventHandler(this.btnSortAlphabeticallyFilter_Click);
            // 
            // btnHideData
            // 
            this.btnHideData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHideData.BackColor = System.Drawing.Color.White;
            this.btnHideData.Location = new System.Drawing.Point(26, 103);
            this.btnHideData.Name = "btnHideData";
            this.btnHideData.Size = new System.Drawing.Size(111, 35);
            this.btnHideData.TabIndex = 220;
            this.btnHideData.Text = "Hide Data";
            this.btnHideData.UseVisualStyleBackColor = false;
            this.btnHideData.Click += new System.EventHandler(this.btnHideData_Click);
            // 
            // btnReverseAlphabeticallyFilter
            // 
            this.btnReverseAlphabeticallyFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReverseAlphabeticallyFilter.BackColor = System.Drawing.Color.White;
            this.btnReverseAlphabeticallyFilter.Location = new System.Drawing.Point(13, 199);
            this.btnReverseAlphabeticallyFilter.Name = "btnReverseAlphabeticallyFilter";
            this.btnReverseAlphabeticallyFilter.Size = new System.Drawing.Size(136, 35);
            this.btnReverseAlphabeticallyFilter.TabIndex = 218;
            this.btnReverseAlphabeticallyFilter.Text = "Reverse Alphabetically";
            this.btnReverseAlphabeticallyFilter.UseVisualStyleBackColor = false;
            this.btnReverseAlphabeticallyFilter.Click += new System.EventHandler(this.btnReverseAlphabeticallyFilter_Click);
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetFilter.BackColor = System.Drawing.Color.White;
            this.btnResetFilter.Location = new System.Drawing.Point(32, 55);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(99, 35);
            this.btnResetFilter.TabIndex = 216;
            this.btnResetFilter.Text = "Reset";
            this.btnResetFilter.UseVisualStyleBackColor = false;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // lblFiltersTitle
            // 
            this.lblFiltersTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltersTitle.AutoSize = true;
            this.lblFiltersTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblFiltersTitle.Location = new System.Drawing.Point(37, 12);
            this.lblFiltersTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltersTitle.Name = "lblFiltersTitle";
            this.lblFiltersTitle.Size = new System.Drawing.Size(96, 37);
            this.lblFiltersTitle.TabIndex = 219;
            this.lblFiltersTitle.Text = "Filters";
            // 
            // panelLeavePage
            // 
            this.panelLeavePage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLeavePage.BackColor = System.Drawing.Color.Azure;
            this.panelLeavePage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeavePage.Controls.Add(this.picButtonMainMenu);
            this.panelLeavePage.Controls.Add(this.lblLeavePageTitle);
            this.panelLeavePage.Controls.Add(this.picButtonLogout);
            this.panelLeavePage.Location = new System.Drawing.Point(25, 48);
            this.panelLeavePage.Name = "panelLeavePage";
            this.panelLeavePage.Size = new System.Drawing.Size(201, 191);
            this.panelLeavePage.TabIndex = 221;
            // 
            // panelFilters
            // 
            this.panelFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFilters.BackColor = System.Drawing.Color.Azure;
            this.panelFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFilters.Controls.Add(this.btnReverseAlphabeticallyFilter);
            this.panelFilters.Controls.Add(this.lblFiltersTitle);
            this.panelFilters.Controls.Add(this.btnSortAlphabeticallyFilter);
            this.panelFilters.Controls.Add(this.btnResetFilter);
            this.panelFilters.Controls.Add(this.btnHideData);
            this.panelFilters.Location = new System.Drawing.Point(675, 48);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(164, 249);
            this.panelFilters.TabIndex = 222;
            // 
            // lblSelectedRequest
            // 
            this.lblSelectedRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectedRequest.BackColor = System.Drawing.Color.Black;
            this.lblSelectedRequest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSelectedRequest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedRequest.ForeColor = System.Drawing.Color.White;
            this.lblSelectedRequest.Location = new System.Drawing.Point(15, 93);
            this.lblSelectedRequest.Name = "lblSelectedRequest";
            this.lblSelectedRequest.Size = new System.Drawing.Size(207, 31);
            this.lblSelectedRequest.TabIndex = 243;
            this.lblSelectedRequest.Text = "Selected Request";
            this.lblSelectedRequest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picButtonApprove
            // 
            this.picButtonApprove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picButtonApprove.BackColor = System.Drawing.Color.Transparent;
            this.picButtonApprove.Image = global::Hospital_Management_System.Properties.Resources.ApproveButton;
            this.picButtonApprove.Location = new System.Drawing.Point(91, 167);
            this.picButtonApprove.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picButtonApprove.Name = "picButtonApprove";
            this.picButtonApprove.Size = new System.Drawing.Size(131, 41);
            this.picButtonApprove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picButtonApprove.TabIndex = 216;
            this.picButtonApprove.TabStop = false;
            this.picButtonApprove.Click += new System.EventHandler(this.picButtonApprove_Click);
            // 
            // picButtonDeny
            // 
            this.picButtonDeny.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picButtonDeny.BackColor = System.Drawing.Color.Transparent;
            this.picButtonDeny.Image = global::Hospital_Management_System.Properties.Resources.DenyButton;
            this.picButtonDeny.Location = new System.Drawing.Point(273, 167);
            this.picButtonDeny.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picButtonDeny.Name = "picButtonDeny";
            this.picButtonDeny.Size = new System.Drawing.Size(131, 41);
            this.picButtonDeny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picButtonDeny.TabIndex = 245;
            this.picButtonDeny.TabStop = false;
            this.picButtonDeny.Click += new System.EventHandler(this.picButtonDeny_Click);
            // 
            // numSelectedRequest
            // 
            this.numSelectedRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numSelectedRequest.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numSelectedRequest.Location = new System.Drawing.Point(15, 124);
            this.numSelectedRequest.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numSelectedRequest.Name = "numSelectedRequest";
            this.numSelectedRequest.Size = new System.Drawing.Size(207, 25);
            this.numSelectedRequest.TabIndex = 246;
            this.numSelectedRequest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numAccountToReset
            // 
            this.numAccountToReset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numAccountToReset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numAccountToReset.Location = new System.Drawing.Point(273, 124);
            this.numAccountToReset.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numAccountToReset.Name = "numAccountToReset";
            this.numAccountToReset.Size = new System.Drawing.Size(207, 25);
            this.numAccountToReset.TabIndex = 248;
            this.numAccountToReset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAccountToReset
            // 
            this.lblAccountToReset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccountToReset.BackColor = System.Drawing.Color.Black;
            this.lblAccountToReset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAccountToReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAccountToReset.ForeColor = System.Drawing.Color.White;
            this.lblAccountToReset.Location = new System.Drawing.Point(273, 93);
            this.lblAccountToReset.Name = "lblAccountToReset";
            this.lblAccountToReset.Size = new System.Drawing.Size(207, 31);
            this.lblAccountToReset.TabIndex = 247;
            this.lblAccountToReset.Text = "Account To Reset (ID)";
            this.lblAccountToReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSearchAndSelect
            // 
            this.panelSearchAndSelect.BackColor = System.Drawing.Color.Azure;
            this.panelSearchAndSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearchAndSelect.Controls.Add(this.numAccountToReset);
            this.panelSearchAndSelect.Controls.Add(this.lbSearchStaff);
            this.panelSearchAndSelect.Controls.Add(this.lblAccountToReset);
            this.panelSearchAndSelect.Controls.Add(this.txtBoxSearch);
            this.panelSearchAndSelect.Controls.Add(this.numSelectedRequest);
            this.panelSearchAndSelect.Controls.Add(this.lblSelectedRequest);
            this.panelSearchAndSelect.Controls.Add(this.picButtonDeny);
            this.panelSearchAndSelect.Controls.Add(this.picButtonApprove);
            this.panelSearchAndSelect.Location = new System.Drawing.Point(206, 303);
            this.panelSearchAndSelect.Name = "panelSearchAndSelect";
            this.panelSearchAndSelect.Size = new System.Drawing.Size(497, 217);
            this.panelSearchAndSelect.TabIndex = 249;
            // 
            // ResetRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(864, 521);
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.panelLeavePage);
            this.Controls.Add(this.lblJobRolesTitle);
            this.Controls.Add(this.panelSearchAndSelect);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResetRequests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Requests";
            this.Load += new System.EventHandler(this.formLoaded);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonMainMenu)).EndInit();
            this.panelLeavePage.ResumeLayout(false);
            this.panelLeavePage.PerformLayout();
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonApprove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonDeny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSelectedRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAccountToReset)).EndInit();
            this.panelSearchAndSelect.ResumeLayout(false);
            this.panelSearchAndSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblJobRolesTitle;
        private DataGridView dataGridView;
        private TextBox txtBoxSearch;
        private Label lbSearchStaff;
        private PictureBox picButtonLogout;
        private PictureBox picButtonMainMenu;
        private Label lblLeavePageTitle;
        private Button btnSortAlphabeticallyFilter;
        private Button btnHideData;
        private Button btnReverseAlphabeticallyFilter;
        private Button btnResetFilter;
        private Label lblFiltersTitle;
        private Panel panelLeavePage;
        private Panel panelFilters;
        private Label lblSelectedRequest;
        private PictureBox picButtonApprove;
        private PictureBox picButtonDeny;
        private NumericUpDown numSelectedRequest;
        private NumericUpDown numAccountToReset;
        private Label lblAccountToReset;
        private Panel panelSearchAndSelect;
    }
}