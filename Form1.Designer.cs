
namespace _11_Event_Ball_In_Play
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.distanceInput = new System.Windows.Forms.NumericUpDown();
            this.trajectoryInput = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.distanceInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trajectoryInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Tag = "distanceLabel";
            this.label1.Text = "Distance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Tag = "trajectoryLabel";
            this.label2.Text = "Trajectory";
            // 
            // distanceInput
            // 
            this.distanceInput.Location = new System.Drawing.Point(66, 7);
            this.distanceInput.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.distanceInput.Name = "distanceInput";
            this.distanceInput.Size = new System.Drawing.Size(134, 20);
            this.distanceInput.TabIndex = 2;
            this.distanceInput.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // trajectoryInput
            // 
            this.trajectoryInput.Location = new System.Drawing.Point(66, 32);
            this.trajectoryInput.Name = "trajectoryInput";
            this.trajectoryInput.Size = new System.Drawing.Size(134, 20);
            this.trajectoryInput.TabIndex = 3;
            this.trajectoryInput.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.trajectoryInput.ValueChanged += new System.EventHandler(this.inputLabel_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Tag = "playButton";
            this.button1.Text = "Play ball!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 153);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trajectoryInput);
            this.Controls.Add(this.distanceInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.distanceInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trajectoryInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown distanceInput;
        private System.Windows.Forms.NumericUpDown trajectoryInput;
        private System.Windows.Forms.Button button1;
    }
}

