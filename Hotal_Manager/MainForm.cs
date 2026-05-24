namespace Hotal_Manager;   // name unchanged

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private GuestForm guest;
    private RoomsForm roomForm;
    private PersonnelForm personnelForm;
    private LoginForm loginForm;  // kept but unused (original had it)
    private billsForm billform;

    // Helper: move the slide panel to the clicked button
    private void MoveSlidePanel(Button btn)
    {
        panel_slide.Height = btn.Height;
        panel_slide.Top = btn.Top;
    }

    // Helper: hide all dashboard controls on panel_conver
    private void HideDashboardControls()
    {
        foreach (Control c in panel_conver.Controls)
        {
            c.Visible = false;
        }
    }

    // Helper: dispose a form and return null (no 'ref' needed)
    private Form DisposeForm(Form form)
    {
        if (form != null)
        {
            panel_conver.Controls.Remove(form);
            form.Close();
            form.Dispose();
        }
        return null;
    }

    // Helper: show a form as a child inside panel_conver
    private void ShowChildForm(Form form)
    {
        form.TopLevel = false;
        form.Dock = DockStyle.Fill;
        form.FormBorderStyle = FormBorderStyle.None;
        panel_conver.Controls.Add(form);
        form.Show();
    }

    // ========== Original event handlers (names unchanged) ==========

    private void button_dashbord_Click(object sender, EventArgs e)
    {
        MoveSlidePanel(button_dashbord);

        // Dispose all child forms
        guest = (GuestForm)DisposeForm(guest);
        roomForm = (RoomsForm)DisposeForm(roomForm);
        personnelForm = (PersonnelForm)DisposeForm(personnelForm);
        billform = (billsForm)DisposeForm(billform);

        // Show dashboard controls again
        foreach (Control c in panel_conver.Controls)
        {
            c.Visible = true;
        }
    }

    private void button_guest_Click(object sender, EventArgs e)
    {
        MoveSlidePanel(button_guest);
        HideDashboardControls();

        // Remove other forms
        roomForm = (RoomsForm)DisposeForm(roomForm);
        personnelForm = (PersonnelForm)DisposeForm(personnelForm);

        // Create guest form if needed
        if (guest == null)
        {
            guest = new GuestForm();
        }
        ShowChildForm(guest);
    }

    private void button_room_Click(object sender, EventArgs e)
    {
        MoveSlidePanel(button_room);   // FIXED: was incorrectly setting panel_conver.Height
        HideDashboardControls();

        // Remove other forms
        guest = (GuestForm)DisposeForm(guest);
        personnelForm = (PersonnelForm)DisposeForm(personnelForm);

        if (roomForm == null)
        {
            roomForm = new RoomsForm();
        }
        ShowChildForm(roomForm);
    }

    private void button_ligout_Click(object sender, EventArgs e)   // typo kept
    {
        MoveSlidePanel(button_ligout);

        this.Hide();
        LoginForm loginform = new LoginForm();
        loginform.Show();
        // Original did not close MainForm – keeping same behavior
    }

    private void button_Personnel_Click(object sender, EventArgs e)
    {
        MoveSlidePanel(button_Personnel);   // FIXED: was using button_ligout's properties
        HideDashboardControls();

        // Remove other forms
        guest = (GuestForm)DisposeForm(guest);
        roomForm = (RoomsForm)DisposeForm(roomForm);

        if (personnelForm == null)
        {
            personnelForm = new PersonnelForm();
        }
        ShowChildForm(personnelForm);
    }
    private void button_bill_Click(object sender, EventArgs e)
    {
        MoveSlidePanel(button_bill);   // FIXED: was using button_ligout's properties
        HideDashboardControls();

        // Remove other forms
        billform = (billsForm)DisposeForm(billform);
        roomForm = (RoomsForm)DisposeForm(roomForm);

        if (billform == null)
        {
            billform = new billsForm();
        }
        ShowChildForm(billform);
    }

    private void label2_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

   
}