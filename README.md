## Unity Transform Tool Cycler

Tired of manually clicking through Unity's transform tools? Speed up your workflow with the **Transform Tool Cycler**! This simple yet effective editor extension allows you to cycle through the **Move, Rotate, Scale, Rect, and Transform** tools using a single hotkey: the **Spacebar**.

### Features:

*   **Effortless Tool Switching:** Cycle through `Move`, `Rotate`, `Scale`, `Rect`, and `Transform` tools with a quick press of the `Spacebar`.
*   **Streamlined Workflow:** Keep your hands on the keyboard and your focus on your scene. No more mouse hunting for tool buttons!
*   **Lightweight & Simple:** A single, easy-to-integrate C# script.
*   **Plug and Play:** Works out of the box after installation.

### Installation

There are two ways to install this tool:

**1. Via Unity Package Manager (Recommended)**

If you have this package hosted on a Git repository (e.g., GitHub), you can install it directly using the Unity Package Manager:

1.  Open your Unity project.
2.  Go to `Window` > `Package Manager`.
3.  Click the `+` (plus) button in the top-left corner of the Package Manager window.
4.  Select `"Add package from git URL..."`.
5.  Enter the Git URL of this repository: `https://github.com/quadraticgames/unitytransformtool.git`.
6.  Click `Add`. Unity will download and install the package.

**2. Manual Installation**

1.  Clone this repository or download the source code.
2.  Copy the entire `com.joestallings.toolcycler` folder (or at least its `Editor` subfolder containing `CycleTransform.cs`) into the `Packages` folder of your Unity project.
    *Alternatively, you can place the `Editor` folder (containing `CycleTransform.cs`) anywhere inside your project's `Assets` folder.*

### How to Use

Once installed (either via UPM or manually), the tool is active:

1.  Ensure you are in the Unity Scene View.
2.  Press the **Spacebar** to cycle through the `Move`, `Rotate`, `Scale`, `Rect`, and `Transform` tools.

### Why Use Transform Tool Cycler?

*   **Boost Productivity:** Spend less time switching tools and more time creating.
*   **Enhanced Ergonomics:** Reduce repetitive mouse movements.
*   **Intuitive Control:** A common hotkey for a common task.

Perfect for any Unity developer looking to optimize their scene editing process.

---

*Consider adding a license (e.g., MIT) to your project if you plan to share it widely.*
