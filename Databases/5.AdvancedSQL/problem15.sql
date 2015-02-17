--Problem 15.	Write a SQL statement to create a table Users.

CREATE TABLE Users(
UserID int PRIMARY KEY IDENTITY NOT NULL,
UserName nvarchar(50) UNIQUE NOT NULL,
UserPassword nvarchar(50) NOT NULL,
FullName nvarchar(50),
LastLoginActivity datetime NOT NULL,
CONSTRAINT MIN_UserName_Length CHECK(DATALENGTH(UserPassword)>=5)
)