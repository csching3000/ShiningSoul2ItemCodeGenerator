
namespace ShiningSoul2_CodeGenerator
{
    partial class codeGenerator
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
            this.generateButton = new System.Windows.Forms.Button();
            this.itemNumberLbl = new System.Windows.Forms.Label();
            this.itemTypeLbl = new System.Windows.Forms.Label();
            this.itemSuffixLbl = new System.Windows.Forms.Label();
            this.itemPrefixLbl = new System.Windows.Forms.Label();
            this.itemTypeBox = new System.Windows.Forms.ComboBox();
            this.itemPrefixBox = new System.Windows.Forms.ComboBox();
            this.itemModLbl = new System.Windows.Forms.Label();
            this.itemSuffixBox = new System.Windows.Forms.TextBox();
            this.itemNumberBox = new System.Windows.Forms.TextBox();
            this.itemModBox = new System.Windows.Forms.TextBox();
            this.cheatCodeBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(245, 340);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(178, 73);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // itemNumberLbl
            // 
            this.itemNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNumberLbl.Location = new System.Drawing.Point(86, 129);
            this.itemNumberLbl.Name = "itemNumberLbl";
            this.itemNumberLbl.Size = new System.Drawing.Size(155, 35);
            this.itemNumberLbl.TabIndex = 1;
            this.itemNumberLbl.Text = "Item Number";
            // 
            // itemTypeLbl
            // 
            this.itemTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTypeLbl.Location = new System.Drawing.Point(86, 82);
            this.itemTypeLbl.Name = "itemTypeLbl";
            this.itemTypeLbl.Size = new System.Drawing.Size(155, 37);
            this.itemTypeLbl.TabIndex = 2;
            this.itemTypeLbl.Text = "Item Type";
            // 
            // itemSuffixLbl
            // 
            this.itemSuffixLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSuffixLbl.Location = new System.Drawing.Point(86, 174);
            this.itemSuffixLbl.Name = "itemSuffixLbl";
            this.itemSuffixLbl.Size = new System.Drawing.Size(155, 35);
            this.itemSuffixLbl.TabIndex = 1;
            this.itemSuffixLbl.Text = "Item Suffix";
            // 
            // itemPrefixLbl
            // 
            this.itemPrefixLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPrefixLbl.Location = new System.Drawing.Point(86, 217);
            this.itemPrefixLbl.Name = "itemPrefixLbl";
            this.itemPrefixLbl.Size = new System.Drawing.Size(155, 37);
            this.itemPrefixLbl.TabIndex = 1;
            this.itemPrefixLbl.Text = "Item Prefix";
            this.itemPrefixLbl.UseCompatibleTextRendering = true;
            // 
            // itemTypeBox
            // 
            this.itemTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTypeBox.FormattingEnabled = true;
            this.itemTypeBox.Items.AddRange(new object[] {
            "00 None",
            "01 Items",
            "02 Weapons",
            "03 Armor",
            "04 Helmets",
            "05 Gloves",
            "06 Accessories"});
            this.itemTypeBox.Location = new System.Drawing.Point(352, 82);
            this.itemTypeBox.Name = "itemTypeBox";
            this.itemTypeBox.Size = new System.Drawing.Size(219, 37);
            this.itemTypeBox.TabIndex = 3;
            this.itemTypeBox.SelectedIndexChanged += new System.EventHandler(this.itemTypeBox_SelectedIndexChanged);
            // 
            // itemPrefixBox
            // 
            this.itemPrefixBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPrefixBox.FormattingEnabled = true;
            this.itemPrefixBox.Items.AddRange(new object[] {
            "00 None",
            "01 Fire",
            "02 Ice",
            "03 Lightning",
            "04 Lightness",
            "05 Darkness",
            "06 Poison"});
            this.itemPrefixBox.Location = new System.Drawing.Point(352, 217);
            this.itemPrefixBox.Name = "itemPrefixBox";
            this.itemPrefixBox.Size = new System.Drawing.Size(219, 37);
            this.itemPrefixBox.TabIndex = 3;
            this.itemPrefixBox.SelectedIndexChanged += new System.EventHandler(this.itemPrefixBox_SelectedIndexChanged);
            // 
            // itemModLbl
            // 
            this.itemModLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemModLbl.Location = new System.Drawing.Point(86, 264);
            this.itemModLbl.Name = "itemModLbl";
            this.itemModLbl.Size = new System.Drawing.Size(155, 32);
            this.itemModLbl.TabIndex = 1;
            this.itemModLbl.Text = "Item Mod";
            // 
            // itemSuffixBox
            // 
            this.itemSuffixBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSuffixBox.Location = new System.Drawing.Point(352, 174);
            this.itemSuffixBox.Name = "itemSuffixBox";
            this.itemSuffixBox.Size = new System.Drawing.Size(219, 35);
            this.itemSuffixBox.TabIndex = 4;
            this.itemSuffixBox.TextChanged += new System.EventHandler(this.itemSuffixBox_TextChanged);
            // 
            // itemNumberBox
            // 
            this.itemNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNumberBox.Location = new System.Drawing.Point(352, 129);
            this.itemNumberBox.Name = "itemNumberBox";
            this.itemNumberBox.Size = new System.Drawing.Size(219, 35);
            this.itemNumberBox.TabIndex = 4;
            this.itemNumberBox.TextChanged += new System.EventHandler(this.itemNumberBox_TextChanged);
            // 
            // itemModBox
            // 
            this.itemModBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemModBox.Location = new System.Drawing.Point(352, 264);
            this.itemModBox.Name = "itemModBox";
            this.itemModBox.Size = new System.Drawing.Size(219, 35);
            this.itemModBox.TabIndex = 4;
            this.itemModBox.TextChanged += new System.EventHandler(this.itemModBox_TextChanged);
            // 
            // cheatCodeBox
            // 
            this.cheatCodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheatCodeBox.Location = new System.Drawing.Point(91, 444);
            this.cheatCodeBox.Name = "cheatCodeBox";
            this.cheatCodeBox.Size = new System.Drawing.Size(495, 186);
            this.cheatCodeBox.TabIndex = 6;
            this.cheatCodeBox.Text = "";
            // 
            // codeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 686);
            this.Controls.Add(this.cheatCodeBox);
            this.Controls.Add(this.itemNumberBox);
            this.Controls.Add(this.itemModBox);
            this.Controls.Add(this.itemSuffixBox);
            this.Controls.Add(this.itemPrefixBox);
            this.Controls.Add(this.itemTypeBox);
            this.Controls.Add(this.itemTypeLbl);
            this.Controls.Add(this.itemModLbl);
            this.Controls.Add(this.itemPrefixLbl);
            this.Controls.Add(this.itemSuffixLbl);
            this.Controls.Add(this.itemNumberLbl);
            this.Controls.Add(this.generateButton);
            this.Name = "codeGenerator";
            this.Text = "Shining Soul 2 Item Code Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label itemNumberLbl;
        private System.Windows.Forms.Label itemTypeLbl;
        private System.Windows.Forms.Label itemSuffixLbl;
        private System.Windows.Forms.Label itemPrefixLbl;
        private System.Windows.Forms.ComboBox itemTypeBox;
        private System.Windows.Forms.ComboBox itemPrefixBox;
        private System.Windows.Forms.Label itemModLbl;
        private System.Windows.Forms.TextBox itemSuffixBox;
        private System.Windows.Forms.TextBox itemNumberBox;
        private System.Windows.Forms.TextBox itemModBox;
        private System.Windows.Forms.RichTextBox cheatCodeBox;
    }
}

