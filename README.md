# PrototipoInterfacesInteligentes
Trabajo realizado por: 
Javier Alberto Martín,
Daniel Rodríguez Suárez,
Miguel Jiménez Gomis.

## Introducción: presentación del juego

## Mecánicas
Las mecánicas que se eligieron para ese juego son sencillas, ya que se escogieron para intentar minimizar la disonancia ludonarrativa \[1] en el gameplay del mismo.
* Para mover al personaje se usa la vista. Si se mira hacia el suelo el personaje avanza hacia delante, mientras que en una posición normal permanece parado. El tener que mirar al suelo cumple dos objetivos, el de tener una interfaz de control sencilla que no requiera de dispositivos externos ,como puede ser un mando o similar, y el de contribuir a la atmosfera de miedo pues el hecho de no ver con claridad lo que hay delante crea una reaccion de desconcierto. 

* Para finalizar el juego, el jugador deberá encontrar las diferentes llaves que están escondidas a lo largo del mapa del juego. Una vez el jugador se encuentra con una llave tiene que mirarla para recogerla y tenerla en su inventario. Como esta mecánica no se explica de manera explicita en ningún punto del juego se ha puesto una llave delante del usuario nada mas empezar la partida, para que le sirva de tutorial y sea obvio lo que tiene que hacer para ganar.

## Assets utilizados

## Hitos logrados (dificultades que se logró resolver)
* 1.Creación del mapa
      1.1.Plano
          El plano se realizó a mano para posteriormente sacarle una foto y pasarlo al Unity. Se escaló convenientemente y se levantaron todos los muros a base de cubos básicos.
      1.2.Texturas
          Se realizó un script para aplicar la textura de ladrillos a todos los cubos.
      1.3.Decoración
          A medida que se necesitaban ciertos objetos o elementos se iban buscando en el Asset Store.


## Aspectos a destacar (complejidades que se añadieron)
* Se añadieron unas IAs al entorno del juego utilizando la plataforma para IA de Unity, con su librería y los assets de Mesh Agent \[4], con esto se consiguió que los agentes navegaran por el entorno de manera aleatoria sin chocarse con nada y sin tener que hacer a mano unos scripts de colisiones o similares que habrían añadido mucha complejidad.
* Una vez hecha toda la estructura de la mazmorra, compuesta por más de 100 muros, nos dimos cuenta que aplicarle las texturas a todos los muros sería una tarea muy laboriosa, así que unimos todos los muros en un GameObject vacío llamado "conjuntoMuros" e hicimos un script que recorriera los hijos de ese objeto y fuera aplicando las texturas a todos los muros. Por esto, las texturas se aplican siempre en el primer instante de ejecución.

## Aspectos relacionados con las recomendaciones para la interacción con VR que se hayan contemplado.
* Lo primero que hicimos para mejorar la interacción con la VR fué quitar el "cliping" con las paredes del juego. Eso que es molesto en un juego normal, en VR se puede volver dañino ya que al dar saltos entre un muro y la posición de detrás se contribuye a marear y desorientar al usuario \[2].

* El angulo en el que el jugador tiene que poner la cabeza para moverse se eligió teniendo en cuenta todas las recomendaciones de perspectiva de realidad virtual para que no fuera molesto ni al usuario ni a la jugabilidad.

* La velocidad a la que se mueve el personaje no es ni muy rapida ni muy lenta, ya que lo primero causaría mareo al estar en VR y o sentir aceleración y si movimiento, la segunda porque empeoraría la jugabilidad haciendo al juego aburrido \[3]. 

## Uso de chatbots
Si bien hemos hechos varias demos en clase asi como por nuestra cuenta para ver si podíamos integrarlo en el juego , al final decidimos desechar la idea ya que , no solo añade una capa de complejidad extra al juego sino que además, no aporta nada al gameplay. También cabe mencionar que los servicios de chatbots que se nos explicaron no sirven para android (ya que el sistema de reconocimiento de voz es solo nativo de windows) y el Google Dialogflow, aunque si funciona en android tambien, crea muchos problemas de conectividad  y ademas detiene la ejecución del juego cada vez que hace una petición al servidor a menos que se le dedique un hilo entero del juego para el solo, deoptimizando recursos y haciendo la APK final mas pesada.

## Uso de sensores.
El principal sensor que usamos en el juego a parte de los que ya vienen integrados de por si en los prefabs de la cámara de VR fue el giroscópio. Con él conseguimos establecer el ángulo de los cascos con respecto al suelo del nivel para realizar los movimientos del personaje, lo cual es la  mecánica mas importante del juego.

## Distribución de las tareas.
La idea del juego y mecanicas de este las decidimos entre todos durante no unos pocos días de debate.
El diseño de niveles y todo lo relacionado con la estética fué realizado por Javier 
La programación de las interacciones, agentes y demás mecánicas del juego fueron hechas por Daniel y Miguel
Si bien esta fue la distribución inicial, todos colaboramos en la depuración de errores de los otros y colaboramos en  la realización de las tareas mas tediosas.

## Referencias
* \[1] https://es.wikipedia.org/wiki/Disonancia_ludonarrativa
* \[2] https://developer.oculus.com/design/latest/concepts/bp-vision/
* \[3] https://developer.oculus.com/design/latest/concepts/bp-locomotion/
* \[4] https://unity3d.com/es/learn/tutorials/topics/navigation/navmesh-agent
