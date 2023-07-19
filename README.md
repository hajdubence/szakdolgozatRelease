# A szakdolgozati program hordozható kiadása.


## Használat

### Windows:
- Futtasd a producer.exe programot majd a visualizzer.exe programot.

### Ubuntu 22.04:
- Függőségek telepítése szükséges az első használat előtt: `sudo ./Ubuntu\ 22.04/install_dependencies_ubuntu_22.04.sh`
- Futtasd a producer programot majd a visualizer programot a terminálból.


## Működés

### Visualizer:
- input.bin -> Visualizer -> output.txt
- Az input.bin fájlt olvassa és annak tartalmát jeleníti meg.
- Az interakciókat az output.txt fájlba írja.
- A program működése a beállításokban módosítható: [settings.txt](<Windows x64/settings.txt>)

### Producer
- output.txt-> Producer -> input.bin
- A figyeli az előző program kimenetét és ez alpján készíti el a bemenetet.
- Lecserélhető tetszőleges saját programra.
