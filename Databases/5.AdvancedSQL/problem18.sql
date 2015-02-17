--Problem 18.Write a SQL statement 
--to add a column GroupID to the table Users.

ALTER TABLE Users 
ADD GroupID INT  
FOREIGN KEY REFERENCES Groups(GroupID)