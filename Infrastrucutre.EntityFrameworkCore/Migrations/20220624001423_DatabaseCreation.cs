using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Omisrho.Infrastrucutre.EntityFrameworkCore.Migrations
{
    public partial class DatabaseCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fault_Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlazaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LaneNumber = table.Column<int>(type: "int", nullable: false),
                    LaneDirection = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EqiupmentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fault_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaultCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LaneStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaultStatusConfirmed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fault_Notifications", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fault_Notifications");
        }
    }
}
