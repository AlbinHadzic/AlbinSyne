
namespace Ritas
{
    partial class Form1
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
            Btn_Triangle = new Button();
            Btn_Square = new Button();
            Circle = new Button();
            Btn_Clear = new Button();
            Pic_box = new PictureBox();
            Drop_Box_Color = new ComboBox();
            Btn_Undo = new Button();
            Btn_SaveFile = new Button();
            Btn_LoadFile = new Button();
            Btn_SavePic = new Button();
            ((System.ComponentModel.ISupportInitialize)Pic_box).BeginInit();
            SuspendLayout();
            // 
            // Btn_Triangle
            // 
            Btn_Triangle.Location = new Point(576, 71);
            Btn_Triangle.Name = "Btn_Triangle";
            Btn_Triangle.Size = new Size(75, 23);
            Btn_Triangle.TabIndex = 0;
            Btn_Triangle.Text = "Triangle";
            Btn_Triangle.UseVisualStyleBackColor = true;
            Btn_Triangle.Click += Btn_Triangle_Click;
            // 
            // Btn_Square
            // 
            Btn_Square.Location = new Point(576, 112);
            Btn_Square.Name = "Btn_Square";
            Btn_Square.Size = new Size(75, 23);
            Btn_Square.TabIndex = 1;
            Btn_Square.Text = "Square";
            Btn_Square.UseVisualStyleBackColor = true;
            Btn_Square.Click += Btn_Square_Click;
            // 
            // Circle
            // 
            Circle.Location = new Point(576, 161);
            Circle.Name = "Circle";
            Circle.Size = new Size(75, 23);
            Circle.TabIndex = 2;
            Circle.Text = "Circle";
            Circle.UseVisualStyleBackColor = true;
            Circle.Click += Circle_Click;
            // 
            // Btn_Clear
            // 
            Btn_Clear.Location = new Point(576, 327);
            Btn_Clear.Name = "Btn_Clear";
            Btn_Clear.Size = new Size(75, 23);
            Btn_Clear.TabIndex = 3;
            Btn_Clear.Text = "Clear";
            Btn_Clear.UseVisualStyleBackColor = true;
            Btn_Clear.Click += Btn_Clear_Click;
            // 
            // Pic_box
            // 
            Pic_box.BackColor = SystemColors.Window;
            Pic_box.BackgroundImageLayout = ImageLayout.None;
            Pic_box.Location = new Point(26, 32);
            Pic_box.Name = "Pic_box";
            Pic_box.Size = new Size(514, 388);
            Pic_box.TabIndex = 4;
            Pic_box.TabStop = false;
            Pic_box.Paint += pictureBox_Paint;
            Pic_box.MouseDown += Pic_box_Click;
            // 
            // Drop_Box_Color
            // 
            Drop_Box_Color.FormattingEnabled = true;
            Drop_Box_Color.Items.AddRange(new object[] { "Black", "Red", "Orange", "Blue", "Gray", "Purple", "Green", "Pink" });
            Drop_Box_Color.Location = new Point(576, 203);
            Drop_Box_Color.Name = "Drop_Box_Color";
            Drop_Box_Color.Size = new Size(100, 23);
            Drop_Box_Color.TabIndex = 5;
            Drop_Box_Color.Text = "Choose Color";
            Drop_Box_Color.SelectedIndexChanged += Drop_Box_Color_SelectedIndexChanged;
            // 
            // Btn_Undo
            // 
            Btn_Undo.Location = new Point(670, 327);
            Btn_Undo.Name = "Btn_Undo";
            Btn_Undo.Size = new Size(75, 23);
            Btn_Undo.TabIndex = 6;
            Btn_Undo.Text = "Undo";
            Btn_Undo.UseVisualStyleBackColor = true;
            Btn_Undo.Click += Btn_Undo_Click;
            // 
            // Btn_SaveFile
            // 
            Btn_SaveFile.Location = new Point(576, 367);
            Btn_SaveFile.Name = "Btn_SaveFile";
            Btn_SaveFile.Size = new Size(75, 23);
            Btn_SaveFile.TabIndex = 7;
            Btn_SaveFile.Text = "Save File";
            Btn_SaveFile.UseVisualStyleBackColor = true;
            Btn_SaveFile.Click += Btn_SaveFile_Click;
            // 
            // Btn_LoadFile
            // 
            Btn_LoadFile.Location = new Point(670, 367);
            Btn_LoadFile.Name = "Btn_LoadFile";
            Btn_LoadFile.Size = new Size(75, 23);
            Btn_LoadFile.TabIndex = 8;
            Btn_LoadFile.Text = "Load File";
            Btn_LoadFile.UseVisualStyleBackColor = true;
            Btn_LoadFile.Click += Btn_LoadFile_Click;
            // 
            // Btn_SavePic
            // 
            Btn_SavePic.Location = new Point(627, 415);
            Btn_SavePic.Name = "Btn_SavePic";
            Btn_SavePic.Size = new Size(100, 23);
            Btn_SavePic.TabIndex = 9;
            Btn_SavePic.Text = "Save Picture";
            Btn_SavePic.UseVisualStyleBackColor = true;
            Btn_SavePic.Click += Btn_SavePic_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_SavePic);
            Controls.Add(Btn_LoadFile);
            Controls.Add(Btn_SaveFile);
            Controls.Add(Btn_Undo);
            Controls.Add(Drop_Box_Color);
            Controls.Add(Pic_box);
            Controls.Add(Btn_Clear);
            Controls.Add(Circle);
            Controls.Add(Btn_Square);
            Controls.Add(Btn_Triangle);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Pic_box).EndInit();
            ResumeLayout(false);
        }

        private void Pic_box_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button Btn_Triangle;
        private Button Btn_Square;
        private Button Circle;
        private Button Btn_Clear;
        private PictureBox Pic_box;
        private ComboBox Drop_Box_Color;
        private Button Btn_Undo;
        private Button Btn_SaveFile;
        private Button Btn_LoadFile;
        private Button Btn_SavePic;
    }
}
