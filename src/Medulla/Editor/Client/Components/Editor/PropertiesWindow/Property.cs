﻿// Licensed to the Medulla Contributors under one or more agreements.
// The Medulla Contributors licenses this file to you under the Apache 2.0 license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace Medulla.Frontend.Client.Components.Editor.PropertiesWindow
{
    /// <summary>
    /// Property
    /// </summary>
    public class Property
    {

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; } = default!;

        /// <summary>
        /// Input Description
        /// </summary>
        public string InputDescription { get; set; } = default!;

        /// <summary>
        /// Default Value
        /// </summary>
        public Dictionary<string, object> DefaultValue { get; set; } = default!;

        /// <summary>
        /// InputType
        /// </summary>
        public string InputType { get; set; } = default!;

    }
}
