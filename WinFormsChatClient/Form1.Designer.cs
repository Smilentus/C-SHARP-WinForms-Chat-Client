namespace WinFormsChatClient
{
    partial class ClientForm
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
            this.messagesText = new System.Windows.Forms.TextBox();
            this.userInputText = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.inputNameText = new System.Windows.Forms.TextBox();
            this.inputIPText = new System.Windows.Forms.TextBox();
            this.IPLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.AllMessagesLabel = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputPortText = new System.Windows.Forms.TextBox();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonScroll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messagesText
            // 
            this.messagesText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messagesText.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messagesText.Location = new System.Drawing.Point(13, 29);
            this.messagesText.Multiline = true;
            this.messagesText.Name = "messagesText";
            this.messagesText.ReadOnly = true;
            this.messagesText.Size = new System.Drawing.Size(481, 441);
            this.messagesText.TabIndex = 0;
            // 
            // userInputText
            // 
            this.userInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userInputText.Location = new System.Drawing.Point(13, 506);
            this.userInputText.Multiline = true;
            this.userInputText.Name = "userInputText";
            this.userInputText.Size = new System.Drawing.Size(481, 97);
            this.userInputText.TabIndex = 1;
            // 
            // buttonSend
            // 
            this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSend.Location = new System.Drawing.Point(500, 535);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(172, 42);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // inputNameText
            // 
            this.inputNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNameText.Location = new System.Drawing.Point(501, 94);
            this.inputNameText.Name = "inputNameText";
            this.inputNameText.Size = new System.Drawing.Size(170, 20);
            this.inputNameText.TabIndex = 3;
            // 
            // inputIPText
            // 
            this.inputIPText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputIPText.Location = new System.Drawing.Point(500, 142);
            this.inputIPText.Name = "inputIPText";
            this.inputIPText.Size = new System.Drawing.Size(170, 20);
            this.inputIPText.TabIndex = 4;
            // 
            // IPLabel
            // 
            this.IPLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IPLabel.AutoSize = true;
            this.IPLabel.Location = new System.Drawing.Point(500, 126);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(143, 13);
            this.IPLabel.TabIndex = 5;
            this.IPLabel.Text = "Введите IP-адрес сервера:";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(500, 78);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(104, 13);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Введите ваше имя:";
            // 
            // MessageLabel
            // 
            this.MessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(12, 490);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(141, 13);
            this.MessageLabel.TabIndex = 7;
            this.MessageLabel.Text = "Введите ваше сообщение:";
            // 
            // AllMessagesLabel
            // 
            this.AllMessagesLabel.AutoSize = true;
            this.AllMessagesLabel.Location = new System.Drawing.Point(12, 13);
            this.AllMessagesLabel.Name = "AllMessagesLabel";
            this.AllMessagesLabel.Size = new System.Drawing.Size(113, 13);
            this.AllMessagesLabel.TabIndex = 8;
            this.AllMessagesLabel.Text = "История сообщения:";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConnect.Location = new System.Drawing.Point(498, 230);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(172, 42);
            this.buttonConnect.TabIndex = 9;
            this.buttonConnect.Text = "Подключиться";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введите порт сервера:";
            // 
            // inputPortText
            // 
            this.inputPortText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPortText.Location = new System.Drawing.Point(500, 192);
            this.inputPortText.Name = "inputPortText";
            this.inputPortText.Size = new System.Drawing.Size(170, 20);
            this.inputPortText.TabIndex = 10;
            // 
            // updateTimer
            // 
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // buttonScroll
            // 
            this.buttonScroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonScroll.Location = new System.Drawing.Point(503, 433);
            this.buttonScroll.Name = "buttonScroll";
            this.buttonScroll.Size = new System.Drawing.Size(172, 25);
            this.buttonScroll.TabIndex = 12;
            this.buttonScroll.Text = "Промотать вниз";
            this.buttonScroll.UseVisualStyleBackColor = true;
            this.buttonScroll.Click += new System.EventHandler(this.buttonScroll_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 611);
            this.Controls.Add(this.buttonScroll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputPortText);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.AllMessagesLabel);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IPLabel);
            this.Controls.Add(this.inputIPText);
            this.Controls.Add(this.inputNameText);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.userInputText);
            this.Controls.Add(this.messagesText);
            this.MaximumSize = new System.Drawing.Size(700, 650);
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "ClientForm";
            this.Text = "Мультичат";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messagesText;
        private System.Windows.Forms.TextBox userInputText;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox inputNameText;
        private System.Windows.Forms.TextBox inputIPText;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label AllMessagesLabel;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputPortText;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Button buttonScroll;
    }
}

