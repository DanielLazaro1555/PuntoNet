# Mi Primer Proyecto .NET en Linux 🚀

Este repositorio documenta mi primer contacto con .NET Core en Fedora Linux, creando una aplicación de consola "Hola Mundo".

## 📋 Prerrequisitos

- Sistema operativo: Fedora 43 (o superior)
- Terminal con acceso sudo

## 🔧 Instalación de .NET SDK 8.0

En Fedora, la instalación del SDK de .NET se realiza mediante DNF (el gestor de paquetes). Estos son los pasos que seguí:

```bash
# Instalar el SDK completo de .NET 8.0
sudo dnf install -y dotnet-sdk-8.0
```

### 📦 Paquetes instalados

Durante la instalación se instalan automáticamente estos componentes:

| Paquete | Descripción | Tamaño |
|---------|-------------|--------|
| `dotnet-sdk-8.0` | SDK completo de .NET 8.0 | 293.6 MiB |
| `aspnetcore-runtime-8.0` | Runtime para aplicaciones ASP.NET Core | 22.9 MiB |
| `aspnetcore-targeting-pack-8.0` | Paquetes de compatibilidad de ASP.NET | 14.5 MiB |
| `dotnet-apphost-pack-8.0` | Host para aplicaciones | 12.1 MiB |
| `dotnet-host` | Lanzador de línea de comandos | 295.0 KiB |
| `dotnet-hostfxr-8.0` | Resolvedor de versiones de runtime | 306.0 KiB |
| `dotnet-runtime-8.0` | Runtime base de .NET | 66.7 MiB |
| `dotnet-targeting-pack-8.0` | Paquetes de compatibilidad | 34.8 MiB |
| `dotnet-templates-8.0` | Plantillas de proyecto | 5.7 MiB |
| `netstandard-targeting-pack-2.1` | Compatibilidad con .NET Standard | 17.9 MiB |

**Total instalado:** Aproximadamente 469 MiB en disco

## 🎯 Creación del proyecto "Hola Mundo"

```bash
# Crear una nueva aplicación de consola
dotnet new console -o HolaMundoApp
```

Este comando genera:
- `HolaMundoApp/` - Carpeta del proyecto
- `HolaMundoApp/Program.cs` - Archivo con el código fuente
- `HolaMundoApp/HolaMundoApp.csproj` - Archivo de proyecto (similar a package.json)

### 📄 Código generado

El archivo `Program.cs` contiene:

```csharp
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
```

### ▶️ Ejecutar la aplicación

```bash
cd HolaMundoApp
dotnet run
```

**Salida esperada:**
```
Hello, World!
```

## 🧪 Verificación de la instalación

Para confirmar que todo está correcto:

```bash
dotnet --info
```

Muestra la versión del SDK y runtime instalados.

## 📚 Comandos útiles de .NET CLI

| Comando | Descripción |
|---------|-------------|
| `dotnet new` | Crear un nuevo proyecto |
| `dotnet build` | Compilar el proyecto |
| `dotnet run` | Ejecutar el proyecto |
| `dotnet test` | Ejecutar pruebas |
| `dotnet publish` | Publicar para distribución |
| `dotnet add package` | Agregar un paquete NuGet |

## 🎨 Lo que sigue

Este es solo el primer paso. .NET permite crear:

- 🌐 **APIs web** con ASP.NET Core
- 📱 **Aplicaciones móviles** con .NET MAUI
- 🖥️ **Aplicaciones de escritorio** multiplataforma
- ☁️ **Microservicios** para la nube
- 🎮 **Videojuegos** con Unity (usa C#)

## 🔗 Recursos útiles

- [Documentación oficial de .NET](https://docs.microsoft.com/dotnet)
- [Tutoriales de .NET](https://dotnet.microsoft.com/learn)
- [Paquetes NuGet](https://www.nuget.org)

---