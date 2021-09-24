
namespace dragAndDrop
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picB2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picB1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picB2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picB1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picB2
            // 
            this.picB2.Location = new System.Drawing.Point(57, 71);
            this.picB2.Name = "picB2";
            this.picB2.Size = new System.Drawing.Size(265, 167);
            this.picB2.TabIndex = 0;
            this.picB2.TabStop = false;
            this.picB2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picB2_MouseDown);
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.picB2);
            this.panel2.Location = new System.Drawing.Point(430, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 308);
            this.panel2.TabIndex = 1;
            this.panel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel2_DragDrop);
            this.panel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel2_DragEnter);
            // 
            // picB1
            // 
            this.picB1.Image = ((System.Drawing.Image)(resources.GetObject("picB1.Image")));
            this.picB1.Location = new System.Drawing.Point(45, 71);
            this.picB1.Name = "picB1";
            this.picB1.Size = new System.Drawing.Size(261, 167);
            this.picB1.TabIndex = 0;
            this.picB1.TabStop = false;
            this.picB1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picB1_MouseDown);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.picB1);
            this.panel1.Location = new System.Drawing.Point(22, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 308);
            this.panel1.TabIndex = 2;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picB2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picB1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picB2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picB1;
        private System.Windows.Forms.Panel panel1;
    }
}

