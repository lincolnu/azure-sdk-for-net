// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Fabric.Admin.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for ScaleUnitState.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(ScaleUnitStateConverter))]
    public struct ScaleUnitState : System.IEquatable<ScaleUnitState>
    {
        private ScaleUnitState(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly ScaleUnitState Unknown = "Unknown";

        public static readonly ScaleUnitState Creating = "Creating";

        public static readonly ScaleUnitState Running = "Running";

        public static readonly ScaleUnitState Upgrading = "Upgrading";

        public static readonly ScaleUnitState Deleting = "Deleting";


        /// <summary>
        /// Underlying value of enum ScaleUnitState
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for ScaleUnitState
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type ScaleUnitState
        /// </summary>
        public bool Equals(ScaleUnitState e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to ScaleUnitState
        /// </summary>
        public static implicit operator ScaleUnitState(string value)
        {
            return new ScaleUnitState(value);
        }

        /// <summary>
        /// Implicit operator to convert ScaleUnitState to string
        /// </summary>
        public static implicit operator string(ScaleUnitState e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum ScaleUnitState
        /// </summary>
        public static bool operator == (ScaleUnitState e1, ScaleUnitState e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum ScaleUnitState
        /// </summary>
        public static bool operator != (ScaleUnitState e1, ScaleUnitState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for ScaleUnitState
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is ScaleUnitState && Equals((ScaleUnitState)obj);
        }

        /// <summary>
        /// Returns for hashCode ScaleUnitState
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
