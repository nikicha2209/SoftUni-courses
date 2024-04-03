using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighwayToPeak.Models.Contracts;
using HighwayToPeak.Utilities.Messages;

namespace HighwayToPeak.Models
{
    public abstract class Climber : IClimber
    {
        private string name;
        private int stamina;
        private List<string> conqueredPeaks;

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.ClimberNameNullOrWhiteSpace);
                }
                name = value;
            }
        }

        public int Stamina
        {
            get => stamina;
            protected set
            {
                if (value > 10)
                {
                    stamina = 10;
                }

                else if (value < 0)
                {
                    stamina = 0;
                }

                else
                {
                    stamina = value;
                }
            }
        }

        public IReadOnlyCollection<string> ConqueredPeaks
        {
            get => conqueredPeaks.AsReadOnly();
        }

        protected Climber(string name, int stamina)
        {
            Name = name;
            Stamina = stamina;
            conqueredPeaks = new List<string>();
        }

        public void Climb(IPeak peak)
        {
            if (!conqueredPeaks.Contains(peak.Name))
            {
                conqueredPeaks.Add(peak.Name);
            }

            switch (peak.DifficultyLevel)
            {
                case "Moderate":
                    Stamina -= 2;
                    break;

                case "Hard":
                    Stamina -= 4;
                    break;

                case "Extreme":
                    Stamina -= 6;
                    break;
            }
        }

        public abstract void Rest(int daysCount);

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{GetType().Name} - Name: {Name}, Stamina: {Stamina}");

            if (conqueredPeaks.Count > 0)
            {
                sb.AppendLine($"Peaks conquered: {ConqueredPeaks.Count}");
                return sb.ToString().TrimEnd();
            }

            sb.AppendLine($"Peaks conquered: no peaks conquered");
            return sb.ToString().TrimEnd();
        }
    }
}
