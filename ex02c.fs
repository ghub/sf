: 2C1   ( a b c -- c b a ) SWAP ROT ;
: 2C2   ( a b -- a b a ) SWAP DUP ROT SWAP ;
: -ROT  ( a b c - c a b ) ROT ROT ;
: 2C4a  ( n -- result ) DUP 1 + SWAP / ;
: 2C4b  ( x -- result ) DUP 7 * 5 + * ;
: 2C4c  ( a b -- result ) OVER 9 * SWAP - * ;

