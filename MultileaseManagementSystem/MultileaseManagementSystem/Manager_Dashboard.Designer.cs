
namespace MultileaseManagementSystem
{
    partial class Manager_Dashboard
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
            this.label2 = new System.Windows.Forms.Label();
            this.editButton1 = new System.Windows.Forms.Button();
            this.addButton1 = new System.Windows.Forms.Button();
            this.viewButton1 = new System.Windows.Forms.Button();
            this.viodButton1 = new System.Windows.Forms.Button();
            this.TLA_Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Please chose from the following options :";
            // 
            // editButton1
            // 
            this.editButton1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.editButton1.Location = new System.Drawing.Point(46, 116);
            this.editButton1.Name = "editButton1";
            this.editButton1.Size = new System.Drawing.Size(247, 32);
            this.editButton1.TabIndex = 1;
            this.editButton1.Text = "Edit tables";
            this.editButton1.UseVisualStyleBackColor = true;
            // 
            // addButton1
            // 
            this.addButton1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton1.Location = new System.Drawing.Point(46, 65);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(247, 32);
            this.addButton1.TabIndex = 2;
            this.addButton1.Text = "Add to tables";
            this.addButton1.UseVisualStyleBackColor = true;
            // 
            // viewButton1
            // 
            this.viewButton1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.viewButton1.Location = new System.Drawing.Point(46, 164);
            this.viewButton1.Name = "viewButton1";
            this.viewButton1.Size = new System.Drawing.Size(247, 31);
            this.viewButton1.TabIndex = 3;
            this.viewButton1.Text = "View tables";
            this.viewButton1.UseVisualStyleBackColor = true;
            // 
            // viodButton1
            // 
            this.viodButton1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.viodButton1.Location = new System.Drawing.Point(46, 211);
            this.viodButton1.Name = "viodButton1";
            this.viodButton1.Size = new System.Drawing.Size(247, 31);
            this.viodButton1.TabIndex = 4;
            this.viodButton1.Text = "Void payments";
            this.viodButton1.UseVisualStyleBackColor = true;
            // 
            // TLA_Button1
            // 
            this.TLA_Button1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.TLA_Button1.Location = new System.Drawing.Point(46, 261);
            this.TLA_Button1.Name = "TLA_Button1";
            this.TLA_Button1.Size = new System.Drawing.Size(247, 31);
            this.TLA_Button1.TabIndex = 5;
            this.TLA_Button1.Text = "Terminate Lease Agreement";
            this.TLA_Button1.UseVisualStyleBackColor = true;
            this.TLA_Button1.Click += new System.EventHandler(this.button10_Click);
            // 
            // Manager_Dashboard
            // 
            this.ClientSize = new System.Drawing.Size(364, 324);
            this.Controls.Add(this.TLA_Button1);
            this.Controls.Add(this.viodButton1);
            this.Controls.Add(this.viewButton1);
            this.Controls.Add(this.addButton1);
            this.Controls.Add(this.editButton1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.Name = "Manager_Dashboard";
            this.Text = "Manger Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button editButton1;
        private System.Windows.Forms.Button addButton1;
        private System.Windows.Forms.Button viewButton1;
        private System.Windows.Forms.Button viodButton1;
        private System.Windows.Forms.Button TLA_Button1;
    }
}