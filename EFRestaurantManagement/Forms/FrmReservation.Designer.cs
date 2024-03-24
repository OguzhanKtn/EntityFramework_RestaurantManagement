namespace EFRestaurantManagement.Forms
{
    partial class FrmReservation
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
            cmbCustomers = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            dtReservation = new DateTimePicker();
            label3 = new Label();
            txtNotes = new TextBox();
            label4 = new Label();
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            label5 = new Label();
            dtUpdatedRsv = new DateTimePicker();
            label6 = new Label();
            txtUpdatedNotes = new TextBox();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmbCustomers
            // 
            cmbCustomers.FormattingEnabled = true;
            cmbCustomers.Location = new Point(179, 45);
            cmbCustomers.Name = "cmbCustomers";
            cmbCustomers.Size = new Size(203, 28);
            cmbCustomers.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 45);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 1;
            label1.Text = "Customers :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 45);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Customers :";
            // 
            // dtReservation
            // 
            dtReservation.Location = new Point(179, 102);
            dtReservation.Name = "dtReservation";
            dtReservation.Size = new Size(203, 27);
            dtReservation.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 102);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 1;
            label3.Text = "Reservation Date :";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(179, 158);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(203, 27);
            txtNotes.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 158);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 1;
            label4.Text = "Notes :";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(288, 239);
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
            dataGridView1.Location = new Point(413, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(500, 188);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(819, 239);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(555, 298);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 1;
            label5.Text = "Reservation Date :";
            // 
            // dtUpdatedRsv
            // 
            dtUpdatedRsv.Location = new Point(710, 298);
            dtUpdatedRsv.Name = "dtUpdatedRsv";
            dtUpdatedRsv.Size = new Size(203, 27);
            dtUpdatedRsv.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(555, 354);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 1;
            label6.Text = "Notes :";
            // 
            // txtUpdatedNotes
            // 
            txtUpdatedNotes.Location = new Point(710, 354);
            txtUpdatedNotes.Name = "txtUpdatedNotes";
            txtUpdatedNotes.Size = new Size(203, 27);
            txtUpdatedNotes.TabIndex = 3;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(819, 428);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FrmReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 491);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtUpdatedNotes);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(txtNotes);
            Controls.Add(dtUpdatedRsv);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(dtReservation);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCustomers);
            Name = "FrmReservation";
            Text = "FrmReservation";
            Load += FrmReservation_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCustomers;
        private Label label1;
        private Label label2;
        private DateTimePicker dtReservation;
        private Label label3;
        private TextBox txtNotes;
        private Label label4;
        private Button btnAdd;
        private DataGridView dataGridView1;
        private Button btnDelete;
        private Label label5;
        private DateTimePicker dtUpdatedRsv;
        private Label label6;
        private TextBox txtUpdatedNotes;
        private Button btnUpdate;
    }
}