
namespace Mancala
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.human1 = new System.Windows.Forms.CheckBox();
            this.computer1 = new System.Windows.Forms.CheckBox();
            this.human2 = new System.Windows.Forms.CheckBox();
            this.computer2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.slot6 = new System.Windows.Forms.TextBox();
            this.slot13 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.slot12 = new System.Windows.Forms.Label();
            this.slot5 = new System.Windows.Forms.Label();
            this.slot7 = new System.Windows.Forms.Label();
            this.slot8 = new System.Windows.Forms.Label();
            this.slot4 = new System.Windows.Forms.Label();
            this.slot9 = new System.Windows.Forms.Label();
            this.slot3 = new System.Windows.Forms.Label();
            this.slot10 = new System.Windows.Forms.Label();
            this.slot2 = new System.Windows.Forms.Label();
            this.slot11 = new System.Windows.Forms.Label();
            this.slot1 = new System.Windows.Forms.Label();
            this.slot0 = new System.Windows.Forms.Label();
            this.T0 = new System.Windows.Forms.Button();
            this.T1 = new System.Windows.Forms.Button();
            this.T2 = new System.Windows.Forms.Button();
            this.T3 = new System.Windows.Forms.Button();
            this.T4 = new System.Windows.Forms.Button();
            this.T5 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B0 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Score: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Player 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Score: 0";
            // 
            // human1
            // 
            this.human1.AutoSize = true;
            this.human1.Location = new System.Drawing.Point(16, 57);
            this.human1.Margin = new System.Windows.Forms.Padding(4);
            this.human1.Name = "human1";
            this.human1.Size = new System.Drawing.Size(72, 20);
            this.human1.TabIndex = 9;
            this.human1.Text = "Human";
            this.human1.UseVisualStyleBackColor = true;
            this.human1.CheckedChanged += new System.EventHandler(this.human1_CheckedChanged);
            // 
            // computer1
            // 
            this.computer1.AutoSize = true;
            this.computer1.Location = new System.Drawing.Point(104, 57);
            this.computer1.Margin = new System.Windows.Forms.Padding(4);
            this.computer1.Name = "computer1";
            this.computer1.Size = new System.Drawing.Size(87, 20);
            this.computer1.TabIndex = 10;
            this.computer1.Text = "Computer";
            this.computer1.UseVisualStyleBackColor = true;
            this.computer1.CheckedChanged += new System.EventHandler(this.computer1_CheckedChanged);
            // 
            // human2
            // 
            this.human2.AutoSize = true;
            this.human2.Location = new System.Drawing.Point(16, 150);
            this.human2.Margin = new System.Windows.Forms.Padding(4);
            this.human2.Name = "human2";
            this.human2.Size = new System.Drawing.Size(72, 20);
            this.human2.TabIndex = 11;
            this.human2.Text = "Human";
            this.human2.UseVisualStyleBackColor = true;
            this.human2.CheckedChanged += new System.EventHandler(this.human2_CheckedChanged);
            // 
            // computer2
            // 
            this.computer2.AutoSize = true;
            this.computer2.Location = new System.Drawing.Point(104, 150);
            this.computer2.Margin = new System.Windows.Forms.Padding(4);
            this.computer2.Name = "computer2";
            this.computer2.Size = new System.Drawing.Size(87, 20);
            this.computer2.TabIndex = 12;
            this.computer2.Text = "Computer";
            this.computer2.UseVisualStyleBackColor = true;
            this.computer2.CheckedChanged += new System.EventHandler(this.computer2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 217);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 27;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 252);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 28;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // slot6
            // 
            this.slot6.BackColor = System.Drawing.Color.Tan;
            this.slot6.Location = new System.Drawing.Point(317, 418);
            this.slot6.Margin = new System.Windows.Forms.Padding(4);
            this.slot6.Name = "slot6";
            this.slot6.Size = new System.Drawing.Size(156, 22);
            this.slot6.TabIndex = 29;
            this.slot6.Text = "0";
            this.slot6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // slot13
            // 
            this.slot13.BackColor = System.Drawing.Color.Tan;
            this.slot13.Location = new System.Drawing.Point(318, 25);
            this.slot13.Margin = new System.Windows.Forms.Padding(4);
            this.slot13.Name = "slot13";
            this.slot13.Size = new System.Drawing.Size(156, 22);
            this.slot13.TabIndex = 30;
            this.slot13.Text = "0";
            this.slot13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.slot13.TextChanged += new System.EventHandler(this.slot13_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(124, 217);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 44;
            this.button3.Text = "Drop Marbles";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // slot12
            // 
            this.slot12.AutoSize = true;
            this.slot12.Image = global::Mancala.Properties.Resources.mancalaBrown;
            this.slot12.Location = new System.Drawing.Point(474, 90);
            this.slot12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.slot12.Name = "slot12";
            this.slot12.Size = new System.Drawing.Size(14, 16);
            this.slot12.TabIndex = 32;
            this.slot12.Text = "4";
            this.slot12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.slot12.Visible = false;
            // 
            // slot5
            // 
            this.slot5.AutoSize = true;
            this.slot5.Image = global::Mancala.Properties.Resources.mancalaBrown;
            this.slot5.Location = new System.Drawing.Point(304, 371);
            this.slot5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.slot5.Name = "slot5";
            this.slot5.Size = new System.Drawing.Size(14, 16);
            this.slot5.TabIndex = 42;
            this.slot5.Text = "4";
            this.slot5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.slot5.Visible = false;
            // 
            // slot7
            // 
            this.slot7.AutoSize = true;
            this.slot7.Image = global::Mancala.Properties.Resources.mancalaBrown;
            this.slot7.Location = new System.Drawing.Point(473, 370);
            this.slot7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.slot7.Name = "slot7";
            this.slot7.Size = new System.Drawing.Size(14, 16);
            this.slot7.TabIndex = 41;
            this.slot7.Text = "4";
            this.slot7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.slot7.Visible = false;
            // 
            // slot8
            // 
            this.slot8.AutoSize = true;
            this.slot8.Image = global::Mancala.Properties.Resources.mancalaBrown;
            this.slot8.Location = new System.Drawing.Point(473, 311);
            this.slot8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.slot8.Name = "slot8";
            this.slot8.Size = new System.Drawing.Size(14, 16);
            this.slot8.TabIndex = 40;
            this.slot8.Text = "4";
            this.slot8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.slot8.Visible = false;
            // 
            // slot4
            // 
            this.slot4.AutoSize = true;
            this.slot4.Image = global::Mancala.Properties.Resources.mancalaBrown;
            this.slot4.Location = new System.Drawing.Point(304, 313);
            this.slot4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.slot4.Name = "slot4";
            this.slot4.Size = new System.Drawing.Size(14, 16);
            this.slot4.TabIndex = 39;
            this.slot4.Text = "4";
            this.slot4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.slot4.Visible = false;
            // 
            // slot9
            // 
            this.slot9.AutoSize = true;
            this.slot9.Image = global::Mancala.Properties.Resources.mancalaBrown;
            this.slot9.Location = new System.Drawing.Point(474, 256);
            this.slot9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.slot9.Name = "slot9";
            this.slot9.Size = new System.Drawing.Size(14, 16);
            this.slot9.TabIndex = 38;
            this.slot9.Text = "4";
            this.slot9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.slot9.Visible = false;
            // 
            // slot3
            // 
            this.slot3.AutoSize = true;
            this.slot3.Image = global::Mancala.Properties.Resources.mancalaBrown;
            this.slot3.Location = new System.Drawing.Point(304, 258);
            this.slot3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.slot3.Name = "slot3";
            this.slot3.Size = new System.Drawing.Size(14, 16);
            this.slot3.TabIndex = 37;
            this.slot3.Text = "4";
            this.slot3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.slot3.Visible = false;
            // 
            // slot10
            // 
            this.slot10.AutoSize = true;
            this.slot10.Image = global::Mancala.Properties.Resources.mancalaBrown;
            this.slot10.Location = new System.Drawing.Point(474, 203);
            this.slot10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.slot10.Name = "slot10";
            this.slot10.Size = new System.Drawing.Size(14, 16);
            this.slot10.TabIndex = 36;
            this.slot10.Text = "4";
            this.slot10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.slot10.Visible = false;
            // 
            // slot2
            // 
            this.slot2.AutoSize = true;
            this.slot2.Image = global::Mancala.Properties.Resources.mancalaBrown;
            this.slot2.Location = new System.Drawing.Point(304, 202);
            this.slot2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.slot2.Name = "slot2";
            this.slot2.Size = new System.Drawing.Size(14, 16);
            this.slot2.TabIndex = 35;
            this.slot2.Text = "4";
            this.slot2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.slot2.Visible = false;
            // 
            // slot11
            // 
            this.slot11.AutoSize = true;
            this.slot11.Image = global::Mancala.Properties.Resources.mancalaBrown;
            this.slot11.Location = new System.Drawing.Point(474, 147);
            this.slot11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.slot11.Name = "slot11";
            this.slot11.Size = new System.Drawing.Size(14, 16);
            this.slot11.TabIndex = 34;
            this.slot11.Text = "4";
            this.slot11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.slot11.Visible = false;
            // 
            // slot1
            // 
            this.slot1.AutoSize = true;
            this.slot1.Image = global::Mancala.Properties.Resources.mancalaBrown;
            this.slot1.Location = new System.Drawing.Point(304, 150);
            this.slot1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.slot1.Name = "slot1";
            this.slot1.Size = new System.Drawing.Size(14, 16);
            this.slot1.TabIndex = 33;
            this.slot1.Text = "4";
            this.slot1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.slot1.Visible = false;
            // 
            // slot0
            // 
            this.slot0.AutoSize = true;
            this.slot0.Image = global::Mancala.Properties.Resources.mancalaBrown;
            this.slot0.Location = new System.Drawing.Point(304, 90);
            this.slot0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.slot0.Name = "slot0";
            this.slot0.Size = new System.Drawing.Size(14, 16);
            this.slot0.TabIndex = 31;
            this.slot0.Text = "4";
            this.slot0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.slot0.Visible = false;
            this.slot0.Click += new System.EventHandler(this.label5_Click);
            // 
            // T0
            // 
            this.T0.BackColor = System.Drawing.Color.Transparent;
            this.T0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("T0.BackgroundImage")));
            this.T0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.T0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.T0.Location = new System.Drawing.Point(403, 352);
            this.T0.Name = "T0";
            this.T0.Size = new System.Drawing.Size(70, 49);
            this.T0.TabIndex = 67;
            this.T0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.T0.UseVisualStyleBackColor = false;
            this.T0.Click += new System.EventHandler(this.T0_Click);
            // 
            // T1
            // 
            this.T1.BackColor = System.Drawing.Color.Transparent;
            this.T1.BackgroundImage = global::Mancala.Properties.Resources.MancalaWood2;
            this.T1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.T1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.T1.Location = new System.Drawing.Point(403, 295);
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(70, 49);
            this.T1.TabIndex = 66;
            this.T1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.T1.UseVisualStyleBackColor = false;
            this.T1.Click += new System.EventHandler(this.T1_Click);
            // 
            // T2
            // 
            this.T2.BackColor = System.Drawing.Color.Transparent;
            this.T2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("T2.BackgroundImage")));
            this.T2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.T2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.T2.Location = new System.Drawing.Point(404, 242);
            this.T2.Name = "T2";
            this.T2.Size = new System.Drawing.Size(70, 49);
            this.T2.TabIndex = 65;
            this.T2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.T2.UseVisualStyleBackColor = false;
            this.T2.Click += new System.EventHandler(this.T2_Click);
            // 
            // T3
            // 
            this.T3.BackColor = System.Drawing.Color.Transparent;
            this.T3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("T3.BackgroundImage")));
            this.T3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.T3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.T3.Location = new System.Drawing.Point(403, 187);
            this.T3.Name = "T3";
            this.T3.Size = new System.Drawing.Size(70, 49);
            this.T3.TabIndex = 64;
            this.T3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.T3.UseVisualStyleBackColor = false;
            this.T3.Click += new System.EventHandler(this.T3_Click);
            // 
            // T4
            // 
            this.T4.BackColor = System.Drawing.Color.Transparent;
            this.T4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("T4.BackgroundImage")));
            this.T4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.T4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.T4.Location = new System.Drawing.Point(403, 128);
            this.T4.Name = "T4";
            this.T4.Size = new System.Drawing.Size(70, 49);
            this.T4.TabIndex = 63;
            this.T4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.T4.UseVisualStyleBackColor = false;
            this.T4.Click += new System.EventHandler(this.T4_Click);
            // 
            // T5
            // 
            this.T5.BackColor = System.Drawing.Color.Transparent;
            this.T5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("T5.BackgroundImage")));
            this.T5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.T5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.T5.Location = new System.Drawing.Point(403, 73);
            this.T5.Name = "T5";
            this.T5.Size = new System.Drawing.Size(70, 49);
            this.T5.TabIndex = 62;
            this.T5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.T5.UseVisualStyleBackColor = false;
            this.T5.Click += new System.EventHandler(this.T5_Click);
            // 
            // B5
            // 
            this.B5.BackColor = System.Drawing.Color.Transparent;
            this.B5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B5.BackgroundImage")));
            this.B5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B5.Location = new System.Drawing.Point(318, 352);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(70, 49);
            this.B5.TabIndex = 61;
            this.B5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.B5.UseVisualStyleBackColor = false;
            this.B5.Click += new System.EventHandler(this.B5_Click);
            // 
            // B4
            // 
            this.B4.BackColor = System.Drawing.Color.Transparent;
            this.B4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B4.BackgroundImage")));
            this.B4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B4.Location = new System.Drawing.Point(318, 297);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(70, 49);
            this.B4.TabIndex = 60;
            this.B4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.B4.UseVisualStyleBackColor = false;
            this.B4.Click += new System.EventHandler(this.B4_Click);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.Transparent;
            this.B3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B3.BackgroundImage")));
            this.B3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B3.Location = new System.Drawing.Point(317, 242);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(70, 49);
            this.B3.TabIndex = 59;
            this.B3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.B3_Click);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.Transparent;
            this.B2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B2.BackgroundImage")));
            this.B2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B2.Location = new System.Drawing.Point(318, 187);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(70, 49);
            this.B2.TabIndex = 58;
            this.B2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.Transparent;
            this.B1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B1.BackgroundImage")));
            this.B1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B1.Location = new System.Drawing.Point(318, 130);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(70, 49);
            this.B1.TabIndex = 57;
            this.B1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // B0
            // 
            this.B0.BackColor = System.Drawing.Color.Transparent;
            this.B0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B0.BackgroundImage")));
            this.B0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B0.Location = new System.Drawing.Point(318, 74);
            this.B0.Name = "B0";
            this.B0.Size = new System.Drawing.Size(70, 49);
            this.B0.TabIndex = 56;
            this.B0.Text = "B0";
            this.B0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.B0.UseVisualStyleBackColor = false;
            this.B0.Click += new System.EventHandler(this.B0_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Mancala.Properties.Resources.MancalaWood2;
            this.pictureBox4.Location = new System.Drawing.Point(317, 407);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(157, 48);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Mancala.Properties.Resources.MancalaWood2;
            this.pictureBox3.Location = new System.Drawing.Point(318, 18);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(157, 48);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 599);
            this.Controls.Add(this.slot12);
            this.Controls.Add(this.slot5);
            this.Controls.Add(this.slot7);
            this.Controls.Add(this.slot8);
            this.Controls.Add(this.slot4);
            this.Controls.Add(this.slot9);
            this.Controls.Add(this.slot3);
            this.Controls.Add(this.slot10);
            this.Controls.Add(this.slot2);
            this.Controls.Add(this.slot11);
            this.Controls.Add(this.slot1);
            this.Controls.Add(this.slot0);
            this.Controls.Add(this.T0);
            this.Controls.Add(this.T1);
            this.Controls.Add(this.T2);
            this.Controls.Add(this.T3);
            this.Controls.Add(this.T4);
            this.Controls.Add(this.T5);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B0);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.slot13);
            this.Controls.Add(this.slot6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.computer2);
            this.Controls.Add(this.human2);
            this.Controls.Add(this.computer1);
            this.Controls.Add(this.human1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox human1;
        private System.Windows.Forms.CheckBox computer1;
        private System.Windows.Forms.CheckBox human2;
        private System.Windows.Forms.CheckBox computer2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox slot6;
        private System.Windows.Forms.TextBox slot13;
        private System.Windows.Forms.Label slot0;
        private System.Windows.Forms.Label slot12;
        private System.Windows.Forms.Label slot1;
        private System.Windows.Forms.Label slot11;
        private System.Windows.Forms.Label slot2;
        private System.Windows.Forms.Label slot10;
        private System.Windows.Forms.Label slot3;
        private System.Windows.Forms.Label slot9;
        private System.Windows.Forms.Label slot4;
        private System.Windows.Forms.Label slot8;
        private System.Windows.Forms.Label slot7;
        private System.Windows.Forms.Label slot5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button B0;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button B5;
        private System.Windows.Forms.Button T5;
        private System.Windows.Forms.Button T4;
        private System.Windows.Forms.Button T3;
        private System.Windows.Forms.Button T2;
        private System.Windows.Forms.Button T1;
        private System.Windows.Forms.Button T0;
    }
}

