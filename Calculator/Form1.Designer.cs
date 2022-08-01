namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.NormalSizeButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.MaxSizeButton = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.ButtonEquals = new System.Windows.Forms.Button();
            this.ButtonDenominator = new System.Windows.Forms.Button();
            this.ButtonZero = new System.Windows.Forms.Button();
            this.ButtonNegative = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.ButtonMultiply = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.ButtonDivide = new System.Windows.Forms.Button();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.ButtonC = new System.Windows.Forms.Button();
            this.ButtonCE = new System.Windows.Forms.Button();
            this.button1X = new System.Windows.Forms.Button();
            this.buttonDegree = new System.Windows.Forms.Button();
            this.buttonRoot = new System.Windows.Forms.Button();
            this.ButtonPercent = new System.Windows.Forms.Button();
            this.ButtonMMinus = new System.Windows.Forms.Button();
            this.ButtonMS = new System.Windows.Forms.Button();
            this.ButtonMPlus = new System.Windows.Forms.Button();
            this.ButtonMR = new System.Windows.Forms.Button();
            this.ButtonMC = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.Control;
            this.TopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Controls.Add(this.NormalSizeButton);
            this.TopPanel.Controls.Add(this.MinimizeButton);
            this.TopPanel.Controls.Add(this.MaxSizeButton);
            this.TopPanel.Controls.Add(this.ButtonClose);
            this.TopPanel.Controls.Add(this.Title);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(302, 32);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // NormalSizeButton
            // 
            this.NormalSizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NormalSizeButton.Location = new System.Drawing.Point(240, 0);
            this.NormalSizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.NormalSizeButton.Name = "NormalSizeButton";
            this.NormalSizeButton.Size = new System.Drawing.Size(30, 30);
            this.NormalSizeButton.TabIndex = 4;
            this.NormalSizeButton.Text = "[]";
            this.NormalSizeButton.UseVisualStyleBackColor = true;
            this.NormalSizeButton.Visible = false;
            this.NormalSizeButton.Click += new System.EventHandler(this.NormalSizeButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MinimizeButton.Location = new System.Drawing.Point(210, 0);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(30, 30);
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // MaxSizeButton
            // 
            this.MaxSizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaxSizeButton.Location = new System.Drawing.Point(240, 0);
            this.MaxSizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MaxSizeButton.Name = "MaxSizeButton";
            this.MaxSizeButton.Size = new System.Drawing.Size(30, 30);
            this.MaxSizeButton.TabIndex = 2;
            this.MaxSizeButton.Text = "[  ]";
            this.MaxSizeButton.UseVisualStyleBackColor = true;
            this.MaxSizeButton.Click += new System.EventHandler(this.MaxSizeButton_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClose.Location = new System.Drawing.Point(270, 0);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(30, 30);
            this.ButtonClose.TabIndex = 1;
            this.ButtonClose.Text = "X";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(3, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(61, 15);
            this.Title.TabIndex = 0;
            this.Title.Text = "Calculator";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 57);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // ControlPanel
            // 
            this.ControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ControlPanel.Controls.Add(this.ButtonEquals);
            this.ControlPanel.Controls.Add(this.textBox1);
            this.ControlPanel.Controls.Add(this.ButtonDenominator);
            this.ControlPanel.Controls.Add(this.ButtonZero);
            this.ControlPanel.Controls.Add(this.ButtonNegative);
            this.ControlPanel.Controls.Add(this.ButtonPlus);
            this.ControlPanel.Controls.Add(this.Button3);
            this.ControlPanel.Controls.Add(this.Button2);
            this.ControlPanel.Controls.Add(this.Button1);
            this.ControlPanel.Controls.Add(this.ButtonMinus);
            this.ControlPanel.Controls.Add(this.Button6);
            this.ControlPanel.Controls.Add(this.Button5);
            this.ControlPanel.Controls.Add(this.Button4);
            this.ControlPanel.Controls.Add(this.ButtonMultiply);
            this.ControlPanel.Controls.Add(this.Button9);
            this.ControlPanel.Controls.Add(this.Button8);
            this.ControlPanel.Controls.Add(this.Button7);
            this.ControlPanel.Controls.Add(this.ButtonDivide);
            this.ControlPanel.Controls.Add(this.ButtonRemove);
            this.ControlPanel.Controls.Add(this.ButtonC);
            this.ControlPanel.Controls.Add(this.ButtonCE);
            this.ControlPanel.Controls.Add(this.button1X);
            this.ControlPanel.Controls.Add(this.buttonDegree);
            this.ControlPanel.Controls.Add(this.buttonRoot);
            this.ControlPanel.Controls.Add(this.ButtonPercent);
            this.ControlPanel.Controls.Add(this.ButtonMMinus);
            this.ControlPanel.Controls.Add(this.ButtonMS);
            this.ControlPanel.Controls.Add(this.ButtonMPlus);
            this.ControlPanel.Controls.Add(this.ButtonMR);
            this.ControlPanel.Controls.Add(this.ButtonMC);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlPanel.Location = new System.Drawing.Point(0, 32);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(302, 485);
            this.ControlPanel.TabIndex = 2;
            // 
            // ButtonEquals
            // 
            this.ButtonEquals.AutoSize = true;
            this.ButtonEquals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEquals.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonEquals.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonEquals.Location = new System.Drawing.Point(225, 417);
            this.ButtonEquals.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonEquals.Name = "ButtonEquals";
            this.ButtonEquals.Size = new System.Drawing.Size(75, 66);
            this.ButtonEquals.TabIndex = 33;
            this.ButtonEquals.Text = "=";
            this.ButtonEquals.UseVisualStyleBackColor = true;
            this.ButtonEquals.Click += new System.EventHandler(this.ButtonEquals_Click);
            // 
            // ButtonDenominator
            // 
            this.ButtonDenominator.AutoSize = true;
            this.ButtonDenominator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDenominator.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonDenominator.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonDenominator.Location = new System.Drawing.Point(150, 417);
            this.ButtonDenominator.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonDenominator.Name = "ButtonDenominator";
            this.ButtonDenominator.Size = new System.Drawing.Size(75, 66);
            this.ButtonDenominator.TabIndex = 32;
            this.ButtonDenominator.Text = ",";
            this.ButtonDenominator.UseVisualStyleBackColor = true;
            this.ButtonDenominator.Click += new System.EventHandler(this.Button7_Click);
            // 
            // ButtonZero
            // 
            this.ButtonZero.AutoSize = true;
            this.ButtonZero.BackColor = System.Drawing.Color.White;
            this.ButtonZero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonZero.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonZero.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonZero.Location = new System.Drawing.Point(75, 417);
            this.ButtonZero.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonZero.Name = "ButtonZero";
            this.ButtonZero.Size = new System.Drawing.Size(75, 66);
            this.ButtonZero.TabIndex = 31;
            this.ButtonZero.Text = "0";
            this.ButtonZero.UseVisualStyleBackColor = false;
            this.ButtonZero.Click += new System.EventHandler(this.Button7_Click);
            // 
            // ButtonNegative
            // 
            this.ButtonNegative.AutoSize = true;
            this.ButtonNegative.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonNegative.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNegative.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonNegative.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonNegative.Location = new System.Drawing.Point(0, 417);
            this.ButtonNegative.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonNegative.Name = "ButtonNegative";
            this.ButtonNegative.Size = new System.Drawing.Size(75, 66);
            this.ButtonNegative.TabIndex = 30;
            this.ButtonNegative.Text = "±";
            this.ButtonNegative.UseCompatibleTextRendering = true;
            this.ButtonNegative.UseVisualStyleBackColor = false;
            this.ButtonNegative.Click += new System.EventHandler(this.ButtonNegative_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.AutoSize = true;
            this.ButtonPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPlus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonPlus.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonPlus.Location = new System.Drawing.Point(225, 351);
            this.ButtonPlus.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(75, 66);
            this.ButtonPlus.TabIndex = 29;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // Button3
            // 
            this.Button3.AutoSize = true;
            this.Button3.BackColor = System.Drawing.SystemColors.Control;
            this.Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button3.Location = new System.Drawing.Point(150, 351);
            this.Button3.Margin = new System.Windows.Forms.Padding(0);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(75, 66);
            this.Button3.TabIndex = 28;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Button2
            // 
            this.Button2.AutoSize = true;
            this.Button2.BackColor = System.Drawing.SystemColors.Control;
            this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button2.Location = new System.Drawing.Point(75, 351);
            this.Button2.Margin = new System.Windows.Forms.Padding(0);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 66);
            this.Button2.TabIndex = 27;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Button1
            // 
            this.Button1.AutoSize = true;
            this.Button1.BackColor = System.Drawing.SystemColors.Control;
            this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button1.Location = new System.Drawing.Point(0, 351);
            this.Button1.Margin = new System.Windows.Forms.Padding(0);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 66);
            this.Button1.TabIndex = 26;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button7_Click);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.AutoSize = true;
            this.ButtonMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMinus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonMinus.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonMinus.Location = new System.Drawing.Point(225, 285);
            this.ButtonMinus.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(75, 66);
            this.ButtonMinus.TabIndex = 25;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = true;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // Button6
            // 
            this.Button6.AutoSize = true;
            this.Button6.BackColor = System.Drawing.SystemColors.Control;
            this.Button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button6.Location = new System.Drawing.Point(150, 285);
            this.Button6.Margin = new System.Windows.Forms.Padding(0);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(75, 66);
            this.Button6.TabIndex = 24;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Button5
            // 
            this.Button5.AutoSize = true;
            this.Button5.BackColor = System.Drawing.SystemColors.Control;
            this.Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button5.Location = new System.Drawing.Point(75, 285);
            this.Button5.Margin = new System.Windows.Forms.Padding(0);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(75, 66);
            this.Button5.TabIndex = 23;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Button4
            // 
            this.Button4.AutoSize = true;
            this.Button4.BackColor = System.Drawing.SystemColors.Control;
            this.Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button4.Location = new System.Drawing.Point(0, 285);
            this.Button4.Margin = new System.Windows.Forms.Padding(0);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(75, 66);
            this.Button4.TabIndex = 22;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Button7_Click);
            // 
            // ButtonMultiply
            // 
            this.ButtonMultiply.AutoSize = true;
            this.ButtonMultiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonMultiply.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonMultiply.Location = new System.Drawing.Point(225, 219);
            this.ButtonMultiply.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonMultiply.Name = "ButtonMultiply";
            this.ButtonMultiply.Size = new System.Drawing.Size(75, 66);
            this.ButtonMultiply.TabIndex = 21;
            this.ButtonMultiply.Text = "*";
            this.ButtonMultiply.UseVisualStyleBackColor = true;
            this.ButtonMultiply.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // Button9
            // 
            this.Button9.AutoSize = true;
            this.Button9.BackColor = System.Drawing.SystemColors.Control;
            this.Button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button9.Location = new System.Drawing.Point(150, 219);
            this.Button9.Margin = new System.Windows.Forms.Padding(0);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(75, 66);
            this.Button9.TabIndex = 20;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = false;
            this.Button9.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Button8
            // 
            this.Button8.AutoSize = true;
            this.Button8.BackColor = System.Drawing.SystemColors.Control;
            this.Button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button8.Location = new System.Drawing.Point(75, 219);
            this.Button8.Margin = new System.Windows.Forms.Padding(0);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(75, 66);
            this.Button8.TabIndex = 19;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = false;
            this.Button8.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Button7
            // 
            this.Button7.AutoSize = true;
            this.Button7.BackColor = System.Drawing.SystemColors.Control;
            this.Button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button7.Location = new System.Drawing.Point(0, 219);
            this.Button7.Margin = new System.Windows.Forms.Padding(0);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(75, 66);
            this.Button7.TabIndex = 18;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = false;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // ButtonDivide
            // 
            this.ButtonDivide.AutoSize = true;
            this.ButtonDivide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDivide.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonDivide.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonDivide.Location = new System.Drawing.Point(225, 153);
            this.ButtonDivide.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Size = new System.Drawing.Size(75, 66);
            this.ButtonDivide.TabIndex = 17;
            this.ButtonDivide.Text = "/";
            this.ButtonDivide.UseVisualStyleBackColor = true;
            this.ButtonDivide.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.AutoSize = true;
            this.ButtonRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRemove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonRemove.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonRemove.Location = new System.Drawing.Point(150, 153);
            this.ButtonRemove.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(75, 66);
            this.ButtonRemove.TabIndex = 16;
            this.ButtonRemove.Text = "←";
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // ButtonC
            // 
            this.ButtonC.AutoSize = true;
            this.ButtonC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonC.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonC.Location = new System.Drawing.Point(75, 153);
            this.ButtonC.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonC.Name = "ButtonC";
            this.ButtonC.Size = new System.Drawing.Size(75, 66);
            this.ButtonC.TabIndex = 15;
            this.ButtonC.Text = "C";
            this.ButtonC.UseVisualStyleBackColor = true;
            this.ButtonC.Click += new System.EventHandler(this.ButtonC_Click);
            // 
            // ButtonCE
            // 
            this.ButtonCE.AutoSize = true;
            this.ButtonCE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCE.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonCE.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonCE.Location = new System.Drawing.Point(0, 153);
            this.ButtonCE.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCE.Name = "ButtonCE";
            this.ButtonCE.Size = new System.Drawing.Size(75, 66);
            this.ButtonCE.TabIndex = 14;
            this.ButtonCE.Text = "CE";
            this.ButtonCE.UseVisualStyleBackColor = true;
            this.ButtonCE.Click += new System.EventHandler(this.ButtonCE_Click);
            // 
            // button1X
            // 
            this.button1X.AutoSize = true;
            this.button1X.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1X.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1X.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1X.Location = new System.Drawing.Point(225, 87);
            this.button1X.Margin = new System.Windows.Forms.Padding(0);
            this.button1X.Name = "button1X";
            this.button1X.Size = new System.Drawing.Size(75, 66);
            this.button1X.TabIndex = 13;
            this.button1X.Text = "¹/x";
            this.button1X.UseVisualStyleBackColor = true;
            this.button1X.Click += new System.EventHandler(this.button1X_Click);
            // 
            // buttonDegree
            // 
            this.buttonDegree.AutoSize = true;
            this.buttonDegree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDegree.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDegree.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDegree.Location = new System.Drawing.Point(150, 87);
            this.buttonDegree.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDegree.Name = "buttonDegree";
            this.buttonDegree.Size = new System.Drawing.Size(75, 66);
            this.buttonDegree.TabIndex = 12;
            this.buttonDegree.Text = "X²";
            this.buttonDegree.UseVisualStyleBackColor = true;
            this.buttonDegree.Click += new System.EventHandler(this.buttonDegree_Click);
            // 
            // buttonRoot
            // 
            this.buttonRoot.AutoSize = true;
            this.buttonRoot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRoot.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRoot.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRoot.Location = new System.Drawing.Point(75, 87);
            this.buttonRoot.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRoot.Name = "buttonRoot";
            this.buttonRoot.Size = new System.Drawing.Size(75, 66);
            this.buttonRoot.TabIndex = 11;
            this.buttonRoot.Text = "√";
            this.buttonRoot.UseVisualStyleBackColor = true;
            this.buttonRoot.Click += new System.EventHandler(this.buttonRoot_Click);
            // 
            // ButtonPercent
            // 
            this.ButtonPercent.AutoSize = true;
            this.ButtonPercent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPercent.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonPercent.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonPercent.Location = new System.Drawing.Point(0, 87);
            this.ButtonPercent.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPercent.Name = "ButtonPercent";
            this.ButtonPercent.Size = new System.Drawing.Size(75, 66);
            this.ButtonPercent.TabIndex = 10;
            this.ButtonPercent.Text = "%";
            this.ButtonPercent.UseVisualStyleBackColor = true;
            this.ButtonPercent.Click += new System.EventHandler(this.ButtonPercent_Click);
            // 
            // ButtonMMinus
            // 
            this.ButtonMMinus.AutoSize = true;
            this.ButtonMMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMMinus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonMMinus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonMMinus.Location = new System.Drawing.Point(180, 57);
            this.ButtonMMinus.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonMMinus.Name = "ButtonMMinus";
            this.ButtonMMinus.Size = new System.Drawing.Size(60, 30);
            this.ButtonMMinus.TabIndex = 9;
            this.ButtonMMinus.Text = "M-";
            this.ButtonMMinus.UseVisualStyleBackColor = true;
            this.ButtonMMinus.Click += new System.EventHandler(this.ButtonMMinus_Click);
            // 
            // ButtonMS
            // 
            this.ButtonMS.AutoSize = true;
            this.ButtonMS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonMS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonMS.Location = new System.Drawing.Point(240, 57);
            this.ButtonMS.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonMS.Name = "ButtonMS";
            this.ButtonMS.Size = new System.Drawing.Size(60, 30);
            this.ButtonMS.TabIndex = 8;
            this.ButtonMS.Text = "MS";
            this.ButtonMS.UseVisualStyleBackColor = true;
            this.ButtonMS.Click += new System.EventHandler(this.ButtonMS_Click);
            // 
            // ButtonMPlus
            // 
            this.ButtonMPlus.AutoSize = true;
            this.ButtonMPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMPlus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonMPlus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonMPlus.Location = new System.Drawing.Point(120, 57);
            this.ButtonMPlus.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonMPlus.Name = "ButtonMPlus";
            this.ButtonMPlus.Size = new System.Drawing.Size(60, 30);
            this.ButtonMPlus.TabIndex = 7;
            this.ButtonMPlus.Text = "M+";
            this.ButtonMPlus.UseVisualStyleBackColor = true;
            this.ButtonMPlus.Click += new System.EventHandler(this.ButtonMPlus_Click);
            // 
            // ButtonMR
            // 
            this.ButtonMR.AutoSize = true;
            this.ButtonMR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMR.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonMR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonMR.Location = new System.Drawing.Point(60, 57);
            this.ButtonMR.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonMR.Name = "ButtonMR";
            this.ButtonMR.Size = new System.Drawing.Size(60, 30);
            this.ButtonMR.TabIndex = 6;
            this.ButtonMR.Text = "MR";
            this.ButtonMR.UseVisualStyleBackColor = true;
            this.ButtonMR.Click += new System.EventHandler(this.ButtonMR_Click);
            // 
            // ButtonMC
            // 
            this.ButtonMC.AutoSize = true;
            this.ButtonMC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonMC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonMC.Location = new System.Drawing.Point(0, 57);
            this.ButtonMC.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonMC.Name = "ButtonMC";
            this.ButtonMC.Size = new System.Drawing.Size(60, 30);
            this.ButtonMC.TabIndex = 5;
            this.ButtonMC.Text = "MC";
            this.ButtonMC.UseVisualStyleBackColor = true;
            this.ButtonMC.Click += new System.EventHandler(this.ButtonMC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(302, 518);
            this.ControlBox = false;
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.TopPanel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel TopPanel;
        private Label Title;
        private Button MinimizeButton;
        private Button MaxSizeButton;
        private Button ButtonClose;
        private TextBox textBox1;
        private Panel ControlPanel;
        private Button ButtonMC;
        private Button ButtonMMinus;
        private Button ButtonMS;
        private Button ButtonMPlus;
        private Button ButtonMR;
        private Button button1X;
        private Button buttonDegree;
        private Button buttonRoot;
        private Button ButtonPercent;
        private Button ButtonEquals;
        private Button ButtonDenominator;
        private Button ButtonZero;
        private Button ButtonNegative;
        private Button ButtonPlus;
        private Button Button3;
        private Button Button2;
        private Button Button1;
        private Button ButtonMinus;
        private Button Button6;
        private Button Button5;
        private Button Button4;
        private Button ButtonMultiply;
        private Button Button9;
        private Button Button8;
        private Button Button7;
        private Button ButtonDivide;
        private Button ButtonRemove;
        private Button ButtonC;
        private Button ButtonCE;
        private Button NormalSizeButton;
    }
}