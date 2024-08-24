USE University
GO

-- Create schema if not already existing
CREATE SCHEMA UniversitySchema
GO

DROP TABLE IF EXISTS UniversitySchema.Students;
DROP TABLE IF EXISTS UniversitySchema.Groups;
DROP TABLE IF EXISTS UniversitySchema.Faculties;

ALTER TABLE Students
ADD CONSTRAINT DF_RegistrationDate DEFAULT GETDATE() FOR RegistrationDate;

-- Create Faculties table with a unique constraint on FacultyName
CREATE TABLE UniversitySchema.Faculties (
    FacultyId INT PRIMARY KEY IDENTITY(1, 1),
    FacultyName VARCHAR(100) UNIQUE,  -- Added unique constraint
    Department VARCHAR(100),
    Note VARCHAR(100)
);

-- Create Groups table with a unique constraint on GroupName
CREATE TABLE UniversitySchema.Groups (
    GroupId INT PRIMARY KEY IDENTITY(1, 1),
    GroupName VARCHAR(100) UNIQUE,  -- Added unique constraint
    Faculty VARCHAR(100),
    AmountOfStudents INT,
    GroupAverage FLOAT,
    CONSTRAINT FK_Faculty FOREIGN KEY (Faculty)
    REFERENCES UniversitySchema.Faculties(FacultyName)
    ON DELETE CASCADE
);

-- Create Students table with a foreign key constraint referencing GroupName
CREATE TABLE UniversitySchema.Students (
    StudentId INT IDENTITY(1, 1) PRIMARY KEY,
    RegistrationDate DATE,
    Surname VARCHAR(100),
    Name VARCHAR(100),
    GroupName VARCHAR(100),
    AverageScore FLOAT,
    CONSTRAINT FK_GroupName FOREIGN KEY (GroupName) 
    REFERENCES UniversitySchema.Groups(GroupName)
    ON DELETE CASCADE
);

-- Insert data into Faculties table
INSERT INTO UniversitySchema.Faculties (FacultyName, Department, Note)
VALUES 
('Faculty of Computer Science', 'Computer Science Department', 'Main faculty for computer-related disciplines'),
('Faculty of Engineering', 'Engineering Department', 'Covers various engineering disciplines'),
('Faculty of Arts', 'Arts Department', 'Focuses on humanities and arts'),
('Faculty of Business', 'Business Department', 'Focuses on business administration and management'),
('Faculty of Law', 'Law Department', 'Covers various fields of law');

-- Insert data into Groups table
INSERT INTO UniversitySchema.Groups (GroupName, Faculty, AmountOfStudents, GroupAverage)
VALUES 
('CS101', 'Faculty of Computer Science', 25, 85.5),
('CS102', 'Faculty of Computer Science', 25, 88.1),
('ENG201', 'Faculty of Engineering', 25, 78.2),
('ENG202', 'Faculty of Engineering', 25, 81.3),
('ART301', 'Faculty of Arts', 25, 87.0),
('ART302', 'Faculty of Arts', 25, 83.7),
('BUS401', 'Faculty of Business', 25, 79.5),
('LAW501', 'Faculty of Law', 25, 86.4);


-- Insert data into Students table
INSERT INTO UniversitySchema.Students (RegistrationDate, Surname, Name, GroupName, AverageScore)
VALUES 
-- Students in CS101
('2023-09-01', 'Smith', 'John', 'CS101', 88.5),
('2023-09-02', 'Johnson', 'Emily', 'CS101', 82.0),
('2023-09-03', 'Williams', 'David', 'CS101', 84.7),
('2023-09-04', 'Brown', 'Emma', 'CS101', 90.1),
('2023-09-05', 'Jones', 'Michael', 'CS101', 87.4),
('2023-09-06', 'Garcia', 'Sophia', 'CS101', 86.5),
('2023-09-07', 'Martinez', 'Olivia', 'CS101', 85.3),
('2023-09-08', 'Davis', 'Daniel', 'CS101', 89.6),
('2023-09-09', 'Rodriguez', 'Mia', 'CS101', 84.9),
('2023-09-10', 'Lopez', 'Isabella', 'CS101', 87.2),

-- Students in CS102
('2023-09-01', 'Nguyen', 'Lucas', 'CS102', 89.1),
('2023-09-02', 'Perez', 'Amelia', 'CS102', 85.6),
('2023-09-03', 'Hall', 'Mason', 'CS102', 90.0),
('2023-09-04', 'Allen', 'Lily', 'CS102', 87.8),
('2023-09-05', 'Young', 'Aiden', 'CS102', 88.4),
('2023-09-06', 'King', 'Zoe', 'CS102', 89.9),
('2023-09-07', 'Wright', 'Daniel', 'CS102', 86.7),
('2023-09-08', 'Scott', 'Ella', 'CS102', 88.2),
('2023-09-09', 'Torres', 'Liam', 'CS102', 87.3),
('2023-09-10', 'Roberts', 'Grace', 'CS102', 88.6),

-- Students in ENG201
('2023-09-01', 'Lewis', 'Oliver', 'ENG201', 77.5),
('2023-09-02', 'Walker', 'Sofia', 'ENG201', 78.9),
('2023-09-03', 'Young', 'Lucas', 'ENG201', 79.2),
('2023-09-04', 'Hernandez', 'Victoria', 'ENG201', 80.1),
('2023-09-05', 'Lee', 'Jackson', 'ENG201', 76.4),
('2023-09-06', 'Hall', 'Layla', 'ENG201', 77.7),
('2023-09-07', 'Allen', 'Sebastian', 'ENG201', 78.3),
('2023-09-08', 'Adams', 'Zoe', 'ENG201', 79.4),
('2023-09-09', 'Baker', 'Henry', 'ENG201', 77.9),
('2023-09-10', 'Gonzalez', 'Ava', 'ENG201', 78.6),

-- Students in ENG202
('2023-09-01', 'Parker', 'Matthew', 'ENG202', 81.5),
('2023-09-02', 'Evans', 'Luna', 'ENG202', 80.4),
('2023-09-03', 'Edwards', 'Owen', 'ENG202', 82.1),
('2023-09-04', 'Collins', 'Charlotte', 'ENG202', 80.7),
('2023-09-05', 'Stewart', 'Elijah', 'ENG202', 81.3),
('2023-09-06', 'Sanchez', 'Mila', 'ENG202', 82.4),
('2023-09-07', 'Morris', 'Grayson', 'ENG202', 81.9),
('2023-09-08', 'Rogers', 'Penelope', 'ENG202', 80.9),
('2023-09-09', 'Reed', 'Liam', 'ENG202', 82.0),
('2023-09-10', 'Cook', 'Victoria', 'ENG202', 81.2),

-- Students in ART301
('2023-09-01', 'Rivera', 'Chloe', 'ART301', 89.4),
('2023-09-02', 'Cooper', 'Mason', 'ART301', 88.6),
('2023-09-03', 'Cox', 'Ella', 'ART301', 87.2),
('2023-09-04', 'Howard', 'Noah', 'ART301', 86.9),
('2023-09-05', 'Ward', 'Mia', 'ART301', 88.0),
('2023-09-06', 'Bailey', 'James', 'ART301', 87.7),
('2023-09-07', 'Hughes', 'Harper', 'ART301', 89.1),
('2023-09-08', 'Flores', 'Benjamin', 'ART301', 86.5),
('2023-09-09', 'Nelson', 'Abigail', 'ART301', 87.3),
('2023-09-10', 'Mitchell', 'Lucas', 'ART301', 88.4),

-- Students in ART302
('2023-09-01', 'Morgan', 'Avery', 'ART302', 83.9),
('2023-09-02', 'Bell', 'William', 'ART302', 82.7),
('2023-09-03', 'Griffin', 'Lily', 'ART302', 84.5),
('2023-09-04', 'Russell', 'Emily', 'ART302', 85.1),
('2023-09-05', 'Kim', 'Jackson', 'ART302', 83.3),
('2023-09-06', 'White', 'Ethan', 'ART302', 84.1),
('2023-09-07', 'Clark', 'Amelia', 'ART302', 85.6),
('2023-09-08', 'Rogers', 'Daniel', 'ART302', 83.2),
('2023-09-09', 'Scott', 'Sophia', 'ART302', 84.7),
('2023-09-10', 'King', 'Oliver', 'ART302', 85.3),

-- Students in BUS401
('2023-09-01', 'Adams', 'Isabella', 'BUS401', 79.5),
('2023-09-02', 'Brooks', 'Mason', 'BUS401', 80.6),
('2023-09-03', 'Gonzalez', 'Ava', 'BUS401', 78.4),
('2023-09-04', 'Diaz', 'Elijah', 'BUS401', 79.7),
('2023-09-05', 'Myers', 'Emma', 'BUS401', 80.2),
('2023-09-06', 'Murphy', 'James', 'BUS401', 79.0),
('2023-09-07', 'Ramirez', 'Mia', 'BUS401', 78.8),
('2023-09-08', 'Richards', 'Lucas', 'BUS401', 80.5),
('2023-09-09', 'Ross', 'Olivia', 'BUS401', 78.9),
('2023-09-10', 'Sanders', 'Aiden', 'BUS401', 80.3),

-- Students in LAW501
('2023-09-01', 'Perez', 'Sophia', 'LAW501', 86.4),
('2023-09-02', 'Hughes', 'Jackson', 'LAW501', 85.9),
('2023-09-03', 'Sullivan', 'Chloe', 'LAW501', 87.1),
('2023-09-04', 'Cook', 'Liam', 'LAW501', 86.7),
('2023-09-05', 'Peterson', 'Emily', 'LAW501', 87.0),
('2023-09-06', 'Gray', 'Lucas', 'LAW501', 85.5),
('2023-09-07', 'Morales', 'Olivia', 'LAW501', 86.3),
('2023-09-08', 'Price', 'Daniel', 'LAW501', 85.7),
('2023-09-09', 'Long', 'Avery', 'LAW501', 86.9),
('2023-09-10', 'Jenkins', 'Mason', 'LAW501', 87.2);


-- Query to check data
SELECT * FROM UniversitySchema.Faculties;
SELECT * FROM UniversitySchema.Groups;
SELECT * FROM UniversitySchema.Students;

