public class GameBoard {

	public static Dictionary<string, string> boardSegments = new Dictionary<string, string> {

		{"boardTop", 
		@" ▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁▁   
		/                                                   /║  
		╔════════════════╦════════════════╦════════════════╗ ║  "},

		{"boardMidDiv", 
		@"╠════════════════╬════════════════╬════════════════╣ ║  "},

		{"boardBottom", 
		@"╚════════════════╩════════════════╩════════════════╝    "},

		{"columnSingle", 
		@"║
		║
		║
		║
		║
		║
		║"},

		{"columnDouble", 
		@"║ ║  
		║ ║  
		║ ║  
		║ ║  
		║ ║  
		║ ║  
		║ ║  "},

		{"columnEnd", 
		@"║ ║  
		║ ║  
		║ ║  
		║ ║  
		║ ║  
		║ ║  
		║ ║  
		║/   "},

		{"squareBlank", 
		@"                
		                
		                
		                
		                
		                
		                "},

		{"squareCross", 
		@"                
		   ██▖    ▗██   
		    ▝██▖▗██▘    
		      ▐██▌      
		    ▗██▘▝██▖    
		   ██▘    ▝██   
		                "},

		{"squareCircle", 
		@"                
		    ▗██████▖    
		    █▘    ▝█    
		    █      █    
		    █▖    ▗█    
		    ▝██████▘    
		                "},

		};

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
}