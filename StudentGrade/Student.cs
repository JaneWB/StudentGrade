using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StudentGrade
{
    class Student
    {
        public List<int> scores = new List<int>();
        public string Name { get; set; }


        public Student(string name)
        {
            Name = name;
        }

        public void AddScore(int score)
        {
            scores.Add(score);
        }

        public double Average()
        {
            //return scores.Sum() / scores.Count;
            return scores.Average(x => x);

        }


    }


}
