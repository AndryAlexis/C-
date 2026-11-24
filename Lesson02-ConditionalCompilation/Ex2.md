# Lesson 2: Conditional Compilation (`#if`)

## Ejercicio: depuración condicional en `Inventory`

### Objetivo
Usar `#if DEBUG` para que el código de depuración solo exista en compilaciones Debug.

### Punto de partida
Copia tu proyecto de la Lesson 1 en una carpeta nueva `Lesson02-ConditionalCompilation/` (o trabaja sobre una copia de `Inventory`).

### Instrucciones
1. En `Inventory.Debug.cs`, envuelve **todo el archivo** en `#if DEBUG` ... `#endif`.
2. Cambia `PrintAll()` para que escriba cada objeto con el formato `[DEBUG] <item>`.
3. En `Program.cs`:
   - Envuelve la llamada a `PrintAll()` en `#if DEBUG`.
   - Fuera de cualquier `#if`, escribe `Inventory ready`.
4. Ejecuta en los dos modos:
   ```bash
   dotnet run
   dotnet run -c Release
   ```

### Resultado esperado (Debug)
```
[DEBUG] Sword
[DEBUG] Shield
[DEBUG] Potion
Inventory ready
```

### Resultado esperado (Release)
```
Inventory ready
```

### Preguntas para pensar
1. ¿Qué pasaría en Release si llamas a `PrintAll()` en `Program.cs` **sin** envolverlo en `#if DEBUG`? Pruébalo y explica el error.

El error es a causa de que, como estoy corriendo el programa en modo NO DEBUG, no puede encontrar el método PrintAll porque está envuelto en la conditional compilation de nombre DEBUG, así que ni lo compila.

2. ¿Qué diferencia hay entre usar `#if DEBUG` y un `bool isDebug = true;` con un `if` normal?

El conditional compilation evita su completa compilation si no se ejecuta en modo debug mientras que un if normal siempre se ejecuta (otra cosa es que se cumpla la condición durante la ejecución).