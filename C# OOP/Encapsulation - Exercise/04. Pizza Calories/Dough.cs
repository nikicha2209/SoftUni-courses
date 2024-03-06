using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Pizza_Calories
{
    public class Dough
    {
        private const double MOD_FLOUR_WHITE = 1.5;
        private const double MOD_FLOUR_WHOLEGRAIN = 1.0;
        private const double MOD_BAKE_CRISPY = 0.9;
        private const double MOD_BAKE_CHEWY = 1.1;
        private const double MOD_BAKE_HOMEMADE = 1.0;

        private string flourType;
        private string bakingTechnique;
        private double grams;

        public string FlourType
        {
            set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                flourType = value;
            }
        }

        public string BakingTechnique
        {
            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                bakingTechnique = value;
            } 
        }

        public double Grams
        {
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                grams = value;
            } 
        }

        public double CaloriesPerGram
        {
            get
            {
                double caloriesPerGram = 2;

                if (flourType.ToLower() == "white") caloriesPerGram *= MOD_FLOUR_WHITE;
                else if (flourType.ToLower() == "wholegrain") caloriesPerGram *= MOD_FLOUR_WHOLEGRAIN;
                if (bakingTechnique.ToLower() == "crispy") caloriesPerGram *= MOD_BAKE_CRISPY;
                else if (bakingTechnique.ToLower() == "chewy") caloriesPerGram *= MOD_BAKE_CHEWY;
                else if (bakingTechnique.ToLower() == "homemade") caloriesPerGram *= MOD_BAKE_HOMEMADE;

                return caloriesPerGram;
            }
        }

        public Dough(string flourType, string bakingTechnique, double grams)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Grams = grams;
        }

        public double GetCalories() => grams * CaloriesPerGram;
    }
}
