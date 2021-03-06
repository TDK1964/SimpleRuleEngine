﻿using RuleEngine.Base;
using RuleEngine.Contracts;

namespace RuleEngineTests.MockImplementation.Conditions
{
    internal class IntegerEqualToCondition : BaseCondition<int>
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegerEqualToCondition"/> class.
        /// </summary>
        /// <param name="threshold">The threshold value.</param>
        public IntegerEqualToCondition(int threshold)
            : base(threshold) {}

        #endregion

        #region ICondition<int> Members

        /// <summary>
        /// Determines whether this instance is satisfied.
        /// </summary>
        /// <returns></returns>
        public override bool IsSatisfied
        {
            get { return Value == Threshold; }
        }

        #endregion
    }
}