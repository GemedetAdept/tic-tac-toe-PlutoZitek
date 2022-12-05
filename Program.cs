using menudriver;

// CS1400 - Extra Credit, Tic-Tac-Toe
// Pluto Zitek, 2022-12-05

MenuDriver selectionMenu = new MenuDriver();
string[] options = new string[] {

	"New Game",
	"Exit Program",
};
selectionMenu.AddOptions(options);

void mainMenu() {
	while (selectionMenu.menuLoop){

		Console.Clear();
		selectionMenu.DisplayMenu();
		selectionMenu.SetMenuCursor();

		switch(selectionMenu.selectedItem) {

			case 0:
				Console.WriteLine(GameDriver.pieceCross);
				Console.ReadKey();
				continue;
			case 1:
				Environment.Exit(0);
				break;
			default:
				break;
		}
	}
}

mainMenu();