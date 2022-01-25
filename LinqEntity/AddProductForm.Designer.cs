
namespace MOLinqEntity
{
    partial class AddProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxUOH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBoxPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBoxNew = new System.Windows.Forms.TextBox();
            this.lblNew = new System.Windows.Forms.Label();
            this.CBCategory = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Number";
            // 
            // TxtBoxProd
            // 
            this.TxtBoxProd.Location = new System.Drawing.Point(213, 75);
            this.TxtBoxProd.Name = "TxtBoxProd";
            this.TxtBoxProd.Size = new System.Drawing.Size(319, 27);
            this.TxtBoxProd.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description";
            // 
            // TxtBoxDesc
            // 
            this.TxtBoxDesc.Location = new System.Drawing.Point(213, 121);
            this.TxtBoxDesc.Name = "TxtBoxDesc";
            this.TxtBoxDesc.Size = new System.Drawing.Size(319, 27);
            this.TxtBoxDesc.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Units On Hand";
            // 
            // TxtBoxUOH
            // 
            this.TxtBoxUOH.Location = new System.Drawing.Point(213, 171);
            this.TxtBoxUOH.Name = "TxtBoxUOH";
            this.TxtBoxUOH.Size = new System.Drawing.Size(319, 27);
            this.TxtBoxUOH.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Price";
            // 
            // TxtBoxPrice
            // 
            this.TxtBoxPrice.Location = new System.Drawing.Point(213, 223);
            this.TxtBoxPrice.Name = "TxtBoxPrice";
            this.TxtBoxPrice.Size = new System.Drawing.Size(319, 27);
            this.TxtBoxPrice.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Category";
            // 
            // TxtBoxNew
            // 
            this.TxtBoxNew.Location = new System.Drawing.Point(420, 276);
            this.TxtBoxNew.Name = "TxtBoxNew";
            this.TxtBoxNew.Size = new System.Drawing.Size(112, 27);
            this.TxtBoxNew.TabIndex = 0;
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Location = new System.Drawing.Point(374, 279);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(40, 19);
            this.lblNew.TabIndex = 0;
            this.lblNew.Text = "New";
            // 
            // CBCategory
            // 
            this.CBCategory.FormattingEnabled = true;
            this.CBCategory.Location = new System.Drawing.Point(213, 276);
            this.CBCategory.Name = "CBCategory";
            this.CBCategory.Size = new System.Drawing.Size(145, 27);
            this.CBCategory.TabIndex = 1;
            this.CBCategory.SelectedIndexChanged += new System.EventHandler(this.CBCategory_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(213, 336);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 43);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(395, 336);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 43);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(683, 434);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.CBCategory);
            this.Controls.Add(this.TxtBoxNew);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtBoxPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtBoxUOH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBoxDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBoxProd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBoxUOH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBoxPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtBoxNew;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.ComboBox CBCategory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}