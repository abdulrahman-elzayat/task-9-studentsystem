using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace task_9_studentsystem.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "studentes",
                columns: table => new
                {
                    studentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "Varchar(100)", nullable: false),
                    phonenumber = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    registrediOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    birthday = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentes", x => x.studentId);
                });

            migrationBuilder.CreateTable(
                name: "coursees",
                columns: table => new
                {
                    courseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "Varchar(80)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    startDate = table.Column<int>(type: "int", nullable: false),
                    endDate = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    studentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coursees", x => x.courseId);
                    table.ForeignKey(
                        name: "FK_coursees_studentes_studentId",
                        column: x => x.studentId,
                        principalTable: "studentes",
                        principalColumn: "studentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "homeworkes",
                columns: table => new
                {
                    homeworkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    content = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    contentType = table.Column<int>(type: "int", nullable: false),
                    submissonTime = table.Column<int>(type: "int", nullable: false),
                    studentId = table.Column<int>(type: "int", nullable: false),
                    courseid = table.Column<int>(type: "int", nullable: false),
                    studentid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_homeworkes", x => x.homeworkId);
                    table.ForeignKey(
                        name: "FK_homeworkes_coursees_courseid",
                        column: x => x.courseid,
                        principalTable: "coursees",
                        principalColumn: "courseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_homeworkes_studentes_studentId",
                        column: x => x.studentId,
                        principalTable: "studentes",
                        principalColumn: "studentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "resourcees",
                columns: table => new
                {
                    resourceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "Varchar(50)", nullable: false),
                    URL = table.Column<int>(type: "int", unicode: false, nullable: false),
                    ResourceType = table.Column<int>(type: "int", nullable: false),
                    courseid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resourcees", x => x.resourceId);
                    table.ForeignKey(
                        name: "FK_resourcees_coursees_courseid",
                        column: x => x.courseid,
                        principalTable: "coursees",
                        principalColumn: "courseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_coursees_studentId",
                table: "coursees",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_homeworkes_courseid",
                table: "homeworkes",
                column: "courseid");

            migrationBuilder.CreateIndex(
                name: "IX_homeworkes_studentId",
                table: "homeworkes",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_resourcees_courseid",
                table: "resourcees",
                column: "courseid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "homeworkes");

            migrationBuilder.DropTable(
                name: "resourcees");

            migrationBuilder.DropTable(
                name: "coursees");

            migrationBuilder.DropTable(
                name: "studentes");
        }
    }
}
