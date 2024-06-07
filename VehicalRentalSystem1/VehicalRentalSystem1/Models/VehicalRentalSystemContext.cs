using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VehicalRentalSystem1.Models;

public partial class VehicalRentalSystemContext : DbContext
{
    public VehicalRentalSystemContext()
    {
    }

    public VehicalRentalSystemContext(DbContextOptions<VehicalRentalSystemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<Chat> Chats { get; set; }

    public virtual DbSet<Damage> Damages { get; set; }

    public virtual DbSet<Feedback> Feedbacks { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<RentalTransaction> RentalTransactions { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Vehical> Vehicals { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        if (!optionsBuilder.IsConfigured)
        {

        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("5611-LAP-0083\\aditee.khedekar_codi");

        modelBuilder.Entity<Booking>(entity =>
        {
            entity.ToTable("Booking", "dbo");

            entity.Property(e => e.BookingId)
                .ValueGeneratedNever()
                .HasColumnName("Booking_Id");
            entity.Property(e => e.AdditionalCharges)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Additional_Charges");
            entity.Property(e => e.DropOffLocation)
                .HasMaxLength(50)
                .HasColumnName("Drop_Off_Location");
            entity.Property(e => e.InsuranceOption).HasColumnName("Insurance_Option");
            entity.Property(e => e.PickupLocation)
                .HasMaxLength(50)
                .HasColumnName("Pickup_Location");
            entity.Property(e => e.RentalEndDate)
                .HasColumnType("datetime")
                .HasColumnName("Rental_End_Date");
            entity.Property(e => e.RentalStartDate)
                .HasColumnType("datetime")
                .HasColumnName("Rental_Start_Date");
            entity.Property(e => e.TotalRentalCost)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Total_Rental_Cost");
            entity.Property(e => e.UserId).HasColumnName("User_Id");
            entity.Property(e => e.VehicalId).HasColumnName("Vehical_Id");

            entity.HasOne(d => d.User).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Booking_User");
        });

        modelBuilder.Entity<Chat>(entity =>
        {
            entity.HasKey(e => e.ChatId).HasName("PK_Chat_1");

            entity.ToTable("Chat", "dbo");

            entity.Property(e => e.ChatId)
                .ValueGeneratedNever()
                .HasColumnName("Chat_Id");
            entity.Property(e => e.ConversationStartTime)
                .HasColumnType("datetime")
                .HasColumnName("Conversation_Start_Time");
            entity.Property(e => e.MessegeContext).HasColumnName("Messege_Context");
            entity.Property(e => e.RuserId).HasColumnName("RUser_Id");
            entity.Property(e => e.SuserId).HasColumnName("SUser_Id");

            entity.HasOne(d => d.Ruser).WithMany(p => p.ChatRusers)
                .HasForeignKey(d => d.RuserId)
                .HasConstraintName("FK_Chat_User1");

            entity.HasOne(d => d.Suser).WithMany(p => p.ChatSusers)
                .HasForeignKey(d => d.SuserId)
                .HasConstraintName("FK_Chat_User");
        });

        modelBuilder.Entity<Damage>(entity =>
        {
            entity.HasKey(e => e.DamageId).HasName("PK_Damage_1");

            entity.ToTable("Damage", "dbo");

            entity.Property(e => e.DamageId)
                .ValueGeneratedNever()
                .HasColumnName("Damage_Id");
            entity.Property(e => e.BookingId).HasColumnName("Booking_Id");
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DamageImage).HasColumnName("Damage_Image");
            entity.Property(e => e.DescriptionOfDamage).HasColumnName("Description_Of_Damage");
            entity.Property(e => e.InsuranceCoverage)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Insurance_Coverage");
            entity.Property(e => e.TotalDamageCost)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Total_damage_Cost");

            entity.HasOne(d => d.Booking).WithMany(p => p.Damages)
                .HasForeignKey(d => d.BookingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Damage_Booking");
        });

        modelBuilder.Entity<Feedback>(entity =>
        {
            entity.ToTable("Feedback", "dbo");

            entity.Property(e => e.FeedbackId)
                .ValueGeneratedNever()
                .HasColumnName("Feedback_Id");
            entity.Property(e => e.Comment).IsUnicode(false);
            entity.Property(e => e.TransactionId).HasColumnName("Transaction_Id");

            entity.HasOne(d => d.Transaction).WithMany(p => p.Feedbacks)
                .HasForeignKey(d => d.TransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Feedback_Rental_Transaction");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK_Payment_1");

            entity.ToTable("Payment", "dbo");

            entity.Property(e => e.PaymentId)
                .ValueGeneratedNever()
                .HasColumnName("Payment_Id");
            entity.Property(e => e.BookingId).HasColumnName("Booking_Id");
            entity.Property(e => e.DamageId).HasColumnName("Damage_Id");
            entity.Property(e => e.TotalPayment)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Total_Payment");
            entity.Property(e => e.UserId).HasColumnName("User_Id");

            entity.HasOne(d => d.Booking).WithMany(p => p.Payments)
                .HasForeignKey(d => d.BookingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payment_Booking");

            entity.HasOne(d => d.User).WithMany(p => p.Payments)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payment_User");
        });

        modelBuilder.Entity<RentalTransaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK_Rental_Transaction_1");

            entity.ToTable("Rental_Transaction", "dbo");

            entity.Property(e => e.TransactionId)
                .ValueGeneratedNever()
                .HasColumnName("Transaction_Id");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PaymentId).HasColumnName("Payment_Id");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Payment_Method");
            entity.Property(e => e.ProofOfPayment).HasColumnName("Proof_Of_Payment");
            entity.Property(e => e.TransactionDate)
                .HasColumnType("datetime")
                .HasColumnName("Transaction_Date");

            entity.HasOne(d => d.Payment).WithMany(p => p.RentalTransactions)
                .HasForeignKey(d => d.PaymentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rental_Transaction_Payment");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User", "dbo");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("User_Id");
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.GovermentDoc)
                .HasMaxLength(50)
                .HasColumnName("Goverment_Doc");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Password1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNo).HasColumnName("Phone_No");
        });

        modelBuilder.Entity<Vehical>(entity =>
        {
            entity.HasKey(e => e.VehicalId).HasName("PK_Vehical_1");

            entity.ToTable("Vehical", "dbo");

            entity.Property(e => e.VehicalId)
                .ValueGeneratedNever()
                .HasColumnName("Vehical_Id");
            entity.Property(e => e.AvailabilityStatus).HasColumnName("Availability_Status");
            entity.Property(e => e.Color).HasMaxLength(50);
            entity.Property(e => e.InsuranceAvailable).HasColumnName("Insurance_Available");
            entity.Property(e => e.InsuranceInfo).HasColumnName("Insurance_Info");
            entity.Property(e => e.LicenseNo).HasColumnName("License_No");
            entity.Property(e => e.Model).HasMaxLength(50);
            entity.Property(e => e.RentalRatePerHour).HasColumnName("Rental_rate_Per_Hour");
            entity.Property(e => e.Vehical_Photo).HasColumnName("Vehical_Photo");
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.UserId).HasColumnName("User_Id");

            entity.HasOne(d => d.User).WithMany(p => p.Vehicals)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vehical_User");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
