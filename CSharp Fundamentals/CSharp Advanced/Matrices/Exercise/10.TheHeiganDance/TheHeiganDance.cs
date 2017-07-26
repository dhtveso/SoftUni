using System;

namespace _10.TheHeiganDance
{
    public class TheHeiganDance
    {
        private const int ChamberSize = 15;
        private const int CloudDamage = 3500;
        private const int EruptionDamage = 6000;
        private const double PlayerHealt = 18500;
        private const double HeiganHealt = 3000000;

        public static void Main()
        {
            var playerPosition = new int[] { ChamberSize / 2, ChamberSize / 2 };
            var heiganPoints = HeiganHealt;
            var playerPoints = PlayerHealt;
            var isHeiganDead = false;
            var isPlayerDead = false;
            var hasCloud = false;
            var deathCause = "";
            var damageToHeigan = double.Parse(Console.ReadLine());

            while (true)
            {
                var spellTokens = Console.ReadLine()
                    .Split();
                var spell = spellTokens[0];
                var spellRow = int.Parse(spellTokens[1]);
                var spellCol = int.Parse(spellTokens[2]);
                heiganPoints -= damageToHeigan;
                isHeiganDead = heiganPoints <= 0;

                if (hasCloud)
                {
                    playerPoints -= CloudDamage;
                    hasCloud = false;
                    isPlayerDead = playerPoints <= 0;
                }
                if (isHeiganDead || isPlayerDead)
                {
                    break;
                }
                if (IsPlayerInDamagedZone(playerPosition, spellRow, spellCol))
                {
                    if (!PlayerTryEscape(playerPosition, spellCol, spellRow))
                    {
                        switch (spell)
                        {
                            case "Cloud":
                                playerPoints -= CloudDamage;
                                hasCloud = true;
                                deathCause = "Plague Cloud";
                                break;

                            case "Eruption":
                                playerPoints -= EruptionDamage;
                                deathCause = spell;
                                break;

                            default:
                                break;
                        }
                    }
                }

                isPlayerDead = playerPoints <= 0;

                if (isPlayerDead)
                {
                    break;
                }
            }

            PrintResult(playerPosition, heiganPoints, playerPoints, deathCause);
        }

        private static void PrintResult(int[] playerPosition, double heiganPoints, double playerPoints, string deathCause)
        {
            if (heiganPoints <= 0)
            {
                Console.WriteLine("Heigan: Defeated!");
            }
            else
            {
                Console.WriteLine($"Heigan: {heiganPoints:f2}");
            }

            if (playerPoints <= 0)
            {
                Console.WriteLine($"Player: Killed by {deathCause}");
            }
            else
            {
                Console.WriteLine($"Player: {playerPoints}");
            }
            Console.WriteLine($"Final position: {playerPosition[0]}, {playerPosition[1]}");
        }

        private static bool PlayerTryEscape(int[] playerPosition, int spellCol, int spellRow)
        {
            if (playerPosition[0] - 1 >= 0 && playerPosition[0] - 1 < spellRow - 1)
            {
                playerPosition[0]--;
                return true;
            }
            else if (playerPosition[1] + 1 < ChamberSize && playerPosition[1] + 1 > spellCol + 1)
            {
                playerPosition[1]++;
                return true;
            }
            else if (playerPosition[0] + 1 < ChamberSize && playerPosition[0] + 1 > spellRow + 1)
            {
                playerPosition[0]++;
                return true;
            }
            else if (playerPosition[1] - 1 >= 0 && playerPosition[1] - 1 < spellCol - 1)
            {
                playerPosition[1]--;
                return true;
            }
            return false;
        }

        private static bool IsPlayerInDamagedZone(int[] playerPosition, int spellRow, int spellCol)
        {
            bool isHitRow = playerPosition[0] >= spellRow - 1 && playerPosition[0] <= spellRow + 1;
            bool isHitCol = playerPosition[1] >= spellCol - 1 && playerPosition[1] <= spellCol + 1;

            return isHitRow && isHitCol;
        }
    }
}