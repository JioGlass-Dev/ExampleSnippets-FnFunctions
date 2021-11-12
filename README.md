# FnFunctions
Example of Fn1 and Fn2 button implementation of JMRSDK

## Scripts 

### `FnButtons.cs`
Shows example of accessing callbacks called during touchpad click (Fn1) and touchpad double click (Fn2) button press.</br>
- Interfaces to implement Fn1 and Fn2 funtionalities
```cs
public class ButtonManager : MonoBehaviour, IBackHandler, IHomeHandler, IMenuHandler
```

## How to use?
1. Download and unzip this project.
2. Open the project using Unity Hub.
3. Download and import the latest version of JMRSDK package.
4. Open and play the FnButtons scene from Assets/Scenes folder.
