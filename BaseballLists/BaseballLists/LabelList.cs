using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballLists
{
    class LabelList
    {
        List<string> statLabels = new List<string>();
        List<double> statistics = new List<double>();

        public void CreateList()

        {
            statLabels.Add("Batting Average");
            statLabels.Add("Home Runs");
            statLabels.Add("RBI's");
            statLabels.Add("Runs Scored");
            statLabels.Add("Stolen Bases");
            statLabels.Add("Games Played");
            statLabels.Add("Hits");
            statLabels.Add("At Bats");
            statLabels.Add("Total Bases");       
            statistics.Add(.325);
            statistics.Add(19);
            statistics.Add(58);
            statistics.Add(115);
            statistics.Add(13);
            statistics.Add(93);
            statistics.Add(354);
            statistics.Add(192);
            

            var LabelsAndStatistics = statLabels.Zip(statistics, (statLabel, statistic) => new { StatLabel = statLabel, Statistic = statistic });

            foreach (var labelsAndStats in LabelsAndStatistics)
            {
                Console.WriteLine(labelsAndStats.StatLabel + ":   \t" + labelsAndStats.Statistic + "\n");
            }
        }
        
    }
        
}
