using gun6;

Student student = new Student("John Doe", "12345");
Student student2 = new Student("Jane Smith", "67890");

Teacher teacher = new Teacher("Dr. Smith", "54321");
Teacher teacher2 = new Teacher("Prof. Johnson", "98765");

Library library = new Library();
library.AddBook(new Book("Clean Code", "Robert Martin" , 1990 ,false));
library.AddBook(new Book("The Pragmatic Programmer", "Andrew Hunt", 1990, false));
library.ShowBook();
library.BorrowBook("Clean Code", student);
library.ReturnBook("Clean Code");
library.RemoveBook("Clean Code");
library.ShowBook();
