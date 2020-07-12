using System;

namespace ExercismCsharp
{
    /// <summary>
    /// Given the size, return a square matrix of numbers in spiral order.
    ///
    /// The matrix should be filled with natural numbers, starting from 1
    /// in the top-left corner, increasing in an inward, clockwise spiral order,
    /// like these examples:
    ///
    ///  Spiral matrix of size 3
    ///      1 2 3
    ///      8 9 4
    ///      7 6 5
    ///
    /// Spiral matrix of size 4
    ///     1  2  3  4
    ///     12 13 14 5
    ///     11 16 15 6
    ///     10  9  8 7
    ///
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SpiralMatrix Spiral = new SpiralMatrix();
            Spiral.GetMatrix(3);
        }
    }

    internal class SpiralMatrix
    {
        private int Length, Steps, Row, Col, CurrentNumber, Edge;
        private int[,] Board, NumberMatrix;

        private Point Position = new Point(0, 0);

        public int[,] GetMatrix(int size)
        {
            ///keep track of the cursor placement on the screen
            Edge = size;
            Length = size * size;
            Steps = 1;
            Row = 0;
            Col = 0;
            Position = new Point(Row, Col);
            CurrentNumber = Steps;

            NumberMatrix = new int[size, size];
            NumberMatrix[Row, Col] = CurrentNumber;

            if (size <= 0)
            {
                return NumberMatrix;
            }

            if (Steps < Length)
            {
                TakeStep();
            }

            return NumberMatrix;
        }


        private void TakeStep()
        {
           
            Console.WriteLine($"CurrentStep = {Steps} Position = {Position.Row},{Position.Column}");
            if (Col < Edge)
            {
                Console.WriteLine($"Col {Col}");
                Col = Col +1;
                Position.Column = Col;
                NumberMatrix[Row, Col] = CurrentNumber;

                Console.WriteLine($"Col {Col}");
            }
           if(Col == Edge)
            {
                Row++;
            }
            Steps++;

            Console.WriteLine($"CurrentStep = {Steps} Position = {Position.Row},{Position.Column}");
            Console.WriteLine(NumberMatrix);
        }


    /// TODO: border checks
  
    }
}

public class Point
{
    public int Row { get; set; }
    public int Column { get; set; }

    public Point(int x, int y)
    {
        Row = x;
        Column = y;
    }
}