namespace Products.API.Models;

/// <summary>
/// 
/// </summary>
[DataContract]
    public partial class ProductPrice : IEquatable<ProductPrice>
    {
        /// <summary>
        /// Gets or Sets SalePrice
        /// </summary>
        [DataMember(Name="sale_price", EmitDefaultValue=false)]
        public decimal SalePrice { get; set; }

        /// <summary>
        /// Gets or Sets ExtraPrice
        /// </summary>
        [DataMember(Name="extra_price", EmitDefaultValue=false)]
        public decimal ExtraPrice { get; set; }

        /// <summary>
        /// Gets or Sets PublicPrice
        /// </summary>
        [DataMember(Name="public_price", EmitDefaultValue=false)]
        public decimal PublicPrice { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyId
        /// </summary>
        [DataMember(Name="currency_id", EmitDefaultValue=false)]
    public CodeLabel CurrencyId { get; set; }

        /// <summary>
        /// Gets or Sets PricelistItemCount
        /// </summary>
        [DataMember(Name="pricelist_item_count", EmitDefaultValue=false)]
        public int PricelistItemCount { get; set; }

        /// <summary>
        /// Gets or Sets PricelistItems
        /// </summary>
        [DataMember(Name="pricelist_items", EmitDefaultValue=false)]
        public List<ProductPriceList> PricelistItems { get; set; }

        /// <summary>
        /// Gets or Sets PricelistId
        /// </summary>
        [DataMember(Name="pricelist_id", EmitDefaultValue=false)]
        public CodeLabel PricelistId { get; set; }

        /// <summary>
        /// Gets or Sets UomId
        /// </summary>
        [DataMember(Name="uom_id", EmitDefaultValue=false)]
        public CodeLabel UomId { get; set; }

        /// <summary>
        /// Gets or Sets UomName
        /// </summary>
        [DataMember(Name="uom_name", EmitDefaultValue=false)]
        public string UomName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductPrice {\n");
            sb.Append("  SalePrice: ").Append(SalePrice).Append('\n');
            sb.Append("  ExtraPrice: ").Append(ExtraPrice).Append('\n');
            sb.Append("  PublicPrice: ").Append(PublicPrice).Append('\n');
            sb.Append("  CurrencyId: ").Append(CurrencyId).Append('\n');
            sb.Append("  PricelistItemCount: ").Append(PricelistItemCount).Append('\n');
            sb.Append("  PricelistItems: ").Append(PricelistItems).Append('\n');
            sb.Append("  PricelistId: ").Append(PricelistId).Append('\n');
            sb.Append("  UomId: ").Append(UomId).Append('\n');
            sb.Append("  UomName: ").Append(UomName).Append('\n');
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
            return obj.GetType() == GetType() && Equals((ProductPrice)obj);
        }

        /// <summary>
        /// Returns true if ProductPrice instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductPrice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductPrice other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SalePrice == other.SalePrice ||
                    
                    SalePrice.Equals(other.SalePrice)
                ) && 
                (
                    ExtraPrice == other.ExtraPrice ||
                    
                    ExtraPrice.Equals(other.ExtraPrice)
                ) && 
                (
                    PublicPrice == other.PublicPrice ||
                    
                    PublicPrice.Equals(other.PublicPrice)
                ) && 
                (
                    CurrencyId! == other.CurrencyId! ||
                    CurrencyId! != null! &&
                    CurrencyId.Equals(other.CurrencyId)
                ) && 
                (
                    PricelistItemCount == other.PricelistItemCount ||
                    
                    PricelistItemCount.Equals(other.PricelistItemCount)
                ) && 
                (
                    PricelistItems == other.PricelistItems ||
                    PricelistItems != null &&
                    other.PricelistItems != null &&
                    PricelistItems.SequenceEqual(other.PricelistItems)
                ) && 
                (
                    PricelistId! == other.PricelistId! ||
                    PricelistId! != null! &&
                    PricelistId.Equals(other.PricelistId)
                ) && 
                (
                    UomId! == other.UomId! ||
                    UomId! != null! &&
                    UomId.Equals(other.UomId)
                ) && 
                (
                    UomName == other.UomName ||
                    UomName != null &&
                    UomName.Equals(other.UomName)
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
                    
                    hashCode = hashCode * 59 + SalePrice.GetHashCode();
                    
                    hashCode = hashCode * 59 + ExtraPrice.GetHashCode();
                    
                    hashCode = hashCode * 59 + PublicPrice.GetHashCode();
                    if (CurrencyId! != null!)
                    hashCode = hashCode * 59 + CurrencyId.GetHashCode();
                    
                    hashCode = hashCode * 59 + PricelistItemCount.GetHashCode();
                    if (PricelistItems != null)
                    hashCode = hashCode * 59 + PricelistItems.GetHashCode();
                    if (PricelistId! != null!)
                    hashCode = hashCode * 59 + PricelistId.GetHashCode();
                    if (UomId! != null!)
                    hashCode = hashCode * 59 + UomId.GetHashCode();
                    if (UomName != null)
                    hashCode = hashCode * 59 + UomName.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ProductPrice left, ProductPrice right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ProductPrice left, ProductPrice right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }

