﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Storage.Internal;
using Project.Infrastructure;
using System;

namespace Project.API.Migrations
{
    [DbContext(typeof(ProjectContext))]
    partial class ProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("Project.Domain.AggregatesModel.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AreaId");

                    b.Property<string>("AreaName");

                    b.Property<string>("Avatar");

                    b.Property<string>("BrokerageOption");

                    b.Property<string>("CityId");

                    b.Property<string>("CityName");

                    b.Property<string>("Company");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("FinMoney");

                    b.Property<int>("FinPercentage");

                    b.Property<int>("FinStage");

                    b.Property<string>("FormatBPFile");

                    b.Property<int>("Income");

                    b.Property<string>("Introduction");

                    b.Property<string>("OriginBPFile");

                    b.Property<string>("ProvinceId");

                    b.Property<string>("ProvinceName");

                    b.Property<int>("ReferenceId");

                    b.Property<DateTime>("RegisterTime");

                    b.Property<int>("Revenue");

                    b.Property<int>("SourceId");

                    b.Property<string>("Tags");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<int>("UserId");

                    b.Property<string>("Valution");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Project.Domain.AggregatesModel.ProjectContributor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Avatar");

                    b.Property<int>("ContributorType");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("IsCloser");

                    b.Property<int>("ProjectId");

                    b.Property<int>("UserId");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectContributors");
                });

            modelBuilder.Entity("Project.Domain.AggregatesModel.ProjectProperty", b =>
                {
                    b.Property<string>("Key")
                        .HasMaxLength(100);

                    b.Property<int>("ProjectId");

                    b.Property<string>("Value")
                        .HasMaxLength(100);

                    b.Property<string>("Text");

                    b.HasKey("Key", "ProjectId", "Value");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectProperties");
                });

            modelBuilder.Entity("Project.Domain.AggregatesModel.ProjectViewer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Avatar");

                    b.Property<int>("ProjectId");

                    b.Property<int>("UserId");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectViewers");
                });

            modelBuilder.Entity("Project.Domain.AggregatesModel.ProjectVisibleRules", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProjectId");

                    b.Property<string>("Tags");

                    b.Property<bool>("Visible");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectVisibleRules");
                });

            modelBuilder.Entity("Project.Domain.AggregatesModel.ProjectContributor", b =>
                {
                    b.HasOne("Project.Domain.AggregatesModel.Project")
                        .WithMany("Contributors")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Project.Domain.AggregatesModel.ProjectProperty", b =>
                {
                    b.HasOne("Project.Domain.AggregatesModel.Project")
                        .WithMany("Properties")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Project.Domain.AggregatesModel.ProjectViewer", b =>
                {
                    b.HasOne("Project.Domain.AggregatesModel.Project")
                        .WithMany("Viewers")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Project.Domain.AggregatesModel.ProjectVisibleRules", b =>
                {
                    b.HasOne("Project.Domain.AggregatesModel.Project")
                        .WithMany("ProjectVisibleRule")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
