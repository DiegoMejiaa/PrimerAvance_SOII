# Proyecto_SOII
Descripción
Este proyecto es un simulador de gestión de memoria desarrollado en C# utilizando Windows Forms. El simulador permite visualizar y experimentar con diferentes técnicas de gestión de memoria empleadas en sistemas operativos. Las técnicas implementadas incluyen particionamiento fijo, particionamiento dinámico, memoria virtual, segmentación y paginación.

Funcionalidades
1. Particionamiento Fijo
Simula la asignación de procesos a particiones de tamaño fijo.
Permite definir particiones con tamaños específicos y asignarles procesos de tamaños determinados.
Muestra el estado de las particiones (ocupadas o libres) y el espacio restante en cada partición.
2. Particionamiento Dinámico
Simula el particionamiento dinámico, donde las particiones se asignan de manera flexible según el tamaño de los procesos.
El sistema verifica la disponibilidad de memoria antes de asignar cada proceso.
Visualiza el estado de la memoria dinámica, mostrando bloques libres y ocupados.
3. Memoria Virtual
Simula la gestión de memoria virtual, permitiendo la visualización de cómo se manejan las páginas de memoria y cómo se asignan procesos a la memoria virtual disponible.
El sistema simula la carga de procesos y la visualización de la memoria disponible en un entorno virtual.
4. Segmentación
Implementa la segmentación, donde la memoria se divide en segmentos lógicos (por ejemplo, código, datos, pila).
Los segmentos pueden ser de diferentes tamaños, y el sistema asigna espacio de acuerdo con las necesidades de los procesos.
Visualiza el estado de los segmentos, indicándolos como disponibles u ocupados.
5. Paginación
Implementa la paginación de memoria, donde la memoria se divide en páginas fijas.
Permite la visualización de la asignación de páginas a procesos.
Soporta la navegación entre las páginas para observar cómo se distribuyen los procesos en la memoria.
Instrucciones de Uso
Iniciar el Programa:

Al ejecutar el programa, se le pedirá al usuario ingresar:
Tamaño de la memoria física: Este es el tamaño total de la memoria que el sistema va a simular. Por ejemplo, si se ingresa 100, significa que la memoria tiene 100 unidades de espacio.
Tipo de particionamiento: El usuario podrá elegir entre particionamiento fijo o dinámico.
Fijo: La memoria se divide en un número fijo de particiones de igual tamaño.
Dinámico: La memoria se asigna de manera dinámica, agregando páginas en la memoria hasta que se llene.
Acceder a las Páginas:

Cuando se elija acceder a las páginas, el sistema pedirá:
Número de página virtual: Identificador de la página a la que se quiere acceder (por ejemplo, ingresar 1 para la página número 1).
Escribir o Leer: El usuario debe indicar si se trata de una operación de escritura o lectura.
Funcionamiento Interno:

El sistema verifica si la página solicitada ya está en memoria.
Si la página no está en memoria, se produce un fallo de página, lo que significa que la página debe cargarse en la memoria, aumentando el contador de fallos de página.
Si la página ya está en memoria, no se produce un fallo de página y el sistema devuelve la dirección física correspondiente.
Proceso Final:

Una vez que se hayan completado las operaciones de acceso a las páginas, el usuario puede escribir "fin" para terminar el programa y el sistema mostrará el número total de fallos de página ocurridos durante la ejecución.
Tecnologías Utilizadas
Lenguaje: C#
Framework: .NET Framework
Entorno de Desarrollo: Visual Studio
Interfaz de Usuario: Windows Forms
