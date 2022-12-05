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

	private string[,] boardState = new string[3,3];

	public GameBoard() {

		BoardState = boardState;
	}

	public string[,] BoardState {
		get {return boardState;}
		set {

			boardState = value;
		}
	}
}