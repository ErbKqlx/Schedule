namespace Schedule_project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpload));
            buttonUpload = new Button();
            panel1 = new Panel();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonUpload
            // 
            buttonUpload.BackColor = Color.White;
            buttonUpload.FlatStyle = FlatStyle.Flat;
            buttonUpload.Location = new Point(55, 100);
            buttonUpload.Name = "buttonUpload";
            buttonUpload.Size = new Size(167, 40);
            buttonUpload.TabIndex = 1;
            buttonUpload.Text = "Загрузить файл";
            buttonUpload.UseVisualStyleBackColor = false;
            buttonUpload.Click += ButtonUpload_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonUpload);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 251);
            panel1.TabIndex = 3;
            // 
            // FormUpload
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(301, 271);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "FormUpload";
            Padding = new Padding(10);
            Text = "Загрузка файла";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button buttonUpload;
        private Panel panel1;
        private OpenFileDialog openFileDialog1;
    }
}
