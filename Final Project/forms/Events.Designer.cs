namespace Final_Project
{
    partial class Events
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Events));
            this.TxtEventname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDate = new System.Windows.Forms.TextBox();
            this.Dgevent = new System.Windows.Forms.DataGridView();
            this.BtnADD = new System.Windows.Forms.Button();
            this.BtnEDIT = new System.Windows.Forms.Button();
            this.BtnDELETE = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgevent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtEventname
            // 
            this.TxtEventname.Location = new System.Drawing.Point(96, 60);
            this.TxtEventname.Name = "TxtEventname";
            this.TxtEventname.Size = new System.Drawing.Size(146, 20);
            this.TxtEventname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Event Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            // 
            // TxtDate
            // 
            this.TxtDate.Location = new System.Drawing.Point(96, 108);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(146, 20);
            this.TxtDate.TabIndex = 4;
            // 
            // Dgevent
            // 
            this.Dgevent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgevent.Location = new System.Drawing.Point(274, 29);
            this.Dgevent.Name = "Dgevent";
            this.Dgevent.Size = new System.Drawing.Size(380, 278);
            this.Dgevent.TabIndex = 5;
            this.Dgevent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgevent_CellContentClick);
            // 
            // BtnADD
            // 
            this.BtnADD.Location = new System.Drawing.Point(15, 209);
            this.BtnADD.Name = "BtnADD";
            this.BtnADD.Size = new System.Drawing.Size(75, 23);
            this.BtnADD.TabIndex = 6;
            this.BtnADD.Text = "Add";
            this.BtnADD.UseVisualStyleBackColor = true;
            this.BtnADD.Click += new System.EventHandler(this.BtnADD_Click);
            // 
            // BtnEDIT
            // 
            this.BtnEDIT.Location = new System.Drawing.Point(96, 209);
            this.BtnEDIT.Name = "BtnEDIT";
            this.BtnEDIT.Size = new System.Drawing.Size(75, 23);
            this.BtnEDIT.TabIndex = 7;
            this.BtnEDIT.Text = "Edit ";
            this.BtnEDIT.UseVisualStyleBackColor = true;
            this.BtnEDIT.Click += new System.EventHandler(this.BtnEDIT_Click);
            // 
            // BtnDELETE
            // 
            this.BtnDELETE.Location = new System.Drawing.Point(177, 209);
            this.BtnDELETE.Name = "BtnDELETE";
            this.BtnDELETE.Size = new System.Drawing.Size(75, 23);
            this.BtnDELETE.TabIndex = 8;
            this.BtnDELETE.Text = "Delete Event";
            this.BtnDELETE.UseVisualStyleBackColor = true;
            this.BtnDELETE.Click += new System.EventHandler(this.BtnDELETE_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Amount";
            // 
            // TxtAmount
            // 
            this.TxtAmount.Location = new System.Drawing.Point(96, 158);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(146, 20);
            this.TxtAmount.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BtnBack
            // 
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.Location = new System.Drawing.Point(12, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(43, 29);
            this.BtnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnBack.TabIndex = 9;
            this.BtnBack.TabStop = false;
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 319);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnDELETE);
            this.Controls.Add(this.BtnEDIT);
            this.Controls.Add(this.BtnADD);
            this.Controls.Add(this.Dgevent);
            this.Controls.Add(this.TxtAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtEventname);
            this.Name = "Events";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events";
            this.Load += new System.EventHandler(this.Events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgevent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEventname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDate;
        private System.Windows.Forms.DataGridView Dgevent;
        private System.Windows.Forms.Button BtnADD;
        private System.Windows.Forms.Button BtnEDIT;
        private System.Windows.Forms.Button BtnDELETE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox BtnBack;
    }
}