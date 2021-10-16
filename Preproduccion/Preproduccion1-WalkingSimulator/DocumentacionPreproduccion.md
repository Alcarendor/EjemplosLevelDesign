# Demostración de una breve documentación de preproducción

La documentación de preproducción es toda aquella documentación que se genera de cara a crear un nivel. Antes de tocar un entorno de desarrollo, primero hay que pensar y tomar ciertas decisiones de diseño. Este breve ejemplo, un proyecto más grande implicaría muchísima más documentación, detalle y referencias. Para este primer proyecto de un Walking simulator contaba con las siguientes limitaciones:

- Se utilizaría el controlador proporcionado por Unity a través de los [Starter Assets](https://assetstore.unity.com/packages/p/starter-assets-first-person-character-controller-196525).
- La única "mecánica" disponible fuera del controlador sería la activación de elementos que desencadenen animaciones simples. Por ejemplo, abrir una puerta.
- El principal objetivo de este primer escenario no es tanto generar mecánicas al uso sino entender cómo funcionan las líneas de visión y orientar al jugador. Todo lo demás es accesorio.
- Dentro de la carpeta *Scenes->01-WalkingSimulator* habrá diferentes escenas (numeradas) para que se vea la evolución del nivel en las diferentes fases de la producción y que así sirva de ejemplo.

A continuación, iré rellenando las diferentes secciones siguiendo la guía de preproducción que se proporcionó en clase. Las secciones que se tratarán serán las de: propósito del nivel, features del nivel, referencias visuales, historia que se contará, objetivo del nivel (se puede incluir subobjetivos), puntos de referencia y, por último, el mapa del nivel.

Esta documentación no es 100% como se haría en un proyecto real, sino que estará ordenada de tal manera que pueda ser seguida por el alumnado que quiera revisar algo. Como nota, la documentación redactada a continuación dará "vueltas". Es decir, que los elementos posteriores forzarán cambios en los primeros. Esto es normal en las primeras fases de la creación de un nivel, cuando todavía no hay nada asentado.

## Localización

Esta sección se centrará en la localización del escenario. Muchas veces la localización vendrá dada por una estructura mayor, dada por el juego, y aquí el trabajo de preproducción será diferente. En vez de buscar ideas para nuevas localizaciones, se buscarán para las ya existentes y hacer más rico el desarrollo previo.

En el caso de este pequeño proyecto, esta localización será para un nivel único, sin recorrido anterior o posterior. La idea es que sea algo que pueda ser jugado de una vez.

### Definición de la localización

La localización que se va a escoger será urbana, concretamente en un **pueblo rural** que evoque recuerdos de la Castilla más cinematográfica.

En concreto, este nivel se desarrollará en la parte central de un pueblo, en lo que sería una plaza mayor y las callejuelas anexas. Los puntos más importantes de dicha localización serán la plaza mayor, el ayuntamiento (en esa misma plaza) y la Iglesia (en una de las calles anexas).

Se escogerán tonos pardos y blancos para representar los edificios del nivel, siendo la principal referencia visual Ayna, el pueblo dónde se ambienta la película *Amanece, que no es poco*.

## Propósito

Esta breve sección es, más que para añadirla a la preproducción, para que se use para completar el resto de elementos. Aquí se reflexionará sobre como se pretende que sea el nivel final, qué se quiere transmitir y por qué.

### Definición del propósito

En este nivel se pretenderá transmitir una sensación de calma y rutina. La idea principal es que le jugadore encarne a una persona de avanzada edad que pasea por enésima vez por el pueblo, siguiendo su ruta en el día a día.

El pueblo, como siempre, estará vacío porque ya casi todas las personas que vivían en él han muerto debido a la edad y su prole ha emigrado a ciudades más grandes y con más servicios, o simplemente para encontrar trabajo. Le jugadore será una de las pocas personas que quedan viviendo en el pueblo, siguiendo su tradición diaria de dar un paseo por las mañanas.

De manera ideal, el juego no será hiperrealista, sino que será bastante figurativo. Usará colores y texturas relativamente planas, cercanas a [*That Dragon, cancer*](http://www.thatdragoncancer.com/), pero sin la parte más surrealista e imaginaria del mismo. No habrá nada sobrenatural, solamente un pueblo que comienza a desdibujarse según pasan los años y nadie habita ya en él.

## Features

Esta sección, al igual que la anterior, repite bastantes elementos que realmente se encontrarán a lo largo de la documentación, pero se dejan aquí de manera independiente con fines docentes. Aquí se definirán diferentes claves visuales, se añadirán los elementos técnicos necesarios (esta parte se saltará, estos elementos ya están en el readme del proyecto), se hablará del gameplay que se desarrollará en el nivel (lista de acciones y mecánicas que hay que tener en cuenta a la hora de diseñar todo), un par de palabras sobre la historia y sobre el mundo.

También se tratará de que la persona que diseñe el nivel vuelva a hacerse preguntas sobre qué se pretende que experimente la persona que juegue, así como tratar de construir un nivel que tenga elementos distintivos sobre otros niveles.

## Definición de las features del nivel

- **Claves visuales**: la idea final del nivel, como se ha esbozado antes, es que tenga un estilo artístico minimalista, con colores y formas que recuerden a *That Dragon, cancer*, pero todo en un pueblo perdido de Albacete.
- **Gameplay**: las mecánicas que se podrán utilizar en este nivel serán:
  - Moverse (ritmo lento).
  - Interactuar con objetos.
  - Se bloqueará la opción de saltar del controlador, ya que un anciano no está para ir dando botes por el escenario.
- **Historia**: la historia que se va a contar será una que ha ocurrido muchas veces antes: un simple paseo de una persona de avanzada edad por las calles de su pueblo. Se pretenderá transmitir sensación de tristeza y abandono, pero también calma y rutina.
- **Mundo**: El pueblo en el que está ambientado el nivel será un pueblo más de la España rural: pueblo en llano, sin muchos desniveles y con la población envejecida que hay ido muriendo con el lento pasar de los años. Habrá casas y locales tapiados, ya sin clientela o abandonadas.
- **Emoción**: el jugador experimentará una sensación de paz al tiempo que de tristeza, de tiempos que no volverán pero tampoco será algo que lamentar. Como el fin de una vida plena, que es triste al acabar pero se sabe que se ha vivido todo con intensidad.
- **Elementos distintivos**: la propia ambientación en una población rural de la [España vaciada](https://es.wikipedia.org/wiki/Espa%C3%B1a_vaciada) (que no vacía) ya es de por sí un elemento distintivo no visto en demasiados videojuegos, aunque sí se haya representado habitualmente en otros productos culturales como el cine. Aunque, también es verdad, en sí el fenómeno de la España vaciada no ha sido representado de manera muy habitual en videojuegos.

## Referencias

Esta sección, más que por texto, se podrá ver en las carpetas de referencias, anexas a este fichero. Algunas carpetas se irán llenando conforme pase el tiempo, no todo se irá subiendo de golpe.

Aunque recomiendo usar un gestor de referencias visuales como [PureRef](https://www.pureref.com/), para que todo en este proyecto sea lo más compatible posible se dejarán las imágenes en las carpetas correspondientes.

Se valoró poner las imágenes en un fichero de Markdown para que se vieran directamente desde el repositorio sin descargar nada, pero la idea se descartó al estar trabajando con imágenes de alta calidad (para percibir los detalles) y los tiempos de carga habrían sido prohibitivos.

La principal referencia visual han sido los pueblos de la comarca de Teruel, como Albarracín.

Aquí iré dejando los links a las imágenes con licencia Creative Commons que se utilizan en este proyecto como referencia:

- **Referencias de entorno general**:
  - [Albarracín,_Teruel,_España,_2014-01-10,_DD_051.JPG](https://es.m.wikipedia.org/wiki/Archivo:Albarrac%C3%ADn,_Teruel,_Espa%C3%B1a,_2014-01-10,_DD_051.JPG)
  - [albarracin-1494762.jpg](https://pixabay.com/es/photos/albarracin-pueblo-valle-edificios-1494762/?download)
- **Referencias arquitectónicas**:
  - [Albarracín,_Teruel,_España,_2014-01-10,_DD_057.JPG](https://es.m.wikipedia.org/wiki/Archivo:Albarrac%C3%ADn,_Teruel,_Espa%C3%B1a,_2014-01-10,_DD_057.JPG)
  - [albarracin-1489085.jpg](https://pixabay.com/es/photos/albarracin-arag%c3%b3n-casas-bonita-1489085/)
  - [Albarracín_-_Catedaral_y_murallas.jpg](https://commons.wikimedia.org/wiki/File:Albarrac%C3%ADn_-_Catedaral_y_murallas.jpg)
  - [Albarracín,_Teruel,_España,_2014-01-10,_DD_087.JPG](https://es.m.wikipedia.org/wiki/Archivo:Albarrac%C3%ADn,_Teruel,_Espa%C3%B1a,_2014-01-10,_DD_087.JPG)
  - [Plaza_Mayor._Albarracín.jpg](https://commons.wikimedia.org/wiki/File:Plaza_Mayor._Albarrac%C3%ADn.jpg)
  - [Torre_de_la_iglesia_de_Santiago,_Albarracín_-_04.jpg](https://commons.wikimedia.org/wiki/File:Torre_de_la_iglesia_de_Santiago,_Albarrac%C3%ADn_-_04.jpg)
- **Detalles y/o props**:
  - [Albarracín_-_Escuelas_Pías_-_Portadda_iglesia.jpg](https://commons.wikimedia.org/wiki/File:Albarrac%C3%ADn_-_Escuelas_P%C3%ADas_-_Portadda_iglesia.jpg)
- **Elementos de inspiracion y estilo de referencia**:
  - Estos elementos están sacados de las páginas de steam del juego. No se listarán aquí
- **Referencias de iluminación**:
  - En este caso, de referencias de iluminación se utilizarán las del entorno general, por lo que esa carpeta no se subirá al repositorio.

## Historia

En esta sección se ampliará lo descrito brevemente en otros apartados. Este caso, se ha utilizado una breve guía estructurada para facilitar el entendimiento.

Nota: en esta sección admito que se me ha ido un poco en lo relativo a como escribirlo, es casi más una especie de relato en primera persona, pero sigue valiendo para el propósito de la documentación.

## Definición de la Historia

### Timeline

1. Comienzo del nivel, en la puerta del hogar del avatar de juego.
2. Camino a izquierda y derecha, se podrá tomar cualquiera ya que ambos llegarán a la plaza del pueblo.
   1. Si se va a la izquierda, se verá la iglesia, con un cartel en la puerta que indica que no hay párroco.
   2. Si se va a la derecha, se verán multitud de casas tapiadas.
3. En la plaza del pueblo, se guiará a las personas que jueguen de manera que recorran la plaza en el siguiente orden:
   1. Bar del pueblo, con la puerta abierta (se puede pasar). La única puerta abierta del pueblo.
   2. Puerta del ayuntamiento.
   3. Centro de la plaza, con un banco para sentarse. Al pulsar sobre el banco el tiempo pasará. Se ejecutará una animación que oscurecerá el cielo y será hora de volver a casa.
4. Vuelta a casa, preferiblemente por el camino no visto a la ida.
5. Llegada a la casa, puerta entreabierta.

### ¿Quién habita este lugar?

Poca gente, en general. Nada más que unas pocas personas en edad avanzada. Se podría asumir que no hay nadie en el pueblo que viva y todavía no se haya jubilado. Es un lugar en proceso de desaparición, ya que no quedará nadie que viva en él una vez las pocas personas que todavía quedan mueran de viejas.

### ¿Qué hacen cada día?

Poco. Dar paseos, escuchar la radio y leer. Tal vez lean el periódico que se reparte en el último bar del pueblo, que gestionan entre todas las personas que quedan, para tener un lugar en el que hablar. La hija del Mariano, en paz descanse, es la que se encarga de ir trayendo cada semana lo que se consume, además de hacer la compra para para las 5 personas que quedan en el pueblo. A veces trae comida ya preparada.

### ¿Qué ha cambiado recientemente el lugar?

Nada, el pueblo sigue exactamente igual que hace 50 años. Nada ha cambiado en su forma. Salvo que en los últimos años empieza a haber una cantidad alarmate de casas con las ventanas tapiadas con ladrillos, para que no se cuele gente.

### ¿Qué es lo más relevante que ha ocurrido antes del comienzo del nivel?

Mariano falleció el día anterior. No sabemos si su hija seguirá trayendo comida cada semana o si tendremos que irnos del pueblo. Tal vez estos paseos sean los últimos que de antes de que tengamos que irnos a alguna residencia a morir en un lugar que no conocemos.

## Objetivo del nivel

En esta sección se escribirá todo lo necesario para que cualquier persona sepa de qué va a ir el nivel y qué elementos habrá que recoger, o acciones ejecutar.

### Definición del objetivo del nivel

- El nivel acabará donde empezó: en la puerta del hogar del anciano.
- El requisito para la finalización será el uso del banco de la plaza, para que pase el tiempo.
- El estado de fin de nivel dejará al jugador ante la puerta, tendiendo marcado el booleano de que ha activado la animación del centro de la plaza.
- Al no haber otros niveles, la persona que juegue no podrá llevarse información, coleccionables o elementos de una escena a otra.
- No habrá ningún tipo de obstáculo en este nivel que bloquee el avance de manera total (muerte, derrota).
- Habrá algunas zonas con "baches" o desniveles que el avatar de juego no podrá subir debido a su condición física.

## Puntos de interés

En esta sección se colocarán todos los elementos visualmente relevantes que tendrán que estar en el nivel para facilitar la orientación de las personas que jueguen.

### Listado de puntos de interés

- Vivienda del avatar de juego.
- Iglesia (se verá por encima de las casas).
- Casas tapiadas.
- Bar del pueblo.
- Plaza del pueblo.
- Ayuntamiento.
- Banco en el que sentarse.

### Navegación entre los puntos de interés

Esta sección se completará en las próximas semanas, cuando se vea el tema teórico relativo a este punto.

## Mapeado

El mapa estará en una carpeta adjunta, con todos los borradores ordenados por nombre y versión del mapa.
