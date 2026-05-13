## Josue Enmanuel Poot Mateo
## Arquitectura de software
## 3B 
## Jorge Javier Pedroza Romero

# Actividad 2: Sistema de Gestión - Menú y Pedidos (JossPoot Ramen)

Este proyecto consiste en una aplicación web rediseñada para la gestión y clasificación de un menú interactivo y sistema de pedidos de un restaurante de Ramen. Proporciona una interfaz estilizada y temática donde el usuario puede registrar nuevas órdenes, visualizar los detalles de cada platillo y organizarlos dentro del catálogo digital.

# Imágenes de presentación del sistema 

| | |
|:---:|:---:|
| <img alt="image" src="https://github.com/user-attachments/assets/07cd4248-9115-4d9b-b148-39d22a70bb34" width="100%" /> | <img alt="image" src="https://github.com/user-attachments/assets/0de2c901-b1f0-425f-a23f-ed78fe096075" width="100%" /> |
| <img alt="image" src="https://github.com/user-attachments/assets/fad46bde-1552-447b-89f2-2dadb5be30eb" width="100%" /> | <img alt="image" src="https://github.com/user-attachments/assets/fab24f4a-8cf3-45ee-b72f-4efff5a43873" width="100%" /> |
| <img alt="image" src="https://github.com/user-attachments/assets/bd10eea5-1e36-4526-b6ba-e9e006017731" width="100%" /> | <img alt="image" src="https://github.com/user-attachments/assets/be46218e-e313-4295-8bbc-beea3eca05b1" width="100%" /> |
| <img alt="image" src="https://github.com/user-attachments/assets/2601d249-06a5-4a2e-b481-40b667e4ce50" width="100%" /> | 









## Tecnologías Utilizadas

El desarrollo de la plataforma se basa en un stack tecnológico robusto que separa la lógica de negocio de la capa de presentación:

* **C#**: Lenguaje principal utilizado para la lógica del servidor, modelos y controladores.
* **.NET**: Framework de desarrollo empleado para estructurar la arquitectura de la aplicación web.
* **HTML / Razor**: Estructura fundamental de las vistas y renderizado dinámico de la interfaz de usuario.
* **CSS**: Definición de estilos, diseño visual temático (Dark Mode) y sistema de Grid responsivo.

## Características Principales

* **Registro de Pedidos/Platillos**: Formulario interactivo para ingresar información relevante sobre cada orden (cliente, platillo, cantidad e instrucciones).
* **Filtrado del Catálogo**: Sistema para buscar y organizar los pedidos activos dependiendo del platillo seleccionado.
* **Visualización Dinámica**: Listado en formato de tarjetas (cards) de los elementos almacenados en el sistema.

## Estructura del Proyecto

La arquitectura sigue el patrón MVC para mantener un código organizado y escalable:

1. **Controladores**: Encargados de gestionar las peticiones del usuario, filtrar los datos y coordinar las respuestas (`CatalogoController`).
2. **Modelos**: Representan la estructura de los datos en el sistema (`Item` / `Pedido`).
3. **Vistas**: Archivos `.cshtml` que definen la experiencia visual del usuario final.

## Instalación y Ejecución

Para ejecutar este proyecto de manera local, es necesario contar con el SDK de .NET instalado. Puedes utilizar tu IDE de preferencia, como JetBrains Rider o Visual Studio.

1. Clonar el repositorio:
   `git clone https://github.com/Josspoot/ArqSoft-S01-Josue.git`
2. Acceder al directorio del proyecto:
   `cd ArqSoft-S01-Josue`
3. Restaurar las dependencias y ejecutar la aplicación:
   `dotnet run`

---

## Cláusula de Uso de Inteligencia Artificial (IA)

En el desarrollo de esta actividad se hizo uso de herramientas de Inteligencia Artificial como asistencia para el desarrollo frontend. Específicamente, la IA fue utilizada para:
* **Diseño CSS y Maquetación**: Generación de la paleta de colores (modo oscuro), la adaptación del sistema *CSS Grid* para la responsividad de las tarjetas y el diseño visual de los componentes de la interfaz.
* **Redacción y Frases Creativas**: Creación de los textos temáticos, descripciones de platillos, chistes orientados a la programación y frases de relleno que acompañan la estructura HTML para darle personalidad al proyecto.

Toda la estructura lógica, arquitectura MVC, controladores y configuración del entorno de .NET fueron implementados y dirigidos de forma personal para cumplir con los lineamientos de la materia.
