partial class frmMain
{
    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
            this.txtPizzaSize = new System.Windows.Forms.TextBox();
            this.txtToppings = new System.Windows.Forms.TextBox();
            this.txtDelivery = new System.Windows.Forms.TextBox();
            this.lblPizzaSize = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPizzaSize
            // 
            this.txtPizzaSize.Location = new System.Drawing.Point(172, 13);
            this.txtPizzaSize.Name = "txtPizzaSize";
            this.txtPizzaSize.Size = new System.Drawing.Size(100, 20);
            this.txtPizzaSize.TabIndex = 0;
            // 
            // txtToppings
            // 
            this.txtToppings.Location = new System.Drawing.Point(172, 40);
            this.txtToppings.Name = "txtToppings";
            this.txtToppings.Size = new System.Drawing.Size(100, 20);
            this.txtToppings.TabIndex = 1;
            // 
            // txtDelivery
            // 
            this.txtDelivery.Location = new System.Drawing.Point(172, 66);
            this.txtDelivery.Name = "txtDelivery";
            this.txtDelivery.Size = new System.Drawing.Size(100, 20);
            this.txtDelivery.TabIndex = 2;
            // 
            // lblPizzaSize
            // 
            this.lblPizzaSize.AutoSize = true;
            this.lblPizzaSize.Location = new System.Drawing.Point(12, 20);
            this.lblPizzaSize.Name = "lblPizzaSize";
            this.lblPizzaSize.Size = new System.Drawing.Size(99, 13);
            this.lblPizzaSize.TabIndex = 3;
            this.lblPizzaSize.Text = "Pizza size (S, M, L):";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point(13, 46);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(147, 13);
            this.lblToppings.TabIndex = 4;
            this.lblToppings.Text = "Number of additional toppings";
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Location = new System.Drawing.Point(13, 72);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(88, 13);
            this.lblDelivery.TabIndex = 5;
            this.lblDelivery.Text = "Is this a delivery?";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(13, 155);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(57, 13);
            this.lblTotalCost.TabIndex = 6;
            this.lblTotalCost.Text = "Total cost:";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(172, 147);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCost.TabIndex = 7;
            this.txtTotalCost.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(13, 202);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(197, 202);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(105, 202);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(284, 239);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblDelivery);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.lblPizzaSize);
            this.Controls.Add(this.txtDelivery);
            this.Controls.Add(this.txtToppings);
            this.Controls.Add(this.txtPizzaSize);
            this.Name = "frmMain";
            this.Text = "Pizza Order";
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    #endregion

    private System.Windows.Forms.TextBox txtPizzaSize;
    private System.Windows.Forms.TextBox txtToppings;
    private System.Windows.Forms.TextBox txtDelivery;
    private System.Windows.Forms.Label lblPizzaSize;
    private System.Windows.Forms.Label lblToppings;
    private System.Windows.Forms.Label lblDelivery;
    private System.Windows.Forms.Label lblTotalCost;
    private System.Windows.Forms.TextBox txtTotalCost;
    private System.Windows.Forms.Button btnCalculate;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnClear;
}