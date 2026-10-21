INSERT INTO Students (StudentID, Name, YearLevel) VALUES
(1, 'a', 9),
(2, 'b', 10),
(3, 'c', 11),
(4, 'd', 12),
(5, 'e', 13);

INSERT INTO Books (BookID, Title, Author, Genre) VALUES
(1, 'book_a', 'author_a', 'genre_a'),
(2, 'book_b', 'author_b', 'genre_b'),
(3, 'book_c', 'author_c', 'genre_c'),
(4, 'book_d', 'author_d', 'genre_d'),
(5, 'book_e', 'author_e', 'genre_e');

INSERT INTO Loans (LoanID, StudentID, BookID, DateOut, DateDue, DateReturned) VALUES
(1, 1, 1, '2026-10-01', '2026-10-15', '2026-10-13'),
(2, 1, 2, '2026-10-02', '2026-10-16', NULL),
(3, 2, 3, '2026-10-03', '2026-10-17', NULL),
(4,2,4,'2026-10-04','2026-10-18','2026-10-16'),
(5,3,5,'2026-10-05','2026-10-19',NULL),
(6,3,1,'2026-10-06','2026-10-20',NULL),
(7,4,2,'2026-10-07','2026-10-21',NULL),
(8,5,3,'2026-10-08','2026-10-22','2026-10-20');