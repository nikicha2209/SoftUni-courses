using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using HighwayToPeak.Models;
using HighwayToPeak.Models.Contracts;
using HighwayToPeak.Repositories;
using HighwayToPeak.Utilities.Messages;

namespace HighwayToPeak.Core.Contracts
{
    public class Controller : IController
    {
        private PeakRepository peaks;
        private ClimberRepository climbers;
        private BaseCamp baseCamp;

        public Controller()
        {
            peaks = new PeakRepository();
            climbers = new ClimberRepository();
            baseCamp = new BaseCamp();
        }

        public string AddPeak(string name, int elevation, string difficultyLevel)
        {
            IPeak currentPeak = peaks.All.FirstOrDefault(p => p.Name == name);

            if (currentPeak != null)
            {
                return string.Format(OutputMessages.PeakAlreadyAdded, name);
            }

            if (difficultyLevel != "Extreme" && difficultyLevel != "Hard" && difficultyLevel != "Moderate")
            {
                return string.Format(OutputMessages.PeakDiffucultyLevelInvalid, difficultyLevel);
            }

            peaks.Add(new Peak(name, elevation, difficultyLevel));
            return string.Format(OutputMessages.PeakIsAllowed, name, peaks.GetType().Name);
        }

        public string NewClimberAtCamp(string name, bool isOxygenUsed)
        {
            IClimber currentClimber = climbers.All.FirstOrDefault(c => c.Name == name);

            if (currentClimber != null)
            {
                return string.Format(OutputMessages.ClimberCannotBeDuplicated, name, climbers.GetType().Name);
            }

            if (isOxygenUsed)
            {
                currentClimber = new OxygenClimber(name);
            }

            else
            {
                currentClimber = new NaturalClimber(name);
            }

            climbers.Add(currentClimber);
            baseCamp.ArriveAtCamp(name);
            //there is an error with the output message here!!
            return $"{currentClimber.Name} has arrived at the BaseCamp and will wait for the best conditions.";
        }

        public string AttackPeak(string climberName, string peakName)
        {

            if (climbers.All.FirstOrDefault(c => c.Name == climberName) == null)
            {
                return string.Format(OutputMessages.ClimberNotArrivedYet, climberName);
            }

            if (peaks.All.FirstOrDefault(p => p.Name == peakName) == null)
            {
                return string.Format(OutputMessages.PeakIsNotAllowed, peakName);
            }


            if (baseCamp.Residents.FirstOrDefault(c => c == climberName) == null)
            {
                return string.Format(OutputMessages.ClimberNotFoundForInstructions, climberName, peakName);
            }

            IClimber currentClimber = climbers.All.FirstOrDefault(c => c.Name == climberName);
            IPeak currentPeak = peaks.All.FirstOrDefault(p => p.Name == peakName);

            if (currentPeak.DifficultyLevel == "Extreme" && currentClimber is NaturalClimber)
            {
                return string.Format(OutputMessages.NotCorrespondingDifficultyLevel, climberName, peakName);
            }

            baseCamp.LeaveCamp(climberName);
            currentClimber.Climb(currentPeak);

            if (currentClimber.Stamina == 0)
            {
                return string.Format(OutputMessages.NotSuccessfullAttack, climberName);
            }


            baseCamp.ArriveAtCamp(climberName);
            return string.Format(OutputMessages.SuccessfulAttack, climberName, peakName);

        }

        public string CampRecovery(string climberName, int daysToRecover)
        {
            if (baseCamp.Residents.FirstOrDefault(c => c == climberName) == null)
            {
                return string.Format(OutputMessages.ClimberIsNotAtBaseCamp, climberName);
            }

            IClimber currentClimber = climbers.All.FirstOrDefault(c => c.Name == climberName);

            if (currentClimber.Stamina == 10)
            {
                return string.Format(OutputMessages.NoNeedOfRecovery, climberName);
            }

            currentClimber.Rest(daysToRecover);
            return string.Format(OutputMessages.ClimberRecovered, climberName, daysToRecover);
        }

        public string BaseCampReport()
        {
            if (baseCamp.Residents.Count == 0)
            {
                return "BaseCamp is currently empty.";
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("BaseCamp residents:");

            foreach (string resident in baseCamp.Residents.OrderBy(r=>r))
            {
                IClimber currentClimber = climbers.All.FirstOrDefault(c => c.Name == resident);

                if (currentClimber != null)
                {
                    sb.AppendLine(
                        $"Name: {currentClimber.Name}, Stamina: {currentClimber.Stamina}, Count of Conquered Peaks: {currentClimber.ConqueredPeaks.Count}");
                }
            }

            return sb.ToString().TrimEnd();
        }

        public string OverallStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("***Highway-To-Peak***");

            foreach (var climber in climbers.All.OrderByDescending(c => c.ConqueredPeaks.Count).ThenBy(c=>c.Name))
            {
                sb.AppendLine(climber.ToString());
                List<IPeak> climbersPeak = new List<IPeak>();

                foreach (string peakName in climber.ConqueredPeaks)
                {
                    IPeak currentPeak = peaks.All.First(p => p.Name == peakName);
                    climbersPeak.Add(currentPeak);
                }

                foreach (var peak in climbersPeak.OrderByDescending(p=>p.Elevation))
                {
                    sb.AppendLine(peak.ToString());
                }
            }

            return sb.ToString().TrimEnd();

        }
    }
}
