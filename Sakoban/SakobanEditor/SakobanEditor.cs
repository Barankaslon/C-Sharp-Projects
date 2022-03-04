namespace SakobanEditor
{

    public enum Cell
    {
        none,
        wall,
        abox,
        done,
        here,
        player
    };

    public partial class SakobanEditor : Form
    {
        PictureBox[,] box;
        Cell[,] cell;
        int width, height;

        public SakobanEditor()
        {
            InitializeComponent();
        }

        private void SakobanEditor_Load(object sender, EventArgs e)
        {
            Cell[,] cell;
            LevelFile level = new LevelFile("levels.txt");
            cell = level.LoadLevel(2);

        }

        public void InitPictures()
        {
            box = new PictureBox[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    PictureBox picture = new PictureBox();
                    picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    picture.Location = new System.Drawing.Point(x, y);
                    picture.Size = new System.Drawing.Size(32, 32);
                    picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    panel.Controls.Add(picture);
                    box [x, y] = picture;

                }
            }
        }
    }
}