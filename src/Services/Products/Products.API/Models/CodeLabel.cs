

namespace Products.API.Models;

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class CodeLabel : IEquatable<CodeLabel>
    {
        /// <summary>
        /// returns -1 when no data has been furnished
        /// </summary>
        /// <value>returns -1 when no data has been furnished</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public int Code { get; set; }

        /// <summary>
        /// returns an empty string when no data has been furnished
        /// </summary>
        /// <value>returns an empty string when no data has been furnished</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CodeLabel {\n");
            sb.Append("  Code: ").Append(Code).Append('\n');
            sb.Append("  Label: ").Append(Label).Append('\n');
            sb.Append("}\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((CodeLabel)obj);
        }

    /// <summary>
    /// Returns true if CodeLabel instances are equal
    /// </summary>
    /// <param name="other">Instance of CodeLabel to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CodeLabel other)
    {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Code == other.Code ||
                    
                    Code.Equals(other.Code)
                ) && 
                (
                    Label == other.Label ||
                    Label != null &&
                    Label.Equals(other.Label)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    
                    hashCode = hashCode * 59 + Code.GetHashCode();
                    if (Label != null)
                    hashCode = hashCode * 59 + Label.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CodeLabel left, CodeLabel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CodeLabel left, CodeLabel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
 }
