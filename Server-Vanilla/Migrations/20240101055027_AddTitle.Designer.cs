﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServerVanilla.Persistence;

#nullable disable

namespace ServerVanilla.Migrations
{
    [DbContext(typeof(ServerDbContext))]
    [Migration("20240101055027_AddTitle")]
    partial class AddTitle
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("ServerVanilla.Models.Cards.CardProfile", b =>
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

                    b.Property<uint>("Gp")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsNewCard")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("LastPlayedAt")
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

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("exvs2_card_profile");
                });

            modelBuilder.Entity("ServerVanilla.Models.Cards.MobileSuit.FavouriteMobileSuit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<uint>("BattleNavId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("BgmPlayMethod")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BgmSettings")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<uint>("BurstType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<uint>("GaugeDesignId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("MstMobileSuitId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("OpenSkillpoint")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("Id");

                    b.HasIndex("CardId", "MstMobileSuitId");

                    b.ToTable("exvs2_favourite_ms");
                });

            modelBuilder.Entity("ServerVanilla.Models.Cards.MobileSuit.MobileSuitUsage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("CostumeId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<uint>("MsUsedNum")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("MstMobileSuitId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("Id");

                    b.HasIndex("CardId", "MstMobileSuitId");

                    b.ToTable("exvs2_ms_usage");
                });

            modelBuilder.Entity("ServerVanilla.Models.Cards.Navi.Navi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<uint>("BattleNavRemains")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("BattleNavSettingFlag")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<uint>("GuestNavCostume")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("GuestNavFamiliarity")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("GuestNavId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("GuestNavRemains")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("GuestNavSettingFlag")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("NewCostumeFlag")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("Id");

                    b.HasIndex("CardId", "GuestNavId");

                    b.ToTable("exvs2_navi");
                });

            modelBuilder.Entity("ServerVanilla.Models.Cards.Profile.BattleProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("EchelonExp")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("EchelonId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MatchingCorrectionSolo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MatchingCorrectionTeam")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("SBrigadierFlag")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("SCaptainFlag")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("SEchelonFlag")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("SEchelonMissionFlag")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("SEchelonProgress")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("ShuffleLose")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("ShuffleWin")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SoloRankPoint")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("TeamLose")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeamRankPoint")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("TeamWin")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("TotalLose")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("TotalWin")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.Property<uint>("VsmAfterRankUp")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CardId")
                        .IsUnique();

                    b.HasIndex("Id");

                    b.ToTable("exvs2_battle_profile");
                });

            modelBuilder.Entity("ServerVanilla.Models.Cards.Profile.CustomizeProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<uint>("BasePanelId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("CommentPartsAId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("CommentPartsBId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<uint>("DefaultBgmPlayMethod")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DefaultBgmSettings")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<uint>("DefaultGaugeDesignId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StageRandoms")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CardId")
                        .IsUnique();

                    b.HasIndex("Id");

                    b.ToTable("exvs2_customize_profile");
                });

            modelBuilder.Entity("ServerVanilla.Models.Cards.Profile.PlayerProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<uint>("OpenEchelon")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("OpenRecord")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("OpenSkillpoint")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CardId")
                        .IsUnique();

                    b.HasIndex("Id");

                    b.ToTable("exvs2_player_profile");
                });

            modelBuilder.Entity("ServerVanilla.Models.Cards.Profile.TrainingProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<uint>("BurstType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("CpuLevel")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<bool>("DamageDisplay")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("ExBurstGauge")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("MstMobileSuitId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CardId")
                        .IsUnique();

                    b.HasIndex("Id");

                    b.ToTable("exvs2_training_profile");
                });

            modelBuilder.Entity("ServerVanilla.Models.Cards.Settings.BoostSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<uint>("GpBoost")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("GuestNavBoost")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CardId")
                        .IsUnique();

                    b.HasIndex("Id");

                    b.ToTable("exvs2_boost_setting");
                });

            modelBuilder.Entity("ServerVanilla.Models.Cards.Settings.NaviSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("BattleNavAdviseFlag")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("BattleNavNotifyFlag")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CardId")
                        .IsUnique();

                    b.HasIndex("Id");

                    b.ToTable("exvs2_navi_setting");
                });

            modelBuilder.Entity("ServerVanilla.Models.Cards.Team.TagTeamData", b =>
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

                    b.Property<int>("OnlineRankPoint")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("SkillPoint")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("SkillPointBoost")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("TagRate")
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

                    b.HasIndex("Id");

                    b.ToTable("exvs2_tag_team_data");
                });

            modelBuilder.Entity("ServerVanilla.Models.Cards.Title.DefaultTitle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<uint>("TitleBackgroundPartsId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("TitleEffectId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("TitleOrnamentId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("TitleTextId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CardId")
                        .IsUnique();

                    b.HasIndex("Id");

                    b.ToTable("exvs2_default_title");
                });

            modelBuilder.Entity("ServerVanilla.Models.Cards.Triad.TriadCourseData", b =>
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

                    b.Property<uint>("Highscore")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("ReleasedAt")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("TotalClearNum")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("TotalPlayNum")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("CardId", "CourseId");

                    b.ToTable("exvs2_triad_course_data");
                });

            modelBuilder.Entity("ServerVanilla.Models.Cards.Triad.TriadMiscInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CpuRibbons")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<uint>("TotalTriadScenePlayNum")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("TotalTriadScore")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("TotalTriadWantedDefeatNum")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CardId")
                        .IsUnique();

                    b.HasIndex("Id");

                    b.ToTable("exvs2_triad_misc_info");
                });

            modelBuilder.Entity("ServerVanilla.Models.Cards.Triad.TriadPartner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<uint>("AiLevel")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("ArmorLevel")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("BoosterLevel")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("BurstType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<uint>("ExGaugeLevel")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("InfightAttackLevel")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("MsSkill1")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("MsSkill2")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("MstMobileSuitId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("ShootAttackLevel")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CardId")
                        .IsUnique();

                    b.HasIndex("Id");

                    b.ToTable("exvs2_triad_partner");
                });

            modelBuilder.Entity("ServerVanilla.Models.Cards.MobileSuit.FavouriteMobileSuit", b =>
                {
                    b.HasOne("ServerVanilla.Models.Cards.CardProfile", "CardProfile")
                        .WithMany("FavouriteMobileSuits")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.ClientCascade);

                    b.Navigation("CardProfile");
                });

            modelBuilder.Entity("ServerVanilla.Models.Cards.MobileSuit.MobileSuitUsage", b =>
                {
                    b.HasOne("ServerVanilla.Models.Cards.CardProfile", "CardProfile")
                        .WithMany("MobileSuits")
                        .HasForeignKey("CardId");

                    b.Navigation("CardProfile");
                });

            modelBuilder.Entity("ServerVanilla.Models.Cards.Navi.Navi", b =>
                {
                    b.HasOne("ServerVanilla.Models.Cards.CardProfile", "CardProfile")
                        .WithMany("Navi")
                        .HasForeignKey("CardId");

                    b.Navigation("CardProfile");
                });

            modelBuilder.Entity("ServerVanilla.Models.Cards.Profile.BattleProfile", b =>
                {
                    b.HasOne("ServerVanilla.Models.Cards.CardProfile", "CardProfile")
                        .WithOne("BattleProfile")
                        .HasForeignKey("ServerVanilla.Models.Cards.Profile.BattleProfile", "CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CardProfile");
                });

            modelBuilder.Entity("ServerVanilla.Models.Cards.Profile.CustomizeProfile", b =>
                {
                    b.HasOne("ServerVanilla.Models.Cards.CardProfile", "CardProfile")
                        .WithOne("CustomizeProfile")
                        .HasForeignKey("ServerVanilla.Models.Cards.Profile.CustomizeProfile", "CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CardProfile");
                });

            modelBuilder.Entity("ServerVanilla.Models.Cards.Profile.PlayerProfile", b =>
                {
                    b.HasOne("ServerVanilla.Models.Cards.CardProfile", "CardProfile")
                        .WithOne("PlayerProfile")
                        .HasForeignKey("ServerVanilla.Models.Cards.Profile.PlayerProfile", "CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CardProfile");
                });

            modelBuilder.Entity("ServerVanilla.Models.Cards.Profile.TrainingProfile", b =>
                {
                    b.HasOne("ServerVanilla.Models.Cards.CardProfile", "CardProfile")
                        .WithOne("TrainingProfile")
                        .HasForeignKey("ServerVanilla.Models.Cards.Profile.TrainingProfile", "CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CardProfile");
                });

            modelBuilder.Entity("ServerVanilla.Models.Cards.Settings.BoostSetting", b =>
                {
                    b.HasOne("ServerVanilla.Models.Cards.CardProfile", "CardProfile")
                        .WithOne("BoostSetting")
                        .HasForeignKey("ServerVanilla.Models.Cards.Settings.BoostSetting", "CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CardProfile");
                });

            modelBuilder.Entity("ServerVanilla.Models.Cards.Settings.NaviSetting", b =>
                {
                    b.HasOne("ServerVanilla.Models.Cards.CardProfile", "CardProfile")
                        .WithOne("NaviSetting")
                        .HasForeignKey("ServerVanilla.Models.Cards.Settings.NaviSetting", "CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CardProfile");
                });

            modelBuilder.Entity("ServerVanilla.Models.Cards.Team.TagTeamData", b =>
                {
                    b.HasOne("ServerVanilla.Models.Cards.CardProfile", "CardProfile")
                        .WithMany("TagTeamDatas")
                        .HasForeignKey("CardId");

                    b.Navigation("CardProfile");
                });

            modelBuilder.Entity("ServerVanilla.Models.Cards.Title.DefaultTitle", b =>
                {
                    b.HasOne("ServerVanilla.Models.Cards.CardProfile", "CardProfile")
                        .WithOne("DefaultTitle")
                        .HasForeignKey("ServerVanilla.Models.Cards.Title.DefaultTitle", "CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CardProfile");
                });

            modelBuilder.Entity("ServerVanilla.Models.Cards.Triad.TriadCourseData", b =>
                {
                    b.HasOne("ServerVanilla.Models.Cards.CardProfile", "CardProfile")
                        .WithMany("TriadCourseDatas")
                        .HasForeignKey("CardId");

                    b.Navigation("CardProfile");
                });

            modelBuilder.Entity("ServerVanilla.Models.Cards.Triad.TriadMiscInfo", b =>
                {
                    b.HasOne("ServerVanilla.Models.Cards.CardProfile", "CardProfile")
                        .WithOne("TriadMiscInfo")
                        .HasForeignKey("ServerVanilla.Models.Cards.Triad.TriadMiscInfo", "CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CardProfile");
                });

            modelBuilder.Entity("ServerVanilla.Models.Cards.Triad.TriadPartner", b =>
                {
                    b.HasOne("ServerVanilla.Models.Cards.CardProfile", "CardProfile")
                        .WithOne("TriadPartner")
                        .HasForeignKey("ServerVanilla.Models.Cards.Triad.TriadPartner", "CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CardProfile");
                });

            modelBuilder.Entity("ServerVanilla.Models.Cards.CardProfile", b =>
                {
                    b.Navigation("BattleProfile")
                        .IsRequired();

                    b.Navigation("BoostSetting")
                        .IsRequired();

                    b.Navigation("CustomizeProfile")
                        .IsRequired();

                    b.Navigation("DefaultTitle")
                        .IsRequired();

                    b.Navigation("FavouriteMobileSuits");

                    b.Navigation("MobileSuits");

                    b.Navigation("Navi");

                    b.Navigation("NaviSetting")
                        .IsRequired();

                    b.Navigation("PlayerProfile")
                        .IsRequired();

                    b.Navigation("TagTeamDatas");

                    b.Navigation("TrainingProfile")
                        .IsRequired();

                    b.Navigation("TriadCourseDatas");

                    b.Navigation("TriadMiscInfo")
                        .IsRequired();

                    b.Navigation("TriadPartner")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
