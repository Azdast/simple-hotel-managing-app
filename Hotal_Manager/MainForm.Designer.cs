using System.ComponentModel;

namespace Hotal_Manager;

partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        panel1 = new System.Windows.Forms.Panel();
        button_bill = new System.Windows.Forms.Button();
        button_Personnel = new System.Windows.Forms.Button();
        button_ligout = new System.Windows.Forms.Button();
        button_room = new System.Windows.Forms.Button();
        button_guest = new System.Windows.Forms.Button();
        button_dashbord = new System.Windows.Forms.Button();
        panel3 = new System.Windows.Forms.Panel();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        panel_conver = new System.Windows.Forms.Panel();
        checkBox3 = new System.Windows.Forms.CheckBox();
        checkBox2 = new System.Windows.Forms.CheckBox();
        label3 = new System.Windows.Forms.Label();
        checkBox1 = new System.Windows.Forms.CheckBox();
        pictureBox2 = new System.Windows.Forms.PictureBox();
        label2 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        checkBox4 = new System.Windows.Forms.CheckBox();
        panel2 = new System.Windows.Forms.Panel();
        panel_slide = new System.Windows.Forms.Panel();
        panel_main = new System.Windows.Forms.Panel();
        panel1.SuspendLayout();
        panel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        panel_conver.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        panel2.SuspendLayout();
        panel_main.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        panel1.Controls.Add(button_bill);
        panel1.Controls.Add(button_Personnel);
        panel1.Controls.Add(button_ligout);
        panel1.Controls.Add(button_room);
        panel1.Controls.Add(button_guest);
        panel1.Controls.Add(button_dashbord);
        panel1.Controls.Add(panel3);
        panel1.Dock = System.Windows.Forms.DockStyle.Left;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(178, 700);
        panel1.TabIndex = 0;
        // 
        // button_bill
        // 
        button_bill.Dock = System.Windows.Forms.DockStyle.Top;
        button_bill.FlatAppearance.BorderSize = 0;
        button_bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button_bill.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button_bill.ForeColor = System.Drawing.SystemColors.ControlText;
        button_bill.Image = ((System.Drawing.Image)resources.GetObject("button_bill.Image"));
        button_bill.Location = new System.Drawing.Point(0, 469);
        button_bill.Name = "button_bill";
        button_bill.Size = new System.Drawing.Size(178, 90);
        button_bill.TabIndex = 7;
        button_bill.Text = "صورتحساب";
        button_bill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        button_bill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
        button_bill.UseVisualStyleBackColor = true;
        button_bill.Click += button_bill_Click;
        // 
        // button_Personnel
        // 
        button_Personnel.Dock = System.Windows.Forms.DockStyle.Top;
        button_Personnel.FlatAppearance.BorderSize = 0;
        button_Personnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button_Personnel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button_Personnel.ForeColor = System.Drawing.SystemColors.ControlText;
        button_Personnel.Image = ((System.Drawing.Image)resources.GetObject("button_Personnel.Image"));
        button_Personnel.Location = new System.Drawing.Point(0, 379);
        button_Personnel.Name = "button_Personnel";
        button_Personnel.Size = new System.Drawing.Size(178, 90);
        button_Personnel.TabIndex = 6;
        button_Personnel.Text = "اطلاعات پرسنل";
        button_Personnel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        button_Personnel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
        button_Personnel.UseVisualStyleBackColor = true;
        button_Personnel.Click += button_Personnel_Click;
        // 
        // button_ligout
        // 
        button_ligout.Dock = System.Windows.Forms.DockStyle.Bottom;
        button_ligout.FlatAppearance.BorderSize = 0;
        button_ligout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button_ligout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button_ligout.ForeColor = System.Drawing.SystemColors.ControlText;
        button_ligout.Image = ((System.Drawing.Image)resources.GetObject("button_ligout.Image"));
        button_ligout.Location = new System.Drawing.Point(0, 565);
        button_ligout.Name = "button_ligout";
        button_ligout.Size = new System.Drawing.Size(178, 135);
        button_ligout.TabIndex = 5;
        button_ligout.Text = "خروج";
        button_ligout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        button_ligout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
        button_ligout.UseVisualStyleBackColor = true;
        button_ligout.Click += button_ligout_Click;
        // 
        // button_room
        // 
        button_room.Dock = System.Windows.Forms.DockStyle.Top;
        button_room.FlatAppearance.BorderSize = 0;
        button_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button_room.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button_room.ForeColor = System.Drawing.SystemColors.ControlText;
        button_room.Image = ((System.Drawing.Image)resources.GetObject("button_room.Image"));
        button_room.Location = new System.Drawing.Point(0, 289);
        button_room.Name = "button_room";
        button_room.Size = new System.Drawing.Size(178, 90);
        button_room.TabIndex = 4;
        button_room.Text = "اتاق ها";
        button_room.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        button_room.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
        button_room.UseVisualStyleBackColor = true;
        button_room.Click += button_room_Click;
        // 
        // button_guest
        // 
        button_guest.Dock = System.Windows.Forms.DockStyle.Top;
        button_guest.FlatAppearance.BorderSize = 0;
        button_guest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button_guest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button_guest.ForeColor = System.Drawing.SystemColors.ControlText;
        button_guest.Image = ((System.Drawing.Image)resources.GetObject("button_guest.Image"));
        button_guest.Location = new System.Drawing.Point(0, 199);
        button_guest.Name = "button_guest";
        button_guest.Size = new System.Drawing.Size(178, 90);
        button_guest.TabIndex = 2;
        button_guest.Text = "مهمان ها";
        button_guest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        button_guest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
        button_guest.UseVisualStyleBackColor = true;
        button_guest.Click += button_guest_Click;
        // 
        // button_dashbord
        // 
        button_dashbord.Dock = System.Windows.Forms.DockStyle.Top;
        button_dashbord.FlatAppearance.BorderSize = 0;
        button_dashbord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button_dashbord.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button_dashbord.ForeColor = System.Drawing.SystemColors.ControlText;
        button_dashbord.Image = ((System.Drawing.Image)resources.GetObject("button_dashbord.Image"));
        button_dashbord.Location = new System.Drawing.Point(0, 109);
        button_dashbord.Name = "button_dashbord";
        button_dashbord.Size = new System.Drawing.Size(178, 90);
        button_dashbord.TabIndex = 1;
        button_dashbord.Text = "پنل کاربری";
        button_dashbord.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        button_dashbord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
        button_dashbord.UseVisualStyleBackColor = true;
        button_dashbord.Click += button_dashbord_Click;
        // 
        // panel3
        // 
        panel3.Controls.Add(pictureBox1);
        panel3.Dock = System.Windows.Forms.DockStyle.Top;
        panel3.Location = new System.Drawing.Point(0, 0);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(178, 109);
        panel3.TabIndex = 0;
        // 
        // pictureBox1
        // 
        pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.Location = new System.Drawing.Point(0, 0);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(178, 109);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // panel_conver
        // 
        panel_conver.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        panel_conver.Controls.Add(checkBox3);
        panel_conver.Controls.Add(checkBox2);
        panel_conver.Controls.Add(label3);
        panel_conver.Controls.Add(checkBox1);
        panel_conver.Controls.Add(pictureBox2);
        panel_conver.Controls.Add(label2);
        panel_conver.Controls.Add(label1);
        panel_conver.Controls.Add(checkBox4);
        panel_conver.Dock = System.Windows.Forms.DockStyle.Fill;
        panel_conver.Location = new System.Drawing.Point(0, 0);
        panel_conver.Name = "panel_conver";
        panel_conver.Size = new System.Drawing.Size(916, 700);
        panel_conver.TabIndex = 1;
        // 
        // checkBox3
        // 
        checkBox3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        checkBox3.Location = new System.Drawing.Point(24, 586);
        checkBox3.Name = "checkBox3";
        checkBox3.Size = new System.Drawing.Size(176, 39);
        checkBox3.TabIndex = 6;
        checkBox3.Text = "خدمات مشتری";
        checkBox3.UseVisualStyleBackColor = true;
        // 
        // checkBox2
        // 
        checkBox2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        checkBox2.Location = new System.Drawing.Point(24, 541);
        checkBox2.Name = "checkBox2";
        checkBox2.Size = new System.Drawing.Size(274, 39);
        checkBox2.TabIndex = 5;
        checkBox2.Text = "تحویل سرویس به اتاق";
        checkBox2.UseVisualStyleBackColor = true;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(19, 406);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(176, 42);
        label3.TabIndex = 4;
        label3.Text = "وظیفه ها";
        // 
        // checkBox1
        // 
        checkBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        checkBox1.Location = new System.Drawing.Point(24, 451);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new System.Drawing.Size(256, 39);
        checkBox1.TabIndex = 3;
        checkBox1.Text = "تمیز کردن اتاق";
        checkBox1.UseVisualStyleBackColor = true;
        // 
        // pictureBox2
        // 
        pictureBox2.Image = ((System.Drawing.Image)resources.GetObject("pictureBox2.Image"));
        pictureBox2.Location = new System.Drawing.Point(6, 69);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new System.Drawing.Size(916, 334);
        pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        pictureBox2.TabIndex = 2;
        pictureBox2.TabStop = false;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(884, 1);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(29, 42);
        label2.TabIndex = 1;
        label2.Text = "X";
        label2.Click += label2_Click;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(324, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(176, 42);
        label1.TabIndex = 0;
        label1.Text = "برنامه هتلداری";
        // 
        // checkBox4
        // 
        checkBox4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        checkBox4.Location = new System.Drawing.Point(24, 496);
        checkBox4.Name = "checkBox4";
        checkBox4.Size = new System.Drawing.Size(274, 39);
        checkBox4.TabIndex = 7;
        checkBox4.Text = "تعویض حوله، ملحفه، لوازم بهداشتی";
        checkBox4.UseVisualStyleBackColor = true;
        // 
        // panel2
        // 
        panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        panel2.Controls.Add(panel_slide);
        panel2.Dock = System.Windows.Forms.DockStyle.Left;
        panel2.Location = new System.Drawing.Point(178, 0);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(13, 700);
        panel2.TabIndex = 9;
        // 
        // panel_slide
        // 
        panel_slide.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        panel_slide.Location = new System.Drawing.Point(0, 109);
        panel_slide.Name = "panel_slide";
        panel_slide.Size = new System.Drawing.Size(10, 110);
        panel_slide.TabIndex = 8;
        // 
        // panel_main
        // 
        panel_main.Controls.Add(panel_conver);
        panel_main.Dock = System.Windows.Forms.DockStyle.Right;
        panel_main.Location = new System.Drawing.Point(184, 0);
        panel_main.Name = "panel_main";
        panel_main.Size = new System.Drawing.Size(916, 700);
        panel_main.TabIndex = 8;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.AppWorkspace;
        ClientSize = new System.Drawing.Size(1100, 700);
        Controls.Add(panel_main);
        Controls.Add(panel2);
        Controls.Add(panel1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        Text = "MainForm";
        panel1.ResumeLayout(false);
        panel3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        panel_conver.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        panel2.ResumeLayout(false);
        panel_main.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button_Personnel;
    private System.Windows.Forms.Button button_bill;

    private System.Windows.Forms.Panel panel_main;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Button button_ligout;

    private System.Windows.Forms.Panel panel_slide;

    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.CheckBox checkBox3;
    private System.Windows.Forms.CheckBox checkBox4;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.CheckBox checkBox1;

    private System.Windows.Forms.PictureBox pictureBox2;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button button_guest;
    private System.Windows.Forms.Button button_room;

    private System.Windows.Forms.Button button_dashbord;

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.Panel panel_conver;

    private System.Windows.Forms.Panel panel1;

    #endregion
}