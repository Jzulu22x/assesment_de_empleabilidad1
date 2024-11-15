using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assessmente_de_empleabilidad.Migrations
{
    /// <inheritdoc />
    public partial class CorrectionAdminsTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_roles_role_id",
                table: "Admins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admins",
                table: "Admins");

            migrationBuilder.RenameTable(
                name: "Admins",
                newName: "admins");

            migrationBuilder.RenameIndex(
                name: "IX_Admins_role_id",
                table: "admins",
                newName: "IX_admins_role_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_admins",
                table: "admins",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_admins_roles_role_id",
                table: "admins",
                column: "role_id",
                principalTable: "roles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_admins_roles_role_id",
                table: "admins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_admins",
                table: "admins");

            migrationBuilder.RenameTable(
                name: "admins",
                newName: "Admins");

            migrationBuilder.RenameIndex(
                name: "IX_admins_role_id",
                table: "Admins",
                newName: "IX_Admins_role_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admins",
                table: "Admins",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_roles_role_id",
                table: "Admins",
                column: "role_id",
                principalTable: "roles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
