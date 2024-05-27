using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Herbzhub.Data.Migrations
{
    /// <inheritdoc />
    public partial class Intial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OperatingHours",
                table: "Dispensaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OperatingHours",
                table: "Dispensaries",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 16,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 17,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 18,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 19,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 20,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 21,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 22,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 23,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 24,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 25,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 26,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 27,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 28,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 29,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 30,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 31,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 32,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 33,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 34,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 35,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 36,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 37,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 38,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 39,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 40,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 41,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 42,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 43,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 44,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 45,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 46,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 47,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 48,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 49,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 50,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "HashPassword", "UpdatedAt" },
                values: new object[] { "$2a$11$YwI.nH70kvs4ZVBxky9bBeYMCo4RUElPaEB2/yfThSwVq4YFj6V/q", new DateTime(2024, 5, 24, 12, 50, 58, 954, DateTimeKind.Utc).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 49,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "cities",
                keyColumn: "Id",
                keyValue: 50,
                column: "UpdatedAt",
                value: new DateTime(2024, 5, 24, 12, 50, 58, 601, DateTimeKind.Utc).AddTicks(9056));
        }
    }
}
