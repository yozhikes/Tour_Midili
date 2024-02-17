namespace TourTest.Window.Forms
{
    partial class TourInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TourInfoForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.checkBoxIsActual = new System.Windows.Forms.CheckBox();
            this.numericUpDownTicket = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.textBoxName.Location = new System.Drawing.Point(111, 16);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(235, 34);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.textBoxPrice.Location = new System.Drawing.Point(111, 54);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(116, 34);
            this.textBoxPrice.TabIndex = 3;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.labelPrice.Location = new System.Drawing.Point(15, 56);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(58, 26);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Цена";
            // 
            // checkBoxIsActual
            // 
            this.checkBoxIsActual.AutoSize = true;
            this.checkBoxIsActual.Checked = true;
            this.checkBoxIsActual.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsActual.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.checkBoxIsActual.Location = new System.Drawing.Point(243, 55);
            this.checkBoxIsActual.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxIsActual.Name = "checkBoxIsActual";
            this.checkBoxIsActual.Size = new System.Drawing.Size(115, 30);
            this.checkBoxIsActual.TabIndex = 4;
            this.checkBoxIsActual.Text = "Актуален";
            this.checkBoxIsActual.UseVisualStyleBackColor = true;
            this.checkBoxIsActual.CheckedChanged += new System.EventHandler(this.checkBoxIsActual_CheckedChanged);
            // 
            // numericUpDownTicket
            // 
            this.numericUpDownTicket.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.numericUpDownTicket.Location = new System.Drawing.Point(174, 105);
            this.numericUpDownTicket.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownTicket.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownTicket.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTicket.Name = "numericUpDownTicket";
            this.numericUpDownTicket.Size = new System.Drawing.Size(184, 34);
            this.numericUpDownTicket.TabIndex = 5;
            this.numericUpDownTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownTicket.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTicket.ValueChanged += new System.EventHandler(this.numericUpDownTicket_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.label2.Location = new System.Drawing.Point(15, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Кол-во билетов";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(173, 149);
            this.comboBoxCountry.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(185, 34);
            this.comboBoxCountry.TabIndex = 7;
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.label3.Location = new System.Drawing.Point(15, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Страна";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(227)))), ((int)(((byte)(232)))));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.button1.Location = new System.Drawing.Point(243, 362);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Отменить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butAdd
            // 
            this.butAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(92)))), ((int)(((byte)(147)))));
            this.butAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butAdd.Enabled = false;
            this.butAdd.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.butAdd.Location = new System.Drawing.Point(11, 362);
            this.butAdd.Margin = new System.Windows.Forms.Padding(2);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(110, 46);
            this.butAdd.TabIndex = 10;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butDelete
            // 
            this.butDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.butDelete.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.butDelete.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.butDelete.Location = new System.Drawing.Point(125, 362);
            this.butDelete.Margin = new System.Windows.Forms.Padding(2);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(113, 46);
            this.butDelete.TabIndex = 11;
            this.butDelete.Text = "Удалить";
            this.butDelete.UseVisualStyleBackColor = false;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // checkedListBox
            // 
            this.checkedListBox.CheckOnClick = true;
            this.checkedListBox.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(19, 203);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(332, 149);
            this.checkedListBox.TabIndex = 12;
            // 
            // TourInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(369, 419);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownTicket);
            this.Controls.Add(this.checkBoxIsActual);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(385, 458);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(385, 458);
            this.Name = "TourInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление тура";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.CheckBox checkBoxIsActual;
        private System.Windows.Forms.NumericUpDown numericUpDownTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.CheckedListBox checkedListBox;
    }
}