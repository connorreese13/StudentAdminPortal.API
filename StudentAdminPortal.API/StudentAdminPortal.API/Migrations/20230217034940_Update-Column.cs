using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentAdminPortal.API.Migrations
{
    public partial class UpdateColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gender_Address_AddressId",
                table: "Gender");

            migrationBuilder.DropIndex(
                name: "IX_Gender_AddressId",
                table: "Gender");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Gender");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Gender",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Gender");

            migrationBuilder.AddColumn<Guid>(
                name: "AddressId",
                table: "Gender",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Gender_AddressId",
                table: "Gender",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gender_Address_AddressId",
                table: "Gender",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
