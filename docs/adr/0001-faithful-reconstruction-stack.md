# ADR-0001 — Faithful reconstruction stack

- Status: accepted
- Date: 2026-09-15

## Context

The original WAFFA System was a Windows desktop application built in Delphi with Microsoft Access. The original source code is lost, but the thesis, presentation, screenshots and Access database survived.

The first reconstruction is a preservation exercise, not a redesign. It should stay close to the original desktop interaction model while remaining reproducible and maintainable in 2026.

## Decision drivers

- Windows desktop behavior close to the original
- local/offline execution
- low operational complexity
- strong support for forms, grids, dialogs and menus
- straightforward relational persistence
- easy separation between immutable historical artifacts and mutable reconstructed data
- no need for cloud infrastructure or a web stack

## Options considered

### Delphi

**Pros**

- closest language/tooling lineage to the original application;
- potentially strongest historical fidelity.

**Cons**

- higher setup/licensing/tooling friction for contributors;
- reconstruction would depend more heavily on a specific IDE/toolchain;
- preserving behavior matters more than reproducing the exact compiler.

### C# + WinForms

**Pros**

- natural fit for a Windows desktop forms application;
- maps well to the original window/menu/grid interaction model;
- easy to maintain and automate with current .NET tooling;
- keeps the project intentionally simple.

**Cons**

- not the original implementation language;
- visual fidelity still requires deliberate work.

## Decision

Use **C# + WinForms on .NET 10** for the faithful reconstruction.

Use **SQLite** as the mutable reconstruction database.

The recovered `WaffaSystem_BD.mdb` remains an immutable archival input. A migration/reconstruction script will recreate only schema and behavior supported by historical evidence.

## Architectural shape

Start as a small modular desktop application, not a distributed system:

```text
WinForms UI
   ↓
Application/domain logic
   ↓
Persistence abstraction
   ↓
SQLite
```

No microservices, HTTP API, cloud runtime or mandatory authentication are introduced in preservation v1.

## Consequences

- screenshots and documented flows can be recreated with familiar desktop controls;
- the original MDB does not need to be mutated or required at runtime;
- reconstructed persistence is reproducible;
- differences from Delphi/Access must be recorded explicitly;
- a future modern reinterpretation may use a different architecture, but it is outside this ADR.
