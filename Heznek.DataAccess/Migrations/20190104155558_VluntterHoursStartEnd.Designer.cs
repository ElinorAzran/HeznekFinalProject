﻿// <auto-generated />
using Heznek.Common.Enums;
using Heznek.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Heznek.DataAccess.Migrations
{
    [DbContext(typeof(HeznekDbContext))]
    [Migration("20190104155558_VluntterHoursStartEnd")]
    partial class VluntterHoursStartEnd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Heznek.DataAccess.Entities.AcademicStudiesEntity", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("AcademicDegree");

                    b.Property<string>("AcademicInstitution");

                    b.Property<string>("AprovalDownloadName");

                    b.Property<string>("AprovalFileName");

                    b.Property<string>("FieldOfStudy");

                    b.Property<string>("GradesDownloadName");

                    b.Property<string>("GradesFileName");

                    b.Property<int?>("GraduationYear");

                    b.Property<int?>("Residence");

                    b.HasKey("Id");

                    b.ToTable("AcademicStudies");
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.BankInfoEntity", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("AccountNumber")
                        .IsRequired();

                    b.Property<string>("BankName")
                        .IsRequired();

                    b.Property<string>("BranchNumber")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("BanksInfo");
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.CandidateAdditionalDataEntity", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Difficulties");

                    b.Property<string>("FamilyDifficulties");

                    b.Property<string>("FinancialProblems");

                    b.Property<bool>("HasFamilyDifficulties");

                    b.Property<bool>("HasFinancialProblems");

                    b.Property<bool>("HasHealthProblems");

                    b.Property<string>("HealthProblems");

                    b.Property<string>("LifeStory");

                    b.Property<string>("ParticipationDescription");

                    b.Property<string>("Reason");

                    b.Property<string>("SituationDetails");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.ToTable("CandidateAdditionalData");
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.ConfirmationEntity", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<DateTime?>("ConfirmDate");

                    b.Property<bool>("Confirmed");

                    b.HasKey("Id");

                    b.ToTable("Confirmations");
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.ForgotPaswordTokenEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<DateTime>("ExpireTime");

                    b.Property<bool>("Used");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ForgotPaswordTokens");
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.FormEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Forms");
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.FormParentsSalaryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Disability");

                    b.Property<string>("DisabilityDownloadName");

                    b.Property<string>("FatherName");

                    b.Property<int>("FormId");

                    b.Property<DateTime?>("LastUpdated");

                    b.Property<string>("MotherName");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("Parent");

                    b.Property<string>("SalarySlips");

                    b.Property<string>("SalarySlipsDownloadName");

                    b.HasKey("Id");

                    b.HasIndex("FormId")
                        .IsUnique();

                    b.ToTable("FormsParentsSalary");
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.FormTaskEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DownloadName");

                    b.Property<string>("FileName");

                    b.Property<int>("FormId");

                    b.Property<DateTime?>("LastUpdated");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("FormId");

                    b.ToTable("FormTasks");
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.GeneralEntity", b =>
                {
                    b.Property<int>("Id");

                    b.Property<bool>("Disabilities");

                    b.Property<int>("Points")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("PsychometricGrade")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<bool>("WorthyOfAdvancment");

                    b.HasKey("Id");

                    b.ToTable("Generals");
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.GeneralParticipationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("GeneralId");

                    b.Property<int>("ProgramId");

                    b.HasKey("Id");

                    b.HasIndex("GeneralId");

                    b.HasIndex("ProgramId");

                    b.ToTable("GeneralsParticipations");
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.HighSchoolEntity", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Name");

                    b.Property<int?>("Year");

                    b.HasKey("Id");

                    b.ToTable("HighSchools");
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.MilitaryServiceEntity", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Details");

                    b.Property<string>("Ease");

                    b.Property<bool>("EaseOfService");

                    b.Property<string>("Role");

                    b.Property<int?>("TypeOfSevice");

                    b.HasKey("Id");

                    b.ToTable("MilitaryServices");
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.ParticipationProgramEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ProgramName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("ParticipationPrograms");
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.ProfileEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AcademicParents")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("Address");

                    b.Property<DateTime?>("BirthDate");

                    b.Property<string>("City");

                    b.Property<int?>("Gender");

                    b.Property<string>("Phone");

                    b.Property<int>("Siblings")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.ScholarDetailsEntity", b =>
                {
                    b.Property<int>("Id");

                    b.Property<decimal>("Amount");

                    b.Property<bool>("Budgeting");

                    b.Property<bool>("Refund");

                    b.HasKey("Id");

                    b.ToTable("ScholarDetails");
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.ScholarshipEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Admission")
                        .IsRequired();

                    b.Property<decimal>("Budget");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Scholarship");
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.StudentScholarshipEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("April");

                    b.Property<decimal>("August");

                    b.Property<decimal>("December");

                    b.Property<decimal>("February");

                    b.Property<decimal>("January");

                    b.Property<decimal>("July");

                    b.Property<decimal>("June");

                    b.Property<decimal>("March");

                    b.Property<decimal>("May");

                    b.Property<decimal>("November");

                    b.Property<decimal>("October");

                    b.Property<int>("ProfileId");

                    b.Property<int>("ScholarshipId");

                    b.Property<decimal>("September");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.HasIndex("ScholarshipId");

                    b.ToTable("StudentsScholarships");
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.UserEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<int>("Role");

                    b.Property<string>("Salt")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.VolunteerDetailsEntity", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Contribution");

                    b.Property<int>("Hours");

                    b.HasKey("Id");

                    b.ToTable("VolunteerDetails");
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.VolunteerHoursEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ActivityType");

                    b.Property<DateTime>("Date");

                    b.Property<string>("End")
                        .IsRequired();

                    b.Property<int>("ProfileId");

                    b.Property<int>("Semester");

                    b.Property<string>("Start")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("VolunteerHours");
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.AcademicStudiesEntity", b =>
                {
                    b.HasOne("Heznek.DataAccess.Entities.ProfileEntity", "Profile")
                        .WithOne("AcademicStudies")
                        .HasForeignKey("Heznek.DataAccess.Entities.AcademicStudiesEntity", "Id")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.BankInfoEntity", b =>
                {
                    b.HasOne("Heznek.DataAccess.Entities.ProfileEntity", "Profile")
                        .WithOne("BankInfo")
                        .HasForeignKey("Heznek.DataAccess.Entities.BankInfoEntity", "Id")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.CandidateAdditionalDataEntity", b =>
                {
                    b.HasOne("Heznek.DataAccess.Entities.ProfileEntity", "Profile")
                        .WithOne("CandidateAdditionalData")
                        .HasForeignKey("Heznek.DataAccess.Entities.CandidateAdditionalDataEntity", "Id")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.ConfirmationEntity", b =>
                {
                    b.HasOne("Heznek.DataAccess.Entities.UserEntity", "User")
                        .WithOne("Confirmation")
                        .HasForeignKey("Heznek.DataAccess.Entities.ConfirmationEntity", "Id")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.ForgotPaswordTokenEntity", b =>
                {
                    b.HasOne("Heznek.DataAccess.Entities.UserEntity", "User")
                        .WithMany("ForgotPaswordTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.FormEntity", b =>
                {
                    b.HasOne("Heznek.DataAccess.Entities.UserEntity", "User")
                        .WithOne("Form")
                        .HasForeignKey("Heznek.DataAccess.Entities.FormEntity", "UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.FormParentsSalaryEntity", b =>
                {
                    b.HasOne("Heznek.DataAccess.Entities.FormEntity", "Form")
                        .WithOne("ParentsSalary")
                        .HasForeignKey("Heznek.DataAccess.Entities.FormParentsSalaryEntity", "FormId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.FormTaskEntity", b =>
                {
                    b.HasOne("Heznek.DataAccess.Entities.FormEntity", "Form")
                        .WithMany("Tasks")
                        .HasForeignKey("FormId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.GeneralEntity", b =>
                {
                    b.HasOne("Heznek.DataAccess.Entities.ProfileEntity", "Profile")
                        .WithOne("General")
                        .HasForeignKey("Heznek.DataAccess.Entities.GeneralEntity", "Id")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.GeneralParticipationEntity", b =>
                {
                    b.HasOne("Heznek.DataAccess.Entities.GeneralEntity", "General")
                        .WithMany("Participations")
                        .HasForeignKey("GeneralId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Heznek.DataAccess.Entities.ParticipationProgramEntity", "Program")
                        .WithMany("Generals")
                        .HasForeignKey("ProgramId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.HighSchoolEntity", b =>
                {
                    b.HasOne("Heznek.DataAccess.Entities.ProfileEntity", "Profile")
                        .WithOne("HighSchool")
                        .HasForeignKey("Heznek.DataAccess.Entities.HighSchoolEntity", "Id")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.MilitaryServiceEntity", b =>
                {
                    b.HasOne("Heznek.DataAccess.Entities.ProfileEntity", "Profile")
                        .WithOne("MilitaryService")
                        .HasForeignKey("Heznek.DataAccess.Entities.MilitaryServiceEntity", "Id")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.ProfileEntity", b =>
                {
                    b.HasOne("Heznek.DataAccess.Entities.UserEntity", "User")
                        .WithOne("Profile")
                        .HasForeignKey("Heznek.DataAccess.Entities.ProfileEntity", "UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.ScholarDetailsEntity", b =>
                {
                    b.HasOne("Heznek.DataAccess.Entities.ProfileEntity", "Profile")
                        .WithOne("ScholarDetails")
                        .HasForeignKey("Heznek.DataAccess.Entities.ScholarDetailsEntity", "Id")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.StudentScholarshipEntity", b =>
                {
                    b.HasOne("Heznek.DataAccess.Entities.ProfileEntity", "Profile")
                        .WithMany("Scholarships")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Heznek.DataAccess.Entities.ScholarshipEntity", "Scholarship")
                        .WithMany("Students")
                        .HasForeignKey("ScholarshipId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.VolunteerDetailsEntity", b =>
                {
                    b.HasOne("Heznek.DataAccess.Entities.ProfileEntity", "Profile")
                        .WithOne("VolunteerDetails")
                        .HasForeignKey("Heznek.DataAccess.Entities.VolunteerDetailsEntity", "Id")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Heznek.DataAccess.Entities.VolunteerHoursEntity", b =>
                {
                    b.HasOne("Heznek.DataAccess.Entities.ProfileEntity", "Profile")
                        .WithMany("VolunteerHours")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
