using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accounting.Persistence.Migrations
{
    public partial class changeuserinfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserLogin_tblUserInfo_UserInfoId",
                table: "UserLogin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLogin",
                table: "UserLogin");

            migrationBuilder.RenameTable(
                name: "UserLogin",
                newName: "UserLogins");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogin_UserInfoId",
                table: "UserLogins",
                newName: "IX_UserLogins_UserInfoId");

            migrationBuilder.AddColumn<bool>(
                name: "IsLoadedImage",
                table: "tblUserInfo",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLogins",
                table: "UserLogins",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogins_tblUserInfo_UserInfoId",
                table: "UserLogins",
                column: "UserInfoId",
                principalTable: "tblUserInfo",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserLogins_tblUserInfo_UserInfoId",
                table: "UserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLogins",
                table: "UserLogins");

            migrationBuilder.DropColumn(
                name: "IsLoadedImage",
                table: "tblUserInfo");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                newName: "UserLogin");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogins_UserInfoId",
                table: "UserLogin",
                newName: "IX_UserLogin_UserInfoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLogin",
                table: "UserLogin",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogin_tblUserInfo_UserInfoId",
                table: "UserLogin",
                column: "UserInfoId",
                principalTable: "tblUserInfo",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
