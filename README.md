# 🧩 Rubik’s Cube Solver – C# Desktop Application

A full-featured **Rubik’s Cube Solver** built with **C# and Windows Forms**, capable of simulating, shuffling, and automatically solving a 3×3 cube using programmed algorithms and heuristic tree search.

---

## ⚙️ Overview
This project visualises and solves a 3×3 Rubik’s Cube within a graphical interface.  
The solver combines **object-oriented cube modelling**, **move simulation**, and **tree-based search algorithms** to automatically determine a valid solution path.

---

## 💻 Features
- 🧠 **Cube Simulation** – interactive GUI to perform moves (F, B, L, R, U, D and inverses)  
- 🎨 **2D Cube Net Rendering** – cube faces drawn dynamically with colour-coded tiles  
- 🔀 **Shuffle Function** – applies a random sequence of moves for testing the solver  
- 🤖 **Automated Solver** – recursively explores cube states using a tree structure (`TreeNode`, `rubik_gen`)  
- ⏱️ **Performance Tracker** – measures solution time and records results in a binary tree (`Times_BimTree`)  
- 💬 **Interface Controls** – buttons for moves, resets, and automated solving within tabbed views  

---

## 🧱 Core Classes

| File | Description |
|------|--------------|
| `rubik_gen.cs` | Defines the cube structure and all face rotations (F, B, L, R, U, D). Handles state copying, hashing, and move generation. |
| `Form1.cs` | Main GUI logic for cube drawing, move handling, shuffling, and solving algorithms. |
| `TreeNode.cs` | Represents each cube state within the search tree, including move history and Manhattan distance scoring. |
| `Times_BimTree.cs` / `Time_taken_node.cs` | Implements a binary search tree to record and display fastest solve times. |
| `Equeue.cs` | Custom generic queue structure for internal state management. |
| `Program.cs` | Entry point for launching the GUI. |

---

## 🧠 Solving Algorithm
The solver uses a **recursive state expansion approach**, generating child cube states for each possible move and tracking those through a **TreeNode structure**.  
Heuristic functions such as **manhattan distance** are used to approximate cube completion and guide solving steps (white cross, corners, middle edges, etc.).

---

## 🧠 Key Learning Outcomes
- Designed and implemented **object-oriented data models** for 3D cube manipulation  
- Developed **recursive tree search algorithms** with state duplication and pruning  
- Built a fully interactive **C# WinForms GUI** for real-time visualisation  
- Applied **heuristics and optimisation** concepts to practical problem-solving  

