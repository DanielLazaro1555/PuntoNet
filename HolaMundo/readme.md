📄 README.md – Instalación de .NET en Zorin OS 17 / Ubuntu (Prueba)

# Instalación de .NET en Zorin OS 17 / Ubuntu

Guía paso a paso para instalar el SDK de .NET en sistemas basados en Ubuntu, como **Zorin OS 17**, que usan la versión base `Ubuntu 22.04`.

---

## 🔧 Requisitos previos

- Sistema operativo: **Zorin OS 17.x** o cualquier distro basada en Ubuntu 22.04
- Acceso a terminal
- Conexión a internet

---

## 📦 Paso 1: Descargar el repositorio de Microsoft

Ejecuta este comando en tu terminal:

```bash
wget https://packages.microsoft.com/config/ubuntu/22.04/packages-microsoft-prod.deb
```

🛠️ Paso 2: Instalar el paquete descargado

Instala el repositorio con dpkg:

sudo dpkg -i packages-microsoft-prod.deb

⚠️ Si el archivo tiene otro nombre (por ejemplo, packages-microsoft-prod.deb.1, deb.2, etc.), usa ese nombre exacto:

sudo dpkg -i packages-microsoft-prod.deb.2

🔄 Paso 3: Actualizar los paquetes

sudo apt update

💻 Paso 4: Instalar el SDK de .NET

Puedes elegir una versión del SDK. Por ejemplo:
Para instalar .NET 8 (recomendado):

sudo apt install -y dotnet-sdk-8.0

O si prefieres .NET 6:

sudo apt install -y dotnet-sdk-6.0

✅ Paso 5: Verificar la instalación

dotnet --version

Deberías ver algo como:

8.0.xxxxx

🧪 Paso 6: Crear y ejecutar un proyecto de prueba

mkdir HolaMundo
cd HolaMundo
dotnet new console
dotnet run

Salida esperada:

Hello World!

🚀 ¿Qué hacer después?

Una vez instalado .NET, puedes:

    Probar con una calculadora básica
    Crear una aplicación web con ASP.NET Core
    Usar Visual Studio Code para desarrollar más cómodamente

📚 Recursos útiles

    Microsoft .NET Download
    Microsoft Learn - C#
    GitHub - Force.com Toolkit for .NET

👤 Autor

Daniel Huaman
Fecha: Mayo 2025
