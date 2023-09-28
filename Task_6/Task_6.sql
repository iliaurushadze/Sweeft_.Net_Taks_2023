
-- 1. დაწერეთ sql რომელიც ააგებს შესაბამის table-ებს.

-- Teacher table
CREATE TABLE Teacher (
    TeacherID INT PRIMARY KEY AUTO_INCREMENT, 
    FirstName VARCHAR(255),
    LastName VARCHAR(255),
    Gender CHAR(1),
    Subject VARCHAR(255)
);

-- Pupil table
CREATE TABLE Pupil (
    PupilID INT PRIMARY KEY AUTO_INCREMENT,
    FirstName VARCHAR(255),
    LastName VARCHAR(255),
    Gender CHAR(1),
    Class VARCHAR(255)
);

-- Table to represent the many-to-many relationship
CREATE TABLE TeacherPupil (
    TeacherID INT,
    PupilID INT,
    PRIMARY KEY (TeacherID, PupilID),
    FOREIGN KEY (TeacherID) REFERENCES Teacher(TeacherID),
    FOREIGN KEY (PupilID) REFERENCES Pupil(PupilID)
);

-- 2. დაწერეთ sql რომელიც დააბრუნებს ყველა მასწავლებელს, რომელიც ასწავლის მოსწავლეს, რომელის სახელია: „გიორგი“ .

SELECT DISTINCT t.FirstName, t.LastName
FROM Teacher t
JOIN TeacherPupil tp ON t.TeacherID = tp.TeacherID
JOIN Pupil p ON tp.PupilID = p.PupilID
WHERE p.FirstName = 'George';