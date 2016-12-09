namespace ClinicManager.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ClinicDB : DbContext
    {
        public ClinicDB()
            : base("name=ClinicDB1")
        {
        }

        public virtual DbSet<BILL> BILL { get; set; }
        public virtual DbSet<BILL_DETAIL> BILL_DETAIL { get; set; }
        public virtual DbSet<MEDICAL_RECORD> MEDICAL_RECORD { get; set; }
        public virtual DbSet<MEDICINE> MEDICINE { get; set; }
        public virtual DbSet<MEDICINE_TYPE> MEDICINE_TYPE { get; set; }
        public virtual DbSet<PATIENT> PATIENT { get; set; }
        public virtual DbSet<PERMISSION> PERMISSION { get; set; }
        public virtual DbSet<PRESCRIPTION> PRESCRIPTION { get; set; }
        public virtual DbSet<PRESCRIPTION_DETAIL> PRESCRIPTION_DETAIL { get; set; }
        public virtual DbSet<PHARMACY_TYPE> PHARMACY_TYPE { get; set; }
        public virtual DbSet<QUEUE> QUEUE { get; set; }
        public virtual DbSet<SCHEDULE> SCHEDULE { get; set; }
        public virtual DbSet<SCHEDULE_INFO> SCHEDULE_INFO { get; set; }
        public virtual DbSet<SERVICE> SERVICE { get; set; }
        public virtual DbSet<SERVICE_DETAIL> SERVICE_DETAIL { get; set; }
        public virtual DbSet<UNIT> UNIT { get; set; }
        public virtual DbSet<USER> USER { get; set; }
        public virtual DbSet<USER_GROUP> USER_GROUP { get; set; }
        public virtual DbSet<WAY_TO_USE> WAY_TO_USE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BILL>()
                .Property(e => e.ServiceFee)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BILL>()
                .Property(e => e.MedicineFee)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BILL>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BILL>()
                .HasMany(e => e.BILL_DETAIL)
                .WithRequired(e => e.BILL)
                .HasForeignKey(e => e.ServiceID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BILL_DETAIL>()
                .Property(e => e.ServiceFee)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MEDICAL_RECORD>()
                .HasMany(e => e.BILL)
                .WithRequired(e => e.MEDICAL_RECORD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MEDICAL_RECORD>()
                .HasMany(e => e.SERVICE_DETAIL)
                .WithRequired(e => e.MEDICAL_RECORD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MEDICINE>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MEDICINE>()
                .HasMany(e => e.PRESCRIPTION_DETAIL)
                .WithRequired(e => e.MEDICINE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MEDICINE_TYPE>()
                .HasMany(e => e.MEDICINE)
                .WithRequired(e => e.MEDICINE_TYPE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PATIENT>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<PATIENT>()
                .HasMany(e => e.MEDICAL_RECORD)
                .WithRequired(e => e.PATIENT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PATIENT>()
                .HasMany(e => e.QUEUE)
                .WithRequired(e => e.PATIENT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PERMISSION>()
                .HasMany(e => e.USER_GROUP)
                .WithMany(e => e.PERMISSION)
                .Map(m => m.ToTable("PERMISSION_DETAIL").MapLeftKey("PermissionID").MapRightKey("UserGroupID"));

            modelBuilder.Entity<PRESCRIPTION>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PRESCRIPTION>()
                .HasMany(e => e.MEDICAL_RECORD)
                .WithRequired(e => e.PRESCRIPTION)
                .HasForeignKey(e => e.PrescriptionsID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRESCRIPTION>()
                .HasMany(e => e.PRESCRIPTION_DETAIL)
                .WithRequired(e => e.PRESCRIPTION)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRESCRIPTION_DETAIL>()
                .Property(e => e.MedicineFee)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PHARMACY_TYPE>()
                .HasMany(e => e.MEDICINE)
                .WithRequired(e => e.PHARMACY_TYPE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SCHEDULE>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<SCHEDULE_INFO>()
                .HasMany(e => e.SCHEDULE)
                .WithRequired(e => e.SCHEDULE_INFO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SERVICE>()
                .Property(e => e.ServiceFee)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SERVICE>()
                .HasMany(e => e.SERVICE_DETAIL)
                .WithRequired(e => e.SERVICE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SERVICE_DETAIL>()
                .Property(e => e.ServiceFee)
                .HasPrecision(19, 4);

            modelBuilder.Entity<UNIT>()
                .HasMany(e => e.MEDICINE)
                .WithRequired(e => e.UNIT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .HasMany(e => e.BILL)
                .WithRequired(e => e.USER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USER>()
                .HasMany(e => e.MEDICAL_RECORD)
                .WithRequired(e => e.USER)
                .HasForeignKey(e => e.DoctorID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USER_GROUP>()
                .HasMany(e => e.USER)
                .WithRequired(e => e.USER_GROUP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WAY_TO_USE>()
                .HasMany(e => e.MEDICINE)
                .WithRequired(e => e.WAY_TO_USE)
                .WillCascadeOnDelete(false);
        }
    }
}
