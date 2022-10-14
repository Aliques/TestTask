using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalTestTask.Infrastructure.Migrations
{
    public partial class Update2addeddataseeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "DistrictPartId", "FullName", "OfficeId", "SpecializationId" },
                values: new object[,]
                {
                    { 1L, 3L, "Doctor_FullName_1", 5L, 1L },
                    { 2L, null, "Doctor_FullName_2", 2L, 2L },
                    { 3L, null, "Doctor_FullName_3", 3L, 2L },
                    { 4L, 1L, "Doctor_FullName_4", 1L, 1L },
                    { 5L, 5L, "Doctor_FullName_5", 4L, 1L },
                    { 6L, 2L, "Doctor_FullName_6", 3L, 1L },
                    { 7L, null, "Doctor_FullName_7", 1L, 3L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7L);
        }
    }
}
