using System;
using System.Windows.Forms;

public partial class frmMain : Form
{
    // Declare in function
    const decimal mSmallPizzaCost = 6.99M;
    const decimal mMediumPizzaCost = 9.99M;
    const decimal mLargePizzaCost = 12.99M;
    const decimal mToppingsCost = 0.99M;
    const decimal mDeliveryCharge = 2.50M;

    public static void Main()
    {
        frmMain main = new frmMain();
        Application.Run(main);
    }

    public frmMain()
    {
        InitializeComponent();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtDelivery.Text = "";
        txtPizzaSize.Text = "";
        txtToppings.Text = "";
        txtTotalCost.Text = "";

        txtDelivery.Focus();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
        // Sentences, Dont be polite, Short and concise
        const string pizzaSizeErrorMessage = "Enter S, M or L for the pizza size.";
        const string toppingsErrorMessage = "Enter a numeric value for toppings that is between zero and ten.";
        const string deliveryErrorMessage = "Enter Y or N for the delivery.";

        decimal totalCost;

        string pizzaSize = "";
        int toppings = 0;
        string delivery = "";

        pizzaSize = txtPizzaSize.Text.Trim().ToLower();
        if (validatePizzaSize(pizzaSize) == false)
        {
            MessageBox.Show(pizzaSizeErrorMessage);
            txtPizzaSize.Focus();
            return;
        }

        
        if (int.TryParse(txtToppings.Text, out toppings) == false || toppings < 0 || toppings > 10)
        {
            MessageBox.Show(toppingsErrorMessage);
            txtToppings.Focus();
            return;
        }

        delivery = txtDelivery.Text.Trim().ToLower();
        if (validateDelivery(delivery) == false)
        {
            MessageBox.Show(deliveryErrorMessage);
            txtDelivery.Focus();
            return;
        }

        // Calculations
        totalCost = calculateTotalCost(pizzaSize, toppings, delivery);

        txtTotalCost.Text = totalCost.ToString("C");

    }

    private static decimal calculateTotalCost(string pizzaSize, int toppings, string delivery)
    {
        decimal totalCost = 0M;

        if (delivery.Equals("y") == true) 
        {
            totalCost += mDeliveryCharge;
        }

        if (pizzaSize.Equals("s") == true) 
        {
            totalCost += mSmallPizzaCost;
        } 
        else if (pizzaSize.Equals("m") == true) 
        {
            totalCost += mMediumPizzaCost;
        }
        else
        {
            totalCost += mLargePizzaCost;
        }

        totalCost += toppings * mToppingsCost;
        
        return totalCost;
    }
    private static bool validateDelivery(string message)  
    {
        if (message.Length != 1)
        {
            return false;
        }
        if (!(message.Equals("y") || message.Equals("n"))) 
        {
            return false;
        }
        return true;
    }

    private static bool validatePizzaSize(string size) 
    {
        if (size.Length != 1) 
        {
            return false;
        }
        // if (!(size.Equals("s") || size.Equals("m") || size.Equals("l")))
        if (size != "s" 
            && size != "m" 
            && size != "l")
        {
            return false;
        } 
        return true;
    }
}