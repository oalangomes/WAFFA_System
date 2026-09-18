# WAFFA System 2012 — Preservation Manifest

This manifest records the surviving historical artifacts recovered in September 2026.

The original artifacts are immutable preservation inputs. Development, migration and analysis must operate on copies.

| Artifact | Size | SHA-256 | Status |
| --- | ---: | --- | --- |
| `tcc3.pdf` | 947,932 bytes (926 KiB on disk) | `60032caef44c6cd846c3b1687460b7a911055e15c411a304b74d0ba9959c4ba5` | recovered locally; binary upload pending |
| `Desenvolvimento de software para informatização da Loja Ecotrel.pptx` | 299,683 bytes (293 KiB on disk) | `664f81212de06fac75b6367ad30e773d7007f5b4a6c5e3667e64c57c1742ded8` | recovered locally; binary upload pending |
| `WaffaSystem_BD.mdb` | 303,104 bytes (296 KiB on disk) | `e05a3e18e07d25cc2ee930b33a04f89c93b594ec35fcb315db114fbf5b05401e` | recovered locally; binary upload pending |

## Provenance

The three files were supplied by Alan Gomes in the WAFFA System reconstruction conversation on 2026-09-15. They correspond to the original 2012 technical-school graduation project artifacts that survived after the Delphi source code was lost.

## Preservation rules

1. Never edit an archived original in-place.
2. Verify SHA-256 after any copy or transfer.
3. Put extracted data, converted formats and migrations outside the immutable archive path.
4. When the binary artifacts are committed, replace `binary upload pending` with the repository blob/commit reference and re-verify the hashes.

## Re-verification

```bash
sha256sum \
  archive/2012/tcc3.pdf \
  "archive/2012/Desenvolvimento de software para informatização da Loja Ecotrel.pptx" \
  archive/2012/WaffaSystem_BD.mdb
```

Expected hashes are the values in the table above.
