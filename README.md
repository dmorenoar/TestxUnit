# Utils Library - Test Suite

Librería de utilidades en C# con funciones matemáticas, de lógica y manipulación de cadenas, acompañada de una suite completa de pruebas unitarias con xUnit.

## 📋 Descripción

Este proyecto contiene una clase `Utils` con métodos de uso común y su correspondiente suite de pruebas unitarias implementada con xUnit. Las pruebas están organizadas por categorías para facilitar su ejecución y mantenimiento.

## 🚀 Características

### Funciones Disponibles

- **`Divide(int dividend, int divisor)`**: Realiza la división de dos números enteros
- **`Add(int a, int b)`**: Suma dos números enteros
- **`IsEven(int num)`**: Determina si un número es par
- **`Max(int a, int b)`**: Retorna el mayor de dos números
- **`Reverse(string text)`**: Invierte una cadena de texto
- **`IsValidGrade(int grade)`**: Valida si una calificación está entre 0 y 10
- **`CountVowels(string text)`**: Cuenta el número de vocales en un texto

## 🏗️ Estructura del Proyecto
```
├── Tools/
│   └── Utils.cs              # Clase con métodos utilitarios
└── TestUtilsxUnit/
    └── UtilsTest.cs          # Suite de pruebas unitarias
```

## 🧪 Pruebas Unitarias

Las pruebas están organizadas en las siguientes categorías:

- **Maths**: Operaciones matemáticas
- **Logic**: Operaciones lógicas
- **String**: Manipulación de cadenas
- **NullCheck**: Validación de valores nulos

### Ejemplos de Pruebas
```csharp
// Prueba con Fact
[Fact]
[Trait("Category", "Maths")]
public void Add_ShouldReturnCorrectSum()

// Prueba con Theory (múltiples casos)
[Theory]
[InlineData(0, true)]
[InlineData(1, false)]
[Trait("Category", "Logic")]
public void IsEven_ShouldReturnTrue(int num, bool expected)
```

## 📦 Requisitos

- .NET 6.0 o superior
- xUnit 2.4.0 o superior

```

## 📊 Cobertura de Pruebas

Las pruebas cubren:
- ✅ Casos normales de uso
- ✅ Casos límite (edge cases)
- ✅ Manejo de valores nulos
- ✅ Validación de excepciones
- ✅ Múltiples escenarios con Theory

## 📝 Notas

- Todos los métodos están documentados con XML documentation comments
- Las pruebas siguen el patrón AAA (Arrange-Act-Assert)
- Se utilizan atributos `[Trait]` para categorizar las pruebas
- Se implementan tanto pruebas `[Fact]` como `[Theory]` según corresponda

---

⭐ Si este proyecto te resulta útil, considera darle una estrella en GitHub
