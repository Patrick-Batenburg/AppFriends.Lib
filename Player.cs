using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFriends
{
    public class Player
    {
        private string name;
        private int life;
        private int money;
        Random randomizer = new Random();

        /// <summary>
        /// Represents a player object.
        /// </summary>
        public Player()
        {
            this.life = 100;
            this.money = 0;
        }

        /// <summary>
        /// Returns objects values interacting with current player and hit a player for a set amount or for a random amount of lifes.
        /// </summary>
        /// <param name="target">Taget player to hit.</param>
        /// <param name="amount">Amount lifes to substract, if left null a random amount is used.</param>
        /// <param name="print">Whenever to print message to console, default is false.</param>
        /// <returns>Returns objects values interacting with current player.</returns>
        public string[] Hit(Player target, int? amount = null, bool print = false)
        {
            int damage;
            string message;
            string[] objects = new string[4];

            if (amount != null)
            {
                damage = (int)amount;
            }
            else
            {
                damage = randomizer.Next(1, 10);
            }

            target.Life -= damage;

            if (target.Life < 0)
            {
                target.Life = 0;
            }

            message = String.Format("{0} just hitted {1} for {2} life(s)\n{3} has {4} lifes\n", this.Name, target.Name, damage.ToString(), target.Name, target.Life);
            objects[0] = this.Name;
            objects[1] = target.Name;
            objects[2] = target.Life.ToString();
            objects[3] = damage.ToString();

            switch (print)
            {
                case true:
                    Console.WriteLine(message);
                    break;
                default:
                    return objects;
            }

            return objects;
        }

        /// <summary>
        /// Returns objects values interacting with current player and give a set amount or a random amount of lifes to a player.
        /// </summary>
        /// <param name="target">Taget player to give lifes to.</param>
        /// <param name="amount">Amount lifes to add, if left null a random amount is used.</param>
        /// <param name="print">Whenever to print message to console, default is false.</param>
        /// <returns>Returns objects values interacting with current player.</returns>
        public string[] GiveLife(Player target, int? amount = null, bool print = false)
        {
            int life;
            string message;
            string[] objects = new string[4];

            if (amount != null)
            {
                life = (int)amount;
            }
            else
            {
                life = randomizer.Next(1, 10);
            }

            target.Life += life;
            message = String.Format("{0} gave {1} {2} life(s)\n{3} has {4} lifes\n", this.Name, target.Name, life, target.Name, target.Life);
            objects[0] = this.Name;
            objects[1] = target.Name;
            objects[2] = target.Life.ToString();
            objects[3] = life.ToString();

            switch (print)
            {
                case true:
                    Console.WriteLine(message);
                    break;
                default:
                    return objects;
            }

            return objects;
        }

        /// <summary>
        /// Returns objects values interacting with current player and gives a set amount or a random amount of money.
        /// </summary>
        /// <param name="amount">Amount of money to add, if left null a random amount is used.</param>
        /// <param name="print">Whenever to print message to console, default is false.</param>
        /// <returns>Returns objects values interacting with current player.</returns>
        public string[] GetMoney(int? amount = null, bool print = false)
        {
            int money;
            string message;
            string[] objects = new string[4];

            if (amount != null)
            {
                money = (int)amount;
            }
            else
            {
                money = randomizer.Next(1, 10);
            }

            this.Money += money;
            message = String.Format("{0} has gotten {1} amount of money.\n", this.Name, money.ToString());
            objects[0] = this.Name;
            objects[1] = money.ToString();

            switch (print)
            {
                case true:
                    Console.WriteLine(message);
                    break;
                default:
                    return objects;
            }

            return objects;
        }

        /// <summary>
        /// Name of current player to get or set.
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                switch (String.IsNullOrEmpty(this.name))
                {
                    case false:
                        throw new InvalidOperationException("Value already set.");
                    case true:
                        this.name = value;
                        break;
                    default:
                        throw new InvalidOperationException("Unexpected exception.");
                }         
            }
        }

        /// <summary>
        /// Life of current player to get or set.
        /// </summary>
        public int Life
        {
            get
            {
                return this.life;
            }
            private set
            {
                this.life = value;
            }
        }

        /// <summary>
        /// Money of current player to get or set.
        /// </summary>
        public int Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                this.money = value;
            }
        }
    }
}