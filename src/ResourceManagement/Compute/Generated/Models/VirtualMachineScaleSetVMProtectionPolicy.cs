// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The protection policy of a virtual machine scale set VM.
    /// </summary>
    public partial class VirtualMachineScaleSetVMProtectionPolicy
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetVMProtectionPolicy class.
        /// </summary>
        public VirtualMachineScaleSetVMProtectionPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetVMProtectionPolicy class.
        /// </summary>
        /// <param name="protectFromScaleIn">Indicates that the virtual machine
        /// scale set VM shouldn't be considered for deletion during a scale-in
        /// operation.</param>
        /// <param name="protectFromScaleSetActions">Indicates that model
        /// updates or actions (including scale-in) initiated on the virtual
        /// machine scale set should not be applied to the virtual machine
        /// scale set VM.</param>
        public VirtualMachineScaleSetVMProtectionPolicy(bool? protectFromScaleIn = default(bool?), bool? protectFromScaleSetActions = default(bool?))
        {
            ProtectFromScaleIn = protectFromScaleIn;
            ProtectFromScaleSetActions = protectFromScaleSetActions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates that the virtual machine scale set VM
        /// shouldn't be considered for deletion during a scale-in operation.
        /// </summary>
        [JsonProperty(PropertyName = "protectFromScaleIn")]
        public bool? ProtectFromScaleIn { get; set; }

        /// <summary>
        /// Gets or sets indicates that model updates or actions (including
        /// scale-in) initiated on the virtual machine scale set should not be
        /// applied to the virtual machine scale set VM.
        /// </summary>
        [JsonProperty(PropertyName = "protectFromScaleSetActions")]
        public bool? ProtectFromScaleSetActions { get; set; }

    }
}