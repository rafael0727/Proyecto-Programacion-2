# REGISTRO TEMPORAL DE LOS POKEMONES

Este es un trabajo estudiantil, creado en el lenguaje de programacion c# el cual consiste en el registro de Pokemones que se almacena por un tiempo los datos ingresados como son el nombre del pokemon, su tipo, su numero en la pokedex, el codigo y su entrenador. En el instante de registrar los datos estos se creara una tabla y un grafico el cual esta implementado por un Dll graficador.

La tabla guardara cada uno de los nombres de los diferentes pokemones diligenciados, y dira si este se encuentra activo o no. Tambien hay un boton en donde su lo pulsamos nos abrira todos los datos que hayan sido introducidos y sean referentes a ese pokemon y nos dara la opcion de modificarlo como queramos.

Cuanto a la grafica que se creara, esta nos mostrara un grafico entre la relacion de los diferentes nombre de los pokemones y su codigo pokemon. En caso de que se cambie el nombre tambien lo hara la grafica, ya que todo esta realizado con el mismo graficador.

### Como instalar el proyecto

con visual jeje

### Funcionamiento del programa
##### Agregar y listar pokemones

El usuario podra agregar pokemones a como de gusto, para eso tendra que ingresar el nombre del pokemon, el tipo, el numero de pokedex, codigo del pokemon y el entrenador.
 
![Ingreso-datos (1)](https://user-images.githubusercontent.com/61460280/81875779-ae22ff80-9546-11ea-8ecd-3956fa7523ab.gif)

 
 #### Graficador del nombre del pokemon y de su numero
 
 A la hora de ingresar un pokemon también se creará una gráfica. Esta grafica nos mostrara dos datos, el nombre del pokemon y su numero. Cada pokemon agregado se colocora en la gráfica una junto a otra para así poder comparar los nombres y los numeros. Por otro lado en la grafica habrá un botón de nombre “etiqueta”, el cual sirve para esconder o visualizar el numero del pokemon.
 
![Grafica](https://user-images.githubusercontent.com/61460280/81875970-30abbf00-9547-11ea-85eb-656967d65995.gif)

 
#### Cambiar el idioma del Software 

Otra de las funciones que tiene este software, es que puede cambiar de idiomas. Para cambiar el idioma tiene que ir a la parte de abajo a la derecha donde dice "Idioma", en este se desplegará una lista con unos idiomas ya establecidos en el software y que al momento de elegir uno, todo el programa se cambiará automáticamente a ese idioma.
Los idiomas establecidos son:
* español (principal)
* ingles
* frances

![cambio-idioma](https://user-images.githubusercontent.com/61460280/81876189-ae6fca80-9547-11ea-812d-031a4ec0418c.gif)


![cambio-idioma2](https://user-images.githubusercontent.com/61460280/81876234-c9423f00-9547-11ea-8d85-e3663f37d89b.gif)


#### Cambiar el color al fondo de la grafica

Así mismo otra funcionalidad del software, es el poder configurarlo al gusto del usuario el color de la grafica, es decir, cambiara el color de todo el fondo de la grafica dependiendo del escogido por el usuario. Próximamente se implementarán más opciones de configuración.

![cambio-color](https://user-images.githubusercontent.com/61460280/81876396-2a6a1280-9548-11ea-9ae6-6d2c489c7100.gif)

### Sobre los DLL
#### DLL graficador

El siguiente DLL que esta implementado es un graficador, el cual posee un montón de funcionalidades en cuanto a realizar graficas. En nuestro software, este es el encargado de crearnos gráficamente las barras correspondientes al nombre de los pokemones con su numero de registro, y compararlas con las demás que hayan sido ingresados. En cuanto a la lógica que utiliza, es que, al momento de ingresar una nueva película, el Dll se encargara de tomar los datos del nombre de esta y su duración, los ubicara en posiciones "X" y "Y", donde el Eje X hace referencia al nombre del pokemon y el Y a el numero de registro. Realizara este proceso con todas las listas que tengamos actualmente en nuestro programa.

![Grafica2](https://user-images.githubusercontent.com/61460280/81877089-d6f8c400-9549-11ea-8507-7426458a2774.gif)


## Autores
##### Rafael Ballesteros Acero
##### Nicolas Barba Villamizar


