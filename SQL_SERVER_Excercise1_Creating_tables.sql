Use  LPU_Db;

-- 1.  Create table zip code
Create Table ZIPCODE_INFO(Zip_Code varchar(5),
						  City varchar(10));

-- 2. Create table instructor info
Create Table INSTRUCTOR_INFO(InstructorID numeric(8,0),
						  Instructor_First_Name varchar(15),
						  Instructor_Last_Name varchar(15));

-- 3. Create table Course info
Create Table COURSE_INFO(Course_No numeric(8,0),
						 Cost Numeric(5,2));

-- 4. Create table Course info
Create Table STUDENT_INFO(Student_ID numeric(8,0),
						 Student_First_Name varchar(15),
						 Student_Last_Name varchar(15));

-- 5. Create table Course info
Create Table SECTION_INFO(Section_ID numeric(8,0),
						 Course_NO Numeric(8,0),
						 Section_No numeric(5),
						 Instructor_ID numeric(8,0));

-- 6. Create table Enrollment info
Create Table ENROLLMENT_INFO(Student_Id numeric(8,0),
							 Section_Id numeric(8,0));

-- 7. Create table Grade info
Create Table GRADE_INFO(Student_Id numeric(8,0),
						Section_Id numeric(8,0),
						Grade_Type_Code char(2),
						Grade_Code_Occurance numeric(5));