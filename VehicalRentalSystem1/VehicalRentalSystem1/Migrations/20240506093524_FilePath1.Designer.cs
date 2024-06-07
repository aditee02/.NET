﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VehicalRentalSystem1.Models;

#nullable disable

namespace VehicalRentalSystem1.Migrations
{
    [DbContext(typeof(VehicalRentalSystemContext))]
    [Migration("20240506093524_FilePath1")]
    partial class FilePath1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("5611-LAP-0083\\aditee.khedekar_codi")
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VehicalRentalSystem1.Models.Booking", b =>
                {
                    b.Property<Guid>("BookingId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Booking_Id");

                    b.Property<decimal?>("AdditionalCharges")
                        .HasColumnType("decimal(18, 0)")
                        .HasColumnName("Additional_Charges");

                    b.Property<string>("DropOffLocation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Drop_Off_Location");

                    b.Property<bool>("InsuranceOption")
                        .HasColumnType("bit")
                        .HasColumnName("Insurance_Option");

                    b.Property<string>("PickupLocation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Pickup_Location");

                    b.Property<DateTime>("RentalEndDate")
                        .HasColumnType("datetime")
                        .HasColumnName("Rental_End_Date");

                    b.Property<DateTime>("RentalStartDate")
                        .HasColumnType("datetime")
                        .HasColumnName("Rental_Start_Date");

                    b.Property<decimal>("TotalRentalCost")
                        .HasColumnType("decimal(18, 0)")
                        .HasColumnName("Total_Rental_Cost");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("User_Id");

                    b.Property<Guid>("VehicalId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Vehical_Id");

                    b.HasKey("BookingId");

                    b.HasIndex("UserId");

                    b.ToTable("Booking", "dbo");
                });

            modelBuilder.Entity("VehicalRentalSystem1.Models.Chat", b =>
                {
                    b.Property<Guid>("ChatId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Chat_Id");

                    b.Property<DateTime>("ConversationStartTime")
                        .HasColumnType("datetime")
                        .HasColumnName("Conversation_Start_Time");

                    b.Property<string>("MessegeContext")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Messege_Context");

                    b.Property<Guid?>("RuserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("RUser_Id");

                    b.Property<Guid?>("SuserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("SUser_Id");

                    b.HasKey("ChatId")
                        .HasName("PK_Chat_1");

                    b.HasIndex("RuserId");

                    b.HasIndex("SuserId");

                    b.ToTable("Chat", "dbo");
                });

            modelBuilder.Entity("VehicalRentalSystem1.Models.Damage", b =>
                {
                    b.Property<Guid>("DamageId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Damage_Id");

                    b.Property<Guid>("BookingId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Booking_Id");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<byte[]>("DamageImage")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("Damage_Image");

                    b.Property<string>("DescriptionOfDamage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Description_Of_Damage");

                    b.Property<decimal>("InsuranceCoverage")
                        .HasColumnType("decimal(18, 0)")
                        .HasColumnName("Insurance_Coverage");

                    b.Property<decimal>("TotalDamageCost")
                        .HasColumnType("decimal(18, 0)")
                        .HasColumnName("Total_damage_Cost");

                    b.HasKey("DamageId")
                        .HasName("PK_Damage_1");

                    b.HasIndex("BookingId");

                    b.ToTable("Damage", "dbo");
                });

            modelBuilder.Entity("VehicalRentalSystem1.Models.Feedback", b =>
                {
                    b.Property<Guid>("FeedbackId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Feedback_Id");

                    b.Property<string>("Comment")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.Property<Guid>("TransactionId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Transaction_Id");

                    b.HasKey("FeedbackId");

                    b.HasIndex("TransactionId");

                    b.ToTable("Feedback", "dbo");
                });

            modelBuilder.Entity("VehicalRentalSystem1.Models.Payment", b =>
                {
                    b.Property<Guid>("PaymentId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Payment_Id");

                    b.Property<Guid>("BookingId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Booking_Id");

                    b.Property<Guid>("DamageId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Damage_Id");

                    b.Property<decimal>("TotalPayment")
                        .HasColumnType("decimal(18, 0)")
                        .HasColumnName("Total_Payment");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("User_Id");

                    b.HasKey("PaymentId")
                        .HasName("PK_Payment_1");

                    b.HasIndex("BookingId");

                    b.HasIndex("UserId");

                    b.ToTable("Payment", "dbo");
                });

            modelBuilder.Entity("VehicalRentalSystem1.Models.RentalTransaction", b =>
                {
                    b.Property<Guid>("TransactionId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Transaction_Id");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<Guid>("PaymentId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Payment_Id");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Payment_Method");

                    b.Property<byte[]>("ProofOfPayment")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("Proof_Of_Payment");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime")
                        .HasColumnName("Transaction_Date");

                    b.HasKey("TransactionId")
                        .HasName("PK_Rental_Transaction_1");

                    b.HasIndex("PaymentId");

                    b.ToTable("Rental_Transaction", "dbo");
                });

            modelBuilder.Entity("VehicalRentalSystem1.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("User_Id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Age")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("GovermentDoc")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Goverment_Doc");

                    b.Property<string>("GovermentDoc_FilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password2")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<long>("PhoneNo")
                        .HasColumnType("bigint")
                        .HasColumnName("Phone_No");

                    b.Property<string>("ResetToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("User", "dbo");
                });

            modelBuilder.Entity("VehicalRentalSystem1.Models.Vehical", b =>
                {
                    b.Property<Guid>("VehicalId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Vehical_Id");

                    b.Property<bool>("AvailabilityStatus")
                        .HasColumnType("bit")
                        .HasColumnName("Availability_Status");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("InsuranceAvailable")
                        .HasColumnType("bit")
                        .HasColumnName("Insurance_Available");

                    b.Property<string>("InsuranceInfo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Insurance_Info");

                    b.Property<Guid>("LicenseNo")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("License_No");

                    b.Property<int>("Mileage")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RentalRatePerHour")
                        .HasColumnType("int")
                        .HasColumnName("Rental_rate_Per_Hour");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("User_Id");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("VehicalId")
                        .HasName("PK_Vehical_1");

                    b.HasIndex("UserId");

                    b.ToTable("Vehical", "dbo");
                });

            modelBuilder.Entity("VehicalRentalSystem1.Models.Booking", b =>
                {
                    b.HasOne("VehicalRentalSystem1.Models.User", "User")
                        .WithMany("Bookings")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Booking_User");

                    b.Navigation("User");
                });

            modelBuilder.Entity("VehicalRentalSystem1.Models.Chat", b =>
                {
                    b.HasOne("VehicalRentalSystem1.Models.User", "Ruser")
                        .WithMany("ChatRusers")
                        .HasForeignKey("RuserId")
                        .HasConstraintName("FK_Chat_User1");

                    b.HasOne("VehicalRentalSystem1.Models.User", "Suser")
                        .WithMany("ChatSusers")
                        .HasForeignKey("SuserId")
                        .HasConstraintName("FK_Chat_User");

                    b.Navigation("Ruser");

                    b.Navigation("Suser");
                });

            modelBuilder.Entity("VehicalRentalSystem1.Models.Damage", b =>
                {
                    b.HasOne("VehicalRentalSystem1.Models.Booking", "Booking")
                        .WithMany("Damages")
                        .HasForeignKey("BookingId")
                        .IsRequired()
                        .HasConstraintName("FK_Damage_Booking");

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("VehicalRentalSystem1.Models.Feedback", b =>
                {
                    b.HasOne("VehicalRentalSystem1.Models.RentalTransaction", "Transaction")
                        .WithMany("Feedbacks")
                        .HasForeignKey("TransactionId")
                        .IsRequired()
                        .HasConstraintName("FK_Feedback_Rental_Transaction");

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("VehicalRentalSystem1.Models.Payment", b =>
                {
                    b.HasOne("VehicalRentalSystem1.Models.Booking", "Booking")
                        .WithMany("Payments")
                        .HasForeignKey("BookingId")
                        .IsRequired()
                        .HasConstraintName("FK_Payment_Booking");

                    b.HasOne("VehicalRentalSystem1.Models.User", "User")
                        .WithMany("Payments")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Payment_User");

                    b.Navigation("Booking");

                    b.Navigation("User");
                });

            modelBuilder.Entity("VehicalRentalSystem1.Models.RentalTransaction", b =>
                {
                    b.HasOne("VehicalRentalSystem1.Models.Payment", "Payment")
                        .WithMany("RentalTransactions")
                        .HasForeignKey("PaymentId")
                        .IsRequired()
                        .HasConstraintName("FK_Rental_Transaction_Payment");

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("VehicalRentalSystem1.Models.Vehical", b =>
                {
                    b.HasOne("VehicalRentalSystem1.Models.User", "User")
                        .WithMany("Vehicals")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Vehical_User");

                    b.Navigation("User");
                });

            modelBuilder.Entity("VehicalRentalSystem1.Models.Booking", b =>
                {
                    b.Navigation("Damages");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("VehicalRentalSystem1.Models.Payment", b =>
                {
                    b.Navigation("RentalTransactions");
                });

            modelBuilder.Entity("VehicalRentalSystem1.Models.RentalTransaction", b =>
                {
                    b.Navigation("Feedbacks");
                });

            modelBuilder.Entity("VehicalRentalSystem1.Models.User", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("ChatRusers");

                    b.Navigation("ChatSusers");

                    b.Navigation("Payments");

                    b.Navigation("Vehicals");
                });
#pragma warning restore 612, 618
        }
    }
}
