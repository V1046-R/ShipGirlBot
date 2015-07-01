
partial class ShipForm
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
        this.components = new System.ComponentModel.Container();
        DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
        DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
        DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
        DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
        DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn5 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
        DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn6 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
        DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn7 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipForm));
        this.equiplist = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
        this.bg = new System.Windows.Forms.Panel();
        this.biglihui = new System.Windows.Forms.Panel();
        this.chainanim = new System.Windows.Forms.Panel();
        this.panelbg = new System.Windows.Forms.Panel();
        this.star6 = new System.Windows.Forms.PictureBox();
        this.star5 = new System.Windows.Forms.PictureBox();
        this.star4 = new System.Windows.Forms.PictureBox();
        this.star3 = new System.Windows.Forms.PictureBox();
        this.star2 = new System.Windows.Forms.PictureBox();
        this.star1 = new System.Windows.Forms.PictureBox();
        this.modicon = new System.Windows.Forms.PictureBox();
        this.weapon4 = new System.Windows.Forms.PictureBox();
        this.weapon3 = new System.Windows.Forms.PictureBox();
        this.weapon2 = new System.Windows.Forms.PictureBox();
        this.weapon1 = new System.Windows.Forms.PictureBox();
        this.pictureBox10 = new System.Windows.Forms.PictureBox();
        this.pictureBox11 = new System.Windows.Forms.PictureBox();
        this.pictureBox12 = new System.Windows.Forms.PictureBox();
        this.pictureBox13 = new System.Windows.Forms.PictureBox();
        this.pictureBox6 = new System.Windows.Forms.PictureBox();
        this.pictureBox7 = new System.Windows.Forms.PictureBox();
        this.pictureBox8 = new System.Windows.Forms.PictureBox();
        this.pictureBox9 = new System.Windows.Forms.PictureBox();
        this.pictureBox5 = new System.Windows.Forms.PictureBox();
        this.pictureBox4 = new System.Windows.Forms.PictureBox();
        this.pictureBox3 = new System.Windows.Forms.PictureBox();
        this.pictureBox2 = new System.Windows.Forms.PictureBox();
        this.shiptypeicon = new System.Windows.Forms.PictureBox();
        this.timer1 = new System.Windows.Forms.Timer(this.components);
        this.bg.SuspendLayout();
        this.biglihui.SuspendLayout();
        this.chainanim.SuspendLayout();
        this.panelbg.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.star6)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.star5)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.star4)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.star3)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.star2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.star1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.modicon)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.weapon4)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.weapon3)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.weapon2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.weapon1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.shiptypeicon)).BeginInit();
        this.SuspendLayout();
        // 
        // equiplist
        // 
        this.equiplist.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
        this.equiplist.Location = new System.Drawing.Point(1027, 0);
        this.equiplist.Name = "equiplist";
        gridColumn1.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridButtonXEditControl);
        gridColumn1.HeaderText = "更换";
        gridColumn1.Name = "";
        gridColumn1.Width = 40;
        gridColumn2.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridImageEditControl);
        gridColumn2.HeaderText = "图标";
        gridColumn2.Name = "";
        gridColumn2.Width = 124;
        gridColumn3.HeaderText = "名称";
        gridColumn3.Name = "";
        gridColumn3.Width = 120;
        gridColumn4.HeaderText = "星级";
        gridColumn4.Name = "";
        gridColumn4.Width = 30;
        gridColumn5.HeaderText = "属性1";
        gridColumn5.Name = "";
        gridColumn5.Width = 50;
        gridColumn6.HeaderText = "属性2";
        gridColumn6.Name = "";
        gridColumn6.Width = 50;
        gridColumn7.HeaderText = "数量";
        gridColumn7.Name = "";
        gridColumn7.Width = 40;
        this.equiplist.PrimaryGrid.Columns.Add(gridColumn1);
        this.equiplist.PrimaryGrid.Columns.Add(gridColumn2);
        this.equiplist.PrimaryGrid.Columns.Add(gridColumn3);
        this.equiplist.PrimaryGrid.Columns.Add(gridColumn4);
        this.equiplist.PrimaryGrid.Columns.Add(gridColumn5);
        this.equiplist.PrimaryGrid.Columns.Add(gridColumn6);
        this.equiplist.PrimaryGrid.Columns.Add(gridColumn7);
        this.equiplist.Size = new System.Drawing.Size(489, 705);
        this.equiplist.TabIndex = 6;
        this.equiplist.Text = "superGridControl1";
        // 
        // bg
        // 
        this.bg.BackColor = System.Drawing.Color.Transparent;
        this.bg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bg.BackgroundImage")));
        this.bg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        this.bg.Controls.Add(this.biglihui);
        this.bg.Location = new System.Drawing.Point(0, 0);
        this.bg.Name = "bg";
        this.bg.Size = new System.Drawing.Size(1024, 768);
        this.bg.TabIndex = 10;
        // 
        // biglihui
        // 
        this.biglihui.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("biglihui.BackgroundImage")));
        this.biglihui.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        this.biglihui.Controls.Add(this.chainanim);
        this.biglihui.Location = new System.Drawing.Point(-270, -100);
        this.biglihui.Name = "biglihui";
        this.biglihui.Size = new System.Drawing.Size(1442, 887);
        this.biglihui.TabIndex = 10;
        // 
        // chainanim
        // 
        this.chainanim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chainanim.BackgroundImage")));
        this.chainanim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        this.chainanim.Controls.Add(this.panelbg);
        this.chainanim.Location = new System.Drawing.Point(366, 101);
        this.chainanim.Name = "chainanim";
        this.chainanim.Size = new System.Drawing.Size(1660, 760);
        this.chainanim.TabIndex = 0;
        // 
        // panelbg
        // 
        this.panelbg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelbg.BackgroundImage")));
        this.panelbg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        this.panelbg.Controls.Add(this.star6);
        this.panelbg.Controls.Add(this.star5);
        this.panelbg.Controls.Add(this.star4);
        this.panelbg.Controls.Add(this.star3);
        this.panelbg.Controls.Add(this.star2);
        this.panelbg.Controls.Add(this.star1);
        this.panelbg.Controls.Add(this.modicon);
        this.panelbg.Controls.Add(this.weapon4);
        this.panelbg.Controls.Add(this.weapon3);
        this.panelbg.Controls.Add(this.weapon2);
        this.panelbg.Controls.Add(this.weapon1);
        this.panelbg.Controls.Add(this.pictureBox10);
        this.panelbg.Controls.Add(this.pictureBox11);
        this.panelbg.Controls.Add(this.pictureBox12);
        this.panelbg.Controls.Add(this.pictureBox13);
        this.panelbg.Controls.Add(this.pictureBox6);
        this.panelbg.Controls.Add(this.pictureBox7);
        this.panelbg.Controls.Add(this.pictureBox8);
        this.panelbg.Controls.Add(this.pictureBox9);
        this.panelbg.Controls.Add(this.pictureBox5);
        this.panelbg.Controls.Add(this.pictureBox4);
        this.panelbg.Controls.Add(this.pictureBox3);
        this.panelbg.Controls.Add(this.pictureBox2);
        this.panelbg.Controls.Add(this.shiptypeicon);
        this.panelbg.Location = new System.Drawing.Point(291, 76);
        this.panelbg.Name = "panelbg";
        this.panelbg.Size = new System.Drawing.Size(676, 684);
        this.panelbg.TabIndex = 10;
        // 
        // star6
        // 
        this.star6.Image = ((System.Drawing.Image)(resources.GetObject("star6.Image")));
        this.star6.Location = new System.Drawing.Point(46, 296);
        this.star6.Name = "star6";
        this.star6.Size = new System.Drawing.Size(25, 25);
        this.star6.TabIndex = 79;
        this.star6.TabStop = false;
        // 
        // star5
        // 
        this.star5.Image = ((System.Drawing.Image)(resources.GetObject("star5.Image")));
        this.star5.Location = new System.Drawing.Point(46, 324);
        this.star5.Name = "star5";
        this.star5.Size = new System.Drawing.Size(25, 25);
        this.star5.TabIndex = 78;
        this.star5.TabStop = false;
        // 
        // star4
        // 
        this.star4.Image = ((System.Drawing.Image)(resources.GetObject("star4.Image")));
        this.star4.Location = new System.Drawing.Point(46, 353);
        this.star4.Name = "star4";
        this.star4.Size = new System.Drawing.Size(25, 25);
        this.star4.TabIndex = 77;
        this.star4.TabStop = false;
        // 
        // star3
        // 
        this.star3.Image = ((System.Drawing.Image)(resources.GetObject("star3.Image")));
        this.star3.Location = new System.Drawing.Point(46, 381);
        this.star3.Name = "star3";
        this.star3.Size = new System.Drawing.Size(25, 25);
        this.star3.TabIndex = 76;
        this.star3.TabStop = false;
        // 
        // star2
        // 
        this.star2.Image = ((System.Drawing.Image)(resources.GetObject("star2.Image")));
        this.star2.Location = new System.Drawing.Point(46, 410);
        this.star2.Name = "star2";
        this.star2.Size = new System.Drawing.Size(25, 25);
        this.star2.TabIndex = 75;
        this.star2.TabStop = false;
        // 
        // star1
        // 
        this.star1.Image = ((System.Drawing.Image)(resources.GetObject("star1.Image")));
        this.star1.Location = new System.Drawing.Point(46, 438);
        this.star1.Name = "star1";
        this.star1.Size = new System.Drawing.Size(25, 25);
        this.star1.TabIndex = 74;
        this.star1.TabStop = false;
        // 
        // modicon
        // 
        this.modicon.Image = ((System.Drawing.Image)(resources.GetObject("modicon.Image")));
        this.modicon.Location = new System.Drawing.Point(107, 16);
        this.modicon.Name = "modicon";
        this.modicon.Size = new System.Drawing.Size(111, 67);
        this.modicon.TabIndex = 73;
        this.modicon.TabStop = false;
        // 
        // weapon4
        // 
        this.weapon4.Image = ((System.Drawing.Image)(resources.GetObject("weapon4.Image")));
        this.weapon4.Location = new System.Drawing.Point(453, 166);
        this.weapon4.Name = "weapon4";
        this.weapon4.Size = new System.Drawing.Size(100, 100);
        this.weapon4.TabIndex = 58;
        this.weapon4.TabStop = false;
        this.weapon4.Click += new System.EventHandler(this.weapon4_Click);
        // 
        // weapon3
        // 
        this.weapon3.Image = ((System.Drawing.Image)(resources.GetObject("weapon3.Image")));
        this.weapon3.Location = new System.Drawing.Point(333, 166);
        this.weapon3.Name = "weapon3";
        this.weapon3.Size = new System.Drawing.Size(100, 100);
        this.weapon3.TabIndex = 51;
        this.weapon3.TabStop = false;
        this.weapon3.Click += new System.EventHandler(this.weapon3_Click);
        // 
        // weapon2
        // 
        this.weapon2.Image = ((System.Drawing.Image)(resources.GetObject("weapon2.Image")));
        this.weapon2.Location = new System.Drawing.Point(211, 166);
        this.weapon2.Name = "weapon2";
        this.weapon2.Size = new System.Drawing.Size(100, 100);
        this.weapon2.TabIndex = 44;
        this.weapon2.TabStop = false;
        this.weapon2.Click += new System.EventHandler(this.weapon2_Click);
        // 
        // weapon1
        // 
        this.weapon1.Image = ((System.Drawing.Image)(resources.GetObject("weapon1.Image")));
        this.weapon1.Location = new System.Drawing.Point(92, 166);
        this.weapon1.Name = "weapon1";
        this.weapon1.Size = new System.Drawing.Size(100, 100);
        this.weapon1.TabIndex = 37;
        this.weapon1.TabStop = false;
        this.weapon1.Click += new System.EventHandler(this.weapon1_Click);
        // 
        // pictureBox10
        // 
        this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
        this.pictureBox10.Location = new System.Drawing.Point(428, 499);
        this.pictureBox10.Name = "pictureBox10";
        this.pictureBox10.Size = new System.Drawing.Size(36, 35);
        this.pictureBox10.TabIndex = 34;
        this.pictureBox10.TabStop = false;
        // 
        // pictureBox11
        // 
        this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
        this.pictureBox11.Location = new System.Drawing.Point(428, 456);
        this.pictureBox11.Name = "pictureBox11";
        this.pictureBox11.Size = new System.Drawing.Size(36, 35);
        this.pictureBox11.TabIndex = 31;
        this.pictureBox11.TabStop = false;
        // 
        // pictureBox12
        // 
        this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
        this.pictureBox12.Location = new System.Drawing.Point(428, 413);
        this.pictureBox12.Name = "pictureBox12";
        this.pictureBox12.Size = new System.Drawing.Size(36, 35);
        this.pictureBox12.TabIndex = 28;
        this.pictureBox12.TabStop = false;
        // 
        // pictureBox13
        // 
        this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
        this.pictureBox13.Location = new System.Drawing.Point(428, 370);
        this.pictureBox13.Name = "pictureBox13";
        this.pictureBox13.Size = new System.Drawing.Size(36, 35);
        this.pictureBox13.TabIndex = 25;
        this.pictureBox13.TabStop = false;
        // 
        // pictureBox6
        // 
        this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
        this.pictureBox6.Location = new System.Drawing.Point(289, 499);
        this.pictureBox6.Name = "pictureBox6";
        this.pictureBox6.Size = new System.Drawing.Size(36, 35);
        this.pictureBox6.TabIndex = 22;
        this.pictureBox6.TabStop = false;
        // 
        // pictureBox7
        // 
        this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
        this.pictureBox7.Location = new System.Drawing.Point(289, 456);
        this.pictureBox7.Name = "pictureBox7";
        this.pictureBox7.Size = new System.Drawing.Size(36, 35);
        this.pictureBox7.TabIndex = 19;
        this.pictureBox7.TabStop = false;
        // 
        // pictureBox8
        // 
        this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
        this.pictureBox8.Location = new System.Drawing.Point(289, 413);
        this.pictureBox8.Name = "pictureBox8";
        this.pictureBox8.Size = new System.Drawing.Size(36, 35);
        this.pictureBox8.TabIndex = 16;
        this.pictureBox8.TabStop = false;
        // 
        // pictureBox9
        // 
        this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
        this.pictureBox9.Location = new System.Drawing.Point(289, 370);
        this.pictureBox9.Name = "pictureBox9";
        this.pictureBox9.Size = new System.Drawing.Size(36, 35);
        this.pictureBox9.TabIndex = 13;
        this.pictureBox9.TabStop = false;
        // 
        // pictureBox5
        // 
        this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
        this.pictureBox5.Location = new System.Drawing.Point(149, 499);
        this.pictureBox5.Name = "pictureBox5";
        this.pictureBox5.Size = new System.Drawing.Size(36, 35);
        this.pictureBox5.TabIndex = 10;
        this.pictureBox5.TabStop = false;
        // 
        // pictureBox4
        // 
        this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
        this.pictureBox4.Location = new System.Drawing.Point(149, 456);
        this.pictureBox4.Name = "pictureBox4";
        this.pictureBox4.Size = new System.Drawing.Size(36, 35);
        this.pictureBox4.TabIndex = 7;
        this.pictureBox4.TabStop = false;
        // 
        // pictureBox3
        // 
        this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
        this.pictureBox3.Location = new System.Drawing.Point(149, 413);
        this.pictureBox3.Name = "pictureBox3";
        this.pictureBox3.Size = new System.Drawing.Size(36, 35);
        this.pictureBox3.TabIndex = 4;
        this.pictureBox3.TabStop = false;
        // 
        // pictureBox2
        // 
        this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
        this.pictureBox2.Location = new System.Drawing.Point(149, 370);
        this.pictureBox2.Name = "pictureBox2";
        this.pictureBox2.Size = new System.Drawing.Size(36, 35);
        this.pictureBox2.TabIndex = 1;
        this.pictureBox2.TabStop = false;
        // 
        // shiptypeicon
        // 
        this.shiptypeicon.Image = ((System.Drawing.Image)(resources.GetObject("shiptypeicon.Image")));
        this.shiptypeicon.Location = new System.Drawing.Point(8, 480);
        this.shiptypeicon.Name = "shiptypeicon";
        this.shiptypeicon.Size = new System.Drawing.Size(67, 66);
        this.shiptypeicon.TabIndex = 0;
        this.shiptypeicon.TabStop = false;
        // 
        // timer1
        // 
        this.timer1.Interval = 2500;
        this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        // 
        // ShipForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.AutoScroll = true;
        this.ClientSize = new System.Drawing.Size(1028, 705);
        this.Controls.Add(this.bg);
        this.Controls.Add(this.equiplist);
        this.DoubleBuffered = true;
        this.Name = "ShipForm";
        this.Text = "CommandForm";
        this.bg.ResumeLayout(false);
        this.biglihui.ResumeLayout(false);
        this.chainanim.ResumeLayout(false);
        this.panelbg.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.star6)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.star5)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.star4)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.star3)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.star2)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.star1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.modicon)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.weapon4)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.weapon3)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.weapon2)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.weapon1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.shiptypeicon)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private DevComponents.DotNetBar.SuperGrid.SuperGridControl equiplist;
    private System.Windows.Forms.Panel bg;
    private System.Windows.Forms.Panel biglihui;
    private System.Windows.Forms.Panel panelbg;
    private System.Windows.Forms.Panel chainanim;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.PictureBox shiptypeicon;
    private cSouza.WinForms.Controls.BorderLabel attr12;
    private cSouza.WinForms.Controls.BorderLabel label17;
    private System.Windows.Forms.PictureBox pictureBox10;
    private cSouza.WinForms.Controls.BorderLabel attr9;
    private cSouza.WinForms.Controls.BorderLabel label19;
    private System.Windows.Forms.PictureBox pictureBox11;
    private cSouza.WinForms.Controls.BorderLabel attr6;
    private cSouza.WinForms.Controls.BorderLabel label21;
    private System.Windows.Forms.PictureBox pictureBox12;
    private cSouza.WinForms.Controls.BorderLabel attr3;
    private cSouza.WinForms.Controls.BorderLabel label23;
    private System.Windows.Forms.PictureBox pictureBox13;
    private cSouza.WinForms.Controls.BorderLabel attr11;
    private cSouza.WinForms.Controls.BorderLabel label9;
    private System.Windows.Forms.PictureBox pictureBox6;
    private cSouza.WinForms.Controls.BorderLabel attr8;
    private cSouza.WinForms.Controls.BorderLabel label11;
    private System.Windows.Forms.PictureBox pictureBox7;
    private cSouza.WinForms.Controls.BorderLabel attr5;
    private cSouza.WinForms.Controls.BorderLabel label13;
    private System.Windows.Forms.PictureBox pictureBox8;
    private cSouza.WinForms.Controls.BorderLabel attr2;
    private cSouza.WinForms.Controls.BorderLabel label15;
    private System.Windows.Forms.PictureBox pictureBox9;
    private cSouza.WinForms.Controls.BorderLabel attr10;
    private cSouza.WinForms.Controls.BorderLabel label7;
    private System.Windows.Forms.PictureBox pictureBox5;
    private cSouza.WinForms.Controls.BorderLabel attr7;
    private cSouza.WinForms.Controls.BorderLabel label5;
    private System.Windows.Forms.PictureBox pictureBox4;
    private cSouza.WinForms.Controls.BorderLabel attr4;
    private cSouza.WinForms.Controls.BorderLabel label3;
    private System.Windows.Forms.PictureBox pictureBox3;
    private cSouza.WinForms.Controls.BorderLabel attr1;
    private cSouza.WinForms.Controls.BorderLabel label1;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox weapon1;
    private cSouza.WinForms.Controls.BorderLabel weapon1count;
    private cSouza.WinForms.Controls.BorderLabel weapon1prop1val;
    private cSouza.WinForms.Controls.BorderLabel weapon1prop1;
    private cSouza.WinForms.Controls.BorderLabel weapon1prop3val;
    private cSouza.WinForms.Controls.BorderLabel weapon1prop3;
    private cSouza.WinForms.Controls.BorderLabel weapon1prop2val;
    private cSouza.WinForms.Controls.BorderLabel weapon1prop2;
    private System.Windows.Forms.PictureBox weapon4;
    private cSouza.WinForms.Controls.BorderLabel weapon4count;
    private cSouza.WinForms.Controls.BorderLabel weapon4prop3val;
    private cSouza.WinForms.Controls.BorderLabel weapon4prop3;
    private cSouza.WinForms.Controls.BorderLabel weapon4prop2val;
    private cSouza.WinForms.Controls.BorderLabel weapon4prop2;
    private cSouza.WinForms.Controls.BorderLabel weapon4prop1val;
    private cSouza.WinForms.Controls.BorderLabel weapon4prop1;
    private System.Windows.Forms.PictureBox weapon3;
    private cSouza.WinForms.Controls.BorderLabel weapon3count;
    private cSouza.WinForms.Controls.BorderLabel weapon3prop3val;
    private cSouza.WinForms.Controls.BorderLabel weapon3prop3;
    private cSouza.WinForms.Controls.BorderLabel weapon3prop2val;
    private cSouza.WinForms.Controls.BorderLabel weapon3prop2;
    private cSouza.WinForms.Controls.BorderLabel weapon3prop1val;
    private cSouza.WinForms.Controls.BorderLabel weapon3prop1;
    private System.Windows.Forms.PictureBox weapon2;
    private cSouza.WinForms.Controls.BorderLabel weapon2count;
    private cSouza.WinForms.Controls.BorderLabel weapon2prop3val;
    private cSouza.WinForms.Controls.BorderLabel weapon2prop3;
    private cSouza.WinForms.Controls.BorderLabel weapon2prop2val;
    private cSouza.WinForms.Controls.BorderLabel weapon2prop2;
    private cSouza.WinForms.Controls.BorderLabel weapon2prop1val;
    private cSouza.WinForms.Controls.BorderLabel weapon2prop1;
    private cSouza.WinForms.Controls.BorderLabel weapon1name;
    private cSouza.WinForms.Controls.BorderLabel weapon2name;
    private cSouza.WinForms.Controls.BorderLabel weapon3name;
    private cSouza.WinForms.Controls.BorderLabel weapon4name;
    private cSouza.WinForms.Controls.BorderLabel shiptitle;
    private cSouza.WinForms.Controls.BorderLabel shipsubtitle;
    private cSouza.WinForms.Controls.BorderLabel borderLabel33;
    private cSouza.WinForms.Controls.BorderLabel shipnumber;
    private System.Windows.Forms.PictureBox modicon;
    private System.Windows.Forms.PictureBox star1;
    private System.Windows.Forms.PictureBox star6;
    private System.Windows.Forms.PictureBox star5;
    private System.Windows.Forms.PictureBox star4;
    private System.Windows.Forms.PictureBox star3;
    private System.Windows.Forms.PictureBox star2;
    private cSouza.WinForms.Controls.BorderLabel shiplevel;
    private cSouza.WinForms.Controls.BorderLabel shipvow2;
    private cSouza.WinForms.Controls.BorderLabel shipvow1;
}