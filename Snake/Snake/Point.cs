using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake {
    class Point {
        int x;
        int y;
        char ch;
      public  Point(){}
       public Point(int _x, int _y, char _ch) {
            x = _x;
            y = _y;
            ch = _ch;
        }

        public void Drow() {
            Console.SetCursorPosition(x, y);
            Console.Write(ch);
        }
    }
    
}
