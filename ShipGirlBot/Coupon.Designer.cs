﻿partial class Coupon
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
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.button1 = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // textBox1
        // 
        this.textBox1.Location = new System.Drawing.Point(31, 47);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new System.Drawing.Size(221, 21);
        this.textBox1.TabIndex = 0;
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(289, 47);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(75, 23);
        this.button1.TabIndex = 1;
        this.button1.Text = "使用";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // Coupon
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.AutoScroll = true;
        this.ClientSize = new System.Drawing.Size(472, 152);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.textBox1);
        this.Name = "Coupon";
        this.Text = "优惠码";
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button1;
}