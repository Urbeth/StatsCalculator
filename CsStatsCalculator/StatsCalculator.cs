using System;
using System.Collections.Generic;
using System.Text;

namespace CsStatsCalculator
{
    public sealed class StatsCalculator
    {
        public StatsCalculator(List<Int32> values)
        {
            // throw new NotImplementedException( "Need to load the Values array with the input values (without using ToArray).");
            Values = new int[values.Count];
            for (int i = 0; i < values.Count; i++)
                Values[i] = values[i];
            Array.Sort(Values);
            InitializeBookkeeping();
        }

        private void InitializeBookkeeping()
        {
            MeanCalculated = false;
            ModeCalculated = false;
            MedianCalculated = false;

            mean = -1;
            mode = -1;
            modeFrequency = 1;
            median = -1;
        }

        public Int32[] Values
        {
            get;
            private set;
        }

        private bool MeanCalculated
        {
            get;
            set;
        }

        private bool ModeCalculated
        {
            get;
            set;
        }

        private bool MedianCalculated
        {
            get;
            set;
        }

        private Double mean;
        public Double Mean
        {
            get
            {
                return CalculateMean();
            }
        }

        private Int32 mode, modeFrequency;
        public Int32 Mode
        {
            get
            {
                CalculateMode(out mode, out modeFrequency);
                return mode;
            }
        }

        public Int32 ModeFrequency
        {
            get
            {
                CalculateMode(out mode, out modeFrequency);
                return modeFrequency;
            }
        }

        private Int32 median;
        public Int32 Median
        {
            get
            {
                CalculateMedian(out median);
                return median;
            }
        }

        private Double CalculateMean()
        {
            if(!MeanCalculated)
            {
                int sum = 0;
                foreach (int i in Values)
                    sum += i;
                mean = (double)sum / Values.Length;
                MeanCalculated = true;
            }
            return mean;
        }

        private void CalculateMode(out Int32 mode, out Int32 frequency)
        {
            int val = 0;
            if (!ModeCalculated)
            {
                Dictionary<int, int> freq = new Dictionary<int,int>();
                foreach (int i in Values)
                {
                    if (!freq.ContainsKey(i))
                        freq.Add(i, 0);
                    freq[i]++;
                }

                bool set = false;
                foreach (int value in freq.Keys)
                {
                    if (set)
                    {
                        if (freq[val] < freq[value])
                            val = value;
                    }
                    else
                    {
                        set = true;
                        val = value;
                    }
                }
                ModeCalculated = true;
                this.mode = val;
                this.modeFrequency = freq[val];
            }
            mode = this.mode;
            frequency = this.modeFrequency;
        }

        private void CalculateMedian(out Int32 median)
        {
            if (!MedianCalculated)
            {
                int half = 2;
                int startIndx = 0;
                int endIndx = Values.Length - 1;
                int middle = (endIndx - startIndx + 1) / half;
                MedianCalculated = true;
                this.median = Values[middle];
            }
            median = this.median;
        }
    }
}
