namespace MyCoffee {
    partial class FormHistoryBill {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistoryBill));
            this.dtgViewBill = new System.Windows.Forms.DataGridView();
            this.dtgViewBillDetail = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewBillDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgViewBill
            // 
            this.dtgViewBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgViewBill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtgViewBill.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgViewBill.Location = new System.Drawing.Point(12, 11);
            this.dtgViewBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgViewBill.Name = "dtgViewBill";
            this.dtgViewBill.ReadOnly = true;
            this.dtgViewBill.RowTemplate.Height = 24;
            this.dtgViewBill.Size = new System.Drawing.Size(600, 600);
            this.dtgViewBill.TabIndex = 0;
            // 
            // dtgViewBillDetail
            // 
            this.dtgViewBillDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgViewBillDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtgViewBillDetail.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgViewBillDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgViewBillDetail.Location = new System.Drawing.Point(618, 11);
            this.dtgViewBillDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgViewBillDetail.Name = "dtgViewBillDetail";
            this.dtgViewBillDetail.ReadOnly = true;
            this.dtgViewBillDetail.RowTemplate.Height = 24;
            this.dtgViewBillDetail.Size = new System.Drawing.Size(754, 600);
            this.dtgViewBillDetail.TabIndex = 1;
            // 
            // FormHistoryBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::MyCoffee.Properties.Resources.c4;
            this.ClientSize = new System.Drawing.Size(1383, 621);
            this.Controls.Add(this.dtgViewBillDetail);
            this.Controls.Add(this.dtgViewBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormHistoryBill";
            this.Text = "Sales History";
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewBillDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgViewBill;
        private System.Windows.Forms.DataGridView dtgViewBillDetail;
    }
}