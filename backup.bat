::  Backup solution
cd "e:\FileSync\SyncProjects\DeckDetector\"
c:\developer\utes\pkzip25 -add=update -rec -path=full -exclude=@c:\developer\work\exclude.lst -temp=c:\developer\temp r:\backup\Development\DeckDetector\DeckDetector.zip
pause