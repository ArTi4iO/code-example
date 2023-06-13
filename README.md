## Jak korzystać z obiektu Mortar

Ten obiekt gry Mortar składa się z dwóch części: głównej konstrukcji i lufy armatniej. Aby skorzystać z tego kodu w swoim projekcie, wykonaj poniższe kroki:

1. **Konstrukcja obiektu Mortar:**
   - Stwórz nowy obiekt w Unity Editorze.
   - Podziel obiekt na dwie części: główną konstrukcję i lufę armatnią.
   - Przypisz tag "MortarBarrel" do lufy armatniej.
   - Upewnij się, że nazwa obiektu lufy armatniej jest zgodna z nazwą "MortarBarrel".

2. **Tagowanie gracza:**
   - Przypisz tag "Player" do obiektów, które pełnią rolę graczy w Twojej grze. Można to zrobić w edytorze Unity w zakładce "Tag", lub poprzez przypisanie wartości "Player" do pola "Tag" w skrypcie gracza.

3. **Dodawanie skryptu Mortar:**
   - Dodaj skrypt "Mortar.cs" do głównego obiektu Mortar w edytorze Unity.

4. **Konfiguracja parametrów armaty:**
   - W skrypcie Mortar.cs znajdziesz stałą LaunchDelay. Możesz ją skonfigurować, aby ustawić opóźnienie przed strzałem.
   - Skrypt Mortar.cs posiada także pole LaunchForce, w którym możesz ustawić pożądaną siłę strzału.

Po wykonaniu tych kroków obiekt Mortar będzie gotowy do użycia w Twojej grze. Gdy gracz zbliży się do Mortar i naciśnie klawisz "E", zostanie umieszczony wewnątrz armaty, a po 1,5 sekundy nastąpi automatyczny strzał. Pamiętaj o odpowiednim dostosowaniu siły strzału w skrypcie Mortar.cs do wymagań Twojej gry.

# Portal1toPortal2

Ten skrypt w języku C# jest odpowiedzialny za teleportację gracza z Portalu 1 do Portalu 2 w grze.

1. Umieść ten skrypt na obiekcie, który ma collider wykorzystywany jako portal 1.
2. Przypisz obiekt reprezentujący Portal 2 do pola "portal2" w inspektorze Unity.
3. Upewnij się, że gracz ma tag "Player".
4. Gdy gracz wejdzie w collider portalu 1, rozpocznie się teleportacja.
5. Po 3 sekundach gracz zostanie przeniesiony do pozycji portalu 2.

# StoneRotator
Ten skrypt w języku C# odpowiada za rotację kamienia w grze.

## Użycie
1. Umieść ten skrypt na obiekcie, który ma być obracany.
2. Ustaw wartości w inspektorze Unity, takie jak "positions" (pozycje obrotu) i "rotationSpeed" (szybkość obrotu).
3. Dodaj do kamienia collider, który będzie wywoływał rotację (np. collider gracza).
4. Gdy collider wejdzie w kontakt z kamieniem, naciśnięcie klawisza "E" spowoduje obrót kamienia.

## Zmienne konfiguracyjne
- **indexStone** - indeks kamienia, który ma być unikalny dla każdego obiektu. | Wartość domyślna to 0. Powinieneś ustawić ją w inspektorze Unity
- **rotationSpeed** - prędkość obrotu kamienia. | Wartość domyślna to 30. Można zmienić ją w inspektorze Unity

## Inne zmienne
- **positionIndex** - indeks obecnej pozycji obrotu kamienia w danym momencie.


# TeleportManager

Ten skrypt w języku C# zarządza teleportacją w grze.

## Użycie
1. Dodaj ten skrypt do obiektu, który pełni rolę menedżera teleportacji.
2. Przypisz obiekty teleportów do zmiennych "teleport_1" i "teleport_2" w inspektorze Unity.

## Konfiguracja hasła
- **password** - tablica zawierająca hasło do aktywacji teleportu. | Możesz zmienić wartości w tej tablicy, aby ustawić własne hasło.

## Obsługa teleportacji
- Metoda **AddToInputPassword** przyjmuje dwa argumenty: **index** (indeks kamienia) i **value** (wartość indeksu pozycji obrotu). Wywołanie tej metody z odpowiednimi wartościami aktualizuje inputPassword i sprawdza, czy hasło jest poprawne.
- Jeśli wprowadzone hasło jest zgodne z ustalonym hasłem, teleport_1 zostanie aktywowany.



