using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mud_Maker.Migrations
{
    public partial class UpdateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_EventTypes_EventTypeId",
                table: "Events");

            migrationBuilder.DropTable(
                name: "EventTypes");

            migrationBuilder.RenameColumn(
                name: "EventTypeId",
                table: "Events",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Events_EventTypeId",
                table: "Events",
                newName: "IX_Events_ItemId");

            migrationBuilder.AlterColumn<int>(
                name: "DirRight",
                table: "Events",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DirLeft",
                table: "Events",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DirFwd",
                table: "Events",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DirBack",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FightId",
                table: "Events",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HealthId",
                table: "Events",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Events_FightId",
                table: "Events",
                column: "FightId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_HealthId",
                table: "Events",
                column: "HealthId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Fights_FightId",
                table: "Events",
                column: "FightId",
                principalTable: "Fights",
                principalColumn: "FightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_HealthBar_HealthId",
                table: "Events",
                column: "HealthId",
                principalTable: "HealthBar",
                principalColumn: "HealthId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Items_ItemId",
                table: "Events",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Fights_FightId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_HealthBar_HealthId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Items_ItemId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_FightId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_HealthId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "DirBack",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "FightId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "HealthId",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "Events",
                newName: "EventTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Events_ItemId",
                table: "Events",
                newName: "IX_Events_EventTypeId");

            migrationBuilder.AlterColumn<string>(
                name: "DirRight",
                table: "Events",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DirLeft",
                table: "Events",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DirFwd",
                table: "Events",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "EventTypes",
                columns: table => new
                {
                    EventTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FightId = table.Column<int>(nullable: false),
                    HealthId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTypes", x => x.EventTypeId);
                    table.ForeignKey(
                        name: "FK_EventTypes_Fights_FightId",
                        column: x => x.FightId,
                        principalTable: "Fights",
                        principalColumn: "FightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventTypes_HealthBar_HealthId",
                        column: x => x.HealthId,
                        principalTable: "HealthBar",
                        principalColumn: "HealthId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventTypes_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventTypes_FightId",
                table: "EventTypes",
                column: "FightId");

            migrationBuilder.CreateIndex(
                name: "IX_EventTypes_HealthId",
                table: "EventTypes",
                column: "HealthId");

            migrationBuilder.CreateIndex(
                name: "IX_EventTypes_ItemId",
                table: "EventTypes",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_EventTypes_EventTypeId",
                table: "Events",
                column: "EventTypeId",
                principalTable: "EventTypes",
                principalColumn: "EventTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
