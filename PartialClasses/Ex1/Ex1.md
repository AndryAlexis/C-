# Lección 1: Clases `partial`

## Ejercicio: `partial class Inventario`

### Objetivo
Comprobar que una clase `partial` repartida en varios archivos es una sola clase, y que todas sus partes comparten los miembros privados.

### Instrucciones
1. Crea un proyecto de consola en la carpeta `Leccion01-Partial/`.
2. En `Inventario.cs`, declara `public partial class Inventario` con:
   - Una lista privada `List<string> objetos`.
   - Un método `Agregar(string objeto)` que añada el objeto a la lista.
3. En `Inventario.Debug.cs`, declara otra parte de la misma clase con:
   - Un método `ImprimirTodo()` que recorra la lista y escriba cada objeto en la consola.
4. En `Program.cs`:
   - Crea un `Inventario`.
   - Añade tres objetos: "Espada", "Escudo" y "Poción".
   - Llama a `ImprimirTodo()`.

### Resultado esperado
```
Espada
Escudo
Poción
```

### Pregunta para pensar
¿Por qué `ImprimirTodo()` puede usar la lista `objetos` si es privada y está declarada en otro archivo?