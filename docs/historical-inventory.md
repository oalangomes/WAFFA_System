# Historical Behavior and Screen Inventory

This inventory reconstructs the 2012 WAFFA System only from surviving evidence. Every item is classified as one of:

- **documented** — explicitly described in the thesis/presentation;
- **observed** — visible in a surviving screenshot;
- **recovered** — recovered from the original MDB;
- **inferred** — plausible but not directly proven; must not drive faithful behavior without confirmation.

## Product maintenance

### Behavior

- list products in stock — **documented**
- register a product — **documented**
- alter a product — **documented**
- delete a product with confirmation — **documented**
- stock entry from the product-maintenance flow — **documented**
- show `produto não encontrado` when lookup fails — **documented**

### Documented product data

- code generated automatically
- product name
- category
- quantity
- purchase value
- sale value
- profit calculated by the system
- minimum quantity
- maximum quantity
- serial
- physical location

All items above are **documented**.

### Screenshot evidence

The surviving product screen shows a desktop window with product information, supplier/category selectors, quantity limits, purchase/sale/profit values, location fields and a product grid. This is **observed** evidence for layout and visible controls, not proof of implementation details behind each control.

### Database evidence

`Produtos` and fields including `Cod_Produto`, `Desc`, `PrecoUnit`, `Marca`, `Cod_Categoria`, `Quantidade`, `Cod_Fornecedor` are **recovered** from the MDB.

## Sales

### Behavior

- start a new sale — **documented**
- maintain a list of products in the current sale — **documented**
- search/select product by name or code — **documented**
- add selected products to the sale list — **documented**
- accumulate sale total — **documented**
- capture date/time from the operating system — **documented**
- calculate change as amount paid minus total — **documented**
- finalize sale and persist it — **documented**
- assign sale identifiers automatically and in order — **documented**
- show `produto não encontrado` when lookup fails — **documented**

### Screenshot evidence

The surviving sales window shows `Venda Nº`, product code/description/unit price/quantity, a sale-items grid, total, paid amount, change and a calculate action. These are **observed**.

### Database evidence

`Vendas` and `Vendas_Temp` plus sale-related fields are **recovered** from the MDB.

## Sales consultation

- list sales ordered by date — **documented**
- show sale code, date, sale value and profit — **documented**
- alter a sale — **documented**
- delete a sale with confirmation — **documented**
- emit reports for a selected sale and its products — **documented**

Whether production use actually allowed edits/deletes exactly as documented is not separately proven by screenshot or source code.

## Revenue / expenses / profit

- list months from newest to oldest — **documented**
- show monthly revenue — **documented**
- show monthly profit — **documented**
- produce a monthly revenue/sales report — **documented**

The surviving screenshot visibly shows a monthly window with `Lucro` and `Faturamento`; this is **observed**.

## Reports

The thesis documents these report families:

- quantity of products
- product entries
- 20 most sold products by month
- 20 least sold products by month
- sales report
- monthly revenue / expenses / profit

These are **documented** requirements. Report rendering technology, exact formatting and whether every report was fully implemented are not proven by the surviving artifacts.

## Authentication

The thesis explicitly decides **not** to require login for the original deployment because the store had only a few employees and login switching would slow down sales. This is **documented** and should be preserved in the faithful reconstruction.

A future login capability is mentioned only as a possible evolution if the company grows. It is not part of the faithful v1 scope.

## Categories, suppliers and clients

The surviving screenshots/menu text and database strings provide evidence for categories and suppliers in the product domain. The MDB contains a `Cliente` object with `Cod_Cliente`.

However, the thesis final considerations describe customer registration as a possible future capability. Therefore a complete customer-registration workflow is **not proven** as part of the original delivered core and must not be invented for preservation v1.

## Fidelity checklist for preservation v1

A faithful v1 should prove at least:

- [ ] desktop UI shaped around the original product and sales workflows
- [ ] product create/update/delete flow
- [ ] stock quantity and min/max fields
- [ ] product purchase/sale values and calculated profit
- [ ] new-sale product selection
- [ ] running sale total
- [ ] paid amount and change calculation
- [ ] automatic sale id and OS date/time
- [ ] persisted sales history
- [ ] monthly revenue/profit view
- [ ] no mandatory login
- [ ] SQLite schema/migrations traceable to documented or recovered evidence
- [ ] intentional differences documented

## Known gaps

- exact Delphi source behavior is lost;
- exact Access data types/relationships still need extraction;
- exact original visual assets are not yet separately recovered;
- implementation completeness of all reports is not independently proven;
- barcode-reading behavior is described as an objective but the surviving material does not prove the hardware/integration implementation.
