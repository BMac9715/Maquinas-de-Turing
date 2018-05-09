
# Simulador de máquinas de Turing.

## Descripcion

**Maquinas de Turing**
Si lo vemos desde su raíz, una máquina de Turing es en realidad un modelo matemático que consiste en un autómata que es capaz 
de “implementar cualquier problema matemático expresado a través de un algoritmo”. 
A pesar de esta definición tan complicada, en realidad la máquina de Turing destaca por su simplicidad 
pues manipula símbolos sobre una tira de cinta siguiendo una serie de reglas. A pesar de esta simplicidad, 
una máquina de Turing puede adaptarse para que simule la lógica de cualquier algoritmo de computador, 
de ahí su enorme potencial y valor.

Como su propio nombre indica, la máquina de Turing fue creada por el matemático inglés Alan Turing, 
un genio en muchos campos pero especialmente en la criptografía y la lógica. 

Una Máquina de Turing consta de una cinta infinita dividida en espacios de trabajo o celdas yuxtapuestas que actúa como memoria, 
un cabezal capaz de leer y escribir símbolos en la cinta y moverla de celda en celda a derecha e izquierda, un registro de estado, 
y una tabla finita de instrucciones o tabla de acción.

La máquina de Turing es considerada un autómata con la capacidad de reconocer lenguajes formales de acuerdo a la jerarquía de Chomsky, 
razón por la cual es muy superior a otros autómatas como el autómata con pila o el autómata finito.

## Acerca del proyecto

El proyecto consistia en construir un software que fuera capaz de simular el funcionamiento de varias máquinas de Turing, estas
máquinas son:
1. Reconocedor de cadenas palíndromas.
2. Copia de patrones.
3. Multiplicación en código unario.
4. Suma en código unario.
5. Resta en código unario.

Básicamente este proyecto se dividió en dos fases, la primera fase consistía en construir la definción de las máquinas de 
turing en papel (diagramas de transición, tablas de transición, etc) para luego en la segunda fase hacer la implementación
de estas máquinas sobre un lenguaje de programación, que en mi caso el lenguaje escogidó fue C# de .Net.

## Requerimientos del software

No existe uno en especifico.

## ¿Comó utilizar el software?

El algoritmo que describe el funcionamiento del software es el siguiente:
 1. Ejecutar la aplicación.
 2. Elegir la máquina de Turing a probar.
 3. Ingresar una cádena de entrada.
 4. Ejecución paso a paso o completo del funcionamiento de la máquina de Turing elegida.
 4. Resultado de la ejecución.
 
### Ejecutar la aplicación

#### Clickeando sobre el Ejecutable
	
Una vez posea la carpeta del proyecto dirigase a la carpeta _Simulador Maquinas de Turing_, una vez este dentro
de esta carpeta dirigase a la carpeta _bin_, luego a la carpeta _Debug_ y dentro de está encontrará un archivo 
llamado _Simulador Maquinas de Turing.exe_.

![Archivo Ejecutable](https://image.ibb.co/cnmmg7/Debug.jpg)

Una vez tenga ubicado este archivo, presione doble click en esté y el programa se inicializará.

La ruta relativa del archivo ejecutable es:
```
\Maquinas-de-Turing\Simulador Maquinas de Turing\Simulador Maquinas de Turing\bin\Debug
```

### Funcionamiento del programa

Una vez iniciada la aplicación, se mostrará la siguiente pantalla:

![MainWindow](https://image.ibb.co/i4Sv8n/Simulador_Maquinas_de_Turing.jpg)

Nos presenta una simple y agradable interfaz para que el uso de la aplicación no requiera de 
mucho tiempo y esfuerzo. Podemos dividirla en 3 secciones: _Selección_, _Entrada y control_ y _Salida_.

#### Selección

![Selección](https://image.ibb.co/n9NsM7/Simulador_Maquinas_de_Turing_2.jpg)

En esta sección, el usuario debe escoger la máquina que desea probar de las 5 opciones que tiene 
disponible el software. No puedo elegir 2 máquinas al mismo tiempo, por esto no hay que preocuparse
pues el programa se encarga de este tipo de validaciones. Al lado derecho de esta sección, se encuentra
un cuadro de descripción que provee información y caracteristicas a cerca de las máquinas disponibles.

#### Entrada y Control

![Entrada-Control](https://image.ibb.co/gXicon/Simulador_Maquinas_de_Turing_3.jpg)

En esta sección, el usuario ingresará la cadena que desee para probar el funcionamiento de la máquina
seleccionada, al momento de pulsar el boton _Cargar Cadena_ estará dando inicio a la ejecución de la 
máquina. 
El programa le presenta 2 opciones para poder ejecutar la máquina: Paso a paso o automaticamente; en 
ambos casos el usuario apresiará la animación de lo que esta sucediendo en la cinta, el estado en el que 
se encuentra la máquina, etc.

Una vez acabada la ejecución, deberá presionar el boton _Reset_ para poder realizar otra ejecución con la 
máquina que el usuario desee.

#### Salidas

![Salida](https://image.ibb.co/bz9NM7/Simulador_Maquinas_de_Turing_4.jpg)

En esta sección solamente se reporta, el estado en el cual terminó le ejecución, la cantidad de pasos que 
fueron necesarios para la ejecución y si la cadena fue o no aceptada por la máquina.

Se presenta un ejemplo de una cadena que no es palindrome, analizada por la máquina que comprueba esto.

![Palindromo](https://image.ibb.co/bDsTTn/Error.jpg)

## Opinion del Autor

Pienso que este proyecto ayudo bastante a aclarar dudas de como funciona una máquina de Turing, experimentar
o idearse las maneras de representar las maquinas en un lenguaje de programación hace que valga la pena 
tanto trabajo. Pienso que mi programa funciona correctamente ya que despues de varias pruebas con las diferentes
máquinas el resultado fue el correcto, y ademas la aplicación no sufrió de errores internos mientras se 
realizarón las pruebas, eso da un poco más de fiabilidad al software. Ademas toda la lógica de las máquinas de
Turing fue planteada desde la idea abstracta, pasar por el diseño de los diagramas de transciones y ademas comprobar
el funcionamiento correcto te estos diseños con simuladores ya implementados, hacen que piense que el programa
funciona correctamente y probablemente existan errores que se hayan mal interpretado de mi parte.

## Información del Autor
	
**Bryan Macario Coronado**

_Estudiante de ingeniería en informática y sistemas_

_Universidad Rafael Landivar_

