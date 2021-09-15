using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FaturaTahsilat.Data.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DuzeltmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ka_KullaniciId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Du_KullaniciId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Sil_KullaniciId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DuzeltmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ka_KullaniciId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Du_KullaniciId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Sil_KullaniciId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Aboneler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdSoyad = table.Column<string>(name: "Ad Soyad", type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Eposta = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TCNo = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    AboneNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    KullaniciId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DuzeltmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ka_KullaniciId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Du_KullaniciId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Sil_KullaniciId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aboneler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aboneler_AspNetUsers_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Faturalar",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AboneId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FaturaOdendiMi = table.Column<bool>(type: "bit", nullable: false),
                    FaturaDüzenlenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FaturaSonOdemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FaturaDönemi = table.Column<string>(name: "Fatura Dönemi", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FaturaTutari = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DuzeltmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ka_KullaniciId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Du_KullaniciId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Sil_KullaniciId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faturalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Faturalar_Aboneler_AboneId",
                        column: x => x.AboneId,
                        principalTable: "Aboneler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tahsilatlar",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AboneId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FaturaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TahhutTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TahhutTutarı = table.Column<decimal>(name: "Tahhut Tutarı", type: "decimal(18,2)", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DuzeltmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ka_KullaniciId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Du_KullaniciId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Sil_KullaniciId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tahsilatlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tahsilatlar_Aboneler_AboneId",
                        column: x => x.AboneId,
                        principalTable: "Aboneler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tahsilat Detyaları",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TahsilatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FaturaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DuzeltmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ka_KullaniciId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Du_KullaniciId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Sil_KullaniciId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tahsilat Detyaları", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tahsilat Detyaları_Faturalar_FaturaId",
                        column: x => x.FaturaId,
                        principalTable: "Faturalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aboneler_KullaniciId",
                table: "Aboneler",
                column: "KullaniciId");

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
                name: "IX_Faturalar_AboneId",
                table: "Faturalar",
                column: "AboneId");

            migrationBuilder.CreateIndex(
                name: "IX_Tahsilat Detyaları_FaturaId",
                table: "Tahsilat Detyaları",
                column: "FaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tahsilatlar_AboneId",
                table: "Tahsilatlar",
                column: "AboneId");
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
                name: "Tahsilat Detyaları");

            migrationBuilder.DropTable(
                name: "Tahsilatlar");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Faturalar");

            migrationBuilder.DropTable(
                name: "Aboneler");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
