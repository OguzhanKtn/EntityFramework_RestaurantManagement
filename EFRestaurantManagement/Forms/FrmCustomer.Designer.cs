namespace EFRestaurantManagement
{
    partial class FrmCustomer
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCustomerName = new TextBox();
            txtCustomerSurname = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtAdress = new TextBox();
            btnCustomerAdd = new Button();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtUpdateEmail = new TextBox();
            txtUpdatePhone = new TextBox();
            txtUpdateAddress = new TextBox();
            btnCustomerUpdate = new Button();
            btnCustomerDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Surname :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 108);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 2;
            label3.Text = "Email :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 155);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Phone :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 219);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 4;
            label5.Text = "Addres :";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(102, 12);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(162, 27);
            txtCustomerName.TabIndex = 5;
            // 
            // txtCustomerSurname
            // 
            txtCustomerSurname.Location = new Point(102, 61);
            txtCustomerSurname.Name = "txtCustomerSurname";
            txtCustomerSurname.Size = new Size(162, 27);
            txtCustomerSurname.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(102, 108);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(162, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(102, 155);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(162, 27);
            txtPhone.TabIndex = 8;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(102, 216);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(162, 27);
            txtAdress.TabIndex = 9;
            // 
            // btnCustomerAdd
            // 
            btnCustomerAdd.Location = new Point(170, 267);
            btnCustomerAdd.Name = "btnCustomerAdd";
            btnCustomerAdd.Size = new Size(94, 29);
            btnCustomerAdd.TabIndex = 10;
            btnCustomerAdd.Text = "Add";
            btnCustomerAdd.UseVisualStyleBackColor = true;
            btnCustomerAdd.Click += btnCustomerAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(299, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(428, 231);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(753, 12);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 12;
            label6.Text = "Email :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(753, 61);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 13;
            label7.Text = "Phone :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(753, 111);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 14;
            label8.Text = "Address :";
            // 
            // txtUpdateEmail
            // 
            txtUpdateEmail.Location = new Point(834, 12);
            txtUpdateEmail.Name = "txtUpdateEmail";
            txtUpdateEmail.Size = new Size(167, 27);
            txtUpdateEmail.TabIndex = 15;
            // 
            // txtUpdatePhone
            // 
            txtUpdatePhone.Location = new Point(834, 58);
            txtUpdatePhone.Name = "txtUpdatePhone";
            txtUpdatePhone.Size = new Size(167, 27);
            txtUpdatePhone.TabIndex = 15;
            // 
            // txtUpdateAddress
            // 
            txtUpdateAddress.Location = new Point(834, 105);
            txtUpdateAddress.Name = "txtUpdateAddress";
            txtUpdateAddress.Size = new Size(167, 27);
            txtUpdateAddress.TabIndex = 15;
            // 
            // btnCustomerUpdate
            // 
            btnCustomerUpdate.Location = new Point(907, 183);
            btnCustomerUpdate.Name = "btnCustomerUpdate";
            btnCustomerUpdate.Size = new Size(94, 29);
            btnCustomerUpdate.TabIndex = 10;
            btnCustomerUpdate.Text = "Update";
            btnCustomerUpdate.UseVisualStyleBackColor = true;
            btnCustomerUpdate.Click += btnCustomerUpdate_Click;
            // 
            // btnCustomerDelete
            // 
            btnCustomerDelete.Location = new Point(624, 267);
            btnCustomerDelete.Name = "btnCustomerDelete";
            btnCustomerDelete.Size = new Size(94, 29);
            btnCustomerDelete.TabIndex = 10;
            btnCustomerDelete.Text = "Delete";
            btnCustomerDelete.UseVisualStyleBackColor = true;
            btnCustomerDelete.Click += btnCustomerDelete_Click;
            // 
            // FrmCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 489);
            Controls.Add(txtUpdateAddress);
            Controls.Add(txtUpdatePhone);
            Controls.Add(txtUpdateEmail);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(btnCustomerDelete);
            Controls.Add(btnCustomerUpdate);
            Controls.Add(btnCustomerAdd);
            Controls.Add(txtAdress);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtCustomerSurname);
            Controls.Add(txtCustomerName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCustomer";
            Text = "Form1";
            Load += FrmCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCustomerName;
        private TextBox txtCustomerSurname;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtAdress;
        private Button btnCustomerAdd;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtUpdateEmail;
        private TextBox txtUpdatePhone;
        private TextBox txtUpdateAddress;
        private Button btnCustomerUpdate;
        private Button btnCustomerDelete;
    }
}
