CREATE TABLE [dbo].[Books]
(
	BookID INT PRIMARY KEY IDENTITY(1,1),
    Title VARCHAR(255),
    Author VARCHAR(100),
    ISBN VARCHAR(20) UNIQUE,
    PublicationYear INT,
    Quantity INT
);
