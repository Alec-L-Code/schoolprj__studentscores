using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Scores
{
    // A class to represent and hold data for a student. Data contains scores, name, etc.
    public class Student
    {
        public string Name { get; set; } = "";
        private List<int> scores = new List<int>(); // A list of scores as integers



        // Constructors for the Student Class
        public Student() {}
        public Student(string name) { Name = name; }
        public Student(string name, int[] scores)
        {
            Name = name;
            this.scores = scores.ToList();
        }


        public int GetScoreCount() { return scores.Count; }

        public int GetScore(int index)
        {
            return scores[index];
        }
        public int[] GetAllScores()
        {
            return scores.ToArray();
        }
        public int GetScoreTotal()
        {
            int total = 0;
            foreach(int score in scores)
            {
                total += score;
            }
            return total;
        }
        public decimal GetScoreAvg()
        {
            if(GetScoreCount() == 0) { return 0; }


            decimal average = 0;
            foreach(int score in scores)
            {
                average += score;
            }
            return average / scores.Count;
        }
        public bool AddScore(int score)
        {
            if(score >= 0 && score <= 100)
            {
                scores.Add(score);
                return true;
            }
            return false;
        }
        public bool RemoveScore(int index)
        {
            try
            {
                scores.RemoveAt(index);
                return true;
            }
            catch(IndexOutOfRangeException) // Only should happen theoretically if called wrong.
            {
                Console.WriteLine();
                return false;
            }
            catch(Exception) { return false; } // Just in case of any unforseen exceptions.
        }
        public bool UpdateScore(int index, int score)
        {
            try
            {
                if (score >= 0 && score <= 100)
                {
                    scores[index] = score;
                    return true;
                }
                return false;
            }
            catch (IndexOutOfRangeException)
            {
                return false; 
            }
        }

        // This will return a properly formatted string of the students name and scores.
        public override string ToString()
        {
            String formatted = Name + "|";
            formatted += string.Join("|", GetAllScores());
            return formatted;
        }
        public void ClearScores()
        {
            scores.Clear();
        }
    }
}
