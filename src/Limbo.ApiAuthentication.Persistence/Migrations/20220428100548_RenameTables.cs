using Microsoft.EntityFrameworkCore.Migrations;

namespace Limbo.ApiAuthentication.Persistence.Migrations
{
    public partial class RenameTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApiClaimApiKey_ApiClaims_ClaimsId",
                table: "ApiClaimApiKey");

            migrationBuilder.DropForeignKey(
                name: "FK_ApiClaimApiKey_ApiKeys_ApiKeysId",
                table: "ApiClaimApiKey");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApiKeys",
                table: "ApiKeys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApiClaims",
                table: "ApiClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApiClaimApiKey",
                table: "ApiClaimApiKey");

            migrationBuilder.RenameTable(
                name: "ApiKeys",
                newName: "Limbo_ApiAuthentication_ApiKeys");

            migrationBuilder.RenameTable(
                name: "ApiClaims",
                newName: "Limbo_ApiAuthentication_ApiClaims");

            migrationBuilder.RenameTable(
                name: "ApiClaimApiKey",
                newName: "Limbo_ApiAuthentication_ApiClaimApiKey");

            migrationBuilder.RenameIndex(
                name: "IX_ApiClaimApiKey_ClaimsId",
                table: "Limbo_ApiAuthentication_ApiClaimApiKey",
                newName: "IX_Limbo_ApiAuthentication_ApiClaimApiKey_ClaimsId");

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "Limbo_ApiAuthentication_ApiKeys",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Limbo_ApiAuthentication_ApiKeys",
                table: "Limbo_ApiAuthentication_ApiKeys",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Limbo_ApiAuthentication_ApiClaims",
                table: "Limbo_ApiAuthentication_ApiClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Limbo_ApiAuthentication_ApiClaimApiKey",
                table: "Limbo_ApiAuthentication_ApiClaimApiKey",
                columns: new[] { "ApiKeysId", "ClaimsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Limbo_ApiAuthentication_ApiClaimApiKey_Limbo_ApiAuthentication_ApiClaims_ClaimsId",
                table: "Limbo_ApiAuthentication_ApiClaimApiKey",
                column: "ClaimsId",
                principalTable: "Limbo_ApiAuthentication_ApiClaims",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Limbo_ApiAuthentication_ApiClaimApiKey_Limbo_ApiAuthentication_ApiKeys_ApiKeysId",
                table: "Limbo_ApiAuthentication_ApiClaimApiKey",
                column: "ApiKeysId",
                principalTable: "Limbo_ApiAuthentication_ApiKeys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Limbo_ApiAuthentication_ApiClaimApiKey_Limbo_ApiAuthentication_ApiClaims_ClaimsId",
                table: "Limbo_ApiAuthentication_ApiClaimApiKey");

            migrationBuilder.DropForeignKey(
                name: "FK_Limbo_ApiAuthentication_ApiClaimApiKey_Limbo_ApiAuthentication_ApiKeys_ApiKeysId",
                table: "Limbo_ApiAuthentication_ApiClaimApiKey");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Limbo_ApiAuthentication_ApiKeys",
                table: "Limbo_ApiAuthentication_ApiKeys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Limbo_ApiAuthentication_ApiClaims",
                table: "Limbo_ApiAuthentication_ApiClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Limbo_ApiAuthentication_ApiClaimApiKey",
                table: "Limbo_ApiAuthentication_ApiClaimApiKey");

            migrationBuilder.RenameTable(
                name: "Limbo_ApiAuthentication_ApiKeys",
                newName: "ApiKeys");

            migrationBuilder.RenameTable(
                name: "Limbo_ApiAuthentication_ApiClaims",
                newName: "ApiClaims");

            migrationBuilder.RenameTable(
                name: "Limbo_ApiAuthentication_ApiClaimApiKey",
                newName: "ApiClaimApiKey");

            migrationBuilder.RenameIndex(
                name: "IX_Limbo_ApiAuthentication_ApiClaimApiKey_ClaimsId",
                table: "ApiClaimApiKey",
                newName: "IX_ApiClaimApiKey_ClaimsId");

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "ApiKeys",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApiKeys",
                table: "ApiKeys",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApiClaims",
                table: "ApiClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApiClaimApiKey",
                table: "ApiClaimApiKey",
                columns: new[] { "ApiKeysId", "ClaimsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ApiClaimApiKey_ApiClaims_ClaimsId",
                table: "ApiClaimApiKey",
                column: "ClaimsId",
                principalTable: "ApiClaims",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApiClaimApiKey_ApiKeys_ApiKeysId",
                table: "ApiClaimApiKey",
                column: "ApiKeysId",
                principalTable: "ApiKeys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
