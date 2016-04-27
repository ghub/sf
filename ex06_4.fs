require ex06_1.fs

: ROW    ( #spaces -- ) SPACES 10 STARS ;
: /STARS   ( height -- ) DUP 0 DO CR DUP I - 1- ROW LOOP DROP ;
