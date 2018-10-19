# ExamenOO
Examen de Orientación a Objetos del curso de .NET

## 1. Modifica la siguiente clase para que cualquiera pueda crear una instancia de ella y si lo desea pueda recibir una notificación mediante un evento cuando cambie el nombre. Este evento notificará el valor anterior y el actual del nombre.
Se ha implementado una clase Bar que hereda de Foo para poder crear instancias y recibir un mensaje cuando se modifica el nombre del objeto.

## 2. Implementa el código necesario para crear una clase figura de la que heredan las siguientes clases: Rectángulo, Círculo, Flecha. Todas estas clases tienen una propiedad color que puede ser Rojo,Verde y Azul
Creo una clase Shape que implementa una interfaz IShape. La cual dispone de una propiedad color del tipo enumerado Color. Este tipo tiene como posibles valores: red, green y blue. Esta propiedad será común a la clase Shape y a las que hereden de ésta: Rectangle, Circle y Arrow.

## 3. Una vez creadas esas clases crea una lista de esas clases del tipo IShape que tiene un método Draw y que escriben por consola el color y lo que son Rectangulo, Circulo o Flecha. ¿Qué técnica de la orientación a objetos crees que estás utilizando?
Hemos utilizado polimorfismo para , ya que permitimos a las clases que heredan de Shape invalidar (sobrecargar) ciertos métodos de la clase padre mediante el modificador virtual. Esto nos permite realizar una implementación más específica y que se adecúe a las necesidades de cada clase hija.

## 4. Las clases creadas en el ejercicio 2 acceden a la tarjeta gráfica y por tanto tienen que liberar recursos. ¿Qué interfaz tienes que implementar y cómo puedes eliminar esos recursos?
Necesito implementar la interfaz IDisposable y su método Dispose(), mediante el cual puedo liberar recursos de forma automática.

## 5. Al crear varias interfaces en las clases del tipo Shape ¿Qué principio SOLID crees que estás cumpliendo o incumpliendo?
Cumplimos con el principio de segregación de la interfaz (I) de SOLID; que indica que es preferible utilizar varias interfaces cliente específicas a una sola interfaz de propósito general. Ya que los clientes de un programa sólo deben conocer aquellos métodos que realmente usan. Haciendo esto, una interfaz amplia y compleja se convierte en otras más pequeñas y específicas, de manera que el cliente sólo utiliza aquella que necesite, ignorando el resto.
