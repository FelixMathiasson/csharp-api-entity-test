﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using workshop.wwwapi.Data;

#nullable disable

namespace workshop.wwwapi.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240910100317_tenthMigration")]
    partial class tenthMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("workshop.wwwapi.Models.Appointment", b =>
                {
                    b.Property<int>("DoctorId")
                        .HasColumnType("integer")
                        .HasColumnName("doctorId");

                    b.Property<int>("PatientId")
                        .HasColumnType("integer")
                        .HasColumnName("patientId");

                    b.Property<DateTime>("Booking")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("booking");

                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.HasKey("DoctorId", "PatientId");

                    b.ToTable("appointments");

                    b.HasData(
                        new
                        {
                            DoctorId = 9,
                            PatientId = 1,
                            Booking = new DateTime(2025, 3, 1, 12, 5, 58, 557, DateTimeKind.Utc).AddTicks(4758),
                            Id = 1
                        },
                        new
                        {
                            DoctorId = 10,
                            PatientId = 2,
                            Booking = new DateTime(2024, 12, 19, 12, 32, 27, 557, DateTimeKind.Utc).AddTicks(4847),
                            Id = 2
                        },
                        new
                        {
                            DoctorId = 2,
                            PatientId = 3,
                            Booking = new DateTime(2025, 9, 2, 13, 14, 4, 557, DateTimeKind.Utc).AddTicks(4852),
                            Id = 3
                        },
                        new
                        {
                            DoctorId = 10,
                            PatientId = 4,
                            Booking = new DateTime(2025, 3, 27, 3, 14, 25, 557, DateTimeKind.Utc).AddTicks(4857),
                            Id = 4
                        },
                        new
                        {
                            DoctorId = 2,
                            PatientId = 5,
                            Booking = new DateTime(2024, 12, 1, 19, 56, 57, 557, DateTimeKind.Utc).AddTicks(4861),
                            Id = 5
                        },
                        new
                        {
                            DoctorId = 7,
                            PatientId = 6,
                            Booking = new DateTime(2025, 6, 19, 2, 16, 37, 557, DateTimeKind.Utc).AddTicks(4865),
                            Id = 6
                        },
                        new
                        {
                            DoctorId = 7,
                            PatientId = 7,
                            Booking = new DateTime(2025, 5, 12, 1, 11, 22, 557, DateTimeKind.Utc).AddTicks(4869),
                            Id = 7
                        },
                        new
                        {
                            DoctorId = 3,
                            PatientId = 8,
                            Booking = new DateTime(2025, 7, 14, 3, 31, 12, 557, DateTimeKind.Utc).AddTicks(4872),
                            Id = 8
                        },
                        new
                        {
                            DoctorId = 3,
                            PatientId = 9,
                            Booking = new DateTime(2025, 5, 25, 0, 18, 15, 557, DateTimeKind.Utc).AddTicks(4876),
                            Id = 9
                        },
                        new
                        {
                            DoctorId = 8,
                            PatientId = 10,
                            Booking = new DateTime(2025, 8, 1, 13, 42, 49, 557, DateTimeKind.Utc).AddTicks(4879),
                            Id = 10
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("fullName");

                    b.HasKey("Id");

                    b.ToTable("doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "Kate Mathiasson"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Elvis Mathiasson"
                        },
                        new
                        {
                            Id = 3,
                            FullName = "Neo Winfrey"
                        },
                        new
                        {
                            Id = 4,
                            FullName = "Oprah Presley"
                        },
                        new
                        {
                            Id = 5,
                            FullName = "Felix Mathiasson"
                        },
                        new
                        {
                            Id = 6,
                            FullName = "Elvis Winslow"
                        },
                        new
                        {
                            Id = 7,
                            FullName = "Elvis Andersson"
                        },
                        new
                        {
                            Id = 8,
                            FullName = "Mickey Schwarzenegger"
                        },
                        new
                        {
                            Id = 9,
                            FullName = "Charles Sandler"
                        },
                        new
                        {
                            Id = 10,
                            FullName = "Arnold Presley"
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Medicine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Instruction")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("instructions");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer")
                        .HasColumnName("quantity");

                    b.HasKey("Id");

                    b.ToTable("medicines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Instruction = "Consume with any meal.",
                            Name = "Bad Mushrooms",
                            Quantity = 19
                        },
                        new
                        {
                            Id = 2,
                            Instruction = "Swallow without anything added.",
                            Name = "Crazy Xanax",
                            Quantity = 78
                        },
                        new
                        {
                            Id = 3,
                            Instruction = "Put in coworker's food.",
                            Name = "Super Pills",
                            Quantity = 54
                        },
                        new
                        {
                            Id = 4,
                            Instruction = "Snort before tequila shot.",
                            Name = "Ultra Pills",
                            Quantity = 29
                        },
                        new
                        {
                            Id = 5,
                            Instruction = "Put in coworker's food.",
                            Name = "Crazy Couch drops",
                            Quantity = 3
                        },
                        new
                        {
                            Id = 6,
                            Instruction = "Inject with needle into the bloodstream.",
                            Name = "Blazing Laxatives",
                            Quantity = 77
                        },
                        new
                        {
                            Id = 7,
                            Instruction = "Insert into rectum.",
                            Name = "Super Pills",
                            Quantity = 1
                        },
                        new
                        {
                            Id = 8,
                            Instruction = "Inject with needle into the bloodstream.",
                            Name = "Dangerous Morphine",
                            Quantity = 28
                        },
                        new
                        {
                            Id = 9,
                            Instruction = "Snort before tequila shot.",
                            Name = "Ultra Laxatives",
                            Quantity = 99
                        },
                        new
                        {
                            Id = 10,
                            Instruction = "Hide in cabinet and let the placebo effect do it's job.",
                            Name = "Stupid Laxatives",
                            Quantity = 48
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("fullName");

                    b.HasKey("Id");

                    b.ToTable("patients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "Kate Andersson"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Barack Winfrey"
                        },
                        new
                        {
                            Id = 3,
                            FullName = "Felix Sandler"
                        },
                        new
                        {
                            Id = 4,
                            FullName = "Charles Duck"
                        },
                        new
                        {
                            Id = 5,
                            FullName = "Donald Sandler"
                        },
                        new
                        {
                            Id = 6,
                            FullName = "Donald Schwarzenegger"
                        },
                        new
                        {
                            Id = 7,
                            FullName = "Neo Obama"
                        },
                        new
                        {
                            Id = 8,
                            FullName = "Donald Xavier"
                        },
                        new
                        {
                            Id = 9,
                            FullName = "Barack Sandler"
                        },
                        new
                        {
                            Id = 10,
                            FullName = "Neo Mathiasson"
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Prescription", b =>
                {
                    b.Property<int>("appointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("appointmentId");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("appointmentId"));

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.HasKey("appointmentId");

                    b.ToTable("prescriptions");

                    b.HasData(
                        new
                        {
                            appointmentId = 10,
                            Id = 1
                        },
                        new
                        {
                            appointmentId = 9,
                            Id = 2
                        },
                        new
                        {
                            appointmentId = 8,
                            Id = 3
                        },
                        new
                        {
                            appointmentId = 7,
                            Id = 4
                        },
                        new
                        {
                            appointmentId = 6,
                            Id = 5
                        },
                        new
                        {
                            appointmentId = 5,
                            Id = 6
                        },
                        new
                        {
                            appointmentId = 4,
                            Id = 7
                        },
                        new
                        {
                            appointmentId = 3,
                            Id = 8
                        },
                        new
                        {
                            appointmentId = 2,
                            Id = 9
                        },
                        new
                        {
                            appointmentId = 1,
                            Id = 10
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.PrescriptionMedicine", b =>
                {
                    b.Property<int>("PrescriptionId")
                        .HasColumnType("integer")
                        .HasColumnName("prescription_id");

                    b.Property<int>("MedicineId")
                        .HasColumnType("integer")
                        .HasColumnName("medicine_id");

                    b.HasKey("PrescriptionId", "MedicineId");

                    b.HasIndex("MedicineId");

                    b.ToTable("prescription_medicines");

                    b.HasData(
                        new
                        {
                            PrescriptionId = 2,
                            MedicineId = 1
                        },
                        new
                        {
                            PrescriptionId = 7,
                            MedicineId = 1
                        },
                        new
                        {
                            PrescriptionId = 1,
                            MedicineId = 1
                        },
                        new
                        {
                            PrescriptionId = 1,
                            MedicineId = 2
                        },
                        new
                        {
                            PrescriptionId = 7,
                            MedicineId = 2
                        },
                        new
                        {
                            PrescriptionId = 8,
                            MedicineId = 2
                        },
                        new
                        {
                            PrescriptionId = 7,
                            MedicineId = 3
                        },
                        new
                        {
                            PrescriptionId = 10,
                            MedicineId = 3
                        },
                        new
                        {
                            PrescriptionId = 5,
                            MedicineId = 3
                        },
                        new
                        {
                            PrescriptionId = 2,
                            MedicineId = 4
                        },
                        new
                        {
                            PrescriptionId = 8,
                            MedicineId = 4
                        },
                        new
                        {
                            PrescriptionId = 1,
                            MedicineId = 4
                        },
                        new
                        {
                            PrescriptionId = 10,
                            MedicineId = 5
                        },
                        new
                        {
                            PrescriptionId = 9,
                            MedicineId = 5
                        },
                        new
                        {
                            PrescriptionId = 6,
                            MedicineId = 5
                        },
                        new
                        {
                            PrescriptionId = 7,
                            MedicineId = 6
                        },
                        new
                        {
                            PrescriptionId = 5,
                            MedicineId = 6
                        },
                        new
                        {
                            PrescriptionId = 9,
                            MedicineId = 6
                        },
                        new
                        {
                            PrescriptionId = 4,
                            MedicineId = 7
                        },
                        new
                        {
                            PrescriptionId = 1,
                            MedicineId = 7
                        },
                        new
                        {
                            PrescriptionId = 3,
                            MedicineId = 7
                        },
                        new
                        {
                            PrescriptionId = 3,
                            MedicineId = 8
                        },
                        new
                        {
                            PrescriptionId = 9,
                            MedicineId = 8
                        },
                        new
                        {
                            PrescriptionId = 10,
                            MedicineId = 8
                        },
                        new
                        {
                            PrescriptionId = 9,
                            MedicineId = 9
                        },
                        new
                        {
                            PrescriptionId = 8,
                            MedicineId = 9
                        },
                        new
                        {
                            PrescriptionId = 4,
                            MedicineId = 9
                        },
                        new
                        {
                            PrescriptionId = 5,
                            MedicineId = 10
                        },
                        new
                        {
                            PrescriptionId = 10,
                            MedicineId = 10
                        },
                        new
                        {
                            PrescriptionId = 7,
                            MedicineId = 10
                        });
                });

            modelBuilder.Entity("workshop.wwwapi.Models.PrescriptionMedicine", b =>
                {
                    b.HasOne("workshop.wwwapi.Models.Medicine", "Medicine")
                        .WithMany("PrescriptionMedicines")
                        .HasForeignKey("MedicineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("workshop.wwwapi.Models.Prescription", "Prescription")
                        .WithMany("PrescriptionMedicines")
                        .HasForeignKey("PrescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medicine");

                    b.Navigation("Prescription");
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Medicine", b =>
                {
                    b.Navigation("PrescriptionMedicines");
                });

            modelBuilder.Entity("workshop.wwwapi.Models.Prescription", b =>
                {
                    b.Navigation("PrescriptionMedicines");
                });
#pragma warning restore 612, 618
        }
    }
}
