# Recovered Database

## Status

The original Microsoft Access database, `WaffaSystem_BD.mdb`, survived even though the Delphi source code did not.

The recovered file is 303,104 bytes and has SHA-256:

`e05a3e18e07d25cc2ee930b33a04f89c93b594ec35fcb315db114fbf5b05401e`

It is a primary preservation artifact and must remain unchanged once archived.

## Recovery method used so far

A non-mutating binary/string inspection was performed against a copy of the MDB. Full Jet/ACE metadata extraction is still pending because the current environment does not expose an Access/Jet schema reader.

The following names are therefore classified as **recovered directly from the MDB binary**, but column data types, indexes and relationship cardinalities are not yet considered proven.

## Recovered user tables / objects

### `Produtos`

Recovered field names:

- `Cod_Produto`
- `Desc`
- `PrecoUnit`
- `Marca`
- `Cod_Categoria`
- `Quantidade`
- `Cod_Fornecedor`

### `Vendas`

Recovered field names:

- `Cod_Venda`
- `Data`
- `Hora`
- `Valor_Total`
- `Valor_Desconto`
- `Valor_Acres`

### `Vendas_Temp`

Recovered field names:

- `Cod_Venda`
- `Valor_Total`
- `Valor_Desconto`
- `Valor_Acres`
- `Desc`
- `Quantidade`

### `Cliente`

Recovered field names:

- `Cod_Cliente`

## Recovered Access metadata evidence

The MDB also exposes Access system metadata and strings including:

- `MSysRelationships`
- `Relationships`
- `PrimaryKey`
- `MSysObjects`
- `MSysQueries`
- `MSysAccessStorage`
- `MSysAccessXML`
- `Microsoft Access 14.0 Object Library`
- `Microsoft Office 14.0 Access database engine Object Library`

This is evidence that the database contains normal Access schema metadata. It is **not** sufficient on its own to assert the exact primary key or relationship structure.

## Historical documentation cross-check

The thesis independently documents product data such as name, category, quantity, purchase value, sale value, calculated profit, minimum and maximum quantity, serial and physical location. It also documents sales with automatically assigned identifiers, date/time, totals and change calculation.

Where the thesis and MDB differ in naming or apparent scope, the reconstruction must preserve the distinction instead of silently normalizing the historical record.

## Evidence classification

| Claim | Classification | Evidence |
| --- | --- | --- |
| Original persistence used Microsoft Access | documented | 2012 thesis |
| `Produtos`, `Vendas`, `Vendas_Temp`, `Cliente` exist in the MDB | recovered | MDB binary inspection |
| Fields listed above exist as recoverable MDB strings | recovered | MDB binary inspection |
| Exact Jet/ACE data types | unknown | requires schema extraction |
| Exact PKs/FKs/cardinalities | unknown | requires schema extraction |
| Surviving row contents | unknown | requires table export/read |

## Next recovery work

A dedicated extraction pass should document:

- all user tables and queries;
- all columns and Jet/ACE data types;
- primary keys;
- relationships;
- indexes;
- default values;
- validation rules;
- surviving rows/data;
- Access-specific objects relevant to application behavior.

Preferred tooling is `mdbtools` or a Windows Jet/ACE provider operating on a disposable copy.

## Preservation rule

Do not modify the original `.mdb` during analysis.

Any migration, normalization or experimental change must operate on a copy or on an exported database.

## Reconstruction target

The faithful reconstruction will use a scripted SQLite schema derived from recovered/documented evidence. The original MDB remains an archival source, not the mutable application database.
