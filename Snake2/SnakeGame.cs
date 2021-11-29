using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Snake2
{
    public enum DireccioSnake
    {
        Dreta,
        Esquerre,
        Amunt,
        Avall
    }
    public class SnakeGame
    {
        public const int X_SIZE = 20;
        public const int Y_SIZE = 20;

        Point capSerp = new Point(0, 0);
        DireccioSnake direccioSnake = DireccioSnake.Avall;

        public Point CapSerp { get => capSerp; set => capSerp = value; }
        public DireccioSnake DireccioSnake { get => direccioSnake; set => direccioSnake = value; }

        internal void Moure()
        {
            capSerp.Y++;
        }
    }
}
