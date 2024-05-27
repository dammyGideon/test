using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Herbzhub.Data.Migrations
{
    /// <inheritdoc />
    public partial class initue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PasswordResetToken",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ResetTokenExpiry",
                table: "Users",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 16,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 17,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 18,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 19,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 20,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 21,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 22,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 23,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 24,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 25,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 26,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5439));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 27,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5439));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 28,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 29,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 30,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 31,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 32,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 33,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 34,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 35,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 36,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 37,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 38,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 39,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 40,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 41,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 42,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 43,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 44,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 45,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 46,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 47,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 48,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 49,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 50,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "HashPassword", "PasswordResetToken", "ResetTokenExpiry", "UpdatedAt" },
                values: new object[] { "$2a$11$ZcR2lEtiOEf.FhkztFLiAOEaxENdZlk9cJliXG.AegSVEKuDsMyce", null, null, new DateTime(2024, 5, 25, 18, 59, 48, 576, DateTimeKind.Utc).AddTicks(899) });

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 49,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 50,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 25, 18, 59, 48, 368, DateTimeKind.Utc).AddTicks(5860));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordResetToken",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ResetTokenExpiry",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2207));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2213));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 16,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 17,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 18,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 19,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 20,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 21,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 22,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 23,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 24,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 25,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 26,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 27,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 28,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 29,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 30,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 31,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 32,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 33,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 34,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 35,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 36,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 37,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 38,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 39,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 40,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 41,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 42,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 43,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 44,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 45,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 46,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 47,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 48,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 49,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 50,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "HashPassword", "UpdatedAt" },
                values: new object[] { "$2a$11$dOroAAS78pWSso8oierRnuZqCcQLMBWUFza1gM0WkzX3IZEz8azKi", new DateTime(2024, 5, 24, 16, 4, 32, 0, DateTimeKind.Utc).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3013));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 49,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 50,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 16, 4, 31, 691, DateTimeKind.Utc).AddTicks(3049));
        }
    }
}
