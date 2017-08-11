namespace App
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrl_select_processes = new System.Windows.Forms.ComboBox();
            this.ctrl_btn_reloadProcesses = new System.Windows.Forms.Button();
            this.ctrl_btn_attect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrl_select_processes
            // 
            this.ctrl_select_processes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctrl_select_processes.FormattingEnabled = true;
            this.ctrl_select_processes.Location = new System.Drawing.Point(53, 12);
            this.ctrl_select_processes.Name = "ctrl_select_processes";
            this.ctrl_select_processes.Size = new System.Drawing.Size(311, 20);
            this.ctrl_select_processes.TabIndex = 0;
            // 
            // ctrl_btn_reloadProcesses
            // 
            this.ctrl_btn_reloadProcesses.Location = new System.Drawing.Point(1, 12);
            this.ctrl_btn_reloadProcesses.Name = "ctrl_btn_reloadProcesses";
            this.ctrl_btn_reloadProcesses.Size = new System.Drawing.Size(46, 20);
            this.ctrl_btn_reloadProcesses.TabIndex = 1;
            this.ctrl_btn_reloadProcesses.Text = "刷新";
            this.ctrl_btn_reloadProcesses.UseVisualStyleBackColor = true;
            this.ctrl_btn_reloadProcesses.Click += new System.EventHandler(this.ctrl_btn_reloadProcesses_Click);
            // 
            // ctrl_btn_attect
            // 
            this.ctrl_btn_attect.Location = new System.Drawing.Point(370, 9);
            this.ctrl_btn_attect.Name = "ctrl_btn_attect";
            this.ctrl_btn_attect.Size = new System.Drawing.Size(64, 23);
            this.ctrl_btn_attect.TabIndex = 2;
            this.ctrl_btn_attect.Text = "Attach";
            this.ctrl_btn_attect.UseVisualStyleBackColor = true;
            this.ctrl_btn_attect.Click += new System.EventHandler(this.ctrl_btn_attect_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 262);
            this.Controls.Add(this.ctrl_btn_attect);
            this.Controls.Add(this.ctrl_btn_reloadProcesses);
            this.Controls.Add(this.ctrl_select_processes);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ctrl_select_processes;
        private System.Windows.Forms.Button ctrl_btn_reloadProcesses;
        private System.Windows.Forms.Button ctrl_btn_attect;
    }
}

