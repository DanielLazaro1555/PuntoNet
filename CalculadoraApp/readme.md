# 🧮 Calculadora .NET 8.0

Este proyecto es una calculadora interactiva de consola creada con .NET 8.0, que demuestra conceptos fundamentales de programación más allá del "Hola Mundo".

## ✨ Características

- ✅ **Interfaz interactiva** con menús seleccionables
- ✅ **Operaciones básicas**: suma, resta, multiplicación, división
- ✅ **Validación de errores** (división entre cero)
- ✅ **Historial** de operaciones guardado en archivo
- ✅ **Interfaz con colores** usando Spectre.Console
- ✅ **Manejo de excepciones** básico

## 🛠️ Conceptos aprendidos

| Concepto | Cómo se usa en .NET |
|----------|---------------------|
| Input del usuario | `AnsiConsole.Ask<double>()` |
| Estructuras de control | `switch`, `while` |
| Manejo de archivos | `File.AppendAllText()`, `File.ReadAllLines()` |
| Paquetes NuGet | `Spectre.Console` para UI mejorada |
| Métodos | Separación en `Calcular()` y `VerHistorial()` |

## 📦 Paquetes utilizados

```bash
dotnet add package Spectre.Console