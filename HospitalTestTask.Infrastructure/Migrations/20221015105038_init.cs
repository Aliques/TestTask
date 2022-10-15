using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalTestTask.Infrastructure.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DistrictPart",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistrictPart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Office",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Office", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specialization",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialization", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patronymic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    DistrictPartId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_DistrictPart_DistrictPartId",
                        column: x => x.DistrictPartId,
                        principalTable: "DistrictPart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OfficeId = table.Column<long>(type: "bigint", nullable: false),
                    SpecializationId = table.Column<long>(type: "bigint", nullable: false),
                    DistrictPartId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_DistrictPart_DistrictPartId",
                        column: x => x.DistrictPartId,
                        principalTable: "DistrictPart",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Doctors_Office_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Office",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Doctors_Specialization_SpecializationId",
                        column: x => x.SpecializationId,
                        principalTable: "Specialization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "BirthDate", "DistrictPartId", "Gender", "Name", "Patronymic", "Surname" },
                values: new object[,]
                {
                    { new Guid("093860d8-5413-4e15-bfad-7375fcbdc664"), "Address_1_1", new DateTime(2022, 10, 15, 13, 50, 37, 902, DateTimeKind.Local).AddTicks(6954), 3L, 0, "Patient_FirstName_1", "Patient_Patronymic_1", "Patient_Surname_1" },
                    { new Guid("19ac7d06-b910-4e5d-8e6b-fa259cb2cffc"), "Address_12_22", new DateTime(2022, 10, 15, 13, 50, 37, 904, DateTimeKind.Local).AddTicks(1061), 3L, 0, "Patient_FirstName_3", null, "Patient_Surname_3" },
                    { new Guid("6a268677-aaa7-4527-8a55-3db666c9464a"), "Address_7_4", new DateTime(2022, 10, 15, 13, 50, 37, 904, DateTimeKind.Local).AddTicks(1067), 2L, 1, "Patient_FirstName_6", "Patient_Patronymic_6", "Patient_Surname_6" },
                    { new Guid("833fe5f0-60eb-4fbb-9513-feb9af5e3d84"), "Address_1_1", new DateTime(2022, 10, 15, 13, 50, 37, 904, DateTimeKind.Local).AddTicks(1076), 1L, 1, "Patient_FirstName_7", "Patient_Patronymic_7", "Patient_Surname_7" },
                    { new Guid("aef2ac54-d4fb-43c6-b397-065f63ecbdc3"), "Address_5_44", new DateTime(2022, 10, 15, 13, 50, 37, 904, DateTimeKind.Local).AddTicks(1065), 3L, 0, "Patient_FirstName_5", "Patient_Patronymic_5", "Patient_Surname_5" },
                    { new Guid("c042d2cb-43d4-499d-bcc4-3d7036035dde"), "Address_224_4", new DateTime(2022, 10, 15, 13, 50, 37, 904, DateTimeKind.Local).AddTicks(1063), 2L, 0, "Patient_FirstName_4", "Patient_Patronymic_4", "Patient_Surname_4" },
                    { new Guid("cdfd7e0b-39fb-41bc-8d1c-614b0c52303e"), "Address_21_5", new DateTime(2022, 10, 15, 13, 50, 37, 904, DateTimeKind.Local).AddTicks(1050), 1L, 1, "Patient_FirstName_2", "Patient_Patronymic_2", "Patient_Surname_2" },
                    { new Guid("da1e200f-eb7f-427d-b186-36e4f8219818"), "Address_22_41", new DateTime(2022, 10, 15, 13, 50, 37, 904, DateTimeKind.Local).AddTicks(1077), 4L, 0, "Patient_FirstName_8", "Patient_Patronymic_8", "Patient_Surname_8" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_DistrictPartId",
                table: "Doctors",
                column: "DistrictPartId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_OfficeId",
                table: "Doctors",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_SpecializationId",
                table: "Doctors",
                column: "SpecializationId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DistrictPartId",
                table: "Patients",
                column: "DistrictPartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Office");

            migrationBuilder.DropTable(
                name: "Specialization");

            migrationBuilder.DropTable(
                name: "DistrictPart");
        }
    }
}
