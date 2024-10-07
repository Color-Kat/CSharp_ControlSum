namespace MyControlSum
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
            elementsGrid = new DataGridView();
            Count = new Label();
            label1 = new Label();
            label2 = new Label();
            resultBox = new Label();
            countInput = new TextBox();
            rangeInput = new TextBox();
            initButton = new Button();
            showButton = new Button();
            saveButton = new Button();
            calcButton = new Button();
            checkSumButton = new Button();
            resultBox2 = new Label();
            ((System.ComponentModel.ISupportInitialize)elementsGrid).BeginInit();
            SuspendLayout();
            // 
            // elementsGrid
            // 
            elementsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            elementsGrid.Location = new Point(13, 19);
            elementsGrid.Name = "elementsGrid";
            elementsGrid.RowHeadersWidth = 82;
            elementsGrid.Size = new Size(358, 834);
            elementsGrid.TabIndex = 0;
            // 
            // Count
            // 
            Count.AutoSize = true;
            Count.Location = new Point(395, 21);
            Count.Name = "Count";
            Count.Size = new Size(79, 32);
            Count.TabIndex = 1;
            Count.Text = "Count";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(395, 127);
            label1.Name = "label1";
            label1.Size = new Size(81, 32);
            label1.TabIndex = 2;
            label1.Text = "Range";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 873);
            label2.Name = "label2";
            label2.Size = new Size(148, 32);
            label2.TabIndex = 3;
            label2.Text = "Control Sum";
            // 
            // resultBox
            // 
            resultBox.AutoSize = true;
            resultBox.Location = new Point(215, 877);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(0, 32);
            resultBox.TabIndex = 4;
            // 
            // countInput
            // 
            countInput.Location = new Point(393, 71);
            countInput.Name = "countInput";
            countInput.Size = new Size(200, 39);
            countInput.TabIndex = 5;
            countInput.Text = "10";
            // 
            // rangeInput
            // 
            rangeInput.Location = new Point(397, 177);
            rangeInput.Name = "rangeInput";
            rangeInput.Size = new Size(200, 39);
            rangeInput.TabIndex = 6;
            rangeInput.Text = "10";
            // 
            // initButton
            // 
            initButton.Location = new Point(399, 255);
            initButton.Name = "initButton";
            initButton.Size = new Size(194, 46);
            initButton.TabIndex = 7;
            initButton.Text = "Init";
            initButton.UseVisualStyleBackColor = true;
            initButton.Click += initButton_Click;
            // 
            // showButton
            // 
            showButton.Location = new Point(397, 313);
            showButton.Name = "showButton";
            showButton.Size = new Size(196, 46);
            showButton.TabIndex = 8;
            showButton.Text = "Show";
            showButton.UseVisualStyleBackColor = true;
            showButton.Click += showButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(395, 379);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(198, 46);
            saveButton.TabIndex = 9;
            saveButton.Text = "Save Changes";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // calcButton
            // 
            calcButton.Location = new Point(393, 441);
            calcButton.Name = "calcButton";
            calcButton.Size = new Size(200, 46);
            calcButton.TabIndex = 10;
            calcButton.Text = "Calc";
            calcButton.UseVisualStyleBackColor = true;
            calcButton.Click += calcButton_Click;
            // 
            // checkSumButton
            // 
            checkSumButton.Location = new Point(395, 505);
            checkSumButton.Name = "checkSumButton";
            checkSumButton.Size = new Size(198, 46);
            checkSumButton.TabIndex = 11;
            checkSumButton.Text = "Check Sum";
            checkSumButton.UseVisualStyleBackColor = true;
            checkSumButton.Click += checkSumButton_Click;
            // 
            // resultBox2
            // 
            resultBox2.AutoSize = true;
            resultBox2.Location = new Point(393, 873);
            resultBox2.Name = "resultBox2";
            resultBox2.Size = new Size(145, 32);
            resultBox2.TabIndex = 12;
            resultBox2.Text = "Check result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 1034);
            Controls.Add(resultBox2);
            Controls.Add(checkSumButton);
            Controls.Add(calcButton);
            Controls.Add(saveButton);
            Controls.Add(showButton);
            Controls.Add(initButton);
            Controls.Add(rangeInput);
            Controls.Add(countInput);
            Controls.Add(resultBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Count);
            Controls.Add(elementsGrid);
            Name = "Form1";
            Text = "Check Control  SUm";
            ((System.ComponentModel.ISupportInitialize)elementsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView elementsGrid;
        private Label Count;
        private Label label1;
        private Label label2;
        private Label resultBox;
        private TextBox countInput;
        private TextBox rangeInput;
        private Button initButton;
        private Button showButton;
        private Button saveButton;
        private Button calcButton;
        private Button checkSumButton;
        private Label resultBox2;
    }
}
