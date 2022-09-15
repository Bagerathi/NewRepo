using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaseEnd_project
{
    public interface ITeam
    {
        void Add(Player player);
        void Remove(int playerid);
        Player GetPlayerById(int playerid);
        Player GetPlayerByName(string playername);
        List<Player> GetAllPlayers();
    }
    public class Player
    {
        private int _playerid;
        private string _playername;
        private int _playerage;
        public int PlayerId
        {
            get { return _playerid; }
            set { _playerid = value; }
        }
        public string PlayerName
        {
            get { return _playername; }
            set { _playername = value; }
        }
        public int PlayerAge
        {
            get { return _playerage; }
            set { _playerage = value; }
        }
    }
    public class OnedayTeam : Player, ITeam
    {
        public static List<Player> Oneday = new List<Player>();
        public OnedayTeam()
        {
            Oneday.Capacity = 11;


        }
        public void Add(Player player)
        {
            Oneday.Add(player);
        }

        public List<Player> GetAllPlayers()
        {
            return Oneday;
        }

        public Player GetPlayerById(int playerid)
        {
            Player player = null;

            foreach (var item in Oneday)
            {
                if (item.PlayerId == playerid)
                {
                    player = item;

                    break;
                }
            }
            return player;

        }

        public Player GetPlayerByName(string playername)
        {
            Player player = null;

            foreach (var item in Oneday)
            {
                if (item.PlayerName == playername)
                {
                    player = item;

                    break;
                }
            }
            return player;


        }

        public void Remove(int playerid)
        {
            Player player = null;

            foreach (var item in Oneday)
            {
                if (item.PlayerId == playerid)
                {
                    Console.WriteLine("Player Removed successfully");
                    player = item;
                }
            }
            Oneday.Remove(player);
        }
    }
}
