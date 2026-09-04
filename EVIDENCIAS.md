# EVIDENCIAS — Equipo 1

Repositorio: https://github.com/JuanSebastianEcheverriGallego/TeamGitPractice

Commit base de `main`: `79e39d6` — chore: create base ASP.NET Core Web API

---

## 1. Commits, ramas y Pull Requests

| Integrante | Rama personal | Commit consola | Commit Visual Studio | Pull Request | Reviewer |
|---|---|---|---|---|---|
| Juan Sebastian Echeverri Gallego | `juan-echeverri` | `abeb079` | `4a608e4d` | PENDIENTE | David Stiven Franco López |
| David Stiven Franco López | `david-franco` | PENDIENTE | PENDIENTE | PENDIENTE | Marbel Juliana Mejía Bedoya |
| Marbel Juliana Mejía Bedoya | `marbel-mejia` | PENDIENTE | PENDIENTE | PENDIENTE | Jhon Fernando Sánchez Álvarez |
| Jhon Fernando Sánchez Álvarez | `jhon-sanchez` | PENDIENTE | PENDIENTE | PENDIENTE | Marlon García Sepúlveda |
| Marlon García Sepúlveda | `marlon-garcia` | PENDIENTE | PENDIENTE | PENDIENTE | Juan Sebastian Echeverri Gallego |

### Detalle integrante 1 — Juan Sebastian Echeverri Gallego

**Commit 1 (consola, Git Bash)**

```
abeb079  feat: add assigned API endpoint
```

Creación de `Controllers/StatusController.cs` con el endpoint `GET /api/status`.
Secuencia ejecutada: `git status` → `git diff` → `git add .` → `git diff --staged`
→ `git commit` → `git log --oneline -3`.

**Commit 2 (Git Changes, Visual Studio Community 2026)**

```
4a608e4  feat: extend status endpoint
```

Adición del endpoint `GET /api/status/team`. El archivo `StatusController.cs` se
pasó a staging desde el panel Cambios de GIT y se confirmó con
"Confirmar cambios staged".

**Endpoints verificados**

| Método | Ruta | Respuesta |
|---|---|---|
| GET | `/api/status` | `{"status":"Running"}` |
| GET | `/api/status/team` | `{"team":"Equipo 1","status":"Ready"}` |

---

## 2. Conflicto en TeamMessage.txt

- Integrantes involucrados: David Stiven Franco López (integrante 2) y Marbel Juliana Mejía Bedoya (integrante 3)
- Pull Request donde se resolvió: PENDIENTE
- Hash del commit de resolución: PENDIENTE
- Versión del integrante 2: `Estado del proyecto: preparado para entrega.`
- Versión del integrante 3: `Estado del proyecto: en validación.`
- Texto final acordado: `Estado del proyecto: preparado para entrega y en validación.`
- Mensaje del commit de resolución: `fix: resolve team message conflict`

Causa del conflicto: ambas ramas personales se crearon desde el mismo commit de
`main` y modificaron la misma línea del archivo. Al integrarse primero el Pull
Request del integrante 2, la rama del integrante 3 quedó desactualizada y Git no
pudo determinar automáticamente cuál versión conservar.

---

## 3. Recuperación de cambios

### 3.1 `git restore` — Jhon Fernando Sánchez Álvarez (integrante 4)

Modificación temporal de `README.md` en la rama `jhon-sanchez`, revisión de la
diferencia con `git diff README.md` y descarte del cambio con
`git restore README.md`. `git status` quedó sin cambios pendientes.

Evidencia: PENDIENTE (captura o salida de terminal)

### 3.2 `git restore --staged` — Jhon Fernando Sánchez Álvarez (integrante 4)

Nueva modificación de `README.md`, paso a staging con `git add README.md` y
retiro del staging con `git restore --staged README.md`, conservando el archivo
en el directorio de trabajo. Posteriormente se descartó con `git restore README.md`.

Evidencia: PENDIENTE (captura o salida de terminal)

### 3.3 `git revert` — Marlon García Sepúlveda (integrante 5)

- Rama auxiliar: `marlon-garcia-revert` (no se integra a `main`)
- Archivo creado: `TemporaryNote.txt`
- Hash del commit temporal: PENDIENTE — `test: add temporary note`
- Hash del commit generado por revert: PENDIENTE

Ambos commits se conservan en el historial de la rama auxiliar.

---

## 4. Capturas

| Evidencia | Archivo |
|---|---|
| Commit 1 — Git Bash (consola) | [Commit-1-Consola.png](docs/JuanSebastianEcheverriGallego/Commit-1-Consola.png) |
| Commit 2 — Git Changes de Visual Studio | [Commit-2-VisualStudio-1.png](docs/JuanSebastianEcheverriGallego/Commit-2-VisualStudio-1.png) |
| Commit 2 — Git Changes, confirmación | [Commit-2-VisualStudio-2.png](docs/JuanSebastianEcheverriGallego/Commit-2-VisualStudio-2.png) |
| Colaboradores del repositorio (incluye `orlapez`) | [colaboradores.png](docs/colaboradores.png) |

---

## 5. Colaboradores del repositorio

| Integrante | Usuario GitHub |
|---|---|
| Juan Sebastian Echeverri Gallego | `JuanSebastianEcheverriGallego` |
| David Stiven Franco López | `Davdfranco` |
| Marbel Juliana Mejía Bedoya | `JULIANA-s22` |
| Jhon Fernando Sánchez Álvarez | `Jhonzn` |
| Marlon García Sepúlveda | `M3rl0n` |
| Profesor | `orlapez` |