require ex06_1.fs

: ROW    ( #spaces -- ) SPACES 10 STARS ;
: \STARS   ( height -- ) 0 DO CR I ROW LOOP ;
