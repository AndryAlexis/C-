# Lesson 3: Static Classes

## Ejercicio: utilidades de dirección y estadísticas de partida

### Objetivo
Diferenciar una Static Class sin estado (utilidades) de una con estado compartido, y ver el riesgo de este último.

### Instrucciones
1. Crea un proyecto de consola en `Lesson03-StaticClasses/` con el Namespace `Lesson03`.
2. En `Direction.cs`, declara un `enum Direction` con los valores `Up`, `Down`, `Left` y `Right`.
3. En `DirectionUtils.cs`, crea una `public static class DirectionUtils` **sin campos** con:
   - `IsHorizontal(Direction direction)`: devuelve `true` si es `Left` o `Right`.
   - `IsVertical(Direction direction)`: reutiliza `IsHorizontal` (no repitas comparaciones).
   - `GetOpposite(Direction direction)`: devuelve la dirección contraria. Usa un `switch`.
4. En `GameStats.cs`, crea una `public static class GameStats` con:
   - Un campo `public static int EnemiesKilled`.
   - Un método `Reset()` que lo ponga a `0`.
5. En `Program.cs`:
   - Recorre todos los valores del `enum` con `Enum.GetValues<Direction>()` y, para cada uno, imprime si es horizontal, si es vertical y cuál es su opuesto.
   - Suma 3 a `GameStats.EnemiesKilled` desde un método local `SimulateCombat()` e imprime el valor desde otro método local `ShowHud()`.
6. Intenta escribir `new DirectionUtils()` y anota el error que te da el compilador. Después bórralo.

### Resultado esperado
```
Up: horizontal=False, vertical=True, opposite=Down
Down: horizontal=False, vertical=True, opposite=Up
Left: horizontal=True, vertical=False, opposite=Right
Right: horizontal=True, vertical=False, opposite=Left
Enemies killed: 3
```

### Preguntas para pensar
1. ¿Qué error da `new DirectionUtils()` y por qué?

El error que da es "...\Program.cs(18,1): error CS0712: Cannot create an instance of the static class 'DirectionUtils'

The build failed. Fix the build errors and run again."

Y  lo da porque estoy intentando crear una instancia de DirectionUtils y eso no se puede ya que es una clase estática. Si quisiera usarla, debo poner directamente su nombre. Por ejemplo: DirectionUtils.IsHorizontal()

2. Si `ShowHud()` muestra un número que no esperas, ¿qué problema tendrías para descubrir quién cambió `EnemiesKilled`?

Si dicho método me mostrase un númeo que no espero, el problema sería descubrir donde se ha actualizado. Ese es el problema de mantener estados en clases estáticas. Las puedes llamar cualquier dentro del mismo namespace haciendo muy complicado rastrear el orden de llamada.

3. ¿Por qué `DirectionUtils` es un buen candidato para ser Static Class y `GameStats` no tanto?

Porque DirectionUtils solo tiene métodos que no cambian el estado de nada mientras que GameStats sí lo hace.