: R%   ( principle rate  -- interest ) 10 */  5 +  10 / ;

: REACHED? ( principle rate current -- principle rate current f )
    ROT 2DUP 2* > 2SWAP ROT ;

: DOUBLED ( balance rate -- )
    OVER 21 1 DO  CR ." YEAR " I 2 U.R
        2DUP R% +  DUP ."    BALANCE " .
        REACHED? IF CR CR ." more than doubled in "
                I . ." years " LEAVE
            THEN
    LOOP 2DROP DROP ;
