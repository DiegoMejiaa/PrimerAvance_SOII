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
1. Iniciar el Programa:
Al ejecutar el programa, el usuario verá 5 opciones de gestión de memoria en la interfaz principal:

Fijo: Particionamiento de memoria fijo.
Dinámico: Particionamiento de memoria dinámico.
Segmentación: Gestión de memoria basada en segmentos lógicos.
Memoria Virtual: Simulación de memoria virtual.
Paginación: Gestión de memoria basada en páginas.
Al seleccionar una de las opciones, el sistema guiará al usuario a través del proceso de simulación correspondiente.

2. Tamaño de la Memoria Física:
El programa solicitará ingresar el tamaño total de la memoria que el sistema va a simular. Por ejemplo, si se ingresa 100, la memoria tendrá 100 unidades de espacio.

3. Tipo de Particionamiento:
Dependiendo de la opción seleccionada (fijo, dinámico, segmentación, memoria virtual, paginación), el sistema se comportará de acuerdo a la técnica de gestión de memoria elegida.

4. Acceso a las Páginas:
Cuando el usuario elija acceder a las páginas, se le pedirá:

Número de página virtual: El identificador de la página que se desea acceder (por ejemplo, página 1).
Escribir o Leer: El usuario indicará si se trata de una operación de escritura o lectura.
5. Funcionamiento Interno:
El sistema verifica si la página solicitada ya está en memoria.
Si la página no está en memoria, se produce un fallo de página, lo que implica que la página debe cargarse en la memoria, aumentando el contador de fallos de página.
Si la página ya está en memoria, el sistema simplemente devuelve la dirección física correspondiente sin generar un fallo de página.

Tecnologías Utilizadas
Lenguaje: C#
Framework: .NET Framework
Entorno de Desarrollo: Visual Studio
Interfaz de Usuario: Windows Forms
