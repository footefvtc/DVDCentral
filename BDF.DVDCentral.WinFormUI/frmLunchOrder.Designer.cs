namespace BDF.DVDCentral.WinFormUI
{
    partial class frmLunchOrder
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
            gbxMain = new GroupBox();
            rbtnMain3 = new RadioButton();
            rbtnMain2 = new RadioButton();
            rbtnMain1 = new RadioButton();
            gbxAddOn = new GroupBox();
            cbxAddOn3 = new CheckBox();
            cbxAddOn2 = new CheckBox();
            cbxAddOn1 = new CheckBox();
            groupBox3 = new GroupBox();
            button2 = new Button();
            btnPlaceOrder = new Button();
            label6 = new Label();
            label5 = new Label();
            lblCost = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gbxMain.SuspendLayout();
            gbxAddOn.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // gbxMain
            // 
            gbxMain.Controls.Add(rbtnMain3);
            gbxMain.Controls.Add(rbtnMain2);
            gbxMain.Controls.Add(rbtnMain1);
            gbxMain.Location = new Point(0, 0);
            gbxMain.Margin = new Padding(4, 5, 4, 5);
            gbxMain.Name = "gbxMain";
            gbxMain.Padding = new Padding(4, 5, 4, 5);
            gbxMain.Size = new Size(267, 262);
            gbxMain.TabIndex = 0;
            gbxMain.TabStop = false;
            gbxMain.Text = "Main Course";
            // 
            // rbtnMain3
            // 
            rbtnMain3.AutoSize = true;
            rbtnMain3.Location = new Point(32, 194);
            rbtnMain3.Margin = new Padding(4, 5, 4, 5);
            rbtnMain3.Name = "rbtnMain3";
            rbtnMain3.Size = new Size(17, 16);
            rbtnMain3.TabIndex = 2;
            rbtnMain3.TabStop = true;
            rbtnMain3.UseVisualStyleBackColor = true;
            rbtnMain3.CheckedChanged += mainDish_CheckedChanged;
            // 
            // rbtnMain2
            // 
            rbtnMain2.AutoSize = true;
            rbtnMain2.Location = new Point(32, 143);
            rbtnMain2.Margin = new Padding(4, 5, 4, 5);
            rbtnMain2.Name = "rbtnMain2";
            rbtnMain2.Size = new Size(17, 16);
            rbtnMain2.TabIndex = 1;
            rbtnMain2.TabStop = true;
            rbtnMain2.UseVisualStyleBackColor = true;
            rbtnMain2.CheckedChanged += mainDish_CheckedChanged;
            // 
            // rbtnMain1
            // 
            rbtnMain1.AutoSize = true;
            rbtnMain1.Location = new Point(32, 92);
            rbtnMain1.Margin = new Padding(4, 5, 4, 5);
            rbtnMain1.Name = "rbtnMain1";
            rbtnMain1.Size = new Size(17, 16);
            rbtnMain1.TabIndex = 0;
            rbtnMain1.TabStop = true;
            rbtnMain1.UseVisualStyleBackColor = true;
            rbtnMain1.CheckedChanged += mainDish_CheckedChanged;
            // 
            // gbxAddOn
            // 
            gbxAddOn.Controls.Add(cbxAddOn3);
            gbxAddOn.Controls.Add(cbxAddOn2);
            gbxAddOn.Controls.Add(cbxAddOn1);
            gbxAddOn.Location = new Point(276, 0);
            gbxAddOn.Margin = new Padding(4, 5, 4, 5);
            gbxAddOn.Name = "gbxAddOn";
            gbxAddOn.Padding = new Padding(4, 5, 4, 5);
            gbxAddOn.Size = new Size(267, 262);
            gbxAddOn.TabIndex = 0;
            gbxAddOn.TabStop = false;
            gbxAddOn.Text = "groupBox2";
            // 
            // cbxAddOn3
            // 
            cbxAddOn3.AutoSize = true;
            cbxAddOn3.Location = new Point(25, 194);
            cbxAddOn3.Margin = new Padding(4, 5, 4, 5);
            cbxAddOn3.Name = "cbxAddOn3";
            cbxAddOn3.Size = new Size(107, 24);
            cbxAddOn3.TabIndex = 2;
            cbxAddOn3.Text = "cbxAddon1";
            cbxAddOn3.UseVisualStyleBackColor = true;
            cbxAddOn3.CheckedChanged += AddOn_CheckedChanged;
            // 
            // cbxAddOn2
            // 
            cbxAddOn2.AutoSize = true;
            cbxAddOn2.Location = new Point(25, 143);
            cbxAddOn2.Margin = new Padding(4, 5, 4, 5);
            cbxAddOn2.Name = "cbxAddOn2";
            cbxAddOn2.Size = new Size(107, 24);
            cbxAddOn2.TabIndex = 1;
            cbxAddOn2.Text = "cbxAddon1";
            cbxAddOn2.UseVisualStyleBackColor = true;
            cbxAddOn2.CheckedChanged += AddOn_CheckedChanged;
            // 
            // cbxAddOn1
            // 
            cbxAddOn1.AutoSize = true;
            cbxAddOn1.Location = new Point(25, 92);
            cbxAddOn1.Margin = new Padding(4, 5, 4, 5);
            cbxAddOn1.Name = "cbxAddOn1";
            cbxAddOn1.Size = new Size(107, 24);
            cbxAddOn1.TabIndex = 0;
            cbxAddOn1.Text = "cbxAddon1";
            cbxAddOn1.UseVisualStyleBackColor = true;
            cbxAddOn1.CheckedChanged += AddOn_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(btnPlaceOrder);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(lblCost);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(16, 271);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(527, 289);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Order Total";
            // 
            // button2
            // 
            button2.Location = new Point(292, 112);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(100, 35);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(292, 42);
            btnPlaceOrder.Margin = new Padding(4, 5, 4, 5);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(100, 35);
            btnPlaceOrder.TabIndex = 6;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(167, 202);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(167, 128);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 4;
            label5.Text = "label5";
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Location = new Point(167, 49);
            lblCost.Margin = new Padding(4, 0, 4, 0);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(50, 20);
            lblCost.TabIndex = 3;
            lblCost.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 202);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 128);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 49);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // frmLunchOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 589);
            Controls.Add(gbxAddOn);
            Controls.Add(groupBox3);
            Controls.Add(gbxMain);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmLunchOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lunch Order";
            gbxMain.ResumeLayout(false);
            gbxMain.PerformLayout();
            gbxAddOn.ResumeLayout(false);
            gbxAddOn.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMain;
        private System.Windows.Forms.RadioButton rbtnMain3;
        private System.Windows.Forms.RadioButton rbtnMain2;
        private System.Windows.Forms.RadioButton rbtnMain1;
        private System.Windows.Forms.GroupBox gbxAddOn;
        private System.Windows.Forms.CheckBox cbxAddOn3;
        private System.Windows.Forms.CheckBox cbxAddOn2;
        private System.Windows.Forms.CheckBox cbxAddOn1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }


}

