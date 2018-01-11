namespace myCalculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.commaButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.percentButton = new System.Windows.Forms.Button();
            this.resultScreen = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // sevenButton
            // 
            resources.ApplyResources(this.sevenButton, "sevenButton");
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.NumberButton);
            // 
            // eightButton
            // 
            resources.ApplyResources(this.eightButton, "eightButton");
            this.eightButton.Name = "eightButton";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.NumberButton);
            // 
            // nineButton
            // 
            resources.ApplyResources(this.nineButton, "nineButton");
            this.nineButton.Name = "nineButton";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.NumberButton);
            // 
            // fourButton
            // 
            resources.ApplyResources(this.fourButton, "fourButton");
            this.fourButton.Name = "fourButton";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.NumberButton);
            // 
            // fiveButton
            // 
            resources.ApplyResources(this.fiveButton, "fiveButton");
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.NumberButton);
            // 
            // sixButton
            // 
            resources.ApplyResources(this.sixButton, "sixButton");
            this.sixButton.Name = "sixButton";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.NumberButton);
            // 
            // oneButton
            // 
            resources.ApplyResources(this.oneButton, "oneButton");
            this.oneButton.Name = "oneButton";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.NumberButton);
            // 
            // twoButton
            // 
            resources.ApplyResources(this.twoButton, "twoButton");
            this.twoButton.Name = "twoButton";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.NumberButton);
            // 
            // threeButton
            // 
            resources.ApplyResources(this.threeButton, "threeButton");
            this.threeButton.Name = "threeButton";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.NumberButton);
            // 
            // equalButton
            // 
            resources.ApplyResources(this.equalButton, "equalButton");
            this.equalButton.Name = "equalButton";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // commaButton
            // 
            resources.ApplyResources(this.commaButton, "commaButton");
            this.commaButton.Name = "commaButton";
            this.commaButton.UseVisualStyleBackColor = true;
            this.commaButton.Click += new System.EventHandler(this.commaButton_Click);
            // 
            // zeroButton
            // 
            resources.ApplyResources(this.zeroButton, "zeroButton");
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.NumberButton);
            this.zeroButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Shoortcut);
            // 
            // plusButton
            // 
            resources.ApplyResources(this.plusButton, "plusButton");
            this.plusButton.Name = "plusButton";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // minusButton
            // 
            resources.ApplyResources(this.minusButton, "minusButton");
            this.minusButton.Name = "minusButton";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // multiplyButton
            // 
            resources.ApplyResources(this.multiplyButton, "multiplyButton");
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // divideButton
            // 
            resources.ApplyResources(this.divideButton, "divideButton");
            this.divideButton.Name = "divideButton";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // backButton
            // 
            resources.ApplyResources(this.backButton, "backButton");
            this.backButton.Name = "backButton";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // button18
            // 
            resources.ApplyResources(this.button18, "button18");
            this.button18.Name = "button18";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // percentButton
            // 
            resources.ApplyResources(this.percentButton, "percentButton");
            this.percentButton.Name = "percentButton";
            this.percentButton.UseVisualStyleBackColor = true;
            this.percentButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // resultScreen
            // 
            this.resultScreen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.resultScreen, "resultScreen");
            this.resultScreen.Name = "resultScreen";
            // 
            // Calculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.resultScreen);
            this.Controls.Add(this.percentButton);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.commaButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.sevenButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button commaButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button percentButton;
        private System.Windows.Forms.RichTextBox resultScreen;
    }
}

