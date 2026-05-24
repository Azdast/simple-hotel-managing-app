namespace Hotal_Manager;

public partial class RoomsForm : Form
{
    public RoomsForm()
    {
        InitializeComponent();
        SetupDataGridView();
        LoadSampleData();
    }
    private void SetupDataGridView()
    {
        // Create columns
        DataGridViewTextBoxColumn colRoomName = new DataGridViewTextBoxColumn();
        colRoomName.HeaderText = "نام اتاق";
        colRoomName.Name = "RoomName";
        colRoomName.Width = 150;

        DataGridViewTextBoxColumn colBeds = new DataGridViewTextBoxColumn();
        colBeds.HeaderText = "تعداد تخت‌ها";
        colBeds.Name = "Beds";
        colBeds.Width = 120;

        DataGridViewCheckBoxColumn colEmpty = new DataGridViewCheckBoxColumn();
        colEmpty.HeaderText = "خالی است؟";
        colEmpty.Name = "Empty";
        colEmpty.Width = 80;
        colEmpty.TrueValue = true;
        colEmpty.FalseValue = false;

        dataGridView1.Columns.AddRange(colRoomName, colBeds, colEmpty);
    }

    private void LoadSampleData()
    {
        // Sample rows: Room 1 with 2 beds, Room 2 with 1 bed, Room 3 with 3 beds
        dataGridView1.Rows.Add("اتاق 1", 2, false);
        dataGridView1.Rows.Add("اتاق 2", 3, false);
    }

    private void btnAddRoom_Click(object sender, EventArgs e)
    {
        // Find the next available room number
        int nextNumber = GetNextRoomNumber();

        // Generate room name
        string roomName = "اتاق " + nextNumber;

        // Prompt for number of beds
        string bedsInput = Microsoft.VisualBasic.Interaction.InputBox("تعداد تخت‌ها " + roomName + ":", "Add Room", "1");
        if (!int.TryParse(bedsInput, out int beds) || beds <= 0)
        {
            MessageBox.Show("لطفا یک عدد مثبت معتبر برای تخت‌ها وارد کنید.", "Invalid Input");
            return;
        }

        // Default empty status = false (occupied)
        dataGridView1.Rows.Add(roomName, beds, false);
    }

    private int GetNextRoomNumber()
    {
        // Collect all existing room numbers from the "RoomName" column
        var existingNumbers = new System.Collections.Generic.List<int>();

        foreach (DataGridViewRow row in dataGridView1.Rows)
        {
            if (row.IsNewRow) continue; // Skip the empty new row placeholder if present

            object cellValue = row.Cells["RoomName"].Value;
            if (cellValue != null && cellValue.ToString().StartsWith("اتاق "))
            {
                string numberPart = cellValue.ToString().Substring(5); // After "Room "
                if (int.TryParse(numberPart, out int num))
                {
                    existingNumbers.Add(num);
                }
            }
        }

        // Find the smallest positive integer not in the list
        if (existingNumbers.Count == 0)
            return 1; // First room

        existingNumbers.Sort();
        int expected = 1;
        foreach (int num in existingNumbers)
        {
            if (num > expected)
                return expected;
            if (num == expected)
                expected++;
        }
        return expected;
    }

    private void btnDeleteRoom_Click(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows.Count > 0)
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            if (!selectedRow.IsNewRow)
            {
                dataGridView1.Rows.Remove(selectedRow);
            }
        }
        else
        {
            MessageBox.Show("لطفا یک اتاق برای حذف انتخاب کنید.", "No Selection");
        }
    }

    private void btnToggleCheckbox_Click(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows.Count > 0)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            if (row.Cells["Empty"] is DataGridViewCheckBoxCell chkCell)
            {
                // Flip the current boolean value
                bool currentValue = (row.Cells["Empty"].Value != null && (bool)row.Cells["Empty"].Value);
                row.Cells["Empty"].Value = !currentValue;
            }
        }
        else
        {
            MessageBox.Show("لطفا یک اتاق را برای تغییر وضعیت خالی بودن آن انتخاب کنید.", "No Selection");
        }
    }

    private void label2_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}