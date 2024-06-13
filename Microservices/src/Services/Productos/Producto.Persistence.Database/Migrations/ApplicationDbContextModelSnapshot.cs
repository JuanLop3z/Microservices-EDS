﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Productos.Persistence.Database;

#nullable disable

namespace Productos.Persistence.Database.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Productos")
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Productos.Domain.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProducto"));

                    b.Property<string>("NombreProducto")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("PrecioUnitarioProducto")
                        .HasMaxLength(50)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("pkidEstacion_tblEstacion")
                        .HasColumnType("int");

                    b.HasKey("IdProducto");

                    b.ToTable("Productos", "Productos");

                    b.HasData(
                        new
                        {
                            IdProducto = 1,
                            NombreProducto = "Producto 1",
                            PrecioUnitarioProducto = 983m,
                            pkidEstacion_tblEstacion = 739
                        },
                        new
                        {
                            IdProducto = 2,
                            NombreProducto = "Producto 2",
                            PrecioUnitarioProducto = 220m,
                            pkidEstacion_tblEstacion = 276
                        },
                        new
                        {
                            IdProducto = 3,
                            NombreProducto = "Producto 3",
                            PrecioUnitarioProducto = 590m,
                            pkidEstacion_tblEstacion = 938
                        },
                        new
                        {
                            IdProducto = 4,
                            NombreProducto = "Producto 4",
                            PrecioUnitarioProducto = 224m,
                            pkidEstacion_tblEstacion = 507
                        },
                        new
                        {
                            IdProducto = 5,
                            NombreProducto = "Producto 5",
                            PrecioUnitarioProducto = 881m,
                            pkidEstacion_tblEstacion = 735
                        },
                        new
                        {
                            IdProducto = 6,
                            NombreProducto = "Producto 6",
                            PrecioUnitarioProducto = 576m,
                            pkidEstacion_tblEstacion = 454
                        },
                        new
                        {
                            IdProducto = 7,
                            NombreProducto = "Producto 7",
                            PrecioUnitarioProducto = 499m,
                            pkidEstacion_tblEstacion = 777
                        },
                        new
                        {
                            IdProducto = 8,
                            NombreProducto = "Producto 8",
                            PrecioUnitarioProducto = 719m,
                            pkidEstacion_tblEstacion = 600
                        },
                        new
                        {
                            IdProducto = 9,
                            NombreProducto = "Producto 9",
                            PrecioUnitarioProducto = 598m,
                            pkidEstacion_tblEstacion = 707
                        },
                        new
                        {
                            IdProducto = 10,
                            NombreProducto = "Producto 10",
                            PrecioUnitarioProducto = 883m,
                            pkidEstacion_tblEstacion = 771
                        },
                        new
                        {
                            IdProducto = 11,
                            NombreProducto = "Producto 11",
                            PrecioUnitarioProducto = 289m,
                            pkidEstacion_tblEstacion = 855
                        },
                        new
                        {
                            IdProducto = 12,
                            NombreProducto = "Producto 12",
                            PrecioUnitarioProducto = 998m,
                            pkidEstacion_tblEstacion = 988
                        },
                        new
                        {
                            IdProducto = 13,
                            NombreProducto = "Producto 13",
                            PrecioUnitarioProducto = 325m,
                            pkidEstacion_tblEstacion = 815
                        },
                        new
                        {
                            IdProducto = 14,
                            NombreProducto = "Producto 14",
                            PrecioUnitarioProducto = 391m,
                            pkidEstacion_tblEstacion = 485
                        },
                        new
                        {
                            IdProducto = 15,
                            NombreProducto = "Producto 15",
                            PrecioUnitarioProducto = 351m,
                            pkidEstacion_tblEstacion = 614
                        },
                        new
                        {
                            IdProducto = 16,
                            NombreProducto = "Producto 16",
                            PrecioUnitarioProducto = 137m,
                            pkidEstacion_tblEstacion = 388
                        },
                        new
                        {
                            IdProducto = 17,
                            NombreProducto = "Producto 17",
                            PrecioUnitarioProducto = 460m,
                            pkidEstacion_tblEstacion = 625
                        },
                        new
                        {
                            IdProducto = 18,
                            NombreProducto = "Producto 18",
                            PrecioUnitarioProducto = 389m,
                            pkidEstacion_tblEstacion = 380
                        },
                        new
                        {
                            IdProducto = 19,
                            NombreProducto = "Producto 19",
                            PrecioUnitarioProducto = 509m,
                            pkidEstacion_tblEstacion = 863
                        },
                        new
                        {
                            IdProducto = 20,
                            NombreProducto = "Producto 20",
                            PrecioUnitarioProducto = 761m,
                            pkidEstacion_tblEstacion = 467
                        },
                        new
                        {
                            IdProducto = 21,
                            NombreProducto = "Producto 21",
                            PrecioUnitarioProducto = 454m,
                            pkidEstacion_tblEstacion = 618
                        },
                        new
                        {
                            IdProducto = 22,
                            NombreProducto = "Producto 22",
                            PrecioUnitarioProducto = 589m,
                            pkidEstacion_tblEstacion = 819
                        },
                        new
                        {
                            IdProducto = 23,
                            NombreProducto = "Producto 23",
                            PrecioUnitarioProducto = 552m,
                            pkidEstacion_tblEstacion = 133
                        },
                        new
                        {
                            IdProducto = 24,
                            NombreProducto = "Producto 24",
                            PrecioUnitarioProducto = 524m,
                            pkidEstacion_tblEstacion = 339
                        },
                        new
                        {
                            IdProducto = 25,
                            NombreProducto = "Producto 25",
                            PrecioUnitarioProducto = 975m,
                            pkidEstacion_tblEstacion = 758
                        },
                        new
                        {
                            IdProducto = 26,
                            NombreProducto = "Producto 26",
                            PrecioUnitarioProducto = 756m,
                            pkidEstacion_tblEstacion = 495
                        },
                        new
                        {
                            IdProducto = 27,
                            NombreProducto = "Producto 27",
                            PrecioUnitarioProducto = 573m,
                            pkidEstacion_tblEstacion = 519
                        },
                        new
                        {
                            IdProducto = 28,
                            NombreProducto = "Producto 28",
                            PrecioUnitarioProducto = 212m,
                            pkidEstacion_tblEstacion = 951
                        },
                        new
                        {
                            IdProducto = 29,
                            NombreProducto = "Producto 29",
                            PrecioUnitarioProducto = 519m,
                            pkidEstacion_tblEstacion = 517
                        },
                        new
                        {
                            IdProducto = 30,
                            NombreProducto = "Producto 30",
                            PrecioUnitarioProducto = 314m,
                            pkidEstacion_tblEstacion = 544
                        },
                        new
                        {
                            IdProducto = 31,
                            NombreProducto = "Producto 31",
                            PrecioUnitarioProducto = 280m,
                            pkidEstacion_tblEstacion = 605
                        },
                        new
                        {
                            IdProducto = 32,
                            NombreProducto = "Producto 32",
                            PrecioUnitarioProducto = 185m,
                            pkidEstacion_tblEstacion = 779
                        },
                        new
                        {
                            IdProducto = 33,
                            NombreProducto = "Producto 33",
                            PrecioUnitarioProducto = 568m,
                            pkidEstacion_tblEstacion = 960
                        },
                        new
                        {
                            IdProducto = 34,
                            NombreProducto = "Producto 34",
                            PrecioUnitarioProducto = 639m,
                            pkidEstacion_tblEstacion = 862
                        },
                        new
                        {
                            IdProducto = 35,
                            NombreProducto = "Producto 35",
                            PrecioUnitarioProducto = 460m,
                            pkidEstacion_tblEstacion = 334
                        },
                        new
                        {
                            IdProducto = 36,
                            NombreProducto = "Producto 36",
                            PrecioUnitarioProducto = 301m,
                            pkidEstacion_tblEstacion = 190
                        },
                        new
                        {
                            IdProducto = 37,
                            NombreProducto = "Producto 37",
                            PrecioUnitarioProducto = 447m,
                            pkidEstacion_tblEstacion = 102
                        },
                        new
                        {
                            IdProducto = 38,
                            NombreProducto = "Producto 38",
                            PrecioUnitarioProducto = 165m,
                            pkidEstacion_tblEstacion = 904
                        },
                        new
                        {
                            IdProducto = 39,
                            NombreProducto = "Producto 39",
                            PrecioUnitarioProducto = 621m,
                            pkidEstacion_tblEstacion = 626
                        },
                        new
                        {
                            IdProducto = 40,
                            NombreProducto = "Producto 40",
                            PrecioUnitarioProducto = 393m,
                            pkidEstacion_tblEstacion = 189
                        },
                        new
                        {
                            IdProducto = 41,
                            NombreProducto = "Producto 41",
                            PrecioUnitarioProducto = 437m,
                            pkidEstacion_tblEstacion = 443
                        },
                        new
                        {
                            IdProducto = 42,
                            NombreProducto = "Producto 42",
                            PrecioUnitarioProducto = 722m,
                            pkidEstacion_tblEstacion = 256
                        },
                        new
                        {
                            IdProducto = 43,
                            NombreProducto = "Producto 43",
                            PrecioUnitarioProducto = 751m,
                            pkidEstacion_tblEstacion = 831
                        },
                        new
                        {
                            IdProducto = 44,
                            NombreProducto = "Producto 44",
                            PrecioUnitarioProducto = 272m,
                            pkidEstacion_tblEstacion = 490
                        },
                        new
                        {
                            IdProducto = 45,
                            NombreProducto = "Producto 45",
                            PrecioUnitarioProducto = 271m,
                            pkidEstacion_tblEstacion = 247
                        },
                        new
                        {
                            IdProducto = 46,
                            NombreProducto = "Producto 46",
                            PrecioUnitarioProducto = 597m,
                            pkidEstacion_tblEstacion = 822
                        },
                        new
                        {
                            IdProducto = 47,
                            NombreProducto = "Producto 47",
                            PrecioUnitarioProducto = 964m,
                            pkidEstacion_tblEstacion = 298
                        },
                        new
                        {
                            IdProducto = 48,
                            NombreProducto = "Producto 48",
                            PrecioUnitarioProducto = 201m,
                            pkidEstacion_tblEstacion = 574
                        },
                        new
                        {
                            IdProducto = 49,
                            NombreProducto = "Producto 49",
                            PrecioUnitarioProducto = 143m,
                            pkidEstacion_tblEstacion = 497
                        },
                        new
                        {
                            IdProducto = 50,
                            NombreProducto = "Producto 50",
                            PrecioUnitarioProducto = 177m,
                            pkidEstacion_tblEstacion = 679
                        },
                        new
                        {
                            IdProducto = 51,
                            NombreProducto = "Producto 51",
                            PrecioUnitarioProducto = 362m,
                            pkidEstacion_tblEstacion = 439
                        },
                        new
                        {
                            IdProducto = 52,
                            NombreProducto = "Producto 52",
                            PrecioUnitarioProducto = 370m,
                            pkidEstacion_tblEstacion = 781
                        },
                        new
                        {
                            IdProducto = 53,
                            NombreProducto = "Producto 53",
                            PrecioUnitarioProducto = 802m,
                            pkidEstacion_tblEstacion = 635
                        },
                        new
                        {
                            IdProducto = 54,
                            NombreProducto = "Producto 54",
                            PrecioUnitarioProducto = 227m,
                            pkidEstacion_tblEstacion = 918
                        },
                        new
                        {
                            IdProducto = 55,
                            NombreProducto = "Producto 55",
                            PrecioUnitarioProducto = 530m,
                            pkidEstacion_tblEstacion = 521
                        },
                        new
                        {
                            IdProducto = 56,
                            NombreProducto = "Producto 56",
                            PrecioUnitarioProducto = 723m,
                            pkidEstacion_tblEstacion = 651
                        },
                        new
                        {
                            IdProducto = 57,
                            NombreProducto = "Producto 57",
                            PrecioUnitarioProducto = 404m,
                            pkidEstacion_tblEstacion = 305
                        },
                        new
                        {
                            IdProducto = 58,
                            NombreProducto = "Producto 58",
                            PrecioUnitarioProducto = 943m,
                            pkidEstacion_tblEstacion = 592
                        },
                        new
                        {
                            IdProducto = 59,
                            NombreProducto = "Producto 59",
                            PrecioUnitarioProducto = 575m,
                            pkidEstacion_tblEstacion = 185
                        },
                        new
                        {
                            IdProducto = 60,
                            NombreProducto = "Producto 60",
                            PrecioUnitarioProducto = 110m,
                            pkidEstacion_tblEstacion = 751
                        },
                        new
                        {
                            IdProducto = 61,
                            NombreProducto = "Producto 61",
                            PrecioUnitarioProducto = 673m,
                            pkidEstacion_tblEstacion = 211
                        },
                        new
                        {
                            IdProducto = 62,
                            NombreProducto = "Producto 62",
                            PrecioUnitarioProducto = 754m,
                            pkidEstacion_tblEstacion = 693
                        },
                        new
                        {
                            IdProducto = 63,
                            NombreProducto = "Producto 63",
                            PrecioUnitarioProducto = 953m,
                            pkidEstacion_tblEstacion = 648
                        },
                        new
                        {
                            IdProducto = 64,
                            NombreProducto = "Producto 64",
                            PrecioUnitarioProducto = 880m,
                            pkidEstacion_tblEstacion = 511
                        },
                        new
                        {
                            IdProducto = 65,
                            NombreProducto = "Producto 65",
                            PrecioUnitarioProducto = 486m,
                            pkidEstacion_tblEstacion = 288
                        },
                        new
                        {
                            IdProducto = 66,
                            NombreProducto = "Producto 66",
                            PrecioUnitarioProducto = 756m,
                            pkidEstacion_tblEstacion = 742
                        },
                        new
                        {
                            IdProducto = 67,
                            NombreProducto = "Producto 67",
                            PrecioUnitarioProducto = 104m,
                            pkidEstacion_tblEstacion = 360
                        },
                        new
                        {
                            IdProducto = 68,
                            NombreProducto = "Producto 68",
                            PrecioUnitarioProducto = 189m,
                            pkidEstacion_tblEstacion = 412
                        },
                        new
                        {
                            IdProducto = 69,
                            NombreProducto = "Producto 69",
                            PrecioUnitarioProducto = 377m,
                            pkidEstacion_tblEstacion = 794
                        },
                        new
                        {
                            IdProducto = 70,
                            NombreProducto = "Producto 70",
                            PrecioUnitarioProducto = 950m,
                            pkidEstacion_tblEstacion = 966
                        },
                        new
                        {
                            IdProducto = 71,
                            NombreProducto = "Producto 71",
                            PrecioUnitarioProducto = 288m,
                            pkidEstacion_tblEstacion = 547
                        },
                        new
                        {
                            IdProducto = 72,
                            NombreProducto = "Producto 72",
                            PrecioUnitarioProducto = 849m,
                            pkidEstacion_tblEstacion = 702
                        },
                        new
                        {
                            IdProducto = 73,
                            NombreProducto = "Producto 73",
                            PrecioUnitarioProducto = 377m,
                            pkidEstacion_tblEstacion = 701
                        },
                        new
                        {
                            IdProducto = 74,
                            NombreProducto = "Producto 74",
                            PrecioUnitarioProducto = 614m,
                            pkidEstacion_tblEstacion = 856
                        },
                        new
                        {
                            IdProducto = 75,
                            NombreProducto = "Producto 75",
                            PrecioUnitarioProducto = 717m,
                            pkidEstacion_tblEstacion = 337
                        },
                        new
                        {
                            IdProducto = 76,
                            NombreProducto = "Producto 76",
                            PrecioUnitarioProducto = 673m,
                            pkidEstacion_tblEstacion = 713
                        },
                        new
                        {
                            IdProducto = 77,
                            NombreProducto = "Producto 77",
                            PrecioUnitarioProducto = 740m,
                            pkidEstacion_tblEstacion = 730
                        },
                        new
                        {
                            IdProducto = 78,
                            NombreProducto = "Producto 78",
                            PrecioUnitarioProducto = 402m,
                            pkidEstacion_tblEstacion = 590
                        },
                        new
                        {
                            IdProducto = 79,
                            NombreProducto = "Producto 79",
                            PrecioUnitarioProducto = 894m,
                            pkidEstacion_tblEstacion = 915
                        },
                        new
                        {
                            IdProducto = 80,
                            NombreProducto = "Producto 80",
                            PrecioUnitarioProducto = 305m,
                            pkidEstacion_tblEstacion = 222
                        },
                        new
                        {
                            IdProducto = 81,
                            NombreProducto = "Producto 81",
                            PrecioUnitarioProducto = 600m,
                            pkidEstacion_tblEstacion = 924
                        },
                        new
                        {
                            IdProducto = 82,
                            NombreProducto = "Producto 82",
                            PrecioUnitarioProducto = 246m,
                            pkidEstacion_tblEstacion = 418
                        },
                        new
                        {
                            IdProducto = 83,
                            NombreProducto = "Producto 83",
                            PrecioUnitarioProducto = 112m,
                            pkidEstacion_tblEstacion = 844
                        },
                        new
                        {
                            IdProducto = 84,
                            NombreProducto = "Producto 84",
                            PrecioUnitarioProducto = 682m,
                            pkidEstacion_tblEstacion = 873
                        },
                        new
                        {
                            IdProducto = 85,
                            NombreProducto = "Producto 85",
                            PrecioUnitarioProducto = 429m,
                            pkidEstacion_tblEstacion = 926
                        },
                        new
                        {
                            IdProducto = 86,
                            NombreProducto = "Producto 86",
                            PrecioUnitarioProducto = 953m,
                            pkidEstacion_tblEstacion = 214
                        },
                        new
                        {
                            IdProducto = 87,
                            NombreProducto = "Producto 87",
                            PrecioUnitarioProducto = 850m,
                            pkidEstacion_tblEstacion = 694
                        },
                        new
                        {
                            IdProducto = 88,
                            NombreProducto = "Producto 88",
                            PrecioUnitarioProducto = 172m,
                            pkidEstacion_tblEstacion = 729
                        },
                        new
                        {
                            IdProducto = 89,
                            NombreProducto = "Producto 89",
                            PrecioUnitarioProducto = 268m,
                            pkidEstacion_tblEstacion = 594
                        },
                        new
                        {
                            IdProducto = 90,
                            NombreProducto = "Producto 90",
                            PrecioUnitarioProducto = 741m,
                            pkidEstacion_tblEstacion = 994
                        },
                        new
                        {
                            IdProducto = 91,
                            NombreProducto = "Producto 91",
                            PrecioUnitarioProducto = 376m,
                            pkidEstacion_tblEstacion = 431
                        },
                        new
                        {
                            IdProducto = 92,
                            NombreProducto = "Producto 92",
                            PrecioUnitarioProducto = 293m,
                            pkidEstacion_tblEstacion = 744
                        },
                        new
                        {
                            IdProducto = 93,
                            NombreProducto = "Producto 93",
                            PrecioUnitarioProducto = 643m,
                            pkidEstacion_tblEstacion = 520
                        },
                        new
                        {
                            IdProducto = 94,
                            NombreProducto = "Producto 94",
                            PrecioUnitarioProducto = 274m,
                            pkidEstacion_tblEstacion = 385
                        },
                        new
                        {
                            IdProducto = 95,
                            NombreProducto = "Producto 95",
                            PrecioUnitarioProducto = 597m,
                            pkidEstacion_tblEstacion = 484
                        },
                        new
                        {
                            IdProducto = 96,
                            NombreProducto = "Producto 96",
                            PrecioUnitarioProducto = 301m,
                            pkidEstacion_tblEstacion = 424
                        },
                        new
                        {
                            IdProducto = 97,
                            NombreProducto = "Producto 97",
                            PrecioUnitarioProducto = 623m,
                            pkidEstacion_tblEstacion = 359
                        },
                        new
                        {
                            IdProducto = 98,
                            NombreProducto = "Producto 98",
                            PrecioUnitarioProducto = 366m,
                            pkidEstacion_tblEstacion = 976
                        },
                        new
                        {
                            IdProducto = 99,
                            NombreProducto = "Producto 99",
                            PrecioUnitarioProducto = 697m,
                            pkidEstacion_tblEstacion = 270
                        },
                        new
                        {
                            IdProducto = 100,
                            NombreProducto = "Producto 100",
                            PrecioUnitarioProducto = 697m,
                            pkidEstacion_tblEstacion = 118
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
