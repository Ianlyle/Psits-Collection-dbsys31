namespace Final_Project.forms
{
    partial class admindashboard
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
            this.BtnAddEvent = new System.Windows.Forms.Button();
            this.Lbldate = new System.Windows.Forms.Label();
            this.DatagridStudent = new System.Windows.Forms.DataGridView();
            this.TxtNameSearch = new System.Windows.Forms.TextBox();
            this.BtnViewuser = new System.Windows.Forms.Button();
            this.BtnSignout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAddEvent
            // 
            this.BtnAddEvent.Location = new System.Drawing.Point(12, 60);
            this.BtnAddEvent.Name = "BtnAddEvent";
            this.BtnAddEvent.Size = new System.Drawing.Size(114, 36);
            this.BtnAddEvent.TabIndex = 1;
            this.BtnAddEvent.Text = "Add Event";
            this.BtnAddEvent.UseVisualStyleBackColor = true;
            this.BtnAddEvent.Click += new System.EventHandler(this.BtnAddEvent_Click);
            // 
            // Lbldate
            // 
            this.Lbldate.AutoSize = true;
            this.Lbldate.Location = new System.Drawing.Point(602, 24);
            this.Lbldate.Name = "Lbldate";
            this.Lbldate.Size = new System.Drawing.Size(30, 13);
            this.Lbldate.TabIndex = 2;
            this.Lbldate.Text = "Date";
            this.Lbldate.Click += new System.EventHandler(this.Lbldate_Click);
            // 
            // DatagridStudent
            // 
            this.DatagridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridStudent.Location = new System.Drawing.Point(146, 60);
            this.DatagridStudent.Name = "DatagridStudent";
            this.DatagridStudent.Size = new System.Drawing.Size(500, 190);
            this.DatagridStudent.TabIndex = 3;
            this.DatagridStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagridStudent_CellContentClick);
            // 
            // TxtNameSearch
            // 
            this.TxtNameSearch.Location = new System.Drawing.Point(291, 34);
            this.TxtNameSearch.Name = "TxtNameSearch";
            this.TxtNameSearch.Size = new System.Drawing.Size(181, 20);
            this.TxtNameSearch.TabIndex = 4;
            this.TxtNameSearch.TextChanged += new System.EventHandler(this.TxtNameSearch_TextChanged);
            // 
            // BtnViewuser
            // 
            this.BtnViewuser.Location = new System.Drawing.Point(12, 125);
            this.BtnViewuser.Name = "BtnViewuser";
            this.BtnViewuser.Size = new System.Drawing.Size(114, 36);
            this.BtnViewuser.TabIndex = 1;
            this.BtnViewuser.Text = "View Users";
            this.BtnViewuser.UseVisualStyleBackColor = true;
            this.BtnViewuser.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnSignout
            // 
            this.BtnSignout.Location = new System.Drawing.Point(12, 185);
            this.BtnSignout.Name = "BtnSignout";
            this.BtnSignout.Size = new System.Drawing.Size(114, 36);
            this.BtnSignout.TabIndex = 1;
            this.BtnSignout.Text = "Signout";
            this.BtnSignout.UseVisualStyleBackColor = true;
            this.BtnSignout.Click += new System.EventHandler(this.BtnSignout_Click);
            // 
            // admindashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 271);
            this.Controls.Add(this.TxtNameSearch);
            this.Controls.Add(this.DatagridStudent);
            this.Controls.Add(this.Lbldate);
            this.Controls.Add(this.BtnSignout);
            this.Controls.Add(this.BtnViewuser);
            this.Controls.Add(this.BtnAddEvent);
            this.Name = "admindashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admindashboard";
            this.Load += new System.EventHandler(this.admindashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddEvent;
        private System.Windows.Forms.Label Lbldate;
        private System.Windows.Forms.DataGridView DatagridStudent;
        private System.Windows.Forms.TextBox TxtNameSearch;
        private System.Windows.Forms.Button BtnViewuser;
        private System.Windows.Forms.Button BtnSignout;
    }
}