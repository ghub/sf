require ex06_1.fs

: MOVE  ( n -- ) 9 SWAP - SPACES ;
: DRAW  ( n -- ) 2* 1+ STARS ;
: ROW   ( n -- ) DUP MOVE DRAW ;

: TOP      ( -- ) 10 0 DO CR I ROW     LOOP ;
: BOTTOM   ( -- )  0 9 DO CR I ROW -1 +LOOP ;

: DIAMOND   ( -- ) TOP BOTTOM ;
: DIAMONDS   ( n -- ) 0 DO DIAMOND LOOP QUIT ;
