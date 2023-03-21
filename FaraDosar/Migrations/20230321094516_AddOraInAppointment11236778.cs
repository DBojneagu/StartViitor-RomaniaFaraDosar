﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FaraDosar.Migrations
{
    /// <inheritdoc />
    public partial class AddOraInAppointment11236778 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Hours_HourId",
                table: "Appointments");

            migrationBuilder.AlterColumn<int>(
                name: "HourId",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Hours_HourId",
                table: "Appointments",
                column: "HourId",
                principalTable: "Hours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Hours_HourId",
                table: "Appointments");

            migrationBuilder.AlterColumn<int>(
                name: "HourId",
                table: "Appointments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Hours_HourId",
                table: "Appointments",
                column: "HourId",
                principalTable: "Hours",
                principalColumn: "Id");
        }
    }
}
