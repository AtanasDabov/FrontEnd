namespace WinFormsApp3
{
    partial class Publisher
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
            Delete = new Button();
            button3 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            OrderItems = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            publisherBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)publisherBindingSource).BeginInit();
            SuspendLayout();
            // 
            // Delete
            // 
            Delete.Location = new Point(351, 116);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 99);
            Delete.TabIndex = 25;
            Delete.Text = "Update";
            Delete.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(251, 116);
            button3.Name = "button3";
            button3.Size = new Size(94, 99);
            button3.TabIndex = 24;
            button3.Text = "Read";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(79, 106);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 113);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 20;
            label3.Text = "Stock";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(79, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 73);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 18;
            label2.Text = "Person";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 24);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 16;
            label1.Text = "Added";
            // 
            // OrderItems
            // 
            OrderItems.Location = new Point(351, 7);
            OrderItems.Name = "OrderItems";
            OrderItems.Size = new Size(94, 99);
            OrderItems.TabIndex = 15;
            OrderItems.Text = "Delete";
            OrderItems.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(251, 7);
            button1.Name = "button1";
            button1.Size = new Size(94, 99);
            button1.TabIndex = 14;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, addedDataGridViewTextBoxColumn, personDataGridViewTextBoxColumn, stockDataGridViewTextBoxColumn });
            dataGridView1.DataSource = publisherBindingSource;
            dataGridView1.Location = new Point(12, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(553, 188);
            dataGridView1.TabIndex = 26;
            // 
            // publisherBindingSource
            // 
            publisherBindingSource.DataSource = typeof(Bookstore.Core.Models.Publisher);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // addedDataGridViewTextBoxColumn
            // 
            addedDataGridViewTextBoxColumn.DataPropertyName = "Added";
            addedDataGridViewTextBoxColumn.HeaderText = "Added";
            addedDataGridViewTextBoxColumn.MinimumWidth = 6;
            addedDataGridViewTextBoxColumn.Name = "addedDataGridViewTextBoxColumn";
            addedDataGridViewTextBoxColumn.Width = 125;
            // 
            // personDataGridViewTextBoxColumn
            // 
            personDataGridViewTextBoxColumn.DataPropertyName = "Person";
            personDataGridViewTextBoxColumn.HeaderText = "Person";
            personDataGridViewTextBoxColumn.MinimumWidth = 6;
            personDataGridViewTextBoxColumn.Name = "personDataGridViewTextBoxColumn";
            personDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            stockDataGridViewTextBoxColumn.MinimumWidth = 6;
            stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            stockDataGridViewTextBoxColumn.Width = 125;
            // 
            // Publisher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(Delete);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(OrderItems);
            Controls.Add(button1);
            Name = "Publisher";
            Text = "Publisher";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)publisherBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Delete;
        private Button button3;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button OrderItems;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private BindingSource publisherBindingSource;
    }
}