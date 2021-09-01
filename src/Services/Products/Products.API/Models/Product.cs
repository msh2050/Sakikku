
namespace Products.API.Models;

/// <summary>
/// 
/// </summary>
[DataContract, Index(nameof(Name), IsUnique = true)]
public partial class Product
{
    public Product()
    {
        Id = Guid.NewGuid();
    }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public Guid Id { get; set; }




    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = true),MaxLength(100), MinLength(5),
        Required(AllowEmptyStrings = false, ErrorMessage ="Name of drug can not be empty")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets DefaultCode
    /// </summary>

    [DataMember(Name = "default_code", EmitDefaultValue = false)]
    public string DefaultCode { get; set; }

    // to be add later ( the entity got from code genetator)


    ///// <summary>
    ///// Gets or Sets Barcode
    ///// </summary>
    //[DataMember(Name = "barcode", EmitDefaultValue = false)]
    //public string Barcode { get; set; } = "00000000";
    //    /// <summary>
    //    /// Gets or Sets DisplayName
    //    /// </summary>
    //    [DataMember(Name = "display_name", EmitDefaultValue = false)]
    //    public string? DisplayName { get; set; }

    //    /// <summary>
    //    /// Gets or Sets Description
    //    /// </summary>
    //    [DataMember(Name = "description", EmitDefaultValue = false)]
    //    public string? Description { get; set; }

    //    /// <summary>
    //    /// Gets or Sets DescriptionSale
    //    /// </summary>
    //    [DataMember(Name = "description_sale", EmitDefaultValue = false)]
    //    public string? DescriptionSale { get; set; }


    //    /// <summary>
    //    /// Gets or Sets Type
    //    /// </summary>
    //    [TypeConverter(typeof(CustomEnumConverter<TypeEnum>))]
    //    [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    //    public enum TypeEnum
    //    {

    //        /// <summary>
    //        /// Enum Consumable Enum for Consumable
    //        /// </summary>
    //        [EnumMember(Value = "Consumable")]
    //        ConsumableEnum = 1,

    //        /// <summary>
    //        /// Enum ServiceEnum for service
    //        /// </summary>
    //        [EnumMember(Value = "service")]
    //        ServiceEnum = 2,

    //        /// <summary>
    //        /// Enum ProductEnum for product
    //        /// </summary>
    //        [EnumMember(Value = "product")]
    //        ProductEnum = 3
    //    }

    //    /// <summary>
    //    /// Gets or Sets Type
    //    /// </summary>
    //    [DataMember(Name = "type", EmitDefaultValue = false)]
    //    public TypeEnum Type { get; set; }

    //    /// <summary>
    //    /// Gets or Sets CategoryId
    //    /// </summary>
    //    [DataMember(Name = "category_id", EmitDefaultValue = false)]
    //    public CodeLabel? CategoryId { get; set; }

    //    /// <summary>
    //    /// Gets or Sets CompanyId
    //    /// </summary>
    //    [DataMember(Name = "company_id", EmitDefaultValue = false)]
    //    public CodeLabel? CompanyId { get; set; }

    //    /// <summary>
    //    /// Gets or Sets BrandIds
    //    /// </summary>
    //    [DataMember(Name = "brand_ids", EmitDefaultValue = false)]
    //    public List<int>? BrandIds { get; set; }

    //    /// <summary>
    //    /// Gets or Sets Prices
    //    /// </summary>
    //    [DataMember(Name = "prices", EmitDefaultValue = false)]
    //    public ProductPrice? Prices { get; set; }

    //    /// <summary>
    //    /// Gets or Sets Active
    //    /// </summary>
    //    [DataMember(Name = "active", EmitDefaultValue = false)]
    //    public bool Active { get; set; }

    //    /// <summary>
    //    /// Gets or Sets IsProductVariant
    //    /// </summary>
    //    [DataMember(Name = "is_product_variant", EmitDefaultValue = false)]
    //    public bool IsProductVariant { get; set; }

    //    /// <summary>
    //    /// Gets or Sets ProductVariantId
    //    /// </summary>
    //    [DataMember(Name = "product_variant_id", EmitDefaultValue = false)]
    //    public CodeLabel? ProductVariantId { get; set; }

    //    /// <summary>
    //    /// Gets or Sets ProductVariantIds
    //    /// </summary>
    //    [DataMember(Name = "product_variant_ids", EmitDefaultValue = false)]
    //    public List<int>? ProductVariantIds { get; set; }

    //    /// <summary>
    //    /// Gets or Sets ProductVariantCount
    //    /// </summary>
    //    [DataMember(Name = "product_variant_count", EmitDefaultValue = false)]
    //    public int ProductVariantCount { get; set; }

    //    /// <summary>
    //    /// Gets or Sets QtyAvailable
    //    /// </summary>
    //    [DataMember(Name = "qty_available", EmitDefaultValue = false)]
    //    public int QtyAvailable { get; set; }


    //    /// <summary>
    //    /// Gets or Sets OptionalProductIds
    //    /// </summary>
    //    [DataMember(Name = "optional_product_ids", EmitDefaultValue = false)]
    //    public List<int>? OptionalProductIds { get; set; }


    //    /// <summary>
    //    /// Gets or Sets GmRef
    //    /// </summary>
    //    [DataMember(Name = "gm_ref", EmitDefaultValue = false)]
    //    public string? GmRef { get; set; }

    //    /// <summary>
    //    /// Returns the string presentation of the object
    //    /// </summary>
    //    /// <returns>String presentation of the object</returns>
    //    public override string ToString()
    //    {
    //        var sb = new StringBuilder();
    //        sb.Append("class Product {\n");
    //        sb.Append("  Id: ").Append(Id).Append("\n");
    //        sb.Append("  Barcode: ").Append(Barcode).Append("\n");
    //        sb.Append("  DefaultCode: ").Append(DefaultCode).Append("\n");
    //        sb.Append("  Name: ").Append(Name).Append("\n");
    //        sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
    //        sb.Append("  Description: ").Append(Description).Append("\n");
    //        sb.Append("  DescriptionSale: ").Append(DescriptionSale).Append("\n");
    //        sb.Append("  Type: ").Append(Type).Append("\n");
    //        sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
    //        sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
    //        sb.Append("  BrandIds: ").Append(BrandIds).Append("\n");
    //        sb.Append("  Prices: ").Append(Prices).Append("\n");
    //        sb.Append("  Active: ").Append(Active).Append("\n");
    //        sb.Append("  IsProductVariant: ").Append(IsProductVariant).Append("\n");
    //        sb.Append("  ProductVariantId: ").Append(ProductVariantId).Append("\n");
    //        sb.Append("  ProductVariantIds: ").Append(ProductVariantIds).Append("\n");
    //        sb.Append("  ProductVariantCount: ").Append(ProductVariantCount).Append("\n");
    //        sb.Append("  QtyAvailable: ").Append(QtyAvailable).Append("\n");
    //        sb.Append("  OptionalProductIds: ").Append(OptionalProductIds).Append("\n");
    //        sb.Append("  GmRef: ").Append(GmRef).Append("\n");
    //        sb.Append("}\n");
    //        return sb.ToString();
    //    }



    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    //    public override bool Equals(object? obj)
    //    {
    //        if (obj is null) return false;
    //        if (ReferenceEquals(this, obj)) return true;
    //        return obj.GetType() == GetType() && Equals((Product)obj);
    //    }

    //    /// <summary>
    //    /// Returns true if Product instances are equal
    //    /// </summary>
    //    /// <param name="other">Instance of Product to be compared</param>
    //    /// <returns>Boolean</returns>
    //    public bool Equals(Product? other)
    //    {
    //        if (other is null) return false;
    //        if (ReferenceEquals(this, other)) return true;

    //        return
    //            (
    //                Id == other.Id ||

    //                Id.Equals(other.Id)
    //            ) &&
    //            (
    //                Barcode == other.Barcode ||
    //                Barcode != null &&
    //                Barcode.Equals(other.Barcode)
    //            ) &&
    //            (
    //                DefaultCode == other.DefaultCode ||
    //                DefaultCode != null &&
    //                DefaultCode.Equals(other.DefaultCode)
    //            ) &&
    //            //(
    //            //    DisplayName == other.DisplayName ||
    //            //    DisplayName != null &&
    //            //    DisplayName.Equals(other.DisplayName)
    //            //) &&
    //            //(
    //            //    Description == other.Description ||
    //            //    Description != null &&
    //            //    Description.Equals(other.Description)
    //            //) &&
    //            //(
    //            //    DescriptionSale == other.DescriptionSale ||
    //            //    DescriptionSale != null &&
    //            //    DescriptionSale.Equals(other.DescriptionSale)
    //            //) &&
    //            //(
    //            //    Type == other.Type ||

    //            //    Type.Equals(other.Type)
    //            //) &&
    //            //(
    //            //    CategoryId! == other.CategoryId! ||
    //            //    CategoryId! != null! &&
    //            //    CategoryId.Equals(other.CategoryId)
    //            //) &&
    //            //(
    //            //    CompanyId! == other.CompanyId! ||
    //            //    CompanyId! != null! &&
    //            //    CompanyId.Equals(other.CompanyId)
    //            //) &&
    //            //(
    //            //    BrandIds == other.BrandIds ||
    //            //    BrandIds != null &&
    //            //    other.BrandIds != null &&
    //            //    BrandIds.SequenceEqual(other.BrandIds)
    //            //) &&
    //            //(
    //            //    Prices! == other.Prices! ||
    //            //    Prices! != null! &&
    //            //    Prices.Equals(other.Prices)
    //            //) &&
    //            //(
    //            //    Active == other.Active ||

    //            //    Active.Equals(other.Active)
    //            //) &&
    //            //(
    //            //    IsProductVariant == other.IsProductVariant ||

    //            //    IsProductVariant.Equals(other.IsProductVariant)
    //            //) &&
    //            //(
    //            //    ProductVariantId! == other.ProductVariantId! ||
    //            //    ProductVariantId! != null! &&
    //            //    ProductVariantId.Equals(other.ProductVariantId)
    //            //) &&
    //            //(
    //            //    ProductVariantIds == other.ProductVariantIds ||
    //            //    ProductVariantIds != null &&
    //            //    other.ProductVariantIds != null &&
    //            //    ProductVariantIds.SequenceEqual(other.ProductVariantIds)
    //            //) &&
    //            //(
    //            //    ProductVariantCount == other.ProductVariantCount ||

    //            //    ProductVariantCount.Equals(other.ProductVariantCount)
    //            //) &&
    //            //(
    //            //    QtyAvailable == other.QtyAvailable ||

    //            //    QtyAvailable.Equals(other.QtyAvailable)
    //            //) &&
    //            //(
    //            //    OptionalProductIds == other.OptionalProductIds ||
    //            //    OptionalProductIds != null &&
    //            //    other.OptionalProductIds != null &&
    //            //    OptionalProductIds.SequenceEqual(other.OptionalProductIds)
    //            //) &&
    //            //(
    //            //    GmRef == other.GmRef ||
    //            //    GmRef != null &&
    //            //    GmRef.Equals(other.GmRef)
    //            //) &&
    //            (
    //                Name == other.Name ||
    //                Name != null &&
    //                Name.Equals(other.Name)
    //            );
    //    }

    //    /// <summary>
    //    /// Gets the hash code
    //    /// </summary>
    //    /// <returns>Hash code</returns>
    //    public override int GetHashCode()
    //    {
    //        unchecked // Overflow is fine, just wrap
    //        {
    //            var hashCode = 41;
    //            // Suitable nullity checks etc, of course :)

    //            hashCode = hashCode * 59 + Id.GetHashCode();
    //            if (Barcode != null)
    //                hashCode = hashCode * 59 + Barcode.GetHashCode();
    //            if (DefaultCode != null)
    //                hashCode = hashCode * 59 + DefaultCode.GetHashCode();
    //            if (Name != null)
    //                hashCode = hashCode * 59 + Name.GetHashCode();
    //            //if (DisplayName != null)
    //            //    hashCode = hashCode * 59 + DisplayName.GetHashCode();
    //            //if (Description != null)
    //            //    hashCode = hashCode * 59 + Description.GetHashCode();
    //            //if (DescriptionSale != null)
    //            //    hashCode = hashCode * 59 + DescriptionSale.GetHashCode();

    //            //hashCode = hashCode * 59 + Type.GetHashCode();
    //            //if (CategoryId! != null!)
    //            //    hashCode = hashCode * 59 + CategoryId.GetHashCode();
    //            //if (CompanyId! != null!)
    //            //    hashCode = hashCode * 59 + CompanyId.GetHashCode();
    //            //if (BrandIds != null)
    //            //    hashCode = hashCode * 59 + BrandIds.GetHashCode();
    //            //if (Prices! != null!)
    //            //    hashCode = hashCode * 59 + Prices.GetHashCode();

    //            //hashCode = hashCode * 59 + Active.GetHashCode();

    //            //hashCode = hashCode * 59 + IsProductVariant.GetHashCode();
    //            //if (ProductVariantId! != null!)
    //            //    hashCode = hashCode * 59 + ProductVariantId.GetHashCode();
    //            //if (ProductVariantIds != null)
    //            //    hashCode = hashCode * 59 + ProductVariantIds.GetHashCode();

    //            //hashCode = hashCode * 59 + ProductVariantCount.GetHashCode();

    //            //hashCode = hashCode * 59 + QtyAvailable.GetHashCode();
    //            //if (OptionalProductIds != null)
    //            //    hashCode = hashCode * 59 + OptionalProductIds.GetHashCode();

    //            //if (GmRef != null)
    //            //    hashCode = hashCode * 59 + GmRef.GetHashCode();
    //            return hashCode;
    //        }
    //    }

    //    #region Operators
    //#pragma warning disable 1591

    //    public static bool operator ==(Product left, Product right)
    //    {
    //        return Equals(left, right);
    //    }

    //    public static bool operator !=(Product left, Product right)
    //    {
    //        return !Equals(left, right);
    //    }

    //#pragma warning restore 1591
    //    #endregion Operators
}
