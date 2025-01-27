namespace CSharpEgitimKampi601
{
    partial class FrmCustomer
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
            this.btnGetById = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCustomerUpdate = new System.Windows.Forms.Button();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnCustomerCreate = new System.Windows.Forms.Button();
            this.btnCustomerList = new System.Windows.Forms.Button();
            this.txtCustomerCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetById
            // 
            this.btnGetById.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGetById.Location = new System.Drawing.Point(220, 464);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(193, 47);
            this.btnGetById.TabIndex = 34;
            this.btnGetById.Text = "Get by ID";
            this.btnGetById.UseVisualStyleBackColor = false;
            this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(500, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(709, 375);
            this.dataGridView1.TabIndex = 33;
            // 
            // btnCustomerUpdate
            // 
            this.btnCustomerUpdate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCustomerUpdate.Location = new System.Drawing.Point(220, 411);
            this.btnCustomerUpdate.Name = "btnCustomerUpdate";
            this.btnCustomerUpdate.Size = new System.Drawing.Size(193, 47);
            this.btnCustomerUpdate.TabIndex = 32;
            this.btnCustomerUpdate.Text = "Update";
            this.btnCustomerUpdate.UseVisualStyleBackColor = false;
            this.btnCustomerUpdate.Click += new System.EventHandler(this.btnCustomerUpdate_Click);
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCustomerDelete.Location = new System.Drawing.Point(220, 358);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(193, 47);
            this.btnCustomerDelete.TabIndex = 31;
            this.btnCustomerDelete.Text = "Delete";
            this.btnCustomerDelete.UseVisualStyleBackColor = false;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // btnCustomerCreate
            // 
            this.btnCustomerCreate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCustomerCreate.Location = new System.Drawing.Point(220, 305);
            this.btnCustomerCreate.Name = "btnCustomerCreate";
            this.btnCustomerCreate.Size = new System.Drawing.Size(193, 47);
            this.btnCustomerCreate.TabIndex = 30;
            this.btnCustomerCreate.Text = "Add";
            this.btnCustomerCreate.UseVisualStyleBackColor = false;
            this.btnCustomerCreate.Click += new System.EventHandler(this.btnCustomerCreate_Click);
            // 
            // btnCustomerList
            // 
            this.btnCustomerList.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCustomerList.Location = new System.Drawing.Point(220, 252);
            this.btnCustomerList.Name = "btnCustomerList";
            this.btnCustomerList.Size = new System.Drawing.Size(193, 47);
            this.btnCustomerList.TabIndex = 29;
            this.btnCustomerList.Text = "List";
            this.btnCustomerList.UseVisualStyleBackColor = false;
            this.btnCustomerList.Click += new System.EventHandler(this.btnCustomerList_Click);
            // 
            // txtCustomerCity
            // 
            this.txtCustomerCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCustomerCity.Location = new System.Drawing.Point(206, 176);
            this.txtCustomerCity.Name = "txtCustomerCity";
            this.txtCustomerCity.Size = new System.Drawing.Size(220, 30);
            this.txtCustomerCity.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(44, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Customer City:";
            // 
            // txtCustomerSurname
            // 
            this.txtCustomerSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCustomerSurname.Location = new System.Drawing.Point(206, 140);
            this.txtCustomerSurname.Name = "txtCustomerSurname";
            this.txtCustomerSurname.Size = new System.Drawing.Size(220, 30);
            this.txtCustomerSurname.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(-2, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Customer Surname:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCustomerName.Location = new System.Drawing.Point(206, 104);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(220, 30);
            this.txtCustomerName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(26, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Customer Name:";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCustomerId.Location = new System.Drawing.Point(206, 68);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(220, 30);
            this.txtCustomerId.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(62, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Customer Id:";
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 538);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCustomerUpdate);
            this.Controls.Add(this.btnCustomerDelete);
            this.Controls.Add(this.btnCustomerCreate);
            this.Controls.Add(this.btnCustomerList);
            this.Controls.Add(this.txtCustomerCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCustomerSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomerId);
            this.Name = "FrmCustomer";
            this.Text = "FrmCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCustomerUpdate;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnCustomerCreate;
        private System.Windows.Forms.Button btnCustomerList;
        private System.Windows.Forms.TextBox txtCustomerCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label label1;
    }
}