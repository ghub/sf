require ex07_07.fs

: X-MAX   ( -- n ) 0 BEGIN 1+ DUP 7X^2+20X+5 0. D< UNTIL 1- ;
