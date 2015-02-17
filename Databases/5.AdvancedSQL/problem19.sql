--Problem 19.	Write SQL statements to insert several records 
--in the Users and Groups tables.

INSERT INTO Groups VALUES ('White')
INSERT INTO Groups VALUES ('Red')
INSERT INTO Groups VALUES ('Blue')
INSERT INTO Groups VALUES ('Black')
INSERT INTO Groups VALUES ('Green')
INSERT INTO Users(UserName, UserPassword, FullName, LastLoginActivity, GroupID)
VALUES('Pesho', 'Pesho123', NULL, GETDATE(), 1)
INSERT INTO Users(UserName, UserPassword, FullName, LastLoginActivity, GroupID)
VALUES('Gosho', 'Gosho123', NULL, GETDATE(), 2)
INSERT INTO Users(UserName, UserPassword, FullName, LastLoginActivity, GroupID)
VALUES('Alex', 'Alex123', NULL, GETDATE(), 3)
INSERT INTO Users(UserName, UserPassword, FullName, LastLoginActivity, GroupID)
VALUES('Tosho', 'Tosho123', NULL, GETDATE(), 4)