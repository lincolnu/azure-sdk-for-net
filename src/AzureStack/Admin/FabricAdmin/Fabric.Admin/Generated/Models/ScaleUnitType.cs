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
    /// Defines values for ScaleUnitType.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(ScaleUnitTypeConverter))]
    public struct ScaleUnitType : System.IEquatable<ScaleUnitType>
    {
        private ScaleUnitType(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly ScaleUnitType Unknown = "Unknown";

        public static readonly ScaleUnitType ComputeOnly = "ComputeOnly";

        public static readonly ScaleUnitType StorageOnly = "StorageOnly";

        public static readonly ScaleUnitType HyperConverged = "HyperConverged";


        /// <summary>
        /// Underlying value of enum ScaleUnitType
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for ScaleUnitType
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type ScaleUnitType
        /// </summary>
        public bool Equals(ScaleUnitType e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to ScaleUnitType
        /// </summary>
        public static implicit operator ScaleUnitType(string value)
        {
            return new ScaleUnitType(value);
        }

        /// <summary>
        /// Implicit operator to convert ScaleUnitType to string
        /// </summary>
        public static implicit operator string(ScaleUnitType e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum ScaleUnitType
        /// </summary>
        public static bool operator == (ScaleUnitType e1, ScaleUnitType e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum ScaleUnitType
        /// </summary>
        public static bool operator != (ScaleUnitType e1, ScaleUnitType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for ScaleUnitType
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is ScaleUnitType && Equals((ScaleUnitType)obj);
        }

        /// <summary>
        /// Returns for hashCode ScaleUnitType
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
