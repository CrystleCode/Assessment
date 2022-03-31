namespace AstronomicalProcessing
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchHourData = new System.Windows.Forms.TextBox();
            this.grpHoldList = new System.Windows.Forms.GroupBox();
            this.lbxHourData = new System.Windows.Forms.ListBox();
            this.btnHourData = new System.Windows.Forms.Button();
            this.txtInputHourData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEditData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateData = new System.Windows.Forms.Button();
            this.btnPrintAllData = new System.Windows.Forms.Button();
            this.btnClearAllData = new System.Windows.Forms.Button();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.btnInsertRandomData = new System.Windows.Forms.Button();
            this.grpHoldList.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search hour";
            // 
            // txtSearchHourData
            // 
            this.txtSearchHourData.Location = new System.Drawing.Point(269, 108);
            this.txtSearchHourData.Name = "txtSearchHourData";
            this.txtSearchHourData.Size = new System.Drawing.Size(100, 20);
            this.txtSearchHourData.TabIndex = 1;
            // 
            // grpHoldList
            // 
            this.grpHoldList.Controls.Add(this.lbxHourData);
            this.grpHoldList.Location = new System.Drawing.Point(13, 13);
            this.grpHoldList.Name = "grpHoldList";
            this.grpHoldList.Size = new System.Drawing.Size(163, 425);
            this.grpHoldList.TabIndex = 2;
            this.grpHoldList.TabStop = false;
            this.grpHoldList.Text = "Hour Data";
            // 
            // lbxHourData
            // 
            this.lbxHourData.FormattingEnabled = true;
            this.lbxHourData.Location = new System.Drawing.Point(6, 19);
            this.lbxHourData.Name = "lbxHourData";
            this.lbxHourData.Size = new System.Drawing.Size(151, 394);
            this.lbxHourData.TabIndex = 0;
            // 
            // btnHourData
            // 
            this.btnHourData.Location = new System.Drawing.Point(185, 134);
            this.btnHourData.Name = "btnHourData";
            this.btnHourData.Size = new System.Drawing.Size(184, 27);
            this.btnHourData.TabIndex = 3;
            this.btnHourData.Text = "Show Single Hour Data";
            this.btnHourData.UseVisualStyleBackColor = true;
            this.btnHourData.Click += new System.EventHandler(this.btnHourData_Click);
            // 
            // txtInputHourData
            // 
            this.txtInputHourData.Location = new System.Drawing.Point(269, 20);
            this.txtInputHourData.Name = "txtInputHourData";
            this.txtInputHourData.Size = new System.Drawing.Size(100, 20);
            this.txtInputHourData.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input Hour";
            // 
            // txtEditData
            // 
            this.txtEditData.Location = new System.Drawing.Point(269, 46);
            this.txtEditData.Name = "txtEditData";
            this.txtEditData.Size = new System.Drawing.Size(100, 20);
            this.txtEditData.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Add / Edit Data";
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.Location = new System.Drawing.Point(185, 72);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(184, 27);
            this.btnUpdateData.TabIndex = 8;
            this.btnUpdateData.Text = "Add / Edit Data";
            this.btnUpdateData.UseVisualStyleBackColor = true;
            this.btnUpdateData.Click += new System.EventHandler(this.btnUpdateData_Click);
            // 
            // btnPrintAllData
            // 
            this.btnPrintAllData.Location = new System.Drawing.Point(185, 312);
            this.btnPrintAllData.Name = "btnPrintAllData";
            this.btnPrintAllData.Size = new System.Drawing.Size(184, 27);
            this.btnPrintAllData.TabIndex = 9;
            this.btnPrintAllData.Text = "Print All Data";
            this.btnPrintAllData.UseVisualStyleBackColor = true;
            this.btnPrintAllData.Click += new System.EventHandler(this.btnPrintAllData_Click);
            // 
            // btnClearAllData
            // 
            this.btnClearAllData.Location = new System.Drawing.Point(185, 345);
            this.btnClearAllData.Name = "btnClearAllData";
            this.btnClearAllData.Size = new System.Drawing.Size(184, 27);
            this.btnClearAllData.TabIndex = 10;
            this.btnClearAllData.Text = "Clear All Data";
            this.btnClearAllData.UseVisualStyleBackColor = true;
            this.btnClearAllData.Click += new System.EventHandler(this.btnClearAllData_Click);
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Location = new System.Drawing.Point(185, 378);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(184, 27);
            this.btnBubbleSort.TabIndex = 11;
            this.btnBubbleSort.Text = "Bubble Sort Hour Data";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // btnInsertRandomData
            // 
            this.btnInsertRandomData.Location = new System.Drawing.Point(185, 411);
            this.btnInsertRandomData.Name = "btnInsertRandomData";
            this.btnInsertRandomData.Size = new System.Drawing.Size(184, 27);
            this.btnInsertRandomData.TabIndex = 12;
            this.btnInsertRandomData.Text = "Insert Random Data";
            this.btnInsertRandomData.UseVisualStyleBackColor = true;
            this.btnInsertRandomData.Click += new System.EventHandler(this.btnInsertRandomData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInsertRandomData);
            this.Controls.Add(this.btnBubbleSort);
            this.Controls.Add(this.btnClearAllData);
            this.Controls.Add(this.btnPrintAllData);
            this.Controls.Add(this.btnUpdateData);
            this.Controls.Add(this.txtEditData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInputHourData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHourData);
            this.Controls.Add(this.grpHoldList);
            this.Controls.Add(this.txtSearchHourData);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpHoldList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchHourData;
        private System.Windows.Forms.GroupBox grpHoldList;
        private System.Windows.Forms.ListBox lbxHourData;
        private System.Windows.Forms.Button btnHourData;
        private System.Windows.Forms.TextBox txtInputHourData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEditData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateData;
        private System.Windows.Forms.Button btnPrintAllData;
        private System.Windows.Forms.Button btnClearAllData;
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnInsertRandomData;
    }
}

