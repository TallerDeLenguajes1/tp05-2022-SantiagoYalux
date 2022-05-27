#tp 

EJERCICIO 4 
*¿String es una tipo por valor o un tipo por referencia?
Referencia

*¿Qué secuencias de escape tiene el tipo string?
\ '- comilla simple 
\ "- comillas dobles
\\ - barra invertida 
\ 0 - nulo 
\ a - alerta 
\ b - retroceso 
\ f - alimentación de formulario 
\ n - nueva línea 
\ r - retorno de carro 
\ t - pestaña horizontal 
\ v - pestaña vertical 
\ u0000 - \ uFFFF - Carácter Unicode
\ x0 - \ xFFFF - Carácter Unicode (código con longitud variable)
\ U00000000 - \ U0010FFFF - Carácter Unicode (para generar sustitutos)

*¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

$"hola, {nombre}" = Quiere decir que es una cadena interpolada.
La interpolación de cadenas significa que puedes utilizar dentro de la misma variables definidas con anterioridad en tu código, y el compilador se encargará de reemplazar las mismas por los valores respectivos, en tiempo de ejecución.

@ = Significa interpretar la cadena literalmente (es decir, no puede escapar ningún carácter dentro de la cadena si usa el prefijo @). Mejora la legibilidad en los casos en que se puede utilizar.