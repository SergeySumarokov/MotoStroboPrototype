namespace MotoStroboPrototype
{
    partial class FormMain
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
            this.HeadlightLeft = new System.Windows.Forms.Label();
            this.HeadlightRight = new System.Windows.Forms.Label();
            this.IndicatorLight = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.labelPower = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HeadlightLeft
            // 
            this.HeadlightLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeadlightLeft.Location = new System.Drawing.Point(157, 146);
            this.HeadlightLeft.Name = "HeadlightLeft";
            this.HeadlightLeft.Size = new System.Drawing.Size(128, 16);
            this.HeadlightLeft.TabIndex = 2;
            // 
            // HeadlightRight
            // 
            this.HeadlightRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeadlightRight.Location = new System.Drawing.Point(377, 145);
            this.HeadlightRight.Name = "HeadlightRight";
            this.HeadlightRight.Size = new System.Drawing.Size(128, 16);
            this.HeadlightRight.TabIndex = 3;
            // 
            // IndicatorLight
            // 
            this.IndicatorLight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IndicatorLight.Location = new System.Drawing.Point(157, 361);
            this.IndicatorLight.Name = "IndicatorLight";
            this.IndicatorLight.Size = new System.Drawing.Size(16, 16);
            this.IndicatorLight.TabIndex = 4;
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // labelPower
            // 
            this.labelPower.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPower.Location = new System.Drawing.Point(374, 360);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(80, 16);
            this.labelPower.TabIndex = 5;
            this.labelPower.Text = "ПИТАНИЕ";
            this.labelPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPower.Click += new System.EventHandler(this.labelPower_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(205, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "РЕЖИМ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 563);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPower);
            this.Controls.Add(this.IndicatorLight);
            this.Controls.Add(this.HeadlightRight);
            this.Controls.Add(this.HeadlightLeft);
            this.Name = "FormMain";
            this.Text = "Moto Strobo Prototype";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label HeadlightLeft;
        private System.Windows.Forms.Label HeadlightRight;
        private System.Windows.Forms.Label IndicatorLight;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label labelPower;
        private System.Windows.Forms.Label label1;
    }
}

