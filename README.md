# Native Dark Mode Lib for Winforms

## What this is
This is a library for both .NET Framework 4.7.2 (or any 4.x version) and .NET 9.0 that makes any winforms project fully dark mode, rendered by the system natively.
There is a couple controls that had to be custom rendered. 
- Dark Tab Control
	+ This control replaces that Tab control and has full dark mode functionality. 
	+ The control isnt fully coded yet. Some of the logic either dosent work or is buggy. For example, you cant just click on a tab in the designer, you have to change the selected tab property. The buttons dont auto size to their text either.
	+ Designer is mostly supported, but you cant rearrange the tab buttons. And they will appear at runtime not in the order they appear on the designer.
- Dark DateTime Picker
	+ This control is a fully functional Dark mode replacement to the traditional winforms DateTimePicker control.


# How to use
Simply add a reference to either the .NET Framework version of the library dll, or the .NET version. 
Then add ```Converter.DarkModeEnable(this);``` as the last line of code in any of your Form constructors in your project. 

## Example
```csharp
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using NativeDarkMode_Lib;
using NativeDarkMode_Lib.Utils; // For DarkMessageBox.Show usage. 

namespace YourProjectNamespace
{
    public partial class Form1 : Form
	{
		public Form1()
		{
			// Your Form constructor code here.
			// Inclue any GUI code you need to setup as well. 
			Converter.DarkModeEnable(this);
		}
	}
}
```

## Donation links
Anything is super helpful! Anything donated helps me keep developing this program and others!
- https://www.paypal.com/paypalme/lifeline42
- https://cash.app/$codoen314
