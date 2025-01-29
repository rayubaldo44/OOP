namespace oop3
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
            resultBox = new TextBox();
            comboBox1 = new ComboBox();
            Compute = new Button();
            Length_TextBox = new TextBox();
            Width_TextBox = new TextBox();
            Radius_TextBox = new TextBox();
            Base_TextBox = new TextBox();
            Height_TextBox = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // resultBox
            // 
            resultBox.Location = new Point(69, 55);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(150, 31);
            resultBox.TabIndex = 0;
            resultBox.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(69, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(210, 33);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "Please select a Shape";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Compute
            // 
            Compute.Location = new Point(303, 40);
            Compute.Name = "Compute";
            Compute.Size = new Size(97, 33);
            Compute.TabIndex = 2;
            Compute.Text = "Compute";
            Compute.UseVisualStyleBackColor = true;
            Compute.Click += Compute_Click;
            // 
            // Length_TextBox
            // 
            Length_TextBox.Location = new Point(69, 150);
            Length_TextBox.Name = "Length_TextBox";
            Length_TextBox.Size = new Size(150, 31);
            Length_TextBox.TabIndex = 3;
            // 
            // Width_TextBox
            // 
            Width_TextBox.Location = new Point(69, 197);
            Width_TextBox.Name = "Width_TextBox";
            Width_TextBox.Size = new Size(150, 31);
            Width_TextBox.TabIndex = 4;
            // 
            // Radius_TextBox
            // 
            Radius_TextBox.Location = new Point(69, 101);
            Radius_TextBox.Name = "Radius_TextBox";
            Radius_TextBox.Size = new Size(150, 31);
            Radius_TextBox.TabIndex = 5;
            // 
            // Base_TextBox
            // 
            Base_TextBox.Location = new Point(69, 253);
            Base_TextBox.Name = "Base_TextBox";
            Base_TextBox.Size = new Size(150, 31);
            Base_TextBox.TabIndex = 6;
            // 
            // Height_TextBox
            // 
            Height_TextBox.Location = new Point(69, 310);
            Height_TextBox.Name = "Height_TextBox";
            Height_TextBox.Size = new Size(150, 31);
            Height_TextBox.TabIndex = 7;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(303, 100);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(339, 254);
            listBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(530, 40);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 9;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 101);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 10;
            label1.Text = "radius";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 153);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 11;
            label2.Text = "length";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 203);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 12;
            label3.Text = "width";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 259);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 13;
            label4.Text = "base";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1, 316);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 14;
            label5.Text = "height";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 58);
            label6.Name = "label6";
            label6.Size = new Size(55, 25);
            label6.TabIndex = 15;
            label6.Text = "result";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(303, 72);
            label7.Name = "label7";
            label7.Size = new Size(66, 25);
            label7.TabIndex = 16;
            label7.Text = "history";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(406, 40);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(118, 34);
            deleteButton.TabIndex = 17;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 390);
            Controls.Add(deleteButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(Height_TextBox);
            Controls.Add(Base_TextBox);
            Controls.Add(Radius_TextBox);
            Controls.Add(Width_TextBox);
            Controls.Add(Length_TextBox);
            Controls.Add(Compute);
            Controls.Add(comboBox1);
            Controls.Add(resultBox);
            Name = "Form1";
            Text = "Compute";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox resultBox;
        private ComboBox comboBox1;
        private Button Compute;
        private TextBox Length_TextBox;
        private TextBox Width_TextBox;
        private TextBox Radius_TextBox;
        private TextBox Base_TextBox;
        private TextBox Height_TextBox;
        private ListBox listBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button deleteButton;
    }
}
