using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace PhaseEnd_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
        mar:
            Console.WriteLine("1.Add by Playername 2.Remove by PlayerID 3.Get Player by ID 4.Get Player by Name 5.Get All Players");
            int m = Convert.ToInt32(Console.ReadLine());
            switch (m)
            {
                case 1:
                there:
                    OnedayTeam p = new OnedayTeam();
                    if (OnedayTeam.Oneday.Count != OnedayTeam.Oneday.Capacity)
                    {
                        Console.Write("Enter Player Id:");
                        p.PlayerId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Player Name:");
                        p.PlayerName = Console.ReadLine();
                        Console.Write("Enter Player Age:");
                        p.PlayerAge = Convert.ToInt32(Console.ReadLine());

                        p.Add(p);
                    }
                    else
                    {
                        Console.WriteLine("Capacity is full");
                        goto mar;
                    }



                    Console.WriteLine("Do you want to continue?.Press yes");
                    string h = Console.ReadLine();
                    if (h == "yes")
                    {
                        goto there;
                    }
                    break;
                case 2:
                    OnedayTeam s = new OnedayTeam();
                    Console.Write("Enter Player Id to remove:");
                    int k = Convert.ToInt32(Console.ReadLine());
                    s.Remove(k);
                    break;
                case 3:
                    OnedayTeam sp = new OnedayTeam();
                    Console.Write("Enter Player Id to search:");
                    int ki = Convert.ToInt32(Console.ReadLine());
                    Player P = sp.GetPlayerById(ki);
                    Console.WriteLine($"{P.PlayerId} {P.PlayerName} {P.PlayerAge}");
                    break;
                case 4:
                    OnedayTeam si = new OnedayTeam();
                    Console.Write("Enter Player Name to search:");
                    string ik = Console.ReadLine();
                    Player Pi = si.GetPlayerByName(ik);
                    Console.WriteLine($"{Pi.PlayerId} {Pi.PlayerName} {Pi.PlayerAge}");
                    break;
                case 5:
                    Console.WriteLine("List all players");
                    List<Player> sm = new List<Player>();
                    OnedayTeam koi = new OnedayTeam();
                    sm = koi.GetAllPlayers();
                    foreach (var item in sm)
                    {
                        Console.WriteLine($"{item.PlayerId} {item.PlayerName} {item.PlayerAge}");
                    }
                    break;


            }
            Console.WriteLine("Do you want to go to start? Enter yes");
            string ji = Console.ReadLine();
            if (ji == "yes")
            {
                goto mar;
            }
            Console.ReadLine();
        }
    }
}
