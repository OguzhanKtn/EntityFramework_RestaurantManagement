namespace EFRestaurantManagement.Forms
{
    partial class FrmMenu
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            txtMenuAdd = new Button();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            btnMenuDelete = new Button();
            txtUpdatedPrice = new TextBox();
            btnMenuUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 114);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "Title :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 163);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 1;
            label2.Text = "Description :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 225);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 2;
            label3.Text = "Price :";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(129, 114);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(129, 163);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(129, 225);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 5;
            // 
            // txtMenuAdd
            // 
            txtMenuAdd.Location = new Point(160, 298);
            txtMenuAdd.Name = "txtMenuAdd";
            txtMenuAdd.Size = new Size(94, 29);
            txtMenuAdd.TabIndex = 6;
            txtMenuAdd.Text = "Add";
            txtMenuAdd.UseVisualStyleBackColor = true;
            txtMenuAdd.Click += txtMenuAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(284, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(378, 188);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(712, 125);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 8;
            label4.Text = "Price :";
            // 
            // btnMenuDelete
            // 
            btnMenuDelete.Location = new Point(568, 307);
            btnMenuDelete.Name = "btnMenuDelete";
            btnMenuDelete.Size = new Size(94, 29);
            btnMenuDelete.TabIndex = 6;
            btnMenuDelete.Text = "Delete";
            btnMenuDelete.UseVisualStyleBackColor = true;
            btnMenuDelete.Click += btnMenuDelete_Click;
            // 
            // txtUpdatedPrice
            // 
            txtUpdatedPrice.Location = new Point(794, 122);
            txtUpdatedPrice.Name = "txtUpdatedPrice";
            txtUpdatedPrice.Size = new Size(125, 27);
            txtUpdatedPrice.TabIndex = 9;
            // 
            // btnMenuUpdate
            // 
            btnMenuUpdate.Location = new Point(841, 298);
            btnMenuUpdate.Name = "btnMenuUpdate";
            btnMenuUpdate.Size = new Size(94, 29);
            btnMenuUpdate.TabIndex = 6;
            btnMenuUpdate.Text = "Update";
            btnMenuUpdate.UseVisualStyleBackColor = true;
            btnMenuUpdate.Click += btnMenuUpdate_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 489);
            Controls.Add(txtUpdatedPrice);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(btnMenuUpdate);
            Controls.Add(btnMenuDelete);
            Controls.Add(txtMenuAdd);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMenu";
            Text = "FrmMenu";
            Load += FrmMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private Button txtMenuAdd;
        private DataGridView dataGridView1;
        private Label label4;
        private Button btnMenuDelete;
        private TextBox txtUpdatedPrice;
        private Button btnMenuUpdate;
    }
}