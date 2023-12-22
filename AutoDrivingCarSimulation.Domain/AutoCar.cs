using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDrivingCarSimulation.Domain
{
    public class AutoCar
    {
        private int x;
        private int y;
        private Direction direction;
        private int width;
        private int height;

        public AutoCar(int width, int height, int initialX, int initialY, Direction initialDirection)
        {
            this.width = width;
            this.height = height;
            x = initialX;
            y = initialY;
            direction = initialDirection;
        }
        public void Move(string commands)
        {
            foreach (char command in commands)
            {
                switch (command)
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'F':
                        MoveForward();
                        break;
                    default:
                        break;
                }
            }
        }

        private void TurnLeft()
        {
            direction = (Direction)(((int)direction + 3) % 4); 
        }

        private void TurnRight()
        {
            direction = (Direction)(((int)direction + 1) % 4); 
        }

        private void MoveForward()
        {
            switch (direction)
            {
                case Direction.North:
                    if (y < height - 1)
                        y++;
                    break;
                case Direction.East:
                    if (x < width - 1)
                        x++;
                    break;
                case Direction.South:
                    if (y > 0)
                        y--;
                    break;
                case Direction.West:
                    if (x > 0)
                        x--;
                    break;
            }
        }

        public override string ToString()
        {
            return $"{x} {y} {direction}";
        }
    }
}