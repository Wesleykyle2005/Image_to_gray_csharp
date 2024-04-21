namespace ImageToGray
{
    partial class ImagesForm
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
            selectButton = new Button();
            button1 = new Button();
            convertButton = new Button();
            exitButton = new Button();
            originalImagesPanel = new FlowLayoutPanel();
            ConvertedImagesPanel = new FlowLayoutPanel();
            maximizeButton = new Button();
            labelbtn = new Button();
            btnLabel = new Button();
            minimizeButton = new Button();
            SuspendLayout();
            // 
            // selectButton
            // 
            selectButton.Cursor = Cursors.Hand;
            selectButton.FlatStyle = FlatStyle.Flat;
            selectButton.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectButton.ForeColor = Color.FromArgb(40, 80, 166);
            selectButton.Location = new Point(50, 50);
            selectButton.Margin = new Padding(0);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(200, 50);
            selectButton.TabIndex = 0;
            selectButton.Text = "Seleccione las imagenes";
            selectButton.UseVisualStyleBackColor = true;
            selectButton.Click += selectButton_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(249, 100);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(0, 0);
            button1.TabIndex = 1;
            button1.Text = "Seleccione las imagenes";
            button1.UseVisualStyleBackColor = true;
            // 
            // convertButton
            // 
            convertButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            convertButton.Cursor = Cursors.Hand;
            convertButton.FlatStyle = FlatStyle.Flat;
            convertButton.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            convertButton.ForeColor = Color.FromArgb(40, 80, 166);
            convertButton.Location = new Point(450, 50);
            convertButton.Margin = new Padding(0);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(200, 50);
            convertButton.TabIndex = 2;
            convertButton.Text = "Convertir";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exitButton.Cursor = Cursors.Hand;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Cascadia Code", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.ForeColor = Color.FromArgb(3, 62, 140);
            exitButton.Location = new Point(670, 0);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(30, 35);
            exitButton.TabIndex = 4;
            exitButton.Text = "X\r\n";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // originalImagesPanel
            // 
            originalImagesPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            originalImagesPanel.BackColor = Color.FromArgb(79, 163, 132);
            originalImagesPanel.BorderStyle = BorderStyle.FixedSingle;
            originalImagesPanel.Location = new Point(0, 155);
            originalImagesPanel.Name = "originalImagesPanel";
            originalImagesPanel.Size = new Size(350, 345);
            originalImagesPanel.TabIndex = 6;
            // 
            // ConvertedImagesPanel
            // 
            ConvertedImagesPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ConvertedImagesPanel.BackColor = Color.FromArgb(79, 163, 132);
            ConvertedImagesPanel.BorderStyle = BorderStyle.FixedSingle;
            ConvertedImagesPanel.Location = new Point(350, 155);
            ConvertedImagesPanel.Name = "ConvertedImagesPanel";
            ConvertedImagesPanel.Size = new Size(350, 345);
            ConvertedImagesPanel.TabIndex = 7;
            // 
            // maximizeButton
            // 
            maximizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maximizeButton.Cursor = Cursors.Hand;
            maximizeButton.FlatStyle = FlatStyle.Flat;
            maximizeButton.Font = new Font("Cascadia Code", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            maximizeButton.ForeColor = Color.FromArgb(3, 62, 140);
            maximizeButton.Location = new Point(640, 0);
            maximizeButton.Name = "maximizeButton";
            maximizeButton.Size = new Size(30, 35);
            maximizeButton.TabIndex = 8;
            maximizeButton.Text = "⬜";
            maximizeButton.UseVisualStyleBackColor = true;
            maximizeButton.Click += maximizeButton_Click;
            // 
            // labelbtn
            // 
            labelbtn.Enabled = false;
            labelbtn.FlatStyle = FlatStyle.Flat;
            labelbtn.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelbtn.ForeColor = Color.FromArgb(40, 80, 166);
            labelbtn.Location = new Point(100, 115);
            labelbtn.Margin = new Padding(0);
            labelbtn.Name = "labelbtn";
            labelbtn.Size = new Size(100, 40);
            labelbtn.TabIndex = 9;
            labelbtn.Text = "Antes";
            labelbtn.UseVisualStyleBackColor = true;
            // 
            // btnLabel
            // 
            btnLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLabel.Enabled = false;
            btnLabel.FlatStyle = FlatStyle.Flat;
            btnLabel.Font = new Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLabel.ForeColor = Color.FromArgb(40, 80, 166);
            btnLabel.Location = new Point(500, 115);
            btnLabel.Margin = new Padding(0);
            btnLabel.Name = "btnLabel";
            btnLabel.Size = new Size(100, 40);
            btnLabel.TabIndex = 10;
            btnLabel.Text = "Despues";
            btnLabel.UseVisualStyleBackColor = true;
            // 
            // minimizeButton
            // 
            minimizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizeButton.Cursor = Cursors.Hand;
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.Font = new Font("Cascadia Code", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minimizeButton.ForeColor = Color.FromArgb(3, 62, 140);
            minimizeButton.Location = new Point(610, 0);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(30, 35);
            minimizeButton.TabIndex = 11;
            minimizeButton.Text = "-\r\n";
            minimizeButton.UseVisualStyleBackColor = true;
            minimizeButton.Click += minimizeButton_Click;
            // 
            // ImagesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(145, 180, 255);
            ClientSize = new Size(700, 500);
            Controls.Add(minimizeButton);
            Controls.Add(btnLabel);
            Controls.Add(labelbtn);
            Controls.Add(maximizeButton);
            Controls.Add(ConvertedImagesPanel);
            Controls.Add(originalImagesPanel);
            Controls.Add(exitButton);
            Controls.Add(convertButton);
            Controls.Add(button1);
            Controls.Add(selectButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ImagesForm";
            Text = "ImagesForm";
            MouseDown += ImagesForm_MouseDown;
            MouseMove += ImagesForm_MouseMove;
            MouseUp += ImagesForm_MouseUp;
            ResumeLayout(false);
        }

        #endregion

        private Button selectButton;
        private Button button1;
        private Button convertButton;
        private Button exitButton;
        private FlowLayoutPanel originalImagesPanel;
        private FlowLayoutPanel ConvertedImagesPanel;
        private Button maximizeButton;
        private Button labelbtn;
        private Button btnLabel;
        private Button minimizeButton;
    }
}