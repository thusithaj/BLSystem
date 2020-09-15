namespace BLSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Main_Reg
    {
        [Key]
        [Column(Order = 0)]
        public int ind { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int regNo { get; set; }

        [StringLength(50)]
        public string regName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string rCode { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string routeName { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(15)]
        public string NICno { get; set; }

        public DateTime? RegDate { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool LineManager { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LineID { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool SpLine { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DyNo { get; set; }

        public int? BankFK { get; set; }

        [StringLength(50)]
        public string NameAcHold { get; set; }

        [StringLength(18)]
        public string AcNumber { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(25)]
        public string PayMode { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(3)]
        public string WelfareReg { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "money")]
        public decimal WelfareBAL { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool SavingReg { get; set; }

        [Key]
        [Column(Order = 13, TypeName = "money")]
        public decimal SavingRate { get; set; }

        [Key]
        [Column(Order = 14, TypeName = "money")]
        public decimal SavingAMT { get; set; }

        [Key]
        [Column(Order = 15, TypeName = "smallmoney")]
        public decimal AddRate { get; set; }

        [Key]
        [Column(Order = 16, TypeName = "money")]
        public decimal xAmount { get; set; }

        [Key]
        [Column(Order = 17, TypeName = "money")]
        public decimal GrosKG { get; set; }

        [Key]
        [Column(Order = 18, TypeName = "smallmoney")]
        public decimal DdRate { get; set; }

        [Key]
        [Column(Order = 19, TypeName = "money")]
        public decimal DdKG { get; set; }

        [Key]
        [Column(Order = 20, TypeName = "money")]
        public decimal TotKg { get; set; }

        [Key]
        [Column(Order = 21, TypeName = "money")]
        public decimal TotKgSL { get; set; }

        [Key]
        [Column(Order = 22, TypeName = "money")]
        public decimal blRate { get; set; }

        [Key]
        [Column(Order = 23, TypeName = "money")]
        public decimal blRateSL { get; set; }

        [Key]
        [Column(Order = 24, TypeName = "money")]
        public decimal trRate { get; set; }

        [Key]
        [Column(Order = 25, TypeName = "money")]
        public decimal TempGross { get; set; }

        [Key]
        [Column(Order = 26, TypeName = "money")]
        public decimal Gross { get; set; }

        [Key]
        [Column(Order = 27, TypeName = "money")]
        public decimal GrossSL { get; set; }

        [Key]
        [Column(Order = 28, TypeName = "money")]
        public decimal AddPay { get; set; }

        [Key]
        [Column(Order = 29, TypeName = "money")]
        public decimal AddRange { get; set; }

        [Key]
        [Column(Order = 30, TypeName = "numeric")]
        public decimal Incentive { get; set; }

        [Key]
        [Column(Order = 31, TypeName = "money")]
        public decimal IncRate { get; set; }

        [Key]
        [Column(Order = 32, TypeName = "money")]
        public decimal prCoins { get; set; }

        [Key]
        [Column(Order = 33, TypeName = "money")]
        public decimal LMB { get; set; }

        [Key]
        [Column(Order = 34, TypeName = "money")]
        public decimal FertLMB { get; set; }

        [Key]
        [Column(Order = 35, TypeName = "money")]
        public decimal Transport { get; set; }

        [Key]
        [Column(Order = 36, TypeName = "money")]
        public decimal Tea { get; set; }

        [Key]
        [Column(Order = 37, TypeName = "money")]
        public decimal Fertilizer { get; set; }

        [Key]
        [Column(Order = 38, TypeName = "money")]
        public decimal CashAdv { get; set; }

        [Key]
        [Column(Order = 39)]
        public bool FunaralReg { get; set; }

        [Key]
        [Column(Order = 40, TypeName = "smallmoney")]
        public decimal FunaralRegFee { get; set; }

        [Key]
        [Column(Order = 41, TypeName = "money")]
        public decimal Funaral { get; set; }

        [Key]
        [Column(Order = 42, TypeName = "money")]
        public decimal Loan { get; set; }

        [Key]
        [Column(Order = 43, TypeName = "money")]
        public decimal LoanInterest { get; set; }

        [Key]
        [Column(Order = 44, TypeName = "money")]
        public decimal OtherDeduction { get; set; }

        [Key]
        [Column(Order = 45, TypeName = "money")]
        public decimal Stamp { get; set; }

        [Key]
        [Column(Order = 46, TypeName = "money")]
        public decimal TotalDeduction { get; set; }

        [Key]
        [Column(Order = 47, TypeName = "money")]
        public decimal tempBal { get; set; }

        [Key]
        [Column(Order = 48, TypeName = "money")]
        public decimal crCoins { get; set; }

        [Key]
        [Column(Order = 49, TypeName = "money")]
        public decimal Balance { get; set; }

        [Key]
        [Column(Order = 50, TypeName = "money")]
        public decimal FertNMB { get; set; }

        [Key]
        [Column(Order = 51, TypeName = "money")]
        public decimal NMB { get; set; }

        [Key]
        [Column(Order = 52, TypeName = "money")]
        public decimal LoanBalance { get; set; }

        [Key]
        [Column(Order = 53)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short FuPrv { get; set; }

        [Key]
        [Column(Order = 54)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short FuNext { get; set; }

        [Key]
        [Column(Order = 55, TypeName = "money")]
        public decimal CouponPrv { get; set; }

        [Key]
        [Column(Order = 56, TypeName = "money")]
        public decimal CouponNext { get; set; }

        [Key]
        [Column(Order = 57)]
        public bool ChequePrinted { get; set; }

        [Key]
        [Column(Order = 58, TypeName = "money")]
        public decimal xBal { get; set; }

        [Key]
        [Column(Order = 59, TypeName = "money")]
        public decimal xDebt { get; set; }

        [Key]
        [Column(Order = 60, TypeName = "money")]
        public decimal xCoins { get; set; }

        [Key]
        [Column(Order = 61)]
        [StringLength(12)]
        public string VoucherNo { get; set; }

        [Key]
        [Column(Order = 62)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ChequeNo { get; set; }

        public DateTime? ChequeDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? LastSupDate { get; set; }

        [Key]
        [Column(Order = 63, TypeName = "money")]
        public decimal LoanArreares { get; set; }

        [Key]
        [Column(Order = 64)]
        public bool AdvBook { get; set; }

        [Key]
        [Column(Order = 65, TypeName = "money")]
        public decimal AdvPayTMP { get; set; }

        [Key]
        [Column(Order = 66, TypeName = "money")]
        public decimal AdvRate { get; set; }

        [Key]
        [Column(Order = 67, TypeName = "money")]
        public decimal SavingBAL { get; set; }

        [Key]
        [Column(Order = 68, TypeName = "money")]
        public decimal SavingSupplier { get; set; }

        [Key]
        [Column(Order = 69, TypeName = "money")]
        public decimal SavingFactory { get; set; }

        [Key]
        [Column(Order = 70, TypeName = "money")]
        public decimal SavingPAID { get; set; }

        [StringLength(12)]
        public string TPno { get; set; }

        [Column(TypeName = "money")]
        public decimal? savingPrvCoin { get; set; }

        public bool? isActive { get; set; }

        public decimal? DeductionRate { get; set; }

        public bool? isBogus { get; set; }
    }
}
