
: BINARY   ( -- )
    2 BASE !
    ;

: PRINT-DECIMAL   ( n -- )
    ." DECIMAL"
    3 U.R
    ;

: PRINT-HEX   ( n -- )
    ."   HEX"
    3 HEX U.R DECIMAL
    ;

: PRINT-BINARY   ( n -- )
    ."   BINARY"
    6 BINARY U.R DECIMAL
    ;

: ROW   ( n -- )
    CR DUP DUP PRINT-DECIMAL PRINT-HEX PRINT-BINARY
    ;

: PRINT-0-16   ( -- )
    17 0 DO I ROW LOOP QUIT
    ;
