using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsumerDebit.Migrations
{
    public partial class AllTrafficsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Traffics",
                columns: new[] { "ID", "Claims", "Date", "Document", "Owes", "UserId" },
                values: new object[,]
                {
                    { 6, 0, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Početno stanje", 584, "S00004" },
                    { 558, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00006" },
                    { 559, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00007" },
                    { 560, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 192, "S00008" },
                    { 561, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 126, "S00009" },
                    { 562, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00010" },
                    { 563, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 183, "S00011" },
                    { 564, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 135, "S00012" },
                    { 565, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 99, "S00013" },
                    { 566, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 153, "S00014" },
                    { 567, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 135, "S00015" },
                    { 557, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 180, "S00005" },
                    { 568, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 99, "S00016" },
                    { 570, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00018" },
                    { 571, 535, new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00015" },
                    { 572, 577, new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00003" },
                    { 573, 592, new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00004" },
                    { 574, 574, new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00007" },
                    { 575, 1996, new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00013" },
                    { 576, 535, new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00012" },
                    { 577, 580, new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00005" },
                    { 578, 526, new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00009" },
                    { 579, 574, new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00018" },
                    { 569, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00017" },
                    { 580, 574, new DateTime(2021, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00007" },
                    { 556, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 192, "S00004" },
                    { 554, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00002" },
                    { 532, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00016" },
                    { 533, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00017" },
                    { 534, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00018" },
                    { 535, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00001" },
                    { 536, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00002" },
                    { 537, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00003" },
                    { 538, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00004" },
                    { 539, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00005" },
                    { 540, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00006" },
                    { 541, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00007" },
                    { 555, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00003" },
                    { 542, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00008" },
                    { 544, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00010" },
                    { 545, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00011" },
                    { 546, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00012" },
                    { 547, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00013" },
                    { 548, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00014" },
                    { 549, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00015" },
                    { 550, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00016" },
                    { 551, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00017" },
                    { 552, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00018" },
                    { 553, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 180, "S00001" },
                    { 543, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00009" },
                    { 531, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00015" },
                    { 581, 574, new DateTime(2021, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00006" },
                    { 583, 700, new DateTime(2021, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00008" },
                    { 610, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00007" },
                    { 611, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 192, "S00008" },
                    { 612, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 126, "S00009" },
                    { 613, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00010" },
                    { 614, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 183, "S00011" },
                    { 615, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 135, "S00012" },
                    { 616, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 99, "S00013" },
                    { 617, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 153, "S00014" },
                    { 618, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 135, "S00015" },
                    { 619, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 99, "S00016" },
                    { 609, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00006" },
                    { 620, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00017" },
                    { 622, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00001" },
                    { 623, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00002" },
                    { 624, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00003" },
                    { 625, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00004" },
                    { 626, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00005" },
                    { 627, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00006" },
                    { 628, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00007" },
                    { 629, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00008" },
                    { 630, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00009" },
                    { 631, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00010" },
                    { 621, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00018" },
                    { 582, 1166, new DateTime(2021, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00011" },
                    { 608, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 180, "S00005" },
                    { 606, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00003" },
                    { 584, 574, new DateTime(2021, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00017" },
                    { 585, 577, new DateTime(2021, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00010" },
                    { 586, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00001" },
                    { 587, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00002" },
                    { 588, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00003" },
                    { 589, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00004" },
                    { 590, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00005" },
                    { 591, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00006" },
                    { 592, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00007" },
                    { 593, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00008" },
                    { 607, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 192, "S00004" },
                    { 594, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00009" },
                    { 596, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00011" },
                    { 597, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00012" },
                    { 598, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00013" },
                    { 599, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00014" },
                    { 600, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00015" },
                    { 601, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00016" },
                    { 602, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00017" },
                    { 603, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00018" },
                    { 604, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 180, "S00001" },
                    { 605, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00002" },
                    { 595, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00010" },
                    { 530, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00014" },
                    { 529, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00013" },
                    { 528, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00012" },
                    { 453, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00002" },
                    { 454, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00003" },
                    { 455, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00004" },
                    { 456, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00005" },
                    { 457, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00006" },
                    { 458, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00007" },
                    { 459, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00008" },
                    { 460, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00009" },
                    { 461, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00010" },
                    { 462, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00011" },
                    { 452, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00001" },
                    { 463, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00012" },
                    { 465, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00014" },
                    { 466, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00015" },
                    { 467, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00016" },
                    { 468, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00017" },
                    { 469, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00018" },
                    { 470, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 180, "S00001" },
                    { 471, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00002" },
                    { 472, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00003" },
                    { 473, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 192, "S00004" },
                    { 474, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 180, "S00005" },
                    { 464, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00013" },
                    { 475, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00006" },
                    { 451, 574, new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00017" },
                    { 449, 580, new DateTime(2021, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00005" },
                    { 427, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00010" },
                    { 428, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00011" },
                    { 429, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00012" },
                    { 430, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00013" },
                    { 431, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00014" },
                    { 432, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00015" },
                    { 433, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00016" },
                    { 434, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00017" },
                    { 435, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00018" },
                    { 436, 1048, new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00009" },
                    { 450, 577, new DateTime(2021, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00010" },
                    { 437, 499, new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00016" },
                    { 439, 580, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00001" },
                    { 440, 526, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00009" },
                    { 441, 574, new DateTime(2021, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00018" },
                    { 442, 600, new DateTime(2021, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00008" },
                    { 443, 574, new DateTime(2021, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00007" },
                    { 444, 592, new DateTime(2021, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00004" },
                    { 445, 535, new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00015" },
                    { 446, 574, new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00006" },
                    { 447, 535, new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00012" },
                    { 448, 583, new DateTime(2021, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00011" },
                    { 438, 2260, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00002" },
                    { 476, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00007" },
                    { 477, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 192, "S00008" },
                    { 478, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 126, "S00009" },
                    { 506, 580, new DateTime(2021, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00001" },
                    { 507, 535, new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00015" },
                    { 508, 592, new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00004" },
                    { 509, 580, new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00005" },
                    { 510, 1154, new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00003" },
                    { 511, 574, new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00006" },
                    { 512, 574, new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00018" },
                    { 513, 526, new DateTime(2021, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00009" },
                    { 514, 574, new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00017" },
                    { 515, 1000, new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00008" },
                    { 505, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00018" },
                    { 516, 577, new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00010" },
                    { 518, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00002" },
                    { 519, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00003" },
                    { 520, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00004" },
                    { 521, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00005" },
                    { 522, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00006" },
                    { 523, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00007" },
                    { 524, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00008" },
                    { 525, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00009" },
                    { 526, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00010" },
                    { 527, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00011" },
                    { 517, 0, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00001" },
                    { 504, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00017" },
                    { 503, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00016" },
                    { 502, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00015" },
                    { 479, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00010" },
                    { 480, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 183, "S00011" },
                    { 481, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 135, "S00012" },
                    { 482, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 99, "S00013" },
                    { 483, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 153, "S00014" },
                    { 484, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 135, "S00015" },
                    { 485, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 99, "S00016" },
                    { 486, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00017" },
                    { 487, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00018" },
                    { 488, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00001" },
                    { 489, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00002" },
                    { 490, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00003" },
                    { 491, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00004" },
                    { 492, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00005" },
                    { 493, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00006" },
                    { 494, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00007" },
                    { 495, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00008" },
                    { 496, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00009" },
                    { 497, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00010" },
                    { 498, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00011" },
                    { 499, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00012" },
                    { 500, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00013" },
                    { 501, 0, new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00014" },
                    { 632, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00011" },
                    { 633, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00012" },
                    { 634, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00013" },
                    { 635, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00014" },
                    { 767, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00009" },
                    { 768, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00010" },
                    { 769, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00011" },
                    { 770, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00012" },
                    { 771, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00013" },
                    { 772, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00014" },
                    { 773, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00015" },
                    { 774, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00016" },
                    { 775, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00017" },
                    { 776, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00018" },
                    { 766, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00008" },
                    { 777, 1100, new DateTime(2021, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00012" },
                    { 779, 500, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00013" },
                    { 780, 565, new DateTime(2021, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00015" },
                    { 781, 574, new DateTime(2021, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00018" },
                    { 782, 580, new DateTime(2021, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00001" },
                    { 783, 550, new DateTime(2021, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00009" },
                    { 784, 592, new DateTime(2021, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00004" },
                    { 785, 592, new DateTime(2021, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00008" },
                    { 786, 574, new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00006" },
                    { 787, 580, new DateTime(2021, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00005" },
                    { 788, 577, new DateTime(2021, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00010" },
                    { 778, 1000, new DateTime(2021, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00016" },
                    { 789, 574, new DateTime(2021, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00017" },
                    { 765, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00007" },
                    { 763, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00005" },
                    { 741, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 180, "S00001" },
                    { 742, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00002" },
                    { 743, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00003" },
                    { 744, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 192, "S00004" },
                    { 745, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 180, "S00005" },
                    { 746, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00006" },
                    { 747, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00007" },
                    { 748, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 192, "S00008" },
                    { 749, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 126, "S00009" },
                    { 750, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00010" },
                    { 764, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00006" },
                    { 751, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 183, "S00011" },
                    { 753, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 99, "S00013" },
                    { 754, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 153, "S00014" },
                    { 755, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 135, "S00015" },
                    { 756, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 99, "S00016" },
                    { 757, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00017" },
                    { 758, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00018" },
                    { 759, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00001" },
                    { 760, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00002" },
                    { 761, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00003" },
                    { 762, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00004" },
                    { 752, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 135, "S00012" },
                    { 790, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00001" },
                    { 791, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00002" },
                    { 792, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00003" },
                    { 820, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 99, "S00013" },
                    { 821, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 153, "S00014" },
                    { 822, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 135, "S00015" },
                    { 823, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 99, "S00016" },
                    { 824, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00017" },
                    { 825, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00018" },
                    { 826, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00001" },
                    { 827, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00002" },
                    { 828, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00003" },
                    { 829, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00004" },
                    { 819, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 135, "S00012" },
                    { 830, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00005" },
                    { 832, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00007" },
                    { 833, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00008" },
                    { 834, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00009" },
                    { 835, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00010" },
                    { 836, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00011" },
                    { 837, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00012" },
                    { 838, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00013" },
                    { 839, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00014" },
                    { 840, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00015" },
                    { 841, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00016" },
                    { 831, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00006" },
                    { 818, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 183, "S00011" },
                    { 817, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00010" },
                    { 816, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 126, "S00009" },
                    { 793, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00004" },
                    { 794, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00005" },
                    { 795, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00006" },
                    { 796, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00007" },
                    { 797, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00008" },
                    { 798, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00009" },
                    { 799, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00010" },
                    { 800, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00011" },
                    { 801, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00012" },
                    { 802, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00013" },
                    { 803, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00014" },
                    { 804, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00015" },
                    { 805, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00016" },
                    { 806, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00017" },
                    { 807, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00018" },
                    { 808, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 180, "S00001" },
                    { 809, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00002" },
                    { 810, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00003" },
                    { 811, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 192, "S00004" },
                    { 812, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 180, "S00005" },
                    { 813, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00006" },
                    { 814, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00007" },
                    { 815, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 192, "S00008" },
                    { 740, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00018" },
                    { 426, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00009" },
                    { 739, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00017" },
                    { 737, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00015" },
                    { 662, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00009" },
                    { 663, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00010" },
                    { 664, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00011" },
                    { 665, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00012" },
                    { 666, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00013" },
                    { 667, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00014" },
                    { 668, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00015" },
                    { 669, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00016" },
                    { 670, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00017" },
                    { 671, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00018" },
                    { 661, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00008" },
                    { 672, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 180, "S00001" },
                    { 674, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00003" },
                    { 675, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 192, "S00004" },
                    { 676, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 180, "S00005" },
                    { 677, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00006" },
                    { 678, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00007" },
                    { 679, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 192, "S00008" },
                    { 680, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 126, "S00009" },
                    { 681, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00010" },
                    { 682, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 183, "S00011" },
                    { 683, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 135, "S00012" },
                    { 673, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00002" },
                    { 684, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 99, "S00013" },
                    { 660, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00007" },
                    { 658, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00005" },
                    { 636, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00015" },
                    { 637, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00016" },
                    { 638, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00017" },
                    { 639, 0, new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00018" },
                    { 640, 500, new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00015" },
                    { 641, 1000, new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00016" },
                    { 642, 1160, new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00001" },
                    { 643, 650, new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00008" },
                    { 644, 550, new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00009" },
                    { 645, 592, new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00004" },
                    { 659, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00006" },
                    { 646, 580, new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00005" },
                    { 648, 574, new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00007" },
                    { 649, 574, new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00006" },
                    { 650, 583, new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00011" },
                    { 651, 574, new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00018" },
                    { 652, 574, new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00017" },
                    { 653, 577, new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00010" },
                    { 654, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00001" },
                    { 655, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00002" },
                    { 656, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00003" },
                    { 657, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00004" },
                    { 647, 577, new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00003" },
                    { 685, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 153, "S00014" },
                    { 686, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 135, "S00015" },
                    { 687, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 99, "S00016" },
                    { 715, 574, new DateTime(2021, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00007" },
                    { 716, 592, new DateTime(2021, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00004" },
                    { 717, 580, new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00005" },
                    { 718, 583, new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00011" },
                    { 719, 574, new DateTime(2021, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00006" },
                    { 720, 574, new DateTime(2021, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00017" },
                    { 721, 577, new DateTime(2021, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00010" },
                    { 722, 591, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00008" },
                    { 723, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00001" },
                    { 724, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00002" },
                    { 714, 574, new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00018" },
                    { 725, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00003" },
                    { 727, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00005" },
                    { 728, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00006" },
                    { 729, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00007" },
                    { 730, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00008" },
                    { 731, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00009" },
                    { 732, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00010" },
                    { 733, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00011" },
                    { 734, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00012" },
                    { 735, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00013" },
                    { 736, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00014" },
                    { 726, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00004" },
                    { 713, 526, new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00009" },
                    { 712, 580, new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00001" },
                    { 711, 540, new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00015" },
                    { 688, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00017" },
                    { 689, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00018" },
                    { 690, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00001" },
                    { 691, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00002" },
                    { 692, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00003" },
                    { 693, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00004" },
                    { 694, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00005" },
                    { 695, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00006" },
                    { 696, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00007" },
                    { 697, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00008" },
                    { 698, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00009" },
                    { 699, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00010" },
                    { 700, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00011" },
                    { 701, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00012" },
                    { 702, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00013" },
                    { 703, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00014" },
                    { 704, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00015" },
                    { 705, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00016" },
                    { 706, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00017" },
                    { 707, 0, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00018" },
                    { 708, 1070, new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00012" },
                    { 709, 1160, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00002" },
                    { 710, 577, new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00003" },
                    { 738, 0, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00016" },
                    { 425, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00008" },
                    { 424, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00007" },
                    { 423, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00006" },
                    { 138, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00002" },
                    { 139, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00003" },
                    { 140, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00004" },
                    { 141, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00005" },
                    { 142, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00006" },
                    { 143, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00007" },
                    { 144, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00008" },
                    { 145, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00009" },
                    { 146, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00010" },
                    { 147, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00011" },
                    { 137, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00001" },
                    { 148, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00012" },
                    { 150, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00014" },
                    { 151, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00015" },
                    { 152, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00016" },
                    { 153, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00017" },
                    { 154, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00018" },
                    { 155, 592, new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00008" },
                    { 156, 1000, new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00016" },
                    { 157, 1055, new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00002" },
                    { 158, 600, new DateTime(2021, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00014" },
                    { 159, 535, new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00012" },
                    { 149, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00013" },
                    { 160, 580, new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00001" },
                    { 136, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00018" },
                    { 134, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 99, "S00016" },
                    { 112, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00012" },
                    { 113, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00013" },
                    { 114, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00014" },
                    { 115, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00015" },
                    { 116, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00016" },
                    { 117, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00017" },
                    { 118, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00018" },
                    { 119, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 180, "S00001" },
                    { 120, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00002" },
                    { 121, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00003" },
                    { 135, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00017" },
                    { 122, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 192, "S00004" },
                    { 124, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00006" },
                    { 125, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00007" },
                    { 126, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 192, "S00008" },
                    { 127, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 126, "S00009" },
                    { 128, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00010" },
                    { 129, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 183, "S00011" },
                    { 130, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 135, "S00012" },
                    { 131, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 99, "S00013" },
                    { 132, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 153, "S00014" },
                    { 133, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 135, "S00015" },
                    { 123, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 180, "S00005" },
                    { 161, 526, new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00009" },
                    { 162, 574, new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00017" },
                    { 163, 535, new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00015" },
                    { 191, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00002" },
                    { 192, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00003" },
                    { 193, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 192, "S00004" },
                    { 194, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 180, "S00005" },
                    { 195, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00006" },
                    { 196, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00007" },
                    { 197, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 192, "S00008" },
                    { 198, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 126, "S00009" },
                    { 199, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00010" },
                    { 200, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 183, "S00011" },
                    { 190, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 180, "S00001" },
                    { 201, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 135, "S00012" },
                    { 203, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 153, "S00014" },
                    { 204, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 135, "S00015" },
                    { 205, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 99, "S00016" },
                    { 206, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00017" },
                    { 207, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00018" },
                    { 208, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00001" },
                    { 209, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00002" },
                    { 210, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00003" },
                    { 211, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00004" },
                    { 212, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00005" },
                    { 202, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 99, "S00013" },
                    { 189, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00018" },
                    { 188, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00017" },
                    { 187, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00016" },
                    { 164, 574, new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00018" },
                    { 165, 577, new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00003" },
                    { 166, 592, new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00004" },
                    { 167, 580, new DateTime(2021, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00005" },
                    { 168, 574, new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00007" },
                    { 169, 574, new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00006" },
                    { 170, 1166, new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00011" },
                    { 171, 577, new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00010" },
                    { 172, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00001" },
                    { 173, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00002" },
                    { 174, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00003" },
                    { 175, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00004" },
                    { 176, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00005" },
                    { 177, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00006" },
                    { 178, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00007" },
                    { 179, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00008" },
                    { 180, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00009" },
                    { 181, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00010" },
                    { 182, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00011" },
                    { 183, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00012" },
                    { 184, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00013" },
                    { 185, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00014" },
                    { 186, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00015" },
                    { 111, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00011" },
                    { 213, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00006" },
                    { 110, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00010" },
                    { 108, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00008" },
                    { 33, 577, new DateTime(2021, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00010" },
                    { 34, 574, new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00006" },
                    { 35, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00002" },
                    { 36, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00003" },
                    { 37, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00004" },
                    { 38, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00005" },
                    { 39, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00006" },
                    { 40, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00007" },
                    { 41, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00008" },
                    { 42, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00009" },
                    { 32, 1154, new DateTime(2021, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00003" },
                    { 43, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00010" },
                    { 45, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00012" },
                    { 46, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00013" },
                    { 47, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00014" },
                    { 48, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00015" },
                    { 49, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00016" },
                    { 50, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00017" },
                    { 51, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00018" },
                    { 52, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00002" },
                    { 53, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00003" },
                    { 54, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 192, "S00004" },
                    { 44, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00011" },
                    { 55, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 180, "S00005" },
                    { 31, 574, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00007" },
                    { 29, 574, new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00017" },
                    { 7, 0, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Početno stanje", 580, "S00005" },
                    { 8, 0, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Početno stanje", 574, "S00006" },
                    { 9, 0, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Početno stanje", 574, "S00007" },
                    { 10, 0, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Početno stanje", 589, "S00008" },
                    { 11, 0, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Početno stanje", 1052, "S00009" },
                    { 12, 0, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Početno stanje", 577, "S00010" },
                    { 13, 0, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Početno stanje", 583, "S00011" },
                    { 14, 0, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Početno stanje", 1070, "S00012" },
                    { 15, 0, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Početno stanje", 499, "S00013" },
                    { 16, 117, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Početno stanje", 0, "S00014" },
                    { 30, 584, new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00004" },
                    { 17, 0, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Početno stanje", 535, "S00015" },
                    { 19, 0, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Početno stanje", 574, "S00017" },
                    { 20, 0, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Početno stanje", 574, "S00018" },
                    { 21, 535, new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00012" },
                    { 22, 535, new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00015" },
                    { 23, 580, new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00005" },
                    { 24, 574, new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00018" },
                    { 25, 592, new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00008" },
                    { 26, 1052, new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00009" },
                    { 27, 583, new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00011" },
                    { 28, 353, new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00014" },
                    { 18, 0, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Početno stanje", 3485, "S00016" },
                    { 56, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00006" },
                    { 57, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00007" },
                    { 58, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 192, "S00008" },
                    { 86, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00018" },
                    { 87, 535, new DateTime(2021, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00012" },
                    { 88, 580, new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00001" },
                    { 89, 526, new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00009" },
                    { 90, 580, new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00001" },
                    { 91, 580, new DateTime(2021, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00005" },
                    { 92, 574, new DateTime(2021, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00018" },
                    { 93, 592, new DateTime(2021, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00004" },
                    { 94, 1000, new DateTime(2021, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00014" },
                    { 95, 574, new DateTime(2021, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00007" },
                    { 85, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00017" },
                    { 96, 535, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00015" },
                    { 98, 574, new DateTime(2021, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00006" },
                    { 99, 574, new DateTime(2021, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00017" },
                    { 100, 577, new DateTime(2021, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00010" },
                    { 101, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00001" },
                    { 102, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00002" },
                    { 103, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00003" },
                    { 104, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00004" },
                    { 105, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00005" },
                    { 106, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00006" },
                    { 107, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00007" },
                    { 97, 577, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00003" },
                    { 84, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00016" },
                    { 83, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00015" },
                    { 82, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00014" },
                    { 59, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 126, "S00009" },
                    { 60, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00010" },
                    { 61, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 183, "S00011" },
                    { 62, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 135, "S00012" },
                    { 63, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 99, "S00013" },
                    { 64, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 153, "S00014" },
                    { 65, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 135, "S00015" },
                    { 66, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 99, "S00016" },
                    { 67, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00017" },
                    { 68, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00018" },
                    { 69, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00001" },
                    { 70, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00002" },
                    { 71, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00003" },
                    { 72, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00004" },
                    { 73, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00005" },
                    { 74, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00006" },
                    { 75, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00007" },
                    { 76, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00008" },
                    { 77, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00009" },
                    { 78, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00010" },
                    { 79, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00011" },
                    { 80, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00012" },
                    { 81, 0, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00013" },
                    { 109, 0, new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00009" },
                    { 842, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00017" },
                    { 214, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00007" },
                    { 216, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00009" },
                    { 348, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00001" },
                    { 349, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00002" },
                    { 350, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00003" },
                    { 351, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00004" },
                    { 352, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00005" },
                    { 353, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00006" },
                    { 354, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00007" },
                    { 355, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00008" },
                    { 356, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00009" },
                    { 357, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00010" },
                    { 347, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00018" },
                    { 358, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00011" },
                    { 360, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00013" },
                    { 361, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00014" },
                    { 362, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00015" },
                    { 363, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00016" },
                    { 364, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00017" },
                    { 365, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00018" },
                    { 366, 535, new DateTime(2021, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00012" },
                    { 367, 1000, new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00016" },
                    { 368, 458, new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00014" },
                    { 369, 580, new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00001" },
                    { 359, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00012" },
                    { 370, 2495, new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00013" },
                    { 346, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00017" },
                    { 344, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 135, "S00015" },
                    { 322, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00011" },
                    { 323, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00012" },
                    { 324, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00013" },
                    { 325, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00014" },
                    { 326, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00015" },
                    { 327, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00016" },
                    { 328, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00017" },
                    { 329, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00018" },
                    { 330, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 180, "S00001" },
                    { 331, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00002" },
                    { 345, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 99, "S00016" },
                    { 332, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00003" },
                    { 334, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 180, "S00005" },
                    { 335, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00006" },
                    { 336, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00007" },
                    { 337, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 192, "S00008" },
                    { 338, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 126, "S00009" },
                    { 339, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00010" },
                    { 340, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 183, "S00011" },
                    { 341, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 135, "S00012" },
                    { 342, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 99, "S00013" },
                    { 343, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 153, "S00014" },
                    { 333, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 192, "S00004" },
                    { 371, 592, new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00004" },
                    { 372, 574, new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00018" },
                    { 373, 574, new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00017" },
                    { 401, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00002" },
                    { 402, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00003" },
                    { 403, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 192, "S00004" },
                    { 404, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 180, "S00005" },
                    { 405, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00006" },
                    { 406, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00007" },
                    { 407, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 192, "S00008" },
                    { 408, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 126, "S00009" },
                    { 409, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00010" },
                    { 410, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 183, "S00011" },
                    { 400, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 180, "S00001" },
                    { 411, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 135, "S00012" },
                    { 413, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 153, "S00014" },
                    { 414, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 135, "S00015" },
                    { 415, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 99, "S00016" },
                    { 416, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00017" },
                    { 417, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00018" },
                    { 418, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00001" },
                    { 419, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00002" },
                    { 420, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00003" },
                    { 421, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00004" },
                    { 422, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00005" },
                    { 412, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 99, "S00013" },
                    { 399, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00018" },
                    { 398, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00017" },
                    { 397, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00016" },
                    { 374, 600, new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00008" },
                    { 375, 574, new DateTime(2021, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00007" },
                    { 376, 577, new DateTime(2021, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00003" },
                    { 377, 535, new DateTime(2021, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00015" },
                    { 378, 535, new DateTime(2021, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00012" },
                    { 379, 580, new DateTime(2021, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00005" },
                    { 380, 577, new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00010" },
                    { 381, 574, new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00006" },
                    { 382, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00001" },
                    { 383, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00002" },
                    { 384, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00003" },
                    { 385, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00004" },
                    { 386, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00005" },
                    { 387, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00006" },
                    { 388, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00007" },
                    { 389, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00008" },
                    { 390, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00009" },
                    { 391, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00010" },
                    { 392, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00011" },
                    { 393, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00012" },
                    { 394, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00013" },
                    { 395, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00014" },
                    { 396, 0, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00015" },
                    { 321, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00010" },
                    { 215, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00008" },
                    { 320, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00009" },
                    { 318, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00007" },
                    { 243, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00004" },
                    { 244, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00005" },
                    { 245, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00006" },
                    { 246, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00007" },
                    { 247, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00008" },
                    { 248, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00009" },
                    { 249, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00010" },
                    { 250, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00011" },
                    { 251, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00012" },
                    { 252, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00013" },
                    { 242, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00003" },
                    { 253, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00014" },
                    { 255, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00016" },
                    { 256, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00017" },
                    { 257, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00018" },
                    { 258, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 180, "S00001" },
                    { 259, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00002" },
                    { 260, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00003" },
                    { 261, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 192, "S00004" },
                    { 262, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 180, "S00005" },
                    { 263, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00006" },
                    { 264, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00007" },
                    { 254, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00015" },
                    { 265, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 192, "S00008" },
                    { 241, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00002" },
                    { 239, 574, new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00006" },
                    { 217, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00010" },
                    { 218, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00011" },
                    { 219, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00012" },
                    { 220, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00013" },
                    { 221, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00014" },
                    { 222, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00015" },
                    { 223, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00016" },
                    { 224, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00017" },
                    { 225, 0, new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00018" },
                    { 226, 535, new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00012" },
                    { 240, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00001" },
                    { 227, 1000, new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00016" },
                    { 229, 600, new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00014" },
                    { 230, 577, new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00003" },
                    { 231, 574, new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00007" },
                    { 232, 574, new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00018" },
                    { 233, 592, new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00004" },
                    { 234, 574, new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00017" },
                    { 235, 580, new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00005" },
                    { 236, 592, new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00008" },
                    { 237, 535, new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00015" },
                    { 238, 577, new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00010" },
                    { 228, 580, new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00001" },
                    { 266, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 126, "S00009" },
                    { 267, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 177, "S00010" },
                    { 268, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 183, "S00011" },
                    { 296, 535, new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00012" },
                    { 297, 1000, new DateTime(2021, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00016" },
                    { 298, 580, new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00001" },
                    { 299, 535, new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00015" },
                    { 300, 574, new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00017" },
                    { 301, 574, new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00018" },
                    { 302, 592, new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00004" },
                    { 303, 592, new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00008" },
                    { 304, 458, new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00014" },
                    { 305, 574, new DateTime(2021, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00007" },
                    { 295, 1300, new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00002" },
                    { 306, 580, new DateTime(2021, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00005" },
                    { 308, 574, new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00006" },
                    { 309, 577, new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00003" },
                    { 310, 577, new DateTime(2021, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00010" },
                    { 311, 1166, new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00011" },
                    { 312, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00001" },
                    { 313, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00002" },
                    { 314, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00003" },
                    { 315, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00004" },
                    { 316, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00005" },
                    { 317, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00006" },
                    { 307, 530, new DateTime(2021, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00009" },
                    { 294, 583, new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Knjiženje izvoda", 0, "S00011" },
                    { 293, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00018" },
                    { 292, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00017" },
                    { 269, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 135, "S00012" },
                    { 270, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 99, "S00013" },
                    { 271, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 153, "S00014" },
                    { 272, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 135, "S00015" },
                    { 273, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 99, "S00016" },
                    { 274, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00017" },
                    { 275, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 174, "S00018" },
                    { 276, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00001" },
                    { 277, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00002" },
                    { 278, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00003" },
                    { 279, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00004" },
                    { 280, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00005" },
                    { 281, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00006" },
                    { 282, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00007" },
                    { 283, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00008" },
                    { 284, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00009" },
                    { 285, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00010" },
                    { 286, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00011" },
                    { 287, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00012" },
                    { 288, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00013" },
                    { 289, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00014" },
                    { 290, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00015" },
                    { 291, 0, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00016" },
                    { 319, 0, new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00008" },
                    { 843, 0, new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaduzenje", 200, "S00018" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "Traffics",
                keyColumn: "ID",
                keyValue: 843);
        }
    }
}
