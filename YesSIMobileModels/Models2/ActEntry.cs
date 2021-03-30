using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ActEntry")]
    public partial class ActEntry
    {
        public ActEntry()
        {
            ActEntryLines = new HashSet<ActEntryLine>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string DocCode { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public Guid? CfgCompanyId { get; set; }
        public Guid? AdmModuleId { get; set; }
        public Guid? ActJournalId { get; set; }
        public Guid? StlSettlementId { get; set; }
        public Guid? ComFolderId { get; set; }
        public Guid? ComSaleWithdrawalCancellationId { get; set; }
        public Guid? ComSaleWithdrawalProductId { get; set; }
        public Guid? ComSaleWithdrawalClientId { get; set; }
        public Guid? BuyDocumentId { get; set; }
        public Guid? StlDocumentId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? StrEntityId { get; set; }
        public Guid? StrEntityRelationId { get; set; }
        public Guid? RelationId { get; set; }
        [StringLength(255)]
        public string RelationCode { get; set; }
        [StringLength(255)]
        public string RelationDescription { get; set; }
        public Guid? StlCurrencyId { get; set; }

        [ForeignKey(nameof(ActJournalId))]
        [InverseProperty("ActEntries")]
        public virtual ActJournal ActJournal { get; set; }
        [ForeignKey(nameof(AdmModuleId))]
        [InverseProperty("ActEntries")]
        public virtual AdmModule AdmModule { get; set; }
        [ForeignKey(nameof(BuyDocumentId))]
        [InverseProperty("ActEntries")]
        public virtual BuyDocument BuyDocument { get; set; }
        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("ActEntries")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(ComFolderId))]
        [InverseProperty("ActEntries")]
        public virtual ComFolder ComFolder { get; set; }
        [ForeignKey(nameof(ComSaleWithdrawalCancellationId))]
        [InverseProperty("ActEntries")]
        public virtual ComSaleWithdrawalCancellation ComSaleWithdrawalCancellation { get; set; }
        [ForeignKey(nameof(ComSaleWithdrawalClientId))]
        [InverseProperty("ActEntries")]
        public virtual ComSaleWithdrawalClient ComSaleWithdrawalClient { get; set; }
        [ForeignKey(nameof(ComSaleWithdrawalProductId))]
        [InverseProperty("ActEntries")]
        public virtual ComSaleWithdrawalProduct ComSaleWithdrawalProduct { get; set; }
        [ForeignKey(nameof(StlCurrencyId))]
        [InverseProperty("ActEntries")]
        public virtual StlCurrency StlCurrency { get; set; }
        [ForeignKey(nameof(StlDocumentId))]
        [InverseProperty("ActEntries")]
        public virtual StlDocument StlDocument { get; set; }
        [ForeignKey(nameof(StlSettlementId))]
        [InverseProperty("ActEntries")]
        public virtual StlSettlement StlSettlement { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("ActEntryStrEntities")]
        public virtual StrEntity StrEntity { get; set; }
        [ForeignKey(nameof(StrEntityRelationId))]
        [InverseProperty("ActEntryStrEntityRelations")]
        public virtual StrEntity StrEntityRelation { get; set; }
        [InverseProperty(nameof(ActEntryLine.ActEntry))]
        public virtual ICollection<ActEntryLine> ActEntryLines { get; set; }
    }
}
