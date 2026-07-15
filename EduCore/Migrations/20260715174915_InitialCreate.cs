using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EduCore.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instructor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor", x => x.Id);
                    table.CheckConstraint("CK_Instructor_Salary_Min", "[Salary] > 0");
                    table.ForeignKey(
                        name: "FK_Instructor_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    Hours = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    InstructorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                    table.CheckConstraint("CK_Course_Hours_Min", "[Hours] > 0");
                    table.CheckConstraint("CK_Course_Price_Min", "[Price] >=0");
                    table.ForeignKey(
                        name: "FK_Course_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Course_Instructor_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Enrollment",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    EnrollDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Progress = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollment", x => new { x.StudentId, x.CourseId });
                    table.CheckConstraint("CK_Enrollment_Progress_Range", "[Progress] >=0 AND [Progress] <=100");
                    table.ForeignKey(
                        name: "FK_Enrollment_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollment_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Software Development & Programming", "Computer Science" },
                    { 2, "AI & Machine Learning", "Artificial Intelligence" },
                    { 3, "Security & Networking", "Cyber Security" },
                    { 4, "Business Administration", "Business" },
                    { 5, "UI/UX & Graphic Design", "Design" },
                    { 6, "Data Analysis and Big Data", "Data Science" },
                    { 7, "English, Spanish, and German", "Languages" }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "BirthDate", "Email", "FullName", "Phone", "RegisterDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "youssef.g@example.com", "Youssef Gamal", "01012345671", new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2001, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "aya.m@example.com", "Aya Mahmoud", "01123456782", new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(1999, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mahmoud.s@example.com", "Mahmoud Salah", "01234567893", new DateTime(2022, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2002, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "fatma.s@example.com", "Fatma Said", "01545678904", new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(1998, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "karim.h@example.com", "Karim Hassan", "01056789015", new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2003, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "nada.t@example.com", "Nada Tarek", "01167890126", new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2000, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "amr.z@example.com", "Amr Zaki", "01278901237", new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2001, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoda.a@example.com", "Hoda Ali", "01589012348", new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(1997, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "mostafa.k@example.com", "Mostafa Kamal", "01090123459", new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2002, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "rana.o@example.com", "Rana Othman", "01101234560", new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(1999, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "omar.f@example.com", "Omar Fathy", "01212345671", new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(2001, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "salma.a@example.com", "Salma Adel", "01523456782", new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(1998, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ahmed.m@example.com", "Ahmed Mostafa", "01034567893", new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(2003, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "mona.i@example.com", "Mona Ibrahim", "01145678904", new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(2000, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "tarek.k@example.com", "Tarek Khaled", "01256789015", new DateTime(2022, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(1999, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "dina.y@example.com", "Dina Youssef", "01567890126", new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(2002, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "hassan.w@example.com", "Hassan Wael", "01078901237", new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(2001, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "nour.f@example.com", "Nour Farouk", "01189012348", new DateTime(2022, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(1998, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ziad.z@example.com", "Ziad Ziad", "01290123459", new DateTime(2020, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, new DateTime(2000, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "yasmine.s@example.com", "Yasmine Samy", "01501234560", new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, new DateTime(1999, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ibrahim.g@example.com", "Ibrahim Gamal", "01011122233", new DateTime(2022, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, new DateTime(2003, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "laila.m@example.com", "Laila Mahmoud", "01122233344", new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, new DateTime(1997, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "kareem.s@example.com", "Kareem Salah", "01233344455", new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, new DateTime(2001, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "sara.s@example.com", "Sara Said", "01544455566", new DateTime(2022, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, new DateTime(1998, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ali.h@example.com", "Ali Hassan", "01055566677", new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, new DateTime(2002, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "habiba.t@example.com", "Habiba Tarek", "01166677788", new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, new DateTime(2000, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "wael.z@example.com", "Wael Zaki", "01277788899", new DateTime(2022, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, new DateTime(1999, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "farah.a@example.com", "Farah Ali", "01588899900", new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, new DateTime(2001, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "saad.k@example.com", "Saad Kamal", "01099900011", new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, new DateTime(2003, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "malak.o@example.com", "Malak Othman", "01100011122", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Instructor",
                columns: new[] { "Id", "DepartmentId", "Email", "FullName", "HireDate", "Phone", "Salary" },
                values: new object[,]
                {
                    { 1, 1, "ahmed.ali@univ.edu", "Ahmed Ali", new DateTime(2015, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "01011110001", 12000.00m },
                    { 2, 1, "sara.hassan@univ.edu", "Sara Hassan", new DateTime(2016, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "01122220002", 13500.50m },
                    { 3, 2, "m.tarek@univ.edu", "Mohamed Tarek", new DateTime(2018, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "01233330003", 15000.00m },
                    { 4, 2, "nour.y@univ.edu", "Nour Youssef", new DateTime(2019, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "01544440004", 14200.00m },
                    { 5, 3, "omar.khaled@univ.edu", "Omar Khaled", new DateTime(2014, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "01055550005", 16000.00m },
                    { 6, 4, "mona.i@univ.edu", "Mona Ibrahim", new DateTime(2020, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "01166660006", 11000.00m },
                    { 7, 4, "hany.said@univ.edu", "Hany Said", new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "01277770007", 11500.00m },
                    { 8, 5, "dina.adel@univ.edu", "Dina Adel", new DateTime(2017, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "01588880008", 12500.00m },
                    { 9, 6, "tarek.z@univ.edu", "Tarek Ziad", new DateTime(2016, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "01099990009", 14000.00m },
                    { 10, 7, "salma.f@univ.edu", "Salma Farouk", new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "01100000010", 9500.00m },
                    { 11, 1, "yassin.m@univ.edu", "Yassin Mahmoud", new DateTime(2019, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "01211110011", 13000.00m },
                    { 12, 2, "laila.k@univ.edu", "Laila Kamal", new DateTime(2013, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "01522220012", 17000.00m },
                    { 13, 3, "ibrahim.m@univ.edu", "Ibrahim Mostafa", new DateTime(2018, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "01033330013", 14500.00m },
                    { 14, 5, "yasmine.f@univ.edu", "Yasmine Fathy", new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "01144440014", 10500.00m },
                    { 15, 6, "kareem.w@univ.edu", "Kareem Wael", new DateTime(2015, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "01255550015", 15500.00m }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "DepartmentId", "Description", "Hours", "InstructorId", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Learn C# from scratch", 40, 1, 1500.00m, "C# Basics" },
                    { 2, 1, "Build web apps", 60, 2, 2500.00m, "ASP.NET Core" },
                    { 3, 2, "Intro to ML", 50, 3, 3000.00m, "Machine Learning" },
                    { 4, 2, "Neural networks", 70, 4, 3500.00m, "Deep Learning" },
                    { 5, 3, "Penetration testing", 45, 5, 2800.00m, "Ethical Hacking" },
                    { 6, 3, "Securing networks", 55, 13, 2600.00m, "Network Security" },
                    { 7, 4, "Marketing principles", 30, 6, 1000.00m, "Marketing 101" },
                    { 8, 4, "PMP basics", 40, 7, 1800.00m, "Project Management" },
                    { 9, 5, "Design interfaces", 35, 8, 1200.00m, "UI/UX Fundamentals" },
                    { 10, 6, "Pandas & NumPy", 50, 9, 2200.00m, "Python for Data Science" },
                    { 11, 7, "Intermediate conversation", 40, 10, 800.00m, "English B2" },
                    { 12, 1, "Algorithms in C#", 45, 11, 1700.00m, "Data Structures" },
                    { 13, 2, "Image processing", 60, 12, 3200.00m, "Computer Vision" },
                    { 14, 3, "Encryption techniques", 50, 5, 2900.00m, "Cryptography" },
                    { 15, 5, "Photoshop & Illustrator", 40, 14, 1400.00m, "Graphic Design" },
                    { 16, 6, "Hadoop & Spark", 65, 15, 3100.00m, "Big Data" },
                    { 17, 7, "Beginner Spanish", 30, 10, 700.00m, "Spanish A1" },
                    { 18, 4, "Human resources basics", 35, 6, 1100.00m, "HR Management" },
                    { 19, 5, "HTML, CSS, JS", 45, 8, 1300.00m, "Web Design" },
                    { 20, 1, "AWS & Azure", 55, 2, 2700.00m, "Cloud Computing" }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "CourseId", "StudentId", "EnrollDate", "Progress", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, "Completed" },
                    { 2, 1, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, "Active" },
                    { 3, 2, new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, "Active" }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "CourseId", "StudentId", "EnrollDate", "Status" },
                values: new object[] { 4, 2, new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "CourseId", "StudentId", "EnrollDate", "Progress", "Status" },
                values: new object[,]
                {
                    { 5, 3, new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, "Completed" },
                    { 1, 4, new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, "Active" },
                    { 9, 4, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Active" },
                    { 7, 5, new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, "Completed" },
                    { 8, 5, new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, "Completed" },
                    { 11, 6, new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Active" },
                    { 10, 7, new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, "Active" },
                    { 2, 8, new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "Cancelled" },
                    { 5, 9, new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, "Completed" },
                    { 6, 9, new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, "Completed" },
                    { 12, 10, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Active" },
                    { 13, 11, new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, "Active" },
                    { 14, 12, new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, "Active" },
                    { 15, 13, new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, "Completed" },
                    { 16, 14, new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 75, "Active" },
                    { 17, 15, new DateTime(2023, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Active" },
                    { 18, 16, new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, "Completed" },
                    { 19, 17, new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, "Active" },
                    { 20, 18, new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, "Active" }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "CourseId", "StudentId", "EnrollDate", "Status" },
                values: new object[,]
                {
                    { 1, 19, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" },
                    { 2, 20, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending" }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "CourseId", "StudentId", "EnrollDate", "Progress", "Status" },
                values: new object[,]
                {
                    { 3, 21, new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, "Completed" },
                    { 4, 22, new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, "Active" },
                    { 5, 23, new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, "Active" },
                    { 6, 24, new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Active" },
                    { 7, 25, new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, "Completed" },
                    { 8, 26, new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, "Active" },
                    { 9, 27, new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Active" },
                    { 10, 28, new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, "Completed" }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "CourseId", "StudentId", "EnrollDate", "Status" },
                values: new object[] { 11, 29, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cancelled" });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "CourseId", "StudentId", "EnrollDate", "Progress", "Status" },
                values: new object[] { 12, 30, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Active" });

            migrationBuilder.CreateIndex(
                name: "IX_Course_DepartmentId",
                table: "Course",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_InstructorId",
                table: "Course",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_Name",
                table: "Department",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_CourseId",
                table: "Enrollment",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_DepartmentId",
                table: "Instructor",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_Email",
                table: "Instructor",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_Phone",
                table: "Instructor",
                column: "Phone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_Email",
                table: "Student",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_Phone",
                table: "Student",
                column: "Phone",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrollment");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Instructor");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
