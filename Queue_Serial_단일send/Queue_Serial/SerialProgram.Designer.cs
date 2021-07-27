
namespace Queue_Serial
{
    partial class SerialProgram
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
            this.components = new System.ComponentModel.Container();
            this.btn_PortSetting = new System.Windows.Forms.Button();
            this.rtb_RecvText = new System.Windows.Forms.RichTextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.tb_SendText = new System.Windows.Forms.TextBox();
            this.btn_PortClose = new System.Windows.Forms.Button();
            this.btn_PortOpen = new System.Windows.Forms.Button();
            this.sp_Port = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // btn_PortSetting
            // 
            this.btn_PortSetting.Location = new System.Drawing.Point(409, 13);
            this.btn_PortSetting.Name = "btn_PortSetting";
            this.btn_PortSetting.Size = new System.Drawing.Size(75, 23);
            this.btn_PortSetting.TabIndex = 26;
            this.btn_PortSetting.Text = "포트설정";
            this.btn_PortSetting.UseVisualStyleBackColor = true;
            this.btn_PortSetting.Click += new System.EventHandler(this.btn_PortSetting_Click);
            // 
            // rtb_RecvText
            // 
            this.rtb_RecvText.Location = new System.Drawing.Point(20, 42);
            this.rtb_RecvText.Name = "rtb_RecvText";
            this.rtb_RecvText.ReadOnly = true;
            this.rtb_RecvText.Size = new System.Drawing.Size(464, 225);
            this.rtb_RecvText.TabIndex = 24;
            this.rtb_RecvText.Text = "";
            // 
            // btn_Send
            // 
            this.btn_Send.Enabled = false;
            this.btn_Send.Location = new System.Drawing.Point(18, 323);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(466, 61);
            this.btn_Send.TabIndex = 23;
            this.btn_Send.Text = "전송";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // tb_SendText
            // 
            this.tb_SendText.Location = new System.Drawing.Point(19, 283);
            this.tb_SendText.Name = "tb_SendText";
            this.tb_SendText.Size = new System.Drawing.Size(463, 21);
            this.tb_SendText.TabIndex = 22;
            // 
            // btn_PortClose
            // 
            this.btn_PortClose.Enabled = false;
            this.btn_PortClose.Location = new System.Drawing.Point(115, 12);
            this.btn_PortClose.Name = "btn_PortClose";
            this.btn_PortClose.Size = new System.Drawing.Size(85, 24);
            this.btn_PortClose.TabIndex = 21;
            this.btn_PortClose.Text = "포트닫기";
            this.btn_PortClose.UseVisualStyleBackColor = true;
            this.btn_PortClose.Click += new System.EventHandler(this.btn_PortClose_Click);
            // 
            // btn_PortOpen
            // 
            this.btn_PortOpen.Location = new System.Drawing.Point(21, 12);
            this.btn_PortOpen.Name = "btn_PortOpen";
            this.btn_PortOpen.Size = new System.Drawing.Size(88, 24);
            this.btn_PortOpen.TabIndex = 20;
            this.btn_PortOpen.Text = "포트열기";
            this.btn_PortOpen.UseVisualStyleBackColor = true;
            this.btn_PortOpen.Click += new System.EventHandler(this.btn_PortOpen_Click);
            // 
            // sp_Port
            // 
            this.sp_Port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.sp_Port_DataReceived);
            // 
            // SerialProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 399);
            this.Controls.Add(this.btn_PortSetting);
            this.Controls.Add(this.rtb_RecvText);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.tb_SendText);
            this.Controls.Add(this.btn_PortClose);
            this.Controls.Add(this.btn_PortOpen);
            this.Name = "SerialProgram";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_PortSetting;
        private System.Windows.Forms.RichTextBox rtb_RecvText;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox tb_SendText;
        private System.Windows.Forms.Button btn_PortClose;
        private System.Windows.Forms.Button btn_PortOpen;
        private System.IO.Ports.SerialPort sp_Port;
    }
}

