﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.Persistence;

#nullable disable

namespace Server.Migrations
{
    [DbContext(typeof(ServerDbContext))]
    partial class ServerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("Server.Models.Cards.CardProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccessCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ChipId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("DistinctTeamFormationToken")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsNewCard")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuickOnlinePartnerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SessionId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("UploadToken")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UploadTokenExpiry")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("card_profile");
                });

            modelBuilder.Entity("Server.Models.Cards.OfflinePvpBattleResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("EchelonExpChange")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("EchelonIdAfterBattle")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("ElapsedSecond")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("Foe1BurstType")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("Foe1EchelonId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Foe1Indicator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<uint>("Foe1MsId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("Foe1PilotId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("Foe2BurstType")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("Foe2EchelonId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Foe2Indicator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<uint>("Foe2MsId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("Foe2PilotId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FullBattleResultJson")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Mode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OfflineBattleMode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<uint>("PartnerBurstType")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("PartnerEchelonId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PartnerIndicator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<uint>("PartnerMsId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("PartnerPilotId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("PastEchelonId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("SEchelonFlag")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("SEchelonProgress")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("Score")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TotalEchelonExp")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.Property<uint>("UsedBurstType")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("UsedMsId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("WinFlag")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.ToTable("offline_pvp_battle_result");
                });

            modelBuilder.Entity("Server.Models.Cards.OnlinePair", b =>
                {
                    b.Property<int>("PairId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeammateCardId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PairId");

                    b.HasIndex("CardId");

                    b.ToTable("online_pair");
                });

            modelBuilder.Entity("Server.Models.Cards.PilotDomain", b =>
                {
                    b.Property<int>("PilotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoadPlayerJson")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PilotDataGroupJson")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("PilotId");

                    b.HasIndex("CardId")
                        .IsUnique();

                    b.ToTable("pilot_domain");
                });

            modelBuilder.Entity("Server.Models.Cards.Snapshot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("SnapshotData")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SnapshotType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("snapshot");
                });

            modelBuilder.Entity("Server.Models.Cards.TagTeamData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<uint>("BackgroundPartsId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("BgmId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<uint>("EffectId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("EmblemId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("NameColorId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("SkillPoint")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("SkillPointBoost")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<uint>("TeammateCardId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.ToTable("tag_team_data");
                });

            modelBuilder.Entity("Server.Models.Cards.TriadBattleResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("CourseId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("EchelonExpChange")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("EchelonIdAfterBattle")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("ElapsedSecond")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FullBattleResultJson")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Mode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<uint>("PastEchelonId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("SceneId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("Score")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TotalEchelonExp")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.Property<uint>("UsedBurstType")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("UsedMsId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("WinFlag")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.ToTable("triad_battle_result");
                });

            modelBuilder.Entity("Server.Models.Cards.UploadImage", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Filename")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("ImageId");

                    b.HasIndex("CardId");

                    b.ToTable("upload_image");
                });

            modelBuilder.Entity("Server.Models.Cards.UploadReplay", b =>
                {
                    b.Property<int>("ReplayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Filename")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<uint>("MatchingMode")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("MobileUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PilotsJson")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<ulong>("PlayedAt")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ReplayServiceFlag")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("ReplaySize")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ReturnMatchFlag")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("SpecialFlag")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("StageId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("TeamType")
                        .HasColumnType("INTEGER");

                    b.Property<uint?>("TournamentId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("ReplayId");

                    b.HasIndex("CardId");

                    b.ToTable("upload_replay");
                });

            modelBuilder.Entity("Server.Models.Cards.UserDomain", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("MobileUserGroupJson")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserJson")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.HasIndex("CardId")
                        .IsUnique();

                    b.ToTable("user_domain");
                });

            modelBuilder.Entity("Server.Models.Cards.OfflinePvpBattleResult", b =>
                {
                    b.HasOne("Server.Models.Cards.CardProfile", "CardProfile")
                        .WithMany("OfflinePvpBattleResults")
                        .HasForeignKey("CardId");

                    b.Navigation("CardProfile");
                });

            modelBuilder.Entity("Server.Models.Cards.OnlinePair", b =>
                {
                    b.HasOne("Server.Models.Cards.CardProfile", "CardProfile")
                        .WithMany("OnlinePairs")
                        .HasForeignKey("CardId");

                    b.Navigation("CardProfile");
                });

            modelBuilder.Entity("Server.Models.Cards.PilotDomain", b =>
                {
                    b.HasOne("Server.Models.Cards.CardProfile", "CardProfile")
                        .WithOne("PilotDomain")
                        .HasForeignKey("Server.Models.Cards.PilotDomain", "CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CardProfile");
                });

            modelBuilder.Entity("Server.Models.Cards.TagTeamData", b =>
                {
                    b.HasOne("Server.Models.Cards.CardProfile", "CardProfile")
                        .WithMany("TagTeamDataList")
                        .HasForeignKey("CardId");

                    b.Navigation("CardProfile");
                });

            modelBuilder.Entity("Server.Models.Cards.TriadBattleResult", b =>
                {
                    b.HasOne("Server.Models.Cards.CardProfile", "CardProfile")
                        .WithMany("TriadBattleResults")
                        .HasForeignKey("CardId");

                    b.Navigation("CardProfile");
                });

            modelBuilder.Entity("Server.Models.Cards.UploadImage", b =>
                {
                    b.HasOne("Server.Models.Cards.CardProfile", "CardProfile")
                        .WithMany("UploadImages")
                        .HasForeignKey("CardId");

                    b.Navigation("CardProfile");
                });

            modelBuilder.Entity("Server.Models.Cards.UploadReplay", b =>
                {
                    b.HasOne("Server.Models.Cards.CardProfile", "CardProfile")
                        .WithMany("UploadReplays")
                        .HasForeignKey("CardId");

                    b.Navigation("CardProfile");
                });

            modelBuilder.Entity("Server.Models.Cards.UserDomain", b =>
                {
                    b.HasOne("Server.Models.Cards.CardProfile", "CardProfile")
                        .WithOne("UserDomain")
                        .HasForeignKey("Server.Models.Cards.UserDomain", "CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CardProfile");
                });

            modelBuilder.Entity("Server.Models.Cards.CardProfile", b =>
                {
                    b.Navigation("OfflinePvpBattleResults");

                    b.Navigation("OnlinePairs");

                    b.Navigation("PilotDomain")
                        .IsRequired();

                    b.Navigation("TagTeamDataList");

                    b.Navigation("TriadBattleResults");

                    b.Navigation("UploadImages");

                    b.Navigation("UploadReplays");

                    b.Navigation("UserDomain")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
