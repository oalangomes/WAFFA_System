-- WAFFA System preservation reconstruction
--
-- This is a conservative SQLite baseline derived only from field/table names
-- recovered directly from WaffaSystem_BD.mdb. Types are reconstruction choices,
-- because exact Jet/ACE types have not yet been extracted.
--
-- Do not treat this file as an exact dump of the 2012 Access schema.

PRAGMA foreign_keys = ON;

CREATE TABLE IF NOT EXISTS Produtos (
    Cod_Produto INTEGER PRIMARY KEY AUTOINCREMENT,
    "Desc" TEXT,
    PrecoUnit NUMERIC,
    Marca TEXT,
    Cod_Categoria INTEGER,
    Quantidade INTEGER NOT NULL DEFAULT 0,
    Cod_Fornecedor INTEGER
);

CREATE TABLE IF NOT EXISTS Vendas (
    Cod_Venda INTEGER PRIMARY KEY AUTOINCREMENT,
    Data TEXT,
    Hora TEXT,
    Valor_Total NUMERIC NOT NULL DEFAULT 0,
    Valor_Desconto NUMERIC NOT NULL DEFAULT 0,
    Valor_Acres NUMERIC NOT NULL DEFAULT 0
);

CREATE TABLE IF NOT EXISTS Vendas_Temp (
    Cod_Venda INTEGER,
    Valor_Total NUMERIC NOT NULL DEFAULT 0,
    Valor_Desconto NUMERIC NOT NULL DEFAULT 0,
    Valor_Acres NUMERIC NOT NULL DEFAULT 0,
    "Desc" TEXT,
    Quantidade INTEGER NOT NULL DEFAULT 0
);

CREATE TABLE IF NOT EXISTS Cliente (
    Cod_Cliente INTEGER PRIMARY KEY AUTOINCREMENT
);
