namespace UPVApp
{
    partial class LetterForm
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
            this.originAddressLbl = new System.Windows.Forms.Label();
            this.destAddressLbl = new System.Windows.Forms.Label();
            this.costLbl = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.originComboBox = new System.Windows.Forms.ComboBox();
            this.destComboBox = new System.Windows.Forms.ComboBox();
            this.letterErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.letterErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // originAddressLbl
            // 
            this.originAddressLbl.AutoSize = true;
            this.originAddressLbl.Location = new System.Drawing.Point(38, 33);
            this.originAddressLbl.Name = "originAddressLbl";
            this.originAddressLbl.Size = new System.Drawing.Size(78, 13);
            this.originAddressLbl.TabIndex = 0;
            this.originAddressLbl.Text = "Origin Address:";
            // 
            // destAddressLbl
            // 
            this.destAddressLbl.AutoSize = true;
            this.destAddressLbl.Location = new System.Drawing.Point(12, 72);
            this.destAddressLbl.Name = "destAddressLbl";
            this.destAddressLbl.Size = new System.Drawing.Size(104, 13);
            this.destAddressLbl.TabIndex = 1;
            this.destAddressLbl.Text = "Destination Address:";
            // 
            // costLbl
            // 
            this.costLbl.AutoSize = true;
            this.costLbl.Location = new System.Drawing.Point(57, 110);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(59, 13);
            this.costLbl.TabIndex = 2;
            this.costLbl.Text = "Fixed Cost:";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(12, 156);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(197, 156);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(122, 110);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(121, 20);
            this.costTextBox.TabIndex = 3;
            this.costTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.costValidating);
            this.costTextBox.Validated += new System.EventHandler(this.costValidated);
            // 
            // originComboBox
            // 
            this.originComboBox.FormattingEnabled = true;
            this.originComboBox.Location = new System.Drawing.Point(122, 33);
            this.originComboBox.Name = "originComboBox";
            this.originComboBox.Size = new System.Drawing.Size(121, 21);
            this.originComboBox.TabIndex = 1;
            this.originComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.origValidating);
            this.originComboBox.Validated += new System.EventHandler(this.origValidated);
            // 
            // destComboBox
            // 
            this.destComboBox.FormattingEnabled = true;
            this.destComboBox.Location = new System.Drawing.Point(122, 72);
            this.destComboBox.Name = "destComboBox";
            this.destComboBox.Size = new System.Drawing.Size(121, 21);
            this.destComboBox.TabIndex = 2;
            this.destComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.destValidating);
            this.destComboBox.Validated += new System.EventHandler(this.destValidated);
            // 
            // letterErrorProvider
            // 
            this.letterErrorProvider.ContainerControl = this;
            // 
            // LetterForm
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(284, 202);
            this.Controls.Add(this.destComboBox);
            this.Controls.Add(this.originComboBox);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.costLbl);
            this.Controls.Add(this.destAddressLbl);
            this.Controls.Add(this.originAddressLbl);
            this.Name = "LetterForm";
            this.Text = "LetterForm";
            ((System.ComponentModel.ISupportInitialize)(this.letterErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originAddressLbl;
        private System.Windows.Forms.Label destAddressLbl;
        private System.Windows.Forms.Label costLbl;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.ComboBox originComboBox;
        private System.Windows.Forms.ComboBox destComboBox;
        private System.Windows.Forms.ErrorProvider letterErrorProvider;
    }
}