: SIGN.TEST   ( n -- )
    DUP 0> IF ." POSITIVE" ELSE
    DUP 0= IF ." ZERO" ELSE
    DUP ." NEGATIVE"
    THEN THEN DROP ;