namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.conn_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.led_off_btn = new System.Windows.Forms.Button();
            this.led_on_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Led_txt = new System.Windows.Forms.TextBox();
            this.Tmp_group = new System.Windows.Forms.GroupBox();
            this.Tmp_txt = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Light_txt = new System.Windows.Forms.TextBox();
            this.Distance_txt = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Tmp_group.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.conn_btn);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(34, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(243, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // conn_btn
            // 
            this.conn_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(175)))), ((int)(((byte)(109)))));
            this.conn_btn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.conn_btn.Location = new System.Drawing.Point(150, 26);
            this.conn_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.conn_btn.Name = "conn_btn";
            this.conn_btn.Size = new System.Drawing.Size(86, 27);
            this.conn_btn.TabIndex = 1;
            this.conn_btn.Text = "연결";
            this.conn_btn.UseVisualStyleBackColor = false;
            this.conn_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18",
            "COM19",
            "COM20",
            "COM21",
            "COM22",
            "COM23",
            "COM24",
            "COM25",
            "COM26",
            "COM27",
            "COM28"});
            this.comboBox1.Location = new System.Drawing.Point(7, 28);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 25);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.led_off_btn);
            this.groupBox2.Controls.Add(this.led_on_btn);
            this.groupBox2.Location = new System.Drawing.Point(34, 125);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(243, 126);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // led_off_btn
            // 
            this.led_off_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.led_off_btn.Font = new System.Drawing.Font("휴먼둥근헤드라인", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.led_off_btn.Location = new System.Drawing.Point(122, 28);
            this.led_off_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.led_off_btn.Name = "led_off_btn";
            this.led_off_btn.Size = new System.Drawing.Size(114, 78);
            this.led_off_btn.TabIndex = 1;
            this.led_off_btn.Text = "OFF";
            this.led_off_btn.UseVisualStyleBackColor = false;
            this.led_off_btn.Click += new System.EventHandler(this.led_off_btn_Click);
            // 
            // led_on_btn
            // 
            this.led_on_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.led_on_btn.Font = new System.Drawing.Font("휴먼둥근헤드라인", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.led_on_btn.Location = new System.Drawing.Point(7, 28);
            this.led_on_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.led_on_btn.Name = "led_on_btn";
            this.led_on_btn.Size = new System.Drawing.Size(114, 78);
            this.led_on_btn.TabIndex = 0;
            this.led_on_btn.Text = "ON";
            this.led_on_btn.UseVisualStyleBackColor = false;
            this.led_on_btn.Click += new System.EventHandler(this.led_on_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Led_txt);
            this.groupBox3.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(34, 259);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(243, 85);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "점등 상태";
            // 
            // Led_txt
            // 
            this.Led_txt.Location = new System.Drawing.Point(7, 28);
            this.Led_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Led_txt.Name = "Led_txt";
            this.Led_txt.Size = new System.Drawing.Size(229, 26);
            this.Led_txt.TabIndex = 0;
            // 
            // Tmp_group
            // 
            this.Tmp_group.Controls.Add(this.Tmp_txt);
            this.Tmp_group.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Tmp_group.Location = new System.Drawing.Point(34, 353);
            this.Tmp_group.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tmp_group.Name = "Tmp_group";
            this.Tmp_group.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tmp_group.Size = new System.Drawing.Size(243, 85);
            this.Tmp_group.TabIndex = 3;
            this.Tmp_group.TabStop = false;
            this.Tmp_group.Text = "온도";
            // 
            // Tmp_txt
            // 
            this.Tmp_txt.Location = new System.Drawing.Point(7, 28);
            this.Tmp_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tmp_txt.Name = "Tmp_txt";
            this.Tmp_txt.Size = new System.Drawing.Size(230, 26);
            this.Tmp_txt.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Light_txt);
            this.groupBox5.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox5.Location = new System.Drawing.Point(34, 446);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(243, 85);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "조도";
            // 
            // Light_txt
            // 
            this.Light_txt.Location = new System.Drawing.Point(7, 24);
            this.Light_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Light_txt.Name = "Light_txt";
            this.Light_txt.Size = new System.Drawing.Size(229, 26);
            this.Light_txt.TabIndex = 0;
            // 
            // Distance_txt
            // 
            this.Distance_txt.Location = new System.Drawing.Point(7, 24);
            this.Distance_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Distance_txt.Name = "Distance_txt";
            this.Distance_txt.Size = new System.Drawing.Size(229, 26);
            this.Distance_txt.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Distance_txt);
            this.groupBox6.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox6.Location = new System.Drawing.Point(34, 540);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(243, 85);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "거리";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(172)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(317, 690);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.Tmp_group);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("휴먼편지체", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "모듈시험";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Tmp_group.ResumeLayout(false);
            this.Tmp_group.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button conn_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button led_off_btn;
        private System.Windows.Forms.Button led_on_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Led_txt;
        private System.Windows.Forms.GroupBox Tmp_group;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox Tmp_txt;
        private System.Windows.Forms.TextBox Light_txt;
        private System.Windows.Forms.TextBox Distance_txt;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}

