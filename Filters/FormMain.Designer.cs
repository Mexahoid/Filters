namespace Filters
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
            this.CtrlTCMain = new System.Windows.Forms.TabControl();
            this.CtrlTPLinear = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CtrlRBGaussian = new System.Windows.Forms.RadioButton();
            this.CtrlRBCounterHarmonic = new System.Windows.Forms.RadioButton();
            this.CtrlRBHarmonic = new System.Windows.Forms.RadioButton();
            this.CtrlRBGeometric = new System.Windows.Forms.RadioButton();
            this.CtrlRBAlgebraic = new System.Windows.Forms.RadioButton();
            this.CtrlTrBM = new System.Windows.Forms.TrackBar();
            this.CtrlTPNonLinear = new System.Windows.Forms.TabPage();
            this.CtrlPnlMain = new System.Windows.Forms.Panel();
            this.CtrlBtnLoad = new System.Windows.Forms.Button();
            this.CtrlBtnSave = new System.Windows.Forms.Button();
            this.CtrlNUDCounterHarmonic = new System.Windows.Forms.NumericUpDown();
            this.CtrlTCMain.SuspendLayout();
            this.CtrlTPLinear.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlTrBM)).BeginInit();
            this.CtrlPnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlNUDCounterHarmonic)).BeginInit();
            this.SuspendLayout();
            // 
            // CtrlTCMain
            // 
            this.CtrlTCMain.Controls.Add(this.CtrlTPLinear);
            this.CtrlTCMain.Controls.Add(this.CtrlTPNonLinear);
            this.CtrlTCMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CtrlTCMain.Location = new System.Drawing.Point(0, 0);
            this.CtrlTCMain.Name = "CtrlTCMain";
            this.CtrlTCMain.SelectedIndex = 0;
            this.CtrlTCMain.Size = new System.Drawing.Size(1039, 509);
            this.CtrlTCMain.TabIndex = 0;
            // 
            // CtrlTPLinear
            // 
            this.CtrlTPLinear.Controls.Add(this.groupBox1);
            this.CtrlTPLinear.Controls.Add(this.CtrlTrBM);
            this.CtrlTPLinear.Location = new System.Drawing.Point(4, 22);
            this.CtrlTPLinear.Name = "CtrlTPLinear";
            this.CtrlTPLinear.Padding = new System.Windows.Forms.Padding(3);
            this.CtrlTPLinear.Size = new System.Drawing.Size(1031, 483);
            this.CtrlTPLinear.TabIndex = 0;
            this.CtrlTPLinear.Text = "Линейные";
            this.CtrlTPLinear.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CtrlNUDCounterHarmonic);
            this.groupBox1.Controls.Add(this.CtrlRBGaussian);
            this.groupBox1.Controls.Add(this.CtrlRBCounterHarmonic);
            this.groupBox1.Controls.Add(this.CtrlRBHarmonic);
            this.groupBox1.Controls.Add(this.CtrlRBGeometric);
            this.groupBox1.Controls.Add(this.CtrlRBAlgebraic);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 165);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // CtrlRBGaussian
            // 
            this.CtrlRBGaussian.AutoSize = true;
            this.CtrlRBGaussian.Location = new System.Drawing.Point(6, 111);
            this.CtrlRBGaussian.Name = "CtrlRBGaussian";
            this.CtrlRBGaussian.Size = new System.Drawing.Size(72, 17);
            this.CtrlRBGaussian.TabIndex = 6;
            this.CtrlRBGaussian.Tag = "10";
            this.CtrlRBGaussian.Text = "Гауссова";
            this.CtrlRBGaussian.UseVisualStyleBackColor = true;
            this.CtrlRBGaussian.CheckedChanged += new System.EventHandler(this.CtrlRB_Checked);
            // 
            // CtrlRBCounterHarmonic
            // 
            this.CtrlRBCounterHarmonic.AutoSize = true;
            this.CtrlRBCounterHarmonic.Location = new System.Drawing.Point(6, 88);
            this.CtrlRBCounterHarmonic.Name = "CtrlRBCounterHarmonic";
            this.CtrlRBCounterHarmonic.Size = new System.Drawing.Size(133, 17);
            this.CtrlRBCounterHarmonic.TabIndex = 5;
            this.CtrlRBCounterHarmonic.Tag = "8";
            this.CtrlRBCounterHarmonic.Text = "Контргармоническая";
            this.CtrlRBCounterHarmonic.UseVisualStyleBackColor = true;
            this.CtrlRBCounterHarmonic.CheckedChanged += new System.EventHandler(this.CtrlRB_Checked);
            // 
            // CtrlRBHarmonic
            // 
            this.CtrlRBHarmonic.AutoSize = true;
            this.CtrlRBHarmonic.Location = new System.Drawing.Point(6, 65);
            this.CtrlRBHarmonic.Name = "CtrlRBHarmonic";
            this.CtrlRBHarmonic.Size = new System.Drawing.Size(104, 17);
            this.CtrlRBHarmonic.TabIndex = 4;
            this.CtrlRBHarmonic.Tag = "6";
            this.CtrlRBHarmonic.Text = "Гармоническая";
            this.CtrlRBHarmonic.UseVisualStyleBackColor = true;
            this.CtrlRBHarmonic.CheckedChanged += new System.EventHandler(this.CtrlRB_Checked);
            // 
            // CtrlRBGeometric
            // 
            this.CtrlRBGeometric.AutoSize = true;
            this.CtrlRBGeometric.Location = new System.Drawing.Point(6, 42);
            this.CtrlRBGeometric.Name = "CtrlRBGeometric";
            this.CtrlRBGeometric.Size = new System.Drawing.Size(109, 17);
            this.CtrlRBGeometric.TabIndex = 3;
            this.CtrlRBGeometric.Tag = "4";
            this.CtrlRBGeometric.Text = "Геометрическая";
            this.CtrlRBGeometric.UseVisualStyleBackColor = true;
            this.CtrlRBGeometric.CheckedChanged += new System.EventHandler(this.CtrlRB_Checked);
            // 
            // CtrlRBAlgebraic
            // 
            this.CtrlRBAlgebraic.AutoSize = true;
            this.CtrlRBAlgebraic.Location = new System.Drawing.Point(6, 19);
            this.CtrlRBAlgebraic.Name = "CtrlRBAlgebraic";
            this.CtrlRBAlgebraic.Size = new System.Drawing.Size(108, 17);
            this.CtrlRBAlgebraic.TabIndex = 2;
            this.CtrlRBAlgebraic.Tag = "2";
            this.CtrlRBAlgebraic.Text = "Алгебраическая";
            this.CtrlRBAlgebraic.UseVisualStyleBackColor = true;
            this.CtrlRBAlgebraic.CheckedChanged += new System.EventHandler(this.CtrlRB_Checked);
            // 
            // CtrlTrBM
            // 
            this.CtrlTrBM.LargeChange = 2;
            this.CtrlTrBM.Location = new System.Drawing.Point(245, 6);
            this.CtrlTrBM.Maximum = 5;
            this.CtrlTrBM.Minimum = 1;
            this.CtrlTrBM.Name = "CtrlTrBM";
            this.CtrlTrBM.Size = new System.Drawing.Size(104, 45);
            this.CtrlTrBM.SmallChange = 2;
            this.CtrlTrBM.TabIndex = 0;
            this.CtrlTrBM.TickFrequency = 2;
            this.CtrlTrBM.Value = 3;
            this.CtrlTrBM.Scroll += new System.EventHandler(this.CtrlTrB_Scroll);
            // 
            // CtrlTPNonLinear
            // 
            this.CtrlTPNonLinear.Location = new System.Drawing.Point(4, 22);
            this.CtrlTPNonLinear.Name = "CtrlTPNonLinear";
            this.CtrlTPNonLinear.Padding = new System.Windows.Forms.Padding(3);
            this.CtrlTPNonLinear.Size = new System.Drawing.Size(1031, 483);
            this.CtrlTPNonLinear.TabIndex = 1;
            this.CtrlTPNonLinear.Text = "Нелинейные";
            this.CtrlTPNonLinear.UseVisualStyleBackColor = true;
            // 
            // CtrlPnlMain
            // 
            this.CtrlPnlMain.Controls.Add(this.CtrlTCMain);
            this.CtrlPnlMain.Location = new System.Drawing.Point(12, 41);
            this.CtrlPnlMain.Name = "CtrlPnlMain";
            this.CtrlPnlMain.Size = new System.Drawing.Size(1039, 509);
            this.CtrlPnlMain.TabIndex = 1;
            // 
            // CtrlBtnLoad
            // 
            this.CtrlBtnLoad.Location = new System.Drawing.Point(12, 12);
            this.CtrlBtnLoad.Name = "CtrlBtnLoad";
            this.CtrlBtnLoad.Size = new System.Drawing.Size(75, 23);
            this.CtrlBtnLoad.TabIndex = 0;
            this.CtrlBtnLoad.Text = "Загрузить";
            this.CtrlBtnLoad.UseVisualStyleBackColor = true;
            this.CtrlBtnLoad.Click += new System.EventHandler(this.CtrlBtnLoad_Click);
            // 
            // CtrlBtnSave
            // 
            this.CtrlBtnSave.Location = new System.Drawing.Point(160, 12);
            this.CtrlBtnSave.Name = "CtrlBtnSave";
            this.CtrlBtnSave.Size = new System.Drawing.Size(75, 23);
            this.CtrlBtnSave.TabIndex = 2;
            this.CtrlBtnSave.Text = "Сохранить";
            this.CtrlBtnSave.UseVisualStyleBackColor = true;
            this.CtrlBtnSave.Click += new System.EventHandler(this.CtrlBtnSave_Click);
            // 
            // CtrlNUDCounterHarmonic
            // 
            this.CtrlNUDCounterHarmonic.Location = new System.Drawing.Point(145, 88);
            this.CtrlNUDCounterHarmonic.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.CtrlNUDCounterHarmonic.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.CtrlNUDCounterHarmonic.Name = "CtrlNUDCounterHarmonic";
            this.CtrlNUDCounterHarmonic.Size = new System.Drawing.Size(51, 20);
            this.CtrlNUDCounterHarmonic.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 562);
            this.Controls.Add(this.CtrlBtnSave);
            this.Controls.Add(this.CtrlBtnLoad);
            this.Controls.Add(this.CtrlPnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Фильтры";
            this.Load += new System.EventHandler(this.MormMain_Load);
            this.CtrlTCMain.ResumeLayout(false);
            this.CtrlTPLinear.ResumeLayout(false);
            this.CtrlTPLinear.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlTrBM)).EndInit();
            this.CtrlPnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CtrlNUDCounterHarmonic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl CtrlTCMain;
        private System.Windows.Forms.TabPage CtrlTPLinear;
        private System.Windows.Forms.TabPage CtrlTPNonLinear;
        private System.Windows.Forms.Panel CtrlPnlMain;
        private System.Windows.Forms.Button CtrlBtnLoad;
        private System.Windows.Forms.Button CtrlBtnSave;
        private System.Windows.Forms.TrackBar CtrlTrBM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton CtrlRBCounterHarmonic;
        private System.Windows.Forms.RadioButton CtrlRBHarmonic;
        private System.Windows.Forms.RadioButton CtrlRBGeometric;
        private System.Windows.Forms.RadioButton CtrlRBAlgebraic;
        private System.Windows.Forms.RadioButton CtrlRBGaussian;
        private System.Windows.Forms.NumericUpDown CtrlNUDCounterHarmonic;
    }
}

