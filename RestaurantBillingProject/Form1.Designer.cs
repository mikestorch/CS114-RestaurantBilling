namespace RestaurantBillingProject
{
    partial class frmRestaurantBilling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRestaurantBilling));
            this.picBurger = new System.Windows.Forms.PictureBox();
            this.picFries = new System.Windows.Forms.PictureBox();
            this.picDrink = new System.Windows.Forms.PictureBox();
            this.lblBurgerTotal = new System.Windows.Forms.Label();
            this.lblFriesTotal = new System.Windows.Forms.Label();
            this.lblDrinkTotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.btnTip = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTaxLabel = new System.Windows.Forms.Label();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblTipIncluded = new System.Windows.Forms.Label();
            this.lblSubtotalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDollarSign = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBurger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDrink)).BeginInit();
            this.SuspendLayout();
            // 
            // picBurger
            // 
            this.picBurger.Image = ((System.Drawing.Image)(resources.GetObject("picBurger.Image")));
            this.picBurger.Location = new System.Drawing.Point(12, 31);
            this.picBurger.Name = "picBurger";
            this.picBurger.Size = new System.Drawing.Size(80, 80);
            this.picBurger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBurger.TabIndex = 0;
            this.picBurger.TabStop = false;
            this.picBurger.Click += new System.EventHandler(this.picBurger_Click);
            this.picBurger.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBurger_MouseDown);
            this.picBurger.MouseLeave += new System.EventHandler(this.picBurger_MouseLeave);
            this.picBurger.MouseHover += new System.EventHandler(this.picBurger_MouseHover);
            this.picBurger.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBurger_MouseUp);
            // 
            // picFries
            // 
            this.picFries.Image = ((System.Drawing.Image)(resources.GetObject("picFries.Image")));
            this.picFries.Location = new System.Drawing.Point(111, 31);
            this.picFries.Name = "picFries";
            this.picFries.Size = new System.Drawing.Size(80, 80);
            this.picFries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFries.TabIndex = 1;
            this.picFries.TabStop = false;
            this.picFries.Click += new System.EventHandler(this.picFries_Click);
            this.picFries.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picFries_MouseDown);
            this.picFries.MouseLeave += new System.EventHandler(this.picFries_MouseLeave);
            this.picFries.MouseHover += new System.EventHandler(this.picFries_MouseHover);
            this.picFries.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picFries_MouseUp);
            // 
            // picDrink
            // 
            this.picDrink.Image = ((System.Drawing.Image)(resources.GetObject("picDrink.Image")));
            this.picDrink.Location = new System.Drawing.Point(210, 29);
            this.picDrink.Name = "picDrink";
            this.picDrink.Size = new System.Drawing.Size(80, 80);
            this.picDrink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDrink.TabIndex = 2;
            this.picDrink.TabStop = false;
            this.picDrink.Click += new System.EventHandler(this.picDrink_Click);
            this.picDrink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picDrink_MouseDown);
            this.picDrink.MouseLeave += new System.EventHandler(this.picDrink_MouseLeave);
            this.picDrink.MouseHover += new System.EventHandler(this.picDrink_MouseHover);
            this.picDrink.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picDrink_MouseUp);
            // 
            // lblBurgerTotal
            // 
            this.lblBurgerTotal.AutoSize = true;
            this.lblBurgerTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBurgerTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblBurgerTotal.Location = new System.Drawing.Point(41, 121);
            this.lblBurgerTotal.Name = "lblBurgerTotal";
            this.lblBurgerTotal.Size = new System.Drawing.Size(19, 20);
            this.lblBurgerTotal.TabIndex = 3;
            this.lblBurgerTotal.Text = "0";
            // 
            // lblFriesTotal
            // 
            this.lblFriesTotal.AutoSize = true;
            this.lblFriesTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriesTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblFriesTotal.Location = new System.Drawing.Point(142, 121);
            this.lblFriesTotal.Name = "lblFriesTotal";
            this.lblFriesTotal.Size = new System.Drawing.Size(19, 20);
            this.lblFriesTotal.TabIndex = 4;
            this.lblFriesTotal.Text = "0";
            // 
            // lblDrinkTotal
            // 
            this.lblDrinkTotal.AutoSize = true;
            this.lblDrinkTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrinkTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblDrinkTotal.Location = new System.Drawing.Point(243, 121);
            this.lblDrinkTotal.Name = "lblDrinkTotal";
            this.lblDrinkTotal.Size = new System.Drawing.Size(19, 20);
            this.lblDrinkTotal.TabIndex = 5;
            this.lblDrinkTotal.Text = "0";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(179, 171);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(18, 20);
            this.lblSubtotal.TabIndex = 6;
            this.lblSubtotal.Text = "0";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(179, 201);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(18, 20);
            this.lblTax.TabIndex = 7;
            this.lblTax.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(179, 234);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(18, 20);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "0";
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(33, 325);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(85, 20);
            this.txtTip.TabIndex = 2;
            // 
            // btnTip
            // 
            this.btnTip.Location = new System.Drawing.Point(131, 323);
            this.btnTip.Name = "btnTip";
            this.btnTip.Size = new System.Drawing.Size(159, 23);
            this.btnTip.TabIndex = 3;
            this.btnTip.Text = "Add &Tip && Update Total";
            this.btnTip.UseVisualStyleBackColor = true;
            this.btnTip.Click += new System.EventHandler(this.btnTip_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 381);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(215, 381);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTaxLabel
            // 
            this.lblTaxLabel.AutoSize = true;
            this.lblTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxLabel.Location = new System.Drawing.Point(72, 201);
            this.lblTaxLabel.Name = "lblTaxLabel";
            this.lblTaxLabel.Size = new System.Drawing.Size(34, 20);
            this.lblTaxLabel.TabIndex = 14;
            this.lblTaxLabel.Text = "Tax";
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLabel.Location = new System.Drawing.Point(72, 230);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(56, 24);
            this.lblTotalLabel.TabIndex = 15;
            this.lblTotalLabel.Text = "Total";
            // 
            // lblTipIncluded
            // 
            this.lblTipIncluded.AutoSize = true;
            this.lblTipIncluded.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipIncluded.Location = new System.Drawing.Point(107, 282);
            this.lblTipIncluded.Name = "lblTipIncluded";
            this.lblTipIncluded.Size = new System.Drawing.Size(0, 17);
            this.lblTipIncluded.TabIndex = 16;
            // 
            // lblSubtotalLabel
            // 
            this.lblSubtotalLabel.AutoSize = true;
            this.lblSubtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalLabel.Location = new System.Drawing.Point(72, 171);
            this.lblSubtotalLabel.Name = "lblSubtotalLabel";
            this.lblSubtotalLabel.Size = new System.Drawing.Size(74, 20);
            this.lblSubtotalLabel.TabIndex = 17;
            this.lblSubtotalLabel.Text = "Sub-total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(85, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Place an Order!";
            // 
            // lblDollarSign
            // 
            this.lblDollarSign.AutoSize = true;
            this.lblDollarSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDollarSign.Location = new System.Drawing.Point(14, 326);
            this.lblDollarSign.Name = "lblDollarSign";
            this.lblDollarSign.Size = new System.Drawing.Size(16, 17);
            this.lblDollarSign.TabIndex = 19;
            this.lblDollarSign.Text = "$";
            // 
            // frmRestaurantBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 416);
            this.Controls.Add(this.lblDollarSign);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSubtotalLabel);
            this.Controls.Add(this.lblTipIncluded);
            this.Controls.Add(this.lblTotalLabel);
            this.Controls.Add(this.lblTaxLabel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTip);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblDrinkTotal);
            this.Controls.Add(this.lblFriesTotal);
            this.Controls.Add(this.lblBurgerTotal);
            this.Controls.Add(this.picDrink);
            this.Controls.Add(this.picFries);
            this.Controls.Add(this.picBurger);
            this.Name = "frmRestaurantBilling";
            this.Text = "Minamalist Food Shop";
            ((System.ComponentModel.ISupportInitialize)(this.picBurger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDrink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBurger;
        private System.Windows.Forms.PictureBox picFries;
        private System.Windows.Forms.PictureBox picDrink;
        private System.Windows.Forms.Label lblBurgerTotal;
        private System.Windows.Forms.Label lblFriesTotal;
        private System.Windows.Forms.Label lblDrinkTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Button btnTip;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTaxLabel;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblTipIncluded;
        private System.Windows.Forms.Label lblSubtotalLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDollarSign;
    }
}

