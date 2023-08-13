using System.Drawing.Drawing2D;
namespace RoundImagePicturebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Region = GetRoundedImagePicturebox(pictureBox1);
        }
        private Region GetRoundedImagePicturebox(PictureBox pictureBox)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);
            Region rgn = new Region(graphicsPath);
            return rgn;
        }
    }
}