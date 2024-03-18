using System.Windows.Forms;
using static Ritas.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
using System.Windows.Forms.Design;
using Newtonsoft.Json;
using System.Drawing.Imaging;

namespace Ritas
{
    public partial class Form1 : Form
    {

        List<Shape> shapes = new List<Shape>();
        private int selectedSize = 30;
        private int selectedHeight = 30;
        private string selectedShapeType = "";
        private Color selectedColor;
        private SaveFileDialog savePic;

        public Form1()
        {

            InitializeComponent();
            savePic = new();
        }
        // saves the shapes into a JSON File
        private void SaveShapes(string filePath)
        {
            var jsonSerializerSettings = new JsonSerializerSettings()
            { TypeNameHandling = TypeNameHandling.All };
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(shapes, jsonSerializerSettings);
            File.WriteAllText(filePath, json);
        }


        private void Pic_box_Click(object sender, MouseEventArgs e)
        {
            Shape shape = null;

            // Getting the positions and calculating the shapes
            switch (selectedShapeType)
            {
                case "Circle":
                    shape = new Circle { Position = new Point(e.X, e.Y), Color = selectedColor, Size = selectedSize };
                    break;
                case "Rectangle":
                    shape = new Rectangle { Position = new Point(e.X, e.Y), Color = selectedColor, Size = selectedSize, Height = selectedHeight };
                    break;
                case "Triangle":
                    shape = new Triangle { Position = new Point(e.X, e.Y), Color = selectedColor, Size = selectedSize };
                    break;
            }

            if (shape != null)
            {
                shapes.Add(shape);
                Pic_box.Invalidate();
            }
        }

        //Draws the Triangle
        private void Btn_Triangle_Click(object sender, EventArgs e)
        {
            selectedShapeType = "Triangle";
        }
        // Draws the Rectangle
        private void Btn_Square_Click(object sender, EventArgs e)
        {
            selectedShapeType = "Rectangle";
        }

        //Draws a circle
        private void Circle_Click(object sender, EventArgs e)
        {
            selectedShapeType = "Circle";
        }

        //Draws the shapes in the picturebox
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in shapes)
            {
                shape.Draw(e.Graphics);
            }

        }
        //Clears the Window
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            shapes.Clear();

            Pic_box.Invalidate();
        }

        public void Drop_Box_Color_SelectedIndexChanged(object sender, EventArgs e)
        {
            // The colors you can choose in a dictionary
            Dictionary<int, Color> colors = new Dictionary<int, Color>();
            colors.Add(0, Color.Black);
            colors.Add(1, Color.Red);
            colors.Add(2, Color.Orange);
            colors.Add(3, Color.Blue);
            colors.Add(4, Color.Gray);
            colors.Add(5, Color.Purple);
            colors.Add(6, Color.Green);
            colors.Add(7, Color.Pink);
            if (sender is System.Windows.Forms.ComboBox comboBox && comboBox.SelectedIndex >= 0)
            {
                // Getting the color chosen
                if (colors.TryGetValue(comboBox.SelectedIndex, out Color color))
                {
                    selectedColor = color;
                    // refreshing the box
                    Pic_box.Invalidate();
                }
            }

        }
        //The button to undo you last painted shape
        private void Btn_Undo_Click(object sender, EventArgs e)
        {
            if (shapes.Count > 0)
            {
                shapes.RemoveAt(shapes.Count - 1);
                Pic_box.Invalidate();
            }
        }

        //The button for saving the JSON file
        private void Btn_SaveFile_Click(object sender, EventArgs e)
        {
            
            savePic.Filter = "JSON Files|*.json";
            if (savePic.ShowDialog() == DialogResult.OK)
            {
                SaveShapes(savePic.FileName);
            }
        }
        // The code for loading the file
        private void loadShapesFromFile(string filePath)
        {
            var json = File.ReadAllText(filePath);
            var jsonSerializerSettings = new JsonSerializerSettings()
            { TypeNameHandling = TypeNameHandling.All };
            shapes = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Shape>>(json, jsonSerializerSettings);
            Pic_box.Refresh();
        }
        // The button for loading the JSON file
        private void Btn_LoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JSON Files|*.json";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                loadShapesFromFile(ofd.FileName);
            }
        }

        private void Btn_SavePic_Click(object sender, EventArgs e)
        {
            //Saves the file to JPG
            savePic.DefaultExt = "jpg";
            savePic.Filter = "JPG images (*.jpg)|*.jpg";
            var result = savePic.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = savePic.FileName;

                
                //Saves the picturebox to a picture
                var bm = new Bitmap(Pic_box.Width, Pic_box.Height);
                Pic_box.DrawToBitmap(bm, new System.Drawing.Rectangle(0, 0, Pic_box.Width, Pic_box.Height));

                
                //If the filename isnt a jpg file
                if (!Path.HasExtension(fileName) || Path.GetExtension(fileName) != "jpg")
                {
                    fileName = fileName + ".jpg";
                }
                bm.Save(fileName, ImageFormat.Jpeg);
            }
        }
    }
}
