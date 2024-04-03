using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NauticalCatchChallenge.Core.Contracts;
using NauticalCatchChallenge.Models;
using NauticalCatchChallenge.Models.Contracts;
using NauticalCatchChallenge.Repositories;
using NauticalCatchChallenge.Utilities.Messages;

namespace NauticalCatchChallenge.Core
{
    public class Controller : IController
    {
        private DiverRepository divers;
        private FishRepository fish;

        public Controller()
        {
            divers = new DiverRepository();
            fish = new FishRepository();

        }

        public string DiveIntoCompetition(string diverType, string diverName)
        {
            if (diverType != "FreeDiver" && diverType != "ScubaDiver")
            {
                return string.Format(OutputMessages.DiverTypeNotPresented, diverType);
            }

            if (divers.GetModel(diverName) != null)
            {
                return string.Format(OutputMessages.DiverNameDuplication, diverName, typeof(DiverRepository).Name);
            }


            if (diverType == typeof(ScubaDiver).Name)
            {
                IDiver diver = new ScubaDiver(diverName);
                divers.AddModel(diver);
            }

            if (diverType == typeof(FreeDiver).Name)
            {
                IDiver diver = new FreeDiver(diverName);
                divers.AddModel(diver);
            }

            return $"{diverName} is successfully registered for the competition -> {typeof(DiverRepository).Name}.";
        }

        public string SwimIntoCompetition(string fishType, string fishName, double points)
        {
            if (fishType != "ReefFish" && fishType != "DeepSeaFish" && fishType != "PredatoryFish")
            {
                return string.Format(OutputMessages.FishTypeNotPresented, fishType);
            }

            if (fish.GetModel(fishName) != null)
            {
                return string.Format(OutputMessages.FishNameDuplication, fishName, typeof(FishRepository).Name);
            }

            IFish fishParticipant = null;
            if (fishType == typeof(ReefFish).Name)
            {
                fishParticipant = new ReefFish(fishName, points);
            }

            if (fishType == typeof(DeepSeaFish).Name)
            {
                fishParticipant = new DeepSeaFish(fishName, points);
            }

            if (fishType == typeof(PredatoryFish).Name)
            {
                fishParticipant = new PredatoryFish(fishName, points);
            }

            fish.AddModel(fishParticipant);
            return $"{fishName} is allowed for chasing.";
        }

        public string ChaseFish(string diverName, string fishName, bool isLucky)
        {
            IDiver currentDiver = divers.GetModel(diverName);
            IFish currentFish = fish.GetModel(fishName);

            if (currentDiver == null)
            {
                return string.Format(OutputMessages.DiverNotFound, typeof(DiverRepository).Name, diverName);
            }

            if (currentFish == null)
            {
                return string.Format(OutputMessages.FishNotAllowed, fishName);
            }

            if (currentDiver.HasHealthIssues)
            {
                return string.Format(OutputMessages.DiverHealthCheck, diverName);
            }

            if (currentDiver.OxygenLevel < currentFish.TimeToCatch)
            {
                currentDiver.Miss(currentFish.TimeToCatch);
                return string.Format(OutputMessages.DiverMisses, diverName, fishName);
            }


            if (currentDiver.OxygenLevel == currentFish.TimeToCatch)
            {
                if (isLucky)
                {
                    currentDiver.Hit(currentFish);
                    return string.Format(OutputMessages.DiverHitsFish, diverName, currentFish.Points, fishName);
                }

                currentDiver.Miss(currentFish.TimeToCatch);
                return string.Format(OutputMessages.DiverMisses, diverName, fishName);
            }


            currentDiver.Hit(currentFish);
            return string.Format(OutputMessages.DiverHitsFish, diverName, currentFish.Points, fishName);
        }

        public string HealthRecovery()
        {
            List<IDiver> diversForRecovery = divers.Models.Where(d => d.HasHealthIssues).ToList();

            foreach (var diver in diversForRecovery)
            {
                diver.UpdateHealthStatus();
                diver.RenewOxy();
            }

            return string.Format(OutputMessages.DiversRecovered, diversForRecovery.Count);
        }

        public string DiverCatchReport(string diverName)
        {
            IDiver currentDiver = divers.GetModel(diverName);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(
                $"Diver [ Name: {currentDiver.Name}, Oxygen left: {currentDiver.OxygenLevel}, Fish caught: {currentDiver.Catch.Count}, Points earned: {currentDiver.CompetitionPoints} ]");

            sb.AppendLine("Catch Report:");

            foreach (var fishName in currentDiver.Catch)
            {
                var currentFish = fish.Models.First(f => f.Name == fishName);
                sb.AppendLine($"{currentFish.GetType().Name}: {currentFish.Name} [ Points: {currentFish.Points}, Time to Catch: {currentFish.TimeToCatch} seconds ]");
            }

            return sb.ToString().TrimEnd();
        }

        public string CompetitionStatistics()
        {
            List<IDiver> statisticsDivers = divers.Models
                .Where(d => !d.HasHealthIssues)
                .OrderByDescending(d => d.CompetitionPoints)
                .ThenByDescending(d => d.Catch.Count)
                .ThenBy(d => d.Name)
                .ToList();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("**Nautical-Catch-Challenge**");

            foreach (var d in statisticsDivers)
            {
                sb.AppendLine(d.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
