﻿namespace cgLabs
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
            this.rightButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.rotateLeft = new System.Windows.Forms.Button();
            this.rotateRight = new System.Windows.Forms.Button();
            this.scaleUp = new System.Windows.Forms.Button();
            this.scaleDown = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TestButton = new System.Windows.Forms.Button();
            this.projectionButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rotateRightZ = new System.Windows.Forms.Button();
            this.rotateLeftZ = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rotateRightY = new System.Windows.Forms.Button();
            this.rotateLeftY = new System.Windows.Forms.Button();
            this.Screen = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Screen)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(31, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "Отрисовать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Вращение X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(435, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Масштаб";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(531, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Перемещение";
            // 
            // rightButton
            // 
            this.rightButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.rightButton.Location = new System.Drawing.Point(838, 137);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(75, 45);
            this.rightButton.TabIndex = 14;
            this.rightButton.Text = ">";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.leftButton.Location = new System.Drawing.Point(687, 137);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(75, 45);
            this.leftButton.TabIndex = 15;
            this.leftButton.Text = "<";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // upButton
            // 
            this.upButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.upButton.Location = new System.Drawing.Point(766, 89);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(68, 45);
            this.upButton.TabIndex = 16;
            this.upButton.Text = "^";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // downButton
            // 
            this.downButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.downButton.Location = new System.Drawing.Point(766, 185);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(68, 45);
            this.downButton.TabIndex = 17;
            this.downButton.Text = "v";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // rotateLeft
            // 
            this.rotateLeft.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.rotateLeft.Location = new System.Drawing.Point(149, 93);
            this.rotateLeft.Name = "rotateLeft";
            this.rotateLeft.Size = new System.Drawing.Size(75, 45);
            this.rotateLeft.TabIndex = 18;
            this.rotateLeft.Text = "<";
            this.rotateLeft.UseVisualStyleBackColor = true;
            this.rotateLeft.Click += new System.EventHandler(this.rotateLeft_Click);
            // 
            // rotateRight
            // 
            this.rotateRight.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.rotateRight.Location = new System.Drawing.Point(230, 93);
            this.rotateRight.Name = "rotateRight";
            this.rotateRight.Size = new System.Drawing.Size(75, 45);
            this.rotateRight.TabIndex = 19;
            this.rotateRight.Text = ">";
            this.rotateRight.UseVisualStyleBackColor = true;
            this.rotateRight.Click += new System.EventHandler(this.rotateRight_Click);
            // 
            // scaleUp
            // 
            this.scaleUp.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.scaleUp.Location = new System.Drawing.Point(640, 195);
            this.scaleUp.Name = "scaleUp";
            this.scaleUp.Size = new System.Drawing.Size(75, 45);
            this.scaleUp.TabIndex = 21;
            this.scaleUp.Text = ">";
            this.scaleUp.UseVisualStyleBackColor = true;
            this.scaleUp.Click += new System.EventHandler(this.scaleUp_Click);
            // 
            // scaleDown
            // 
            this.scaleDown.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.scaleDown.Location = new System.Drawing.Point(559, 195);
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
            this.panel1.Controls.Add(this.TestButton);
            this.panel1.Controls.Add(this.projectionButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.rotateRightZ);
            this.panel1.Controls.Add(this.rotateLeftZ);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rotateRightY);
            this.panel1.Controls.Add(this.rotateLeftY);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.scaleUp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.scaleDown);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rotateRight);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rotateLeft);
            this.panel1.Controls.Add(this.downButton);
            this.panel1.Controls.Add(this.rightButton);
            this.panel1.Controls.Add(this.upButton);
            this.panel1.Controls.Add(this.leftButton);
            this.panel1.Location = new System.Drawing.Point(0, 615);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 254);
            this.panel1.TabIndex = 22;
            // 
            // TestButton
            // 
            this.TestButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TestButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestButton.Location = new System.Drawing.Point(640, 17);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(279, 59);
            this.TestButton.TabIndex = 29;
            this.TestButton.Text = "Анимировать";
            this.TestButton.UseVisualStyleBackColor = false;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // projectionButton
            // 
            this.projectionButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.projectionButton.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.projectionButton.Location = new System.Drawing.Point(336, 17);
            this.projectionButton.Name = "projectionButton";
            this.projectionButton.Size = new System.Drawing.Size(298, 59);
            this.projectionButton.TabIndex = 28;
            this.projectionButton.Text = "Проекция";
            this.projectionButton.UseVisualStyleBackColor = false;
            this.projectionButton.Click += new System.EventHandler(this.projectionButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(26, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Вращение Z";
            // 
            // rotateRightZ
            // 
            this.rotateRightZ.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.rotateRightZ.Location = new System.Drawing.Point(230, 195);
            this.rotateRightZ.Name = "rotateRightZ";
            this.rotateRightZ.Size = new System.Drawing.Size(75, 45);
            this.rotateRightZ.TabIndex = 27;
            this.rotateRightZ.Text = ">";
            this.rotateRightZ.UseVisualStyleBackColor = true;
            this.rotateRightZ.Click += new System.EventHandler(this.rotateRightZ_Click);
            // 
            // rotateLeftZ
            // 
            this.rotateLeftZ.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.rotateLeftZ.Location = new System.Drawing.Point(149, 195);
            this.rotateLeftZ.Name = "rotateLeftZ";
            this.rotateLeftZ.Size = new System.Drawing.Size(75, 45);
            this.rotateLeftZ.TabIndex = 26;
            this.rotateLeftZ.Text = "<";
            this.rotateLeftZ.UseVisualStyleBackColor = true;
            this.rotateLeftZ.Click += new System.EventHandler(this.rotateLeftZ_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(26, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Вращение Y";
            // 
            // rotateRightY
            // 
            this.rotateRightY.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.rotateRightY.Location = new System.Drawing.Point(230, 145);
            this.rotateRightY.Name = "rotateRightY";
            this.rotateRightY.Size = new System.Drawing.Size(75, 45);
            this.rotateRightY.TabIndex = 24;
            this.rotateRightY.Text = ">";
            this.rotateRightY.UseVisualStyleBackColor = true;
            this.rotateRightY.Click += new System.EventHandler(this.rotateRightY_Click);
            // 
            // rotateLeftY
            // 
            this.rotateLeftY.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F);
            this.rotateLeftY.Location = new System.Drawing.Point(149, 145);
            this.rotateLeftY.Name = "rotateLeftY";
            this.rotateLeftY.Size = new System.Drawing.Size(75, 45);
            this.rotateLeftY.TabIndex = 23;
            this.rotateLeftY.Text = "<";
            this.rotateLeftY.UseVisualStyleBackColor = true;
            this.rotateLeftY.Click += new System.EventHandler(this.rotateLeftY_Click);
            // 
            // Screen
            // 
            this.Screen.Location = new System.Drawing.Point(0, 0);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(935, 609);
            this.Screen.TabIndex = 23;
            this.Screen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(931, 870);
            this.Controls.Add(this.Screen);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PlaneProject v0.1 -/- Akmashev, Kosenko, Sadykov.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Screen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button rotateLeft;
        private System.Windows.Forms.Button rotateRight;
        private System.Windows.Forms.Button scaleUp;
        private System.Windows.Forms.Button scaleDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button rotateRightZ;
        private System.Windows.Forms.Button rotateLeftZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button rotateRightY;
        private System.Windows.Forms.Button rotateLeftY;
        private System.Windows.Forms.Button projectionButton;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.PictureBox Screen;
    }
}

