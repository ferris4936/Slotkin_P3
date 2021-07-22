
namespace Slotkin_P3
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
            this.orderNumLabel = new System.Windows.Forms.Label();
            this.numItemsLabel = new System.Windows.Forms.Label();
            this.orderNumTextBox = new System.Windows.Forms.TextBox();
            this.numItemsTextBox = new System.Windows.Forms.TextBox();
            this.itemTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.usbDriverRadioButton = new System.Windows.Forms.RadioButton();
            this.penRadioButton = new System.Windows.Forms.RadioButton();
            this.coffeeMugRadioButton = new System.Windows.Forms.RadioButton();
            this.textLabel = new System.Windows.Forms.Label();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.logoCheckBox = new System.Windows.Forms.CheckBox();
            this.numColorsLabel = new System.Windows.Forms.Label();
            this.numColorsTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.resultsTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.itemTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderNumLabel
            // 
            this.orderNumLabel.AutoSize = true;
            this.orderNumLabel.Location = new System.Drawing.Point(65, 47);
            this.orderNumLabel.Name = "orderNumLabel";
            this.orderNumLabel.Size = new System.Drawing.Size(108, 20);
            this.orderNumLabel.TabIndex = 0;
            this.orderNumLabel.Text = "Order Number:";
            // 
            // numItemsLabel
            // 
            this.numItemsLabel.AutoSize = true;
            this.numItemsLabel.Location = new System.Drawing.Point(65, 104);
            this.numItemsLabel.Name = "numItemsLabel";
            this.numItemsLabel.Size = new System.Drawing.Size(124, 20);
            this.numItemsLabel.TabIndex = 1;
            this.numItemsLabel.Text = "Number of Items:";
            // 
            // orderNumTextBox
            // 
            this.orderNumTextBox.Location = new System.Drawing.Point(192, 44);
            this.orderNumTextBox.Name = "orderNumTextBox";
            this.orderNumTextBox.Size = new System.Drawing.Size(143, 27);
            this.orderNumTextBox.TabIndex = 2;
            // 
            // numItemsTextBox
            // 
            this.numItemsTextBox.Location = new System.Drawing.Point(192, 101);
            this.numItemsTextBox.Name = "numItemsTextBox";
            this.numItemsTextBox.Size = new System.Drawing.Size(143, 27);
            this.numItemsTextBox.TabIndex = 3;
            // 
            // itemTypeGroupBox
            // 
            this.itemTypeGroupBox.Controls.Add(this.usbDriverRadioButton);
            this.itemTypeGroupBox.Controls.Add(this.penRadioButton);
            this.itemTypeGroupBox.Controls.Add(this.coffeeMugRadioButton);
            this.itemTypeGroupBox.Location = new System.Drawing.Point(84, 157);
            this.itemTypeGroupBox.Name = "itemTypeGroupBox";
            this.itemTypeGroupBox.Size = new System.Drawing.Size(251, 160);
            this.itemTypeGroupBox.TabIndex = 4;
            this.itemTypeGroupBox.TabStop = false;
            this.itemTypeGroupBox.Text = "Item Type:";
            // 
            // usbDriverRadioButton
            // 
            this.usbDriverRadioButton.AutoSize = true;
            this.usbDriverRadioButton.Location = new System.Drawing.Point(30, 113);
            this.usbDriverRadioButton.Name = "usbDriverRadioButton";
            this.usbDriverRadioButton.Size = new System.Drawing.Size(117, 24);
            this.usbDriverRadioButton.TabIndex = 2;
            this.usbDriverRadioButton.Text = "USB Driver(s)";
            this.usbDriverRadioButton.UseVisualStyleBackColor = true;
            // 
            // penRadioButton
            // 
            this.penRadioButton.AutoSize = true;
            this.penRadioButton.Location = new System.Drawing.Point(30, 73);
            this.penRadioButton.Name = "penRadioButton";
            this.penRadioButton.Size = new System.Drawing.Size(69, 24);
            this.penRadioButton.TabIndex = 1;
            this.penRadioButton.Text = "Pen(s)";
            this.penRadioButton.UseVisualStyleBackColor = true;
            // 
            // coffeeMugRadioButton
            // 
            this.coffeeMugRadioButton.AutoSize = true;
            this.coffeeMugRadioButton.Location = new System.Drawing.Point(30, 34);
            this.coffeeMugRadioButton.Name = "coffeeMugRadioButton";
            this.coffeeMugRadioButton.Size = new System.Drawing.Size(124, 24);
            this.coffeeMugRadioButton.TabIndex = 0;
            this.coffeeMugRadioButton.Text = "Coffee Mug(s)";
            this.coffeeMugRadioButton.UseVisualStyleBackColor = true;
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(58, 337);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(163, 20);
            this.textLabel.TabIndex = 5;
            this.textLabel.Text = "Text to print on item(s):";
            // 
            // textTextBox
            // 
            this.textTextBox.Location = new System.Drawing.Point(65, 360);
            this.textTextBox.Multiline = true;
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(270, 66);
            this.textTextBox.TabIndex = 6;
            this.textTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // logoCheckBox
            // 
            this.logoCheckBox.AutoSize = true;
            this.logoCheckBox.Location = new System.Drawing.Point(463, 47);
            this.logoCheckBox.Name = "logoCheckBox";
            this.logoCheckBox.Size = new System.Drawing.Size(124, 24);
            this.logoCheckBox.TabIndex = 7;
            this.logoCheckBox.Text = "Include Logo?";
            this.logoCheckBox.UseVisualStyleBackColor = true;
            this.logoCheckBox.CheckedChanged += new System.EventHandler(this.logoCheckBox_CheckedChanged);
            // 
            // numColorsLabel
            // 
            this.numColorsLabel.AutoSize = true;
            this.numColorsLabel.Location = new System.Drawing.Point(463, 104);
            this.numColorsLabel.Name = "numColorsLabel";
            this.numColorsLabel.Size = new System.Drawing.Size(130, 20);
            this.numColorsLabel.TabIndex = 8;
            this.numColorsLabel.Text = "Number of Colors:";
            this.numColorsLabel.Visible = false;
            // 
            // numColorsTextBox
            // 
            this.numColorsTextBox.Location = new System.Drawing.Point(610, 97);
            this.numColorsTextBox.Name = "numColorsTextBox";
            this.numColorsTextBox.Size = new System.Drawing.Size(125, 27);
            this.numColorsTextBox.TabIndex = 9;
            this.numColorsTextBox.Visible = false;
            this.numColorsTextBox.TextChanged += new System.EventHandler(this.numColorsTextBox_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(493, 186);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(94, 29);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(420, 249);
            this.resultsTextBox.Multiline = true;
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.Size = new System.Drawing.Size(332, 130);
            this.resultsTextBox.TabIndex = 11;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(630, 186);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(94, 29);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseCompatibleTextRendering = true;
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.resultsTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.numColorsTextBox);
            this.Controls.Add(this.numColorsLabel);
            this.Controls.Add(this.logoCheckBox);
            this.Controls.Add(this.textTextBox);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.itemTypeGroupBox);
            this.Controls.Add(this.numItemsTextBox);
            this.Controls.Add(this.orderNumTextBox);
            this.Controls.Add(this.numItemsLabel);
            this.Controls.Add(this.orderNumLabel);
            this.Name = "Form1";
            this.Text = "Logo Order Price Quote Calculator";
            this.itemTypeGroupBox.ResumeLayout(false);
            this.itemTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderNumLabel;
        private System.Windows.Forms.Label numItemsLabel;
        private System.Windows.Forms.TextBox orderNumTextBox;
        private System.Windows.Forms.TextBox numItemsTextBox;
        private System.Windows.Forms.GroupBox itemTypeGroupBox;
        private System.Windows.Forms.RadioButton usbDriverRadioButton;
        private System.Windows.Forms.RadioButton penRadioButton;
        private System.Windows.Forms.RadioButton coffeeMugRadioButton;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.CheckBox logoCheckBox;
        private System.Windows.Forms.Label numColorsLabel;
        private System.Windows.Forms.TextBox numColorsTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox resultsTextBox;
        private System.Windows.Forms.Button clearButton;
    }
}

