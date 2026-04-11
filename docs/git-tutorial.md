# Git tutoriál

### Základní pojmy
- `origin` - zkrácený název pro vzdálený repozitář, ze kterého byl projekt původně naklonován
- `main` - hlavní větev
- `HEAD` - zkrácený název pro aktuální větev (např. 3/git-tutorial)


### Konvence commitů
- `<popisek>` zadávat jako `<typ>: <název_změny>`
  - např. `feat: přidání login formuláře`

### Konvence Pull Requestů (PR)
- **Title (`<Název>`):** Měl by mít stejný formát jako `<popisek>` v hlavním `commitu` (`<typ>: <název_změny>`)
- **Description (`<popisek>`):** Zde je možno podrobněji rozepsat, **co** PR řeší a **proč**, pokud by popis v `<Title>` nestačil

### Správa větví

- `git branch <název_větve>` - vytvoření větve
- `git switch <název_větve>` - přepnutí do větve
- `git branch -d <název_větve>` - smazání větve

## Uložení do vzdáleného repozitáře

### Synchronizace

- `git stash` - pro uložení všech rozpracovaných změn
- `git pull origin main --rebase` - stažení změn z `main`
> [!IMPORTANT]
> `--rebase` - udrží historii `commitů` "čistou" a lineární
> 1. `Git` vezme lokální změny a dočasně je "dá stranou"
> 2. aplikuje stažené změny z `main`
> 3. přeskládá `commity` na samotný konec
>
> **bez** `--rebase` - `Git` vytvoří zbytečný `merge commit`, což při častém používání udělá v historii `commitů` zmatek
- `git stash pop` - načtění rozpracovaný změn v `git stash`

### Kontrola stavu

- `git status` - pro ukázku stavu mojí práce (změny v projektu)
  - červeně - změny, které se nepošlou do **staging area**
  - zeleně - změny, které si přidal pomocí `git add <cesta_změněného_souboru>` do **staging area**
- `git log`- ukáže historii commitů a v jaký větvi se právě nacházíš (**HEAD**)
  - `git log --oneline` - každý `commit` zabere přesně **jeden řádek**, obsahuje jen zkrácený hash (**prvních 7 znaků**) a název `commitu`

### Uložení

- `git add <cesta_změněného_souboru>` - přidání změněného souboru do **staging area**
- `git restore <sourbor>` - zahodí tvoje poslední úpravy a vrátí soubor do stavu, v jakém byl při posledním commitu
> [!CAUTION]
> Samotný `git restore <soubor>` smaže tvoje úpravy v souboru a vrátí stav z historie
>
> Pomocí `git restore --staged <soubor>` zachová tvůj kód, ale vyndá ho ze **staging area**
- `git commit -m "<popisek>"` - uložení změn do lokálního repozitáře
- `git push origin <zdroj>:<cíl>` - odeslání změn z větve `<zdroj>` do větve `<cíl>`
  - `git push origin HEAD:main` - odeslání změn z větve `HEAD` do větve `main`
  - `git push origin HEAD` - odeslání změn z `HEAD` do větve se stejným názvem ve <ins>vzdáleném</ins> repozitáři 

## Životní cyklus změny

- `git add <cesta_změněného_souboru>` - **staging area**
- `git commit -m "<popisek>"` - lokální repozitář
- `git push origin HEAD:main` - vzdálený repozitář

## Rozdíl mezi . a *
- **tečka** - aktuální adresář a všechno v jeho podadresářích
> [!IMPORTANT]
> tečka <ins>**vidí**</ins> i skryté soubory (např. soubor `.env`)
- **hvězdička** -  všechny **viditelné** soubory
>[!IMPORTANT]
> hvězdička <ins>**nevidí**</ins> skryté soubory (např. soubor `.env`)
