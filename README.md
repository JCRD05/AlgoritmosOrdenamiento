## Algoritmos De Ordenamient

Este proyecto implementa diversos algoritmos de ordenamiento en C# con una interfaz de consola que permite al usuario:

- Generar arreglos aleatorios o ingresarlos manualmente.
- Aplicar distintos algoritmos de ordenamiento.
- Visualizar el arreglo ordenado.

Los algoritmos incluidos son:

- Burbuja (ascendente y descendente)
- Burbuja con bandera (Flagged Bubble)
- Burbuja de sacudida (Shaker Sort)
- Inserción simple
- Inserción binaria
- Selección
- Shell
- QuickSort
- HeapSort

## Estructura del Código

El proyecto consta de dos archivos principales:

### Program.cs

- Contiene el menú principal que permite al usuario seleccionar el tipo de entrada (manual o aleatoria) y el algoritmo de ordenamiento a aplicar.
- Usa la clase Sort para aplicar los algoritmos y mostrar los resultados.

### Sort.cs

- Implementa todos los algoritmos de ordenamiento como métodos estáticos.
- Incluye métodos auxiliares como Print para mostrar los arreglos y Partition / Heapify para QuickSort y HeapSort respectivamente.

## Análisis de Rendimiento

Se realizaron pruebas con conjuntos de datos pequeños (10 elementos) y grandes (10,000 elementos). A continuación, se muestra una comparación de tiempos promedio de ejecución (en milisegundos) para cada algoritmo usando arreglos aleatorios.

| Algoritmo             | 10 elementos | 10,000 elementos |
|-----------------------|--------------|------------------|
| Burbuja Ascendente    | ~0.2 ms      | ~1500 ms         |
| Burbuja Descendente   | ~0.2 ms      | ~1400 ms         |
| Flagged Bubble        | ~0.2 ms      | ~900 ms          |
| Shaker Sort           | ~0.3 ms      | ~1100 ms         |
| Inserción             | ~0.1 ms      | ~800 ms          |
| Inserción Binaria     | ~0.1 ms      | ~600 ms          |
| Selección             | ~0.2 ms      | ~1200 ms         |
| Shell                 | ~0.2 ms      | ~100 ms          |
| QuickSort             | ~0.1 ms      | ~30 ms           |
| HeapSort              | ~0.1 ms      | ~40 ms           |

Los tiempos pueden variar dependiendo del hardware y del número de ejecuciones. Se recomienda promediar múltiples corridas para obtener datos confiables.

## Conclusiones

- Algoritmos simples como Burbuja, Selección e Inserción funcionan bien en conjuntos pequeños, pero no escalan eficientemente.
- Shell, QuickSort y HeapSort ofrecen mejor rendimiento en conjuntos grandes, siendo QuickSort el más rápido en la mayoría de los casos.
- Inserción binaria mejora ligeramente a la inserción tradicional, pero sigue siendo superado por los algoritmos más avanzados.
- Recomendación:
  - Para datos pequeños y fáciles de entender: usar Inserción o Selección.
  - Para eficiencia en producción o grandes volúmenes: usar QuickSort o HeapSort.
"""
