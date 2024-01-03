namespace WinFormsApp3
{
    partial class Stock
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            stockBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            publisherDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isbnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            issnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderItemsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Delete = new Button();
            button3 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            OrderItems = new Button();
            button1 = new Button();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            textBox8 = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stockBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, publisherDataGridViewTextBoxColumn, isbnDataGridViewTextBoxColumn, issnDataGridViewTextBoxColumn, addedDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, orderItemsDataGridViewTextBoxColumn });
            dataGridView1.DataSource = stockBindingSource;
            dataGridView1.Location = new Point(1, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1179, 188);
            dataGridView1.TabIndex = 0;
            // 
            // stockBindingSource
            // 
            stockBindingSource.DataSource = typeof(Bookstore.Core.Models.Stock);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            publisherDataGridViewTextBoxColumn.MinimumWidth = 6;
            publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            publisherDataGridViewTextBoxColumn.Width = 125;
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            isbnDataGridViewTextBoxColumn.DataPropertyName = "Isbn";
            isbnDataGridViewTextBoxColumn.HeaderText = "Isbn";
            isbnDataGridViewTextBoxColumn.MinimumWidth = 6;
            isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            isbnDataGridViewTextBoxColumn.Width = 125;
            // 
            // issnDataGridViewTextBoxColumn
            // 
            issnDataGridViewTextBoxColumn.DataPropertyName = "Issn";
            issnDataGridViewTextBoxColumn.HeaderText = "Issn";
            issnDataGridViewTextBoxColumn.MinimumWidth = 6;
            issnDataGridViewTextBoxColumn.Name = "issnDataGridViewTextBoxColumn";
            issnDataGridViewTextBoxColumn.Width = 125;
            // 
            // addedDataGridViewTextBoxColumn
            // 
            addedDataGridViewTextBoxColumn.DataPropertyName = "Added";
            addedDataGridViewTextBoxColumn.HeaderText = "Added";
            addedDataGridViewTextBoxColumn.MinimumWidth = 6;
            addedDataGridViewTextBoxColumn.Name = "addedDataGridViewTextBoxColumn";
            addedDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderItemsDataGridViewTextBoxColumn
            // 
            orderItemsDataGridViewTextBoxColumn.DataPropertyName = "OrderItems";
            orderItemsDataGridViewTextBoxColumn.HeaderText = "OrderItems";
            orderItemsDataGridViewTextBoxColumn.MinimumWidth = 6;
            orderItemsDataGridViewTextBoxColumn.Name = "orderItemsDataGridViewTextBoxColumn";
            orderItemsDataGridViewTextBoxColumn.Width = 125;
            // 
            // Delete
            // 
            Delete.Location = new Point(631, 121);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 99);
            Delete.TabIndex = 37;
            Delete.Text = "Update";
            Delete.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(531, 121);
            button3.Name = "button3";
            button3.Size = new Size(94, 99);
            button3.TabIndex = 36;
            button3.Text = "Read";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(103, 163);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 170);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 34;
            label4.Text = "Added";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(103, 121);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 128);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 32;
            label3.Text = "Issn";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(103, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 88);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 30;
            label2.Text = "Isbn";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 39);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 28;
            label1.Text = "Publisher";
            // 
            // OrderItems
            // 
            OrderItems.Location = new Point(631, 12);
            OrderItems.Name = "OrderItems";
            OrderItems.Size = new Size(94, 99);
            OrderItems.TabIndex = 27;
            OrderItems.Text = "Delete";
            OrderItems.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(531, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 99);
            button1.TabIndex = 26;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(334, 163);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(251, 170);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 44;
            label5.Text = "OrderItem";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(334, 121);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(251, 128);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 42;
            label6.Text = "Title";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(334, 81);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(251, 88);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 40;
            label7.Text = "Price";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(334, 36);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 27);
            textBox8.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(251, 39);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 38;
            label8.Text = "Quantity";
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 450);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox8);
            Controls.Add(label8);
            Controls.Add(Delete);
            Controls.Add(button3);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(OrderItems);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Stock";
            Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)stockBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn issnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderItemsDataGridViewTextBoxColumn;
        private BindingSource stockBindingSource;
        private Button Delete;
        private Button button3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button OrderItems;
        private Button button1;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox8;
        private Label label8;
    }
}