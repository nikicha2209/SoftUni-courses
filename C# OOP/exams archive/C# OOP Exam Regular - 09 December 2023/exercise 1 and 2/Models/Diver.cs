using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NauticalCatchChallenge.Models.Contracts;
using NauticalCatchChallenge.Utilities.Messages;

namespace NauticalCatchChallenge.Models
{
    public abstract class Diver : IDiver
    {
        private string name;
        private int oxygenLevel;
        private List<string> caughtFish;
        private double competitionPoints;
        private bool hasHealthIssues;

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(ExceptionMessages.DiversNameNull);
                }
                name = value;
            }
        }

        public int OxygenLevel
        {
            get => oxygenLevel;
            protected set
            {
                if (value < 0)
                {
                    hasHealthIssues = true;
                    oxygenLevel = 0;
                }
                else
                {
                    oxygenLevel = value;
                }
            }
        }

        public IReadOnlyCollection<string> Catch
        {
            get => caughtFish.AsReadOnly();
        }

        public double CompetitionPoints
        {
            get => competitionPoints;
        }

        public bool HasHealthIssues
        {
            get => hasHealthIssues;
            private set => hasHealthIssues = value;
        }

        public void Hit(IFish fish)
        {
            OxygenLevel -= fish.TimeToCatch;
            caughtFish.Add(fish.Name);
            competitionPoints = Math.Round(fish.Points + competitionPoints, 1);
            if (OxygenLevel <= 0)
            {
                HasHealthIssues = true;
            }
        }

        public abstract void Miss(int timeToCatch);
        public abstract void RenewOxy();

        public void UpdateHealthStatus()
        {
            HasHealthIssues = !HasHealthIssues;
        }

        public override string ToString()
        {
            return
                $"Diver [ Name: {Name}, Oxygen left: {OxygenLevel}, Fish caught: {caughtFish.Count}, Points earned: {CompetitionPoints} ]";
        }

        public Diver(string name, int oxygenLevel)
        {
            Name = name;
            OxygenLevel = oxygenLevel;
            caughtFish = new List<string>();
        }
    }
}
