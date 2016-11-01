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
            this.ModeSwitch = new System.Windows.Forms.Button();
            this.PowerSwitch = new System.Windows.Forms.Button();
            this.HeadlightLeft = new System.Windows.Forms.Label();
            this.HeadlightRight = new System.Windows.Forms.Label();
            this.IndicatorLight = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ModeSwitch
            // 
            this.ModeSwitch.Location = new System.Drawing.Point(157, 349);
            this.ModeSwitch.Name = "ModeSwitch";
            this.ModeSwitch.Size = new System.Drawing.Size(75, 23);
            this.ModeSwitch.TabIndex = 0;
            this.ModeSwitch.Text = "РЕЖИМ";
            this.ModeSwitch.UseVisualStyleBackColor = true;
            // 
            // PowerSwitch
            // 
            this.PowerSwitch.Location = new System.Drawing.Point(439, 349);
            this.PowerSwitch.Name = "PowerSwitch";
            this.PowerSwitch.Size = new System.Drawing.Size(75, 23);
            this.PowerSwitch.TabIndex = 1;
            this.PowerSwitch.Text = "ПИТАНИЕ";
            this.PowerSwitch.UseVisualStyleBackColor = true;
            this.PowerSwitch.Click += new System.EventHandler(this.PowerSwitch_Click);
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
            this.HeadlightRight.Location = new System.Drawing.Point(386, 146);
            this.HeadlightRight.Name = "HeadlightRight";
            this.HeadlightRight.Size = new System.Drawing.Size(128, 16);
            this.HeadlightRight.TabIndex = 3;
            // 
            // IndicatorLight
            // 
            this.IndicatorLight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IndicatorLight.Location = new System.Drawing.Point(269, 349);
            this.IndicatorLight.Name = "IndicatorLight";
            this.IndicatorLight.Size = new System.Drawing.Size(16, 16);
            this.IndicatorLight.TabIndex = 4;
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 563);
            this.Controls.Add(this.IndicatorLight);
            this.Controls.Add(this.HeadlightRight);
            this.Controls.Add(this.HeadlightLeft);
            this.Controls.Add(this.PowerSwitch);
            this.Controls.Add(this.ModeSwitch);
            this.Name = "FormMain";
            this.Text = "Moto Strobo Prototype";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ModeSwitch;
        private System.Windows.Forms.Button PowerSwitch;
        private System.Windows.Forms.Label HeadlightLeft;
        private System.Windows.Forms.Label HeadlightRight;
        private System.Windows.Forms.Label IndicatorLight;
        private System.Windows.Forms.Timer Timer;
    }
}

