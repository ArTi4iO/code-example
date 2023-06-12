Jak korzystać z obiektu Mortar
Ten obiekt gry Mortar składa się z dwóch części: głównej konstrukcji i lufy armatniej. Aby skorzystać z tego kodu w swoim projekcie, postępuj zgodnie z poniższymi krokami:

1. Konstrukcja obiektu Mortar:
  Utwórz nowy obiekt w Unity Editorze.
  Podziel obiekt na dwie części: główną konstrukcję i lufę armatnią.
  Przypisz tag "MortarBarrel" do lufy armatniej.
  Upewnij się, że nazwa obiektu lufy armatniej odpowiada nazwie "MortarBarrel".
2. Ustawianie tagu gracza:
  Przypisz tag "Player" do obiektów, które uważasz za graczy w swojej grze. Możesz to zrobić w inspektorze obiektu w zakładce "Tag" lub poprzez przypisanie wartości "Player" do pola "Tag" w skrypcie gracza.
3. Dodawanie skryptu Mortar:
  Dodaj skrypt "Mortar.cs" do głównego obiektu Mortar w Unity Editorze.
4. Jak działa:
  Umieść gracza obok obiektu Mortar w grze.
  Gdy gracz zbliży się do obiektu Mortar, naciśnięcie klawisza "E" spowoduje umieszczenie gracza wewnątrz armaty.
  Po umieszczeniu gracza w armacie, po upływie 1,5 sekundy nastąpi automatyczny strzał gracza z obiektu Mortar.
