CREATE BOARD 9 ALLOT
BOARD 9 ERASE

: SQUARE   ( index -- )
    BOARD + ;

: EMPTY?   ( index -- f )
    SQUARE C@ 0= ;

: MOVE   ( n player -- )
    SWAP 1-
    0 MAX 8 MIN
    DUP EMPTY? IF
        SQUARE C!
    ELSE
        2DROP
    THEN ;

: PLOT_PLAYER   ( player -- )
    DUP 0=  IF SPACE ELSE
    DUP 1 = IF ." X" ELSE
               ." O"
    THEN THEN DROP ;

: DASHES   ( -- )
    CR 9 0 DO [CHAR] - EMIT LOOP CR ;

: PLOT_DASHES   ( index -- )
    DUP 2 = IF DASHES ELSE
    DUP 5 = IF DASHES ELSE
    THEN THEN ;

: BAR   ( -- )
    ."  | " ;

: PLOT_BAR   ( index -- )
    3 MOD 2 = 0=
    IF
        BAR
    THEN ;

: PLOT   ( -- )
    CR 9 0 DO
        I SQUARE C@ PLOT_PLAYER
        I PLOT_BAR
        I PLOT_DASHES
    LOOP QUIT ;

: PLAY   ( n player -- )
    MOVE PLOT ;

: X!   ( n -- )
    1 PLAY ;

: O!   ( n -- )
    -1 PLAY ;
