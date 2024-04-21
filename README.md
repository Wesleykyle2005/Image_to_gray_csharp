# ImageToGray

ImageToGray es una aplicaci�n de Windows Forms que permite al usuario seleccionar im�genes en formato JPG, JPEG o PNG y aplicar un filtro de escala de grises a cada una de ellas. La aplicaci�n muestra las im�genes originales en un panel y las versiones filtradas en otro panel contiguo.

### Funcionalidad

1. **Selecci�n de Im�genes**: Al hacer clic en el bot�n "Seleccionar Im�genes", se abre un cuadro de di�logo que permite al usuario seleccionar una o varias im�genes en los formatos admitidos.

2. **Aplicaci�n del Filtro de Escala de Grises**: Una vez seleccionadas las im�genes, al hacer clic en el bot�n "Convertir", la aplicaci�n procesa cada imagen, convirti�ndola a escala de grises y mostrando la versi�n filtrada en el panel correspondiente.

3. **Visualizaci�n de Im�genes**: Las im�genes originales se muestran en el panel izquierdo, mientras que las im�genes filtradas se muestran en el panel derecho.

4. **Manejo de Errores**: La aplicaci�n maneja posibles errores durante el proceso de conversi�n de im�genes, mostrando mensajes informativos al usuario en caso de que ocurra alg�n problema.

### Manejo de Errores

- Si el usuario intenta convertir im�genes sin haber seleccionado ninguna, se muestra un mensaje de error.
- Si ocurre alg�n error durante el proceso de conversi�n de una imagen, se muestra un mensaje indicando el problema espec�fico.
- Si una imagen ya ha sido procesada previamente y se intenta volver a procesar, se muestra un mensaje informando al usuario que la versi�n filtrada ya existe.

### Funciones Adicionales

- **Arrastrar y Soltar el Formulario**: El formulario se puede arrastrar haciendo clic y manteniendo presionado el bot�n izquierdo del mouse en cualquier �rea del formulario.
- **Botones de Esquina**: Los botones en la esquina superior derecha permiten minimizar, maximizar y cerrar la aplicaci�n.
- La aplicaci�n utiliza la biblioteca est�ndar de .NET para manipular im�genes y cuadros de di�logo de selecci�n de archivos.
- Se ha implementado un borde redondeado personalizado para las im�genes mostradas en los paneles.