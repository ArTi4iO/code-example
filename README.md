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
