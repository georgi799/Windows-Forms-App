
namespace ProiectMTP
{
    partial class AssignmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignmentForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dragDropPanel = new System.Windows.Forms.Panel();
            this.uploadedFilesList = new System.Windows.Forms.ListBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.dragDropPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 61);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(630, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(100, 33);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "         Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(287, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Assignments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(60, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Available assignments";
            // 
            // dragDropPanel
            // 
            this.dragDropPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dragDropPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dragDropPanel.Controls.Add(this.uploadedFilesList);
            this.dragDropPanel.Location = new System.Drawing.Point(63, 151);
            this.dragDropPanel.Name = "dragDropPanel";
            this.dragDropPanel.Size = new System.Drawing.Size(269, 165);
            this.dragDropPanel.TabIndex = 2;
            this.dragDropPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDropPanel_DragDrop);
            this.dragDropPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragDropPanel_DragEnter);
            // 
            // uploadedFilesList
            // 
            this.uploadedFilesList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uploadedFilesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uploadedFilesList.FormattingEnabled = true;
            this.uploadedFilesList.Location = new System.Drawing.Point(12, 19);
            this.uploadedFilesList.Name = "uploadedFilesList";
            this.uploadedFilesList.Size = new System.Drawing.Size(222, 91);
            this.uploadedFilesList.TabIndex = 3;
            this.uploadedFilesList.Visible = false;
            this.uploadedFilesList.SelectedIndexChanged += new System.EventHandler(this.uploadedFilesList_SelectedIndexChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(222, 348);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // AssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(742, 457);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.dragDropPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AssignmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssignmentForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.dragDropPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel dragDropPanel;
        private System.Windows.Forms.ListBox uploadedFilesList;
        private System.Windows.Forms.Button clearButton;
    }
}