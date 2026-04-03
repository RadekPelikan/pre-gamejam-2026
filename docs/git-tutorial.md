# Git tutoriál

### Konvence commitů

`<popisek>` zadávat jako `<typ>: <název_změny>`
- např. feat: přidání login formuláře
- **Pull request** - do `<popisek>` zanechat zprávu jako v `commit`

### Správa větví

- `git branch <název_větve>` - vytvoření větve
- `git switch <název_větve>` - přepnutí do větve
- `git branch -d <název_větve>` - smazání větve

## Uložení do vzdáleného repositáře

### Synchronizace

- `git stash` - pro uložení všech rozpracovaných změn
- `git pull origin main --rebase` - stažení změn z main
- `git stash pop` - načtení rozpracovaných změn v `git stash`

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
- `git commit -m "<popisek>"` - uložení změn do lokálního repositáře
- `git push origin HEAD:main` - poslání změn z aktuální větve (**HEAD**) do `main`

## Životní cyklus změny

- `git add <cesta_změněného_souboru>` - **staging area**
- `git commit -m "<popisek>"` - lokální repositář
- `git push origin HEAD:main` - vzdálený repositář

## Rozdíl mezi . a *
- **tečka** - aktuální adresář a všechno v jeho podadresářích
> [!IMPORTANT]
> tečka <ins>**vidí**</ins> i skryté soubory (např. soubor `.env`)
- **hvězdička** -  všechny **viditelné** soubory
>[!IMPORTANT]
> hvězdička <ins>**nevidí**</ins> skryté soubory (např. soubor `.env`)
