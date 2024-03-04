using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersAndMonsters
{
    public class Hero
    {
        private string username;
        private int level;

        public string Username { get { return username; } set { username = value; } }
        public int Level { get { return level; } set { level = value; } }

        public Hero(string username, int level)
        {
            this.username = username;
            this.level = level;
        }

        public override string ToString()
            => $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
    }
}
