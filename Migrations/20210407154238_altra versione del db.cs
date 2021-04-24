using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace giorgetti.alessio._5h.SecondaWeb.Migrations
{
    public partial class altraversionedeldb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Partecipazione",
                table: "Prenotazioni");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Prenotazioni");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Prenotazioni",
                newName: "PrenotazioneId");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Prenotazioni",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataPrenotazione",
                table: "Prenotazioni",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataPrenotazione",
                table: "Prenotazioni");

            migrationBuilder.RenameColumn(
                name: "PrenotazioneId",
                table: "Prenotazioni",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Prenotazioni",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<bool>(
                name: "Partecipazione",
                table: "Prenotazioni",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "Prenotazioni",
                type: "TEXT",
                nullable: true);
        }
    }
}
