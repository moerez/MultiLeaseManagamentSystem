
namespace MultileaseManagementSystem
{
    partial class Associate
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
            this.viewButton2 = new System.Windows.Forms.Button();
            this.addButton2 = new System.Windows.Forms.Button();
            this.editButton2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // viewButton2
            // 
            this.viewButton2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.viewButton2.Location = new System.Drawing.Point(46, 155);
            this.viewButton2.Name = "viewButton2";
            this.viewButton2.Size = new System.Drawing.Size(247, 34);
            this.viewButton2.TabIndex = 9;
            this.viewButton2.Text = "View tables";
            this.viewButton2.UseVisualStyleBackColor = true;
            // 
            // addButton2
            // 
            this.addButton2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton2.Location = new System.Drawing.Point(46, 59);
            this.addButton2.Name = "addButton2";
            this.addButton2.Size = new System.Drawing.Size(247, 32);
            this.addButton2.TabIndex = 8;
            this.addButton2.Text = "Add to tables";
            this.addButton2.UseVisualStyleBackColor = true;
            // 
            // editButton2
            // 
            this.editButton2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.editButton2.Location = new System.Drawing.Point(46, 107);
            this.editButton2.Name = "editButton2";
            this.editButton2.Size = new System.Drawing.Size(247, 32);
            this.editButton2.TabIndex = 7;
            this.editButton2.Text = "Edit tables";
            this.editButton2.UseVisualStyleBackColor = true;
            this.editButton2.Click += new System.EventHandler(this.editButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Please chose from the following options :";
            // 
            // Associate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 213);
            this.Controls.Add(this.viewButton2);
            this.Controls.Add(this.addButton2);
            this.Controls.Add(this.editButton2);
            this.Controls.Add(this.label2);
            this.Name = "Associate";
            this.Text = "Associate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button viewButton2;
        private System.Windows.Forms.Button addButton2;
        private System.Windows.Forms.Button editButton2;
        private System.Windows.Forms.Label label2;
    }
}