# Lesson 4: Extension Methods

## Ejercicio: convertir utilidades de dirección en Extension Methods

### Objetivo
Entender qué es un Extension Method, cómo se declara con `this` y cuándo tiene sentido usarlo frente a una Static Class normal.

### Instrucciones
1. Copia el proyecto de Lesson 3 a `Lesson04-ExtensionMethods/` y cambia el Namespace a `Lesson04` (también el RootNamespace del `.csproj`).
2. Renombra `DirectionUtils` a `DirectionExtensions` (archivo y clase). Convierte `IsHorizontal`, `IsVertical` y `GetOpposite` en Extension Methods: el primer parámetro debe ser `this Direction direction`. Sigue reutilizando `IsHorizontal` dentro de `IsVertical`.
3. Añade un Extension Method `RotateClockwise` que devuelva la siguiente dirección en el sentido de las agujas del reloj: `Up` → `Right` → `Down` → `Left` → `Up`. Usa un switch expression, como en `GetOpposite`.
4. En `Program.cs`, llama a esos métodos como si fueran de instancia: `direction.IsHorizontal()`, `direction.IsVertical()`, `direction.GetOpposite()`, `direction.RotateClockwise()`. No conviertas `GameStats`: se queda como Static Class y se sigue llamando `GameStats.EnemiesKilled` y `GameStats.Reset()`.
5. El `foreach` debe recorrer todas las direcciones e imprimir también la dirección rotada. `SimulateCombat()` y `ShowHud()` se quedan como en Lesson 3.

### Resultado esperado
```
Up: horizontal=False, vertical=True, opposite=Down, clockwise=Right
Down: horizontal=False, vertical=True, opposite=Up, clockwise=Left
Left: horizontal=True, vertical=False, opposite=Right, clockwise=Up
Right: horizontal=True, vertical=False, opposite=Left, clockwise=Down
Enemies killed: 3
```

### Preguntas para pensar
1. Si quitas `this` del primer parámetro y dejas el resto igual, ¿puedes seguir llamando `direction.IsHorizontal()`? ¿Por qué?

No, si quito this no puedo seguir llamándolo con 'direction.IsHorizontal()' porque no estaría extendiendo direction, estaría solo creando un método estático al cual tendría que llamarlo así 'DirectionExtensions.IsHorizontal(direction)' para que funcione.

2. ¿Por qué `GameStats.Reset()` no encaja como Extension Method?

Porque no hay ningún parámetro en el metodo Reset que se pueda extender.

3. ¿Qué ocurre si el Extension Method vive en un Namespace que no has importado con `using` y `Program.cs` está fuera de ese Namespace?

Pues que no podría usarlo y si lo intento saltaría un error.

4. ¿Puedes declarar un Extension Method para un tipo que no has escrito tú, como `string`? ¿Para qué sirve eso?

Sí puedo declarar un Extension Method para un tipo que no he escrito yo como el 'string'. Sirve para añadir nuevos métodos sin realmente tocar la clase.