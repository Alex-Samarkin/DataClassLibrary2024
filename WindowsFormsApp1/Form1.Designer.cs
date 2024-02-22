namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.component11 = new WindowsFormsApp1.Component1(this.components);
            this.userControl11 = new WindowsFormsApp1.UserControl1();
            this.SuspendLayout();
            // 
            // component11
            // 
            this.component11.Color1 = System.Drawing.Color.Red;
            this.component11.Color2 = System.Drawing.Color.Blue;
            this.component11.FIO = "Alex";
            // 
            // userControl11
            // 
            this.userControl11.Color1 = System.Drawing.Color.Red;
            this.userControl11.Color2 = System.Drawing.Color.Blue;
            this.userControl11.Location = new System.Drawing.Point(13, 13);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(150, 150);
            this.userControl11.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Component1 component11;
        private UserControl1 userControl11;
    }
}

