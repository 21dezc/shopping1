namespace Shoppingcart21
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GBeverage = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            tbGreenTeaQuantity = new TextBox();
            tbCoffeeQuantity = new TextBox();
            tbGreenTeaPrice = new TextBox();
            tbCoffeePrice = new TextBox();
            cbGreenTea = new CheckBox();
            cbCoffee = new CheckBox();
            GFood = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            label7 = new Label();
            label6 = new Label();
            tbPizzaQuantity = new TextBox();
            tbNoodleQuantity = new TextBox();
            tbPizzaPrice = new TextBox();
            tbNoodlePrice = new TextBox();
            cbPizza = new CheckBox();
            cbNoodle = new CheckBox();
            GDiscount = new GroupBox();
            label3 = new Label();
            label1 = new Label();
            tbDiscountFood = new TextBox();
            cbFood = new CheckBox();
            tbDiscountDrinks = new TextBox();
            tbDiscountAll = new TextBox();
            cbBeverage = new CheckBox();
            cbAll = new CheckBox();
            label2 = new Label();
            lbTotal = new Label();
            lb50 = new Label();
            lb100 = new Label();
            lb500 = new Label();
            lb1000 = new Label();
            lbChange = new Label();
            lbCash = new Label();
            lb20 = new Label();
            lb10 = new Label();
            lb5 = new Label();
            lb1 = new Label();
            tbTotal = new TextBox();
            tbCash = new TextBox();
            tbChange = new TextBox();
            tb100 = new TextBox();
            tb500 = new TextBox();
            tb1000 = new TextBox();
            tb1 = new TextBox();
            tb5 = new TextBox();
            tb10 = new TextBox();
            tb20 = new TextBox();
            tb50 = new TextBox();
            btClear = new Button();
            btcheck_out = new Button();
            tbDiscountAmount = new TextBox();
            label12 = new Label();
            GBeverage.SuspendLayout();
            GFood.SuspendLayout();
            GDiscount.SuspendLayout();
            SuspendLayout();
            // 
            // GBeverage
            // 
            GBeverage.Controls.Add(label9);
            GBeverage.Controls.Add(label8);
            GBeverage.Controls.Add(label5);
            GBeverage.Controls.Add(label4);
            GBeverage.Controls.Add(tbGreenTeaQuantity);
            GBeverage.Controls.Add(tbCoffeeQuantity);
            GBeverage.Controls.Add(tbGreenTeaPrice);
            GBeverage.Controls.Add(tbCoffeePrice);
            GBeverage.Controls.Add(cbGreenTea);
            GBeverage.Controls.Add(cbCoffee);
            GBeverage.Location = new Point(42, 47);
            GBeverage.Name = "GBeverage";
            GBeverage.Size = new Size(427, 140);
            GBeverage.TabIndex = 0;
            GBeverage.TabStop = false;
            GBeverage.Text = "Beverage";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(311, 70);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 34;
            label9.Text = "Quantity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(311, 13);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 33;
            label8.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(173, 66);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 6;
            label5.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(173, 11);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 5;
            label4.Text = "Price";
            // 
            // tbGreenTeaQuantity
            // 
            tbGreenTeaQuantity.Location = new Point(282, 93);
            tbGreenTeaQuantity.Name = "tbGreenTeaQuantity";
            tbGreenTeaQuantity.Size = new Size(125, 27);
            tbGreenTeaQuantity.TabIndex = 4;
            // 
            // tbCoffeeQuantity
            // 
            tbCoffeeQuantity.Location = new Point(282, 36);
            tbCoffeeQuantity.Name = "tbCoffeeQuantity";
            tbCoffeeQuantity.Size = new Size(125, 27);
            tbCoffeeQuantity.TabIndex = 3;
            // 
            // tbGreenTeaPrice
            // 
            tbGreenTeaPrice.Location = new Point(139, 94);
            tbGreenTeaPrice.Name = "tbGreenTeaPrice";
            tbGreenTeaPrice.Size = new Size(125, 27);
            tbGreenTeaPrice.TabIndex = 2;
            // 
            // tbCoffeePrice
            // 
            tbCoffeePrice.Location = new Point(139, 36);
            tbCoffeePrice.Name = "tbCoffeePrice";
            tbCoffeePrice.Size = new Size(125, 27);
            tbCoffeePrice.TabIndex = 1;
            // 
            // cbGreenTea
            // 
            cbGreenTea.AutoSize = true;
            cbGreenTea.Location = new Point(11, 96);
            cbGreenTea.Name = "cbGreenTea";
            cbGreenTea.Size = new Size(97, 24);
            cbGreenTea.TabIndex = 1;
            cbGreenTea.Text = "Green Tea";
            cbGreenTea.UseVisualStyleBackColor = true;
            // 
            // cbCoffee
            // 
            cbCoffee.AutoSize = true;
            cbCoffee.Location = new Point(11, 36);
            cbCoffee.Name = "cbCoffee";
            cbCoffee.Size = new Size(75, 24);
            cbCoffee.TabIndex = 0;
            cbCoffee.Text = "Coffee";
            cbCoffee.UseVisualStyleBackColor = true;
            // 
            // GFood
            // 
            GFood.Controls.Add(label11);
            GFood.Controls.Add(label10);
            GFood.Controls.Add(label7);
            GFood.Controls.Add(label6);
            GFood.Controls.Add(tbPizzaQuantity);
            GFood.Controls.Add(tbNoodleQuantity);
            GFood.Controls.Add(tbPizzaPrice);
            GFood.Controls.Add(tbNoodlePrice);
            GFood.Controls.Add(cbPizza);
            GFood.Controls.Add(cbNoodle);
            GFood.Location = new Point(42, 193);
            GFood.Name = "GFood";
            GFood.Size = new Size(427, 158);
            GFood.TabIndex = 5;
            GFood.TabStop = false;
            GFood.Text = "Food";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(311, 73);
            label11.Name = "label11";
            label11.Size = new Size(65, 20);
            label11.TabIndex = 35;
            label11.Text = "Quantity";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(311, 13);
            label10.Name = "label10";
            label10.Size = new Size(65, 20);
            label10.TabIndex = 34;
            label10.Text = "Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(173, 73);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 7;
            label7.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(173, 13);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 6;
            label6.Text = "Price";
            // 
            // tbPizzaQuantity
            // 
            tbPizzaQuantity.Location = new Point(282, 100);
            tbPizzaQuantity.Name = "tbPizzaQuantity";
            tbPizzaQuantity.Size = new Size(125, 27);
            tbPizzaQuantity.TabIndex = 4;
            // 
            // tbNoodleQuantity
            // 
            tbNoodleQuantity.Location = new Point(282, 36);
            tbNoodleQuantity.Name = "tbNoodleQuantity";
            tbNoodleQuantity.Size = new Size(125, 27);
            tbNoodleQuantity.TabIndex = 3;
            // 
            // tbPizzaPrice
            // 
            tbPizzaPrice.Location = new Point(139, 100);
            tbPizzaPrice.Name = "tbPizzaPrice";
            tbPizzaPrice.Size = new Size(125, 27);
            tbPizzaPrice.TabIndex = 2;
            // 
            // tbNoodlePrice
            // 
            tbNoodlePrice.Location = new Point(139, 36);
            tbNoodlePrice.Name = "tbNoodlePrice";
            tbNoodlePrice.Size = new Size(125, 27);
            tbNoodlePrice.TabIndex = 1;
            // 
            // cbPizza
            // 
            cbPizza.AutoSize = true;
            cbPizza.Location = new Point(11, 103);
            cbPizza.Name = "cbPizza";
            cbPizza.Size = new Size(65, 24);
            cbPizza.TabIndex = 1;
            cbPizza.Text = "Pizza";
            cbPizza.UseVisualStyleBackColor = true;
            // 
            // cbNoodle
            // 
            cbNoodle.AutoSize = true;
            cbNoodle.Location = new Point(11, 36);
            cbNoodle.Name = "cbNoodle";
            cbNoodle.Size = new Size(81, 24);
            cbNoodle.TabIndex = 0;
            cbNoodle.Text = "Noodle";
            cbNoodle.UseVisualStyleBackColor = true;
            // 
            // GDiscount
            // 
            GDiscount.Controls.Add(label3);
            GDiscount.Controls.Add(label1);
            GDiscount.Controls.Add(tbDiscountFood);
            GDiscount.Controls.Add(cbFood);
            GDiscount.Controls.Add(tbDiscountDrinks);
            GDiscount.Controls.Add(tbDiscountAll);
            GDiscount.Controls.Add(cbBeverage);
            GDiscount.Controls.Add(cbAll);
            GDiscount.Controls.Add(label2);
            GDiscount.Location = new Point(42, 357);
            GDiscount.Name = "GDiscount";
            GDiscount.Size = new Size(427, 158);
            GDiscount.TabIndex = 5;
            GDiscount.TabStop = false;
            GDiscount.Text = "Discount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(399, 124);
            label3.Name = "label3";
            label3.Size = new Size(21, 20);
            label3.TabIndex = 9;
            label3.Text = "%";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(399, 29);
            label1.Name = "label1";
            label1.Size = new Size(21, 20);
            label1.TabIndex = 6;
            label1.Text = "%";
            // 
            // tbDiscountFood
            // 
            tbDiscountFood.Location = new Point(268, 117);
            tbDiscountFood.Name = "tbDiscountFood";
            tbDiscountFood.Size = new Size(125, 27);
            tbDiscountFood.TabIndex = 7;
            // 
            // cbFood
            // 
            cbFood.AutoSize = true;
            cbFood.Location = new Point(11, 117);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(65, 24);
            cbFood.TabIndex = 5;
            cbFood.Text = "Food";
            cbFood.UseVisualStyleBackColor = true;
            // 
            // tbDiscountDrinks
            // 
            tbDiscountDrinks.Location = new Point(268, 74);
            tbDiscountDrinks.Name = "tbDiscountDrinks";
            tbDiscountDrinks.Size = new Size(125, 27);
            tbDiscountDrinks.TabIndex = 4;
            // 
            // tbDiscountAll
            // 
            tbDiscountAll.Location = new Point(268, 22);
            tbDiscountAll.Name = "tbDiscountAll";
            tbDiscountAll.Size = new Size(125, 27);
            tbDiscountAll.TabIndex = 3;
            // 
            // cbBeverage
            // 
            cbBeverage.AutoSize = true;
            cbBeverage.Location = new Point(11, 77);
            cbBeverage.Name = "cbBeverage";
            cbBeverage.Size = new Size(93, 24);
            cbBeverage.TabIndex = 1;
            cbBeverage.Text = "Beverage";
            cbBeverage.UseVisualStyleBackColor = true;
            // 
            // cbAll
            // 
            cbAll.AutoSize = true;
            cbAll.Location = new Point(11, 36);
            cbAll.Name = "cbAll";
            cbAll.Size = new Size(49, 24);
            cbAll.TabIndex = 0;
            cbAll.Text = "All";
            cbAll.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(400, 78);
            label2.Name = "label2";
            label2.Size = new Size(21, 20);
            label2.TabIndex = 8;
            label2.Text = "%";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(668, 112);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(42, 20);
            lbTotal.TabIndex = 10;
            lbTotal.Text = "Total";
            // 
            // lb50
            // 
            lb50.AutoSize = true;
            lb50.Location = new Point(668, 347);
            lb50.Name = "lb50";
            lb50.Size = new Size(25, 20);
            lb50.TabIndex = 11;
            lb50.Text = "50";
            // 
            // lb100
            // 
            lb100.AutoSize = true;
            lb100.Location = new Point(668, 300);
            lb100.Name = "lb100";
            lb100.Size = new Size(33, 20);
            lb100.TabIndex = 12;
            lb100.Text = "100";
            // 
            // lb500
            // 
            lb500.AutoSize = true;
            lb500.Location = new Point(668, 263);
            lb500.Name = "lb500";
            lb500.Size = new Size(33, 20);
            lb500.TabIndex = 13;
            lb500.Text = "500";
            // 
            // lb1000
            // 
            lb1000.AutoSize = true;
            lb1000.Location = new Point(668, 222);
            lb1000.Name = "lb1000";
            lb1000.Size = new Size(41, 20);
            lb1000.TabIndex = 14;
            lb1000.Text = "1000";
            // 
            // lbChange
            // 
            lbChange.AutoSize = true;
            lbChange.Location = new Point(668, 183);
            lbChange.Name = "lbChange";
            lbChange.Size = new Size(59, 20);
            lbChange.TabIndex = 15;
            lbChange.Text = "Change";
            // 
            // lbCash
            // 
            lbCash.AutoSize = true;
            lbCash.Location = new Point(668, 73);
            lbCash.Name = "lbCash";
            lbCash.Size = new Size(40, 20);
            lbCash.TabIndex = 16;
            lbCash.Text = "Cash";
            // 
            // lb20
            // 
            lb20.AutoSize = true;
            lb20.Location = new Point(668, 386);
            lb20.Name = "lb20";
            lb20.Size = new Size(25, 20);
            lb20.TabIndex = 17;
            lb20.Text = "20";
            // 
            // lb10
            // 
            lb10.AutoSize = true;
            lb10.Location = new Point(668, 430);
            lb10.Name = "lb10";
            lb10.Size = new Size(25, 20);
            lb10.TabIndex = 18;
            lb10.Text = "10";
            // 
            // lb5
            // 
            lb5.AutoSize = true;
            lb5.Location = new Point(668, 472);
            lb5.Name = "lb5";
            lb5.Size = new Size(17, 20);
            lb5.TabIndex = 19;
            lb5.Text = "5";
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(668, 513);
            lb1.Name = "lb1";
            lb1.Size = new Size(17, 20);
            lb1.TabIndex = 20;
            lb1.Text = "1";
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(752, 106);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(125, 27);
            tbTotal.TabIndex = 5;
            // 
            // tbCash
            // 
            tbCash.Location = new Point(752, 70);
            tbCash.Name = "tbCash";
            tbCash.Size = new Size(125, 27);
            tbCash.TabIndex = 21;
            // 
            // tbChange
            // 
            tbChange.Location = new Point(752, 177);
            tbChange.Name = "tbChange";
            tbChange.Size = new Size(125, 27);
            tbChange.TabIndex = 22;
            // 
            // tb100
            // 
            tb100.Location = new Point(752, 302);
            tb100.Name = "tb100";
            tb100.Size = new Size(125, 27);
            tb100.TabIndex = 25;
            // 
            // tb500
            // 
            tb500.Location = new Point(752, 260);
            tb500.Name = "tb500";
            tb500.Size = new Size(125, 27);
            tb500.TabIndex = 24;
            // 
            // tb1000
            // 
            tb1000.Location = new Point(752, 219);
            tb1000.Name = "tb1000";
            tb1000.Size = new Size(125, 27);
            tb1000.TabIndex = 23;
            // 
            // tb1
            // 
            tb1.Location = new Point(752, 510);
            tb1.Name = "tb1";
            tb1.Size = new Size(125, 27);
            tb1.TabIndex = 30;
            // 
            // tb5
            // 
            tb5.Location = new Point(752, 469);
            tb5.Name = "tb5";
            tb5.Size = new Size(125, 27);
            tb5.TabIndex = 29;
            // 
            // tb10
            // 
            tb10.Location = new Point(752, 427);
            tb10.Name = "tb10";
            tb10.Size = new Size(125, 27);
            tb10.TabIndex = 28;
            // 
            // tb20
            // 
            tb20.Location = new Point(752, 385);
            tb20.Name = "tb20";
            tb20.Size = new Size(125, 27);
            tb20.TabIndex = 27;
            // 
            // tb50
            // 
            tb50.Location = new Point(752, 344);
            tb50.Name = "tb50";
            tb50.Size = new Size(125, 27);
            tb50.TabIndex = 26;
            // 
            // btClear
            // 
            btClear.Location = new Point(517, 509);
            btClear.Name = "btClear";
            btClear.Size = new Size(136, 28);
            btClear.TabIndex = 31;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // btcheck_out
            // 
            btcheck_out.Location = new Point(517, 70);
            btcheck_out.Name = "btcheck_out";
            btcheck_out.Size = new Size(130, 413);
            btcheck_out.TabIndex = 32;
            btcheck_out.Text = "Check out";
            btcheck_out.UseVisualStyleBackColor = true;
            btcheck_out.Click += btcheck_out_Click;
            // 
            // tbDiscountAmount
            // 
            tbDiscountAmount.Location = new Point(752, 140);
            tbDiscountAmount.Name = "tbDiscountAmount";
            tbDiscountAmount.Size = new Size(125, 27);
            tbDiscountAmount.TabIndex = 34;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(668, 146);
            label12.Name = "label12";
            label12.Size = new Size(67, 20);
            label12.TabIndex = 33;
            label12.Text = "Discount";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 626);
            Controls.Add(tbDiscountAmount);
            Controls.Add(label12);
            Controls.Add(btcheck_out);
            Controls.Add(btClear);
            Controls.Add(tb1);
            Controls.Add(tb5);
            Controls.Add(tb10);
            Controls.Add(tb20);
            Controls.Add(tb50);
            Controls.Add(tb100);
            Controls.Add(tb500);
            Controls.Add(tb1000);
            Controls.Add(tbChange);
            Controls.Add(tbCash);
            Controls.Add(tbTotal);
            Controls.Add(lb1);
            Controls.Add(lb5);
            Controls.Add(lb10);
            Controls.Add(lb20);
            Controls.Add(lbCash);
            Controls.Add(lbChange);
            Controls.Add(lb1000);
            Controls.Add(lb500);
            Controls.Add(lb100);
            Controls.Add(lb50);
            Controls.Add(lbTotal);
            Controls.Add(GDiscount);
            Controls.Add(GFood);
            Controls.Add(GBeverage);
            Name = "Form1";
            Text = "Form1";
            GBeverage.ResumeLayout(false);
            GBeverage.PerformLayout();
            GFood.ResumeLayout(false);
            GFood.PerformLayout();
            GDiscount.ResumeLayout(false);
            GDiscount.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GBeverage;
        private CheckBox cbGreenTea;
        private CheckBox cbCoffee;
        private TextBox tbGreenTeaQuantity;
        private TextBox tbCoffeeQuantity;
        private TextBox tbGreenTeaPrice;
        private TextBox tbCoffeePrice;
        private GroupBox GFood;
        private TextBox tbPizzaQuantity;
        private TextBox tbNoodleQuantity;
        private TextBox tbPizzaPrice;
        private TextBox tbNoodlePrice;
        private CheckBox cbPizza;
        private CheckBox cbNoodle;
        private GroupBox GDiscount;
        private CheckBox cbFood;
        private TextBox tbDiscountDrinks;
        private TextBox tbDiscountAll;
        private CheckBox cbBeverage;
        private CheckBox cbAll;
        private TextBox tbDiscountFood;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button btCheckout;
        private Label lbTotal;
        private Label lb50;
        private Label lb100;
        private Label lb500;
        private Label lb1000;
        private Label lbChange;
        private Label lbCash;
        private Label lb20;
        private Label lb10;
        private Label lb5;
        private Label lb1;
        private TextBox tbTotal;
        private TextBox tbCash;
        private TextBox tbChange;
        private TextBox tb100;
        private TextBox tb500;
        private TextBox tb1000;
        private TextBox tb1;
        private TextBox tb5;
        private TextBox tb10;
        private TextBox tb20;
        private TextBox tb50;
        private Button btClear;
        private Button btcheck_out;
        private Label label4;
        private Label label9;
        private Label label8;
        private Label label5;
        private Label label11;
        private Label label10;
        private Label label7;
        private Label label6;
        private TextBox tbDiscountAmount;
        private Label label12;
    }
}
