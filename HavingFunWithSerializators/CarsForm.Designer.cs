namespace HavingFunWithSerializators
{
    partial class CarsForm
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
            this.carsDataGridView = new System.Windows.Forms.DataGridView();
            this.saveAllButton = new System.Windows.Forms.Button();
            this.saveToLoadFromDialog = new System.Windows.Forms.OpenFileDialog();
            this.serializerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.refreshSerializersButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loadFromButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // carsDataGridView
            // 
            this.carsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.carsDataGridView.Name = "carsDataGridView";
            this.carsDataGridView.Size = new System.Drawing.Size(555, 277);
            this.carsDataGridView.TabIndex = 0;
            // 
            // saveAllButton
            // 
            this.saveAllButton.Location = new System.Drawing.Point(58, 325);
            this.saveAllButton.Name = "saveAllButton";
            this.saveAllButton.Size = new System.Drawing.Size(131, 23);
            this.saveAllButton.TabIndex = 1;
            this.saveAllButton.Text = "Save All";
            this.saveAllButton.UseVisualStyleBackColor = true;
            this.saveAllButton.Click += new System.EventHandler(this.saveAllButton_Click);
            // 
            // saveToLoadFromDialog
            // 
            this.saveToLoadFromDialog.FileName = "saveToFileDialog";
            // 
            // serializerTypeComboBox
            // 
            this.serializerTypeComboBox.FormattingEnabled = true;
            this.serializerTypeComboBox.Location = new System.Drawing.Point(401, 325);
            this.serializerTypeComboBox.Name = "serializerTypeComboBox";
            this.serializerTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.serializerTypeComboBox.TabIndex = 2;
            // 
            // refreshSerializersButton
            // 
            this.refreshSerializersButton.Location = new System.Drawing.Point(401, 352);
            this.refreshSerializersButton.Name = "refreshSerializersButton";
            this.refreshSerializersButton.Size = new System.Drawing.Size(121, 23);
            this.refreshSerializersButton.TabIndex = 3;
            this.refreshSerializersButton.Text = "Refresh options";
            this.refreshSerializersButton.UseVisualStyleBackColor = true;
            this.refreshSerializersButton.Click += new System.EventHandler(this.refreshSerializersButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Save As options:";
            // 
            // loadFromButton
            // 
            this.loadFromButton.Location = new System.Drawing.Point(58, 354);
            this.loadFromButton.Name = "loadFromButton";
            this.loadFromButton.Size = new System.Drawing.Size(131, 23);
            this.loadFromButton.TabIndex = 5;
            this.loadFromButton.Text = "Load From";
            this.loadFromButton.UseVisualStyleBackColor = true;
            this.loadFromButton.Click += new System.EventHandler(this.loadFromButton_Click);
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 420);
            this.Controls.Add(this.loadFromButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshSerializersButton);
            this.Controls.Add(this.serializerTypeComboBox);
            this.Controls.Add(this.saveAllButton);
            this.Controls.Add(this.carsDataGridView);
            this.Name = "CarsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CarsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView carsDataGridView;
        private System.Windows.Forms.Button saveAllButton;
        private System.Windows.Forms.OpenFileDialog saveToLoadFromDialog;
        private System.Windows.Forms.ComboBox serializerTypeComboBox;
        private System.Windows.Forms.Button refreshSerializersButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loadFromButton;
    }
}

