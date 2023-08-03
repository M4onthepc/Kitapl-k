namespace Kitaplık
{
    partial class BuyNewBook
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapYazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SatınAl = new System.Windows.Forms.DataGridViewButtonColumn();
            this.kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitaplıkDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplıkDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.kitapAdDataGridViewTextBoxColumn,
            this.kitapYazarDataGridViewTextBoxColumn,
            this.kitapFiyatDataGridViewTextBoxColumn,
            this.SatınAl});
            this.dataGridView1.DataSource = this.kitapBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(653, 654);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // kitapAdDataGridViewTextBoxColumn
            // 
            this.kitapAdDataGridViewTextBoxColumn.DataPropertyName = "KitapAd";
            this.kitapAdDataGridViewTextBoxColumn.HeaderText = "KitapAd";
            this.kitapAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapAdDataGridViewTextBoxColumn.Name = "kitapAdDataGridViewTextBoxColumn";
            this.kitapAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapYazarDataGridViewTextBoxColumn
            // 
            this.kitapYazarDataGridViewTextBoxColumn.DataPropertyName = "KitapYazar";
            this.kitapYazarDataGridViewTextBoxColumn.HeaderText = "KitapYazar";
            this.kitapYazarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapYazarDataGridViewTextBoxColumn.Name = "kitapYazarDataGridViewTextBoxColumn";
            this.kitapYazarDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapFiyatDataGridViewTextBoxColumn
            // 
            this.kitapFiyatDataGridViewTextBoxColumn.DataPropertyName = "KitapFiyat";
            this.kitapFiyatDataGridViewTextBoxColumn.HeaderText = "KitapFiyat";
            this.kitapFiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapFiyatDataGridViewTextBoxColumn.Name = "kitapFiyatDataGridViewTextBoxColumn";
            this.kitapFiyatDataGridViewTextBoxColumn.Width = 70;
            // 
            // SatınAl
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SatınAl.DefaultCellStyle = dataGridViewCellStyle5;
            this.SatınAl.HeaderText = "Satın Al";
            this.SatınAl.MinimumWidth = 6;
            this.SatınAl.Name = "SatınAl";
            this.SatınAl.Text = "Al";
            this.SatınAl.UseColumnTextForButtonValue = true;
            this.SatınAl.Width = 70;
   
            // 
            // BuyNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(645, 594);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BuyNewBook";
            this.Text = "BuyNewBook";
            this.Load += new System.EventHandler(this.BuyNewBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplıkDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource kitaplıkDataSet2BindingSource;
        private System.Windows.Forms.BindingSource kitapBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapYazarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn SatınAl;
    }
}