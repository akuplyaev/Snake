﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake {
    class Program {
        static void Main(string[] args) {
            Console.SetBufferSize(80,25);
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0,24,0,'+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();
<<<<<<< 01ea44ba28582ce02a6c06cc18cd7604a936f1ac
            Console.ReadKey();
           
=======
            Point p = new Point(3,4,'*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            Console.ReadKey();
>>>>>>> 264cccedcb009168e7401229ab3fe9451d115159
        }
    }
}
