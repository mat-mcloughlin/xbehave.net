﻿// <copyright file="StepTest.cs" company="xBehave.net contributors">
//  Copyright (c) xBehave.net contributors. All rights reserved.
// </copyright>

namespace Xbehave.Execution
{
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using Xunit.Sdk;

    public class StepTest : XunitTest, IStepTest
    {
        private readonly string scenarioName;
        private readonly int scenarioNumber;
        private readonly int stepNumber;
        private readonly string stepName;

        [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1118:ParameterMustNotSpanMultipleLines", Justification = "It's a constructor.")]
        public StepTest(
            IXunitTestCase testCase, string scenarioName, int scenarioNumber, int stepNumber, string stepName)
            : base(
                testCase,
                string.Format(
                    CultureInfo.InvariantCulture,
                    "{0} [{1}.{2}] {3}",
                    scenarioName,
                    scenarioNumber.ToString("D2", CultureInfo.InvariantCulture),
                    stepNumber.ToString("D2", CultureInfo.InvariantCulture),
                    stepName))
        {
            this.scenarioName = scenarioName;
            this.scenarioNumber = scenarioNumber;
            this.stepNumber = stepNumber;
            this.stepName = stepName;
        }

        public string ScenarioName
        {
            get { return this.scenarioName; }
        }

        public int ScenarioNumber
        {
            get { return this.scenarioNumber; }
        }

        public int StepNumber
        {
            get { return this.stepNumber; }
        }

        public string StepName
        {
            get { return this.stepName; }
        }
    }
}
