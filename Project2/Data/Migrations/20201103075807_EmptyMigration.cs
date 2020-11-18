using Microsoft.EntityFrameworkCore.Migrations;

namespace Project2.Data.Migrations
{
    public partial class EmptyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AFiles");

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeNumber = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(nullable: false),
                    Attrition = table.Column<string>(nullable: true),
                    BusinessTravel = table.Column<string>(nullable: true),
                    DailyRate = table.Column<int>(nullable: false),
                    Department = table.Column<string>(nullable: true),
                    DistanceFromHome = table.Column<string>(nullable: true),
                    Education = table.Column<string>(nullable: true),
                    EducationField = table.Column<string>(nullable: true),
                    EmployeeCount = table.Column<string>(nullable: true),
                    EnvironmentSatisfaction = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    HourlyRate = table.Column<int>(nullable: false),
                    JobInvolvement = table.Column<string>(nullable: true),
                    JobLevel = table.Column<string>(nullable: true),
                    JobRole = table.Column<string>(nullable: true),
                    JobSatisfaction = table.Column<string>(nullable: true),
                    MaritalStatus = table.Column<string>(nullable: true),
                    MonthlyIncome = table.Column<int>(nullable: false),
                    MonthlyRate = table.Column<int>(nullable: false),
                    NumCompaniesWorked = table.Column<string>(nullable: true),
                    Over18 = table.Column<string>(nullable: true),
                    OverTime = table.Column<string>(nullable: true),
                    PercentSalaryHike = table.Column<int>(nullable: false),
                    PerformanceRating = table.Column<int>(nullable: false),
                    RelationshipSatisfaction = table.Column<string>(nullable: true),
                    StandardHours = table.Column<int>(nullable: false),
                    StockOptionLevel = table.Column<string>(nullable: true),
                    TotalWorkingYears = table.Column<string>(nullable: true),
                    TrainingTimesLastYear = table.Column<string>(nullable: true),
                    WorkLifeBalance = table.Column<string>(nullable: true),
                    YearsAtCompany = table.Column<string>(nullable: true),
                    YearsInCurrentRole = table.Column<string>(nullable: true),
                    YearsSinceLastPromotion = table.Column<string>(nullable: true),
                    YearsWithCurrManager = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeNumber);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.CreateTable(
                name: "AFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AFiles", x => x.Id);
                });
        }
    }
}
