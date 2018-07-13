namespace ControlLibrary
{
    partial class NumericUpDownEx
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBorder = new ControlLibrary.PanelEx();
            this.numContent = new System.Windows.Forms.NumericUpDown();
            this.panelBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numContent)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBorder
            // 
            this.panelBorder.BorderSkin.ColorSkin.ActiveColor = System.Drawing.Color.Red;
            this.panelBorder.BorderSkin.ColorSkin.NomalColor = System.Drawing.Color.LightGray;
            this.panelBorder.BorderSkin.LineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.panelBorder.BorderSkin.LineWidth = 1F;
            this.panelBorder.BorderSkin.ShowBottomLine = true;
            this.panelBorder.BorderSkin.ShowLeftLine = true;
            this.panelBorder.BorderSkin.ShowRightLine = true;
            this.panelBorder.BorderSkin.ShowTopLine = true;
            this.panelBorder.Controls.Add(this.numContent);
            this.panelBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBorder.Location = new System.Drawing.Point(0, 0);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(148, 32);
            this.panelBorder.TabIndex = 0;
            // 
            // numContent
            // 
            this.numContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numContent.Location = new System.Drawing.Point(6, 5);
            this.numContent.Name = "numContent";
            this.numContent.Size = new System.Drawing.Size(135, 22);
            this.numContent.TabIndex = 0;
            // 
            // NumericUpDownEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelBorder);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NumericUpDownEx";
            this.Size = new System.Drawing.Size(148, 32);
            this.panelBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PanelEx panelBorder;
        private System.Windows.Forms.NumericUpDown numContent;


    }
}
