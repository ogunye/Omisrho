using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Omisrho.Infrastrucutre.EntityFrameworkCore.Migrations
{
    public partial class FirstDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Fault_Notifications",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "EqiupmentType", "FaultCategory", "FaultStatusConfirmed", "Fault_Description", "IsDeleted", "LaneDirection", "LaneNumber", "LaneStatus", "LastModifiedBy", "LastModifiedOn", "PlazaName" },
                values: new object[] { 1, new Guid("fdc36b12-9de0-407a-845d-9cc3e2a59149"), new DateTime(2022, 6, 24, 1, 17, 14, 953, DateTimeKind.Local).AddTicks(7599), null, null, "Boom Barrier", "Critical Error", "Fault Status Pending.", "Boom Barrier not opening for user after classification and validation and traffic turn Green.", false, "EB", 7, "Lane Closed", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2022, 6, 24, 1, 17, 14, 953, DateTimeKind.Local).AddTicks(7611), "Admiralty Plaza" });

            migrationBuilder.InsertData(
                table: "Fault_Notifications",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "EqiupmentType", "FaultCategory", "FaultStatusConfirmed", "Fault_Description", "IsDeleted", "LaneDirection", "LaneNumber", "LaneStatus", "LastModifiedBy", "LastModifiedOn", "PlazaName" },
                values: new object[] { 2, new Guid("f911de87-0250-405d-ae3d-368f61e849c6"), new DateTime(2022, 6, 24, 1, 17, 14, 953, DateTimeKind.Local).AddTicks(7696), null, null, "Traffic Ligth Green", "Major Error", "Fault Status Pending.", "Traffic Light Greeen", false, "EB", 10, "Lane Closed", new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2022, 6, 24, 1, 17, 14, 953, DateTimeKind.Local).AddTicks(7697), "Admiralty Plaza" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Fault_Notifications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fault_Notifications",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
