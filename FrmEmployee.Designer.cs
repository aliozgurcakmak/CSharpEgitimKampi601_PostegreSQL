namespace CSharpEgitimKampi601
{
    partial class FrmEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetById = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btCreate = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.txtEmployeeSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmployeeSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEmployeeDepartment = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(82, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "Employee Id:";
            // 
            // btnGetById
            // 
            this.btnGetById.BackColor = System.Drawing.Color.DarkViolet;
            this.btnGetById.Location = new System.Drawing.Point(73, 473);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(361, 47);
            this.btnGetById.TabIndex = 48;
            this.btnGetById.Text = "Get by ID";
            this.btnGetById.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(521, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(709, 375);
            this.dataGridView1.TabIndex = 47;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkViolet;
            this.btnUpdate.Location = new System.Drawing.Point(73, 420);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(361, 47);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkViolet;
            this.btnDelete.Location = new System.Drawing.Point(73, 367);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(361, 47);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btCreate
            // 
            this.btCreate.BackColor = System.Drawing.Color.DarkViolet;
            this.btCreate.Location = new System.Drawing.Point(73, 314);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(361, 47);
            this.btCreate.TabIndex = 44;
            this.btCreate.Text = "Add";
            this.btCreate.UseVisualStyleBackColor = false;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.DarkViolet;
            this.btnList.Location = new System.Drawing.Point(73, 261);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(361, 47);
            this.btnList.TabIndex = 43;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtEmployeeSalary
            // 
            this.txtEmployeeSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmployeeSalary.Location = new System.Drawing.Point(229, 159);
            this.txtEmployeeSalary.Name = "txtEmployeeSalary";
            this.txtEmployeeSalary.Size = new System.Drawing.Size(220, 30);
            this.txtEmployeeSalary.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(42, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 41;
            this.label4.Text = "Employee Salary:";
            // 
            // txtEmployeeSurname
            // 
            this.txtEmployeeSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmployeeSurname.Location = new System.Drawing.Point(229, 123);
            this.txtEmployeeSurname.Name = "txtEmployeeSurname";
            this.txtEmployeeSurname.Size = new System.Drawing.Size(220, 30);
            this.txtEmployeeSurname.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(18, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Employee Surname:";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmployeeName.Location = new System.Drawing.Point(229, 87);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(220, 30);
            this.txtEmployeeName.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(46, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Employee Name:";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmployeeId.Location = new System.Drawing.Point(229, 51);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(220, 30);
            this.txtEmployeeId.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(89, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "Department:";
            // 
            // cmbEmployeeDepartment
            // 
            this.cmbEmployeeDepartment.FormattingEnabled = true;
            this.cmbEmployeeDepartment.Location = new System.Drawing.Point(229, 200);
            this.cmbEmployeeDepartment.Name = "cmbEmployeeDepartment";
            this.cmbEmployeeDepartment.Size = new System.Drawing.Size(220, 24);
            this.cmbEmployeeDepartment.TabIndex = 52;
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 558);
            this.Controls.Add(this.cmbEmployeeDepartment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtEmployeeSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmployeeSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmployeeId);
            this.Name = "FrmEmployee";
            this.Text = "FrmEmployee";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtEmployeeSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmployeeSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEmployeeDepartment;
    }
}