require ex06_1.fs

: ROW    ( #spaces -- ) SPACES 10 STARS ;
: /STARS   ( height -- ) BEGIN CR 1- DUP DUP ROW 0= UNTIL DROP ;
