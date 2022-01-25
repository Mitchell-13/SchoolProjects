
namespace MOJellybeanApp
{
    partial class JellyBeanSearchForm
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
            this.DgvJellyBeans = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxSearch = new System.Windows.Forms.TextBox();
            this.CBCat = new System.Windows.Forms.ComboBox();
            this.BtnShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvJellyBeans)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvJellyBeans
            // 
            this.DgvJellyBeans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvJellyBeans.Location = new System.Drawing.Point(14, 13);
            this.DgvJellyBeans.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DgvJellyBeans.Name = "DgvJellyBeans";
            this.DgvJellyBeans.Size = new System.Drawing.Size(841, 372);
            this.DgvJellyBeans.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(168, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search:";
            // 
            // TxtBoxSearch
            // 
            this.TxtBoxSearch.Location = new System.Drawing.Point(252, 422);
            this.TxtBoxSearch.Name = "TxtBoxSearch";
            this.TxtBoxSearch.Size = new System.Drawing.Size(233, 26);
            this.TxtBoxSearch.TabIndex = 2;
            this.TxtBoxSearch.TextChanged += new System.EventHandler(this.TxtBoxSearch_TextChanged);
            // 
            // CBCat
            // 
            this.CBCat.FormattingEnabled = true;
            this.CBCat.Location = new System.Drawing.Point(252, 464);
            this.CBCat.Name = "CBCat";
            this.CBCat.Size = new System.Drawing.Size(233, 27);
            this.CBCat.TabIndex = 3;
            this.CBCat.SelectedIndexChanged += new System.EventHandler(this.CBCat_SelectedIndexChanged);
            // 
            // BtnShow
            // 
            this.BtnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnShow.ForeColor = System.Drawing.Color.Black;
            this.BtnShow.Location = new System.Drawing.Point(539, 422);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(207, 26);
            this.BtnShow.TabIndex = 4;
            this.BtnShow.Text = "Show All";
            this.BtnShow.UseVisualStyleBackColor = false;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(85, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filter By Category:";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnClose.ForeColor = System.Drawing.Color.Black;
            this.BtnClose.Location = new System.Drawing.Point(539, 465);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(207, 26);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // JellyBeanSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(869, 528);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.CBCat);
            this.Controls.Add(this.TxtBoxSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvJellyBeans);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "JellyBeanSearchForm";
            this.Text = "Search Form";
            this.Load += new System.EventHandler(this.JellyBeanSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvJellyBeans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvJellyBeans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxSearch;
        private System.Windows.Forms.ComboBox CBCat;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnClose;
    }
}