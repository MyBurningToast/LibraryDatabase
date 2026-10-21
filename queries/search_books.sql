SELECT l.LoanID, s.Name, b.Title, l.DateOut, l.DateDue, l.DateReturned
FROM Loans l
JOIN Students s ON s.StudentID = l.StudentID
JOIN Books b ON b.BookID = l.BookID
WHERE b.Title LIKE @q
ORDER BY l.DateOut DESC;