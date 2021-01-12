using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KhimikBackend.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgeCategory",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    BeginAge = table.Column<int>(type: "int", nullable: false),
                    EndAge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgeCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Club",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    City = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Club", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Day",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Day", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rank",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Decryption = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rank", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SessionKind",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionKind", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimeRange",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    BeginTime = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    EndTime = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeRange", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ActivityDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AgeCategoryId = table.Column<string>(type: "nvarchar(36)", nullable: true),
                    ClubId = table.Column<string>(type: "nvarchar(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Team_AgeCategory_AgeCategoryId",
                        column: x => x.AgeCategoryId,
                        principalTable: "AgeCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Team_Club_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Club",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    TimeRangeId = table.Column<string>(type: "nvarchar(36)", nullable: true),
                    DayId = table.Column<string>(type: "nvarchar(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedule_Day_DayId",
                        column: x => x.DayId,
                        principalTable: "Day",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schedule_TimeRange_TimeRangeId",
                        column: x => x.TimeRangeId,
                        principalTable: "TimeRange",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mentor",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsReferee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RankId = table.Column<string>(type: "nvarchar(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mentor_Rank_RankId",
                        column: x => x.RankId,
                        principalTable: "Rank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mentor_User_Id",
                        column: x => x.Id,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Team1Id = table.Column<string>(type: "nvarchar(36)", nullable: true),
                    Team2Id = table.Column<string>(type: "nvarchar(36)", nullable: true),
                    Team1Points = table.Column<int>(type: "int", nullable: false),
                    Team2Points = table.Column<int>(type: "int", nullable: false),
                    ResultDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.Id);
                    table.ForeignKey(
                        name: "Game_Team1_Key",
                        column: x => x.Team1Id,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Game_Team2_Key",
                        column: x => x.Team2Id,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sportsman",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RankId = table.Column<string>(type: "nvarchar(36)", nullable: true),
                    TeamId = table.Column<string>(type: "nvarchar(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sportsman", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sportsman_Rank_RankId",
                        column: x => x.RankId,
                        principalTable: "Rank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sportsman_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MentorTeam",
                columns: table => new
                {
                    MentorsId = table.Column<string>(type: "nvarchar(36)", nullable: false),
                    TeamsId = table.Column<string>(type: "nvarchar(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MentorTeam", x => new { x.MentorsId, x.TeamsId });
                    table.ForeignKey(
                        name: "FK_MentorTeam_Mentor_MentorsId",
                        column: x => x.MentorsId,
                        principalTable: "Mentor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MentorTeam_Team_TeamsId",
                        column: x => x.TeamsId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Workout",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    MentorId = table.Column<string>(type: "nvarchar(36)", nullable: true),
                    TeamId = table.Column<string>(type: "nvarchar(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workout", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workout_Mentor_MentorId",
                        column: x => x.MentorId,
                        principalTable: "Mentor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Workout_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GameMentor",
                columns: table => new
                {
                    GamesId = table.Column<string>(type: "nvarchar(36)", nullable: false),
                    MentorsId = table.Column<string>(type: "nvarchar(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameMentor", x => new { x.GamesId, x.MentorsId });
                    table.ForeignKey(
                        name: "FK_GameMentor_Game_GamesId",
                        column: x => x.GamesId,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameMentor_Mentor_MentorsId",
                        column: x => x.MentorsId,
                        principalTable: "Mentor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IceOccupation",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    ScheduleId = table.Column<string>(type: "nvarchar(36)", nullable: true),
                    SessionKindId = table.Column<string>(type: "nvarchar(36)", nullable: true),
                    HoldDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IceOccupation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IceOccupation_Game_Id",
                        column: x => x.Id,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IceOccupation_Schedule_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IceOccupation_SessionKind_SessionKindId",
                        column: x => x.SessionKindId,
                        principalTable: "SessionKind",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IceOccupation_Workout_Id",
                        column: x => x.Id,
                        principalTable: "Workout",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Game_Team1Id",
                table: "Game",
                column: "Team1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Game_Team2Id",
                table: "Game",
                column: "Team2Id");

            migrationBuilder.CreateIndex(
                name: "IX_GameMentor_MentorsId",
                table: "GameMentor",
                column: "MentorsId");

            migrationBuilder.CreateIndex(
                name: "IX_IceOccupation_ScheduleId",
                table: "IceOccupation",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_IceOccupation_SessionKindId",
                table: "IceOccupation",
                column: "SessionKindId");

            migrationBuilder.CreateIndex(
                name: "IX_Mentor_RankId",
                table: "Mentor",
                column: "RankId");

            migrationBuilder.CreateIndex(
                name: "IX_MentorTeam_TeamsId",
                table: "MentorTeam",
                column: "TeamsId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_DayId",
                table: "Schedule",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_TimeRangeId",
                table: "Schedule",
                column: "TimeRangeId");

            migrationBuilder.CreateIndex(
                name: "IX_Sportsman_RankId",
                table: "Sportsman",
                column: "RankId");

            migrationBuilder.CreateIndex(
                name: "IX_Sportsman_TeamId",
                table: "Sportsman",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_AgeCategoryId",
                table: "Team",
                column: "AgeCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_ClubId",
                table: "Team",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Workout_MentorId",
                table: "Workout",
                column: "MentorId");

            migrationBuilder.CreateIndex(
                name: "IX_Workout_TeamId",
                table: "Workout",
                column: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameMentor");

            migrationBuilder.DropTable(
                name: "IceOccupation");

            migrationBuilder.DropTable(
                name: "MentorTeam");

            migrationBuilder.DropTable(
                name: "Sportsman");

            migrationBuilder.DropTable(
                name: "Game");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropTable(
                name: "SessionKind");

            migrationBuilder.DropTable(
                name: "Workout");

            migrationBuilder.DropTable(
                name: "Day");

            migrationBuilder.DropTable(
                name: "TimeRange");

            migrationBuilder.DropTable(
                name: "Mentor");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "Rank");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "AgeCategory");

            migrationBuilder.DropTable(
                name: "Club");
        }
    }
}
