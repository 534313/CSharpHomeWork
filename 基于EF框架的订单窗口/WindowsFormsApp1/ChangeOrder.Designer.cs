﻿namespace 结合EF框架的订单窗口
{
	partial class ChangeOrder
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.perpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemTotalPirceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(216, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "客户名";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(328, 81);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 25);
			this.textBox1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(3, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 30);
			this.button1.TabIndex = 2;
			this.button1.Text = "添加商品";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(84, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(84, 30);
			this.button2.TabIndex = 3;
			this.button2.Text = "删除商品";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(508, 304);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "确定";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.button1);
			this.flowLayoutPanel1.Controls.Add(this.button2);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(210, 297);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 33);
			this.flowLayoutPanel1.TabIndex = 5;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNameDataGridViewTextBoxColumn,
            this.itemNumDataGridViewTextBoxColumn,
            this.perpriceDataGridViewTextBoxColumn,
            this.itemTotalPirceDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.itemBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(157, 112);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.Size = new System.Drawing.Size(520, 150);
			this.dataGridView1.TabIndex = 6;
			// 
			// itemNameDataGridViewTextBoxColumn
			// 
			this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
			this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
			this.itemNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
			this.itemNameDataGridViewTextBoxColumn.Width = 125;
			// 
			// itemNumDataGridViewTextBoxColumn
			// 
			this.itemNumDataGridViewTextBoxColumn.DataPropertyName = "ItemNum";
			this.itemNumDataGridViewTextBoxColumn.HeaderText = "ItemNum";
			this.itemNumDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.itemNumDataGridViewTextBoxColumn.Name = "itemNumDataGridViewTextBoxColumn";
			this.itemNumDataGridViewTextBoxColumn.Width = 125;
			// 
			// perpriceDataGridViewTextBoxColumn
			// 
			this.perpriceDataGridViewTextBoxColumn.DataPropertyName = "Perprice";
			this.perpriceDataGridViewTextBoxColumn.HeaderText = "Perprice";
			this.perpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.perpriceDataGridViewTextBoxColumn.Name = "perpriceDataGridViewTextBoxColumn";
			this.perpriceDataGridViewTextBoxColumn.Width = 125;
			// 
			// itemTotalPirceDataGridViewTextBoxColumn
			// 
			this.itemTotalPirceDataGridViewTextBoxColumn.DataPropertyName = "ItemTotalPirce";
			this.itemTotalPirceDataGridViewTextBoxColumn.HeaderText = "ItemTotalPirce";
			this.itemTotalPirceDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.itemTotalPirceDataGridViewTextBoxColumn.Name = "itemTotalPirceDataGridViewTextBoxColumn";
			this.itemTotalPirceDataGridViewTextBoxColumn.ReadOnly = true;
			this.itemTotalPirceDataGridViewTextBoxColumn.Width = 125;
			// 
			// itemBindingSource
			// 
			this.itemBindingSource.DataSource = typeof(结合EF框架的订单窗口.Item);
			// 
			// orderBindingSource
			// 
			this.orderBindingSource.DataSource = typeof(结合EF框架的订单窗口.Order);
			// 
			// ChangeOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "ChangeOrder";
			this.Text = "ChangeOrder";
			this.flowLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource orderBindingSource;
		private System.Windows.Forms.BindingSource itemBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemNumDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn perpriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemTotalPirceDataGridViewTextBoxColumn;
	}
}