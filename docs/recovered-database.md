# Recovered Database

## Status

The original Microsoft Access database, `WaffaSystem_BD.mdb`, survived even though the Delphi source code did not.

This file is a primary preservation artifact and should remain unchanged once added to the repository archive.

## Structures currently visible in the recovered file

A lightweight structural inspection of the recovered MDB exposes at least the following table/object names:

- `Produtos`
- `Vendas`
- `Vendas_Temp`
- `Cliente`

Visible field names include:

### Produtos

- `Cod_Produto`
- `PrecoUnit`
- `Cod_Categoria`
- `Quantidade`
- `Cod_Fornecedor`

### Vendas

- `Cod_Venda`
- `Valor_Total`
- `Valor_Desconto`
- `Valor_Acres`

### Vendas_Temp

- `Cod_Venda`
- `Valor_Total`
- `Valor_Desconto`
- `Valor_Acres`
- `Quantidade`

### Cliente

- `Cod_Cliente`

These names are recovered directly from the database file structure. They are not a complete schema yet.

## Next recovery work

A dedicated extraction pass should document:

- all tables and queries;
- all columns and data types;
- primary keys;
- relationships;
- indexes;
- default values;
- validation rules;
- surviving rows/data;
- Access-specific objects relevant to application behavior.

The extraction should produce a machine-readable schema snapshot and a human-readable report.

## Preservation rule

Do not modify the original `.mdb` during analysis.

Any migration, normalization or experimental change must operate on a copy or on an exported database.

## Planned migration target

For the faithful reconstruction, the recovered Access model may be migrated to a simpler currently supported relational database such as SQLite, provided that:

1. the original MDB remains archived unchanged;
2. the migration is scripted and reproducible;
3. schema differences are documented;
4. reconstructed behavior remains traceable to historical evidence.
