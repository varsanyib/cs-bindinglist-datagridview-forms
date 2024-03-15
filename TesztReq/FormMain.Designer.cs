namespace TesztReq
{
    partial class FormMain
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
            dgData = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Avatar = new DataGridViewLinkColumn();
            btnStart = new Button();
            btnDel = new Button();
            btnInfo = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgData).BeginInit();
            SuspendLayout();
            // 
            // dgData
            // 
            dgData.AllowUserToAddRows = false;
            dgData.AllowUserToDeleteRows = false;
            dgData.AllowUserToOrderColumns = true;
            dgData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgData.BackgroundColor = SystemColors.ControlLight;
            dgData.BorderStyle = BorderStyle.Fixed3D;
            dgData.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgData.Columns.AddRange(new DataGridViewColumn[] { Id, FirstName, LastName, Email, Avatar });
            dgData.GridColor = SystemColors.ScrollBar;
            dgData.Location = new Point(146, 12);
            dgData.MultiSelect = false;
            dgData.Name = "dgData";
            dgData.ReadOnly = true;
            dgData.RowHeadersVisible = false;
            dgData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgData.ShowCellErrors = false;
            dgData.ShowEditingIcon = false;
            dgData.Size = new Size(642, 426);
            dgData.TabIndex = 3;
            dgData.ColumnHeaderMouseClick += dgData_ColumnHeaderMouseClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "First name";
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "Last name";
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Avatar
            // 
            Avatar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Avatar.DataPropertyName = "Avatar";
            Avatar.HeaderText = "Avatar";
            Avatar.Name = "Avatar";
            Avatar.ReadOnly = true;
            Avatar.Resizable = DataGridViewTriState.True;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(22, 12);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(111, 23);
            btnStart.TabIndex = 0;
            btnStart.Text = "Request";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(22, 70);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(111, 23);
            btnDel.TabIndex = 2;
            btnDel.Text = "Clear";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnInfo
            // 
            btnInfo.Location = new Point(22, 41);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(111, 23);
            btnInfo.TabIndex = 1;
            btnInfo.Text = "Info";
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClose.Location = new Point(22, 415);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(111, 23);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close Application";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AcceptButton = btnStart;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnDel);
            Controls.Add(btnClose);
            Controls.Add(btnInfo);
            Controls.Add(btnStart);
            Controls.Add(dgData);
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimizeBox = false;
            MinimumSize = new Size(816, 489);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test - API Request Application";
            ((System.ComponentModel.ISupportInitialize)dgData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgData;
        private Button btnStart;
        private Button btnDel;
        private Button btnInfo;
        private Button btnClose;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewLinkColumn Avatar;
    }
}
