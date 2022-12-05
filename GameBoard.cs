public class GameBoard {

	public const int boardWidth = 3;
	public const int boardHeight = 3;
	static Tile[,] boardState = new Tile[boardWidth, boardHeight];

	public GameBoard() {

		BoardState = boardState;
	}

	public Tile[,] BoardState {
		get {return boardState;}
		set {

			boardState = value;
		}
	}

	public static void Populate(GameBoard board) {

		for (int i = 0; i < boardWidth; i++) {
			for (int j = 0; j < boardHeight; j++) {

				board.BoardState[i,j] = new Tile(i,j);
			}
		}
	}
}