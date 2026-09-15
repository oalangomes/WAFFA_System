# WAFFA System

> A software archaeology and reconstruction project based on my 2012 Technical School graduation project.

## The story

WAFFA System was originally developed in **2012** as the final project for the Technical Course in Informatics at **ETEC Vasco Antônio Venchiarutti**, in Jundiaí, São Paulo, Brazil.

The project was created for a real local business, **Ecotrel**, after identifying a practical inventory-management problem. The original application was built as a Windows desktop system using **Delphi** with a **Microsoft Access** database.

More than a decade later, the original Delphi source code is no longer available. However, part of the project survived:

- the original graduation thesis;
- the presentation used for the project;
- screenshots of the running application;
- the original Microsoft Access database (`WaffaSystem_BD.mdb`).

In 2026, I decided to preserve these artifacts and reconstruct the system.

## Original system — 2012

The documented scope included:

- product registration and maintenance;
- product categories and suppliers;
- inventory entry and quantity control;
- sales registration;
- total and change calculation;
- sales history and consultation;
- monthly revenue, expenses and profit;
- stock alerts;
- operational reports, including best- and worst-selling products.

The original stack was roughly:

```text
Desktop application : Delphi
Database            : Microsoft Access
Modeling            : Astah
Visual assets        : Adobe Photoshop CS5
Target environment   : Windows
```

One original design decision was to avoid user authentication because the store had only a few employees and the team considered repeated login friction unnecessary for the sales workflow. The final report already anticipated authentication as a future feature if the number of employees increased.

## Reconstruction goals

This repository has two distinct goals.

### 1. Preservation

Recover and document as much as possible from the original 2012 system without rewriting history.

Original artifacts, screenshots, terminology, decisions and limitations should be preserved as historical material.

### 2. Reconstruction

Rebuild the behavior of the original WAFFA System from the surviving evidence: thesis, presentation, screenshots and database.

The first reconstruction should prioritize **behavioral fidelity** over modernization.

A later modern implementation may reinterpret the same business problem using contemporary engineering practices while keeping the 2012 reconstruction intact.

## Repository direction

```text
WAFFA_System/
├── archive/                  # Original surviving artifacts (to be added)
├── docs/
│   ├── original-system.md
│   ├── recovered-database.md
│   └── reconstruction-plan.md
├── legacy-reconstruction/   # Faithful reconstruction of the 2012 application
└── modern-rebuild/           # Optional modern reinterpretation
```

## Recovery status

| Artifact | Status |
| --- | --- |
| Graduation thesis | Recovered |
| Presentation | Recovered |
| Screenshots | Recovered inside the thesis |
| Microsoft Access database | Recovered |
| Original Delphi source code | Missing |

## Why preserve this?

This is not an attempt to present 2012 code as modern software engineering.

It is a historical snapshot of an early software project: a real problem, a real client, a small team, desktop software, database persistence, use cases, inventory rules and reporting — built at the beginning of my career in technology.

The reconstruction is intentionally both technical and archival.

## Roadmap

The first milestones are:

1. archive the surviving original artifacts;
2. document the original behavior and screens;
3. inspect and document the Access database schema;
4. define a fidelity contract for the reconstruction;
5. rebuild the original flows;
6. validate the reconstruction against the historical evidence;
7. only then evaluate a modern rebuild.

See the repository issues for the active reconstruction plan.

---

**Original project:** 2012  
**Reconstruction started:** 2026
