namespace PhoneSupportWindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tblOuter = new System.Windows.Forms.TableLayoutPanel();
            this.lbxDisplay = new System.Windows.Forms.ListBox();
            this.phoneCallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblTop = new System.Windows.Forms.TableLayoutPanel();
            this.btnDisplayCalls = new System.Windows.Forms.Button();
            this.tblOuter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneCallBindingSource)).BeginInit();
            this.tblTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblOuter
            // 
            this.tblOuter.ColumnCount = 1;
            this.tblOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblOuter.Controls.Add(this.lbxDisplay, 0, 1);
            this.tblOuter.Controls.Add(this.tblTop, 0, 0);
            this.tblOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblOuter.Location = new System.Drawing.Point(0, 0);
            this.tblOuter.Name = "tblOuter";
            this.tblOuter.RowCount = 2;
            this.tblOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblOuter.Size = new System.Drawing.Size(1092, 461);
            this.tblOuter.TabIndex = 0;
            // 
            // lbxDisplay
            // 
            this.lbxDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxDisplay.FormattingEnabled = true;
            this.lbxDisplay.Location = new System.Drawing.Point(3, 233);
            this.lbxDisplay.Name = "lbxDisplay";
            this.lbxDisplay.Size = new System.Drawing.Size(1086, 225);
            this.lbxDisplay.TabIndex = 0;
            this.lbxDisplay.SelectedValueChanged += new System.EventHandler(this.lbxDisplay_SelectedValueChanged);
            // 
            // phoneCallBindingSource
            // 
            this.phoneCallBindingSource.DataSource = typeof(PhoneSupportLog.PhoneCall);
            // 
            // tblTop
            // 
            this.tblTop.ColumnCount = 2;
            this.tblTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblTop.Controls.Add(this.btnDisplayCalls, 1, 0);
            this.tblTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTop.Location = new System.Drawing.Point(3, 3);
            this.tblTop.Name = "tblTop";
            this.tblTop.RowCount = 1;
            this.tblTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblTop.Size = new System.Drawing.Size(1086, 224);
            this.tblTop.TabIndex = 1;
            // 
            // btnDisplayCalls
            // 
            this.btnDisplayCalls.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDisplayCalls.Location = new System.Drawing.Point(777, 198);
            this.btnDisplayCalls.Name = "btnDisplayCalls";
            this.btnDisplayCalls.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayCalls.TabIndex = 2;
            this.btnDisplayCalls.Text = "Display Calls";
            this.btnDisplayCalls.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 461);
            this.Controls.Add(this.tblOuter);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phone Support Log";
            this.tblOuter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phoneCallBindingSource)).EndInit();
            this.tblTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblOuter;
        private System.Windows.Forms.BindingSource phoneCallBindingSource;
        private System.Windows.Forms.ListBox lbxDisplay;
        private System.Windows.Forms.TableLayoutPanel tblTop;
        private System.Windows.Forms.Button btnDisplayCalls;
    }
}

