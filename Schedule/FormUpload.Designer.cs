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
            buttonUpload = new Button();
            panel1 = new Panel();
            buttonSave = new Button();
            panel2 = new Panel();
            openFileDialog1 = new OpenFileDialog();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonUpload
            // 
            buttonUpload.BackColor = Color.White;
            buttonUpload.FlatStyle = FlatStyle.Flat;
            buttonUpload.Location = new Point(3, 12);
            buttonUpload.Name = "buttonUpload";
            buttonUpload.Size = new Size(167, 40);
            buttonUpload.TabIndex = 1;
            buttonUpload.Text = "Загрузить файл";
            buttonUpload.UseVisualStyleBackColor = false;
            buttonUpload.Click += ButtonUpload_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonUpload);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(830, 67);
            panel1.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.White;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Location = new Point(176, 12);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(167, 40);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Сохранить файл";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += ButtonSave_Click;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(10, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(830, 449);
            panel2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(824, 440);
            dataGridView1.TabIndex = 0;
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
            Padding = new Padding(10);
            Text = "Загрузка файла";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonUpload;
        private Panel panel1;
        private Panel panel2;
        private OpenFileDialog openFileDialog1;
        private Button buttonSave;
        private DataGridView dataGridView1;
    }
}
