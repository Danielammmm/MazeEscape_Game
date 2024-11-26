# MazeEscape_Game
# **Maze Escape**

## **Descripción**
**Maze Escape** es un juego desarrollado en **C#** como aplicación de consola, donde el jugador debe navegar a través de un laberinto para alcanzar el final mientras evita obstáculos y enemigos. El juego incluye tres niveles de dificultad, cada uno con un tablero de diferentes dimensiones y características. El objetivo principal es completar el nivel antes de que el punteo llegue a cero.

## **Características principales**
- **Tres niveles de dificultad:**
  - **Nivel 1:** Tablero 8x8 con 25 obstáculos y 10 enemigos.
  - **Nivel 2:** Tablero 10x10 con 50 obstáculos y 15 enemigos.
  - **Nivel 3:** Tablero 12x12 con 70 obstáculos y 30 enemigos.
- Sistema de puntuación inicial de 10 puntos, que aumenta o disminuye según las acciones del jugador.
- Comandos intuitivos para mover al personaje y atacar enemigos.
- Generación aleatoria de obstáculos, enemigos y posición final.

## **Instrucciones de uso**
1. Al iniciar el juego, elige una de las siguientes opciones:
   - `a` para el nivel 1.
   - `b` para el nivel 2.
   - `c` para el nivel 3.
   - `d` para salir.
2. Durante el juego, utiliza los siguientes comandos:
   - **Movimientos:**
     - `u`: Mover hacia arriba.
     - `d`: Mover hacia abajo.
     - `r`: Mover hacia la derecha.
     - `l`: Mover hacia la izquierda.
   - **Ataques:**
     - `j`: Atacar a la izquierda.
     - `k`: Atacar hacia abajo.
     - `i`: Atacar hacia arriba.
     - `l`: Atacar a la derecha.
3. Evita los obstáculos y enfrenta a los enemigos para llegar al final del laberinto.

## **Tecnologías utilizadas**
- **Lenguaje:** C#
- **Entorno de desarrollo:** Visual Studio
- **Paradigma:** Programación estructurada con procedimientos y funciones reutilizables.

## **Diagrama de flujo**
El diseño del juego sigue un flujo lógico que asegura la interacción dinámica del jugador con el entorno del laberinto, procesando entradas de movimiento y generando salidas en tiempo real.

## **Próximas mejoras**
- Implementación de un sistema de guardado de progreso.
- Gráficos simples en 2D para mejorar la experiencia visual.
- Ampliación de niveles y personalización de personajes.

## **Cómo ejecutar el proyecto**
1. Clona este repositorio:  
   ```bash
   git clone https://github.com/tu-usuario/maze-escape.git
