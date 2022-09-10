namespace cgLabs
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rightButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.rotateLeft = new System.Windows.Forms.Button();
            this.rotateRight = new System.Windows.Forms.Button();
            this.scaleUp = new System.Windows.Forms.Button();
            this.scaleDown = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(201, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(388, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "Отрисовать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Вращение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Масштаб";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(375, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Перемещение";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(12, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 1);
            this.panel2.TabIndex = 11;
            // 
            // rightButton
            // 
            this.rightButton.Enabled = false;
            this.rightButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.rightButton.Location = new System.Drawing.Point(679, 129);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(75, 45);
            this.rightButton.TabIndex = 14;
            this.rightButton.Text = ">";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Enabled = false;
            this.leftButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.leftButton.Location = new System.Drawing.Point(528, 129);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(75, 45);
            this.leftButton.TabIndex = 15;
            this.leftButton.Text = "<";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // upButton
            // 
            this.upButton.Enabled = false;
            this.upButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.upButton.Location = new System.Drawing.Point(607, 81);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(68, 45);
            this.upButton.TabIndex = 16;
            this.upButton.Text = "^";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // downButton
            // 
            this.downButton.Enabled = false;
            this.downButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.downButton.Location = new System.Drawing.Point(607, 177);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(68, 45);
            this.downButton.TabIndex = 17;
            this.downButton.Text = "v";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // rotateLeft
            // 
            this.rotateLeft.Enabled = false;
            this.rotateLeft.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.rotateLeft.Location = new System.Drawing.Point(144, 120);
            this.rotateLeft.Name = "rotateLeft";
            this.rotateLeft.Size = new System.Drawing.Size(75, 45);
            this.rotateLeft.TabIndex = 18;
            this.rotateLeft.Text = "<";
            this.rotateLeft.UseVisualStyleBackColor = true;
            this.rotateLeft.Click += new System.EventHandler(this.rotateLeft_Click);
            // 
            // rotateRight
            // 
            this.rotateRight.Enabled = false;
            this.rotateRight.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.rotateRight.Location = new System.Drawing.Point(225, 120);
            this.rotateRight.Name = "rotateRight";
            this.rotateRight.Size = new System.Drawing.Size(75, 45);
            this.rotateRight.TabIndex = 19;
            this.rotateRight.Text = ">";
            this.rotateRight.UseVisualStyleBackColor = true;
            this.rotateRight.Click += new System.EventHandler(this.rotateRight_Click);
            // 
            // scaleUp
            // 
            this.scaleUp.Enabled = false;
            this.scaleUp.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.scaleUp.Location = new System.Drawing.Point(225, 174);
            this.scaleUp.Name = "scaleUp";
            this.scaleUp.Size = new System.Drawing.Size(75, 45);
            this.scaleUp.TabIndex = 21;
            this.scaleUp.Text = ">";
            this.scaleUp.UseVisualStyleBackColor = true;
            this.scaleUp.Click += new System.EventHandler(this.scaleUp_Click);
            // 
            // scaleDown
            // 
            this.scaleDown.Enabled = false;
            this.scaleDown.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.scaleDown.Location = new System.Drawing.Point(144, 174);
            this.scaleDown.Name = "scaleDown";
            this.scaleDown.Size = new System.Drawing.Size(75, 45);
            this.scaleDown.TabIndex = 20;
            this.scaleDown.Text = "<";
            this.scaleDown.UseVisualStyleBackColor = true;
            this.scaleDown.Click += new System.EventHandler(this.scaleDown_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.scaleUp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.scaleDown);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rotateRight);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rotateLeft);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.downButton);
            this.panel1.Controls.Add(this.rightButton);
            this.panel1.Controls.Add(this.upButton);
            this.panel1.Controls.Add(this.leftButton);
            this.panel1.Location = new System.Drawing.Point(0, 604);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 265);
            this.panel1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(777, 869);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Laba #1. Akmashev, Kosenko, Sadykov, Chapaev";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button rotateLeft;
        private System.Windows.Forms.Button rotateRight;
        private System.Windows.Forms.Button scaleUp;
        private System.Windows.Forms.Button scaleDown;
        private System.Windows.Forms.Panel panel1;
    }
}

