using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UploadDocumentEmailDocuments.Persistence.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsersPersonalDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateLastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersPersonalDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilesDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsersPersonalDetailId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateLastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilesDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilesDetails_UsersPersonalDetail_UsersPersonalDetailId",
                        column: x => x.UsersPersonalDetailId,
                        principalTable: "UsersPersonalDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "UsersPersonalDetail",
                columns: new[] { "Id", "Age", "DateCreated", "DateLastModified", "Email", "Name", "Phone", "ReferenceNumber" },
                values: new object[] { 1, "20", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "steville2013@gmail.com", "Stephen", "08077670500", null });

            migrationBuilder.CreateIndex(
                name: "IX_FilesDetails_UsersPersonalDetailId",
                table: "FilesDetails",
                column: "UsersPersonalDetailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilesDetails");

            migrationBuilder.DropTable(
                name: "UsersPersonalDetail");
        }
    }
}
