﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake {
    class HorizontalLine:Figure {
        public HorizontalLine(int xLeft,int xRight,int y, char ch) {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++) {
                Point p = new Point(x,y,ch);
                pList.Add(p);
            }

        }
    }
}
