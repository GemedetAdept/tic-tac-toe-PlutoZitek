public class Tile {

	private int coordX;
	private int coordY;
	// bool isMarked;
	// bool isActive;
	// ConsoleColor markerColor;
	// ConsoleColor tileColor;

	public Tile(int x, int y) {

		CoordX = coordX;
		CoordY = coordY;

		CoordX = x;
		CoordY = y;
	}

	public int CoordX {

		get {return coordX;}
		set {coordX = value;}
	}

	public int CoordY {

		get {return coordY;}
		set {coordY = value;}
	}
}