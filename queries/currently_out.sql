SELECT s.Name, b.Title, l.DateDue
FROM Loans l
JOIN Students s ON s.StudentID = l.StudentID
JOIN Books b ON b.BookID = l.BookID
WHERE l.DateReturned IS NULL
ORDER BY l.DateDue;