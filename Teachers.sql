CREATE TABLE Teachers(
	ID int IDENTITY(1,1) NOT NULL,
	Fname varchar (50) NULL,
	Lname varchar (50) NULL,
	gender bit NULL,
	subject_id int NULL
  Primary key (ID)
  Foreign key (subject_id) references Subjects (ID)