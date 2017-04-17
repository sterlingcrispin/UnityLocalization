[System.Serializable]
public class LocalizationData 
{
	public LocalizationItem[] items;
}

[System.Serializable]
public class LocalizationItem
{
	public LocalizationEnum.Key key;
	public string value;
}

[System.Serializable]
public class LocalizationEnum
{
	public enum Key{
		Menu_Title = 0,
		Menu_Quit = 1,
		Menu_Load = 2,
		Menu_Save = 3,
		Menu_Options = 4,
		Menu_Windows = 5,

		Common_Stop = 50,
		Common_Go = 51,
		Common_Yes = 52,
		Common_No = 53,

		Panel_Something_Title = 100,

		Panel_Foo_Bakery = 102,
		Panel_Foo_Hospital = 106,
		Panel_Foo_Bridge = 107,
		Panel_Foo_Waterfall = 108,

		Panel_Monkey_Title = 200,

		Lorem_Lorem = 250,
		Lorem_OrangePeel = 251,
		Lorem_Cake = 252,
		Lorem_Donut = 253,


		Tooltip_Move = 301,
		Tooltip_Close = 302,

		Panel_Whatever_Title = 500,

	}
}