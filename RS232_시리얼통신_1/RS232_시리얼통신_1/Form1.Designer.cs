
namespace RS232_시리얼통신_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_comdev = new System.Windows.Forms.ComboBox();
            this.button_cmd = new System.Windows.Forms.Button();
            this.listBox_msg = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "통신 디바이스";
            // 
            // comboBox_comdev
            // 
            this.comboBox_comdev.FormattingEnabled = true;
            this.comboBox_comdev.Location = new System.Drawing.Point(12, 36);
            this.comboBox_comdev.Name = "comboBox_comdev";
            this.comboBox_comdev.Size = new System.Drawing.Size(121, 20);
            this.comboBox_comdev.TabIndex = 1;
            this.comboBox_comdev.SelectedIndexChanged += new System.EventHandler(this.comboBox_comdev_SelectedIndexChanged);
            this.comboBox_comdev.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_comdev_MouseClick);
            // 
            // button_cmd
            // 
            this.button_cmd.Location = new System.Drawing.Point(14, 63);
            this.button_cmd.Name = "button_cmd";
            this.button_cmd.Size = new System.Drawing.Size(119, 40);
            this.button_cmd.TabIndex = 2;
            this.button_cmd.Text = "명령";
            this.button_cmd.UseVisualStyleBackColor = true;
            this.button_cmd.Click += new System.EventHandler(this.button_cmd_Click);
            // 
            // listBox_msg
            // 
            this.listBox_msg.FormattingEnabled = true;
            this.listBox_msg.ItemHeight = 12;
            this.listBox_msg.Location = new System.Drawing.Point(178, 12);
            this.listBox_msg.Name = "listBox_msg";
            this.listBox_msg.Size = new System.Drawing.Size(610, 424);
            this.listBox_msg.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox_msg);
            this.Controls.Add(this.button_cmd);
            this.Controls.Add(this.comboBox_comdev);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ADC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_comdev;
        private System.Windows.Forms.Button button_cmd;
        private System.Windows.Forms.ListBox listBox_msg;
    }
}

