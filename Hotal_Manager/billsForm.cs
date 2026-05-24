namespace Hotal_Manager;

public partial class billsForm : Form
{
    public billsForm()
    {
        InitializeComponent();
        PopulateBedOptions(); // Fill bed numbers
    }

    private void PopulateBedOptions()
    {
        // Add bed numbers 1 to 5 (or any range)
        for (int i = 1; i <= 5; i++)
        {
            comboBoxBeds.Items.Add(i);
            
        }
        comboBoxBeds.SelectedIndex = 0; // default to 1 bed
    }

    private void buttonCalculate_Click(object sender, EventArgs e)
    {
        // Validate number of days
        if (!int.TryParse(textBoxDays.Text, out int days) || days <= 0)
        {
            MessageBox.Show("لطفا تعداد روزهای مثبت معتبری وارد کنید.", "Input Error");
            textBoxDays.Focus();
            return;
        }

        // Validate beds selection
        if (comboBoxBeds.SelectedItem == null)
        {
            MessageBox.Show("لطفا تعداد تخت را انتخاب کنید.", "Input Error");
            return;
        }
        int beds = (int)comboBoxBeds.SelectedItem;

        // Validate additional cost (extra services)
        if (!decimal.TryParse(textBoxExtra.Text, out decimal extraCost) || extraCost < 0)
        {
            MessageBox.Show("لطفا هزینه اضافی معتبری (0 یا مثبت) وارد کنید.", "Input Error");
            textBoxExtra.Focus();
            return;
        }

        // Validate price per bed per day (from user-editable TextBox)
        if (!decimal.TryParse(textBoxPricePerBed.Text, out decimal pricePerBedPerDay) || pricePerBedPerDay <= 0)
        {
            MessageBox.Show("لطفا قیمت هر تخت در شب را به صورت یک عدد مثبت وارد کنید.", "Input Error");
            textBoxPricePerBed.Focus();
            return;
        }

        // Calculate total
        decimal bedCost = beds * pricePerBedPerDay * days;
        decimal total = bedCost + extraCost;

        // Format for Toman (e.g., "1,250,000 تومان")
        string formattedTotal = total.ToString("#,0");

        // Display result in label
        labelResult.Text = formattedTotal;
    }

    private void label_exit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}