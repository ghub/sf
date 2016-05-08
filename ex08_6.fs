require ex06_1.fs
require ex08_5.fs

: []   ( array index -- addr )
    CELLS + ;

: ROW   ( index #cell -- )
    . STARS CR ;

: PLOT   ( array size -- )
    0 DO
    DUP I [] @ I ROW
    LOOP DROP ;

#PENCILS 4 PLOT
