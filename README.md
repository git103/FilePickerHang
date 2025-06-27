**Title:** FilePicker.PickAsync Task Hangs When User Swipes Down to Cancel the Picker

**Description:**  
When using FilePicker.PickAsync in a .NET MAUI application, if the user cancels the file picker by swiping to close, the task does not complete and remains in a hanging state. This behavior prevents proper handling of cancellation and leaves tasks in an incomplete state.

**Steps to Reproduce:**  
Run the provided code on an iOS device or emulator.  
Click the button to open the file picker.  
Cancel the file picker without selecting a file (by swiping down to close the picker).  
Observe that the task remains in a hanging state.  

**Expected Behavior:**  
The task should complete and return null when the user cancels the file picker.

**Actual Behavior:**  
The task remains in a pending state indefinitely.

**Environment:**  
.NET MAUI version: 9.0.80
.NET version: 9.0
Target platform: iOS
Devices: iOS < 16

**Additional Context:**  
This issue occurs specifically when the user cancels the picker by swiping to close. The cancel button works correctly and the issue also does not occur when a file is successfully picked.  
This issue only seems to affects older iOS versions, so devices < iOS 16.
