INSERT INTO Artist (ArtistId, ArtistName, YearEstablished)
VALUES (null, 'The Arcs', 2009);

INSERT INTO Album (AlbumId, Title, ReleaseDate, AlbumLength, Label, ArtistId, GenreId)
VALUES (null, 'Yours, Dreamily,', '9/4/2015', 4933, 'Nonesuch', 29, 2);

INSERT INTO Song (SongId, Title, SongLength, ReleaseDate,GenreId,ArtistId,AlbumId)
VALUES (null, 'Outta My Mind', 294, '9/4/2015', 2, 29, 25);
INSERT INTO Song (SongId, Title, SongLength, ReleaseDate,GenreId,ArtistId,AlbumId)
VALUES (null, 'Stay in My Corner', 894, '9/4/2015', 2, 29, 25);
INSERT INTO Song (SongId, Title, SongLength, ReleaseDate,GenreId,ArtistId,AlbumId)
VALUES (null, 'The Arc', 827, '9/4/2015', 2, 29, 25);

-- Write a SELECT query that provides the song titles, 
-- album title, and artist name for all of the data you just entered in.
-- Use the LEFT JOIN keyword sequence to connect the tables, 
--and the WHERE keyword to filter the results to the album and artist you added. 

SELECT Song.Title AS "Song", Album.Title AS "Album", Artist.ArtistName AS "Artist"
FROM Song 
LEFT JOIN Album ON Song.AlbumId = Album.AlbumId
LEFT JOIN Artist ON Song.ArtistId = Artist.ArtistId
WHERE Album.Title = "Yours, Dreamily,"
;









-- Write a SELECT statement to display how many songs exist for each album. 
-- You'll need to use the COUNT() function and the GROUP BY keyword sequence.
SELECT Album.Title AS "Album", COUNT(Song.AlbumId)
FROM Album
JOIN Song ON Song.AlbumId = Album.AlbumId
GROUP BY Song.AlbumId;




-- Write a SELECT statement to display how many songs exist for each artist. 
-- You'll need to use the COUNT() function and the GROUP BY keyword sequence.



-- Write a SELECT statement to display how many songs exist for each genre. You'll need to use the COUNT() function and the GROUP BY keyword sequence.

-- Using MAX() function, write a select statement to find the album with the longest 
--duration. The result should display the album title and the duration.
SELECT Album.Title, MAX(Album.AlbumLength)
FROM Album;


-- Using MAX() function, write a select statement to find the song with the 
--longest duration. The result should display the song title and the duration.
-- Modify the previous query to also display the title of the album.
SELECT MAX(Song.SongLength), Song.Title AS "Song", Album.Title AS "Album"
FROM Song, Album
WHERE Song.AlbumId = Album.AlbumId;

SELECT MAX(Song.SongLength), Song.Title AS "Song", Album.Title AS "Album"
FROM Song
JOIN Album ON Song.AlbumId = Album.AlbumId; 










-- Which album has the most songs?
SELECT al.Title, COUNT(s.AlbumId) AS "Song total"
FROM Song s
JOIN Album al ON s.AlbumId = al.AlbumId
GROUP BY s.AlbumId
ORDER BY "Song total" desc
LIMIT 1;



-- Which genre has been assigned to the most songs?




-- Which record label has released the most albums?
