# Hotellrum

**Designmönster: Factory Pattern**

För att hantera olika typer av rum i mitt hotellbokningssystem har jag valt att använda Factory Pattern. Detta designmönster gör koden mer strukturerad, flexibel och lätt att underhålla, eftersom jag kan skapa objekt dynamiskt utan att direkt instansiera klasser i vår huvudkod.

Genom att använda en fabriksklass centraliserar jag skapandet av rumstyper, vilket gör att vi enkelt kan lägga till nya rum utan att behöva ändra kod på flera ställen. Detta följer Open-Closed Principle inom SOLID, vilket innebär att koden är öppen för utbyggnad men stängd för modifiering. Dessutom minskar det behovet av långa if- eller switch-satser, vilket gör systemet mer effektivt och lättläst.

I mitt system har vi olika rumstyper, såsom Enkelrum, Dubbelrum och Svit. Dessa skapas dynamiskt med hjälp av en fabriksklass (RumFabrik), som returnerar rätt rumstyp baserat på en inparametrar. Om jag i framtiden vill lägga till fler typer av rum, t.ex. "Lyxsvit", kan jag göra det utan att ändra huvudkoden – behöver jag bara lägga till en ny klass och uppdatera fabriken.
 
**Use Case:**
I ett hotellbokningssystem måste kunder kunna välja mellan olika typer av hotellrum, t.ex. Enkelrum, Dubbelrum och Svit. Istället för att skapa varje rumstyp manuellt, använder vi en Factory Pattern klass som skapar rätt rum baserat på användarens val.

**User Story:**
"Som kund vill jag kunna se olika typer av hotellrum på webbplatsen, så att jag kan välja det rum som passar mina behov."
