﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProjerct.Context.Migrations
{
    /// <inheritdoc />
    public partial class firstCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "Claims",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PermissionId",
                table: "Claims",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Claims_PermissionId",
                table: "Claims",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Claims_RoleId",
                table: "Claims",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Claims_Permissions_PermissionId",
                table: "Claims",
                column: "PermissionId",
                principalTable: "Permissions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Claims_Roles_RoleId",
                table: "Claims",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Claims_Permissions_PermissionId",
                table: "Claims");

            migrationBuilder.DropForeignKey(
                name: "FK_Claims_Roles_RoleId",
                table: "Claims");

            migrationBuilder.DropIndex(
                name: "IX_Claims_PermissionId",
                table: "Claims");

            migrationBuilder.DropIndex(
                name: "IX_Claims_RoleId",
                table: "Claims");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "Claims",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PermissionId",
                table: "Claims",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
