namespace Calculator
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.plus_btn = new System.Windows.Forms.Button();
            this.minus_btn = new System.Windows.Forms.Button();
            this.multiply_btn = new System.Windows.Forms.Button();
            this.divide_btn = new System.Windows.Forms.Button();
            this.negate_btn = new System.Windows.Forms.Button();
            this.nine_btn = new System.Windows.Forms.Button();
            this.eight_btn = new System.Windows.Forms.Button();
            this.seven_btn = new System.Windows.Forms.Button();
            this.four_btn = new System.Windows.Forms.Button();
            this.five_btn = new System.Windows.Forms.Button();
            this.six_btn = new System.Windows.Forms.Button();
            this.three_btn = new System.Windows.Forms.Button();
            this.two_btn = new System.Windows.Forms.Button();
            this.one_btn = new System.Windows.Forms.Button();
            this.zero_btn = new System.Windows.Forms.Button();
            this.dot_btn = new System.Windows.Forms.Button();
            this.equal_btn = new System.Windows.Forms.Button();
            this.pow_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.operationField = new System.Windows.Forms.TextBox();
            this.sqrt_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox.Location = new System.Drawing.Point(26, 13);
            this.textBox.MaxLength = 10;
            this.textBox.Name = "textBox";
            this.textBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox.Size = new System.Drawing.Size(266, 46);
            this.textBox.TabIndex = 0;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox.WordWrap = false;
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // plus_btn
            // 
            this.plus_btn.BackColor = System.Drawing.Color.Transparent;
            this.plus_btn.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.plus_btn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.plus_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.plus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plus_btn.Location = new System.Drawing.Point(230, 183);
            this.plus_btn.Name = "plus_btn";
            this.plus_btn.Size = new System.Drawing.Size(62, 57);
            this.plus_btn.TabIndex = 4;
            this.plus_btn.Text = "+";
            this.plus_btn.UseVisualStyleBackColor = false;
            this.plus_btn.Click += new System.EventHandler(this.plus_btn_Click);
            // 
            // minus_btn
            // 
            this.minus_btn.BackColor = System.Drawing.Color.Transparent;
            this.minus_btn.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.minus_btn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.minus_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.minus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minus_btn.Location = new System.Drawing.Point(230, 246);
            this.minus_btn.Name = "minus_btn";
            this.minus_btn.Size = new System.Drawing.Size(62, 57);
            this.minus_btn.TabIndex = 5;
            this.minus_btn.Text = "-";
            this.minus_btn.UseVisualStyleBackColor = false;
            this.minus_btn.Click += new System.EventHandler(this.minus_btn_Click);
            // 
            // multiply_btn
            // 
            this.multiply_btn.BackColor = System.Drawing.Color.Transparent;
            this.multiply_btn.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.multiply_btn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.multiply_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.multiply_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiply_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.multiply_btn.Location = new System.Drawing.Point(230, 309);
            this.multiply_btn.Name = "multiply_btn";
            this.multiply_btn.Size = new System.Drawing.Size(62, 57);
            this.multiply_btn.TabIndex = 6;
            this.multiply_btn.Text = "*";
            this.multiply_btn.UseVisualStyleBackColor = false;
            this.multiply_btn.Click += new System.EventHandler(this.multiply_btn_Click);
            // 
            // divide_btn
            // 
            this.divide_btn.BackColor = System.Drawing.Color.Transparent;
            this.divide_btn.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.divide_btn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.divide_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.divide_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divide_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.divide_btn.Location = new System.Drawing.Point(230, 372);
            this.divide_btn.Name = "divide_btn";
            this.divide_btn.Size = new System.Drawing.Size(62, 57);
            this.divide_btn.TabIndex = 7;
            this.divide_btn.Text = "/";
            this.divide_btn.UseVisualStyleBackColor = false;
            this.divide_btn.Click += new System.EventHandler(this.divide_btn_Click);
            // 
            // negate_btn
            // 
            this.negate_btn.BackColor = System.Drawing.Color.Transparent;
            this.negate_btn.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.negate_btn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.negate_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.negate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.negate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negate_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.negate_btn.Location = new System.Drawing.Point(230, 118);
            this.negate_btn.Name = "negate_btn";
            this.negate_btn.Size = new System.Drawing.Size(62, 57);
            this.negate_btn.TabIndex = 8;
            this.negate_btn.Text = "+/-";
            this.negate_btn.UseVisualStyleBackColor = false;
            this.negate_btn.Click += new System.EventHandler(this.negate_btn_Click);
            // 
            // nine_btn
            // 
            this.nine_btn.BackColor = System.Drawing.Color.Transparent;
            this.nine_btn.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.nine_btn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nine_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.nine_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nine_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nine_btn.Location = new System.Drawing.Point(162, 182);
            this.nine_btn.Name = "nine_btn";
            this.nine_btn.Size = new System.Drawing.Size(62, 57);
            this.nine_btn.TabIndex = 9;
            this.nine_btn.Text = "9";
            this.nine_btn.UseVisualStyleBackColor = false;
            this.nine_btn.Click += new System.EventHandler(this.nine_btn_Click);
            // 
            // eight_btn
            // 
            this.eight_btn.BackColor = System.Drawing.Color.Transparent;
            this.eight_btn.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.eight_btn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.eight_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.eight_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eight_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eight_btn.Location = new System.Drawing.Point(94, 182);
            this.eight_btn.Name = "eight_btn";
            this.eight_btn.Size = new System.Drawing.Size(62, 57);
            this.eight_btn.TabIndex = 10;
            this.eight_btn.Text = "8";
            this.eight_btn.UseVisualStyleBackColor = false;
            this.eight_btn.Click += new System.EventHandler(this.eight_btn_Click);
            // 
            // seven_btn
            // 
            this.seven_btn.BackColor = System.Drawing.Color.Transparent;
            this.seven_btn.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.seven_btn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.seven_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.seven_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seven_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.seven_btn.Location = new System.Drawing.Point(26, 182);
            this.seven_btn.Name = "seven_btn";
            this.seven_btn.Size = new System.Drawing.Size(62, 57);
            this.seven_btn.TabIndex = 11;
            this.seven_btn.Text = "7";
            this.seven_btn.UseVisualStyleBackColor = false;
            this.seven_btn.Click += new System.EventHandler(this.seven_btn_Click);
            // 
            // four_btn
            // 
            this.four_btn.BackColor = System.Drawing.Color.Transparent;
            this.four_btn.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.four_btn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.four_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.four_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.four_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.four_btn.Location = new System.Drawing.Point(26, 246);
            this.four_btn.Name = "four_btn";
            this.four_btn.Size = new System.Drawing.Size(62, 57);
            this.four_btn.TabIndex = 12;
            this.four_btn.Text = "4";
            this.four_btn.UseVisualStyleBackColor = false;
            this.four_btn.Click += new System.EventHandler(this.four_btn_Click);
            // 
            // five_btn
            // 
            this.five_btn.BackColor = System.Drawing.Color.Transparent;
            this.five_btn.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.five_btn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.five_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.five_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.five_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.five_btn.Location = new System.Drawing.Point(94, 246);
            this.five_btn.Name = "five_btn";
            this.five_btn.Size = new System.Drawing.Size(62, 57);
            this.five_btn.TabIndex = 13;
            this.five_btn.Text = "5";
            this.five_btn.UseVisualStyleBackColor = false;
            this.five_btn.Click += new System.EventHandler(this.five_btn_Click);
            // 
            // six_btn
            // 
            this.six_btn.BackColor = System.Drawing.Color.Transparent;
            this.six_btn.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.six_btn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.six_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.six_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.six_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.six_btn.Location = new System.Drawing.Point(162, 246);
            this.six_btn.Name = "six_btn";
            this.six_btn.Size = new System.Drawing.Size(62, 57);
            this.six_btn.TabIndex = 14;
            this.six_btn.Text = "6";
            this.six_btn.UseVisualStyleBackColor = false;
            this.six_btn.Click += new System.EventHandler(this.six_btn_Click);
            // 
            // three_btn
            // 
            this.three_btn.BackColor = System.Drawing.Color.Transparent;
            this.three_btn.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.three_btn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.three_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.three_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.three_btn.Location = new System.Drawing.Point(162, 309);
            this.three_btn.Name = "three_btn";
            this.three_btn.Size = new System.Drawing.Size(62, 57);
            this.three_btn.TabIndex = 15;
            this.three_btn.Text = "3";
            this.three_btn.UseVisualStyleBackColor = false;
            this.three_btn.Click += new System.EventHandler(this.three_btn_Click);
            // 
            // two_btn
            // 
            this.two_btn.BackColor = System.Drawing.Color.Transparent;
            this.two_btn.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.two_btn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.two_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.two_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.two_btn.Location = new System.Drawing.Point(94, 309);
            this.two_btn.Name = "two_btn";
            this.two_btn.Size = new System.Drawing.Size(62, 57);
            this.two_btn.TabIndex = 16;
            this.two_btn.Text = "2";
            this.two_btn.UseVisualStyleBackColor = false;
            this.two_btn.Click += new System.EventHandler(this.two_btn_Click);
            // 
            // one_btn
            // 
            this.one_btn.BackColor = System.Drawing.Color.Transparent;
            this.one_btn.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.one_btn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.one_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.one_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.one_btn.Location = new System.Drawing.Point(26, 309);
            this.one_btn.Name = "one_btn";
            this.one_btn.Size = new System.Drawing.Size(62, 57);
            this.one_btn.TabIndex = 17;
            this.one_btn.Text = "1";
            this.one_btn.UseVisualStyleBackColor = false;
            this.one_btn.Click += new System.EventHandler(this.one_btn_Click);
            // 
            // zero_btn
            // 
            this.zero_btn.BackColor = System.Drawing.Color.Transparent;
            this.zero_btn.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.zero_btn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.zero_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.zero_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zero_btn.Location = new System.Drawing.Point(26, 372);
            this.zero_btn.Name = "zero_btn";
            this.zero_btn.Size = new System.Drawing.Size(62, 57);
            this.zero_btn.TabIndex = 18;
            this.zero_btn.Text = "0";
            this.zero_btn.UseVisualStyleBackColor = false;
            this.zero_btn.Click += new System.EventHandler(this.zero_btn_Click);
            // 
            // dot_btn
            // 
            this.dot_btn.BackColor = System.Drawing.Color.Transparent;
            this.dot_btn.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.dot_btn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dot_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.dot_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dot_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dot_btn.Location = new System.Drawing.Point(94, 372);
            this.dot_btn.Name = "dot_btn";
            this.dot_btn.Size = new System.Drawing.Size(62, 57);
            this.dot_btn.TabIndex = 19;
            this.dot_btn.Text = ".";
            this.dot_btn.UseVisualStyleBackColor = false;
            this.dot_btn.Click += new System.EventHandler(this.dot_btn_Click);
            // 
            // equal_btn
            // 
            this.equal_btn.BackColor = System.Drawing.Color.Transparent;
            this.equal_btn.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.equal_btn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.equal_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.equal_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equal_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.equal_btn.Location = new System.Drawing.Point(162, 372);
            this.equal_btn.Name = "equal_btn";
            this.equal_btn.Size = new System.Drawing.Size(62, 57);
            this.equal_btn.TabIndex = 20;
            this.equal_btn.Text = "=";
            this.equal_btn.UseVisualStyleBackColor = false;
            this.equal_btn.Click += new System.EventHandler(this.equal_btn_Click);
            // 
            // pow_btn
            // 
            this.pow_btn.BackColor = System.Drawing.Color.Transparent;
            this.pow_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pow_btn.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.pow_btn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pow_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.pow_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pow_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pow_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pow_btn.Location = new System.Drawing.Point(162, 118);
            this.pow_btn.Name = "pow_btn";
            this.pow_btn.Size = new System.Drawing.Size(62, 57);
            this.pow_btn.TabIndex = 21;
            this.pow_btn.Text = "x^2 ";
            this.pow_btn.UseVisualStyleBackColor = false;
            this.pow_btn.Click += new System.EventHandler(this.pow_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.Transparent;
            this.clear_btn.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.clear_btn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.clear_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clear_btn.Location = new System.Drawing.Point(26, 116);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(62, 58);
            this.clear_btn.TabIndex = 22;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // operationField
            // 
            this.operationField.BackColor = System.Drawing.Color.AliceBlue;
            this.operationField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.operationField.Enabled = false;
            this.operationField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.operationField.Location = new System.Drawing.Point(42, 76);
            this.operationField.Name = "operationField";
            this.operationField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.operationField.Size = new System.Drawing.Size(236, 17);
            this.operationField.TabIndex = 23;
            this.operationField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sqrt_btn
            // 
            this.sqrt_btn.BackColor = System.Drawing.Color.Transparent;
            this.sqrt_btn.BackgroundImage = global::Calculator.Properties.Resources.square_root1;
            this.sqrt_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sqrt_btn.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.sqrt_btn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sqrt_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.sqrt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqrt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrt_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sqrt_btn.Location = new System.Drawing.Point(94, 117);
            this.sqrt_btn.Name = "sqrt_btn";
            this.sqrt_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sqrt_btn.Size = new System.Drawing.Size(62, 57);
            this.sqrt_btn.TabIndex = 24;
            this.sqrt_btn.UseVisualStyleBackColor = false;
            this.sqrt_btn.Click += new System.EventHandler(this.sqrt_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(319, 446);
            this.Controls.Add(this.sqrt_btn);
            this.Controls.Add(this.operationField);
            this.Controls.Add(this.pow_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.equal_btn);
            this.Controls.Add(this.dot_btn);
            this.Controls.Add(this.zero_btn);
            this.Controls.Add(this.one_btn);
            this.Controls.Add(this.two_btn);
            this.Controls.Add(this.three_btn);
            this.Controls.Add(this.six_btn);
            this.Controls.Add(this.five_btn);
            this.Controls.Add(this.four_btn);
            this.Controls.Add(this.seven_btn);
            this.Controls.Add(this.eight_btn);
            this.Controls.Add(this.nine_btn);
            this.Controls.Add(this.negate_btn);
            this.Controls.Add(this.divide_btn);
            this.Controls.Add(this.multiply_btn);
            this.Controls.Add(this.minus_btn);
            this.Controls.Add(this.plus_btn);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button plus_btn;
        private System.Windows.Forms.Button minus_btn;
        private System.Windows.Forms.Button multiply_btn;
        private System.Windows.Forms.Button divide_btn;
        private System.Windows.Forms.Button negate_btn;
        private System.Windows.Forms.Button nine_btn;
        private System.Windows.Forms.Button eight_btn;
        private System.Windows.Forms.Button seven_btn;
        private System.Windows.Forms.Button four_btn;
        private System.Windows.Forms.Button five_btn;
        private System.Windows.Forms.Button six_btn;
        private System.Windows.Forms.Button three_btn;
        private System.Windows.Forms.Button two_btn;
        private System.Windows.Forms.Button one_btn;
        private System.Windows.Forms.Button zero_btn;
        private System.Windows.Forms.Button dot_btn;
        private System.Windows.Forms.Button equal_btn;
        private System.Windows.Forms.Button pow_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.TextBox operationField;
        private System.Windows.Forms.Button sqrt_btn;
    }
}

