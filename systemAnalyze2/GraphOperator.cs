using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemAnalyze2
{
    class GraphOperator
    {
        public List<List<int>> matrix { get; private set; }
        private int count;
        public Dictionary<int, int> levels { get; private set; }
        public int levelsCount { get; private set; }
        public GraphOperator(int _len, List<List<int>> _val)
        {
            matrix = _val;
            count = _len;
            levels = new Dictionary<int, int>();
        }
        private List<int> getOutcomingNodes(int num)
        {
            if (num >= count) return null;
            return matrix[num];
        }
        private List<int> getIncomingNodes(int num)
        {
            if (num >= count) return null;
            List<int> incList = new List<int>();
            for (int i=0; i!= count; i++)
            {
                if (matrix[i].Contains(num))
                    incList.Add(i);
            }
            return incList;
        }

        public void createLevels()
        {
            for(int i=0; i!= count; ++i)
            {
                if (getIncomingNodes(i).Count == 0) levels.Add(i, 0);
            }
            List<int> prevLevel = levels.Keys.ToList();
            List<int> currLevel = new List<int>();
            List<int> validLevel = new List<int>();
            levelsCount = 1;
            do
            {
                currLevel.Clear();
                foreach (int sour in prevLevel)
                {
                    currLevel.AddRange(getOutcomingNodes(sour));
                }
                currLevel = currLevel.Distinct().ToList();
                validLevel.Clear();
                for (int i = 0; i != currLevel.Count; ++i)
                {
                    List<int> incomNodes = getIncomingNodes(currLevel[i]);
                    if (levels.Keys.ToList().Intersect(incomNodes).Count() == incomNodes.Count)
                        validLevel.Add(currLevel[i]);
                }
                foreach (int v in validLevel)
                    levels.Add(v, levelsCount);
                prevLevel = new List<int>(validLevel);
                if (currLevel.Count != 0) 
                    levelsCount++;
            }
            while (currLevel.Count != 0);
        }


    }
}
