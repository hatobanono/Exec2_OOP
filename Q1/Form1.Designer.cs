namespace Q1
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.newButton = new System.Windows.Forms.Button();
			this.ansButton = new System.Windows.Forms.Button();
			this.resultTextBox = new System.Windows.Forms.TextBox();
			this.inputTextbox = new System.Windows.Forms.TextBox();
			this.inputButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// newButton
			// 
			this.newButton.Location = new System.Drawing.Point(12, 12);
			this.newButton.Name = "newButton";
			this.newButton.Size = new System.Drawing.Size(75, 23);
			this.newButton.TabIndex = 0;
			this.newButton.Text = "新遊戲";
			this.newButton.UseVisualStyleBackColor = true;
			this.newButton.Click += new System.EventHandler(this.newButton_Click);
			// 
			// ansButton
			// 
			this.ansButton.Location = new System.Drawing.Point(118, 12);
			this.ansButton.Name = "ansButton";
			this.ansButton.Size = new System.Drawing.Size(75, 23);
			this.ansButton.TabIndex = 1;
			this.ansButton.Text = "看答案";
			this.ansButton.UseVisualStyleBackColor = true;
			this.ansButton.Click += new System.EventHandler(this.ansButton_Click);
			// 
			// resultTextBox
			// 
			this.resultTextBox.Location = new System.Drawing.Point(12, 41);
			this.resultTextBox.Multiline = true;
			this.resultTextBox.Name = "resultTextBox";
			this.resultTextBox.Size = new System.Drawing.Size(181, 181);
			this.resultTextBox.TabIndex = 2;
			// 
			// inputTextbox
			// 
			this.inputTextbox.Location = new System.Drawing.Point(12, 228);
			this.inputTextbox.MaxLength = 4;
			this.inputTextbox.Name = "inputTextbox";
			this.inputTextbox.Size = new System.Drawing.Size(100, 22);
			this.inputTextbox.TabIndex = 3;
			// 
			// inputButton
			// 
			this.inputButton.Location = new System.Drawing.Point(118, 226);
			this.inputButton.Name = "inputButton";
			this.inputButton.Size = new System.Drawing.Size(75, 23);
			this.inputButton.TabIndex = 4;
			this.inputButton.Text = "送出";
			this.inputButton.UseVisualStyleBackColor = true;
			this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(208, 272);
			this.Controls.Add(this.inputButton);
			this.Controls.Add(this.inputTextbox);
			this.Controls.Add(this.resultTextBox);
			this.Controls.Add(this.ansButton);
			this.Controls.Add(this.newButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button newButton;
		private System.Windows.Forms.Button ansButton;
		private System.Windows.Forms.TextBox resultTextBox;
		private System.Windows.Forms.TextBox inputTextbox;
		private System.Windows.Forms.Button inputButton;
	}
}

