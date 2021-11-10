
namespace SpeedMathTrainer
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
            this.components = new System.ComponentModel.Container();
            this.userMin1 = new System.Windows.Forms.TextBox();
            this.userMax1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userMin2 = new System.Windows.Forms.TextBox();
            this.autoPickerButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timeLimitInputBox = new System.Windows.Forms.TextBox();
            this.userMax2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.operatorChooser = new System.Windows.Forms.CheckedListBox();
            this.startButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.userScore = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.numberBox2 = new System.Windows.Forms.TextBox();
            this.numberBox1 = new System.Windows.Forms.TextBox();
            this.operatorLabel1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.incrementAnim = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.incrementAnim2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.stringPanel = new System.Windows.Forms.Panel();
            this.numBox3 = new System.Windows.Forms.TextBox();
            this.numBox7 = new System.Windows.Forms.TextBox();
            this.numBox6 = new System.Windows.Forms.TextBox();
            this.numBox5 = new System.Windows.Forms.TextBox();
            this.numBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.answerBoxString = new System.Windows.Forms.TextBox();
            this.scoreCopy = new System.Windows.Forms.Label();
            this.timeCopy = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.avgTimeBox = new System.Windows.Forms.TextBox();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.summaryBox = new System.Windows.Forms.TextBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.nextDelay = new System.Windows.Forms.Timer(this.components);
            this.opacityTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.stringPanel.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // userMin1
            // 
            this.userMin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userMin1.Location = new System.Drawing.Point(22, 47);
            this.userMin1.Name = "userMin1";
            this.userMin1.Size = new System.Drawing.Size(157, 35);
            this.userMin1.TabIndex = 2;
            // 
            // userMax1
            // 
            this.userMax1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userMax1.Location = new System.Drawing.Point(22, 144);
            this.userMax1.Name = "userMax1";
            this.userMax1.Size = new System.Drawing.Size(157, 35);
            this.userMax1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Minimum #1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Maximum #1";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1231, 776);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.titleLabel);
            this.tabPage1.Controls.Add(this.operatorChooser);
            this.tabPage1.Controls.Add(this.startButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1223, 750);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.userMin1);
            this.panel1.Controls.Add(this.userMin2);
            this.panel1.Controls.Add(this.autoPickerButton);
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.timeLimitInputBox);
            this.panel1.Controls.Add(this.userMax1);
            this.panel1.Controls.Add(this.userMax2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(728, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 300);
            this.panel1.TabIndex = 19;
            // 
            // userMin2
            // 
            this.userMin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userMin2.Location = new System.Drawing.Point(254, 47);
            this.userMin2.Name = "userMin2";
            this.userMin2.Size = new System.Drawing.Size(157, 35);
            this.userMin2.TabIndex = 11;
            // 
            // autoPickerButton
            // 
            this.autoPickerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoPickerButton.Location = new System.Drawing.Point(22, 211);
            this.autoPickerButton.Name = "autoPickerButton";
            this.autoPickerButton.Size = new System.Drawing.Size(192, 52);
            this.autoPickerButton.TabIndex = 15;
            this.autoPickerButton.Text = "Default Settings";
            this.autoPickerButton.UseVisualStyleBackColor = true;
            this.autoPickerButton.Click += new System.EventHandler(this.autoPickerButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(250, 211);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timeLabel.Size = new System.Drawing.Size(160, 20);
            this.timeLabel.TabIndex = 17;
            this.timeLabel.Text = "Enter Time (seconds)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Minimum #2";
            // 
            // timeLimitInputBox
            // 
            this.timeLimitInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLimitInputBox.Location = new System.Drawing.Point(262, 234);
            this.timeLimitInputBox.Name = "timeLimitInputBox";
            this.timeLimitInputBox.Size = new System.Drawing.Size(135, 29);
            this.timeLimitInputBox.TabIndex = 16;
            // 
            // userMax2
            // 
            this.userMax2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userMax2.Location = new System.Drawing.Point(254, 144);
            this.userMax2.Name = "userMax2";
            this.userMax2.Size = new System.Drawing.Size(157, 35);
            this.userMax2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Maximum #2";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(166, 53);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(889, 108);
            this.titleLabel.TabIndex = 18;
            this.titleLabel.Text = "Speed Math Trainer";
            // 
            // operatorChooser
            // 
            this.operatorChooser.BackColor = System.Drawing.Color.Aqua;
            this.operatorChooser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.operatorChooser.CheckOnClick = true;
            this.operatorChooser.ColumnWidth = 2;
            this.operatorChooser.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.operatorChooser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorChooser.FormattingEnabled = true;
            this.operatorChooser.Items.AddRange(new object[] {
            "Addition",
            "Subtraction",
            "Multiplication",
            "Divsion",
            "String Addition"});
            this.operatorChooser.Location = new System.Drawing.Point(504, 352);
            this.operatorChooser.Name = "operatorChooser";
            this.operatorChooser.Size = new System.Drawing.Size(187, 152);
            this.operatorChooser.TabIndex = 9;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.SeaShell;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(121, 385);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(279, 107);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.userScore);
            this.tabPage2.Controls.Add(this.mainPanel);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.timeLeftLabel);
            this.tabPage2.Controls.Add(this.answerBox);
            this.tabPage2.Controls.Add(this.incrementAnim);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1223, 750);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // userScore
            // 
            this.userScore.AutoSize = true;
            this.userScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userScore.Location = new System.Drawing.Point(951, 22);
            this.userScore.Name = "userScore";
            this.userScore.Size = new System.Drawing.Size(203, 55);
            this.userScore.TabIndex = 4;
            this.userScore.Text = "Score: 0";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Honeydew;
            this.mainPanel.Controls.Add(this.numberBox2);
            this.mainPanel.Controls.Add(this.numberBox1);
            this.mainPanel.Controls.Add(this.operatorLabel1);
            this.mainPanel.Location = new System.Drawing.Point(-4, 247);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1221, 147);
            this.mainPanel.TabIndex = 22;
            // 
            // numberBox2
            // 
            this.numberBox2.BackColor = System.Drawing.Color.White;
            this.numberBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numberBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBox2.Location = new System.Drawing.Point(732, 13);
            this.numberBox2.Name = "numberBox2";
            this.numberBox2.ReadOnly = true;
            this.numberBox2.Size = new System.Drawing.Size(426, 116);
            this.numberBox2.TabIndex = 2;
            this.numberBox2.Text = "number";
            this.numberBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numberBox1
            // 
            this.numberBox1.BackColor = System.Drawing.Color.White;
            this.numberBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numberBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBox1.Location = new System.Drawing.Point(60, 13);
            this.numberBox1.Name = "numberBox1";
            this.numberBox1.ReadOnly = true;
            this.numberBox1.Size = new System.Drawing.Size(426, 116);
            this.numberBox1.TabIndex = 0;
            this.numberBox1.Text = "number";
            this.numberBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // operatorLabel1
            // 
            this.operatorLabel1.AutoSize = true;
            this.operatorLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorLabel1.Location = new System.Drawing.Point(556, 21);
            this.operatorLabel1.Name = "operatorLabel1";
            this.operatorLabel1.Size = new System.Drawing.Size(109, 108);
            this.operatorLabel1.TabIndex = 1;
            this.operatorLabel1.Text = "X";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(162, 491);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 108);
            this.label10.TabIndex = 20;
            this.label10.Text = "=";
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.AutoSize = true;
            this.timeLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftLabel.Location = new System.Drawing.Point(8, 22);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(314, 55);
            this.timeLeftLabel.TabIndex = 5;
            this.timeLeftLabel.Text = "Seconds left: ";
            // 
            // answerBox
            // 
            this.answerBox.BackColor = System.Drawing.Color.White;
            this.answerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerBox.Location = new System.Drawing.Point(269, 483);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(646, 116);
            this.answerBox.TabIndex = 3;
            this.answerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.answerBox.TextChanged += new System.EventHandler(this.answerBox_TextChanged);
            // 
            // incrementAnim
            // 
            this.incrementAnim.AutoSize = true;
            this.incrementAnim.BackColor = System.Drawing.Color.Transparent;
            this.incrementAnim.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incrementAnim.ForeColor = System.Drawing.Color.Lime;
            this.incrementAnim.Location = new System.Drawing.Point(1075, 68);
            this.incrementAnim.Name = "incrementAnim";
            this.incrementAnim.Size = new System.Drawing.Size(79, 55);
            this.incrementAnim.TabIndex = 23;
            this.incrementAnim.Text = "+1";
            this.incrementAnim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.incrementAnim2);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.stringPanel);
            this.tabPage3.Controls.Add(this.answerBoxString);
            this.tabPage3.Controls.Add(this.scoreCopy);
            this.tabPage3.Controls.Add(this.timeCopy);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1223, 750);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // incrementAnim2
            // 
            this.incrementAnim2.AutoSize = true;
            this.incrementAnim2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incrementAnim2.ForeColor = System.Drawing.Color.Lime;
            this.incrementAnim2.Location = new System.Drawing.Point(1075, 68);
            this.incrementAnim2.Name = "incrementAnim2";
            this.incrementAnim2.Size = new System.Drawing.Size(79, 55);
            this.incrementAnim2.TabIndex = 20;
            this.incrementAnim2.Text = "+1";
            this.incrementAnim2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(330, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 108);
            this.label9.TabIndex = 19;
            this.label9.Text = "=";
            // 
            // stringPanel
            // 
            this.stringPanel.BackColor = System.Drawing.Color.Honeydew;
            this.stringPanel.Controls.Add(this.numBox3);
            this.stringPanel.Controls.Add(this.numBox7);
            this.stringPanel.Controls.Add(this.numBox6);
            this.stringPanel.Controls.Add(this.numBox5);
            this.stringPanel.Controls.Add(this.numBox4);
            this.stringPanel.Controls.Add(this.label6);
            this.stringPanel.Controls.Add(this.label7);
            this.stringPanel.Controls.Add(this.label8);
            this.stringPanel.Controls.Add(this.label5);
            this.stringPanel.Location = new System.Drawing.Point(-4, 246);
            this.stringPanel.Name = "stringPanel";
            this.stringPanel.Size = new System.Drawing.Size(1227, 147);
            this.stringPanel.TabIndex = 18;
            // 
            // numBox3
            // 
            this.numBox3.BackColor = System.Drawing.Color.White;
            this.numBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBox3.Location = new System.Drawing.Point(72, 27);
            this.numBox3.Name = "numBox3";
            this.numBox3.ReadOnly = true;
            this.numBox3.Size = new System.Drawing.Size(157, 90);
            this.numBox3.TabIndex = 8;
            this.numBox3.Text = "number";
            this.numBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numBox7
            // 
            this.numBox7.BackColor = System.Drawing.Color.White;
            this.numBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBox7.Location = new System.Drawing.Point(963, 27);
            this.numBox7.Name = "numBox7";
            this.numBox7.ReadOnly = true;
            this.numBox7.Size = new System.Drawing.Size(157, 90);
            this.numBox7.TabIndex = 16;
            this.numBox7.Text = "number";
            this.numBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numBox6
            // 
            this.numBox6.BackColor = System.Drawing.Color.White;
            this.numBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBox6.Location = new System.Drawing.Point(739, 27);
            this.numBox6.Name = "numBox6";
            this.numBox6.ReadOnly = true;
            this.numBox6.Size = new System.Drawing.Size(157, 90);
            this.numBox6.TabIndex = 14;
            this.numBox6.Text = "number";
            this.numBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numBox5
            // 
            this.numBox5.BackColor = System.Drawing.Color.White;
            this.numBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBox5.Location = new System.Drawing.Point(514, 27);
            this.numBox5.Name = "numBox5";
            this.numBox5.ReadOnly = true;
            this.numBox5.Size = new System.Drawing.Size(157, 90);
            this.numBox5.TabIndex = 12;
            this.numBox5.Text = "number";
            this.numBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numBox4
            // 
            this.numBox4.BackColor = System.Drawing.Color.White;
            this.numBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBox4.Location = new System.Drawing.Point(292, 27);
            this.numBox4.Name = "numBox4";
            this.numBox4.ReadOnly = true;
            this.numBox4.Size = new System.Drawing.Size(157, 90);
            this.numBox4.TabIndex = 10;
            this.numBox4.Text = "number";
            this.numBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(883, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 108);
            this.label6.TabIndex = 11;
            this.label6.Text = "+";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(435, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 108);
            this.label7.TabIndex = 13;
            this.label7.Text = "+";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(660, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 108);
            this.label8.TabIndex = 15;
            this.label8.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(214, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 108);
            this.label5.TabIndex = 9;
            this.label5.Text = "+";
            // 
            // answerBoxString
            // 
            this.answerBoxString.BackColor = System.Drawing.Color.White;
            this.answerBoxString.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerBoxString.Location = new System.Drawing.Point(449, 483);
            this.answerBoxString.Name = "answerBoxString";
            this.answerBoxString.Size = new System.Drawing.Size(358, 116);
            this.answerBoxString.TabIndex = 17;
            this.answerBoxString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.answerBoxString.TextChanged += new System.EventHandler(this.answerBox_TextChanged);
            // 
            // scoreCopy
            // 
            this.scoreCopy.AutoSize = true;
            this.scoreCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreCopy.Location = new System.Drawing.Point(951, 22);
            this.scoreCopy.Name = "scoreCopy";
            this.scoreCopy.Size = new System.Drawing.Size(203, 55);
            this.scoreCopy.TabIndex = 7;
            this.scoreCopy.Text = "Score: 0";
            // 
            // timeCopy
            // 
            this.timeCopy.AutoSize = true;
            this.timeCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCopy.Location = new System.Drawing.Point(8, 22);
            this.timeCopy.Name = "timeCopy";
            this.timeCopy.Size = new System.Drawing.Size(314, 55);
            this.timeCopy.TabIndex = 6;
            this.timeCopy.Text = "Seconds left: ";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.avgTimeBox);
            this.tabPage4.Controls.Add(this.playAgainButton);
            this.tabPage4.Controls.Add(this.mainMenuButton);
            this.tabPage4.Controls.Add(this.summaryBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1223, 750);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // avgTimeBox
            // 
            this.avgTimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgTimeBox.Location = new System.Drawing.Point(37, 15);
            this.avgTimeBox.Multiline = true;
            this.avgTimeBox.Name = "avgTimeBox";
            this.avgTimeBox.ReadOnly = true;
            this.avgTimeBox.Size = new System.Drawing.Size(1103, 143);
            this.avgTimeBox.TabIndex = 3;
            this.avgTimeBox.Text = "summary goes here";
            this.avgTimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playAgainButton
            // 
            this.playAgainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgainButton.Location = new System.Drawing.Point(354, 569);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(231, 92);
            this.playAgainButton.TabIndex = 2;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuButton.Location = new System.Drawing.Point(717, 569);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(231, 92);
            this.mainMenuButton.TabIndex = 1;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // summaryBox
            // 
            this.summaryBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.summaryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryBox.Location = new System.Drawing.Point(37, 164);
            this.summaryBox.Multiline = true;
            this.summaryBox.Name = "summaryBox";
            this.summaryBox.ReadOnly = true;
            this.summaryBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.summaryBox.Size = new System.Drawing.Size(1103, 364);
            this.summaryBox.TabIndex = 0;
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // nextDelay
            // 
            this.nextDelay.Interval = 300;
            this.nextDelay.Tick += new System.EventHandler(this.nextDelay_Tick);
            // 
            // opacityTimer
            // 
            this.opacityTimer.Interval = 1000;
            this.opacityTimer.Tick += new System.EventHandler(this.opacityTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 731);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.stringPanel.ResumeLayout(false);
            this.stringPanel.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox userMin1;
        private System.Windows.Forms.TextBox userMax1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.TextBox numberBox2;
        private System.Windows.Forms.Label operatorLabel1;
        private System.Windows.Forms.TextBox numberBox1;
        private System.Windows.Forms.CheckedListBox operatorChooser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userMin2;
        private System.Windows.Forms.TextBox userMax2;
        private System.Windows.Forms.Button autoPickerButton;
        private System.Windows.Forms.Label userScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox timeLimitInputBox;
        private System.Windows.Forms.Label timeLeftLabel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label scoreCopy;
        private System.Windows.Forms.Label timeCopy;
        private System.Windows.Forms.TextBox answerBoxString;
        private System.Windows.Forms.TextBox numBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox numBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox numBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numBox3;
        private System.Windows.Forms.Timer nextDelay;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel stringPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label incrementAnim2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label incrementAnim;
        private System.Windows.Forms.Timer opacityTimer;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox summaryBox;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.TextBox avgTimeBox;
    }
}

