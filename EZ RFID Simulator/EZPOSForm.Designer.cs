namespace EZ_RFID_Simulator
{
    partial class EZPOSForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._sendButton = new System.Windows.Forms.Button();
            this._openPortButton = new System.Windows.Forms.Button();
            this._portComboBox = new System.Windows.Forms.ComboBox();
            this._itemDataGridView = new System.Windows.Forms.DataGridView();
            this._itemTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._clearButton = new System.Windows.Forms.Button();
            this._tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._itemDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _tableLayoutPanel
            // 
            this._tableLayoutPanel.ColumnCount = 4;
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._tableLayoutPanel.Controls.Add(this._sendButton, 2, 1);
            this._tableLayoutPanel.Controls.Add(this._openPortButton, 1, 1);
            this._tableLayoutPanel.Controls.Add(this._portComboBox, 0, 1);
            this._tableLayoutPanel.Controls.Add(this._itemDataGridView, 1, 0);
            this._tableLayoutPanel.Controls.Add(this._itemTableLayoutPanel, 0, 0);
            this._tableLayoutPanel.Controls.Add(this._clearButton, 3, 1);
            this._tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanel.Name = "_tableLayoutPanel";
            this._tableLayoutPanel.RowCount = 2;
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._tableLayoutPanel.Size = new System.Drawing.Size(776, 407);
            this._tableLayoutPanel.TabIndex = 0;
            // 
            // _sendButton
            // 
            this._sendButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._sendButton.Location = new System.Drawing.Point(391, 381);
            this._sendButton.Name = "_sendButton";
            this._sendButton.Size = new System.Drawing.Size(188, 23);
            this._sendButton.TabIndex = 6;
            this._sendButton.Text = "Send";
            this._sendButton.UseVisualStyleBackColor = true;
            this._sendButton.Click += new System.EventHandler(this._sendButton_Click);
            // 
            // _openPortButton
            // 
            this._openPortButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._openPortButton.Location = new System.Drawing.Point(197, 381);
            this._openPortButton.Name = "_openPortButton";
            this._openPortButton.Size = new System.Drawing.Size(188, 23);
            this._openPortButton.TabIndex = 5;
            this._openPortButton.Text = "Open Port";
            this._openPortButton.UseVisualStyleBackColor = true;
            this._openPortButton.Click += new System.EventHandler(this._openPortButton_Click);
            // 
            // _portComboBox
            // 
            this._portComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._portComboBox.FormattingEnabled = true;
            this._portComboBox.Location = new System.Drawing.Point(3, 384);
            this._portComboBox.Name = "_portComboBox";
            this._portComboBox.Size = new System.Drawing.Size(188, 20);
            this._portComboBox.TabIndex = 4;
            // 
            // _itemDataGridView
            // 
            this._itemDataGridView.AllowUserToAddRows = false;
            this._itemDataGridView.AllowUserToDeleteRows = false;
            this._itemDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._tableLayoutPanel.SetColumnSpan(this._itemDataGridView, 2);
            this._itemDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._itemDataGridView.EnableHeadersVisualStyles = false;
            this._itemDataGridView.Location = new System.Drawing.Point(391, 3);
            this._itemDataGridView.Name = "_itemDataGridView";
            this._itemDataGridView.RowHeadersVisible = false;
            this._itemDataGridView.RowTemplate.Height = 24;
            this._itemDataGridView.Size = new System.Drawing.Size(382, 319);
            this._itemDataGridView.TabIndex = 2;
            // 
            // _itemTableLayoutPanel
            // 
            this._itemTableLayoutPanel.ColumnCount = 2;
            this._tableLayoutPanel.SetColumnSpan(this._itemTableLayoutPanel, 2);
            this._itemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._itemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._itemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._itemTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._itemTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this._itemTableLayoutPanel.Name = "_itemTableLayoutPanel";
            this._itemTableLayoutPanel.RowCount = 3;
            this._itemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._itemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._itemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._itemTableLayoutPanel.Size = new System.Drawing.Size(382, 319);
            this._itemTableLayoutPanel.TabIndex = 3;
            // 
            // _clearButton
            // 
            this._clearButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._clearButton.Location = new System.Drawing.Point(585, 381);
            this._clearButton.Name = "_clearButton";
            this._clearButton.Size = new System.Drawing.Size(188, 23);
            this._clearButton.TabIndex = 7;
            this._clearButton.Text = "Clear";
            this._clearButton.UseVisualStyleBackColor = true;
            this._clearButton.Click += new System.EventHandler(this._clearButton_Click);
            // 
            // EZPOSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 407);
            this.Controls.Add(this._tableLayoutPanel);
            this.Name = "EZPOSForm";
            this.Text = "EZPOSForm";
            this.Load += new System.EventHandler(this.EZPOSForm_Load);
            this._tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._itemDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
        private System.Windows.Forms.DataGridView _itemDataGridView;
        private System.Windows.Forms.TableLayoutPanel _itemTableLayoutPanel;
        private System.Windows.Forms.Button _sendButton;
        private System.Windows.Forms.Button _openPortButton;
        private System.Windows.Forms.ComboBox _portComboBox;
        private System.Windows.Forms.Button _clearButton;
    }
}

