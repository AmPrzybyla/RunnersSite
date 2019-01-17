using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RunnersTeamSite.Migrations
{
    public partial class AddIdToStartsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Starts_Competitions_CompetitionId",
                table: "Starts");

            migrationBuilder.DropForeignKey(
                name: "FK_Starts_AspNetUsers_UserId",
                table: "Starts");

            migrationBuilder.DropIndex(
                name: "IX_Starts_UserId",
                table: "Starts");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Starts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompetitionId",
                table: "Starts",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Starts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Starts_UserId1",
                table: "Starts",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Starts_Competitions_CompetitionId",
                table: "Starts",
                column: "CompetitionId",
                principalTable: "Competitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Starts_AspNetUsers_UserId1",
                table: "Starts",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Starts_Competitions_CompetitionId",
                table: "Starts");

            migrationBuilder.DropForeignKey(
                name: "FK_Starts_AspNetUsers_UserId1",
                table: "Starts");

            migrationBuilder.DropIndex(
                name: "IX_Starts_UserId1",
                table: "Starts");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Starts");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Starts",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CompetitionId",
                table: "Starts",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Starts_UserId",
                table: "Starts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Starts_Competitions_CompetitionId",
                table: "Starts",
                column: "CompetitionId",
                principalTable: "Competitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Starts_AspNetUsers_UserId",
                table: "Starts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
