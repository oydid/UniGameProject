
namespace GameUniProject
{
    partial class GameExtras
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
            this.lblGameName = new System.Windows.Forms.Label();
            this.InputGameName = new System.Windows.Forms.TextBox();
            this.lblExtras = new System.Windows.Forms.Label();
            this.ComboExtraId = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.ManyToManyGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ManyToManyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGameName.Location = new System.Drawing.Point(45, 59);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(61, 24);
            this.lblGameName.TabIndex = 0;
            this.lblGameName.Text = "Game";
            // 
            // InputGameName
            // 
            this.InputGameName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.InputGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputGameName.Location = new System.Drawing.Point(26, 86);
            this.InputGameName.Name = "InputGameName";
            this.InputGameName.ReadOnly = true;
            this.InputGameName.Size = new System.Drawing.Size(100, 29);
            this.InputGameName.TabIndex = 1;
            // 
            // lblExtras
            // 
            this.lblExtras.AutoSize = true;
            this.lblExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExtras.Location = new System.Drawing.Point(269, 59);
            this.lblExtras.Name = "lblExtras";
            this.lblExtras.Size = new System.Drawing.Size(62, 24);
            this.lblExtras.TabIndex = 2;
            this.lblExtras.Text = "Extras";
            // 
            // ComboExtraId
            // 
            this.ComboExtraId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboExtraId.FormattingEnabled = true;
            this.ComboExtraId.Location = new System.Drawing.Point(239, 86);
            this.ComboExtraId.Name = "ComboExtraId";
            this.ComboExtraId.Size = new System.Drawing.Size(121, 32);
            this.ComboExtraId.TabIndex = 3;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAdd.Location = new System.Drawing.Point(93, 138);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(95, 44);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExit.Location = new System.Drawing.Point(194, 138);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(95, 44);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // ManyToManyGrid
            // 
            this.ManyToManyGrid.AllowUserToAddRows = false;
            this.ManyToManyGrid.AllowUserToDeleteRows = false;
            this.ManyToManyGrid.AllowUserToResizeColumns = false;
            this.ManyToManyGrid.AllowUserToResizeRows = false;
            this.ManyToManyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManyToManyGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ManyToManyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManyToManyGrid.Location = new System.Drawing.Point(12, 200);
            this.ManyToManyGrid.Name = "ManyToManyGrid";
            this.ManyToManyGrid.Size = new System.Drawing.Size(411, 170);
            this.ManyToManyGrid.TabIndex = 6;
            // 
            // GameExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 382);
            this.Controls.Add(this.ManyToManyGrid);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.ComboExtraId);
            this.Controls.Add(this.lblExtras);
            this.Controls.Add(this.InputGameName);
            this.Controls.Add(this.lblGameName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameExtras";
            this.Text = "GameExtra";
            ((System.ComponentModel.ISupportInitialize)(this.ManyToManyGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.TextBox InputGameName;
        private System.Windows.Forms.Label lblExtras;
        private System.Windows.Forms.ComboBox ComboExtraId;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.DataGridView ManyToManyGrid;
    }
}