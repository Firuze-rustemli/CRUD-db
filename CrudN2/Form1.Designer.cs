namespace CrudN2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.Label();
            this.boxName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.Label();
            this.boxDelId = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.txtDelName = new System.Windows.Forms.Label();
            this.boxDelName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.txtUpName = new System.Windows.Forms.Label();
            this.boxUpName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtSearchName = new System.Windows.Forms.Label();
            this.boxSearchName = new System.Windows.Forms.TextBox();
            this.dgwData = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.boxName);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(109, 114);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 45);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(6, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(72, 25);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Name";
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(125, 48);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(168, 33);
            this.boxName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.boxDelId);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.txtDelName);
            this.groupBox2.Controls.Add(this.boxDelName);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(374, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 182);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete";
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(6, 95);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(41, 25);
            this.txtId.TabIndex = 4;
            this.txtId.Text = "ID";
            // 
            // boxDelId
            // 
            this.boxDelId.Location = new System.Drawing.Point(109, 89);
            this.boxDelId.Name = "boxDelId";
            this.boxDelId.Size = new System.Drawing.Size(168, 33);
            this.boxDelId.TabIndex = 3;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(109, 131);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(100, 45);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtDelName
            // 
            this.txtDelName.AutoSize = true;
            this.txtDelName.Location = new System.Drawing.Point(6, 48);
            this.txtDelName.Name = "txtDelName";
            this.txtDelName.Size = new System.Drawing.Size(72, 25);
            this.txtDelName.TabIndex = 1;
            this.txtDelName.Text = "Name";
            // 
            // boxDelName
            // 
            this.boxDelName.Location = new System.Drawing.Point(109, 42);
            this.boxDelName.Name = "boxDelName";
            this.boxDelName.Size = new System.Drawing.Size(168, 33);
            this.boxDelName.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUp);
            this.groupBox3.Controls.Add(this.txtUpName);
            this.groupBox3.Controls.Add(this.boxUpName);
            this.groupBox3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(732, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 183);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update";
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(109, 114);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(100, 45);
            this.btnUp.TabIndex = 2;
            this.btnUp.Text = "Update";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // txtUpName
            // 
            this.txtUpName.AutoSize = true;
            this.txtUpName.Location = new System.Drawing.Point(6, 51);
            this.txtUpName.Name = "txtUpName";
            this.txtUpName.Size = new System.Drawing.Size(72, 25);
            this.txtUpName.TabIndex = 1;
            this.txtUpName.Text = "Name";
            // 
            // boxUpName
            // 
            this.boxUpName.Location = new System.Drawing.Point(125, 48);
            this.boxUpName.Name = "boxUpName";
            this.boxUpName.Size = new System.Drawing.Size(168, 33);
            this.boxUpName.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtSearchName);
            this.groupBox4.Controls.Add(this.boxSearchName);
            this.groupBox4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 216);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(325, 124);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search";
            // 
            // txtSearchName
            // 
            this.txtSearchName.AutoSize = true;
            this.txtSearchName.Location = new System.Drawing.Point(6, 51);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(72, 25);
            this.txtSearchName.TabIndex = 1;
            this.txtSearchName.Text = "Name";
            // 
            // boxSearchName
            // 
            this.boxSearchName.Location = new System.Drawing.Point(125, 48);
            this.boxSearchName.Name = "boxSearchName";
            this.boxSearchName.Size = new System.Drawing.Size(168, 33);
            this.boxSearchName.TabIndex = 0;
            this.boxSearchName.TextChanged += new System.EventHandler(this.boxSearchName_TextChanged);
            // 
            // dgwData
            // 
            this.dgwData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwData.Location = new System.Drawing.Point(0, 387);
            this.dgwData.Name = "dgwData";
            this.dgwData.RowTemplate.Height = 28;
            this.dgwData.Size = new System.Drawing.Size(1069, 228);
            this.dgwData.TabIndex = 4;
            this.dgwData.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.deleteMouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1069, 627);
            this.Controls.Add(this.dgwData);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.TextBox boxDelId;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label txtDelName;
        private System.Windows.Forms.TextBox boxDelName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Label txtUpName;
        private System.Windows.Forms.TextBox boxUpName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label txtSearchName;
        private System.Windows.Forms.TextBox boxSearchName;
        private System.Windows.Forms.DataGridView dgwData;
    }
}

