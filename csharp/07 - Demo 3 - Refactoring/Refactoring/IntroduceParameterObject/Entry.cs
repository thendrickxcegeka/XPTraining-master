using System;

namespace Refactoring.IntroduceParameterObject
{
    public class Entry
    {
        public Entry(double value, DateTime chargeDate)
        {
            Value = value;
            ChargeDate = chargeDate;
        }

        public DateTime ChargeDate { get; }
        public double Value { get; }

    }
}