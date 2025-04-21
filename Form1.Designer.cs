namespace OOPLaba3._2
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
            labelA = new Label();
            labelB = new Label();
            labelC = new Label();
            label1 = new Label();
            label2 = new Label();
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            textBoxC = new TextBox();
            numericUpDownA = new NumericUpDown();
            numericUpDownB = new NumericUpDown();
            numericUpDownC = new NumericUpDown();
            trackBarA = new TrackBar();
            trackBarB = new TrackBar();
            trackBarC = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)numericUpDownA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarC).BeginInit();
            SuspendLayout();
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelA.Location = new Point(120, 43);
            labelA.Name = "labelA";
            labelA.Size = new Size(59, 55);
            labelA.TabIndex = 0;
            labelA.Text = "A";
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelB.Location = new Point(367, 43);
            labelB.Name = "labelB";
            labelB.Size = new Size(57, 55);
            labelB.TabIndex = 3;
            labelB.Text = "B";
            // 
            // labelC
            // 
            labelC.AutoSize = true;
            labelC.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelC.Location = new Point(595, 43);
            labelC.Name = "labelC";
            labelC.Size = new Size(59, 55);
            labelC.TabIndex = 4;
            labelC.Text = "C";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(236, 43);
            label1.Name = "label1";
            label1.Size = new Size(78, 55);
            label1.TabIndex = 5;
            label1.Text = "<=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(470, 43);
            label2.Name = "label2";
            label2.Size = new Size(78, 55);
            label2.TabIndex = 6;
            label2.Text = "<=";
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(91, 153);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(120, 23);
            textBoxA.TabIndex = 7;
            textBoxA.TextChanged += textBoxA_TextChanged;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(334, 153);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(120, 23);
            textBoxB.TabIndex = 8;
            textBoxB.TextChanged += textBoxB_TextChanged;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(561, 153);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(120, 23);
            textBoxC.TabIndex = 9;
            textBoxC.TextChanged += textBoxC_TextChanged;
            // 
            // numericUpDownA
            // 
            numericUpDownA.Location = new Point(91, 216);
            numericUpDownA.Name = "numericUpDownA";
            numericUpDownA.Size = new Size(120, 23);
            numericUpDownA.TabIndex = 10;
            numericUpDownA.ValueChanged += numericUpDownA_ValueChanged;
            numericUpDownA.Minimum = NumberModel.MIN_A;
            numericUpDownA.Maximum = NumberModel.MAX_A;
            // 
            // numericUpDownB
            // 
            numericUpDownB.Location = new Point(334, 216);
            numericUpDownB.Name = "numericUpDownB";
            numericUpDownB.Size = new Size(120, 23);
            numericUpDownB.TabIndex = 11;
            numericUpDownB.ValueChanged += numericUpDownB_ValueChanged;
            numericUpDownB.Minimum = NumberModel.MIN_B;
            numericUpDownB.Maximum = NumberModel.MAX_B;
            // 
            // numericUpDownC
            // 
            numericUpDownC.Location = new Point(561, 216);
            numericUpDownC.Name = "numericUpDownC";
            numericUpDownC.Size = new Size(120, 23);
            numericUpDownC.TabIndex = 12;
            numericUpDownC.ValueChanged += numericUpDownC_ValueChanged;
            numericUpDownC.Minimum = NumberModel.MIN_C;
            numericUpDownC.Maximum = NumberModel.MAX_C;
            // 
            // trackBarA
            // 
            trackBarA.Location = new Point(91, 280);
            trackBarA.Maximum = 100;
            trackBarA.Name = "trackBarA";
            trackBarA.Size = new Size(120, 45);
            trackBarA.TabIndex = 13;
            trackBarA.Scroll += trackBarA_Scroll;
            trackBarA.Minimum = NumberModel.MIN_A;
            trackBarA.Maximum = NumberModel.MAX_A;
            // 
            // trackBarB
            // 
            trackBarB.Location = new Point(334, 280);
            trackBarB.Maximum = 100;
            trackBarB.Name = "trackBarB";
            trackBarB.Size = new Size(120, 45);
            trackBarB.TabIndex = 14;
            trackBarB.Scroll += trackBarB_Scroll;
            trackBarB.Minimum = NumberModel.MIN_B;
            trackBarB.Maximum = NumberModel.MAX_B;
            // 
            // trackBarC
            // 
            trackBarC.Location = new Point(561, 280);
            trackBarC.Maximum = 100;
            trackBarC.Name = "trackBarC";
            trackBarC.Size = new Size(120, 45);
            trackBarC.TabIndex = 15;
            trackBarC.Scroll += trackBarC_Scroll;
            trackBarC.Minimum = NumberModel.MIN_C;
            trackBarC.Maximum = NumberModel.MAX_C;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(trackBarC);
            Controls.Add(trackBarB);
            Controls.Add(trackBarA);
            Controls.Add(numericUpDownC);
            Controls.Add(numericUpDownB);
            Controls.Add(numericUpDownA);
            Controls.Add(textBoxC);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelC);
            Controls.Add(labelB);
            Controls.Add(labelA);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownB).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownC).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarA).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarB).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelA;
        private Label labelB;
        private Label labelC;
        private Label label1;
        private Label label2;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private TextBox textBoxC;
        private NumericUpDown numericUpDownA;
        private NumericUpDown numericUpDownB;
        private NumericUpDown numericUpDownC;
        private TrackBar trackBarA;
        private TrackBar trackBarB;
        private TrackBar trackBarC;
    }
}
