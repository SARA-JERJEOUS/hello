﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using DALco;

namespace Dal.Migrations
{
    [DbContext(typeof(data_collection))]
    [Migration("20220527120558_iu")]
    partial class iu
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("miide.newdata.disease", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("name_OF_disease")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("diseases_table");
                });

            modelBuilder.Entity("miide.newdata.disease_drug", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("diseaseId")
                        .HasColumnType("int");

                    b.Property<int>("drugId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("diseaseId");

                    b.HasIndex("drugId");

                    b.ToTable("disease_drug_table");
                });

            modelBuilder.Entity("miide.newdata.drug", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Scientific_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("The_number_of_medicine")
                        .HasColumnType("int");

                    b.Property<string>("company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("how_to_use")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("medicine_caliber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("package_size")
                        .HasColumnType("int");

                    b.Property<string>("path_img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("trade_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("drug_table");
                });

            modelBuilder.Entity("miide.newdata.role", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("titel")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("role_table");
                });

            modelBuilder.Entity("miide.newdata.sideDrug", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("drugId")
                        .HasColumnType("int");

                    b.Property<int>("sideeffectId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("drugId");

                    b.HasIndex("sideeffectId");

                    b.ToTable("sideDrug_table");
                });

            modelBuilder.Entity("miide.newdata.sideeffect", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Expiration_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("When_to_consult__doctor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("sideeffect_table");
                });

            modelBuilder.Entity("miide.newdata.sym_disease", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("diseaseId")
                        .HasColumnType("int");

                    b.Property<int>("symptomesId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("diseaseId");

                    b.HasIndex("symptomesId");

                    b.ToTable("sym_disease_table");
                });

            modelBuilder.Entity("miide.newdata.symptomes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("name_of_symptomes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("symptomes_table");
                });

            modelBuilder.Entity("miide.newdata.user", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("phone_number")
                        .HasColumnType("int");

                    b.Property<int>("roleId")
                        .HasColumnType("int");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("roleId");

                    b.ToTable("user_table");
                });

            modelBuilder.Entity("miide.newdata.disease_drug", b =>
                {
                    b.HasOne("miide.newdata.disease", "diseases")
                        .WithMany("disease_drugs")
                        .HasForeignKey("diseaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("miide.newdata.drug", "drugs")
                        .WithMany("disease_drugs")
                        .HasForeignKey("drugId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("diseases");

                    b.Navigation("drugs");
                });

            modelBuilder.Entity("miide.newdata.sideDrug", b =>
                {
                    b.HasOne("miide.newdata.drug", "drugs")
                        .WithMany("sideDrugs")
                        .HasForeignKey("drugId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("miide.newdata.sideeffect", "sideeffects")
                        .WithMany("sideDrugs")
                        .HasForeignKey("sideeffectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("drugs");

                    b.Navigation("sideeffects");
                });

            modelBuilder.Entity("miide.newdata.sym_disease", b =>
                {
                    b.HasOne("miide.newdata.disease", "diseases")
                        .WithMany("symp_disease")
                        .HasForeignKey("diseaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("miide.newdata.symptomes", "symptom")
                        .WithMany("symp_disease")
                        .HasForeignKey("symptomesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("diseases");

                    b.Navigation("symptom");
                });

            modelBuilder.Entity("miide.newdata.user", b =>
                {
                    b.HasOne("miide.newdata.role", "roles")
                        .WithMany("users")
                        .HasForeignKey("roleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("roles");
                });

            modelBuilder.Entity("miide.newdata.disease", b =>
                {
                    b.Navigation("disease_drugs");

                    b.Navigation("symp_disease");
                });

            modelBuilder.Entity("miide.newdata.drug", b =>
                {
                    b.Navigation("disease_drugs");

                    b.Navigation("sideDrugs");
                });

            modelBuilder.Entity("miide.newdata.role", b =>
                {
                    b.Navigation("users");
                });

            modelBuilder.Entity("miide.newdata.sideeffect", b =>
                {
                    b.Navigation("sideDrugs");
                });

            modelBuilder.Entity("miide.newdata.symptomes", b =>
                {
                    b.Navigation("symp_disease");
                });
#pragma warning restore 612, 618
        }
    }
}