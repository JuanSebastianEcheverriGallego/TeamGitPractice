# Equipo 1

## Proyecto
**TeamGitPractice** — API REST desarrollada con ASP.NET Core Web API (.NET 10).

## Descripción
Práctica 1 de la asignatura: flujo colaborativo con Git y GitHub sobre un único
repositorio. Cada integrante desarrolla un controlador en su rama personal y lo
integra a `main` mediante Pull Request, revisión y merge.

## Integrantes

| # | Nombre completo | Usuario GitHub | Rama personal |
|---|-----------------|----------------|---------------|
| 1 | Juan Sebastian Echeverri Gallego | JuanSebastianEcheverriGallego | juan-echeverri |
| 2 | David Stiven Franco López | Davdfranco | david-franco |
| 3 | Marbel Juliana Mejía Bedoya | JULIANA-s22 | marbel-mejia |
| 4 | Jhon Fernando Sánchez Álvarez | Jhonzn | jhon-sanchez |
| 5 | Marlon García Sepúlveda | M3rl0n | marlon-garcia |

## Ejecución de la API

Requisitos: .NET SDK 10.0

```bash
git clone https://github.com/JuanSebastianEcheverriGallego/TeamGitPractice.git
cd TeamGitPractice
dotnet restore
dotnet run
```

La API queda disponible en la URL que indique la consola (por defecto
`https://localhost:7xxx`). También puede ejecutarse desde Visual Studio
Community 2026 con F5.

## Endpoints

| Endpoint | Responsable | Descripción |
|---|---|---|
| `GET /api/status` | Juan Sebastián Echeverri Gallego | Estado de la API |
| `GET /api/status/team` | Juan Sebastián Echeverri Gallego | Estado del equipo |
| `GET /api/members` | David Stiven Franco López | Lista de integrantes |
| `GET /api/members/count` | David Stiven Franco López | Cantidad de integrantes |
| `GET /api/version` | Marbel Juliana Mejía Bedoya | Versión de la aplicación |
| `GET /api/version/platform` | Marbel Juliana Mejía Bedoya | Plataforma y proyecto |
| `GET /api/health` | Jhon Fernando Sánchez Álvarez | Estado de salud de la API |
| `GET /api/health/time` | Jhon Fernando Sánchez Álvarez | Hora UTC actual del servidor |
| `GET /api/info` | Marlon García Sepúlveda | Información general del proyecto |
| `GET /api/info/tools` | Marlon García Sepúlveda | Herramientas utilizadas |
