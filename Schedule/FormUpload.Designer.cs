namespace Schedule
{
    partial class FormUpload
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
            buttonUpload = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 21);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 0;
            label1.Text = "Загрузить файл:";
            // 
            // buttonUpload
            // 
            buttonUpload.Location = new Point(180, 21);
            buttonUpload.Name = "buttonUpload";
            buttonUpload.Size = new Size(105, 34);
            buttonUpload.TabIndex = 1;
            buttonUpload.Text = "Загрузить";
            buttonUpload.UseVisualStyleBackColor = true;
            buttonUpload.Click += ButtonUpload_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(826, 451);
            dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonUpload);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 67);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(850, 469);
            panel2.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormUpload
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(850, 536);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormUpload";
            Text = "Загрузка файла";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button buttonUpload;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Panel panel2;
        private OpenFileDialog openFileDialog1;
    }
}
