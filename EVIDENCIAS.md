# EVIDENCIAS — Equipo 1

Repositorio: https://github.com/JuanSebastianEcheverriGallego/TeamGitPractice

Commit base de `main`: `79e39d6` — chore: create base ASP.NET Core Web API

---

## 1. Commits, ramas y Pull Requests

| Integrante | Rama personal | Commit consola | Commit Visual Studio | Pull Request | Reviewer |
|---|---|---|---|---|---|
| Juan Sebastian Echeverri Gallego | `juan-echeverri` | `abeb079` | `4a608e4` | #4 | David Stiven Franco López |
| David Stiven Franco López | `david-franco` | `703fd01` | `e13729f` | #11 | Marbel Juliana Mejía Bedoya |
| Marbel Juliana Mejía Bedoya | `marbel-mejia` | `fe0dc35` | `19d24e7` | #7 | Jhon Fernando Sánchez Álvarez |
| Jhon Fernando Sánchez Álvarez | `jhon-sanchez` | `85e86aa` | `0f84241` | #9  | Marlon García Sepúlveda |
| Marlon García Sepúlveda | `marlon-garcia` | `3fe3b53` | `4a141d2` | #10  | Juan Sebastian Echeverri Gallego |

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

**Pull Request #4** —
- Rama: `juan-echeverri` → `main`
- Reviewer: `Davdfranco` Aprobó ("todo ok, apruebo")
- Merge commit: `fd7c67f` — Sep 4, 2026


### Detalle integrante 2 — David Stiven Franco López

**Commit 1 (consola, Git Bash)**

```
703fd01  feat: add assigned API endpoint
```

Creación de `Controllers/MembersController.cs` con el endpoint `GET /api/members`.
Secuencia ejecutada: `git status` → `git diff` → `git add .` → `git diff --staged`
→ `git commit` → `git log --oneline -3`.

**Commit 2 (Git Changes, Visual Studio Community 2026)**

```
e13729f  feat: extend members endpoint
```
Adición del endpoint `GET /api/members/count`. El archivo `MembersController.cs` se
pasó a staging desde el panel Cambios de GIT y se confirmó con
"Confirmar cambios staged".

**Pull Request #11**
- Rama: `david-franco` → `main`
- Reviewer asignado: Marbel Juliana Mejía Bedoya (`JULIANA-s22`) Aprobó
- Merge commit: `8a5a33e` — Sep 4, 2026

---

### Detalle integrante 3 — Marbel Juliana Mejía Bedoya

**Commit 1 (consola)**

```
fe0dc35  feat: añadir endpoint api/version
```

**Commit 2 (Visual Studio)**

```
19d24e7  feat: añadir endpoint /platform
```

**Pull Request #7** 
- Rama: `marbel-mejia` → `main`
- Reviewer: `Jhonzn` (Jhon Fernando Sánchez Álvarez)
- Merge commit: `c556fbf` — Sep 4, 2026
- Descripción: Se agrega `api/version` y `/api/version/platform`

---

### Detalle integrante 4 — Jhon Fernando Sánchez Álvarez

**Commit 1 (consola)**

```
85e86aa  crear GET /api/health
```

**Commit 2 (Visual Studio)**

```
0f84241  agregar GET /api/health/time
```

**Pull Request #9** — `
- Rama: `jhon-sanchez` → `main`
- Reviewer: `M3rl0n` (Marlon García Sepúlveda)
- Merge commit: `2bba0aa` — Sep 4, 2026
- Descripción: Se agrega el HealthController y se extiende el endpoint de status.

---

### Detalle integrante 5 — Marlon García Sepúlveda

**Commit 1 (consola)**

```
3fe3b53  feat: add assigned API endpoint
```

**Commit 2 (Visual Studio)**

```
4a141d2  feat: extend status endpoint.
```

**Pull Request #10** — 
- Rama: `marlon-garcia` → `main`
- Reviewer solicitado: `JuanSebastianEcheverriGallego`
- Merge commit: `ebf9537` — Sep 4, 2026
- Descripción: Agrega el controlador InfoController con los endpoints `/api/info` y `/api/info/tools`.

---

## 2. Conflicto en TeamMessage.txt

- Integrantes involucrados: David Stiven Franco López (integrante 2) y Marbel Juliana Mejía Bedoya (integrante 3)
- Pull Request donde se resolvió: **#7** (rama `marbel-mejia`)
- https://github.com/JuanSebastianEcheverriGallego/TeamGitPractice/pull/7/changes/b807567add41bcad0ee636db5196432ba8d8b2fe
- Hash del commit de resolución: **`b807567`**
- Mensaje del commit de resolución: `fix: resolve team message conflict.`
- Versión del integrante 2: `Estado del proyecto: preparado para entrega.`
- Versión del integrante 3: `Estado del proyecto: en validación.`
- Texto final acordado: `Estado del proyecto: preparado para entrega y en validación.`

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
- Hash del commit temporal: `978e6e9` — `test: add temporary note`
- Hash del commit generado por revert:  `4c661ed`

Ambos commits se conservan en el historial de la rama auxiliar.

---

## 4. Capturas

**integrante 1 — Juan Sebastian Echeverri Gallego**

| Evidencia | Archivo |
|---|---|
| Commit 1 — Git Bash (consola) | [Commit-1-Consola.png](docs/JuanSebastianEcheverriGallego/Commit-1-Consola.png) |
| Commit 2 — Git Changes de Visual Studio | [Commit-2-VisualStudio-1.png](docs/JuanSebastianEcheverriGallego/Commit-2-VisualStudio-1.png) |
| Commit 2 — Git Changes, confirmación | [Commit-2-VisualStudio-2.png](docs/JuanSebastianEcheverriGallego/Commit-2-VisualStudio-2.png) |
| Colaboradores del repositorio (incluye `oalarconpe`) | [colaboradores.png](docs/colaboradores.png) |

---

**integrante 2 — David Stiven Franco Lopez**

| Evidencia | Archivo |
|---|---|
| Commit 1 — Git Bash (consola) | [Commit-1-1-GitBash.png](docs/David_Stiven_Franco_Lopez/Commit-1-1-GitBash.png) |
| Commit 1.2 — Git Bash (consola) | [Commit-1-2-GitBash.png](docs/David_Stiven_Franco_Lopez/Commit-1-2-GitBash.png) |
| Commit 2 — Git Changes de Visual Studio | [Commit-2-1-VisualStudio.png](docs/David_Stiven_Franco_Lopez/Commit-2-1-VisualStudio.png) |
| Commit 2 — Git Changes, confirmación | [Commit-2-2-VisualStudio.png](docs/David_Stiven_Franco_Lopez/Commit-2-2-VisualStudio.png) |
| Commit Del Conflicto | [Commit-Conflicto.png](docs/David_Stiven_Franco_Lopez/Commit-Conflicto) |

---


## 5. Colaboradores del repositorio

| Integrante | Usuario GitHub |
|---|---|
| Juan Sebastian Echeverri Gallego | `JuanSebastianEcheverriGallego` |
| David Stiven Franco López | `Davdfranco` |
| Marbel Juliana Mejía Bedoya | `JULIANA-s22` |
| Jhon Fernando Sánchez Álvarez | `Jhonzn` |
| Marlon García Sepúlveda | `M3rl0n` |
| Profesor | `oalarconpe` |

---


