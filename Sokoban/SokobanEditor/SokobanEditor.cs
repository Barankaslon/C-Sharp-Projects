namespace SokobanEditor
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

    public partial class SokobanEditor : Form
    {



        public SokobanEditor()
        {
            InitializeComponent();
        }

        private void SokobanEditor_Load(object sender, EventArgs e)
        {
            Cell[,] cell;
            LevelFile level = new LevelFile("levels.txt");
            cell = level.LoadLevel(2);
        }
    }
}