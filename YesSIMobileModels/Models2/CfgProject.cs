using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("CfgProject")]
    public partial class CfgProject
    {
        public CfgProject()
        {
            ActDefaultAccounts = new HashSet<ActDefaultAccount>();
            ActStockVariationCoefs = new HashSet<ActStockVariationCoef>();
            ActStockVariationExclusions = new HashSet<ActStockVariationExclusion>();
            AdmUserHabilitations = new HashSet<AdmUserHabilitation>();
            CfgTranches = new HashSet<CfgTranche>();
            SavServiceExpenses = new HashSet<SavServiceExpense>();
            StkItems = new HashSet<StkItem>();
            StlItemPricings = new HashSet<StlItemPricing>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(255)]
        public string Mobile { get; set; }
        [StringLength(255)]
        public string Phone { get; set; }
        [StringLength(255)]
        public string Fax { get; set; }
        [StringLength(255)]
        public string WebSite { get; set; }
        [StringLength(255)]
        public string Address2 { get; set; }
        [StringLength(255)]
        public string Address3 { get; set; }
        [StringLength(255)]
        public string ZipCode { get; set; }
        [StringLength(255)]
        public string City { get; set; }
        [StringLength(255)]
        public string SignatureCity { get; set; }
        public Guid? AdmCountryId { get; set; }
        public Guid? AdmSignatoryId { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkEndDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MarketingStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MarketingEndDate { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? CfgTechnicalManagerId { get; set; }
        public Guid? CfgSalesManagerId { get; set; }
        [StringLength(500)]
        public string DescriptionLong { get; set; }

        [ForeignKey(nameof(AdmCountryId))]
        [InverseProperty("CfgProjects")]
        public virtual AdmCountry AdmCountry { get; set; }
        [ForeignKey(nameof(AdmSignatoryId))]
        [InverseProperty(nameof(CfgTier.CfgProjectAdmSignatories))]
        public virtual CfgTier AdmSignatory { get; set; }
        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("CfgProjects")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(CfgSalesManagerId))]
        [InverseProperty(nameof(CfgTier.CfgProjectCfgSalesManagers))]
        public virtual CfgTier CfgSalesManager { get; set; }
        [ForeignKey(nameof(CfgTechnicalManagerId))]
        [InverseProperty(nameof(CfgTier.CfgProjectCfgTechnicalManagers))]
        public virtual CfgTier CfgTechnicalManager { get; set; }
        [InverseProperty(nameof(ActDefaultAccount.CfgProject))]
        public virtual ICollection<ActDefaultAccount> ActDefaultAccounts { get; set; }
        [InverseProperty(nameof(ActStockVariationCoef.CfgProject))]
        public virtual ICollection<ActStockVariationCoef> ActStockVariationCoefs { get; set; }
        [InverseProperty(nameof(ActStockVariationExclusion.CfgProject))]
        public virtual ICollection<ActStockVariationExclusion> ActStockVariationExclusions { get; set; }
        [InverseProperty(nameof(AdmUserHabilitation.CfgProject))]
        public virtual ICollection<AdmUserHabilitation> AdmUserHabilitations { get; set; }
        [InverseProperty(nameof(CfgTranche.CfgProject))]
        public virtual ICollection<CfgTranche> CfgTranches { get; set; }
        [InverseProperty(nameof(SavServiceExpense.CfgProject))]
        public virtual ICollection<SavServiceExpense> SavServiceExpenses { get; set; }
        [InverseProperty(nameof(StkItem.CfgProject))]
        public virtual ICollection<StkItem> StkItems { get; set; }
        [InverseProperty(nameof(StlItemPricing.CfgProject))]
        public virtual ICollection<StlItemPricing> StlItemPricings { get; set; }
    }
}
