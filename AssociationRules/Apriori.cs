﻿using AssociationRules.Apriori;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationRules
{
    /// <summary>
    /// Apriori algorithm is based on the following key property:
    /// Every subset of a frequent / large item set is also a frequent / large
    /// </summary>
    public interface IApriori
    {
        IList<AssociationRule> BuildAssociationRules(IDataSet dataSet);
    }

    public class Apriori : IApriori
    {
        readonly IItemSetBuilder itemSetBuilder;

        readonly IRuleBuilder ruleBuilder;

        public Apriori(IItemSetBuilder iItemSetBuilder, IRuleBuilder ruleBuilder)
        {
            this.itemSetBuilder = iItemSetBuilder;
            this.ruleBuilder = ruleBuilder;
        }

        public IList<AssociationRule> BuildAssociationRules(IDataSet dataSet)
        {
            var itemSets = itemSetBuilder.BuildItemSets(dataSet);

            var rules = ruleBuilder.BuildRules(itemSets);

            return rules;
        }
    }
}