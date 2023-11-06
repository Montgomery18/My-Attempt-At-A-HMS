namespace Hospital_Management_System
{
    partial class Archive
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
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.lbSearchStaff = new System.Windows.Forms.Label();
            this.lblArchiveTitle = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.picButtonLogout = new System.Windows.Forms.PictureBox();
            this.picButtonMainMenu = new System.Windows.Forms.PictureBox();
            this.lblLeavePageTitle = new System.Windows.Forms.Label();
            this.btnSortAlphabeticallyFilter = new System.Windows.Forms.Button();
            this.btnHideData = new System.Windows.Forms.Button();
            this.btnReverseAlphabeticallyFilter = new System.Windows.Forms.Button();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.lblFiltersTitle = new System.Windows.Forms.Label();
            this.panelLeavePage = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numUDSearch = new System.Windows.Forms.NumericUpDown();
            this.lblSearchID = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonMainMenu)).BeginInit();
            this.panelLeavePage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDSearch)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxSearch.Location = new System.Drawing.Point(5, 35);
            this.txtBoxSearch.MaxLength = 42;
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.PlaceholderText = "Enter Staff Name";
            this.txtBoxSearch.Size = new System.Drawing.Size(205, 27);
            this.txtBoxSearch.TabIndex = 213;
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
            this.lbSearchStaff.Location = new System.Drawing.Point(5, 4);
            this.lbSearchStaff.Name = "lbSearchStaff";
            this.lbSearchStaff.Size = new System.Drawing.Size(205, 31);
            this.lbSearchStaff.TabIndex = 212;
            this.lbSearchStaff.Text = "Search";
            this.lbSearchStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArchiveTitle
            // 
            this.lblArchiveTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArchiveTitle.AutoSize = true;
            this.lblArchiveTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblArchiveTitle.Location = new System.Drawing.Point(393, 9);
            this.lblArchiveTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArchiveTitle.Name = "lblArchiveTitle";
            this.lblArchiveTitle.Size = new System.Drawing.Size(114, 37);
            this.lblArchiveTitle.TabIndex = 211;
            this.lblArchiveTitle.Text = "Archive";
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
            this.dataGridView.Location = new System.Drawing.Point(223, 48);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(455, 250);
            this.dataGridView.TabIndex = 210;
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
            this.picButtonLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picButtonLogout.TabIndex = 215;
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
            this.picButtonMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picButtonMainMenu.TabIndex = 214;
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
            this.lblLeavePageTitle.Location = new System.Drawing.Point(21, 12);
            this.lblLeavePageTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLeavePageTitle.Name = "lblLeavePageTitle";
            this.lblLeavePageTitle.Size = new System.Drawing.Size(161, 37);
            this.lblLeavePageTitle.TabIndex = 216;
            this.lblLeavePageTitle.Text = "Leave Page";
            // 
            // btnSortAlphabeticallyFilter
            // 
            this.btnSortAlphabeticallyFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSortAlphabeticallyFilter.BackColor = System.Drawing.Color.White;
            this.btnSortAlphabeticallyFilter.Location = new System.Drawing.Point(22, 151);
            this.btnSortAlphabeticallyFilter.Name = "btnSortAlphabeticallyFilter";
            this.btnSortAlphabeticallyFilter.Size = new System.Drawing.Size(119, 35);
            this.btnSortAlphabeticallyFilter.TabIndex = 218;
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
            this.btnHideData.Location = new System.Drawing.Point(25, 103);
            this.btnHideData.Name = "btnHideData";
            this.btnHideData.Size = new System.Drawing.Size(113, 35);
            this.btnHideData.TabIndex = 221;
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
            this.btnReverseAlphabeticallyFilter.Location = new System.Drawing.Point(12, 199);
            this.btnReverseAlphabeticallyFilter.Name = "btnReverseAlphabeticallyFilter";
            this.btnReverseAlphabeticallyFilter.Size = new System.Drawing.Size(138, 35);
            this.btnReverseAlphabeticallyFilter.TabIndex = 219;
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
            this.btnResetFilter.Location = new System.Drawing.Point(31, 55);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(101, 35);
            this.btnResetFilter.TabIndex = 217;
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
            this.lblFiltersTitle.Location = new System.Drawing.Point(36, 12);
            this.lblFiltersTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltersTitle.Name = "lblFiltersTitle";
            this.lblFiltersTitle.Size = new System.Drawing.Size(96, 37);
            this.lblFiltersTitle.TabIndex = 220;
            this.lblFiltersTitle.Text = "Filters";
            // 
            // panelLeavePage
            // 
            this.panelLeavePage.BackColor = System.Drawing.Color.Azure;
            this.panelLeavePage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeavePage.Controls.Add(this.lblLeavePageTitle);
            this.panelLeavePage.Controls.Add(this.picButtonMainMenu);
            this.panelLeavePage.Controls.Add(this.picButtonLogout);
            this.panelLeavePage.Location = new System.Drawing.Point(16, 48);
            this.panelLeavePage.Name = "panelLeavePage";
            this.panelLeavePage.Size = new System.Drawing.Size(201, 191);
            this.panelLeavePage.TabIndex = 222;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSortAlphabeticallyFilter);
            this.panel1.Controls.Add(this.lblFiltersTitle);
            this.panel1.Controls.Add(this.btnResetFilter);
            this.panel1.Controls.Add(this.btnHideData);
            this.panel1.Controls.Add(this.btnReverseAlphabeticallyFilter);
            this.panel1.Location = new System.Drawing.Point(684, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 250);
            this.panel1.TabIndex = 223;
            // 
            // numUDSearch
            // 
            this.numUDSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numUDSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numUDSearch.Location = new System.Drawing.Point(5, 110);
            this.numUDSearch.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numUDSearch.Name = "numUDSearch";
            this.numUDSearch.Size = new System.Drawing.Size(205, 25);
            this.numUDSearch.TabIndex = 230;
            this.numUDSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUDSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numSearchEnterKey);
            // 
            // lblSearchID
            // 
            this.lblSearchID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchID.BackColor = System.Drawing.Color.Black;
            this.lblSearchID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSearchID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearchID.ForeColor = System.Drawing.Color.White;
            this.lblSearchID.Location = new System.Drawing.Point(5, 77);
            this.lblSearchID.Name = "lblSearchID";
            this.lblSearchID.Size = new System.Drawing.Size(205, 33);
            this.lblSearchID.TabIndex = 229;
            this.lblSearchID.Text = "Search By ID";
            this.lblSearchID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch.BackColor = System.Drawing.Color.Azure;
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.numUDSearch);
            this.panelSearch.Controls.Add(this.lbSearchStaff);
            this.panelSearch.Controls.Add(this.lblSearchID);
            this.panelSearch.Controls.Add(this.txtBoxSearch);
            this.panelSearch.Location = new System.Drawing.Point(341, 305);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(216, 141);
            this.panelSearch.TabIndex = 231;
            // 
            // Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(864, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLeavePage);
            this.Controls.Add(this.lblArchiveTitle);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panelSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Archive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archive";
            this.Load += new System.EventHandler(this.formLoaded);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonMainMenu)).EndInit();
            this.panelLeavePage.ResumeLayout(false);
            this.panelLeavePage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDSearch)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBoxSearch;
        private Label lbSearchStaff;
        private Label lblArchiveTitle;
        private DataGridView dataGridView;
        private PictureBox picButtonLogout;
        private PictureBox picButtonMainMenu;
        private Label lblLeavePageTitle;
        private Button btnSortAlphabeticallyFilter;
        private Button btnHideData;
        private Button btnReverseAlphabeticallyFilter;
        private Button btnResetFilter;
        private Label lblFiltersTitle;
        private Panel panelLeavePage;
        private Panel panel1;
        private NumericUpDown numUDSearch;
        private Label lblSearchID;
        private Panel panelSearch;
    }
}