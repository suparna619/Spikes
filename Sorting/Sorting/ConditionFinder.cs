using System;

namespace Sorting
{
    public class ConditionFinder<TComparable> where TComparable : IMyComparable<TComparable>
    {
        private readonly TComparable[] _comparableArray;

        private Func<TComparable, TComparable, bool> Condition;

        public ConditionFinder(TComparable[] comparableArray, Func<TComparable, TComparable, bool> condition)
        {
            this._comparableArray = comparableArray;
            Condition = condition;
        }

        public TComparable Find()
        {
            var temp = _comparableArray[0];
            foreach (TComparable comparedObject in _comparableArray)
            {
                if (Condition(temp, comparedObject))
                {
                    temp = comparedObject;
                }
            }
            return temp;
        }
    }
}