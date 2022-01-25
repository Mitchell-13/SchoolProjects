
namespace MOLinqEntity
{
    partial class CategoryForm
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
            this.LVCategory = new System.Windows.Forms.ListView();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LVCategory
            // 
            this.LVCategory.HideSelection = false;
            this.LVCategory.Location = new System.Drawing.Point(12, 12);
            this.LVCategory.Name = "LVCategory";
            this.LVCategory.Size = new System.Drawing.Size(277, 267);
            this.LVCategory.TabIndex = 0;
            this.LVCategory.UseCompatibleStateImageBehavior = false;
            this.LVCategory.View = System.Windows.Forms.View.Details;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Maroon;
            this.BtnClose.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnClose.Location = new System.Drawing.Point(12, 285);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(277, 56);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 351);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LVCategory);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LVCategory;
        private System.Windows.Forms.Button BtnClose;
    }
}