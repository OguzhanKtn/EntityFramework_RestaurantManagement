namespace EFRestaurantManagement.Forms
{
    partial class FrmOrder
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
            cmbRsvDateCustomer = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cmbMenus = new ComboBox();
            dtOrder = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            txtQuantity = new TextBox();
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmbRsvDateCustomer
            // 
            cmbRsvDateCustomer.FormattingEnabled = true;
            cmbRsvDateCustomer.Location = new Point(171, 27);
            cmbRsvDateCustomer.Name = "cmbRsvDateCustomer";
            cmbRsvDateCustomer.Size = new Size(166, 28);
            cmbRsvDateCustomer.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 30);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 1;
            label1.Text = "RsvDate-Customer :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 82);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Menus :";
            // 
            // cmbMenus
            // 
            cmbMenus.FormattingEnabled = true;
            cmbMenus.Location = new Point(171, 74);
            cmbMenus.Name = "cmbMenus";
            cmbMenus.Size = new Size(166, 28);
            cmbMenus.TabIndex = 0;
            // 
            // dtOrder
            // 
            dtOrder.Location = new Point(171, 131);
            dtOrder.Name = "dtOrder";
            dtOrder.Size = new Size(166, 27);
            dtOrder.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 136);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 1;
            label3.Text = "OrderDate :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 188);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 1;
            label4.Text = "Quantity :";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(171, 188);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(166, 27);
            txtQuantity.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(243, 253);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(365, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(466, 188);
            dataGridView1.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(737, 253);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // FrmOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 481);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtQuantity);
            Controls.Add(dtOrder);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbMenus);
            Controls.Add(label1);
            Controls.Add(cmbRsvDateCustomer);
            Name = "FrmOrder";
            Text = "FrmOrder";
            Load += FrmOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbRsvDateCustomer;
        private Label label1;
        private Label label2;
        private ComboBox cmbMenus;
        private DateTimePicker dtOrder;
        private Label label3;
        private Label label4;
        private TextBox txtQuantity;
        private Button btnAdd;
        private DataGridView dataGridView1;
        private Button btnDelete;
    }
}