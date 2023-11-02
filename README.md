# EnemyChasingAndShooting
Descripción
Este proyecto te permite controlar un enemigo que persigue y dispara al jugador. Aprenderás a configurar un mini mapa con obstáculos, a crear un enemigo que usa un NavMesh para seguir al jugador y dispararle. Además, implementarás una barra de vida y mostrarás mensajes de "Game Over" cuando el jugador se quede sin vida.

Requisitos
Unity 2022.3.10 o posterior
Configuración del Entorno
Crea un plano en la escena y coloca los assets necesarios, incluyendo un robot, el "First Person Controller" y las texturas.
![image](https://github.com/Ariel454/EnemyChasingAndShooting/assets/121766763/214ddcb5-e956-48fb-a9fd-0de34aa33ac0)

Agrega texturas y crea muros y obstáculos en el terreno para formar un mini mapa. Posiciona el "First Person Controller" y el robot en el escenario.
![image](https://github.com/Ariel454/EnemyChasingAndShooting/assets/121766763/050103d8-9368-486d-90dc-0b734f418649)

Implementa el paquete "AI Navigation" desde el Package Manager de Unity para habilitar la funcionalidad de NavMesh.
![image](https://github.com/Ariel454/EnemyChasingAndShooting/assets/121766763/9107eb86-5103-46fc-ace7-426a2a2eb8d0)

Agrega un componente NavMeshAgent al enemigo para configurar sus propiedades, como la velocidad a la que perseguirá al jugador.
![image](https://github.com/Ariel454/EnemyChasingAndShooting/assets/121766763/cd0153b2-5e12-4f1d-8d30-157c07051824)

Asegúrate de que todos los elementos, incluyendo los muros y personajes, estén dentro del plano. Luego, realiza un bake en el NavMesh para generar la navegación.
![image](https://github.com/Ariel454/EnemyChasingAndShooting/assets/121766763/82d71e81-8dc9-4e63-bee9-e2d1ab804f44)

Crea un prefab de la bala configurando una esfera con un Rigidbody y etiquetándola como "Bala" para su control mediante script.
![image](https://github.com/Ariel454/EnemyChasingAndShooting/assets/121766763/dfca9bbe-2025-4fca-b8ca-d978b7c1d5c6)

Coloca un GameObject dentro del robot para determinar el punto de origen de las balas y así configurar un punto de disparo.
![image](https://github.com/Ariel454/EnemyChasingAndShooting/assets/121766763/d1c9c342-e36c-4e0b-84f1-4be8236c7c66)

Agrega un script al robot llamado "CuboPerseguidor" para permitirle perseguir y disparar al jugador.
![image](https://github.com/Ariel454/EnemyChasingAndShooting/assets/121766763/7baf1f85-1533-43ae-8d46-3b7dd8f5169a)

Funcionalidad del Robot
El robot usa un componente NavMeshAgent para seguir al jugador sin colisionar con obstáculos.

Dispara balas en dirección al jugador a intervalos regulares.
![image](https://github.com/Ariel454/EnemyChasingAndShooting/assets/121766763/0493495a-0588-4b00-8789-aed2463dc726)

Creación de la Barra de Vida
En el Canvas, agrega una imagen que represente la barra de vida. Ajusta sus dimensiones según sea necesario.
![image](https://github.com/Ariel454/EnemyChasingAndShooting/assets/121766763/22e69e42-9508-4982-980c-ad56e8205538)

Agrega una imagen secundaria que se ajuste dentro de la primera, sin tocar los bordes.
![image](https://github.com/Ariel454/EnemyChasingAndShooting/assets/121766763/2638b8ec-188d-4d46-9974-ef432faaac9c)

Descarga una imagen blanca y conviértela en un Sprite en la propiedad de textura de la imagen. Asigna este Sprite a la barra de vida.

Modifica el color de la barra de vida según tus preferencias.
![image](https://github.com/Ariel454/EnemyChasingAndShooting/assets/121766763/eee29231-eadb-4ebf-8479-2c1d37046333)

Configura la imagen para que sea de tipo "Filled" y el método sea "Horizontal" para lograr un efecto de reducción horizontal de la barra de vida.

Control de Daño y "Game Over"
Utiliza el evento OnCollisionEnter para detectar colisiones con las balas y llama a la función "RecibirDanio()" cuando el jugador recibe daño.

La función "RecibirDanio()" reduce la vida del jugador y actualiza la barra de vida. Si la vida llega a cero, muestra un mensaje de "Game Over".

Textos
Agrega dos TextMeshPro (TMP) en el Canvas, uno para mostrar la vida restante y otro para mostrar un mensaje de "Game Over".

Posiciona el mensaje de "Game Over" dentro de un GameObject para controlar su visibilidad.
![image](https://github.com/Ariel454/EnemyChasingAndShooting/assets/121766763/01e04657-0f02-4592-9aa6-1c79b5b13bd5)

Asigna etiquetas a ambos textos.

Utiliza la función "MostrarTextoGameOver()" para activar el mensaje de "Game Over" y pausar el juego cuando el jugador se queda sin vida.

¡Ahora estás listo para jugar y explorar el comportamiento de tu enemigo persigue y dispara!
