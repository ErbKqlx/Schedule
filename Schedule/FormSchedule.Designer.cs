namespace Schedule_project
{
    partial class FormSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSchedule));
            labelGroup = new Label();
            labelCabinet = new Label();
            labelTeacher = new Label();
            labelDiscipline = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            labelDate = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel2 = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            comboBoxGroups = new ComboBox();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // labelGroup
            // 
            labelGroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelGroup.AutoSize = true;
            labelGroup.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelGroup.Location = new Point(498, 9);
            labelGroup.Margin = new Padding(5, 0, 5, 0);
            labelGroup.Name = "labelGroup";
            labelGroup.Size = new Size(89, 37);
            labelGroup.TabIndex = 0;
            labelGroup.Text = "group";
            labelGroup.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelCabinet
            // 
            labelCabinet.Dock = DockStyle.Bottom;
            labelCabinet.Location = new Point(0, 172);
            labelCabinet.Margin = new Padding(5, 0, 5, 0);
            labelCabinet.Name = "labelCabinet";
            labelCabinet.RightToLeft = RightToLeft.No;
            labelCabinet.Size = new Size(193, 25);
            labelCabinet.TabIndex = 1;
            labelCabinet.Text = "cabinet";
            labelCabinet.TextAlign = ContentAlignment.BottomRight;
            // 
            // labelTeacher
            // 
            labelTeacher.AutoSize = true;
            labelTeacher.Dock = DockStyle.Top;
            labelTeacher.Location = new Point(0, 35);
            labelTeacher.Margin = new Padding(5, 0, 5, 0);
            labelTeacher.MaximumSize = new Size(193, 0);
            labelTeacher.Name = "labelTeacher";
            labelTeacher.Padding = new Padding(0, 0, 0, 10);
            labelTeacher.Size = new Size(75, 35);
            labelTeacher.TabIndex = 3;
            labelTeacher.Text = "teacher";
            // 
            // labelDiscipline
            // 
            labelDiscipline.AutoSize = true;
            labelDiscipline.Dock = DockStyle.Top;
            labelDiscipline.Location = new Point(0, 0);
            labelDiscipline.Margin = new Padding(5, 0, 5, 0);
            labelDiscipline.MaximumSize = new Size(193, 0);
            labelDiscipline.Name = "labelDiscipline";
            labelDiscipline.Padding = new Padding(0, 0, 0, 10);
            labelDiscipline.Size = new Size(92, 35);
            labelDiscipline.TabIndex = 4;
            labelDiscipline.Text = "discipline";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(5, 35);
            flowLayoutPanel1.Margin = new Padding(5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(201, 475);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelCabinet);
            panel1.Controls.Add(labelTeacher);
            panel1.Controls.Add(labelDiscipline);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(195, 199);
            panel1.TabIndex = 0;
            panel1.Visible = false;
            panel1.MouseClick += Panel_MouseClick;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelDate.ImageAlign = ContentAlignment.TopLeft;
            labelDate.Location = new Point(8, 5);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(51, 25);
            labelDate.TabIndex = 9;
            labelDate.Text = "date";
            labelDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(panel2);
            flowLayoutPanel2.Location = new Point(12, 52);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1076, 527);
            flowLayoutPanel2.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(labelDate);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(210, 515);
            panel2.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // comboBoxGroups
            // 
            comboBoxGroups.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxGroups.FormattingEnabled = true;
            comboBoxGroups.Location = new Point(945, 13);
            comboBoxGroups.Name = "comboBoxGroups";
            comboBoxGroups.Size = new Size(143, 33);
            comboBoxGroups.TabIndex = 11;
            // 
            // FormSchedule
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 591);
            Controls.Add(comboBoxGroups);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(labelGroup);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "FormSchedule";
            Text = "Расписание";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGroup;
        private Label labelCabinet;
        private Label labelTeacher;
        private Label labelDiscipline;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label labelDate;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel2;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox comboBoxGroups;
    }
}