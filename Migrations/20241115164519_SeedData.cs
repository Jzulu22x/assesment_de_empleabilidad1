using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace assessmente_de_empleabilidad.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "id", "created_at", "date", "doctor_id", "patient_id", "reason", "updated_at", "doctor_id1", "patient_id1" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 15, 11, 45, 18, 167, DateTimeKind.Local).AddTicks(540), new DateTime(2024, 11, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Routine Checkup", null, null, null },
                    { 2, new DateTime(2024, 11, 15, 11, 45, 18, 167, DateTimeKind.Local).AddTicks(543), new DateTime(2024, 11, 21, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, "Consultation", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Administrator" },
                    { 2, "Doctor" },
                    { 3, "Patient" }
                });

            migrationBuilder.InsertData(
                table: "specialities",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Cardiology" },
                    { 2, "Neurology" }
                });

            migrationBuilder.InsertData(
                table: "admins",
                columns: new[] { "id", "name", "password", "role_id", "user_name" },
                values: new object[] { 1, "Admin One", "adminpassword", 1, "admin123" });

            migrationBuilder.InsertData(
                table: "doctors",
                columns: new[] { "id", "availability", "email", "first_name", "last_name", "role_id", "specialty_id", "user_name" },
                values: new object[,]
                {
                    { 1, true, "john.doe@example.com", "John", "Doe", 2, 1, "johndoe" },
                    { 2, false, "jane.smith@example.com", "Jane", "Smith", 2, 2, "janesmith" }
                });

            migrationBuilder.InsertData(
                table: "patients",
                columns: new[] { "id", "email", "first_name", "last_name", "role_id", "user_name" },
                values: new object[,]
                {
                    { 1, "alice.brown@example.com", "Alice", "Brown", 3, "alicebrown" },
                    { 2, "bob.white@example.com", "Bob", "White", 3, "bobwhite" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "admins",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "specialities",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "specialities",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
