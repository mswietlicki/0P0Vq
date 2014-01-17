

ZADANIE

Rozwa¿my zbiór P={p(0), p(1), ..., p(n-1)} sk³adaj¹cy siê z n spo³ecznoœci lokalnych, dla których ustalona jest relacja bezpoœredniego s¹siedztwa. Ze zbioru P wybieramy k ró¿nych elementów, które bêd¹ stanowi³y punkty startowe kampanii wyborczych k kandydatów q(0), q(1), ..., q(k-1). Dalej proces realizacji kampanii wyborczych przebiega w turach tak, ¿e:

 - tura 0: ka¿dy z kandydatów q(j) dla 0<=j<=k-1 zak³ada w punkcie startowym swojej kampanii sztab wyborczy,

 - ...

 - tura i, krok I: ka¿dy z kandydatów z ka¿dego sztabu wyborczego zlokalizowanego w dowolnej spo³ecznoœci p(j) dla 0<=j<=n-1, odwiedza wszystkie spo³ecznoœci bezpoœrednio s¹siednie z w/w elementem zbioru P, gdzie zak³ada swoje komitety wyborcze, pod warunkiem, ¿e nie ma w nich ju¿ w³asnych sztabów wyborczych, b¹dŸ sztabów wyborczych innych kandydatów,

 - tura i, krok II: w ka¿dej spo³ecznoœci p(j) dla 0<=j<=n-1, dla której za³o¿ony jest komitet wyborczy co najmniej jednego kandydata odbywaj¹ siê prawybory, w których zwyciê¿a ten kandydat, którego liczba sztabów wyborczych w spo³ecznoœciach bezpoœrednio s¹siednich (stan z pocz¹tku i-tej tury) ze spo³ecznoœci¹ p(j) jest:

 -- wariant A: najmniejsza (w przypadku remisu wygrywa kandydat o wiêkszej wartoœci indeksu l dla q(l)),

 -- wariant B: najwiêksza (w przypadku remisu wygrywa kandydat o mniejszej wartoœci indeksu l dla q(l)).

 - tura i, krok III: zwyciêstwo w prawyborach w danej spo³ecznoœci uprawnia kandydata do za³o¿enia sztabu wyborczego w miejsce komitetu wyborczego,

 - ...

i koñczy siê z chwil¹, gdy ka¿da nastêpna tura realizacji kampanii wyborczych nie zmienia ustalonej wczeœniej postaci przypisania sztabów wyborczych do elementów rozwa¿anego zbioru P spo³ecznoœci lokalnych.

Ustal finansowanie kosztów kampanii wyborczej, w zale¿noœci od przyjêtego wariantu rozstrzygania prawyborów (wariant A albo wariant B), dla ka¿dego z k kandydatów, je¿eli koszty kampanii wyborczej mierzymy ostateczn¹ liczb¹ za³o¿onych sztabów wyborczych w obrêbie rozwa¿anego zbioru spo³ecznoœci lokalnych P.

 

WEJŒCIE

Kolejno:

 - liczba naturalna reprezentuj¹ca liczbê n spo³ecznoœci lokalnych, znak nowej linii (kod ASCII 10),

 - ci¹g m wierszy postaci liczba naturalna x znak odstêpu (kod ASCII 32) liczba naturalna y znak nowego wiersza, zakoñczony wierszem specjalnym postaci -1 znak odstêpu -1 znak nowej linii, z których ka¿dy w³aœciwy wiersz definiuje bezpoœrednie s¹siedztwo spo³ecznoœci lokalnych indeksowanych kolejno liczbami x i y,

 - liczba naturalna opisuj¹ca liczbê k kandydatów, znak nowej linii,

 - ci¹g k wierszy postaci liczba naturalna z znak nowej linii, gdzie liczba z zawarta w i-tym wierszu reprezentuje indeks punktu startowego (spo³ecznoœci lokalnej) ka¿dego kolejnego kandydata pocz¹wszy od kandydata q(0).

 

WYJŒCIE

Ci¹g k wierszy postaci liczba naturalna a znak odstêpu liczba naturalna b znak nowej linii, z których ka¿dy reprezentuje kolejno koszt kampanii wyborczej w wariancie A (wartoœæ a) i w wariancie B (wartoœæ b) ka¿dego kolejnego kandydata pocz¹wszy od kandydata q(0).

 

OGRANICZENIA

Liczby kolejno spo³ecznoœci n jak i kandydatów k, zawarte w przedziale [1,10^5]. Rozmiar m relacji s¹siedztwa spo³ecznoœci lokalnych nie wiêkszy ni¿ 10^7.

 

LIMITY

Z³o¿onoœæ czasowa O(k(n^2)), z³o¿onoœæ pamiêciowa O(n+m+k), gdzie n jest liczb¹ spo³ecznoœci lokalnych, k jest liczb¹ kandydatów, m jest rozmiarem relacji s¹siedztwa na zbiorze P.

 

PRZYK£AD 1

wejœcie:

3

0 1

1 2

0 2

-1 -1

2

0

1

wyjœcie:

1 2

2 1

/*

KOMENTARZ DO ROZWI¥ZANIA

Przebieg algorytmu:

  tura 0: stan sztabów wyborczych w spo³ecznoœciach

    p(0) – sztab wyborczy kandydata 0

    p(1) – sztab wyborczy kandydata 1

    p(2) – brak 

  tura 1, krok 1: stan komitetów wyborczych w spo³ecznoœciach

    p(0) – brak

    p(1) – brak

    p(2) – komitety wyborcze kandydatów 0 i 1

  tura 1, krok 2: wynik prawyborów w spo³ecznoœciach

    p(0) – brak

    p(1) – brak

    p(2) – wariant A: wygrywa kandydat 1

         - wariant B: wygrywa kandydat 0 

  tura 1, krok 3: stan sztabów wyborczych w spo³ecznoœciach

    p(0) – sztab wyborczy kandydata 0

    p(1) – sztab wyborczy kandydata 1

    p(2) – wariant A: sztab wyborczy kandydata 1

         - wariant B: sztab wyborczy kandydata 0

Koniec algorytmu.

 

Koszt kampanii wyborczej:

  kandydat 0 – wariant A: 1

             - warrant B: 2

  kandydat 1 – wariant A: 2

             - warrant B: 1

*/

PRZYK£AD 2

wejœcie:

6

1 0

2 1

3 0

3 1

3 2

4 2

4 3

5 0

5 2

-1 -1

3

0

1

5

wyjœcie:

1 3

2 2

3 1

 

PRZYK£AD 3

wejœcie:

20

3 0

5 1

6 1

7 4

7 5

8 4

10 3

10 9

11 5

11 8

12 4

12 5

12 6

12 10

13 1

13 3

13 5

14 1

14 6

14 7

15 12

15 13

15 14

16 4

16 8

16 9

16 13

17 0

17 2

17 5

17 7

17 15

18 5

18 7

19 3

19 4

19 7

19 10

19 13

19 14

-1 -1

10

3

2

19

5

15

14

4

8

17

11
wyjœcie:

1 5

1 1

2 2

2 4

2 1

3 2

2 2

3 1

3 1

1 1
Limit d³ugoœci kodu 	50000
Dostêpne jêzyki 	ADA 95 (gnat 4.3.2) Any document (no testing) Assembler (nasm 2.03.01) Bash (bash-4.0.37) Brainf**k (bff 1.0.3.1) C (gcc 4.3.2) C# (gmcs 2.0.1) C++ (g++ 4.0.0-8) C++ (g++ 4.3.2) C99 strict (gcc 4.3.2) Clips (clips 6.24) Clojure (clojure 1.1.0) Common Lisp (clisp 2.44.1) Common Lisp (sbcl 1.0.18) D (gdc 4.1.3) Erlang (erl 5.6.3) F# (fsharp 2.0.0) Fortran 95 (gfortran 4.3.2) Go (gc 2010-07-14) Haskell (ghc 6.10.4) Icon (iconc 9.4.3) Intercal (ick 0.28-4) JAR (JavaSE 6) Java (JavaSE 6) JavaScript (rhino 1.7R1-2) Lua (luac 5.1.3) Nemerle (ncc 0.9.3) Nice (nicec 0.9.6) Ocaml (ocamlopt 3.10.2) Pascal (gpc 20070904) Pascal (fpc 2.2.4) PDF (ghostscript 8.62) Perl (perl 5.12.1) Perl 6 (rakudo-2010.08) PHP (php 5.2.6) Pike (pike 7.6.112) PostScript (ghostscript 8.62) Prolog (swipl 5.6.58) Python (python 2.5) Python 3 (python 3.1.2) Ruby (ruby 1.9.0) Scala (scala 2.8.0) Scheme (stalin 0.11) Scheme (guile 1.8.5) Smalltalk (gst 3.0.3) Tcl (tclsh 8.5.3) TECS Text (plain text) Whitespace (wspace 0.3)