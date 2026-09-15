# Original WAFFA System (2012)

This document records the surviving evidence about the original WAFFA System without modernizing or correcting the original project.

## Context

WAFFA System was developed in 2012 as a Technical Course in Informatics graduation project at ETEC Vasco Antônio Venchiarutti, in Jundiaí, São Paulo, Brazil.

The project followed a visit to the Ecotrel store and a conversation with its owner. The team identified inventory-control problems and proposed software that could run on the computer the business already owned, avoiding significant additional infrastructure cost.

## Original purpose

The system was intended to improve stock organization and day-to-day operations by supporting:

- product registration;
- inventory entry;
- product maintenance;
- sales registration;
- stock-level control;
- monthly revenue and profit calculation;
- product-availability alerts;
- operational reports.

## Documented use cases

The original thesis describes five main use cases:

1. **Maintain Products**
2. **Consult Products**
3. **Sales**
4. **Consult Sales**
5. **Consult Revenue / Profit**

### Maintain Products

The documented product data included:

- product code;
- name;
- category;
- quantity;
- purchase price;
- sale price;
- calculated profit value;
- maximum quantity;
- minimum quantity;
- serial number;
- physical location.

The flow supported creation, update and deletion.

### Sales

The sales flow was documented to:

- prepare a list for the products in the purchase;
- find products by name or code;
- accumulate selected products and values;
- capture operating-system date and time;
- calculate change from amount paid minus total;
- persist the completed sale;
- assign sale identifiers automatically.

### Consult Sales

The sales-consultation flow included:

- sale code;
- date;
- sale value;
- sale profit;
- update and delete actions;
- report generation.

### Revenue / expenses / profit

The financial view was designed to show monthly values and make monthly historical information available.

## Reports described in the thesis

The original project planned reports for:

- product quantities;
- incoming products;
- 20 best-selling products in the month;
- 20 least-selling products in the month;
- sales;
- monthly revenue, expenses and profit.

## Original implementation choices

### Desktop application

The thesis states that WAFFA System was developed in **Delphi** because the team already had familiarity with the language/tooling.

### Database

**Microsoft Access** was selected because it was considered simple to integrate with Delphi and already part of Microsoft Office.

### Modeling and assets

Surviving material indicates use of:

- Astah for use-case modeling;
- Adobe Photoshop CS5 for logo, background images and buttons.

## Authentication decision

The original system intentionally did **not** require login.

The rationale documented in 2012 was that only a small number of employees would use the software, and switching users or repeatedly logging in could slow down the sales process.

The final considerations already identified authentication as a possible future feature if the number of employees increased.

## Screens preserved in the thesis

The surviving thesis contains screenshots of at least:

- product registration / maintenance;
- sales;
- monthly revenue / profit consultation.

These screenshots should be treated as primary visual evidence for the faithful reconstruction.

## Historical constraints

The original Delphi source code is currently missing.

The reconstruction must therefore distinguish between:

- **documented behavior** — explicitly described in the surviving material;
- **observed behavior** — inferable from screenshots or recovered data;
- **reconstructed behavior** — implementation choices made in 2026 where the historical evidence is incomplete.

That distinction should remain visible in design notes and issues.
