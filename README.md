# ImageToGray

ImageToGray es una aplicación de Windows Forms que permite al usuario seleccionar imágenes en formato JPG, JPEG o PNG y aplicar un filtro de escala de grises a cada una de ellas. La aplicación muestra las imágenes originales en un panel y las versiones filtradas en otro panel contiguo.

### Funcionalidad

1. **Selección de Imágenes**: Al hacer clic en el botón "Seleccionar Imágenes", se abre un cuadro de diálogo que permite al usuario seleccionar una o varias imágenes en los formatos admitidos.

2. **Aplicación del Filtro de Escala de Grises**: Una vez seleccionadas las imágenes, al hacer clic en el botón "Convertir", la aplicación procesa cada imagen, convirtiéndola a escala de grises y mostrando la versión filtrada en el panel correspondiente.

3. **Visualización de Imágenes**: Las imágenes originales se muestran en el panel izquierdo, mientras que las imágenes filtradas se muestran en el panel derecho.

4. **Manejo de Errores**: La aplicación maneja posibles errores durante el proceso de conversión de imágenes, mostrando mensajes informativos al usuario en caso de que ocurra algún problema.

### Manejo de Errores

- Si el usuario intenta convertir imágenes sin haber seleccionado ninguna, se muestra un mensaje de error.
- Si ocurre algún error durante el proceso de conversión de una imagen, se muestra un mensaje indicando el problema específico.
- Si una imagen ya ha sido procesada previamente y se intenta volver a procesar, se muestra un mensaje informando al usuario que la versión filtrada ya existe.

### Funciones Adicionales

- **Arrastrar y Soltar el Formulario**: El formulario se puede arrastrar haciendo clic y manteniendo presionado el botón izquierdo del mouse en cualquier área del formulario.
- **Botones de Esquina**: Los botones en la esquina superior derecha permiten minimizar, maximizar y cerrar la aplicación.
- La aplicación utiliza la biblioteca estándar de .NET para manipular imágenes y cuadros de diálogo de selección de archivos.
- Se ha implementado un borde redondeado personalizado para las imágenes mostradas en los paneles.