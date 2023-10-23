namespace TestForms
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
            FirstTextBox = new TextBox();
            SecondTextBox = new TextBox();
            ThirdTextBox = new TextBox();
            FristSideLable = new Label();
            SecondSideLable = new Label();
            ThridSideLable = new Label();
            ResoltLable = new Label();
            DrawButton = new Button();
            SuspendLayout();
            // 
            // FirstTextBox
            // 
            FirstTextBox.BackColor = Color.LightCoral;
            FirstTextBox.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            FirstTextBox.ForeColor = Color.White;
            FirstTextBox.Location = new Point(12, 88);
            FirstTextBox.Name = "FirstTextBox";
            FirstTextBox.Size = new Size(172, 37);
            FirstTextBox.TabIndex = 0;
            FirstTextBox.Text = "0";
            // 
            // SecondTextBox
            // 
            SecondTextBox.BackColor = Color.LightCoral;
            SecondTextBox.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SecondTextBox.ForeColor = Color.White;
            SecondTextBox.Location = new Point(241, 88);
            SecondTextBox.Name = "SecondTextBox";
            SecondTextBox.Size = new Size(166, 37);
            SecondTextBox.TabIndex = 1;
            SecondTextBox.Text = "0";
            // 
            // ThirdTextBox
            // 
            ThirdTextBox.BackColor = Color.LightCoral;
            ThirdTextBox.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ThirdTextBox.ForeColor = Color.White;
            ThirdTextBox.Location = new Point(457, 88);
            ThirdTextBox.Name = "ThirdTextBox";
            ThirdTextBox.Size = new Size(165, 37);
            ThirdTextBox.TabIndex = 2;
            ThirdTextBox.Text = "0";
            // 
            // FristSideLable
            // 
            FristSideLable.AutoSize = true;
            FristSideLable.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            FristSideLable.ForeColor = Color.White;
            FristSideLable.Location = new Point(12, 56);
            FristSideLable.Name = "FristSideLable";
            FristSideLable.Size = new Size(172, 29);
            FristSideLable.TabIndex = 3;
            FristSideLable.Text = "Первая сторона";
            // 
            // SecondSideLable
            // 
            SecondSideLable.AutoSize = true;
            SecondSideLable.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SecondSideLable.ForeColor = Color.White;
            SecondSideLable.Location = new Point(241, 56);
            SecondSideLable.Name = "SecondSideLable";
            SecondSideLable.Size = new Size(166, 29);
            SecondSideLable.TabIndex = 4;
            SecondSideLable.Text = "Вторая сторона";
            // 
            // ThridSideLable
            // 
            ThridSideLable.AutoSize = true;
            ThridSideLable.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ThridSideLable.ForeColor = Color.White;
            ThridSideLable.Location = new Point(457, 56);
            ThridSideLable.Name = "ThridSideLable";
            ThridSideLable.Size = new Size(165, 29);
            ThridSideLable.TabIndex = 5;
            ThridSideLable.Text = "Третья сторона";
            // 
            // ResoltLable
            // 
            ResoltLable.AutoSize = true;
            ResoltLable.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ResoltLable.ForeColor = Color.White;
            ResoltLable.Location = new Point(53, 312);
            ResoltLable.Name = "ResoltLable";
            ResoltLable.Size = new Size(175, 29);
            ResoltLable.TabIndex = 7;
            ResoltLable.Text = "Введите данные";
            // 
            // DrawButton
            // 
            DrawButton.BackColor = Color.LightCoral;
            DrawButton.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            DrawButton.ForeColor = Color.White;
            DrawButton.Location = new Point(180, 162);
            DrawButton.Name = "DrawButton";
            DrawButton.Size = new Size(277, 55);
            DrawButton.TabIndex = 8;
            DrawButton.Text = "Нарисовать треугольник";
            DrawButton.UseVisualStyleBackColor = false;
            DrawButton.Click += DrawButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.HotPink;
            ClientSize = new Size(634, 470);
            Controls.Add(DrawButton);
            Controls.Add(ResoltLable);
            Controls.Add(ThridSideLable);
            Controls.Add(SecondSideLable);
            Controls.Add(FristSideLable);
            Controls.Add(ThirdTextBox);
            Controls.Add(SecondTextBox);
            Controls.Add(FirstTextBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            HelpButton = true;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FirstTextBox;
        private TextBox SecondTextBox;
        private TextBox ThirdTextBox;
        private Label FristSideLable;
        private Label SecondSideLable;
        private Label ThridSideLable;
        private Label ResoltLable;
        private Button DrawButton;
    }
}