select T.ID , T.Fname + " " + T.Lname from Teachers T
  join Subjects on sub.ID = Teachers.subject_id
  join Students on stud.subject_id = sub.ID
  where Students.Fname = "გიორგი"