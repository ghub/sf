VARIABLE PLACES 0 PLACES !

: .M   ( d -- )
    TUCK DABS
    <# PLACES @ DUP 0>
    IF
        0 DO # LOOP
        [CHAR] . HOLD
    ELSE
        DROP
    THEN
    #S ROT SIGN #> TYPE ;
