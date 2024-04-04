USE LibraryPD_321;
GO

SELECT SUM(price) FROM Books WHERE author = (SELECT author_id FROM Authors WHERE last_name='Cameron');