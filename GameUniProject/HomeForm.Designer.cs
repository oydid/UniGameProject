
namespace GameUniProject
{
    partial class HomeForm
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
            this.InputId = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.InputName = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.InputYear = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.InputPublisherId = new System.Windows.Forms.ComboBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.GameGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GameGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // InputId
            // 
            this.InputId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputId.Location = new System.Drawing.Point(12, 42);
            this.InputId.Name = "InputId";
            this.InputId.ReadOnly = true;
            this.InputId.Size = new System.Drawing.Size(170, 29);
            this.InputId.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblID.Location = new System.Drawing.Point(12, 15);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 24);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(12, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 24);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // InputName
            // 
            this.InputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputName.Location = new System.Drawing.Point(12, 108);
            this.InputName.Name = "InputName";
            this.InputName.Size = new System.Drawing.Size(170, 29);
            this.InputName.TabIndex = 2;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYear.Location = new System.Drawing.Point(8, 151);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(162, 24);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "Year of Publishing";
            // 
            // InputYear
            // 
            this.InputYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputYear.Location = new System.Drawing.Point(12, 178);
            this.InputYear.Name = "InputYear";
            this.InputYear.Size = new System.Drawing.Size(170, 29);
            this.InputYear.TabIndex = 4;
            this.InputYear.TextChanged += new System.EventHandler(this.InputYear_TextChanged);
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPublisher.Location = new System.Drawing.Point(12, 223);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(89, 24);
            this.lblPublisher.TabIndex = 6;
            this.lblPublisher.Text = "Publisher";
            // 
            // InputPublisherId
            // 
            this.InputPublisherId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputPublisherId.FormattingEnabled = true;
            this.InputPublisherId.Location = new System.Drawing.Point(12, 250);
            this.InputPublisherId.Name = "InputPublisherId";
            this.InputPublisherId.Size = new System.Drawing.Size(166, 32);
            this.InputPublisherId.TabIndex = 7;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCreate.Location = new System.Drawing.Point(12, 315);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(89, 33);
            this.BtnCreate.TabIndex = 8;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnUpdate.Location = new System.Drawing.Point(107, 315);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(89, 33);
            this.BtnUpdate.TabIndex = 9;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDelete.Location = new System.Drawing.Point(202, 315);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(89, 33);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // GameGridView
            // 
            this.GameGridView.AllowUserToAddRows = false;
            this.GameGridView.AllowUserToDeleteRows = false;
            this.GameGridView.AllowUserToResizeColumns = false;
            this.GameGridView.AllowUserToResizeRows = false;
            this.GameGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GameGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GameGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GameGridView.Location = new System.Drawing.Point(382, 42);
            this.GameGridView.Name = "GameGridView";
            this.GameGridView.ReadOnly = true;
            this.GameGridView.Size = new System.Drawing.Size(690, 306);
            this.GameGridView.TabIndex = 11;
            this.GameGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GameGridView_RowHeaderMouseClick);
            this.GameGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GameGridView_RowHeaderMouseDoubleClick);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 385);
            this.Controls.Add(this.GameGridView);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.InputPublisherId);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.InputYear);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.InputName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.InputId);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GameGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputId;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox InputName;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox InputYear;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.ComboBox InputPublisherId;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.DataGridView GameGridView;
    }
}

