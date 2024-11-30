# PrimerAvance_SOII
### Primer Avance del proyecto de gestion de memoria, este avance incluye el funcionamiento de el particionamiento fijo y dinamico.

## Iniciar el Programa:

- El programa comenzará pidiendo dos cosas al usuario:
- Tamaño de la memoria física: Este es el tamaño total de la memoria que el sistema va a simular. Lo puedes ingresar como un número entero, por ejemplo, 100 para indicar que la memoria tiene 100 unidades de espacio.
- Tipo de particionamiento: Aquí debes decidir si deseas usar particionamiento fijo o dinámico.
- Fijo: La memoria se dividirá en un número fijo de particiones de igual tamaño.
- Dinámico: La memoria se asignará de manera dinámica, agregando páginas en la memoria hasta que esté llena.

## Realizar las operaciones para acceder a las paginas

Cada vez que el usuario elija acceso, se pedirá lo siguiente:
- Número de página virtual: Este es el identificador de la página a la que se quiere acceder. Por ejemplo, ingresar 1 para la página número 1.
- Escribir o leer: El programa preguntará si es una operación de escritura o lectura. Si se elige "si", se tratará de una escritura; si eliges "no", será una lectura.

  ## Funcionamiento Interno
- El programa verificará si la página solicitada ya está en la memoria.
- Si la página no está en memoria, se produce un fallo de página, lo que significa
que se debe agregar la página a la memoria.
- El número de fallos de página aumentará en este caso.
- Si la página ya está en memoria, no se produce un fallo de página y el programa
simplemente devuelve la dirección física correspondiente.

## Proceso Final

Cuando se finalicen las operaciones de acceso a páginas, se escribe "fin" para
terminar el programa y mostrará el número total de fallos de página.

##Simulador de Gestión de Memoria en C#
Este proyecto es un simulador de gestión de memoria desarrollado en C# con Windows Forms. El simulador permite visualizar y experimentar con diferentes técnicas de gestión de memoria utilizadas en sistemas operativos, tales como particionamiento fijo, particionamiento dinámico, memoria virtual, segmentación y paginación.

##Funcionalidades
###1. Particionamiento Fijo
Simula la asignación de procesos a particiones de tamaño fijo.
Se pueden definir particiones con tamaños específicos y asignarles procesos de tamaños determinados.
Muestra el estado de las particiones (ocupadas o libres) y el espacio restante.
###2. Particionamiento Dinámico
Simula el particionamiento dinámico donde las particiones se asignan de manera flexible según el tamaño de los procesos.
El sistema verifica la disponibilidad de memoria para cada proceso antes de asignarlo.
Visualiza el estado de la memoria dinámica, mostrando bloques libres y ocupados.
###3. Memoria Virtual
Simula la gestión de memoria virtual, permitiendo la visualización de cómo se manejan las páginas de memoria y cómo se asignan procesos a la memoria virtual disponible.
El sistema simula la carga de procesos y la visualización de la memoria disponible en un entorno virtual.
###4. Segmentación
Implementa la segmentación, donde la memoria se divide en segmentos lógicos (por ejemplo, código, datos, pila).
Los segmentos pueden ser de diferentes tamaños, y el sistema asigna espacio de acuerdo con las necesidades de los procesos.
Visualiza el estado de los segmentos, indicándolos como disponibles u ocupados.
###5. Paginación
Implementa paginación de memoria, donde la memoria se divide en páginas fijas.
Permite la visualización de la asignación de páginas a procesos.
Soporta navegación entre las páginas para ver cómo se distribuyen los procesos en la memoria.
##Tecnologías Utilizadas
Lenguaje: C#
Framework: .NET Framework
Entorno de Desarrollo: Visual Studio
Interfaz de Usuario: Windows Forms
