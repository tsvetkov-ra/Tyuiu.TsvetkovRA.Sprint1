﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.TsvetkovRA.Sprint1.Task3.V19.Lib
{
    public class DataService : ISprint1Task3V19
    {
        public bool ElephCanMove(double x1, double x2, double y1, double y2)
        {
            bool canMove = Math.Abs(x1 - x2) == Math.Abs(y1 - y2);
        }
    }
}
