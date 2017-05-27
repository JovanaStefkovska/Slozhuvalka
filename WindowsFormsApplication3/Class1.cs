using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Igraci
    {
        public string Name { get; set; }

        public int Score { get; set; }

        public Igraci(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Name, Score);
        }
    }
}
