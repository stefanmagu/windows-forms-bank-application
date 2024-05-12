namespace _2_1058_MAGUREANU_STEFAN
{
    partial class CreditAccountsForm
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
            this.creditAccountsDataGridView = new System.Windows.Forms.DataGridView();
            this.infoCreditAcountLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.addCreditAccountButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.creditAccountsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // creditAccountsDataGridView
            // 
            this.creditAccountsDataGridView.AllowUserToAddRows = false;
            this.creditAccountsDataGridView.AllowUserToDeleteRows = false;
            this.creditAccountsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.creditAccountsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.creditAccountsDataGridView.BackgroundColor = System.Drawing.Color.MintCream;
            this.creditAccountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.creditAccountsDataGridView.Location = new System.Drawing.Point(12, 79);
            this.creditAccountsDataGridView.Name = "creditAccountsDataGridView";
            this.creditAccountsDataGridView.ReadOnly = true;
            this.creditAccountsDataGridView.RowHeadersWidth = 51;
            this.creditAccountsDataGridView.RowTemplate.Height = 24;
            this.creditAccountsDataGridView.Size = new System.Drawing.Size(1372, 317);
            this.creditAccountsDataGridView.TabIndex = 0;
            this.creditAccountsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.creditAccountsDataGridView_CellContentClick);
            // 
            // infoCreditAcountLabel
            // 
            this.infoCreditAcountLabel.AutoSize = true;
            this.infoCreditAcountLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoCreditAcountLabel.Location = new System.Drawing.Point(9, 24);
            this.infoCreditAcountLabel.Name = "infoCreditAcountLabel";
            this.infoCreditAcountLabel.Size = new System.Drawing.Size(254, 25);
            this.infoCreditAcountLabel.TabIndex = 1;
            this.infoCreditAcountLabel.Text = "infoCreditAccountLabel";
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.Orange;
            this.refreshButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(413, 6);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(145, 68);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Refresh Data";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // addCreditAccountButton
            // 
            this.addCreditAccountButton.BackColor = System.Drawing.Color.LimeGreen;
            this.addCreditAccountButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCreditAccountButton.Location = new System.Drawing.Point(564, 6);
            this.addCreditAccountButton.Name = "addCreditAccountButton";
            this.addCreditAccountButton.Size = new System.Drawing.Size(153, 68);
            this.addCreditAccountButton.TabIndex = 3;
            this.addCreditAccountButton.Text = "Add credit account";
            this.addCreditAccountButton.UseVisualStyleBackColor = false;
            this.addCreditAccountButton.Click += new System.EventHandler(this.addCreditAccountButton_Click);
            // 
            // CreditAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1394, 403);
            this.Controls.Add(this.addCreditAccountButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.infoCreditAcountLabel);
            this.Controls.Add(this.creditAccountsDataGridView);
            this.Name = "CreditAccountsForm";
            this.Text = "CreditAccountsForm";
            ((System.ComponentModel.ISupportInitialize)(this.creditAccountsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView creditAccountsDataGridView;
        private System.Windows.Forms.Label infoCreditAcountLabel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button addCreditAccountButton;
    }
}