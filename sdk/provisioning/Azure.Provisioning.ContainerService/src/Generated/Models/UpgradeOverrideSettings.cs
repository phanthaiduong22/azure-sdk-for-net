// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// Settings for overrides when upgrading a cluster.
/// </summary>
public partial class UpgradeOverrideSettings : ProvisionableConstruct
{
    /// <summary>
    /// Whether to force upgrade the cluster. Note that this option instructs
    /// upgrade operation to bypass upgrade protections such as checking for
    /// deprecated API usage. Enable this option only with caution.
    /// </summary>
    public BicepValue<bool> ForceUpgrade { get => _forceUpgrade; set => _forceUpgrade.Assign(value); }
    private readonly BicepValue<bool> _forceUpgrade;

    /// <summary>
    /// Until when the overrides are effective. Note that this only matches the
    /// start time of an upgrade, and the effectiveness won&apos;t change once
    /// an upgrade starts even if the `until` expires as upgrade proceeds.
    /// This field is not set by default. It must be set for the overrides to
    /// take effect.
    /// </summary>
    public BicepValue<DateTimeOffset> Until { get => _until; set => _until.Assign(value); }
    private readonly BicepValue<DateTimeOffset> _until;

    /// <summary>
    /// Creates a new UpgradeOverrideSettings.
    /// </summary>
    public UpgradeOverrideSettings()
    {
        _forceUpgrade = BicepValue<bool>.DefineProperty(this, "ForceUpgrade", ["forceUpgrade"]);
        _until = BicepValue<DateTimeOffset>.DefineProperty(this, "Until", ["until"]);
    }
}
