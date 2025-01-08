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
            cbCoffee = new CheckBox();
            cbGreenTea = new CheckBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            GFood = new GroupBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            cbPizza = new CheckBox();
            cbNoodle = new CheckBox();
            GDiscount = new GroupBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            cbBeverage = new CheckBox();
            cbAll = new CheckBox();
            cbFood = new CheckBox();
            textBox14 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btCheckout = new Button();
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
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            textBox15 = new TextBox();
            textBox16 = new TextBox();
            textBox17 = new TextBox();
            textBox19 = new TextBox();
            textBox20 = new TextBox();
            textBox21 = new TextBox();
            textBox22 = new TextBox();
            textBox23 = new TextBox();
            GBeverage.SuspendLayout();
            GFood.SuspendLayout();
            GDiscount.SuspendLayout();
            SuspendLayout();
            // 
            // GBeverage
            // 
            GBeverage.Controls.Add(textBox4);
            GBeverage.Controls.Add(textBox3);
            GBeverage.Controls.Add(textBox2);
            GBeverage.Controls.Add(textBox1);
            GBeverage.Controls.Add(cbGreenTea);
            GBeverage.Controls.Add(cbCoffee);
            GBeverage.Location = new Point(42, 47);
            GBeverage.Name = "GBeverage";
            GBeverage.Size = new Size(427, 121);
            GBeverage.TabIndex = 0;
            GBeverage.TabStop = false;
            GBeverage.Text = "Beverage";
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
            // cbGreenTea
            // 
            cbGreenTea.AutoSize = true;
            cbGreenTea.Location = new Point(11, 78);
            cbGreenTea.Name = "cbGreenTea";
            cbGreenTea.Size = new Size(97, 24);
            cbGreenTea.TabIndex = 1;
            cbGreenTea.Text = "Green Tea";
            cbGreenTea.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(139, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(282, 36);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(282, 78);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 4;
            // 
            // GFood
            // 
            GFood.Controls.Add(textBox5);
            GFood.Controls.Add(textBox6);
            GFood.Controls.Add(textBox7);
            GFood.Controls.Add(textBox8);
            GFood.Controls.Add(cbPizza);
            GFood.Controls.Add(cbNoodle);
            GFood.Location = new Point(42, 193);
            GFood.Name = "GFood";
            GFood.Size = new Size(427, 121);
            GFood.TabIndex = 5;
            GFood.TabStop = false;
            GFood.Text = "Food";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(282, 78);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(282, 36);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 3;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(139, 77);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 2;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(139, 36);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 27);
            textBox8.TabIndex = 1;
            // 
            // cbPizza
            // 
            cbPizza.AutoSize = true;
            cbPizza.Location = new Point(11, 77);
            cbPizza.Name = "cbPizza";
            cbPizza.Size = new Size(65, 24);
            cbPizza.TabIndex = 1;
            cbPizza.Text = "Pizza";
            cbPizza.UseVisualStyleBackColor = true;
            cbPizza.CheckedChanged += checkBox3_CheckedChanged;
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
            GDiscount.Controls.Add(textBox14);
            GDiscount.Controls.Add(cbFood);
            GDiscount.Controls.Add(textBox9);
            GDiscount.Controls.Add(textBox10);
            GDiscount.Controls.Add(cbBeverage);
            GDiscount.Controls.Add(cbAll);
            GDiscount.Location = new Point(42, 332);
            GDiscount.Name = "GDiscount";
            GDiscount.Size = new Size(427, 158);
            GDiscount.TabIndex = 5;
            GDiscount.TabStop = false;
            GDiscount.Text = "Discount";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(268, 74);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(125, 27);
            textBox9.TabIndex = 4;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(268, 22);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(125, 27);
            textBox10.TabIndex = 3;
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
            // textBox14
            // 
            textBox14.Location = new Point(268, 117);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(125, 27);
            textBox14.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(399, 29);
            label1.Name = "label1";
            label1.Size = new Size(21, 20);
            label1.TabIndex = 6;
            label1.Text = "%";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(441, 413);
            label2.Name = "label2";
            label2.Size = new Size(21, 20);
            label2.TabIndex = 8;
            label2.Text = "%";
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
            // btCheckout
            // 
            btCheckout.Location = new Point(505, 58);
            btCheckout.Name = "btCheckout";
            btCheckout.Size = new Size(129, 432);
            btCheckout.TabIndex = 9;
            btCheckout.Text = "Check out";
            btCheckout.UseVisualStyleBackColor = true;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(663, 65);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(42, 20);
            lbTotal.TabIndex = 10;
            lbTotal.Text = "Total";
            lbTotal.Click += label4_Click;
            // 
            // lb50
            // 
            lb50.AutoSize = true;
            lb50.Location = new Point(678, 315);
            lb50.Name = "lb50";
            lb50.Size = new Size(25, 20);
            lb50.TabIndex = 11;
            lb50.Text = "50";
            // 
            // lb100
            // 
            lb100.AutoSize = true;
            lb100.Location = new Point(670, 273);
            lb100.Name = "lb100";
            lb100.Size = new Size(33, 20);
            lb100.TabIndex = 12;
            lb100.Text = "100";
            // 
            // lb500
            // 
            lb500.AutoSize = true;
            lb500.Location = new Point(670, 231);
            lb500.Name = "lb500";
            lb500.Size = new Size(33, 20);
            lb500.TabIndex = 13;
            lb500.Text = "500";
            // 
            // lb1000
            // 
            lb1000.AutoSize = true;
            lb1000.Location = new Point(663, 193);
            lb1000.Name = "lb1000";
            lb1000.Size = new Size(41, 20);
            lb1000.TabIndex = 14;
            lb1000.Text = "1000";
            // 
            // lbChange
            // 
            lbChange.AutoSize = true;
            lbChange.Location = new Point(655, 148);
            lbChange.Name = "lbChange";
            lbChange.Size = new Size(59, 20);
            lbChange.TabIndex = 15;
            lbChange.Text = "Change";
            lbChange.Click += lbChange_Click;
            // 
            // lbCash
            // 
            lbCash.AutoSize = true;
            lbCash.Location = new Point(663, 106);
            lbCash.Name = "lbCash";
            lbCash.Size = new Size(40, 20);
            lbCash.TabIndex = 16;
            lbCash.Text = "Cash";
            // 
            // lb20
            // 
            lb20.AutoSize = true;
            lb20.Location = new Point(678, 357);
            lb20.Name = "lb20";
            lb20.Size = new Size(25, 20);
            lb20.TabIndex = 17;
            lb20.Text = "20";
            // 
            // lb10
            // 
            lb10.AutoSize = true;
            lb10.Location = new Point(680, 398);
            lb10.Name = "lb10";
            lb10.Size = new Size(25, 20);
            lb10.TabIndex = 18;
            lb10.Text = "10";
            // 
            // lb5
            // 
            lb5.AutoSize = true;
            lb5.Location = new Point(684, 440);
            lb5.Name = "lb5";
            lb5.Size = new Size(17, 20);
            lb5.TabIndex = 19;
            lb5.Text = "5";
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(684, 481);
            lb1.Name = "lb1";
            lb1.Size = new Size(17, 20);
            lb1.TabIndex = 20;
            lb1.Text = "1";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(720, 58);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(125, 27);
            textBox11.TabIndex = 5;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(720, 99);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(125, 27);
            textBox12.TabIndex = 21;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(720, 141);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(125, 27);
            textBox13.TabIndex = 22;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(720, 266);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(125, 27);
            textBox15.TabIndex = 25;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(720, 224);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(125, 27);
            textBox16.TabIndex = 24;
            // 
            // textBox17
            // 
            textBox17.Location = new Point(720, 183);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(125, 27);
            textBox17.TabIndex = 23;
            // 
            // textBox19
            // 
            textBox19.Location = new Point(720, 474);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(125, 27);
            textBox19.TabIndex = 30;
            // 
            // textBox20
            // 
            textBox20.Location = new Point(720, 433);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(125, 27);
            textBox20.TabIndex = 29;
            // 
            // textBox21
            // 
            textBox21.Location = new Point(720, 391);
            textBox21.Name = "textBox21";
            textBox21.Size = new Size(125, 27);
            textBox21.TabIndex = 28;
            // 
            // textBox22
            // 
            textBox22.Location = new Point(720, 349);
            textBox22.Name = "textBox22";
            textBox22.Size = new Size(125, 27);
            textBox22.TabIndex = 27;
            // 
            // textBox23
            // 
            textBox23.Location = new Point(720, 308);
            textBox23.Name = "textBox23";
            textBox23.Size = new Size(125, 27);
            textBox23.TabIndex = 26;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 626);
            Controls.Add(textBox19);
            Controls.Add(textBox20);
            Controls.Add(textBox21);
            Controls.Add(textBox22);
            Controls.Add(textBox23);
            Controls.Add(textBox15);
            Controls.Add(textBox16);
            Controls.Add(textBox17);
            Controls.Add(textBox13);
            Controls.Add(textBox12);
            Controls.Add(textBox11);
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
            Controls.Add(btCheckout);
            Controls.Add(label2);
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
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox GFood;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private CheckBox cbPizza;
        private CheckBox cbNoodle;
        private GroupBox GDiscount;
        private CheckBox cbFood;
        private TextBox textBox9;
        private TextBox textBox10;
        private CheckBox cbBeverage;
        private CheckBox cbAll;
        private TextBox textBox14;
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
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox15;
        private TextBox textBox16;
        private TextBox textBox17;
        private TextBox textBox19;
        private TextBox textBox20;
        private TextBox textBox21;
        private TextBox textBox22;
        private TextBox textBox23;
    }
}
