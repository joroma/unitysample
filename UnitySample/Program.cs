using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitySample;

namespace UnitySample
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public interface IGame
    {
        string Name { get;}
        int CurrentPlayers { get; }
        int MinPlayers { get; }
        int MaxPlayers { get; }

        void AddPlayer();
        void RemovePlayer();
        void play();
        string result();

    }

    public class TrivialPursuit : IGame
    {
        private string _status;

        public TrivialPursuit()
        {
            Name = "Trivial Pursuit";
            CurrentPlayers = 0;
            MinPlayers = 2;
            MaxPlayers = 8;
            _status = "No active games";
        }

        #region IGame Members
        public string Name { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public int CurrentPlayers { get; set; }

        public void AddPlayer()
        {
            CurrentPlayers++;
        }

        public void RemovePlayer()
        {
            CurrentPlayers--;
        }

        public void play()
        {
            if ((CurrentPlayers > MaxPlayers) || (CurrentPlayers < MinPlayers))
                _status = string.Format("{0}: It's not possible to play with {1} players", Name, CurrentPlayers);
            else
                _status = string.Format("{0}: Playing with {1} players", Name, CurrentPlayers);

        }

        public string result()
        {
            return _status;
        }
        #endregion
        
    }

    public class TicTacToe : IGame
    {
        private string _status;

        public TicTacToe()
        {
            Name = "Tic Tac Toe";
            CurrentPlayers = 0;
            MinPlayers = 2;
            MaxPlayers = 2;
            _status = "No Active game";
        }

        #region IGame Members
        public string Name { get; set; }
        public int CurrentPlayers { get; set; }

        
        public int MaxPlayers { get; set;}

        public int MinPlayers { get; set; }

        

        public void AddPlayer()
        {
            CurrentPlayers++;
        }

        public void play()
        {
            if ((CurrentPlayers > MaxPlayers) || (CurrentPlayers < MinPlayers))
                _status = string.Format("{0}: It's not possible to play with {1} players", Name, CurrentPlayers);
            else
                _status = string.Format("{0}: Playing with {1} players", Name, CurrentPlayers);

        }

        public void RemovePlayer()
        {
            CurrentPlayers--;
        }

        public string result()
        {
            return _status;
        }

        #endregion
    }

}

