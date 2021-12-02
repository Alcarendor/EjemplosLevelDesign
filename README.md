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
- Una versión modificada de los Standard Assets, que incluye solamente lo relacionado con el terreno.
- [Rock Package](https://assetstore.unity.com/packages/3d/props/exterior/rock-package-118182), para tener un grupo de rocas con LOD que utilizar en las prácticas de terrenos.
- [Rocks](https://assetstore.unity.com/packages/3d/props/exterior/rocks-604): para tener rocas sin LOD con las que pintar en terrenos.

Ambos proyectos tienen ya actualizados sus materiales a URP.

Probablemente se instalen otros a lo largo del curso, se irá viendo.

### De fuera de la Asset Store

- Edición personalizada de los Standard Assets, únicamente añadiendo lo relacionado con los terrenos. Se ha añadido en la carpeta [StandardAssets](https://github.com/Alcarendor/EjemplosLevelDesign/tree/main/Assets/Standard%20Assets)
- Pequeñas actualizaciones de código para añadir un sistema, escalable, de interactuaciones. Se han modificado los ficheros del [Input System](https://github.com/Alcarendor/EjemplosLevelDesign/tree/main/Assets/StarterAssets/InputSystem) de los Starter Assets para añadir un nuevo input, así como los siguientes ficheros:
  - El fichero [First Person Controller](https://github.com/Alcarendor/EjemplosLevelDesign/blob/main/Assets/StarterAssets/FirstPersonController/Scripts/FirstPersonController.cs). Se ha planeado la reversión de este fichero al formato original y sacar todo este contenido a otra clase, para que también se pueda aplicar sobre el Third Person Controller.
  - Se ha añadido la carpeta [Scripts](https://github.com/Alcarendor/EjemplosLevelDesign/tree/main/Assets/Scripts) con los elementos necesarios para que este activador genérico funcione (todavía en beta, sobre todo en lo relacionado con las animaciones).

## Docencia a través de este proyecto

En cada escena habrá elementos explicativos de diferentes elementos que usaré para explicar cosas. Desde elementos insertados con TextMeshPro para que se vean mientras se está testeando el nivel a GameObjects de Unity que tendrán determinados nombres en la jerarquía, para que separen secciones de objetos.

Cada nivel estará lo mejor ordenado posible (sobre todo en las versiones finales, algunas versiones intermedias estarán desordenadas a posta para luego en clase discutir sobre las posibles mejoras).
