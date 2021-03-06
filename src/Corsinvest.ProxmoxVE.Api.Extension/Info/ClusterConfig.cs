/*
 * This file is part of the cv4pve-api-dotnet https://github.com/Corsinvest/cv4pve-api-dotnet,
 *
 * This source file is available under two different licenses:
 * - GNU General Public License version 3 (GPLv3)
 * - Corsinvest Enterprise License (CEL)
 * Full copyright and license information is available in
 * LICENSE.md which is distributed with this source code.
 *
 * Copyright (C) 2016 Corsinvest Srl	GPLv3 and CEL
 */

using System.Collections.Generic;

namespace Corsinvest.ProxmoxVE.Api.Extension.Info
{
    /// <summary>
    /// Cluster Config
    /// </summary>
    public class ClusterConfig
    {
        /// <summary>
        /// Token
        /// </summary>
        /// <value></value>
        public dynamic Totem { get; set; }

        /// <summary>
        /// Nodes
        /// </summary>
        /// <value></value>
        public IEnumerable<dynamic> Nodes { get; set; }
    }
}