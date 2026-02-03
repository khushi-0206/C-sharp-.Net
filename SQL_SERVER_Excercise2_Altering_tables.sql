Use LPU_Db

-- Add State in Zip Code info table
Alter table ZIPCODE_INFO Add State varchar(2);

-- Add Street Address and zip code in istructor info table
Alter table INSTRUCTOR_INFO Add Street_Address varchar(50), Zip_Code varchar(5);

-- Add Course name and prequequisite in course info table
Alter table COURSE_INFO Add CourseName varchar(50), Course_Prerequisite numeric(8,0);

-- Add Street Address and zip code in student info table
Alter table STUDENT_INFO Add Street_Address varchar(50), Zip_Code varchar(5);

-- Add location and capacity in section info table
Alter table SECTION_INFO Add Location varchar(50), Capacity numeric(3,0);

-- Add Enrollement date in enrollment info
Alter table ENROLLMENT_INFO Add Enrollment_Date Date;

-- Add Numeric grade in Grade info table
Alter table GRADE_INFO Add Numeric_Grade numeric(3,0);

select * from GRADE_INFO; -- to check for other table change the table name here...