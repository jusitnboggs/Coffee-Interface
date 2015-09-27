namespace Coffee_Interface
{
    partial class CoffeeInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoffeeInterface));
            this.Welcome = new System.Windows.Forms.Label();
            this.Flavors = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.addons = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.order = new System.Windows.Forms.Button();
            this.Flavors.SuspendLayout();
            this.addons.SuspendLayout();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Welcome.AutoSize = true;
            this.Welcome.Location = new System.Drawing.Point(373, 9);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(189, 13);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome to McBuilds Coffee Interface";
            // 
            // Flavors
            // 
            this.Flavors.Controls.Add(this.radioButton3);
            this.Flavors.Controls.Add(this.radioButton2);
            this.Flavors.Controls.Add(this.radioButton1);
            this.Flavors.Location = new System.Drawing.Point(243, 405);
            this.Flavors.Name = "Flavors";
            this.Flavors.Size = new System.Drawing.Size(220, 98);
            this.Flavors.TabIndex = 1;
            this.Flavors.TabStop = false;
            this.Flavors.Text = "Flavors";
            this.Flavors.Enter += new System.EventHandler(this.Flavors_Enter);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(144, 36);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(73, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Chocolate";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(82, 36);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Vanilla";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(14, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Regular";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // addons
            // 
            this.addons.Controls.Add(this.checkBox3);
            this.addons.Controls.Add(this.comboBox3);
            this.addons.Controls.Add(this.checkBox2);
            this.addons.Controls.Add(this.comboBox2);
            this.addons.Controls.Add(this.comboBox1);
            this.addons.Controls.Add(this.checkBox1);
            this.addons.Location = new System.Drawing.Point(515, 405);
            this.addons.Name = "addons";
            this.addons.Size = new System.Drawing.Size(235, 98);
            this.addons.TabIndex = 2;
            this.addons.TabStop = false;
            this.addons.Text = "Addons";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 73);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(90, 17);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Check to add";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Extra Shot",
            "Extra Shot 2x",
            "Extra Shot 3x",
            "Extra Shot 4x"});
            this.comboBox3.Location = new System.Drawing.Point(105, 71);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.Text = "Extra Shot";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 48);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(90, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Check to add";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Cream",
            "Cream 2x",
            "Cream 3x",
            "Cream 4x"});
            this.comboBox2.Location = new System.Drawing.Point(105, 46);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Text = "Cream ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Suger",
            "Suger 2x",
            "Suger 3x",
            "Suger 4x"});
            this.comboBox1.Location = new System.Drawing.Point(105, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Suger";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Check to add";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(404, 509);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(180, 87);
            this.order.TabIndex = 3;
            this.order.Text = "Order";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // CoffeeInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(968, 605);
            this.Controls.Add(this.order);
            this.Controls.Add(this.addons);
            this.Controls.Add(this.Flavors);
            this.Controls.Add(this.Welcome);
            this.Name = "CoffeeInterface";
            this.Text = "Coffee Interface";
            this.Flavors.ResumeLayout(false);
            this.Flavors.PerformLayout();
            this.addons.ResumeLayout(false);
            this.addons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.GroupBox Flavors;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox addons;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button order;
    }
}

