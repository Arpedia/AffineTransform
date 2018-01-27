namespace AffineTransformation
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RotateLabel = new System.Windows.Forms.Label();
            this.TransLabel = new System.Windows.Forms.Label();
            this.RotateValue = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.TranslationX = new System.Windows.Forms.NumericUpDown();
            this.TranslationY = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TransformButton = new System.Windows.Forms.Button();
            this.FileNameBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.Origin = new System.Windows.Forms.RadioButton();
            this.Center = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ScaleBar = new System.Windows.Forms.TrackBar();
            this.ScaleValue = new System.Windows.Forms.Label();
            this.NearestButton = new System.Windows.Forms.Button();
            this.LinerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TranslationX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TranslationY)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RotateLabel
            // 
            this.RotateLabel.AutoSize = true;
            this.RotateLabel.Location = new System.Drawing.Point(523, 14);
            this.RotateLabel.Name = "RotateLabel";
            this.RotateLabel.Size = new System.Drawing.Size(29, 12);
            this.RotateLabel.TabIndex = 1;
            this.RotateLabel.Text = "回転";
            // 
            // TransLabel
            // 
            this.TransLabel.AutoSize = true;
            this.TransLabel.Location = new System.Drawing.Point(523, 100);
            this.TransLabel.Name = "TransLabel";
            this.TransLabel.Size = new System.Drawing.Size(29, 12);
            this.TransLabel.TabIndex = 2;
            this.TransLabel.Text = "移動";
            // 
            // RotateValue
            // 
            this.RotateValue.AutoSize = true;
            this.RotateValue.Location = new System.Drawing.Point(536, 43);
            this.RotateValue.Name = "RotateValue";
            this.RotateValue.Size = new System.Drawing.Size(11, 12);
            this.RotateValue.TabIndex = 3;
            this.RotateValue.Text = "0";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 30;
            this.trackBar1.Location = new System.Drawing.Point(553, 34);
            this.trackBar1.Maximum = 360;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(228, 45);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickFrequency = 45;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // TranslationX
            // 
            this.TranslationX.Location = new System.Drawing.Point(590, 118);
            this.TranslationX.Maximum = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.TranslationX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.TranslationX.Name = "TranslationX";
            this.TranslationX.Size = new System.Drawing.Size(50, 19);
            this.TranslationX.TabIndex = 5;
            // 
            // TranslationY
            // 
            this.TranslationY.Location = new System.Drawing.Point(704, 117);
            this.TranslationY.Maximum = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.TranslationY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.TranslationY.Name = "TranslationY";
            this.TranslationY.Size = new System.Drawing.Size(50, 19);
            this.TranslationY.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(572, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(686, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Y";
            // 
            // TransformButton
            // 
            this.TransformButton.Location = new System.Drawing.Point(522, 216);
            this.TransformButton.Name = "TransformButton";
            this.TransformButton.Size = new System.Drawing.Size(261, 30);
            this.TransformButton.TabIndex = 9;
            this.TransformButton.Text = "適用";
            this.TransformButton.UseVisualStyleBackColor = true;
            this.TransformButton.Click += new System.EventHandler(this.TransformButton_Click);
            // 
            // FileNameBox
            // 
            this.FileNameBox.Location = new System.Drawing.Point(522, 266);
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.Size = new System.Drawing.Size(178, 19);
            this.FileNameBox.TabIndex = 10;
            this.FileNameBox.Text = "image";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(706, 265);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 20);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(522, 292);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(259, 23);
            this.ResetButton.TabIndex = 12;
            this.ResetButton.Text = "リセット";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Origin
            // 
            this.Origin.AutoSize = true;
            this.Origin.Location = new System.Drawing.Point(138, 3);
            this.Origin.Name = "Origin";
            this.Origin.Size = new System.Drawing.Size(78, 16);
            this.Origin.TabIndex = 14;
            this.Origin.Text = "(0,0)を原点";
            this.Origin.UseVisualStyleBackColor = true;
            // 
            // Center
            // 
            this.Center.AutoSize = true;
            this.Center.Checked = true;
            this.Center.Location = new System.Drawing.Point(28, 3);
            this.Center.Name = "Center";
            this.Center.Size = new System.Drawing.Size(104, 16);
            this.Center.TabIndex = 13;
            this.Center.TabStop = true;
            this.Center.Text = "画像中心を原点";
            this.Center.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Center);
            this.panel1.Controls.Add(this.Origin);
            this.panel1.Location = new System.Drawing.Point(522, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 25);
            this.panel1.TabIndex = 15;
            // 
            // ScaleBar
            // 
            this.ScaleBar.Location = new System.Drawing.Point(550, 165);
            this.ScaleBar.Maximum = 20;
            this.ScaleBar.Minimum = 1;
            this.ScaleBar.Name = "ScaleBar";
            this.ScaleBar.Size = new System.Drawing.Size(229, 45);
            this.ScaleBar.TabIndex = 16;
            this.ScaleBar.Value = 10;
            this.ScaleBar.Scroll += new System.EventHandler(this.ScaleBar_Scroll);
            // 
            // ScaleValue
            // 
            this.ScaleValue.AutoSize = true;
            this.ScaleValue.Location = new System.Drawing.Point(536, 177);
            this.ScaleValue.Name = "ScaleValue";
            this.ScaleValue.Size = new System.Drawing.Size(11, 12);
            this.ScaleValue.TabIndex = 17;
            this.ScaleValue.Text = "1";
            // 
            // NearestButton
            // 
            this.NearestButton.Location = new System.Drawing.Point(522, 346);
            this.NearestButton.Name = "NearestButton";
            this.NearestButton.Size = new System.Drawing.Size(132, 23);
            this.NearestButton.TabIndex = 18;
            this.NearestButton.Text = "最近傍法";
            this.NearestButton.UseVisualStyleBackColor = true;
            this.NearestButton.Click += new System.EventHandler(this.NearestButton_Click);
            // 
            // LinerButton
            // 
            this.LinerButton.Location = new System.Drawing.Point(660, 346);
            this.LinerButton.Name = "LinerButton";
            this.LinerButton.Size = new System.Drawing.Size(118, 23);
            this.LinerButton.TabIndex = 19;
            this.LinerButton.Text = "線形補完法";
            this.LinerButton.UseVisualStyleBackColor = true;
            this.LinerButton.Click += new System.EventHandler(this.LinerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 525);
            this.Controls.Add(this.LinerButton);
            this.Controls.Add(this.NearestButton);
            this.Controls.Add(this.ScaleValue);
            this.Controls.Add(this.ScaleBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FileNameBox);
            this.Controls.Add(this.TransformButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TranslationY);
            this.Controls.Add(this.TranslationX);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.RotateValue);
            this.Controls.Add(this.TransLabel);
            this.Controls.Add(this.RotateLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TranslationX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TranslationY)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label RotateLabel;
        private System.Windows.Forms.Label TransLabel;
        private System.Windows.Forms.Label RotateValue;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.NumericUpDown TranslationX;
        private System.Windows.Forms.NumericUpDown TranslationY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TransformButton;
        private System.Windows.Forms.TextBox FileNameBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.RadioButton Origin;
        private System.Windows.Forms.RadioButton Center;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TrackBar ScaleBar;
        private System.Windows.Forms.Label ScaleValue;
        private System.Windows.Forms.Button NearestButton;
        private System.Windows.Forms.Button LinerButton;
    }
}

