﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.DAL.Migrations
{
    public partial class initialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Qualification = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedComputerName = table.Column<string>(nullable: true),
                    CreatedIpAddress = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedComputerName = table.Column<string>(nullable: true),
                    UpdatedIpAddress = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Qualification = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedComputerName = table.Column<string>(nullable: true),
                    CreatedIpAddress = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedComputerName = table.Column<string>(nullable: true),
                    UpdatedIpAddress = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Title = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedComputerName = table.Column<string>(nullable: true),
                    CreatedIpAddress = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedComputerName = table.Column<string>(nullable: true),
                    UpdatedIpAddress = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    GenreName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Halls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedComputerName = table.Column<string>(nullable: true),
                    CreatedIpAddress = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedComputerName = table.Column<string>(nullable: true),
                    UpdatedIpAddress = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    No = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Halls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedComputerName = table.Column<string>(nullable: true),
                    CreatedIpAddress = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedComputerName = table.Column<string>(nullable: true),
                    UpdatedIpAddress = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    AppUserId = table.Column<int>(nullable: true),
                    CustomerId = table.Column<int>(nullable: true),
                    TicketNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedComputerName = table.Column<string>(nullable: true),
                    CreatedIpAddress = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedComputerName = table.Column<string>(nullable: true),
                    UpdatedIpAddress = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    Duration = table.Column<TimeSpan>(nullable: true),
                    Year = table.Column<DateTime>(nullable: true),
                    Rating = table.Column<double>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    UnitPrice = table.Column<decimal>(nullable: true),
                    GenreId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedComputerName = table.Column<string>(nullable: true),
                    CreatedIpAddress = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedComputerName = table.Column<string>(nullable: true),
                    UpdatedIpAddress = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Letter = table.Column<string>(nullable: true),
                    No = table.Column<int>(nullable: false),
                    HallId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seats_Halls_HallId",
                        column: x => x.HallId,
                        principalTable: "Halls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShowTimes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedComputerName = table.Column<string>(nullable: true),
                    CreatedIpAddress = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedComputerName = table.Column<string>(nullable: true),
                    UpdatedIpAddress = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false),
                    MovieId = table.Column<int>(nullable: false),
                    HallId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShowTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShowTimes_Halls_HallId",
                        column: x => x.HallId,
                        principalTable: "Halls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShowTimes_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TicketDetails",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false),
                    TicketId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    MasterId = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedComputerName = table.Column<string>(nullable: true),
                    CreatedIpAddress = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedComputerName = table.Column<string>(nullable: true),
                    UpdatedIpAddress = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<decimal>(nullable: true),
                    Quantity = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketDetails", x => new { x.MovieId, x.TicketId });
                    table.ForeignKey(
                        name: "FK_TicketDetails_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketDetails_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GenreId",
                table: "Movies",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_HallId",
                table: "Seats",
                column: "HallId");

            migrationBuilder.CreateIndex(
                name: "IX_ShowTimes_HallId",
                table: "ShowTimes",
                column: "HallId");

            migrationBuilder.CreateIndex(
                name: "IX_ShowTimes_MovieId",
                table: "ShowTimes",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketDetails_TicketId",
                table: "TicketDetails",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_AppUserId",
                table: "Tickets",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_CustomerId",
                table: "Tickets",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "ShowTimes");

            migrationBuilder.DropTable(
                name: "TicketDetails");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Halls");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
