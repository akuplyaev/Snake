﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake {
    class Point {
        public int x;
        public int y;
        public char ch;
        public Point() { }
        public Point(int x, int y, char ch) {
            this.x = x;
            this.y = y;
            this.ch = ch;
        }
        public Point(Point p) {
            x = p.x;
            y = p.y;
            ch = p.ch;
        }
        public void Move(int offset, Direction dir) {
            if (dir == Direction.RIGHT) {
                x = x + offset;
            }
            else if (dir == Direction.LEFT) {
                x = x - offset;
            }
            else if (dir == Direction.UP) {
                y = y - offset;
            }
            else if (dir == Direction.DOWN) {
                y = y + offset;
            }
        }

        public void Draw() {
            Console.SetCursorPosition(x, y);
            Console.Write(ch);
        }
        public bool IsHit(Point p) {
            return p.x == this.x && p.y == this.y;
        }

        public void Clear() {
            ch = ' ';
            Draw();
        }
    }

}
