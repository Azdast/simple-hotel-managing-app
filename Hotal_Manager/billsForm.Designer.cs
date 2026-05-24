using System.ComponentModel;

namespace Hotal_Manager;

partial class billsForm
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
        panel1 = new System.Windows.Forms.Panel();
        label_exit = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        comboBoxBeds = new System.Windows.Forms.ComboBox();
        label2 = new System.Windows.Forms.Label();
        textBoxDays = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        textBoxExtra = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        buttonCalculate = new System.Windows.Forms.Button();
        labelResult = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        textBoxPricePerBed = new System.Windows.Forms.TextBox();
        label6 = new System.Windows.Forms.Label();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(label_exit);
        panel1.Controls.Add(label1);
        panel1.Dock = System.Windows.Forms.DockStyle.Top;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(900, 127);
        panel1.TabIndex = 0;
        // 
        // label_exit
        // 
        label_exit.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label_exit.Location = new System.Drawing.Point(868, 0);
        label_exit.Name = "label_exit";
        label_exit.Size = new System.Drawing.Size(32, 34);
        label_exit.TabIndex = 1;
        label_exit.Text = "X";
        label_exit.Click += label_exit_Click;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(350, 9);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(184, 61);
        label1.TabIndex = 0;
        label1.Text = "صورتحساب";
        // 
        // comboBoxBeds
        // 
        comboBoxBeds.FormattingEnabled = true;
        comboBoxBeds.Location = new System.Drawing.Point(106, 297);
        comboBoxBeds.Name = "comboBoxBeds";
        comboBoxBeds.Size = new System.Drawing.Size(121, 23);
        comboBoxBeds.TabIndex = 1;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(106, 268);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(138, 26);
        label2.TabIndex = 2;
        label2.Text = "تعداد تخت‌های اتاق";
        // 
        // textBoxDays
        // 
        textBoxDays.Location = new System.Drawing.Point(368, 297);
        textBoxDays.Name = "textBoxDays";
        textBoxDays.Size = new System.Drawing.Size(100, 23);
        textBoxDays.TabIndex = 3;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(318, 268);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(194, 26);
        label3.TabIndex = 4;
        label3.Text = "تعداد روزهای اقامت مهمان";
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(649, 268);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(159, 26);
        label4.TabIndex = 6;
        label4.Text = "هزیته های مهمان";
        // 
        // textBoxExtra
        // 
        textBoxExtra.Location = new System.Drawing.Point(649, 297);
        textBoxExtra.Name = "textBoxExtra";
        textBoxExtra.Size = new System.Drawing.Size(159, 23);
        textBoxExtra.TabIndex = 5;
        textBoxExtra.Text = "0";
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.Location = new System.Drawing.Point(593, 294);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(50, 26);
        label5.TabIndex = 7;
        label5.Text = "تومان";
        // 
        // buttonCalculate
        // 
        buttonCalculate.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        buttonCalculate.Location = new System.Drawing.Point(300, 464);
        buttonCalculate.Name = "buttonCalculate";
        buttonCalculate.Size = new System.Drawing.Size(268, 86);
        buttonCalculate.TabIndex = 8;
        buttonCalculate.Text = "نتیجه";
        buttonCalculate.UseVisualStyleBackColor = true;
        buttonCalculate.Click += buttonCalculate_Click;
        // 
        // labelResult
        // 
        labelResult.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        labelResult.Location = new System.Drawing.Point(350, 570);
        labelResult.Name = "labelResult";
        labelResult.Size = new System.Drawing.Size(337, 38);
        labelResult.TabIndex = 9;
        labelResult.Text = "0";
        // 
        // label7
        // 
        label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label7.Location = new System.Drawing.Point(271, 570);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(73, 38);
        label7.TabIndex = 10;
        label7.Text = "تومان";
        // 
        // textBoxPricePerBed
        // 
        textBoxPricePerBed.Location = new System.Drawing.Point(106, 356);
        textBoxPricePerBed.Name = "textBoxPricePerBed";
        textBoxPricePerBed.Size = new System.Drawing.Size(121, 23);
        textBoxPricePerBed.TabIndex = 11;
        textBoxPricePerBed.Text = "30000";
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.Location = new System.Drawing.Point(104, 327);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(140, 26);
        label6.TabIndex = 12;
        label6.Text = "قیمت برای هر تخت";
        // 
        // billsForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(900, 661);
        Controls.Add(label6);
        Controls.Add(textBoxPricePerBed);
        Controls.Add(label7);
        Controls.Add(labelResult);
        Controls.Add(buttonCalculate);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(textBoxExtra);
        Controls.Add(label3);
        Controls.Add(textBoxDays);
        Controls.Add(label2);
        Controls.Add(comboBoxBeds);
        Controls.Add(panel1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        Text = "billsForm";
        panel1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label_exit;

    private System.Windows.Forms.TextBox textBoxPricePerBed;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.Label labelResult;

    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button buttonCalculate;

    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBoxExtra;

    private System.Windows.Forms.TextBox textBoxDays;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.ComboBox comboBoxBeds;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Panel panel1;

    #endregion
}