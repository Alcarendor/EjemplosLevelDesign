# PruebasDisenoNiveles2021-2022

Repositorio con ejemplos y ejercicios de Diseño de Niveles durante el curso 2012/2022.

## Orientación del repositorio

En este repositorio se irán colocando los diferentes ejercicios, ejemplos y otra información relevante para el desarrollo de la asignatura. También se usará como referencia de uso.

Este proyecto tendrá como plantilla de Unity el proyecto con **URP**, ya que al final de cuatrimestre se utilizará para la iluminación de los escenarios.

## Distribución de carpetas

Las carpetas estarán ordenadas en este repositorio como se pretende que se ordenen durante el transcurso de la asignatura. La ordenación de carpetas es algo relevante y muy importante en la organización de proyectos de Unity, por lo que se prestará especial atención a ello.

Las carpetas que vienen incluidas con la plantilla de los proyectos URP se dejarán como ejemplo del sistema de iluminación y para usarlas en clase cuando llegue el momento.

Fuera de la carpeta **Assets**, en la raíz del proyecto, se encontrará la carpeta de **Preproducción**, que contendrá información sobre la preproducción de los niveles, distribuidas en carpeta según el tipo de nivel que se esté haciendo de ejemplo.

## Descripción técnica y paquetes instalados

### Versión de Unity

La versión de Unity en la que se ha construido este proyecto es **2020.3.19f1**, no se ha testeado en versiones posteriores (aunque en principio debería de funcionar sin mayor problema).

### Importación

Para utilizar este repositorio, simplemente hay que clonar el proyecto a través de GIT (o descargando todo en un zip) y abriendo la carpeta raíz en Unity. Tras importación del proyecto, puede tardar unos minutos, se podrá comenzar a utilizar.

### De Unity Technologies (a través del Package Manager)

En negrita, los paquetes de Unity Registry que se deben de instalar aparte para la asignatura.

- JetBrains Rider Editor (preinstalado).
- Test Framework (preinstalado).
- TextMeshPro (preinstalado).
- Timeline (preinstalado).
- Unity UI (preinstalado).
- Universal RP (URP, preinstalado).
- Version Control (preinstaslado).
- Visual Studio Code Editor (preinstalado).
- Visual Studio Editor (preinstalado).
- **ProBuilder** (instalación aparte). Hay que instalar también el soporte a URP al instalar el paquete. Si no, habrá problemas con los materiales.
- **ProGrids** (instalación aparte, experimental).
- Más adelante se instalarán más paquetes.

### De la Asset Store (aparte)

- [Starter Assets - First Person Character Controller](https://assetstore.unity.com/packages/p/starter-assets-first-person-character-controller-196525).
- [Starter Assets - Third person Character Controller](https://assetstore.unity.com/packages/essentials/starter-assets-third-person-character-controller-196526).

Ambos proyectos tienen ya actualizados sus materiales a URP.

Probablemente se instalen otros a lo largo del curso, se irá viendo.

### De fuera de la Asset Store

Al comienzo del curso, ninguno, pero más adelante se instalará [Fungus](https://github.com/snozbot/fungus) de su repositorio. Existe una versión de Fungus en la Asset Store, pero se actualiza más lentamente y, en el momento de la creación de este repositorio, no se podía instalar en ninguna versión de Unity por encima de 2020.1.

Según se añadan paquetes extras para, por ejemplo, assets para la decoración de niveles o skyboxes, se creará un listado aquí. Todo elemento que sobre de dichos paquetes se eliminará para no saturar el proyecto (como se eliminará próximamente todo lo sobrante de los Starter Assets).

## Docencia a través de este proyecto

En cada escena habrá elementos explicativos de diferentes elementos que usaré para explicar cosas. Desde elementos insertados con TextMeshPro para que se vean mientras se está testeando el nivel a GameObjects de Unity que tendrán determinados nombres en la jerarquía, para que separen secciones de objetos.

Cada nivel estará lo mejor ordenado posible (sobre todo en las versiones finales, algunas versiones intermedias estarán desordenadas a posta para luego en clase discutir sobre las posibles mejoras).
