: SPELLER ( n -- )
    DUP ABS 4 > IF
        ." OUT OF RANGE"
    ELSE
        DUP 0<  IF ." negative " ABS THEN
        DUP 0=  IF ." zero"  ELSE
        DUP 1 = IF ." one"   ELSE
        DUP 2 = IF ." two"   ELSE
        DUP 3 = IF ." three" ELSE
                   ." four"  ELSE
        THEN THEN THEN THEN
    THEN DROP ;
