using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalTestTask.Infrastructure.Migrations
{
    public partial class Update1addeddataseeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_DistrictPart_DistrictPartId",
                table: "Doctor");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Office_OfficeId",
                table: "Doctor");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Specialization_SpecializationId",
                table: "Doctor");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_DistrictPart_DistrictPartId",
                table: "Patient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patient",
                table: "Patient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctor",
                table: "Doctor");

            migrationBuilder.RenameTable(
                name: "Patient",
                newName: "Patients");

            migrationBuilder.RenameTable(
                name: "Doctor",
                newName: "Doctors");

            migrationBuilder.RenameIndex(
                name: "IX_Patient_DistrictPartId",
                table: "Patients",
                newName: "IX_Patients_DistrictPartId");

            migrationBuilder.RenameIndex(
                name: "IX_Doctor_SpecializationId",
                table: "Doctors",
                newName: "IX_Doctors_SpecializationId");

            migrationBuilder.RenameIndex(
                name: "IX_Doctor_OfficeId",
                table: "Doctors",
                newName: "IX_Doctors_OfficeId");

            migrationBuilder.RenameIndex(
                name: "IX_Doctor_DistrictPartId",
                table: "Doctors",
                newName: "IX_Doctors_DistrictPartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patients",
                table: "Patients",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors",
                column: "Id");

            migrationBuilder.InsertData(
                table: "DistrictPart",
                columns: new[] { "Id", "Number" },
                values: new object[,]
                {
                    { 1L, 112L },
                    { 2L, 113L },
                    { 3L, 114L },
                    { 4L, 115L },
                    { 5L, 116L }
                });

            migrationBuilder.InsertData(
                table: "Office",
                columns: new[] { "Id", "Number" },
                values: new object[,]
                {
                    { 1L, 210 },
                    { 2L, 220 },
                    { 3L, 213 },
                    { 4L, 314 },
                    { 5L, 302 }
                });

            migrationBuilder.InsertData(
                table: "Specialization",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Терапевт" },
                    { 2L, "Хирург" },
                    { 3L, "Офтальмолог" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_DistrictPart_DistrictPartId",
                table: "Doctors",
                column: "DistrictPartId",
                principalTable: "DistrictPart",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Office_OfficeId",
                table: "Doctors",
                column: "OfficeId",
                principalTable: "Office",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Specialization_SpecializationId",
                table: "Doctors",
                column: "SpecializationId",
                principalTable: "Specialization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_DistrictPart_DistrictPartId",
                table: "Patients",
                column: "DistrictPartId",
                principalTable: "DistrictPart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_DistrictPart_DistrictPartId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Office_OfficeId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Specialization_SpecializationId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_DistrictPart_DistrictPartId",
                table: "Patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patients",
                table: "Patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors");

            migrationBuilder.DeleteData(
                table: "DistrictPart",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "DistrictPart",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "DistrictPart",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "DistrictPart",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "DistrictPart",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Office",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Specialization",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Specialization",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Specialization",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.RenameTable(
                name: "Patients",
                newName: "Patient");

            migrationBuilder.RenameTable(
                name: "Doctors",
                newName: "Doctor");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_DistrictPartId",
                table: "Patient",
                newName: "IX_Patient_DistrictPartId");

            migrationBuilder.RenameIndex(
                name: "IX_Doctors_SpecializationId",
                table: "Doctor",
                newName: "IX_Doctor_SpecializationId");

            migrationBuilder.RenameIndex(
                name: "IX_Doctors_OfficeId",
                table: "Doctor",
                newName: "IX_Doctor_OfficeId");

            migrationBuilder.RenameIndex(
                name: "IX_Doctors_DistrictPartId",
                table: "Doctor",
                newName: "IX_Doctor_DistrictPartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patient",
                table: "Patient",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctor",
                table: "Doctor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_DistrictPart_DistrictPartId",
                table: "Doctor",
                column: "DistrictPartId",
                principalTable: "DistrictPart",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Office_OfficeId",
                table: "Doctor",
                column: "OfficeId",
                principalTable: "Office",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Specialization_SpecializationId",
                table: "Doctor",
                column: "SpecializationId",
                principalTable: "Specialization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_DistrictPart_DistrictPartId",
                table: "Patient",
                column: "DistrictPartId",
                principalTable: "DistrictPart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
