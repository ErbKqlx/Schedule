namespace Schedule_project
{
    partial class FormErrors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormErrors));
            dataGridViewErrors = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewErrors).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewErrors
            // 
            dataGridViewErrors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewErrors.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewErrors.BackgroundColor = Color.White;
            dataGridViewErrors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewErrors.Dock = DockStyle.Fill;
            dataGridViewErrors.Location = new Point(15, 15);
            dataGridViewErrors.Name = "dataGridViewErrors";
            dataGridViewErrors.ReadOnly = true;
            dataGridViewErrors.Size = new Size(905, 484);
            dataGridViewErrors.TabIndex = 0;
            // 
            // FormErrors
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(935, 514);
            Controls.Add(dataGridViewErrors);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "FormErrors";
            Padding = new Padding(15);
            Text = "Ошибки";
            ((System.ComponentModel.ISupportInitialize)dataGridViewErrors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewErrors;
    }
}