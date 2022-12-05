using Microsoft.VisualBasic;
using System.IO;
using System.Text;
Console.OutputEncoding = Encoding.Unicode;

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
				unitTest();
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

void unitTest() {

	GameBoard newBoard = new GameBoard();

	void Populate(GameBoard board) {

		for (int i = 0; i < GameBoard.boardWidth; i++) {
			for (int j = 0; j < GameBoard.boardHeight; j++) {

				board.BoardState[i,j] = new Tile(i,j);
			}
		}
	}

	Populate(newBoard);

	foreach (Tile tile in newBoard.BoardState) {

		Console.WriteLine($"{tile.CoordX}, {tile.CoordY}");
	}
}