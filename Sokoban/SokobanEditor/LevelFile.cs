using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokobanEditor
{
    public class LevelFile
    {
        string filename;

        public LevelFile (string filename)
        {
            this.filename = filename;
        }

        public Cell [,] LoadLevel(int level_nr)
        {
            string[] lines;

            Cell[,] cell = null;

            try
            {
                lines = File.ReadAllLines(filename);
            } catch
            {
                return cell;
            }



            return cell; 
        }

        private void ReadLevelHeader (string line, out int level_nr, out int width, out int height)
        {
            string[] parts = line.Split();
            level_nr = 0;
            width = 0;
            height = 0;
            if (parts.Length != 3)
                return;
            int.TryParse(parts[0], out level_nr);
            int.TryParse(parts[1], out width);
            int.TryParse(parts[2], out height);
        }

        public void SaveLevel(int level_nr, int x, int y)
        {

        }

    }
}
