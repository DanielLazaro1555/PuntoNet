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

```bash
sudo dpkg -i packages-microsoft-prod.deb
```

⚠️ Si el archivo tiene otro nombre (por ejemplo, packages-microsoft-prod.deb.1, deb.2, etc.), usa ese nombre exacto:

```bash
sudo dpkg -i packages-microsoft-prod.deb.2
```

🔄 Paso 3: Actualizar los paquetes

```bash
sudo apt update
```

💻 Paso 4: Instalar el SDK de .NET

Puedes elegir una versión del SDK. Por ejemplo:
Para instalar .NET 8 (recomendado):

```bash
sudo apt install -y dotnet-sdk-8.0
```

O si prefieres .NET 6:

```bash
sudo apt install -y dotnet-sdk-6.0
```

✅ Paso 5: Verificar la instalación

```bash
dotnet --version
```

Deberías ver algo como:

```bash
8.0.xxxxx
```

🧪 Paso 6: Crear y ejecutar un proyecto de prueba

```bash
mkdir HolaMundo
cd HolaMundo
dotnet new console
dotnet run
```

Salida esperada:

```bash
Hello World!
```

📚 Recursos útiles

    Microsoft .NET Download
    Microsoft Learn - C#
    GitHub - Force.com Toolkit for .NET

---

## 📄 Nota de uso

Este documento es de uso personal y educativo.

## 👤 Autor

**Daniel Huaman**  
Mayo 2025
