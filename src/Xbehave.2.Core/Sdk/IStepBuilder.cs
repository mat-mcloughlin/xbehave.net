﻿// <copyright file="IStepBuilder.cs" company="xBehave.net contributors">
//  Copyright (c) xBehave.net contributors. All rights reserved.
// </copyright>

namespace Xbehave.Sdk
{
    using System;

    /// <summary>
    /// Provides methods for building steps.
    /// </summary>
    public interface IStepBuilder
    {
        /// <summary>
        /// Indicates that the step will not be executed.
        /// </summary>
        /// <param name="reason">The reason for not executing the step.</param>
        /// <returns>An instance of <see cref="IStepBuilder"/>.</returns>
        /// <remarks>If the <paramref name="reason"/> is <c>null</c> then the step will not be skipped.</remarks>
        IStepBuilder Skip(string reason);

        /// <summary>
        /// Declares a teardown action (related to this step and/or previous steps) which will be executed
        /// after all steps in the current scenario have been executed.
        /// </summary>
        /// <param name="action">The action.</param>
        /// <returns>
        /// An instance of <see cref="IStepBuilder"/>.
        /// </returns>
        IStepBuilder Teardown(Action action);

        /// <summary>
        /// Defines the behavior of remaining steps if this step fails.
        /// </summary>
        /// <param name="behavior">The behavior of remaining steps.</param>
        /// <returns>
        /// An instance of <see cref="IStepBuilder"/>.
        /// </returns>
        IStepBuilder OnFailure(RemainingSteps behavior);
    }
}
