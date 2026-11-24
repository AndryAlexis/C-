# Lesson 1: `partial` Class

## Ejercicio: `partial class Inventory`

### Objetivo
Comprobar que una `partial` Class repartida en varios archivos es una sola Class, y que todas sus partes comparten los miembros `private`.

### Instrucciones
1. Crea un proyecto de consola en la carpeta `Lesson01-Partial/`:
   ```bash
   dotnet new console -n Lesson01-Partial
   ```
2. En `Inventory.cs`, declara `public partial class Inventory` dentro del Namespace `Lesson01Partial` con:
   - Una List privada `List<string> items`.
   - Un método `Add(string item)` que añada el objeto a la List.
3. En `Inventory.Debug.cs`, declara otra parte de la misma Class con:
   - Un método `PrintAll()` que recorra la List y escriba cada objeto en la consola.
4. En `Program.cs`:
   - Crea un `Inventory`.
   - Añade tres objetos: "Sword", "Shield" y "Potion".
   - Llama a `PrintAll()`.
5. Ejecuta con `dotnet run`.

### Resultado esperado
```
Sword
Shield
Potion
```

### Pregunta para pensar
¿Por qué `PrintAll()` puede usar la List `items` si es `private` y está declarada en otro archivo?