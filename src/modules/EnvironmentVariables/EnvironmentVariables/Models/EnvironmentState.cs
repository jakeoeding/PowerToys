﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace EnvironmentVariables.Models
{
    public enum EnvironmentState
    {
        Unchanged = 0,
        ChangedOnStartup,
        EnvironmentMessageReceived,
        ProfileNotApplicable,
    }
}
