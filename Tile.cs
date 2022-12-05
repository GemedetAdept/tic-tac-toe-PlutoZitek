public class Tile {

	int coordX;
	int coordY;
	bool isMarked;
	bool isActive;
	ConsoleColor markerColor;
	ConsoleColor tileColor;

	public Tile(int x, int y) {

		CoordX = coordX;
		CoordY = coordY;
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