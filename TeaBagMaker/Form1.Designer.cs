namespace TeaBagMaker
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
			this.components = new System.ComponentModel.Container();
			this.title = new System.Windows.Forms.Label();
			this.teaList = new System.Windows.Forms.ComboBox();
			this.countLabel = new System.Windows.Forms.Label();
			this.timeResult = new System.Windows.Forms.Label();
			this.startBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Timer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.title.Location = new System.Drawing.Point(48, 9);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(186, 31);
			this.title.TabIndex = 0;
			this.title.Text = "TeaBagMaker";
			// 
			// teaList
			// 
			this.teaList.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.teaList.FormattingEnabled = true;
			this.teaList.Location = new System.Drawing.Point(40, 55);
			this.teaList.Name = "teaList";
			this.teaList.Size = new System.Drawing.Size(122, 22);
			this.teaList.TabIndex = 1;
			this.teaList.SelectedIndexChanged += new System.EventHandler(this.TeaList_SelectedIndexChanged);
			// 
			// countLabel
			// 
			this.countLabel.AutoSize = true;
			this.countLabel.Location = new System.Drawing.Point(40, 88);
			this.countLabel.Name = "countLabel";
			this.countLabel.Size = new System.Drawing.Size(0, 12);
			this.countLabel.TabIndex = 2;
			// 
			// timeResult
			// 
			this.timeResult.AutoSize = true;
			this.timeResult.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.timeResult.Location = new System.Drawing.Point(36, 100);
			this.timeResult.Name = "timeResult";
			this.timeResult.Size = new System.Drawing.Size(48, 19);
			this.timeResult.TabIndex = 3;
			this.timeResult.Text = "시간: ";
			// 
			// startBtn
			// 
			this.startBtn.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.startBtn.Location = new System.Drawing.Point(170, 54);
			this.startBtn.Name = "startBtn";
			this.startBtn.Size = new System.Drawing.Size(75, 23);
			this.startBtn.TabIndex = 4;
			this.startBtn.Text = "담그기!";
			this.startBtn.UseVisualStyleBackColor = true;
			this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.Location = new System.Drawing.Point(121, 143);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 14);
			this.label1.TabIndex = 5;
			this.label1.Text = "19-05-24  3217최유라";
			// 
			// Timer
			// 
			this.Timer.Interval = 1000;
			this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(280, 182);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.startBtn);
			this.Controls.Add(this.timeResult);
			this.Controls.Add(this.countLabel);
			this.Controls.Add(this.teaList);
			this.Controls.Add(this.title);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label title;
		private System.Windows.Forms.ComboBox teaList;
		private System.Windows.Forms.Label countLabel;
		private System.Windows.Forms.Label timeResult;
		private System.Windows.Forms.Button startBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer Timer;
	}
}

