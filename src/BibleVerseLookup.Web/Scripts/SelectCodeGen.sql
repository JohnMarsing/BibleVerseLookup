
SELECT '<option value="' + Title + '"></option>' AS DataList
FROM Book
ORDER BY ID

SELECT max(LastChapter) FROM Book

SELECT '<option value="' + CAST(N AS VARCHAR(3)) + '"></option>' AS DataList
FROM Number where N <= 150
order by N

SELECT '<option value="' + CAST(Id AS VARCHAR(2)) + '">' + Title + '</option>' AS DataList
FROM Book
ORDER BY ID

SELECT '<option value="' + Title + '">' + Title + '</option>' AS SelectList
FROM Book
ORDER BY ID

SELECT BookID, Chapter, LastVerse
, '{bookid: ' + CAST(bc.BookID AS VARCHAR(2)) + ', chapter: ' + CAST(bc.Chapter AS VARCHAR(3)) + ', lastverse: ' + CAST(bc.LastVerse AS VARCHAR(3)) + ' },'  AS CodeGen
FROM BookChapter bc

SELECT ID, LastChapter 
, '{id: ' + CAST(ID AS VARCHAR(2)) + ', lastchapter: ' + CAST(LastChapter AS VARCHAR(3)) + ' },'   AS CodeGen
FROM Book