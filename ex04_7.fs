: GUESS   ( answer guess -- answer if incorrect or empty )
    2DUP < IF ." TOO HIGH" ELSE
    2DUP > IF ." TOO LOW" ELSE
        ." CORRECT!" DROP
    THEN THEN DROP ;
