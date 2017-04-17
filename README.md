# UnityLocalization
tool for localization (language support) in unity 
This was modified from the Unity tutorial on Localization - https://unity3d.com/learn/tutorials/topics/scripting/overview-and-goals?playlist=17117

they used a String-on-String dictionary, I don't like remembering strings to look up other strings or the risk of making typos so
I built on their code by creating a LocalizationEnum Key which contains a list of all the potential things:
```c#
[System.Serializable]
public class LocalizationEnum
{
	public enum Key{
		Menu_Title = 0,
		Menu_Quit = 1,
    
		Common_Stop = 50,
		Common_Go = 51,
		Common_Yes = 52,
		Common_No = 53,
    
		Panel_Something_Title = 100,
    
		Lorem_Lorem = 250,
		Lorem_OrangePeel = 251,
		Lorem_Cake = 252,
		Lorem_Donut = 253,
    
	}
}

```

To use:

- Place the editor script in your Editor Folder,  
- rewrite the LocalizationEnum to contain the things you care about, I numbered all of the items and gave myself plenty of room for unknown-unknowns I may add to the app later on
- go to Window > Localization Text Editor and populate your data (or use a spreadsheet to create the JSON , will make translating easier later on)
- save it in StreamingAssets
- put LocalizedText script on any text object and pick which of the Enums it should be 


