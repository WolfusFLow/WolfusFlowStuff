namespace Chat
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SaveFile = new System.Windows.Forms.Button();
            this.ChatBox = new System.Windows.Forms.ListBox();
            this.IPConnect = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.ChatMessage = new System.Windows.Forms.TextBox();
            this.tempRichText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(45, 292);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(108, 23);
            this.SaveFile.TabIndex = 0;
            this.SaveFile.Text = "Send";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.Text_To_Send_Click);
            // 
            // ChatBox
            // 
            this.ChatBox.FormattingEnabled = true;
            this.ChatBox.Location = new System.Drawing.Point(15, 85);
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.Size = new System.Drawing.Size(186, 147);
            this.ChatBox.TabIndex = 2;
            // 
            // IPConnect
            // 
            this.IPConnect.Location = new System.Drawing.Point(11, 59);
            this.IPConnect.Name = "IPConnect";
            this.IPConnect.Size = new System.Drawing.Size(185, 20);
            this.IPConnect.TabIndex = 3;
            this.IPConnect.Text = "169.254.244.126";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(255, 292);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(108, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // ChatMessage
            // 
            this.ChatMessage.Location = new System.Drawing.Point(11, 266);
            this.ChatMessage.Name = "ChatMessage";
            this.ChatMessage.Size = new System.Drawing.Size(185, 20);
            this.ChatMessage.TabIndex = 6;
            // 
            // tempRichText
            // 
            this.tempRichText.Location = new System.Drawing.Point(255, 85);
            this.tempRichText.Name = "tempRichText";
            this.tempRichText.Size = new System.Drawing.Size(100, 96);
            this.tempRichText.TabIndex = 7;
            this.tempRichText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "IP Adress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tempRichText);
            this.Controls.Add(this.ChatMessage);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.IPConnect);
            this.Controls.Add(this.ChatBox);
            this.Controls.Add(this.SaveFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.ListBox ChatBox;
        private System.Windows.Forms.TextBox IPConnect;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox ChatMessage;
        private System.Windows.Forms.RichTextBox tempRichText;
        private System.Windows.Forms.Label label1;
    }
}

