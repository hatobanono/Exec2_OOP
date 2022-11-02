namespace Q2
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
			this.resultButton = new System.Windows.Forms.Button();
			this.dice1Label = new System.Windows.Forms.Label();
			this.dice2Label = new System.Windows.Forms.Label();
			this.dice3Label = new System.Windows.Forms.Label();
			this.dice4Label = new System.Windows.Forms.Label();
			this.resultLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// resultButton
			// 
			this.resultButton.Location = new System.Drawing.Point(29, 146);
			this.resultButton.Name = "resultButton";
			this.resultButton.Size = new System.Drawing.Size(75, 23);
			this.resultButton.TabIndex = 0;
			this.resultButton.Text = "骰子";
			this.resultButton.UseVisualStyleBackColor = true;
			this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
			// 
			// dice1Label
			// 
			this.dice1Label.AutoSize = true;
			this.dice1Label.Location = new System.Drawing.Point(27, 46);
			this.dice1Label.Name = "dice1Label";
			this.dice1Label.Size = new System.Drawing.Size(30, 12);
			this.dice1Label.TabIndex = 1;
			this.dice1Label.Text = "dice1";
			// 
			// dice2Label
			// 
			this.dice2Label.AutoSize = true;
			this.dice2Label.Location = new System.Drawing.Point(77, 46);
			this.dice2Label.Name = "dice2Label";
			this.dice2Label.Size = new System.Drawing.Size(30, 12);
			this.dice2Label.TabIndex = 1;
			this.dice2Label.Text = "dice2";
			// 
			// dice3Label
			// 
			this.dice3Label.AutoSize = true;
			this.dice3Label.Location = new System.Drawing.Point(27, 84);
			this.dice3Label.Name = "dice3Label";
			this.dice3Label.Size = new System.Drawing.Size(30, 12);
			this.dice3Label.TabIndex = 1;
			this.dice3Label.Text = "dice3";
			// 
			// dice4Label
			// 
			this.dice4Label.AutoSize = true;
			this.dice4Label.Location = new System.Drawing.Point(77, 84);
			this.dice4Label.Name = "dice4Label";
			this.dice4Label.Size = new System.Drawing.Size(30, 12);
			this.dice4Label.TabIndex = 1;
			this.dice4Label.Text = "dice4";
			// 
			// resultLabel
			// 
			this.resultLabel.AutoSize = true;
			this.resultLabel.Location = new System.Drawing.Point(27, 119);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(56, 12);
			this.resultLabel.TabIndex = 2;
			this.resultLabel.Text = "resultLabel";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(144, 206);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.dice4Label);
			this.Controls.Add(this.dice3Label);
			this.Controls.Add(this.dice2Label);
			this.Controls.Add(this.dice1Label);
			this.Controls.Add(this.resultButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button resultButton;
		private System.Windows.Forms.Label dice1Label;
		private System.Windows.Forms.Label dice2Label;
		private System.Windows.Forms.Label dice3Label;
		private System.Windows.Forms.Label dice4Label;
		private System.Windows.Forms.Label resultLabel;
	}
}

