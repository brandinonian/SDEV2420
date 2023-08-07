namespace InvoicesGUI {
    partial class InvoiceGUI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.LeftDisplay = new System.Windows.Forms.RichTextBox();
            this.RightDisplay = new System.Windows.Forms.RichTextBox();
            this.CostBtn = new System.Windows.Forms.RadioButton();
            this.InvIDBtn = new System.Windows.Forms.RadioButton();
            this.LastNameBtn = new System.Windows.Forms.RadioButton();
            this.CustIDBtn = new System.Windows.Forms.RadioButton();
            this.InvoicesByCustomerBtn = new System.Windows.Forms.RadioButton();
            this.InventorySoldBtn = new System.Windows.Forms.RadioButton();
            this.InvoicesBtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // LeftDisplay
            // 
            this.LeftDisplay.Location = new System.Drawing.Point(12, 132);
            this.LeftDisplay.Name = "LeftDisplay";
            this.LeftDisplay.Size = new System.Drawing.Size(376, 491);
            this.LeftDisplay.TabIndex = 0;
            this.LeftDisplay.Text = "";
            // 
            // RightDisplay
            // 
            this.RightDisplay.Location = new System.Drawing.Point(394, 132);
            this.RightDisplay.Name = "RightDisplay";
            this.RightDisplay.Size = new System.Drawing.Size(646, 491);
            this.RightDisplay.TabIndex = 1;
            this.RightDisplay.Text = "";
            // 
            // CostBtn
            // 
            this.CostBtn.AutoSize = true;
            this.CostBtn.Location = new System.Drawing.Point(76, 106);
            this.CostBtn.Name = "CostBtn";
            this.CostBtn.Size = new System.Drawing.Size(128, 20);
            this.CostBtn.TabIndex = 2;
            this.CostBtn.TabStop = true;
            this.CostBtn.Text = "Inventory by cost";
            this.CostBtn.UseVisualStyleBackColor = true;
            this.CostBtn.CheckedChanged += new System.EventHandler(this.CostBtn_CheckedChanged);
            // 
            // InvIDBtn
            // 
            this.InvIDBtn.AutoSize = true;
            this.InvIDBtn.Location = new System.Drawing.Point(76, 80);
            this.InvIDBtn.Name = "InvIDBtn";
            this.InvIDBtn.Size = new System.Drawing.Size(116, 20);
            this.InvIDBtn.TabIndex = 3;
            this.InvIDBtn.TabStop = true;
            this.InvIDBtn.Text = "Inventory by ID";
            this.InvIDBtn.UseVisualStyleBackColor = true;
            this.InvIDBtn.CheckedChanged += new System.EventHandler(this.InvIDBtn_CheckedChanged);
            // 
            // LastNameBtn
            // 
            this.LastNameBtn.AutoSize = true;
            this.LastNameBtn.Location = new System.Drawing.Point(76, 28);
            this.LastNameBtn.Name = "LastNameBtn";
            this.LastNameBtn.Size = new System.Drawing.Size(178, 20);
            this.LastNameBtn.TabIndex = 4;
            this.LastNameBtn.TabStop = true;
            this.LastNameBtn.Text = "Customers by Last Name";
            this.LastNameBtn.UseVisualStyleBackColor = true;
            this.LastNameBtn.CheckedChanged += new System.EventHandler(this.LastNameBtn_CheckedChanged);
            // 
            // CustIDBtn
            // 
            this.CustIDBtn.AutoSize = true;
            this.CustIDBtn.Location = new System.Drawing.Point(76, 54);
            this.CustIDBtn.Name = "CustIDBtn";
            this.CustIDBtn.Size = new System.Drawing.Size(126, 20);
            this.CustIDBtn.TabIndex = 5;
            this.CustIDBtn.TabStop = true;
            this.CustIDBtn.Text = "Customers by ID";
            this.CustIDBtn.UseVisualStyleBackColor = true;
            this.CustIDBtn.CheckedChanged += new System.EventHandler(this.CustIDBtn_CheckedChanged);
            // 
            // InvoicesByCustomerBtn
            // 
            this.InvoicesByCustomerBtn.AutoSize = true;
            this.InvoicesByCustomerBtn.Location = new System.Drawing.Point(416, 106);
            this.InvoicesByCustomerBtn.Name = "InvoicesByCustomerBtn";
            this.InvoicesByCustomerBtn.Size = new System.Drawing.Size(156, 20);
            this.InvoicesByCustomerBtn.TabIndex = 6;
            this.InvoicesByCustomerBtn.TabStop = true;
            this.InvoicesByCustomerBtn.Text = "Invoices by Customer";
            this.InvoicesByCustomerBtn.UseVisualStyleBackColor = true;
            this.InvoicesByCustomerBtn.CheckedChanged += new System.EventHandler(this.InvoicesByCustomerBtn_CheckedChanged);
            // 
            // InventorySoldBtn
            // 
            this.InventorySoldBtn.AutoSize = true;
            this.InventorySoldBtn.Location = new System.Drawing.Point(416, 80);
            this.InventorySoldBtn.Name = "InventorySoldBtn";
            this.InventorySoldBtn.Size = new System.Drawing.Size(113, 20);
            this.InventorySoldBtn.TabIndex = 7;
            this.InventorySoldBtn.TabStop = true;
            this.InventorySoldBtn.Text = "Inventory Sold";
            this.InventorySoldBtn.UseVisualStyleBackColor = true;
            this.InventorySoldBtn.CheckedChanged += new System.EventHandler(this.InventorySoldBtn_CheckedChanged);
            // 
            // InvoicesBtn
            // 
            this.InvoicesBtn.AutoSize = true;
            this.InvoicesBtn.Location = new System.Drawing.Point(416, 54);
            this.InvoicesBtn.Name = "InvoicesBtn";
            this.InvoicesBtn.Size = new System.Drawing.Size(78, 20);
            this.InvoicesBtn.TabIndex = 8;
            this.InvoicesBtn.TabStop = true;
            this.InvoicesBtn.Text = "Invoices";
            this.InvoicesBtn.UseVisualStyleBackColor = true;
            this.InvoicesBtn.CheckedChanged += new System.EventHandler(this.InvoicesBtn_CheckedChanged);
            // 
            // InvoiceGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 635);
            this.Controls.Add(this.InvoicesBtn);
            this.Controls.Add(this.InventorySoldBtn);
            this.Controls.Add(this.InvoicesByCustomerBtn);
            this.Controls.Add(this.CustIDBtn);
            this.Controls.Add(this.LastNameBtn);
            this.Controls.Add(this.InvIDBtn);
            this.Controls.Add(this.CostBtn);
            this.Controls.Add(this.RightDisplay);
            this.Controls.Add(this.LeftDisplay);
            this.Name = "InvoiceGUI";
            this.Text = "Invoices by Brandon Phillips";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox RightDisplay;
        private System.Windows.Forms.RadioButton CostBtn;
        private System.Windows.Forms.RadioButton InvIDBtn;
        private System.Windows.Forms.RadioButton LastNameBtn;
        private System.Windows.Forms.RadioButton CustIDBtn;
        private System.Windows.Forms.RadioButton InvoicesByCustomerBtn;
        private System.Windows.Forms.RadioButton InventorySoldBtn;
        private System.Windows.Forms.RadioButton InvoicesBtn;
        private System.Windows.Forms.RichTextBox LeftDisplay;
    }
}

