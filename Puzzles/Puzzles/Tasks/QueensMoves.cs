using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    class QueensMoves
    {
        static void QueensMain(string[] args)
        {
            int n = 4;  // Chessboard size
            int k = 1;  // Number of obstacles
            int Qposx = 1; // Queen x position
            int Qposy = 1; // Queen y position
            //int obstPosx[] = { 3 };  // x position of obstacles
            //int obstPosy[] = { 5 };  // y position of obstacles
            int finalans = 0;
            //finalans = numberofPosition(n, k, Qposx, Qposy, obstPosx, obstPosy);
            finalans = numberofPosition(n, k, Qposx, Qposy);
            finalans = (n * n) - finalans;
            Console.WriteLine(finalans);
        }

        // Return the number of position a Queen can move.
        public static int numberofPosition(int n, int k, int x, int y)
        {
            //int x1, y1;
            int ans = 0;
            //map<pair<int, int>, int> mp;

            // Mapping each obstacle's position
            //while (k--)
            //{
            //    x1 = obstPosx[k];
            //    y1 = obstPosy[k];

            //    mp[{ x1, y1}] = 1;
            //}

            // Fetching number of position a queen can
            // move in each direction.
            ans += check(n, x + 1, y, 1, 0);
            ans += check(n, x - 1, y, -1, 0);
            ans += check(n, x, y + 1, 0, 1);
            ans += check(n, x, y - 1, 0, -1);
            ans += check(n, x + 1, y + 1, 1, 1);
            ans += check(n, x + 1, y - 1, 1, -1);
            ans += check(n, x - 1, y + 1, -1, 1);
            ans += check(n, x - 1, y - 1, -1, -1);

            return ans;
        }

        // Return if position is valid on chessboard
        public static bool range(int n, int x, int y)
        {
            return (x <= n && x > 0 && y <= n && y > 0);
        }

        // Return the number of moves with a given direction
        public static int check(int n, int x, int y, int xx, int yy)
        {
            int ans = 0;

            // Checking valid move of Queen in a direction.
            while (range(n, x, y))
            {
                x += xx;
                y += yy;
                ans++;
            }

            return ans;
        }
    }
 }
