CREATE PROCEDURE AddStudent
(
@StdNumber INT,
@Name varchar(100),
@Surname varchar(100),
@studentimage IMAGE,
@Dob DATE,
@Gender varchar(10),
@Phone INT,
@Email varchar(100),
@adress varchar(50),
@ModuleCodes varchar(50)
)

AS BEGIN 
INSERT INTO [student Info]
VALUES (@StdNumber, @Name, @studentimage, @Dob, @Gender, @Phone, @Email , @adress, @ModuleCodes)
END

CREATE PROCEDURE DeleteStudent
DELETE FROM StudentDB
WHERE
SearchStudentNumTXT

