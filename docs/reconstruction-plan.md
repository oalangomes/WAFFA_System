# Reconstruction Plan

## Principle

The first reconstruction of WAFFA System should be a **software-preservation exercise**, not a redesign.

The goal is to recover the behavior of the 2012 application as faithfully as the surviving evidence allows.

Modernization is a separate phase and must not overwrite the historical reconstruction.

## Evidence hierarchy

When implementation choices conflict or evidence is incomplete, use this order:

1. surviving original database;
2. screenshots of the original running system;
3. behavior explicitly described in the 2012 thesis;
4. presentation material;
5. clearly documented reconstruction inference.

No inferred behavior should be presented as an original 2012 fact.

## Phase 0 — Preserve the source material

- add the recovered thesis to `archive/`;
- add the recovered presentation to `archive/`;
- add the original `WaffaSystem_BD.mdb` to `archive/`;
- calculate and record hashes for archival files;
- keep archival binaries unchanged after import.

## Phase 1 — Recover the domain

Document:

- entities and fields from the Access database;
- relationships and keys;
- product lifecycle;
- stock-entry flow;
- sales flow;
- financial calculations;
- reporting rules;
- known validations and messages.

Every finding should be labeled as documented, observed, recovered, or inferred.

## Phase 2 — Choose the faithful reconstruction stack

The reconstruction should prioritize:

- Windows desktop behavior;
- straightforward local execution;
- relational persistence;
- UI structure close to the screenshots;
- low implementation complexity.

Candidate approaches include C# / WinForms or Delphi. The stack decision should be recorded before implementation begins.

## Phase 3 — Rebuild core flows

Suggested implementation order:

1. database model and migration/import tooling;
2. categories and suppliers needed by products;
3. product registration and maintenance;
4. stock entry and stock quantities;
5. sales and change calculation;
6. sales history;
7. monthly revenue / expenses / profit;
8. reports and stock alerts.

## Phase 4 — Historical validation

Validate the reconstruction against:

- screenshots;
- documented field names;
- documented use-case steps;
- recovered schema;
- recovered data where available.

A reconstructed feature is considered historically validated only when its evidence is recorded.

## Phase 5 — Modern rebuild

Only after the preservation reconstruction is usable should a modern interpretation be considered.

The modern version may change architecture, UI, authentication, deployment, database and observability, but it should solve the same underlying business problem so that the evolution can be compared meaningfully.

## Non-goals for the first reconstruction

- microservices;
- cloud deployment;
- distributed architecture;
- speculative features not supported by surviving evidence;
- rewriting archival documents;
- hiding original design limitations.

## Definition of done for preservation v1

Preservation v1 is complete when:

- original artifacts are archived and checksummed;
- recovered schema is documented;
- core historical flows work locally;
- reconstructed screens are traceable to historical evidence;
- differences from the original are explicitly documented;
- the original source-code loss remains clear in the project history.
