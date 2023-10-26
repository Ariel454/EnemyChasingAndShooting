# EnemyChasingAndShooting
Descripción
Este proyecto te permite controlar un enemigo que persigue y dispara al jugador. Aprenderás a configurar un mini mapa con obstáculos, a crear un enemigo que usa un NavMesh para seguir al jugador y dispararle. Además, implementarás una barra de vida y mostrarás mensajes de "Game Over" cuando el jugador se quede sin vida.

Requisitos
Unity 2022.3.10 o posterior
Configuración del Entorno
Crea un plano en la escena y coloca los assets necesarios, incluyendo un robot, el "First Person Controller" y las texturas.

Agrega texturas y crea muros y obstáculos en el terreno para formar un mini mapa. Posiciona el "First Person Controller" y el robot en el escenario.

Implementa el paquete "AI Navigation" desde el Package Manager de Unity para habilitar la funcionalidad de NavMesh.

Agrega un componente NavMeshAgent al enemigo para configurar sus propiedades, como la velocidad a la que perseguirá al jugador.

Asegúrate de que todos los elementos, incluyendo los muros y personajes, estén dentro del plano. Luego, realiza un bake en el NavMesh para generar la navegación.

Crea un prefab de la bala configurando una esfera con un Rigidbody y etiquetándola como "Bala" para su control mediante script.

Coloca un GameObject dentro del robot para determinar el punto de origen de las balas y así configurar un punto de disparo.

Agrega un script al robot llamado "CuboPerseguidor" para permitirle perseguir y disparar al jugador.

Funcionalidad del Robot
El robot usa un componente NavMeshAgent para seguir al jugador sin colisionar con obstáculos.

Dispara balas en dirección al jugador a intervalos regulares.

Creación de la Barra de Vida
En el Canvas, agrega una imagen que represente la barra de vida. Ajusta sus dimensiones según sea necesario.

Agrega una imagen secundaria que se ajuste dentro de la primera, sin tocar los bordes.

Descarga una imagen blanca y conviértela en un Sprite en la propiedad de textura de la imagen. Asigna este Sprite a la barra de vida.

Modifica el color de la barra de vida según tus preferencias.

Configura la imagen para que sea de tipo "Filled" y el método sea "Horizontal" para lograr un efecto de reducción horizontal de la barra de vida.

Control de Daño y "Game Over"
Utiliza el evento OnCollisionEnter para detectar colisiones con las balas y llama a la función "RecibirDanio()" cuando el jugador recibe daño.

La función "RecibirDanio()" reduce la vida del jugador y actualiza la barra de vida. Si la vida llega a cero, muestra un mensaje de "Game Over".

Textos
Agrega dos TextMeshPro (TMP) en el Canvas, uno para mostrar la vida restante y otro para mostrar un mensaje de "Game Over".

Posiciona el mensaje de "Game Over" dentro de un GameObject para controlar su visibilidad.

Asigna etiquetas a ambos textos.

Utiliza la función "MostrarTextoGameOver()" para activar el mensaje de "Game Over" y pausar el juego cuando el jugador se queda sin vida.

¡Ahora estás listo para jugar y explorar el comportamiento de tu enemigo persigue y dispara!
