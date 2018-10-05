namespace CashRegister
{
    partial class mcdonaldsLite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mcdonaldsLite));
            this.changeAmount = new System.Windows.Forms.Label();
            this.changeTextx = new System.Windows.Forms.Label();
            this.printReciept = new System.Windows.Forms.Button();
            this.calculateChange = new System.Windows.Forms.Button();
            this.paidAmountText = new System.Windows.Forms.Label();
            this.paidAmount = new System.Windows.Forms.TextBox();
            this.totalPrice = new System.Windows.Forms.Label();
            this.taxPrice = new System.Windows.Forms.Label();
            this.subPrice = new System.Windows.Forms.Label();
            this.totalPriceText = new System.Windows.Forms.Label();
            this.taxPriceText = new System.Windows.Forms.Label();
            this.subPriceText = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.calculateTotal = new System.Windows.Forms.Button();
            this.drinksText = new System.Windows.Forms.Label();
            this.friesText = new System.Windows.Forms.Label();
            this.burgerText = new System.Windows.Forms.Label();
            this.numberOfDrinks = new System.Windows.Forms.TextBox();
            this.numberOfFries = new System.Windows.Forms.TextBox();
            this.numberOfBurger = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // changeAmount
            // 
            this.changeAmount.AutoSize = true;
            this.changeAmount.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeAmount.Location = new System.Drawing.Point(122, 440);
            this.changeAmount.Name = "changeAmount";
            this.changeAmount.Size = new System.Drawing.Size(0, 11);
            this.changeAmount.TabIndex = 20;
            // 
            // changeTextx
            // 
            this.changeTextx.AutoSize = true;
            this.changeTextx.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeTextx.Location = new System.Drawing.Point(16, 440);
            this.changeTextx.Name = "changeTextx";
            this.changeTextx.Size = new System.Drawing.Size(54, 11);
            this.changeTextx.TabIndex = 19;
            this.changeTextx.Text = "Change:";
            // 
            // printReciept
            // 
            this.printReciept.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReciept.Location = new System.Drawing.Point(59, 482);
            this.printReciept.Name = "printReciept";
            this.printReciept.Size = new System.Drawing.Size(114, 29);
            this.printReciept.TabIndex = 18;
            this.printReciept.Text = "Print Reciept";
            this.printReciept.UseVisualStyleBackColor = true;
            this.printReciept.Click += new System.EventHandler(this.printReciept_Click);
            // 
            // calculateChange
            // 
            this.calculateChange.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateChange.Location = new System.Drawing.Point(43, 392);
            this.calculateChange.Name = "calculateChange";
            this.calculateChange.Size = new System.Drawing.Size(144, 27);
            this.calculateChange.TabIndex = 15;
            this.calculateChange.Text = "Calculate Change";
            this.calculateChange.UseVisualStyleBackColor = true;
            this.calculateChange.Click += new System.EventHandler(this.calculateChange_Click);
            // 
            // paidAmountText
            // 
            this.paidAmountText.AutoSize = true;
            this.paidAmountText.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidAmountText.Location = new System.Drawing.Point(12, 361);
            this.paidAmountText.Name = "paidAmountText";
            this.paidAmountText.Size = new System.Drawing.Size(68, 11);
            this.paidAmountText.TabIndex = 14;
            this.paidAmountText.Text = "Tendered:";
            // 
            // paidAmount
            // 
            this.paidAmount.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidAmount.Location = new System.Drawing.Point(155, 356);
            this.paidAmount.Name = "paidAmount";
            this.paidAmount.Size = new System.Drawing.Size(63, 18);
            this.paidAmount.TabIndex = 13;
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSize = true;
            this.totalPrice.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.Location = new System.Drawing.Point(122, 283);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(0, 11);
            this.totalPrice.TabIndex = 12;
            // 
            // taxPrice
            // 
            this.taxPrice.AutoSize = true;
            this.taxPrice.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxPrice.Location = new System.Drawing.Point(122, 259);
            this.taxPrice.Name = "taxPrice";
            this.taxPrice.Size = new System.Drawing.Size(0, 11);
            this.taxPrice.TabIndex = 11;
            // 
            // subPrice
            // 
            this.subPrice.AutoSize = true;
            this.subPrice.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subPrice.Location = new System.Drawing.Point(122, 235);
            this.subPrice.Name = "subPrice";
            this.subPrice.Size = new System.Drawing.Size(0, 11);
            this.subPrice.TabIndex = 10;
            // 
            // totalPriceText
            // 
            this.totalPriceText.AutoSize = true;
            this.totalPriceText.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceText.Location = new System.Drawing.Point(15, 283);
            this.totalPriceText.Name = "totalPriceText";
            this.totalPriceText.Size = new System.Drawing.Size(47, 11);
            this.totalPriceText.TabIndex = 9;
            this.totalPriceText.Text = "Total:";
            // 
            // taxPriceText
            // 
            this.taxPriceText.AutoSize = true;
            this.taxPriceText.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxPriceText.Location = new System.Drawing.Point(16, 259);
            this.taxPriceText.Name = "taxPriceText";
            this.taxPriceText.Size = new System.Drawing.Size(33, 11);
            this.taxPriceText.TabIndex = 8;
            this.taxPriceText.Text = "Tax:";
            // 
            // subPriceText
            // 
            this.subPriceText.AutoSize = true;
            this.subPriceText.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subPriceText.Location = new System.Drawing.Point(16, 237);
            this.subPriceText.Name = "subPriceText";
            this.subPriceText.Size = new System.Drawing.Size(75, 11);
            this.subPriceText.TabIndex = 7;
            this.subPriceText.Text = "Sub Price:";
            // 
            // calculateTotal
            // 
            this.calculateTotal.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateTotal.Location = new System.Drawing.Point(59, 180);
            this.calculateTotal.Name = "calculateTotal";
            this.calculateTotal.Size = new System.Drawing.Size(103, 27);
            this.calculateTotal.TabIndex = 6;
            this.calculateTotal.Text = "Calculate Total";
            this.calculateTotal.UseVisualStyleBackColor = true;
            this.calculateTotal.Click += new System.EventHandler(this.calculateTotal_Click);
            // 
            // drinksText
            // 
            this.drinksText.AutoSize = true;
            this.drinksText.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksText.Location = new System.Drawing.Point(16, 133);
            this.drinksText.Name = "drinksText";
            this.drinksText.Size = new System.Drawing.Size(124, 11);
            this.drinksText.TabIndex = 5;
            this.drinksText.Text = "Number of Drinks:";
            // 
            // friesText
            // 
            this.friesText.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friesText.Location = new System.Drawing.Point(16, 84);
            this.friesText.Name = "friesText";
            this.friesText.Size = new System.Drawing.Size(129, 15);
            this.friesText.TabIndex = 4;
            this.friesText.Text = "Number of Fries:";
            // 
            // burgerText
            // 
            this.burgerText.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerText.Location = new System.Drawing.Point(12, 39);
            this.burgerText.Name = "burgerText";
            this.burgerText.Size = new System.Drawing.Size(133, 20);
            this.burgerText.TabIndex = 3;
            this.burgerText.Text = "Number of Burgers:";
            // 
            // numberOfDrinks
            // 
            this.numberOfDrinks.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfDrinks.Location = new System.Drawing.Point(155, 128);
            this.numberOfDrinks.Name = "numberOfDrinks";
            this.numberOfDrinks.Size = new System.Drawing.Size(63, 18);
            this.numberOfDrinks.TabIndex = 2;
            // 
            // numberOfFries
            // 
            this.numberOfFries.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfFries.Location = new System.Drawing.Point(155, 79);
            this.numberOfFries.Name = "numberOfFries";
            this.numberOfFries.Size = new System.Drawing.Size(63, 18);
            this.numberOfFries.TabIndex = 1;
            // 
            // numberOfBurger
            // 
            this.numberOfBurger.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfBurger.Location = new System.Drawing.Point(153, 34);
            this.numberOfBurger.Name = "numberOfBurger";
            this.numberOfBurger.Size = new System.Drawing.Size(65, 18);
            this.numberOfBurger.TabIndex = 0;
            // 
            // mcdonaldsLite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(530, 556);
            this.Controls.Add(this.changeAmount);
            this.Controls.Add(this.changeTextx);
            this.Controls.Add(this.printReciept);
            this.Controls.Add(this.calculateChange);
            this.Controls.Add(this.paidAmountText);
            this.Controls.Add(this.paidAmount);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.taxPrice);
            this.Controls.Add(this.subPrice);
            this.Controls.Add(this.totalPriceText);
            this.Controls.Add(this.taxPriceText);
            this.Controls.Add(this.subPriceText);
            this.Controls.Add(this.calculateTotal);
            this.Controls.Add(this.drinksText);
            this.Controls.Add(this.friesText);
            this.Controls.Add(this.burgerText);
            this.Controls.Add(this.numberOfDrinks);
            this.Controls.Add(this.numberOfFries);
            this.Controls.Add(this.numberOfBurger);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mcdonaldsLite";
            this.Text = "McDonalds Lite";
            this.Shown += new System.EventHandler(this.burgerTim_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label changeAmount;
        private System.Windows.Forms.Label changeTextx;
        private System.Windows.Forms.Button printReciept;
        private System.Windows.Forms.Button calculateChange;
        private System.Windows.Forms.Label paidAmountText;
        private System.Windows.Forms.TextBox paidAmount;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Label taxPrice;
        private System.Windows.Forms.Label subPrice;
        private System.Windows.Forms.Label totalPriceText;
        private System.Windows.Forms.Label taxPriceText;
        private System.Windows.Forms.Label subPriceText;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button calculateTotal;
        private System.Windows.Forms.Label drinksText;
        private System.Windows.Forms.Label friesText;
        private System.Windows.Forms.Label burgerText;
        private System.Windows.Forms.TextBox numberOfDrinks;
        private System.Windows.Forms.TextBox numberOfFries;
        private System.Windows.Forms.TextBox numberOfBurger;
    }
}

