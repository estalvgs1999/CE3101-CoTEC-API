﻿// <auto-generated />
using System;
using CotecAPI.DataAccess.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CotecAPI.Migrations
{
    [DbContext(typeof(CotecContext))]
    [Migration("20200618220259_ContactAddress")]
    partial class ContactAddress
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CotecAPI.Models.Admin", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasColumnType("varchar(3)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Username");

                    b.HasIndex("CountryCode");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("CotecAPI.Models.ContactedPerson", b =>
                {
                    b.Property<string>("Dni")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Address")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("varchar(3)");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Dni");

                    b.HasIndex("Region", "Country");

                    b.ToTable("ContactedPersons");
                });

            modelBuilder.Entity("CotecAPI.Models.ContainmentMeasure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("ContainmentMeasures");
                });

            modelBuilder.Entity("CotecAPI.Models.Continent", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("varchar(2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.HasKey("Code");

                    b.ToTable("Continents");
                });

            modelBuilder.Entity("CotecAPI.Models.Country", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("ContinentCode")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("FlagUrl")
                        .HasColumnType("varchar(45)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.HasKey("Code");

                    b.HasIndex("ContinentCode");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("CotecAPI.Models.CountryContainmentMeasures", b =>
                {
                    b.Property<string>("CountryCode")
                        .HasColumnType("varchar(3)");

                    b.Property<int>("MeasureId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.HasKey("CountryCode", "MeasureId");

                    b.HasIndex("MeasureId");

                    b.ToTable("CountryContainmentMeasures");
                });

            modelBuilder.Entity("CotecAPI.Models.CountrySanitaryMeasures", b =>
                {
                    b.Property<string>("CountryCode")
                        .HasColumnType("varchar(3)");

                    b.Property<int>("MeasureId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.HasKey("CountryCode", "MeasureId");

                    b.HasIndex("MeasureId");

                    b.ToTable("CountrySanitaryMeasures");
                });

            modelBuilder.Entity("CotecAPI.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasColumnType("varchar(3)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("CountryCode");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("CotecAPI.Models.Hospital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("varchar(3)");

                    b.Property<int>("ICU_Capacity")
                        .HasColumnType("int");

                    b.Property<string>("ManagerName")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Region", "Country");

                    b.ToTable("Hospitals");
                });

            modelBuilder.Entity("CotecAPI.Models.HospitalEmployee", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Hospital_Id")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Username");

                    b.HasIndex("Hospital_Id");

                    b.ToTable("HospitalEmployees");
                });

            modelBuilder.Entity("CotecAPI.Models.Medication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.Property<int>("PharmaceuticCo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PharmaceuticCo");

                    b.ToTable("Medications");
                });

            modelBuilder.Entity("CotecAPI.Models.Pathology", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Symptoms")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Treatment")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Name");

                    b.ToTable("Pathologies");
                });

            modelBuilder.Entity("CotecAPI.Models.Patient", b =>
                {
                    b.Property<string>("Dni")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("varchar(3)");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("date");

                    b.Property<int>("Hospital_Id")
                        .HasColumnType("int");

                    b.Property<bool>("Hospitalized")
                        .HasColumnType("bit");

                    b.Property<bool>("ICU")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Dni");

                    b.HasIndex("Hospital_Id");

                    b.HasIndex("Status");

                    b.HasIndex("Region", "Country");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("CotecAPI.Models.PatientMedications", b =>
                {
                    b.Property<int>("MedicationId")
                        .HasColumnType("int");

                    b.Property<string>("PatientDni")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Prescription")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("MedicationId", "PatientDni");

                    b.HasIndex("PatientDni");

                    b.ToTable("PatientMedications");
                });

            modelBuilder.Entity("CotecAPI.Models.PatientPathologies", b =>
                {
                    b.Property<string>("PathologyName")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PatientDni")
                        .HasColumnType("varchar(30)");

                    b.HasKey("PathologyName", "PatientDni");

                    b.HasIndex("PatientDni");

                    b.ToTable("PatientPathologies");
                });

            modelBuilder.Entity("CotecAPI.Models.PatientStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("PatientStatus");
                });

            modelBuilder.Entity("CotecAPI.Models.PersonPathologies", b =>
                {
                    b.Property<string>("PathologyName")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PersonDni")
                        .HasColumnType("varchar(30)");

                    b.HasKey("PathologyName", "PersonDni");

                    b.HasIndex("PersonDni");

                    b.ToTable("PersonPathologies");
                });

            modelBuilder.Entity("CotecAPI.Models.PersonsContactedByPatient", b =>
                {
                    b.Property<string>("ContactDni")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("PatientDni")
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime?>("MeetingDate")
                        .HasColumnType("date");

                    b.HasKey("ContactDni", "PatientDni");

                    b.HasIndex("PatientDni");

                    b.ToTable("PersonsContactedByPatient");
                });

            modelBuilder.Entity("CotecAPI.Models.PharmaceuticalCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.HasKey("Id");

                    b.ToTable("PharmaceuticalCompanies");
                });

            modelBuilder.Entity("CotecAPI.Models.Region", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CountryCode")
                        .HasColumnType("varchar(3)");

                    b.HasKey("Name", "CountryCode");

                    b.HasIndex("CountryCode");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("CotecAPI.Models.SanitaryMeasure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("SanitaryMeasures");
                });

            modelBuilder.Entity("CotecAPI.Models.Admin", b =>
                {
                    b.HasOne("CotecAPI.Models.Country", "Country")
                        .WithMany("Admins")
                        .HasForeignKey("CountryCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CotecAPI.Models.ContactedPerson", b =>
                {
                    b.HasOne("CotecAPI.Models.Region", "PersonRegion")
                        .WithMany("ContactedPersons")
                        .HasForeignKey("Region", "Country")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("CotecAPI.Models.Country", b =>
                {
                    b.HasOne("CotecAPI.Models.Continent", "Continent")
                        .WithMany("Countries")
                        .HasForeignKey("ContinentCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CotecAPI.Models.CountryContainmentMeasures", b =>
                {
                    b.HasOne("CotecAPI.Models.Country", "Country")
                        .WithMany("ImplementedContainmentMeasures")
                        .HasForeignKey("CountryCode")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CotecAPI.Models.ContainmentMeasure", "Measure")
                        .WithMany("ImplementedMeasures")
                        .HasForeignKey("MeasureId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("CotecAPI.Models.CountrySanitaryMeasures", b =>
                {
                    b.HasOne("CotecAPI.Models.Country", "Country")
                        .WithMany("ImplementedSanitaryMeasures")
                        .HasForeignKey("CountryCode")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CotecAPI.Models.SanitaryMeasure", "Measure")
                        .WithMany("ImplementedMeasures")
                        .HasForeignKey("MeasureId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("CotecAPI.Models.Event", b =>
                {
                    b.HasOne("CotecAPI.Models.Country", "Country")
                        .WithMany("CountryEvents")
                        .HasForeignKey("CountryCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CotecAPI.Models.Hospital", b =>
                {
                    b.HasOne("CotecAPI.Models.Region", "HRegion")
                        .WithMany("Hospitals")
                        .HasForeignKey("Region", "Country")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("CotecAPI.Models.HospitalEmployee", b =>
                {
                    b.HasOne("CotecAPI.Models.Hospital", "Hospital")
                        .WithMany("Employees")
                        .HasForeignKey("Hospital_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CotecAPI.Models.Medication", b =>
                {
                    b.HasOne("CotecAPI.Models.PharmaceuticalCompany", "PCompany")
                        .WithMany("Madications")
                        .HasForeignKey("PharmaceuticCo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CotecAPI.Models.Patient", b =>
                {
                    b.HasOne("CotecAPI.Models.Hospital", "Hospital")
                        .WithMany("Patients")
                        .HasForeignKey("Hospital_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CotecAPI.Models.PatientStatus", "PatientStatus")
                        .WithMany("Patients")
                        .HasForeignKey("Status")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CotecAPI.Models.Region", "PatientRegion")
                        .WithMany("Patients")
                        .HasForeignKey("Region", "Country")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("CotecAPI.Models.PatientMedications", b =>
                {
                    b.HasOne("CotecAPI.Models.Medication", "Medication")
                        .WithMany("PatientMedications")
                        .HasForeignKey("MedicationId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CotecAPI.Models.Patient", "Patient")
                        .WithMany("Medications")
                        .HasForeignKey("PatientDni")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("CotecAPI.Models.PatientPathologies", b =>
                {
                    b.HasOne("CotecAPI.Models.Pathology", "Pathology")
                        .WithMany("PatientPathologies")
                        .HasForeignKey("PathologyName")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CotecAPI.Models.Patient", "Patient")
                        .WithMany("Pathologies")
                        .HasForeignKey("PatientDni")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("CotecAPI.Models.PersonPathologies", b =>
                {
                    b.HasOne("CotecAPI.Models.Pathology", "Pathology")
                        .WithMany("PersonPathologies")
                        .HasForeignKey("PathologyName")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CotecAPI.Models.ContactedPerson", "Contacted")
                        .WithMany("Pathologies")
                        .HasForeignKey("PersonDni")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("CotecAPI.Models.PersonsContactedByPatient", b =>
                {
                    b.HasOne("CotecAPI.Models.ContactedPerson", "Contacted")
                        .WithMany("ContactedPatients")
                        .HasForeignKey("ContactDni")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CotecAPI.Models.Patient", "Patient")
                        .WithMany("ContactedPersons")
                        .HasForeignKey("PatientDni")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("CotecAPI.Models.Region", b =>
                {
                    b.HasOne("CotecAPI.Models.Country", "Country")
                        .WithMany("Regions")
                        .HasForeignKey("CountryCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
