: .PH#7   ( ud -- )
    <# # # # # [CHAR] - HOLD #S #> TYPE
    ;

: .PH#10   ( ud -- )
    <# # # # # [CHAR] - HOLD # # # [CHAR] / HOLD # # #S #> TYPE
    ;

: .PH#   ( ud -- )
    2DUP 10000000. DU<
    IF
        .PH#7
    ELSE
        .PH#10
    THEN
    ;

: .PH#  ( d -- )  <#  # # # #  [CHAR] - HOLD  # # #
   OVER IF  [CHAR] / HOLD  #S THEN  #>  TYPE SPACE ;
