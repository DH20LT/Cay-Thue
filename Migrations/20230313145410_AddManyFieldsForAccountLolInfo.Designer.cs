﻿// <auto-generated />
using System;
using CayThue.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CayThue.Migrations
{
    [DbContext(typeof(CayThueDbContext))]
    [Migration("20230313145410_AddManyFieldsForAccountLolInfo")]
    partial class AddManyFieldsForAccountLolInfo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("CayThue.Models.AccountLolInfos.AccountLolInfo", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int?>("AccountCreatedAt")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("AccountId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("AvailableBlueEssence")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AvailableRiotPoints")
                        .HasColumnType("TEXT");

                    b.Property<string>("Champions")
                        .HasColumnType("TEXT");

                    b.Property<string>("Chroma")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateUpdateAccount")
                        .HasColumnType("TEXT");

                    b.Property<string>("Emotes")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstServerOfAccount")
                        .HasColumnType("TEXT");

                    b.Property<string>("Honor")
                        .HasColumnType("TEXT");

                    b.Property<string>("Level")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("OffineTime")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Prestige")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PrevSeasonFlex")
                        .HasColumnType("TEXT");

                    b.Property<string>("PrevSeasonSoloDuo")
                        .HasColumnType("TEXT");

                    b.Property<string>("RankFlex")
                        .HasColumnType("TEXT");

                    b.Property<string>("RankSoloDuo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Server")
                        .HasColumnType("TEXT");

                    b.Property<string>("Skins")
                        .HasColumnType("TEXT");

                    b.Property<string>("SumIcons")
                        .HasColumnType("TEXT");

                    b.Property<string>("WardSkins")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AccountLolInfos");
                });

            modelBuilder.Entity("CayThue.Models.Accounts.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("ID");

                    b.Property<bool?>("CanChangeInfo")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("GameId")
                        .HasColumnType("TEXT")
                        .HasColumnName("GameID");

                    b.Property<bool?>("IsSold")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("IsVerify")
                        .HasColumnType("INTEGER");

                    b.Property<float?>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Views")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("CayThue.Models.Games.Game", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("ID");

                    b.Property<string>("Code")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("CayThue.Models.Library.Rank", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Library.Rank");
                });

            modelBuilder.Entity("CayThue.Models.PaymentHistory.Payment", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<float?>("Amount")
                        .HasColumnType("REAL");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mac")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("PaymentType")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PaymentHistory");
                });

            modelBuilder.Entity("CayThue.Models.TradeHistory.Trade", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("ID");

                    b.Property<Guid?>("AccountId")
                        .HasColumnType("TEXT");

                    b.Property<float?>("Amount")
                        .HasColumnType("REAL");

                    b.Property<Guid?>("BuyerId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CancellationDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("CancellationReason")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CommentByBuyer")
                        .HasColumnType("TEXT");

                    b.Property<string>("CommentBySeller")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CompletionDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mac")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PaymentStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PaymentType")
                        .HasColumnType("TEXT");

                    b.Property<int?>("RateByBuyer")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("RateBySeller")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("SellerId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("TradeHistory");
                });

            modelBuilder.Entity("CayThue.Models.Users.User", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Currency")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Reputation")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}