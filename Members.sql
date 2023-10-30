USE library; -- Assuming "library" is your database name

-- Create a new "Members" table with a registration date column
CREATE TABLE Members
(
    MemberID INT PRIMARY KEY,
    Name NVARCHAR(255),
    PhoneNumber NVARCHAR(15),
    RegistrationDate DATE
);