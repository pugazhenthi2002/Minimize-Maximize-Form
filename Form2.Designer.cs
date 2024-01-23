namespace WindowsFormsDraft
{
    partial class Form2
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
            this.rippleButton4 = new WindowsFormsDraft.RippleButton();
            this.rippleButton3 = new WindowsFormsDraft.RippleButton();
            this.rippleButton2 = new WindowsFormsDraft.RippleButton();
            this.rippleButton1 = new WindowsFormsDraft.RippleButton();
            this.SuspendLayout();
            // 
            // rippleButton4
            // 
            this.rippleButton4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rippleButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rippleButton4.Location = new System.Drawing.Point(487, 266);
            this.rippleButton4.Name = "rippleButton4";
            this.rippleButton4.Size = new System.Drawing.Size(150, 100);
            this.rippleButton4.TabIndex = 3;
            this.rippleButton4.UseVisualStyleBackColor = false;
            this.rippleButton4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.rippleButton4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnFormMouseUp);
            // 
            // rippleButton3
            // 
            this.rippleButton3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rippleButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rippleButton3.Location = new System.Drawing.Point(487, 160);
            this.rippleButton3.Name = "rippleButton3";
            this.rippleButton3.Size = new System.Drawing.Size(150, 100);
            this.rippleButton3.TabIndex = 2;
            this.rippleButton3.UseVisualStyleBackColor = false;
            this.rippleButton3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.rippleButton3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnFormMouseUp);
            // 
            // rippleButton2
            // 
            this.rippleButton2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rippleButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rippleButton2.Location = new System.Drawing.Point(321, 160);
            this.rippleButton2.Name = "rippleButton2";
            this.rippleButton2.Size = new System.Drawing.Size(150, 100);
            this.rippleButton2.TabIndex = 1;
            this.rippleButton2.UseVisualStyleBackColor = false;
            this.rippleButton2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.rippleButton2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnFormMouseUp);
            // 
            // rippleButton1
            // 
            this.rippleButton1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rippleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rippleButton1.Location = new System.Drawing.Point(321, 266);
            this.rippleButton1.Name = "rippleButton1";
            this.rippleButton1.Size = new System.Drawing.Size(150, 100);
            this.rippleButton1.TabIndex = 0;
            this.rippleButton1.UseVisualStyleBackColor = false;
            this.rippleButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.rippleButton1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnFormMouseUp);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.rippleButton4);
            this.Controls.Add(this.rippleButton3);
            this.Controls.Add(this.rippleButton2);
            this.Controls.Add(this.rippleButton1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnFormMouseUp);
            this.Move += new System.EventHandler(this.Form2_Move);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private RippleButton rippleButton1;
        private RippleButton rippleButton2;
        private RippleButton rippleButton3;
        private RippleButton rippleButton4;
    }
}