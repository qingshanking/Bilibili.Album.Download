namespace Main
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.doc_id_text = new CCWin.SkinControl.SkinWaterTextBox();
            this.down_btn = new CCWin.SkinControl.SkinButton();
            this.long_text = new CCWin.SkinControl.RtfRichTextBox();
            this.Version_Label = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(68, 47);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(68, 17);
            this.skinLabel1.TabIndex = 4;
            this.skinLabel1.Text = "相簿编号：";
            // 
            // doc_id_text
            // 
            this.doc_id_text.Location = new System.Drawing.Point(132, 44);
            this.doc_id_text.Name = "doc_id_text";
            this.doc_id_text.Size = new System.Drawing.Size(207, 21);
            this.doc_id_text.TabIndex = 5;
            this.doc_id_text.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.doc_id_text.WaterText = "";
            // 
            // down_btn
            // 
            this.down_btn.BackColor = System.Drawing.Color.Transparent;
            this.down_btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.down_btn.DownBack = null;
            this.down_btn.Location = new System.Drawing.Point(345, 44);
            this.down_btn.MouseBack = null;
            this.down_btn.Name = "down_btn";
            this.down_btn.NormlBack = null;
            this.down_btn.Size = new System.Drawing.Size(75, 23);
            this.down_btn.TabIndex = 6;
            this.down_btn.Text = "下载相簿";
            this.down_btn.UseVisualStyleBackColor = false;
            this.down_btn.Click += new System.EventHandler(this.down_btn_Click);
            // 
            // long_text
            // 
            this.long_text.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.long_text.Location = new System.Drawing.Point(49, 73);
            this.long_text.Name = "long_text";
            this.long_text.Size = new System.Drawing.Size(450, 96);
            this.long_text.TabIndex = 7;
            this.long_text.Text = "系统提示：本工具仅供用于学习和交流，请勿用于商业用途，请尊重B站版权要求";
            this.long_text.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            // 
            // Version_Label
            // 
            this.Version_Label.AutoSize = true;
            this.Version_Label.BackColor = System.Drawing.Color.Transparent;
            this.Version_Label.BorderColor = System.Drawing.Color.White;
            this.Version_Label.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Version_Label.Location = new System.Drawing.Point(450, 49);
            this.Version_Label.Name = "Version_Label";
            this.Version_Label.Size = new System.Drawing.Size(47, 17);
            this.Version_Label.TabIndex = 9;
            this.Version_Label.Text = "V 1.0.1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 203);
            this.Controls.Add(this.Version_Label);
            this.Controls.Add(this.long_text);
            this.Controls.Add(this.down_btn);
            this.Controls.Add(this.doc_id_text);
            this.Controls.Add(this.skinLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "哔哩哔哩相簿 下载工具";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinWaterTextBox doc_id_text;
        private CCWin.SkinControl.SkinButton down_btn;
        private CCWin.SkinControl.RtfRichTextBox long_text;
        private CCWin.SkinControl.SkinLabel Version_Label;
    }
}

