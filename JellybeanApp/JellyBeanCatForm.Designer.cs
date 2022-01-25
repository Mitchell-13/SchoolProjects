
namespace MOJellybeanApp
{
    partial class JellyBeanCatForm
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
            this.SuspendLayout();
            // 
            // LVCategory
            // 
            this.LVCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVCategory.HideSelection = false;
            this.LVCategory.Location = new System.Drawing.Point(12, 12);
            this.LVCategory.Name = "LVCategory";
            this.LVCategory.Size = new System.Drawing.Size(415, 507);
            this.LVCategory.TabIndex = 0;
            this.LVCategory.UseCompatibleStateImageBehavior = false;
            this.LVCategory.View = System.Windows.Forms.View.Details;
            // 
            // JellyBeanCatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(439, 531);
            this.Controls.Add(this.LVCategory);
            this.Name = "JellyBeanCatForm";
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.JellyBeanCatForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LVCategory;
    }
}