using System;
using System.Collections.Generic;

namespace Refactoring.IntroduceParameterObject
{
    public class Account
    {
        public ISet<Entry> Entries { get; } = new HashSet<Entry>();

        public double GetFlowBetween(DateTime start, DateTime end)
        {
            double result = 0;
            foreach (var entry in Entries)
            {
                if (entry.ChargeDate == start
                        || entry.ChargeDate == end
                        || (entry.ChargeDate > start && entry.ChargeDate < end))
                {
                    result += entry.Value;
                }
            }

            return result;
        }

    }
}