# UnityLocalization
tool for localization (language support) in unity 
This was modified from the Unity tutorial on Localization - https://unity3d.com/learn/tutorials/topics/scripting/overview-and-goals?playlist=17117

they used a String - String dictionary , I don't like remembering strings to look up other strings so
I built on their code by creating a LocalizationEnum Key which contains a list of all the potential things.

To use:

- Place the editor script in your Editor Folder,  
- rewrite the LocalizationEnum to contain the things you care about, I numbered all of the items and gave myself plenty of room for unknown-unknowns I may add to the app later on
- go to Window > Localization Text Editor and populate your data (or use a spreadsheet to create the JSON , will make translating easier later on)
- save it in StreamingAssets
- put LocalizedText script on any text object and pick which of the Enums it should be 


