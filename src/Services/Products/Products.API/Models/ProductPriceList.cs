namespace Products.API.Models;

/// <summary>
/// 
/// </summary>
[DataContract]
    public partial class ProductPriceList : IEquatable<ProductPriceList>
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets ProductTmplId
        /// </summary>
        [DataMember(Name="product_tmpl_id", EmitDefaultValue=false)]
        public CodeLabel ProductTmplId { get; set; }

        /// <summary>
        /// Gets or Sets ProductId
        /// </summary>
        [DataMember(Name="product_id", EmitDefaultValue=false)]
        public CodeLabel ProductId { get; set; }

        /// <summary>
        /// Gets or Sets PricelistId
        /// </summary>
        [DataMember(Name="pricelist_id", EmitDefaultValue=false)]
        public CodeLabel PricelistId { get; set; }

        /// <summary>
        /// Gets or Sets FixedPrice
        /// </summary>
        [DataMember(Name="fixed_price", EmitDefaultValue=false)]
        public decimal FixedPrice { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public string Price { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductPriceList {\n");
            sb.Append("  Id: ").Append(Id).Append('\n');
            sb.Append("  Name: ").Append(Name).Append('\n');
            sb.Append("  DisplayName: ").Append(DisplayName).Append('\n');
            sb.Append("  ProductTmplId: ").Append(ProductTmplId).Append('\n');
            sb.Append("  ProductId: ").Append(ProductId).Append('\n');
            sb.Append("  PricelistId: ").Append(PricelistId).Append('\n');
            sb.Append("  FixedPrice: ").Append(FixedPrice).Append('\n');
            sb.Append("  Price: ").Append(Price).Append('\n');
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
            return obj.GetType() == GetType() && Equals((ProductPriceList)obj);
        }

        /// <summary>
        /// Returns true if ProductPriceList instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductPriceList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductPriceList other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    DisplayName == other.DisplayName ||
                    DisplayName != null &&
                    DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    ProductTmplId! == other.ProductTmplId! ||
                    ProductTmplId! != null! &&
                    ProductTmplId.Equals(other.ProductTmplId)
                ) && 
                (
                    ProductId! == other.ProductId! ||
                    ProductId! != null! &&
                    ProductId.Equals(other.ProductId)
                ) && 
                (
                    PricelistId! == other.PricelistId! ||
                    PricelistId! != null! &&
                    PricelistId.Equals(other.PricelistId)
                ) && 
                (
                    FixedPrice == other.FixedPrice ||
                    
                    FixedPrice.Equals(other.FixedPrice)
                ) && 
                (
                    Price == other.Price ||
                    Price != null &&
                    Price.Equals(other.Price)
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
                    
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (DisplayName != null)
                    hashCode = hashCode * 59 + DisplayName.GetHashCode();
                    if (ProductTmplId! != null!)
                    hashCode = hashCode * 59 + ProductTmplId.GetHashCode();
                    if (ProductId! != null!)
                    hashCode = hashCode * 59 + ProductId.GetHashCode();
                    if (PricelistId! != null!)
                    hashCode = hashCode * 59 + PricelistId.GetHashCode();
                    
                    hashCode = hashCode * 59 + FixedPrice.GetHashCode();
                    if (Price != null)
                    hashCode = hashCode * 59 + Price.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ProductPriceList left, ProductPriceList right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ProductPriceList left, ProductPriceList right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }

