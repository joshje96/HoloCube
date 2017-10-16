﻿using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
//            Solve();
            Translator t = new Translator();
            var cube = t.setSides();

            cube.RotateX(false);

            while (cube.FaceColor(CubeSide.Front) != CubeColor.Orange)
            {
                cube.RotateY(false);
            }
            
            
//            cube.ExecuteMove(new Move(CubeAction.U,CubeColor.White,CubeColor.Blue));
//            cube.ExecuteMove(new Move(CubeAction.F,CubeColor.White,CubeColor.Blue));
            Console.WriteLine(cube.ToString());


        }

        private static void Solve()
        {
            RubikCube cube = new RubikCube();
           
            cube.Scramble();
            List<Move> moves = Solver.Solve(cube);
            Console.WriteLine(cube);
            Console.WriteLine("\nTotal number of moves: " + moves.Count + "\n");
            foreach(Move move in moves)
            {
                Console.WriteLine(move);
            }
            Console.ReadKey();
        }
        
    }
}
