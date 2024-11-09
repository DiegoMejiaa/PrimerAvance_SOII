# PrimerAvance_SOII
### Primer Avance del proyecto de gestion de memoria, este avance incluye el funcionamiento de el particionamiento fijo y dinamico.

## Iniciar el Programa:

- El programa comenzará pidiendo dos cosas al usuario:
- Tamaño de la memoria física: Este es el tamaño total de la memoria que el sistema va a simular. Lo puedes ingresar como un número entero, por ejemplo, 100 para indicar que la memoria tiene 100 unidades de espacio.
-Tipo de particionamiento: Aquí debes decidir si deseas usar particionamiento fijo o dinámico.
-Fijo: La memoria se dividirá en un número fijo de particiones de igual tamaño.
-Dinámico: La memoria se asignará de manera dinámica, agregando páginas en la memoria hasta que esté llena.

## Realizar las operaciones para acceder a las paginas

Cada vez que el usuario elija acceso, se pedirá lo siguiente:
- Número de página virtual: Este es el identificador de la página a la que quieres acceder. Por ejemplo, puedes ingresar 1 para la página número 1.
- Escribir o leer: El programa preguntará si es una operación de escritura o lectura. Si eliges "si", se tratará de una escritura; si eliges "no", será una lectura.

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
