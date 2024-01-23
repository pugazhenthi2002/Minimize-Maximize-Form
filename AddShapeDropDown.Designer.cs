namespace WindowsFormsDraft
{
    partial class AddShapeDropDown
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.closeButton = new WindowsFormsDraft.RippleButton();
            this.sizeChangeBtn = new WindowsFormsDraft.RippleButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.closeButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.sizeChangeBtn, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(190, 107);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Gray;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(3, 56);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(184, 48);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "X - Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // sizeChangeBtn
            // 
            this.sizeChangeBtn.BackColor = System.Drawing.Color.Gray;
            this.sizeChangeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizeChangeBtn.FlatAppearance.BorderSize = 0;
            this.sizeChangeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sizeChangeBtn.ForeColor = System.Drawing.Color.White;
            this.sizeChangeBtn.Location = new System.Drawing.Point(3, 3);
            this.sizeChangeBtn.Name = "sizeChangeBtn";
            this.sizeChangeBtn.Size = new System.Drawing.Size(184, 47);
            this.sizeChangeBtn.TabIndex = 2;
            this.sizeChangeBtn.UseVisualStyleBackColor = false;
            this.sizeChangeBtn.Click += new System.EventHandler(this.SizeChangeBtn_Click);
            // 
            // AddShapeDropDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(190, 107);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddShapeDropDown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddShapeDropDown";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RippleButton closeButton;
        private RippleButton sizeChangeBtn;
    }
}