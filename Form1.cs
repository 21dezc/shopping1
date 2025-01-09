namespace Shoppingcart21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btcheck_out_Click(object sender, EventArgs e)
        {
            
            string strCoffeePrice = tbCoffeePrice.Text;
            string strCoffeeQuantity = tbCoffeeQuantity.Text;

            string strNoodlePrice = tbNoodlePrice.Text;
            string strNoodleQuantity = tbNoodleQuantity.Text;

            
            string strGreenTeaPrice = tbGreenTeaPrice.Text;
            string strGreenTeaQuantity = tbGreenTeaQuantity.Text;

           
            string strPizzaPrice = tbPizzaPrice.Text;
            string strPizzaQuantity = tbPizzaQuantity.Text;

            
            string strCash = tbCash.Text;
            string strDiscountAll = tbDiscountAll.Text;
            string strDiscountDrinks = tbDiscountDrinks.Text;
            string strDiscountFood = tbDiscountFood.Text;

            double iCoffeePrice = 0;
            double iCoffeeQuantity = 0;
            double iGreenTeaPrice = 0;
            double iGreenTeaQuantity = 0;
            double iNoodlePrice = 0;
            double iNoodleQuantity = 0;
            double iPizzaPrice = 0;
            double iPizzaQuantity = 0;
            double iTotal = 0;
            double iCash = 0;
            double iChange = 0;

            double discountAmount = 0; 

            double discountAll = 0;
            double discountDrinks = 0;
            double discountFood = 0;

            try
            {
                
                if (cbCoffee.Checked)
                {
                    iCoffeePrice = double.Parse(strCoffeePrice);
                    iCoffeeQuantity = double.Parse(strCoffeeQuantity);
                }

                
                if (cbGreenTea.Checked)
                {
                    iGreenTeaPrice = double.Parse(strGreenTeaPrice);
                    iGreenTeaQuantity = double.Parse(strGreenTeaQuantity);
                }

                
                if (cbNoodle.Checked)
                {
                    iNoodlePrice = double.Parse(strNoodlePrice);
                    iNoodleQuantity = double.Parse(strNoodleQuantity);
                }

                
                if (cbPizza.Checked)
                {
                    iPizzaPrice = double.Parse(strPizzaPrice);
                    iPizzaQuantity = double.Parse(strPizzaQuantity);
                }

                
                iCash = double.Parse(strCash);

                
                discountAll = string.IsNullOrWhiteSpace(strDiscountAll) ? 0 : double.Parse(strDiscountAll) / 100;
                discountDrinks = string.IsNullOrWhiteSpace(strDiscountDrinks) ? 0 : double.Parse(strDiscountDrinks) / 100;
                discountFood = string.IsNullOrWhiteSpace(strDiscountFood) ? 0 : double.Parse(strDiscountFood) / 100;
            }
            catch (Exception ex)
            {
                iCoffeePrice = 0;
                iCoffeeQuantity = 0;
                iGreenTeaPrice = 0;
                iGreenTeaQuantity = 0;
                iNoodlePrice = 0;
                iNoodleQuantity = 0;
                iPizzaPrice = 0;
                iPizzaQuantity = 0;
                iCash = 0;
                discountAll = 0;
                discountDrinks = 0;
                discountFood = 0;
            }

           
            double drinksTotal = (iCoffeePrice * iCoffeeQuantity) + (iGreenTeaPrice * iGreenTeaQuantity);
            double foodTotal = (iNoodlePrice * iNoodleQuantity) + (iPizzaPrice * iPizzaQuantity);

            iTotal = drinksTotal + foodTotal;

            if (cbAll.Checked && discountAll > 0)
            {
                discountAmount = iTotal * discountAll; 
                iTotal -= discountAmount;             
            }
            else
            {
                if (cbBeverage.Checked && discountDrinks > 0)
                {
                    discountAmount = drinksTotal * discountDrinks; 
                    drinksTotal -= discountAmount;                
                }
                else if (cbFood.Checked && discountFood > 0)
                {
                    discountAmount = foodTotal * discountFood;    
                    foodTotal -= discountAmount;                 
                }

                iTotal = drinksTotal + foodTotal;
            }

            
            iChange = iCash - iTotal;

        
            tbDiscountAmount.Text = discountAmount.ToString("F2");

            tbTotal.Text = iTotal.ToString("F2");
            tbChange.Text = iChange.ToString("F2");

          ­
            int[] denominations = { 1000, 500, 100, 50, 20, 10, 5, 1 };
            TextBox[] denominationTextBoxes = { tb1000, tb500, tb100, tb50, tb20, tb10, tb5, tb1 };

        
            for (int i = 0; i < denominations.Length; i++)
            {
                int count = (int)(iChange / denominations[i]); ­
                iChange %= denominations[i];                  
                denominationTextBoxes[i].Text = count.ToString();
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
         
            tbCoffeePrice.Text = "";
            tbCoffeeQuantity.Text = "";
            tbGreenTeaQuantity.Text = "";
            tbGreenTeaPrice.Text = "";
            tbNoodlePrice.Text = "";
            tbNoodleQuantity.Text = "";
            tbPizzaPrice.Text = "";
            tbPizzaQuantity.Text = "";

        
            tbTotal.Text = "";
            tbCash.Text = "";
            tbChange.Text = "";
         
            tbDiscountAll.Text = "";
            tbDiscountDrinks.Text = "";
            tbDiscountFood.Text = "";
            tbDiscountAmount.Text = "0.00";  

        ­
            tb1000.Text = "";
            tb500.Text = "";
            tb100.Text = "";
            tb50.Text = "";
            tb20.Text = "";
            tb10.Text = "";
            tb5.Text = "";
            tb1.Text = "";

        
            cbCoffee.Checked = false;
            cbGreenTea.Checked = false;
            cbNoodle.Checked = false;
            cbPizza.Checked = false;
            cbAll.Checked = false;
            cbBeverage.Checked = false;
            cbFood.Checked = false;
        }

    }

}
