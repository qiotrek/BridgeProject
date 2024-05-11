namespace BridgeProject
{
    partial class BridgeMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CbShapeKind = new ComboBox();
            BtnAdd = new Button();
            tbParameters = new TextBox();
            listBox1 = new ListBox();
            PbShape = new PictureBox();
            TbXML = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PbShape).BeginInit();
            SuspendLayout();
            // 
            // CbShapeKind
            // 
            CbShapeKind.FormattingEnabled = true;
            CbShapeKind.Location = new Point(12, 12);
            CbShapeKind.Name = "CbShapeKind";
            CbShapeKind.Size = new Size(229, 28);
            CbShapeKind.TabIndex = 0;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(12, 80);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(94, 29);
            BtnAdd.TabIndex = 2;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // tbParameters
            // 
            tbParameters.Location = new Point(12, 47);
            tbParameters.Name = "tbParameters";
            tbParameters.Size = new Size(229, 27);
            tbParameters.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 115);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(229, 364);
            listBox1.TabIndex = 4;
            // 
            // PbShape
            // 
            PbShape.Location = new Point(258, 12);
            PbShape.Name = "PbShape";
            PbShape.Size = new Size(670, 250);
            PbShape.TabIndex = 5;
            PbShape.TabStop = false;
            // 
            // TbXML
            // 
            TbXML.Location = new Point(258, 281);
            TbXML.Multiline = true;
            TbXML.Name = "TbXML";
            TbXML.Size = new Size(670, 198);
            TbXML.TabIndex = 6;
            // 
            // BridgeMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 506);
            Controls.Add(TbXML);
            Controls.Add(PbShape);
            Controls.Add(listBox1);
            Controls.Add(tbParameters);
            Controls.Add(BtnAdd);
            Controls.Add(CbShapeKind);
            Name = "BridgeMainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PbShape).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CbShapeKind;
        private ComboBox comboBox1;
        private Button BtnAdd;
        private TextBox tbParameters;
        private ListBox listBox1;
        private PictureBox PbShape;
        private TextBox TbXML;
    }
}
