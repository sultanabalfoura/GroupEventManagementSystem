using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ActivitySystem.DAL.Migrations
{
    public partial class inaitalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_MemberShip_MembershipID",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Members_MembershipID",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "MembershipID",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Groups");

            migrationBuilder.AddColumn<int>(
                name: "GroupID",
                table: "MemberShip",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MemberID",
                table: "MemberShip",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AddedBy",
                table: "Members",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Members",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FullName_Ar",
                table: "Members",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Members",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Members",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "GroupReference",
                table: "Groups",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Groups",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Discription",
                table: "Groups",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Discription_Ar",
                table: "Groups",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GroupName_Ar",
                table: "Groups",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Groups",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddedBy",
                table: "GroupPosition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "GroupPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Title_Ar",
                table: "GroupPosition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "GroupPosition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "GroupPosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_MemberShip_GroupID",
                table: "MemberShip",
                column: "GroupID");

            migrationBuilder.CreateIndex(
                name: "IX_MemberShip_MemberID",
                table: "MemberShip",
                column: "MemberID");

            migrationBuilder.AddForeignKey(
                name: "FK_MemberShip_Groups_GroupID",
                table: "MemberShip",
                column: "GroupID",
                principalTable: "Groups",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MemberShip_Members_MemberID",
                table: "MemberShip",
                column: "MemberID",
                principalTable: "Members",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MemberShip_Groups_GroupID",
                table: "MemberShip");

            migrationBuilder.DropForeignKey(
                name: "FK_MemberShip_Members_MemberID",
                table: "MemberShip");

            migrationBuilder.DropIndex(
                name: "IX_MemberShip_GroupID",
                table: "MemberShip");

            migrationBuilder.DropIndex(
                name: "IX_MemberShip_MemberID",
                table: "MemberShip");

            migrationBuilder.DropColumn(
                name: "GroupID",
                table: "MemberShip");

            migrationBuilder.DropColumn(
                name: "MemberID",
                table: "MemberShip");

            migrationBuilder.DropColumn(
                name: "AddedBy",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "FullName_Ar",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "Discription",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "Discription_Ar",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "GroupName_Ar",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "AddedBy",
                table: "GroupPosition");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "GroupPosition");

            migrationBuilder.DropColumn(
                name: "Title_Ar",
                table: "GroupPosition");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "GroupPosition");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "GroupPosition");

            migrationBuilder.AddColumn<int>(
                name: "MembershipID",
                table: "Members",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "GroupReference",
                table: "Groups",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Groups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Members_MembershipID",
                table: "Members",
                column: "MembershipID");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_MemberShip_MembershipID",
                table: "Members",
                column: "MembershipID",
                principalTable: "MemberShip",
                principalColumn: "membershipID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
