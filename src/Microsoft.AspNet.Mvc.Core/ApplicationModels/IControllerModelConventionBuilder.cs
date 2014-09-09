﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.AspNet.Mvc.ApplicationModels
{
    public interface IControllerModelConventionBuilder
    {
        IControllerModelConventionBuilder Add(IControllerModelConvention convention);

        IActionModelConventionBuilder ForActions(Func<ActionModel, bool> predicate);
    }
}