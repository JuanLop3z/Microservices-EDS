using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Productos.Persistence.Database.Migrations
{
    /// <inheritdoc />
    public partial class Initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Productos");

            migrationBuilder.CreateTable(
                name: "Productos",
                schema: "Productos",
                columns: table => new
                {
                    IdProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProducto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PrecioUnitarioProducto = table.Column<decimal>(type: "decimal(18,2)", maxLength: 50, nullable: false),
                    pkidEstacion_tblEstacion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.IdProducto);
                });

            migrationBuilder.InsertData(
                schema: "Productos",
                table: "Productos",
                columns: new[] { "IdProducto", "NombreProducto", "PrecioUnitarioProducto", "pkidEstacion_tblEstacion" },
                values: new object[,]
                {
                    { 1, "Producto 1", 983m, 739 },
                    { 2, "Producto 2", 220m, 276 },
                    { 3, "Producto 3", 590m, 938 },
                    { 4, "Producto 4", 224m, 507 },
                    { 5, "Producto 5", 881m, 735 },
                    { 6, "Producto 6", 576m, 454 },
                    { 7, "Producto 7", 499m, 777 },
                    { 8, "Producto 8", 719m, 600 },
                    { 9, "Producto 9", 598m, 707 },
                    { 10, "Producto 10", 883m, 771 },
                    { 11, "Producto 11", 289m, 855 },
                    { 12, "Producto 12", 998m, 988 },
                    { 13, "Producto 13", 325m, 815 },
                    { 14, "Producto 14", 391m, 485 },
                    { 15, "Producto 15", 351m, 614 },
                    { 16, "Producto 16", 137m, 388 },
                    { 17, "Producto 17", 460m, 625 },
                    { 18, "Producto 18", 389m, 380 },
                    { 19, "Producto 19", 509m, 863 },
                    { 20, "Producto 20", 761m, 467 },
                    { 21, "Producto 21", 454m, 618 },
                    { 22, "Producto 22", 589m, 819 },
                    { 23, "Producto 23", 552m, 133 },
                    { 24, "Producto 24", 524m, 339 },
                    { 25, "Producto 25", 975m, 758 },
                    { 26, "Producto 26", 756m, 495 },
                    { 27, "Producto 27", 573m, 519 },
                    { 28, "Producto 28", 212m, 951 },
                    { 29, "Producto 29", 519m, 517 },
                    { 30, "Producto 30", 314m, 544 },
                    { 31, "Producto 31", 280m, 605 },
                    { 32, "Producto 32", 185m, 779 },
                    { 33, "Producto 33", 568m, 960 },
                    { 34, "Producto 34", 639m, 862 },
                    { 35, "Producto 35", 460m, 334 },
                    { 36, "Producto 36", 301m, 190 },
                    { 37, "Producto 37", 447m, 102 },
                    { 38, "Producto 38", 165m, 904 },
                    { 39, "Producto 39", 621m, 626 },
                    { 40, "Producto 40", 393m, 189 },
                    { 41, "Producto 41", 437m, 443 },
                    { 42, "Producto 42", 722m, 256 },
                    { 43, "Producto 43", 751m, 831 },
                    { 44, "Producto 44", 272m, 490 },
                    { 45, "Producto 45", 271m, 247 },
                    { 46, "Producto 46", 597m, 822 },
                    { 47, "Producto 47", 964m, 298 },
                    { 48, "Producto 48", 201m, 574 },
                    { 49, "Producto 49", 143m, 497 },
                    { 50, "Producto 50", 177m, 679 },
                    { 51, "Producto 51", 362m, 439 },
                    { 52, "Producto 52", 370m, 781 },
                    { 53, "Producto 53", 802m, 635 },
                    { 54, "Producto 54", 227m, 918 },
                    { 55, "Producto 55", 530m, 521 },
                    { 56, "Producto 56", 723m, 651 },
                    { 57, "Producto 57", 404m, 305 },
                    { 58, "Producto 58", 943m, 592 },
                    { 59, "Producto 59", 575m, 185 },
                    { 60, "Producto 60", 110m, 751 },
                    { 61, "Producto 61", 673m, 211 },
                    { 62, "Producto 62", 754m, 693 },
                    { 63, "Producto 63", 953m, 648 },
                    { 64, "Producto 64", 880m, 511 },
                    { 65, "Producto 65", 486m, 288 },
                    { 66, "Producto 66", 756m, 742 },
                    { 67, "Producto 67", 104m, 360 },
                    { 68, "Producto 68", 189m, 412 },
                    { 69, "Producto 69", 377m, 794 },
                    { 70, "Producto 70", 950m, 966 },
                    { 71, "Producto 71", 288m, 547 },
                    { 72, "Producto 72", 849m, 702 },
                    { 73, "Producto 73", 377m, 701 },
                    { 74, "Producto 74", 614m, 856 },
                    { 75, "Producto 75", 717m, 337 },
                    { 76, "Producto 76", 673m, 713 },
                    { 77, "Producto 77", 740m, 730 },
                    { 78, "Producto 78", 402m, 590 },
                    { 79, "Producto 79", 894m, 915 },
                    { 80, "Producto 80", 305m, 222 },
                    { 81, "Producto 81", 600m, 924 },
                    { 82, "Producto 82", 246m, 418 },
                    { 83, "Producto 83", 112m, 844 },
                    { 84, "Producto 84", 682m, 873 },
                    { 85, "Producto 85", 429m, 926 },
                    { 86, "Producto 86", 953m, 214 },
                    { 87, "Producto 87", 850m, 694 },
                    { 88, "Producto 88", 172m, 729 },
                    { 89, "Producto 89", 268m, 594 },
                    { 90, "Producto 90", 741m, 994 },
                    { 91, "Producto 91", 376m, 431 },
                    { 92, "Producto 92", 293m, 744 },
                    { 93, "Producto 93", 643m, 520 },
                    { 94, "Producto 94", 274m, 385 },
                    { 95, "Producto 95", 597m, 484 },
                    { 96, "Producto 96", 301m, 424 },
                    { 97, "Producto 97", 623m, 359 },
                    { 98, "Producto 98", 366m, 976 },
                    { 99, "Producto 99", 697m, 270 },
                    { 100, "Producto 100", 697m, 118 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos",
                schema: "Productos");
        }
    }
}
