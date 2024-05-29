
namespace ProiectMTP
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CourseContainer = new System.Windows.Forms.Panel();
            this.btnPrevSem = new System.Windows.Forms.Button();
            this.btnOngSem = new System.Windows.Forms.Button();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.submenu = new System.Windows.Forms.Panel();
            this.prevSem = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.ongSem = new System.Windows.Forms.Button();
            this.btnAssignments = new System.Windows.Forms.Button();
            this.btnAbt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.meniuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudyYear = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.treeViewCourses = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.CourseContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.submenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(203, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student hub";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.CourseContainer);
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 20);
            this.panel1.TabIndex = 1;
            // 
            // CourseContainer
            // 
            this.CourseContainer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CourseContainer.Controls.Add(this.btnPrevSem);
            this.CourseContainer.Controls.Add(this.btnOngSem);
            this.CourseContainer.Location = new System.Drawing.Point(0, 23);
            this.CourseContainer.Name = "CourseContainer";
            this.CourseContainer.Size = new System.Drawing.Size(200, 54);
            this.CourseContainer.TabIndex = 4;
            // 
            // btnPrevSem
            // 
            this.btnPrevSem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrevSem.FlatAppearance.BorderSize = 0;
            this.btnPrevSem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevSem.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevSem.ForeColor = System.Drawing.Color.White;
            this.btnPrevSem.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevSem.Image")));
            this.btnPrevSem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrevSem.Location = new System.Drawing.Point(0, 89);
            this.btnPrevSem.Name = "btnPrevSem";
            this.btnPrevSem.Size = new System.Drawing.Size(197, 51);
            this.btnPrevSem.TabIndex = 7;
            this.btnPrevSem.Text = "Last Semester";
            this.btnPrevSem.UseVisualStyleBackColor = false;
            // 
            // btnOngSem
            // 
            this.btnOngSem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnOngSem.FlatAppearance.BorderSize = 0;
            this.btnOngSem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOngSem.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOngSem.ForeColor = System.Drawing.Color.White;
            this.btnOngSem.Image = ((System.Drawing.Image)(resources.GetObject("btnOngSem.Image")));
            this.btnOngSem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOngSem.Location = new System.Drawing.Point(0, 44);
            this.btnOngSem.Name = "btnOngSem";
            this.btnOngSem.Size = new System.Drawing.Size(197, 54);
            this.btnOngSem.TabIndex = 6;
            this.btnOngSem.Text = "Ongoing semester";
            this.btnOngSem.UseVisualStyleBackColor = false;
            // 
            // btnHam
            // 
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(12, 0);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(24, 20);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHam.TabIndex = 2;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.sidebar.Controls.Add(this.submenu);
            this.sidebar.Controls.Add(this.btnAssignments);
            this.sidebar.Controls.Add(this.btnAbt);
            this.sidebar.Controls.Add(this.button1);
            this.sidebar.Controls.Add(this.button2);
            this.sidebar.Controls.Add(this.btnLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 20);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(197, 430);
            this.sidebar.TabIndex = 2;
            // 
            // submenu
            // 
            this.submenu.Controls.Add(this.prevSem);
            this.submenu.Controls.Add(this.btnCourses);
            this.submenu.Controls.Add(this.ongSem);
            this.submenu.Location = new System.Drawing.Point(3, 3);
            this.submenu.Name = "submenu";
            this.submenu.Size = new System.Drawing.Size(200, 34);
            this.submenu.TabIndex = 9;
            this.submenu.Paint += new System.Windows.Forms.PaintEventHandler(this.submenu_Paint);
            // 
            // prevSem
            // 
            this.prevSem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.prevSem.FlatAppearance.BorderSize = 0;
            this.prevSem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevSem.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevSem.ForeColor = System.Drawing.Color.White;
            this.prevSem.Image = ((System.Drawing.Image)(resources.GetObject("prevSem.Image")));
            this.prevSem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.prevSem.Location = new System.Drawing.Point(-3, 71);
            this.prevSem.Name = "prevSem";
            this.prevSem.Size = new System.Drawing.Size(197, 33);
            this.prevSem.TabIndex = 6;
            this.prevSem.Text = "Previous Semester";
            this.prevSem.UseVisualStyleBackColor = false;
            this.prevSem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCourses.FlatAppearance.BorderSize = 0;
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourses.ForeColor = System.Drawing.Color.White;
            this.btnCourses.Image = ((System.Drawing.Image)(resources.GetObject("btnCourses.Image")));
            this.btnCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourses.Location = new System.Drawing.Point(-3, -3);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(197, 41);
            this.btnCourses.TabIndex = 5;
            this.btnCourses.Text = "Courses";
            this.btnCourses.UseVisualStyleBackColor = false;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // ongSem
            // 
            this.ongSem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ongSem.FlatAppearance.BorderSize = 0;
            this.ongSem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ongSem.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ongSem.ForeColor = System.Drawing.Color.White;
            this.ongSem.Image = ((System.Drawing.Image)(resources.GetObject("ongSem.Image")));
            this.ongSem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ongSem.Location = new System.Drawing.Point(-3, 39);
            this.ongSem.Name = "ongSem";
            this.ongSem.Size = new System.Drawing.Size(197, 33);
            this.ongSem.TabIndex = 7;
            this.ongSem.Text = "Ongoing Semester";
            this.ongSem.UseVisualStyleBackColor = false;
            this.ongSem.Click += new System.EventHandler(this.ongSem_Click);
            // 
            // btnAssignments
            // 
            this.btnAssignments.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAssignments.FlatAppearance.BorderSize = 0;
            this.btnAssignments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignments.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignments.ForeColor = System.Drawing.Color.White;
            this.btnAssignments.Image = ((System.Drawing.Image)(resources.GetObject("btnAssignments.Image")));
            this.btnAssignments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignments.Location = new System.Drawing.Point(3, 43);
            this.btnAssignments.Name = "btnAssignments";
            this.btnAssignments.Size = new System.Drawing.Size(197, 33);
            this.btnAssignments.TabIndex = 6;
            this.btnAssignments.Text = "Assignments";
            this.btnAssignments.UseVisualStyleBackColor = false;
            this.btnAssignments.Click += new System.EventHandler(this.btnAssignments_Click);
            // 
            // btnAbt
            // 
            this.btnAbt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAbt.FlatAppearance.BorderSize = 0;
            this.btnAbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbt.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbt.ForeColor = System.Drawing.Color.White;
            this.btnAbt.Image = ((System.Drawing.Image)(resources.GetObject("btnAbt.Image")));
            this.btnAbt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbt.Location = new System.Drawing.Point(3, 82);
            this.btnAbt.Name = "btnAbt";
            this.btnAbt.Size = new System.Drawing.Size(197, 33);
            this.btnAbt.TabIndex = 7;
            this.btnAbt.Text = "About";
            this.btnAbt.UseVisualStyleBackColor = false;
            this.btnAbt.Click += new System.EventHandler(this.btnAbt_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Quizzes";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "Grades";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(3, 199);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(197, 33);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // meniuTransition
            // 
            this.meniuTransition.Interval = 10;
            this.meniuTransition.Tick += new System.EventHandler(this.meniuTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(246, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CadetBlue;
            this.label3.Location = new System.Drawing.Point(246, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Department:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CadetBlue;
            this.label4.Location = new System.Drawing.Point(246, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Study Year:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(390, 137);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 16);
            this.lblName.TabIndex = 6;
            // 
            // lblStudyYear
            // 
            this.lblStudyYear.AutoSize = true;
            this.lblStudyYear.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudyYear.Location = new System.Drawing.Point(390, 176);
            this.lblStudyYear.Name = "lblStudyYear";
            this.lblStudyYear.Size = new System.Drawing.Size(0, 16);
            this.lblStudyYear.TabIndex = 7;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(390, 223);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(0, 16);
            this.lblDepartment.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(247, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Your info";
            // 
            // treeViewCourses
            // 
            this.treeViewCourses.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewCourses.Location = new System.Drawing.Point(223, 102);
            this.treeViewCourses.Name = "treeViewCourses";
            this.treeViewCourses.Size = new System.Drawing.Size(540, 236);
            this.treeViewCourses.TabIndex = 10;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeViewCourses);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblStudyYear);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.panel1.ResumeLayout(false);
            this.CourseContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.submenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Panel CourseContainer;
        private System.Windows.Forms.Button btnAssignments;
        private System.Windows.Forms.Button btnAbt;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnPrevSem;
        private System.Windows.Forms.Button btnOngSem;
        private System.Windows.Forms.Timer meniuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel submenu;
        private System.Windows.Forms.Button prevSem;
        private System.Windows.Forms.Button ongSem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudyYear;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TreeView treeViewCourses;
    }
}