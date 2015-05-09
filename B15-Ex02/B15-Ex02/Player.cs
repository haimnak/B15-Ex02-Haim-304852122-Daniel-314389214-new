using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B15_Ex02
{
    public class Player
    {
        private string m_playerName;
        private int m_points;

        public Player(string io_PlayerName, string playerType)
        {
            this.m_playerName = io_PlayerName;
            this.m_points = 0;
        }

        public int Points
        {
            get { return m_points; }
            set { m_points = value; }
        }

        public string PlayerName
        {
            get { return this.m_playerName; }
        }

        /*
         * TODO: Asks for move from the user and commits
         */
        public static void Move(string playerType)
        {
            // get valid moves

            // If human
            UI.ScanPlayerMove();


            // else if pc create random move
        }
    }
}
