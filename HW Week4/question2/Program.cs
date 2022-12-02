 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool finish = false;
            var myLeague = new League();
            
            while (!finish)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                if (command.Length == 0) continue;
                
                if (command[0] == "new")
                {
                    if (command[1] == "player")
                    {
                        //var player = new Player(command[2], int.Parse(command[3]), int.Parse(command[4]),
                        //    int.Parse(command[5]), int.Parse(command[6]));
                        myLeague.AddPlayer(command);
                    }
                    else if (command[1] == "team")
                    {
                        //var team = new Team(command[2], int.Parse(command[3]));
                        myLeague.AddTeam(command);
                    }
                }
                else if (command[0] == "buy")
                {
                    myLeague.Buy(int.Parse(command[1]), int.Parse(command[2]));
                }
                else if (command[0] == "sell")
                {
                    myLeague.Sell(int.Parse(command[1]), int.Parse(command[2]));
                }
                else if (command[0] == "match")
                {
                    myLeague.Match(int.Parse(command[1]), int.Parse(command[2]));
                }
                else if (command[0] == "rank")
                {
                    myLeague.Rank();
                }
                else if (command[0] == "end")
                {
                    finish = true;
                }
            }
        }
    }
    class League
    {
        public static List<Team> Teams { get; set; }
        public static List<Player> Players { get; set; }

        public League()
        {
            Teams = new List<Team>();
            Players = new List<Player>();
        }
        public void Buy(int playerID, int teamID)
        {
            bool hasPlayerID = false;
            bool hasTeamID = false;
            Team team = null;
            Player player = null;

            for (int i = 0; i < Players.Count; i++)
            {
                if (Players[i].ID == playerID)
                {
                    hasPlayerID = true;
                    player = Players[i];
                    break;
                }
            }
            for (int i = 0; i < Teams.Count; i++)
            {
                if (Teams[i].ID == teamID)
                {
                    hasTeamID = true;
                    team = Teams[i];
                    break;
                }
            }
            
            if (!hasPlayerID)
            {
                Console.WriteLine("player with the id playerID doesnt exist");
            }
            else if (!hasTeamID)
            {
                Console.WriteLine("team with the id teamID doesnt exist");
            }
            else if (team.Money < player.Price)
            {
                Console.WriteLine("the team cant afford to buy this player");
            }
            else if (player.Team != null)
            {
                Console.WriteLine("player already has a team");
            }
            else
            {
                team.Money -= player.Price;
                team.Players.Add(player);
                player.Team = team;
                Console.WriteLine("player added to the team succesfully");
            }
        }
        public void Sell(int playerID, int teamID)
        {
            bool hasTeamID = false;
            bool hasPlayerID = false;
            Team team = null;
            Player player = null;

            for (int i = 0; i < Teams.Count; i++)
            {
                if (Teams[i].ID == teamID)
                {
                    hasTeamID = true;
                    team = Teams[i];
                    break;
                }
            }
            for (int i = 0; i < team.Players.Count; i++)
            {
                if (team.Players[i].ID == playerID)
                {
                    hasPlayerID = true;
                    player = team.Players[i];
                    break;
                }
            }
            
            if (!hasTeamID)
            {
                Console.WriteLine("team doesnt exist");
            }
            else if (!hasPlayerID)
            {
                Console.WriteLine("team doesnt have this player");
            }
            else
            {
                team.Money += player.Price;
                team.Players.Remove(player);
                player.Team = null;
                Console.WriteLine("player sold succesfully");
            }
        }
        public void Match(int teamID1, int teamID2)
        {
            Team team1 = null;
            Team team2 = null;
            bool hasTeamID1 = false;
            bool hasTeamID2 = false;

            for (int i = 0; i < Teams.Count; i++)
            {
                if (Teams[i].ID == teamID1)
                {
                    team1 = Teams[i];
                    hasTeamID1 = true;
                }
                else if (Teams[i].ID == teamID2)
                {
                    team2 = Teams[i];
                    hasTeamID2 = true;
                }
            }
            if (!hasTeamID1 || !hasTeamID2)
            {
                Console.WriteLine("team doesnt exist");
            }
            else if (team1.Players.Count + team2.Players.Count < 22)
            {
                Console.WriteLine("the game can not be held due to loss of the players");
            }
            else
            {
                RunMatch(team1, team2);
            }
        }
        private void RunMatch(Team team1, Team team2)
        {
            int team1Score = 0;
            int team2Score = 0;
            for (int i = 0; i < team1.Players.Count; i++)
            {
                team1Score += team1.Players[i].Speed;
                team1Score += team1.Players[i].Finishing;
            }
            for (int i = 0; i < team2.Players.Count; i++)
            {
                team2Score += team2.Players[i].Speed;
                team2Score += team2.Players[i].Defence;
            }
            if (team1Score > team2Score)
            {
                team1.Money += 1000;
                team1.Win++;
                team2.Lose++;
            }
            else if (team2Score > team1Score)
            {
                team2.Money += 1000;
                team2.Win++;
                team1.Lose++;
            }
            else
            {
                team1.Draw++;
                team2.Draw++;
            }
        }
        public void Rank()
        {
            int rank = 1;
            List<Team> orderedTeams = Teams.OrderByDescending(x => x.Win).OrderBy(x => x.Draw).ThenByDescending(x => x.Draw).ToList();
            for (int i = 0; i < orderedTeams.Count; i++)
            {
                Console.WriteLine($"{rank}. {orderedTeams[i].Name}");
                rank++;
            }
        }
        public void AddTeam(string[] command)
        {
            foreach (var team in Teams)
            {
                if (team.Name == command[2])
                {
                    //Console.WriteLine("Team already exists");
                    return;
                }
            }
            Teams.Add(new Team(command[2], int.Parse(command[3])));
        }
        public void AddPlayer(string[] command)
        {
            var player = new Player(command[2], int.Parse(command[3]), int.Parse(command[4]),
                            int.Parse(command[5]), int.Parse(command[6]));
            Players.Add(player);
        }
    }


    class Player
    {
        static int PlayersId = 0;
        public string Name { get; set; }
        public int Price { get; set; }
        public int Speed { get; set; }
        public int Finishing { get; set; }
        public int Defence { get; set; }
        public int ID { get; set; }
        public Team Team { get; set; }

        public Player(string name, int price, int speed, int finishing, int defence)
        {
            PlayersId++;
            Name = name;
            Price = price;
            Speed = speed;
            Finishing = finishing;
            Defence = defence;
            Team = null;
            ID = PlayersId;
        }

    }

    class Team
    {
        static int TeamsId = 0;
        public string Name { get; set; }
        public int Money { get; set; }
        public int ID { get; set; }
        public int Win { get; set; }
        public int Lose { get; set; }
        public int Draw { get; set; }
        public List<Player> Players { get; set; }

        public Team(string name, int money)
        {
            TeamsId++;
            Name = name;
            Money = money;
            ID = TeamsId;
            Draw = 0;
            Win = 0;
            Lose = 0;
            Players = new List<Player>();
        }
    }
}



