namespace ControlLibrary
{
    partial class TextBoxBtnEx
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
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnContent = new ControlLibrary.ButtonEx();
            this.panelBorder.SuspendLayout();
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
            this.panelBorder.Controls.Add(this.txtContent);
            this.panelBorder.Controls.Add(this.btnContent);
            this.panelBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.panelBorder.Location = new System.Drawing.Point(0, 0);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(148, 32);
            this.panelBorder.TabIndex = 2;
            // 
            // txtContent
            // 
            this.txtContent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtContent.BackColor = System.Drawing.Color.Snow;
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.txtContent.Location = new System.Drawing.Point(5, 6);
            this.txtContent.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(109, 19);
            this.txtContent.TabIndex = 1;
            // 
            // btnContent
            // 
            this.btnContent.ActiveLeftLineSize = 0;
            this.btnContent.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnContent.BorderSkin.ColorSkin.ActiveColor = System.Drawing.Color.Red;
            this.btnContent.BorderSkin.ColorSkin.NomalColor = System.Drawing.Color.Black;
            this.btnContent.BorderSkin.LineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.btnContent.BorderSkin.LineWidth = 1F;
            this.btnContent.BorderSkin.ShowBottomLine = false;
            this.btnContent.BorderSkin.ShowLeftLine = false;
            this.btnContent.BorderSkin.ShowRightLine = false;
            this.btnContent.BorderSkin.ShowTopLine = false;
            this.btnContent.BtnPressState = false;
            this.btnContent.ColorSkin.ActiveColor = System.Drawing.SystemColors.Highlight;
            this.btnContent.ColorSkin.NomalColor = System.Drawing.SystemColors.WindowText;
            this.btnContent.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnContent.GroupNum = 0;
            this.btnContent.IconSkin.IconPoint = new System.Drawing.Point(0, 0);
            this.btnContent.IconSkin.IconSize = 17;
            this.btnContent.IconSkin.IconString = "0xf0d7";
            this.btnContent.KeepPressColor = false;
            this.btnContent.Location = new System.Drawing.Point(119, 5);
            this.btnContent.Name = "btnContent";
            this.btnContent.Size = new System.Drawing.Size(24, 23);
            this.btnContent.TabIndex = 0;
            this.btnContent.ToolTipText = "";
            this.btnContent.UseVisualStyleBackColor = true;
            // 
            // TextBoxBtnEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelBorder);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TextBoxBtnEx";
            this.Size = new System.Drawing.Size(148, 32);
            this.panelBorder.ResumeLayout(false);
            this.panelBorder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonEx btnContent;
        private System.Windows.Forms.TextBox txtContent;
        private PanelEx panelBorder;


    }
}
