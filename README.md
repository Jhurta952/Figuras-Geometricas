
Figuras Geométricas (Primera Parte)

 Descripción
Este proyecto es una aplicación de escritorio desarrollada en **C# Windows Forms** llamada **Figuras Geométricas**.  
Permite crear y visualizar diferentes figuras geométricas (**Rectángulo y Círculo**) sobre un lienzo gráfico utilizando el control `PictureBox`.

El programa aplica los **principios de la Programación Orientada a Objetos (POO)** — abstracción, herencia, encapsulamiento y polimorfismo — junto con el **patrón de diseño Factory**, que permite crear las figuras sin usar la palabra clave `new` directamente desde el formulario.

Cada figura es un objeto independiente con su propio color, posición y tamaño.  
El usuario puede seleccionar el tipo de figura, elegir un color, definir las coordenadas y visualizar el resultado en el lienzo.  
También se incluye un **contador de figuras creadas** y un **botón de limpieza** que elimina todas las figuras y reinicia el contador.

## ⚙️ Reglas de Negocio Implementadas

- ❌ No se usa `new` en el formulario para crear figuras.  
  Todas se crean mediante `FiguraFactory`.
- ✅ Tamaño debe ser **mayor a 0**.  
- ✅ Las figuras deben ser **completamente visibles** dentro del lienzo.  
- ✅ El **color** debe seleccionarse antes de crear una figura.  
- ✅ El **contador (`txtContador`)** aumenta al crear y se reinicia al limpiar.  
- ✅ El botón **“Limpiar”** borra todas las figuras y deja el lienzo vacío.

---

## 🚀 Ejecución del Programa

1. Ejecutar el proyecto **StickerBoard**.  
2. Seleccionar el **tipo de figura** (Rectángulo o Círculo).  
3. Elegir el **color** haciendo clic en `pbColor`.  
4. Definir la **posición (X, Y)** y el **tamaño**.  
5. Presionar **“Crear”** para dibujar la figura en el lienzo.  
6. Repetir con distintas figuras o colores.  
7. Presionar **“Limpiar”** para borrar todas las figuras y reiniciar el contador.

---

## 📸 Capturas de Pantalla
*(Agrega aquí tus imágenes del formulario funcionando con cada caso de prueba.)*

1. Círculo creado correctamente  
2. Error de tamaño inválido  
3. Varios colores  
4. Contador funcionando  
5. Lienzo limpio  


## 👥 Autores

**Nombre:** Juan Esteban Camacho Hurtado - Alejandro Arias Ramirez
**Institución:** Institución Universitaria Pascual Bravo  
**Materia:** Herramientas de Programación II  
**Docente:** Alexandra Guerrero Bocanegra  
**Semestre:** 3  
**Proyecto:** Evaluación práctica – Polimorfismo (Primera Parte)
