Una vez tengamos instalado Unity con su Editor actualizado más el Rider para los scripts en C, procedemos a crear un nuevo proyecto(New Project).
En templates seleccionamos 3D Core. Asignamos un nombre al proyecto, y seleccionamos la ruta en donde vamos a guardarlo. Click en Create Project.
Se nos abre una nueva escena para este nuevo proyecto, y su archivo correspondiente está guardado en la carpeta Scenes. En esta escena que nos muestra por defecto, aparecen dos elementos: la cámara y una luz direccional.

Primero antes de empezar necesito instalar el paquete Input System. Para ello click en Window / Package Manager. Escribo el nombre del paquete en el buscador para que me lo localice. Una vez que me aparezca hago click en Install.

Una vez que tenemos instalado el InputSystem, vamos a añadir un nuevo elemento a nuestra escena, que será un 3D Object de tipo Sphere. A este objeto le llamaremos Player. Hago click sobre él, y en la parte derecha se nos muestra un panel con las distintas características y parámetros para dicho objeto, los cuáles podremos configurar a nuestro gusto. A este Player (la bolita) le voy a añadir más componentes a través del Inspector. Hago click en Add Component, y selecciono Input Player. Luego de nuevo Add Component, selecciono New Script y lo llamaré PlayerController.cs. Se nos crea el archivo en la carpeta Assets. Procedo a crear una nueva carpeta llamada Scripts (dentro de Assets). Muevo el PlayerController.cs a dentro de la carpeta Scripts. Luego de nuevo click en Add Component, y selecciono Rigidbody (que será la manera de identoficar a mi objeto Player dentro del script PlayerController.cs).

Ahora creo un nuevo elemento para la escena, será un 3D Object de tipo Plane. Le llamaré Ground. Voy al inspector y en escale X-Y-Z asigno como valores 2-1-2.
Ahora también quiero darle nuevos colores a mis objetos Player y Ground. Eso se hace creando nuevos Materiales o Materials. Primero, dentro de Assets crearé una nueva carpeta llamada Materials. Luego hago click en new Material, le llamaré Player (ya que lo voy a asociar a mi objeto Player). En el Inspector, voy a Base Map y ahí podré seleccionar el color para el material. Una vez que lo tengo configurado, lo arrastro con la flecha a mi objeto Player, y listo. Podemos observar como Player ahora está formado por este nuevo material que he creado, y ahora tiene el mismo color que dicho material.

Después crearé un nuevo material para mi objeto Ground. A este material también lo llamo Ground (siempre mejor llamar a los materiales igual que a los objetos a los que los queremos asociar, para así evitar confusiones). De nuevo en BaseMap selecciono el color que quiero para mi Ground. Una vez que ya haya seleccionado el color y el material esté ya listo, lo arrastro con la flecha hasta mi objeto Ground, y listo, vemos como el objeto Ground ha cambiado a este nuevo material, adoptando el color del mismo.

Para esto sirven los materiales, ayudan a personalizar nuestros objetos con los colores, brillo, etc. que queramos darles. Me aseguro de meter mis materiales Player y Ground dentro de la carpeta Materials. Importante tener todos los archivos y componentes bien organizados en carpetas, para evitar confusiones y no esté todo mezclado.
Pero lo qure va a dar funcionalidad a mis objetos serán los scripts asociados a dichos ojetos. En los códigos de los scripts, añadiré comentarios en las lineas de código más relevantes explicando las mismas.

Pero no me gusta que el objeto se mueva tan lento, así que voy a cambiar su velocidad. La velocidad se identifica con el parámetro speed, y se puede configurar directamente desde el Inspector del Object o bien en el script asociado a dicho Object. Tenía puesto speed = 1. Como quiero que se mueva más rápido, pondré speed = 10.
Pero hay otro detalle que se aprecia al correr la escena y que debemos corregir, y es que la cámara no sigue al Player durante su movimiento, por tanto llega un momento que éste desaparece de nuestra vista. Para cambiar esto, en Unity hacemos click sobre la Cámara, luego vamos al Inspector de la misma, buscamos la parte donde se encuentra nuestro script (que es CameraController.cs) y justo debajo, donde pone Player vemos que por defecto aparece None(Game Object).

![Captura de pantalla (131)](https://user-images.githubusercontent.com/32130215/220363751-50b0ff1a-805b-4062-9599-ab8405062d80.png)



Hago click derecho y veo que aparece la lista con los obetos de la escena, y selecciono Player (que representa la bolita que se mueve).

![Captura de pantalla (132)](https://user-images.githubusercontent.com/32130215/220363850-fa1a4eb4-bc04-4475-97f2-2a32791a594b.png)




Guardo los cambios y vuelvo a correr la escena. Ésta vez sí, la cámara seguirá el movimiento del Player en todo momento, así que éste nunca escapará de nuestra vista.


Además, en el script para el Player (PlayerController.cs) he añadido un método para gestionar las interacciones que pueda tener el Player con otros objetos que se encuentran en mi escena, y qué comportamiento adoptará el Player cuando se produzcan dichas interacciones. Dicho comportamiento variará en función del tag que tenga el objeto con el que colisiona. Por ejemplo, si choca con un objeto de tag "Destroy" el Player destruirá dicho objeto, o si choca con objeto de tag "Teleport" entonces automáticamente se teletransportará a otra ubicación distinta de mi escena, etc, etc. 
