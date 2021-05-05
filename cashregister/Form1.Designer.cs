
namespace cashregister
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
            this.chickenLabel = new System.Windows.Forms.Label();
            this.titalLable = new System.Windows.Forms.Label();
            this.friesLabel = new System.Windows.Forms.Label();
            this.drinkLabel = new System.Windows.Forms.Label();
            this.chickenTextbox = new System.Windows.Forms.TextBox();
            this.drinkTextbox = new System.Windows.Forms.TextBox();
            this.friesTextbox = new System.Windows.Forms.TextBox();
            this.calaculateButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedText = new System.Windows.Forms.TextBox();
            this.chnageButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.print = new System.Windows.Forms.Button();
            this.printLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chickenLabel
            // 
            this.chickenLabel.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chickenLabel.Location = new System.Drawing.Point(24, 65);
            this.chickenLabel.Name = "chickenLabel";
            this.chickenLabel.Size = new System.Drawing.Size(100, 23);
            this.chickenLabel.TabIndex = 0;
            this.chickenLabel.Text = "Pieces of chicken ";
            this.chickenLabel.Click += new System.EventHandler(this.chickenLabel_Click);
            // 
            // titalLable
            // 
            this.titalLable.BackColor = System.Drawing.Color.SteelBlue;
            this.titalLable.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titalLable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titalLable.Location = new System.Drawing.Point(1, 9);
            this.titalLable.Name = "titalLable";
            this.titalLable.Size = new System.Drawing.Size(798, 43);
            this.titalLable.TabIndex = 1;
            this.titalLable.Text = "The Chicken bucket ";
            this.titalLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titalLable.Click += new System.EventHandler(this.titalLable_Click);
            // 
            // friesLabel
            // 
            this.friesLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friesLabel.Location = new System.Drawing.Point(24, 104);
            this.friesLabel.Name = "friesLabel";
            this.friesLabel.Size = new System.Drawing.Size(100, 23);
            this.friesLabel.TabIndex = 2;
            this.friesLabel.Text = "Number of Fries";
            this.friesLabel.Click += new System.EventHandler(this.friesLabel_Click);
            // 
            // drinkLabel
            // 
            this.drinkLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkLabel.Location = new System.Drawing.Point(24, 141);
            this.drinkLabel.Name = "drinkLabel";
            this.drinkLabel.Size = new System.Drawing.Size(112, 23);
            this.drinkLabel.TabIndex = 3;
            this.drinkLabel.Text = "Number of Drinks ";
            // 
            // chickenTextbox
            // 
            this.chickenTextbox.Location = new System.Drawing.Point(130, 62);
            this.chickenTextbox.Name = "chickenTextbox";
            this.chickenTextbox.Size = new System.Drawing.Size(100, 20);
            this.chickenTextbox.TabIndex = 4;
            this.chickenTextbox.TextChanged += new System.EventHandler(this.chickenTextbox_TextChanged);
            // 
            // drinkTextbox
            // 
            this.drinkTextbox.Location = new System.Drawing.Point(130, 138);
            this.drinkTextbox.Name = "drinkTextbox";
            this.drinkTextbox.Size = new System.Drawing.Size(100, 20);
            this.drinkTextbox.TabIndex = 5;
            // 
            // friesTextbox
            // 
            this.friesTextbox.Location = new System.Drawing.Point(130, 101);
            this.friesTextbox.Name = "friesTextbox";
            this.friesTextbox.Size = new System.Drawing.Size(100, 20);
            this.friesTextbox.TabIndex = 6;
            // 
            // calaculateButton
            // 
            this.calaculateButton.Location = new System.Drawing.Point(27, 167);
            this.calaculateButton.Name = "calaculateButton";
            this.calaculateButton.Size = new System.Drawing.Size(203, 23);
            this.calaculateButton.TabIndex = 7;
            this.calaculateButton.Text = "Calculate ";
            this.calaculateButton.UseVisualStyleBackColor = true;
            this.calaculateButton.Click += new System.EventHandler(this.calaculateButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(24, 204);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(206, 23);
            this.subtotalLabel.TabIndex = 8;
            this.subtotalLabel.Text = "Sub Total:";
            // 
            // taxLabel
            // 
            this.taxLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(24, 237);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(206, 23);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax:";
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(24, 273);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(206, 23);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Total:";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(24, 304);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(112, 23);
            this.tenderedLabel.TabIndex = 11;
            this.tenderedLabel.Text = "Amount Tendered";
            // 
            // tenderedText
            // 
            this.tenderedText.Location = new System.Drawing.Point(130, 304);
            this.tenderedText.Name = "tenderedText";
            this.tenderedText.Size = new System.Drawing.Size(100, 20);
            this.tenderedText.TabIndex = 12;
            // 
            // chnageButton
            // 
            this.chnageButton.Location = new System.Drawing.Point(27, 333);
            this.chnageButton.Name = "chnageButton";
            this.chnageButton.Size = new System.Drawing.Size(203, 23);
            this.chnageButton.TabIndex = 13;
            this.chnageButton.Text = "Calculate Change";
            this.chnageButton.UseVisualStyleBackColor = true;
            this.chnageButton.Click += new System.EventHandler(this.chnageButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(24, 369);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(206, 23);
            this.changeLabel.TabIndex = 14;
            this.changeLabel.Text = "Change ";
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(27, 395);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(203, 23);
            this.print.TabIndex = 15;
            this.print.Text = "Print Receit ";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // printLabel
            // 
            this.printLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.printLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printLabel.Location = new System.Drawing.Point(410, 65);
            this.printLabel.Name = "printLabel";
            this.printLabel.Size = new System.Drawing.Size(378, 353);
            this.printLabel.TabIndex = 16;
            this.printLabel.Click += new System.EventHandler(this.printLabel_Click);
            // 
            // resetButton
            // 
            this.resetButton.ForeColor = System.Drawing.Color.Black;
            this.resetButton.Location = new System.Drawing.Point(410, 421);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(378, 23);
            this.resetButton.TabIndex = 17;
            this.resetButton.Text = "New Order";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.printLabel);
            this.Controls.Add(this.print);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.chnageButton);
            this.Controls.Add(this.tenderedText);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calaculateButton);
            this.Controls.Add(this.friesTextbox);
            this.Controls.Add(this.drinkTextbox);
            this.Controls.Add(this.chickenTextbox);
            this.Controls.Add(this.drinkLabel);
            this.Controls.Add(this.friesLabel);
            this.Controls.Add(this.titalLable);
            this.Controls.Add(this.chickenLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "The Chicken Bucket ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chickenLabel;
        private System.Windows.Forms.Label titalLable;
        private System.Windows.Forms.Label friesLabel;
        private System.Windows.Forms.Label drinkLabel;
        private System.Windows.Forms.TextBox chickenTextbox;
        private System.Windows.Forms.TextBox drinkTextbox;
        private System.Windows.Forms.TextBox friesTextbox;
        private System.Windows.Forms.Button calaculateButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedText;
        private System.Windows.Forms.Button chnageButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Label printLabel;
        private System.Windows.Forms.Button resetButton;
    }
}

